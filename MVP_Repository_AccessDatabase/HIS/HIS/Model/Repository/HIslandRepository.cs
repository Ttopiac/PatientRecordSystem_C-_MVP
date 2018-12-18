using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.Objects;

namespace HIS.Model
{
    internal class HIslandRepository : AdoRepository<HomeIsalnd>, IHIslandRepository
    {
        public HIslandRepository(string connectionString, IHISDataset hisDataset)
            : base(connectionString, "HOMEISLAND", hisDataset)
        {
        }
        public List<String> hIslandNameList
        {
            get
            {
                return (from h in GetAll() orderby h.Name select h.Name.Trim()).ToList();
            }
        }
        #region Get
        #endregion
        public override HomeIsalnd PopulateRecord(OleDbDataReader reader)
        {
            return new HomeIsalnd
            {
                Name = (reader.IsDBNull(0) == true ? null : reader.GetString(0)),
                ID = reader.GetInt32(1),
            };
        }
    }
}
