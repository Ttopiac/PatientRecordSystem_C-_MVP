using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HIS.Model
{
    [Table("DIAGNOSIS")]
    public class Diagnosis : IAggregateRoot, IEntityWithReocord
    {
        [Key, Column(Order = 0)]
        public Double PID { get; set; }
        [Key, Column(Order = 1)]
        public DateTime SaveDate { get; set; }
        public Boolean Angina { get; set; }
        public Boolean MyoInfar { get; set; }
        public Boolean Valvular { get; set; }
        public Boolean RheuHeart { get; set; }
        public Boolean Cardiac { get; set; }
        public Boolean Diabetes { get; set; }
        public Int32 DiabetesStart { get; set; }
        public Boolean Stroke { get; set; }
        public Boolean TIA { get; set; }
        public Boolean Hypertension { get; set; }
        public Boolean Hyperlip { get; set; }
        public Boolean RenalArtery { get; set; }
        public Boolean PeriVascular { get; set; }
        public Boolean LVH { get; set; }
    }
}
