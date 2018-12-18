using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.Objects;

namespace HIS.Model
{
    internal class VillageRepository : AdoRepository<Village>, IVillageRepository
    {
        public VillageRepository(string connectionString, IHISDataset hisDataset)
            : base(connectionString, "VILLAGE", hisDataset)
        {
        }
        public List<String> villageNameList
        {
            get
            {
                return (from v in GetAll() orderby v.Name select v.Name.Trim()).ToList();
            }
        }
        #region Get
        #endregion
        public override Village PopulateRecord(OleDbDataReader reader)
        {
            return new Village
            {
                Name = (reader.IsDBNull(0) == true ? null : reader.GetString(0)),
                ID = reader.GetInt32(1),
            };
        }
    }
}
