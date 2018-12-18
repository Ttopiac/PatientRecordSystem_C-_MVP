using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using HIS.FunctionLibrary;

namespace HIS.Model
{
    public class FamilyRepository : AdoRepository<Family>, IFamilyRepository
    {
        public FamilyRepository(string connectionString, IHISDataset hisDataSet)
            : base(connectionString, "FAMILY", hisDataSet)
        {
        }
        #region Menus
        private List<String> diabetes = 
            new List<String>()
            { "Type-1 Diabetes", "Type-2 Diabetes", "Gestation Diabetes", "Not Sure"};
        public List<String> diabetesMenu
        {
            get
            {
                var list = diabetes;
                list.Remove("");
                list.Insert(0, "");
                return list;
            }
        }
        #endregion
        #region Get
        public Family GetNewEntity(
            Double pid, DateTime saveDate,
            Boolean stroke = false, Boolean cad = false,
            Boolean mi = false, Boolean father = false,
            Boolean mother = false, Boolean notsure = false,
            String diabetesType = null, Boolean breast = false,
            Boolean liver = false, Boolean gastric = false,
            Boolean colon = false, Boolean skin = false,
            Boolean lung = false, String cancerOthers = null)
        {
            return new Family
            {
                PID = pid,
                SaveDate = saveDate,
                Stroke = stroke,
                CAD = cad,
                MI = mi,
                Father = father,
                Mother = mother,
                NotSure = notsure,
                DiabetesType = diabetesType,
                Breast = breast,
                Liver = liver,
                Gastric = gastric,
                Colon = colon,
                Skin = skin,
                Lung = lung,
                CancerOthers = cancerOthers
            };
        }
        #endregion
        public override Family PopulateRecord(OleDbDataReader reader)
        {
            return new Family
            {
                PID = reader.GetDouble(0),
                SaveDate = reader.GetDateTime(1),
                Stroke = reader.GetBoolean(2),
                CAD = reader.GetBoolean(3),
                MI = reader.GetBoolean(4),
                Father = reader.GetBoolean(5),
                Mother = reader.GetBoolean(6),
                NotSure = reader.GetBoolean(7),
                DiabetesType = reader.IsDBNull(8) == true ? null : reader.GetString(8),
                Breast = reader.GetBoolean(9),
                Liver = reader.GetBoolean(10),
                Gastric = reader.GetBoolean(11),
                Colon = reader.GetBoolean(12),
                Skin = reader.GetBoolean(13),
                Lung = reader.GetBoolean(14),
                CancerOthers = reader.IsDBNull(15) == true ? null : reader.GetString(15)
            };
        }


    }
}
