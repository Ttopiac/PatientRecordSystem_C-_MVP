using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Model
{
    public interface IHabitRepository : IRepository<Habit>
    {
        #region Menus
        List<String> yearMenu { get; }
        List<String> freqMenu { get; }
        void SetYearMenu(Int32 birthYear);
        #endregion
        #region Get
        Habit GetByPidAndSavedate(Double id, DateTime saveDate);
        Habit GetNewestEntity(Double id);
        Habit GetNewEntity(
            Double pid, DateTime saveDate,
            Boolean smoke = false, String smoke_year = null, String smoke_roll = null, String smoke_describe = null,
            Boolean alcohol = false, String alcohol_year = null, String alcohol_roll = null, String alcohol_describe = null,
            Boolean kava = false, String kava_year = null, String kava_roll = null, String kava_describe = null,
            Boolean healthyDiet = false, String diet_describe = null,
            Boolean exercise = false, String exercise_freq = null);
        #endregion
    }
}
