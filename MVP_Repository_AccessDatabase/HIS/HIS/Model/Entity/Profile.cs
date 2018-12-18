using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HIS.Model
{
    [Table("PROFILE")]
    public class Profile : IAggregateRoot, IEntityWithReocord
    {
        [Key]
        public Double PID { get; set; }
        public DateTime SaveDate { get; set; }
        public String FName { get; set; }
        public String SName { get; set; }
        public String Gender { get; set; }
        public Int32 BYear { get; set; }
        public String Village { get; set; }
        public String HIsland { get; set; }
        public String Religion { get; set; }
        public String Marital { get; set; }
        public String Occupation { get; set; }
        public String Contact { get; set; }
        public String Allergy { get; set; }
        public Int32 EnrollFingers { get; set; }
        public Boolean Death { get; set; }
        public DateTime DeathTime { get; set; }
        public String DeathCause { get; set; }
        public DateTime InsertDate { get; set; }
        public Boolean IsPermanentPID { get; set; }

        public Boolean IsEqual(Profile other)
        {
            if (other == null)
                return false;

            return this.PID == other.PID
                && (this.FName == other.FName || (String.IsNullOrEmpty(this.FName) && String.IsNullOrEmpty(other.FName)))
                && (this.SName == other.SName || (String.IsNullOrEmpty(this.SName) && String.IsNullOrEmpty(other.SName)))
                && (this.Gender == other.Gender || (String.IsNullOrEmpty(this.Gender) && String.IsNullOrEmpty(other.Gender)))
                && this.BYear == other.BYear
                && (this.Village == other.Village || (String.IsNullOrEmpty(this.Village) && String.IsNullOrEmpty(other.Village)))
                && (this.HIsland == other.HIsland || (String.IsNullOrEmpty(this.HIsland) && String.IsNullOrEmpty(other.HIsland)))
                && (this.Religion == other.Religion || (String.IsNullOrEmpty(this.Religion) && String.IsNullOrEmpty(other.Religion)))
                && (this.Marital == other.Marital || (String.IsNullOrEmpty(this.Marital) && String.IsNullOrEmpty(other.Marital)))
                && (this.Occupation == other.Occupation || (String.IsNullOrEmpty(this.Occupation) && String.IsNullOrEmpty(other.Occupation)))
                && (this.Contact == other.Contact || (String.IsNullOrEmpty(this.Contact) && String.IsNullOrEmpty(other.Contact)))
                && (this.Allergy == other.Allergy || (String.IsNullOrEmpty(this.Allergy) && String.IsNullOrEmpty(other.Allergy)))
                && (this.EnrollFingers == other.EnrollFingers || (String.IsNullOrEmpty(this.Allergy) && String.IsNullOrEmpty(other.Allergy)))
                && this.Death == other.Death
                && this.DeathTime == other.DeathTime
                && (this.DeathCause == other.DeathCause || (String.IsNullOrEmpty(this.DeathCause) && String.IsNullOrEmpty(other.DeathCause)))
                && this.InsertDate == other.InsertDate
                && this.IsPermanentPID == other.IsPermanentPID;
        }
    }
    
}

