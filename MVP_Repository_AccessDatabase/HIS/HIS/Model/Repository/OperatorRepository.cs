using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.Objects;

namespace HIS.Model
{
    internal class OperatorRepository : AdoRepository<Operator>, IOperatorRepository
    {
        public OperatorRepository(string connectionString, IHISDataset hisDataSet)
            : base(connectionString, "OPERATOR", hisDataSet)
        {
        }
        #region Get
        public Operator GetById(Int32 id)
        {
            using (var command = new OleDbCommand(
                        String.Format("SELECT * FROM {0} WHERE OID = {1}", 
                        _tableName, "?")))
            {
                command.Parameters.Add(new OleDbParameter("OID", id));
                return GetRecord(command);
            }
        }
        public Operator GetByUsernameAndPswd(String username, String pswd)
        {

            using (var command = new OleDbCommand(
                        String.Format("SELECT * FROM {0} WHERE username = {1} and pswd = {2}", 
                        _tableName, "?", "?")))
            {
                command.Parameters.Add(new OleDbParameter("username", username));
                command.Parameters.Add(new OleDbParameter("pswd", pswd));
                return GetRecord(command);
            }
        }
        #endregion
        public override Operator PopulateRecord(OleDbDataReader reader)
        {
            return new Operator
            {
                OID = reader.GetInt32(0),
                SaveDate = reader.GetDateTime(1),
                FName = (reader.IsDBNull(2)==true?null:reader.GetString(2)),
                SName = (reader.IsDBNull(3) == true ? null : reader.GetString(3)),
                Username = (reader.IsDBNull(4) == true ? null : reader.GetString(4)),
                Pswd = (reader.IsDBNull(5) == true ? null : reader.GetString(5)),
                EnrollFingers = reader.GetInt16(6),
                LastLogin = reader.GetDateTime(7)
            };
        }
    }
}
