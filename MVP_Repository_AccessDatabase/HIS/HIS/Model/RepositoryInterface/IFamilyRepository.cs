using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Model
{
    public interface IFamilyRepository : IRepository<Family>
    {
        #region Menus
        List<String> diabetesMenu { get; }
        #endregion
        #region Get
        Family GetByPidAndSavedate(Double id, DateTime saveDate);
        Family GetNewestEntity(Double id);
        Family GetNewEntity(
            Double pid, DateTime saveDate,
            Boolean stroke = false, Boolean cad = false,
            Boolean mi = false, Boolean father = false,
            Boolean mother = false, Boolean notsure = false,
            String diabetesType = null, Boolean breast = false, 
            Boolean liver = false, Boolean gastric = false,
            Boolean colon = false, Boolean skin = false,
            Boolean lung = false, String cancerOthers = null);
        #endregion
    }
}
