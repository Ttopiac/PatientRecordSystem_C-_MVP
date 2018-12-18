using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System;
using System.Linq;
using HIS.Model;
namespace HIS.Model
{
    public abstract class AdoRepository<T> : IUnitOfWorkRepository where T : class
    {
        private OleDbConnection _connection;
        public string _tableName;
        protected IHISDataset _hisDataset;
        public AdoRepository(string connectionString, string tablename, IHISDataset hisDataset)
        {
            _connection = new OleDbConnection(connectionString);
            _tableName = tablename;
            _hisDataset = hisDataset;
        }
        public virtual T PopulateRecord(OleDbDataReader reader)
        {
            return null;
        }
        protected IEnumerable<T> GetRecords(OleDbCommand command)
        {
            var list = new List<T>();
            command.Connection = _connection;
            _connection.Open();
            try
            {
                var reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                        list.Add(PopulateRecord(reader));
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            finally
            {
                _connection.Close();
            }
            return  list;
        }
        protected T GetRecord(OleDbCommand command)
        {
            T record = null;
            command.Connection = _connection;
            _connection.Open();
            try
            {
                var reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        record = PopulateRecord(reader);
                        break;
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            finally
            {
                _connection.Close();
            }
            return record;
        }
        protected IEnumerable<T> ExecuteStoredProc(OleDbCommand command)
        {
            var list = new List<T>();
            command.Connection = _connection;
            command.CommandType = CommandType.StoredProcedure;
            _connection.Open();
            try
            {
                var reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        var record = PopulateRecord(reader);
                        if (record != null) list.Add(record);
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            finally
            {
                _connection.Close();
            }
            return list;
        }
        protected void ExecuteCommand(OleDbCommand command)
        {
            command.Connection = _connection;
            command.CommandType = CommandType.Text;
            _connection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            //catch (OleDbException)
            //{
            //    Console.WriteLine("Excepted Command: " + command.CommandText);
            //    Console.WriteLine("Exception Message: The changes you requested to the table were not successful because they would create duplicate values in the index, primary key, or relationship.");
            //}
            finally
            {
                _connection.Close();
            }
        }
        public T GetByPidAndSavedate(double pid, DateTime savedate)
        {
            using (
                var command = new OleDbCommand(
                String.Format("SELECT * FROM {0} WHERE pid=@pid and savedate=@date",
                            _tableName)))
            {
                command.Parameters.Add("@pid", OleDbType.Double).Value = pid;
                command.Parameters.Add("@date", OleDbType.Date).Value = savedate;
                return GetRecord(command);
            }
        }
        public T GetNewestEntity(double pid)
        {
            using (
                var command = new OleDbCommand(
                String.Format("SELECT TOP 1 * FROM {0} WHERE pid=@pid ORDER BY savedate DESC",
                            _tableName)))
            {
                command.Parameters.Add("@pid", OleDbType.Double).Value = pid;
                return GetRecord(command);
            }
        }
        public IEnumerable<T> GetAll()
        {
            using (
                var command = new OleDbCommand(String.Format("SELECT * FROM {0}", 
                    _tableName)))
            {
                return GetRecords(command);
            }
        }
        #region Register CUD(Create, Update, Delete)
        public void Create(IEntityWithReocord _t, String clinic, Int32 oper)
        {
            _hisDataset.RegisterCreation((IAggregateRoot)_t, this);
            Record r = _hisDataset.recordRepository.GetNewEntity(
                _t.PID, _t.SaveDate, clinic, oper, _t.GetType().Name.ToUpper());
            _hisDataset.recordRepository.Create(r);
        }
        public void Update(IEntityWithReocord _t, String clinic, Int32 oper)
        {
            _hisDataset.RegisterUpdate((IAggregateRoot)_t, this);
            Record r = _hisDataset.recordRepository.GetByKey(
                _t.PID, _t.SaveDate, _t.GetType().Name.ToUpper());
            if (r == null)
            {
                r = _hisDataset.recordRepository.GetNewEntity(
                    _t.PID, _t.SaveDate, clinic, oper, _t.GetType().Name.ToUpper());
                _hisDataset.recordRepository.Create(r);
            }
        }
        public void Delete(IEntityWithReocord _t, String clinic, Int32 oper)
        {
            _hisDataset.RegisterUpdate((IAggregateRoot)_t, this);
            Record r = _hisDataset.recordRepository.GetByKey(
                _t.PID, _t.SaveDate, _t.GetType().Name.ToUpper());
            if (r != null)
            {
                _hisDataset.recordRepository.Delete(r);
            }
        }
        public void Create(IAggregateRoot _t)
        {
            _hisDataset.RegisterCreation((IAggregateRoot)_t, this);
        }
        public void Update(IAggregateRoot _t)
        {
            _hisDataset.RegisterUpdate((IAggregateRoot)_t, this);
        }
        public void Delete(IAggregateRoot _t)
        {
            _hisDataset.RegisterDeletion((IAggregateRoot)_t, this);
        }
        #endregion
        #region Persist CUD(Create, Update, Delete)
        public void PersistCreationOf(IAggregateRoot entity)
        {
            var builder = new SqlQueryBuilder<T>((T)entity);
            ExecuteCommand(builder.GetInsertCommand());
        }
        public void PersistUpdateOf(IAggregateRoot entity)
        {
            var builder = new SqlQueryBuilder<T>((T)entity);
            ExecuteCommand(builder.GetUpdateCommand());
        }
        public void PersistDeletionOf(IAggregateRoot entity)
        {
            var builder = new SqlQueryBuilder<T>((T)entity);
            ExecuteCommand(builder.GetDeleteCommand());
        }
        #endregion
    }
}