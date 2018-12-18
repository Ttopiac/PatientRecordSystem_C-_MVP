using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.Objects;

namespace HIS.Model
{
    internal class OccupationRepository : AdoRepository<Occupation>, IOccupationRepository
    {
        public OccupationRepository(string connectionString, IHISDataset hisDataset)
            : base(connectionString, "OCCUPATION", hisDataset)
        {
        }
        public List<String> occupationNameList
        {
            get
            {
                return (from o in GetAll() orderby o.Name select o.Name.Trim()).ToList();
            }
        }
        #region Get
        #endregion
        public override Occupation PopulateRecord(OleDbDataReader reader)
        {
            return new Occupation
            {
                Name = (reader.IsDBNull(0) == true ? null : reader.GetString(0)),
                ID = reader.GetInt32(1),
            };
        }
    }
}
