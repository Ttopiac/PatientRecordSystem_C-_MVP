using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using HIS.FunctionLibrary;

namespace HIS.Model
{
    public class HabitRepository : AdoRepository<Habit>, IHabitRepository
    {
        public HabitRepository(string connectionString, IHISDataset hisDataSet)
            : base(connectionString, "HABIT", hisDataSet)
        {
        }
        #region Menus
        private List<String> freq = 
            (Enumerable.Range(1, 15).Select(x => (x - 1) + 1)).ToList().
            ConvertAll<string>(x => x.ToString());
        private List<String> years = null;
        public void SetYearMenu(Int32 birthYear)
        {
            years = 
                (Enumerable.Range(birthYear, DateTime.Now.Year- birthYear+1).Select(x => (x - 1) + 1)).ToList().
                ConvertAll<string>(x => x.ToString());
        }
        public List<String> yearMenu
        {
            get
            {
                if (years == null)
                { years = _hisDataset.profileRepository.bYearMenu; }
                var list = years;
                list.Remove("");
                list.Insert(0, "");
                return list;
            }
        }
        public List<String> freqMenu
        {
            get
            {
                var list = freq;
                list.Remove("");
                list.Insert(0, "");
                return list;
            }
        }
        #endregion
        # region Get
        public Habit GetNewEntity(
            Double pid, DateTime saveDate, 
            Boolean smoke = false, String smoke_year = null, String smoke_roll = null, String smoke_describe = null,
            Boolean alcohol = false, String alcohol_year = null, String alcohol_bottle = null, String alcohol_describe = null,
            Boolean kava = false, String kava_year = null, String kava_bottle = null, String kava_describe = null,
            Boolean healthyDiet = false, String diet_describe = null,
            Boolean exercise = false, String exercise_freq = null)
        {
            return new Habit
            {
                PID = pid,
                SaveDate = saveDate,
                Smoke = smoke,
                Smoke_year = smoke_year,
                Smoke_roll = smoke_roll,
                Smoke_describe = smoke_describe,
                Alcohol = alcohol,
                Alcohol_year = alcohol_year,
                Alcohol_bottle = alcohol_bottle,
                Alcohol_describe = alcohol_describe,
                Kava = kava,
                Kava_year = kava_year,
                Kava_bottle = kava_bottle,
                Kava_describe = kava_describe,
                HealthyDiet = healthyDiet,
                Diet_describe = diet_describe,
                Exercise = exercise,
                Exercise_freq = exercise_freq
            };
        }
        #endregion
        public override Habit PopulateRecord(OleDbDataReader reader)
        {
            return new Habit
            {
                PID = reader.GetDouble(0),
                SaveDate = reader.GetDateTime(1),
                Smoke = reader.GetBoolean(2),
                Smoke_year = reader.IsDBNull(3) == true ? null : reader.GetString(3),
                Smoke_roll = reader.IsDBNull(4) == true ? null : reader.GetString(4),
                Smoke_describe = reader.IsDBNull(5) == true ? null : reader.GetString(5),
                Alcohol = reader.GetBoolean(6),
                Alcohol_year = reader.IsDBNull(7) == true ? null : reader.GetString(7),
                Alcohol_bottle = reader.IsDBNull(8) == true ? null : reader.GetString(8),
                Alcohol_describe = reader.IsDBNull(9) == true ? null : reader.GetString(9),
                Kava = reader.GetBoolean(10),
                Kava_year = reader.IsDBNull(11) == true ? null : reader.GetString(11),
                Kava_bottle = reader.IsDBNull(12) == true ? null : reader.GetString(12),
                Kava_describe = reader.IsDBNull(13) == true ? null : reader.GetString(13),
                HealthyDiet = reader.GetBoolean(14),
                Diet_describe = reader.IsDBNull(15) == true ? null : reader.GetString(15),
                Exercise = reader.GetBoolean(16),
                Exercise_freq = reader.IsDBNull(17) == true ? null : reader.GetString(17)
            };
        }


    }
}
