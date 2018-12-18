using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.Objects;

namespace HIS.Model
{
    internal class System_InfoRepository : AdoRepository<System_Info>, ISystem_InfoRepository
    {
        public System_InfoRepository(string connectionString, IHISDataset hisDataset)
            : base(connectionString, "SYSTEM_INFO", hisDataset)
        {
        }
        #region Get
        public System_Info GetById(Int32 id)
        {
            using (var command = new OleDbCommand(
                        String.Format("SELECT * FROM {0} WHERE SID = {1}",
                        _tableName, "?")))
            {
                command.Parameters.Add(new OleDbParameter("SID", id));
                return GetRecord(command);
            }
        }
        #endregion
        public override System_Info PopulateRecord(OleDbDataReader reader)
        {
            return new System_Info
            {
                Clinic = reader.IsDBNull(0)==true?null: reader.GetString(0),
                LastUpdateDate = reader.GetDateTime(1),
                PermanentID = reader.GetInt32(2),
                SID = reader.GetInt32(3)
            };
        }
    }
}
