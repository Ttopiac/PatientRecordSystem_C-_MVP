using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.Objects;

namespace HIS.Model
{
    internal class RecordRepository : AdoRepository<Record>, IRecordRepository
    {
        public RecordRepository(string connectionString, IHISDataset hisDataset)
            : base(connectionString, "RECORD", hisDataset)
        {
        }
        #region Get
        public Record GetByKey(Double id, DateTime date, String tableName)
        {
            var record = from r in GetAll()
                          where r.PID == id 
                          && r.SaveDate == date
                          && r.TableName.ToLower() == tableName.ToLower()
                         select r;
            if (record.Count() == 0) { return null; }
            else { return record.First(); }
        }
        public Record GetNewEntity(Double id, DateTime date, String clinic, Int32 oper, String tableName)
        {
            return new Record
            {
                PID = id,
                SaveDate = date,
                Clinic = clinic,
                Operator = oper,
                TableName = tableName
            };
        }
        #endregion

        public override Record PopulateRecord(OleDbDataReader reader)
        {
            return new Record
            {
                PID = reader.GetDouble(0),
                SaveDate = reader.GetDateTime(1),
                Clinic = reader.IsDBNull(2) == true ? null : reader.GetString(2),
                Operator = reader.GetInt32(3),
                TableName = reader.IsDBNull(4) == true ? null : reader.GetString(4)
            };
        }
    }
}
