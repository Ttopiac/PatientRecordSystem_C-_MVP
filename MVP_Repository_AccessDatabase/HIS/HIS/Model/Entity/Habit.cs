using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HIS.Model
{
    [Table("HABIT")]
    public class Habit : IAggregateRoot, IEntityWithReocord
    {
        [Key, Column(Order = 0)]
        public Double PID { get; set; }
        [Key, Column(Order = 1)]
        public DateTime SaveDate { get; set; }
        public Boolean Smoke { get; set; }
        public String Smoke_year { get; set; }
        public String Smoke_roll { get; set; }
        public String Smoke_describe { get; set; }
        public Boolean Alcohol { get; set; }
        public String Alcohol_year { get; set; }
        public String Alcohol_bottle { get; set; }
        public String Alcohol_describe { get; set; }
        public Boolean Kava { get; set; }
        public String Kava_year { get; set; }
        public String Kava_bottle { get; set; }
        public String Kava_describe { get; set; }
        public Boolean HealthyDiet { get; set; }
        public String Diet_describe { get; set; }
        public Boolean Exercise { get; set; }
        public String Exercise_freq { get; set; }
        public Boolean ConvertSmokeStatus(String smokeDescribe)
        {
            switch (smokeDescribe)
            {
                case "A":
                case "B":
                case "C":
                    return false;
                case "D":
                case "E":
                    return true;
            }
            return false;
        }
        public String ConvertSmokeDescribeCode(String smokeDescribe)
        {
            switch (smokeDescribe)
            {
                case "Never Smoked":
                    return "A";
                case "Stopped > a year":
                    return "B";
                case "Passive Smoker":
                    return "C";
                case "Stopped < a year":
                    return "D";
                case "Smoker":
                    return "E";
            }
            return "";
        }
        public Boolean IsEqual(Habit other)
        {
            if (other == null)
                return false;
            return this.PID == other.PID
                && this.Smoke == other.Smoke
                && (this.Smoke_year == other.Smoke_year || (String.IsNullOrEmpty(this.Smoke_year) && String.IsNullOrEmpty(other.Smoke_year)))
                && (this.Smoke_roll == other.Smoke_roll || (String.IsNullOrEmpty(this.Smoke_roll) && String.IsNullOrEmpty(other.Smoke_roll)))
                && (this.Smoke_describe == other.Smoke_describe || (String.IsNullOrEmpty(this.Smoke_describe) && String.IsNullOrEmpty(other.Smoke_describe)))
                && this.Alcohol == other.Alcohol
                && (this.Alcohol_year == other.Alcohol_year || (String.IsNullOrEmpty(this.Alcohol_year) && String.IsNullOrEmpty(other.Alcohol_year)))
                && (this.Alcohol_bottle == other.Alcohol_bottle || (String.IsNullOrEmpty(this.Alcohol_bottle) && String.IsNullOrEmpty(other.Alcohol_bottle)))
                && (this.Alcohol_describe == other.Alcohol_describe || (String.IsNullOrEmpty(this.Alcohol_describe) && String.IsNullOrEmpty(other.Alcohol_describe)))
                && this.Kava == other.Kava
                && (this.Kava_year == other.Kava_year || (String.IsNullOrEmpty(this.Kava_year) && String.IsNullOrEmpty(other.Kava_year)))
                && (this.Kava_bottle == other.Kava_bottle || (String.IsNullOrEmpty(this.Kava_bottle) && String.IsNullOrEmpty(other.Kava_bottle)))
                && (this.Kava_describe == other.Kava_describe || (String.IsNullOrEmpty(this.Kava_describe) && String.IsNullOrEmpty(other.Kava_describe)))
                && this.HealthyDiet == other.HealthyDiet
                && (this.Diet_describe == other.Diet_describe || (String.IsNullOrEmpty(this.Diet_describe) && String.IsNullOrEmpty(other.Diet_describe)))
                && this.Exercise == other.Exercise
                && (this.Exercise_freq == other.Exercise_freq || (String.IsNullOrEmpty(this.Exercise_freq) && String.IsNullOrEmpty(other.Exercise_freq)));
        }
    }
}
