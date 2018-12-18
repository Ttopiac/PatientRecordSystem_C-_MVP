using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HIS.Model
{
    [Table("SYMPTOM")]
    public class Symptom : IAggregateRoot, IEntityWithReocord
    {
        [Key, Column(Order = 0)]
        public Double PID { get; set; }
        [Key, Column(Order = 1)]
        public DateTime SaveDate { get; set; }
        public Boolean Breathlessness { get; set; }
        public Boolean IncreaThirst { get; set; }
        public Boolean PassBloodUrine { get; set; }
        public Boolean NumbnessLimbs { get; set; }
        public Boolean Puffiness { get; set; }
        public Boolean Polyuria { get; set; }
        public Boolean SwellingFeet { get; set; }
        public Boolean LossWeight { get; set; }
        public Boolean ChestPain { get; set; }
        public Boolean DiabetesInfection { get; set; }
    }
}
