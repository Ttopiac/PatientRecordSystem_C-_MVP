using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.Objects;

namespace HIS.Model
{
    internal class ReligionRepository : AdoRepository<Religion>, IReligionRepository
    {
        public ReligionRepository(string connectionString, IHISDataset hisDataset)
            : base(connectionString, "RELIGION", hisDataset)
        {
        }
        public List<String> religionNameList
        {
            get
            {
                return (from r in GetAll() orderby r.Name select r.Name.Trim()).ToList();
            }
        }
        #region Get
        #endregion
        public override Religion PopulateRecord(OleDbDataReader reader)
        {
            return new Religion
            {
                Name = (reader.IsDBNull(0) == true ? null : reader.GetString(0)),
                ID = reader.GetInt32(1),
            };
        }
    }
}
