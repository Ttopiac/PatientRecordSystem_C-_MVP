using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.Objects;

namespace HIS.Model
{
    internal class ClinicRepository : AdoRepository<Clinic>, IClinicRepository
    {
        public ClinicRepository(string connectionString, IHISDataset hisDataset)
            : base(connectionString, "CLINIC", hisDataset)
        {
        }
        public List<String> clinicNameList
        {
            get
            {
                return (from c in GetAll() orderby c.Name select c.Name).ToList();
            }
        }
    
        #region Get
        #endregion
        public override Clinic PopulateRecord(OleDbDataReader reader)
        {
            return new Clinic
            {
                Name = (reader.IsDBNull(0) == true ? null : reader.GetString(0)),
                Pnum = reader.GetInt32(1),
                ID = reader.GetInt32(2)
            };
        }
    }
}
