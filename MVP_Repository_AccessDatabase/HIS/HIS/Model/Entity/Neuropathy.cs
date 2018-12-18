using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HIS.Model
{
    [Table("NEUROPATHY")]
    public class Neuropathy : IAggregateRoot, IEntityWithReocord
    {
        [Key, Column(Order = 0)]
        public Double PID { get; set; }
        [Key, Column(Order = 1)]
        public DateTime SaveDate { get; set; }
        public Boolean TempRecord { get; set; }
        public Boolean Available { get; set; }
        public String Pedal_left { get; set; }
        public String Intermittent_left { get; set; }
        public String Cold_left { get; set; }
        public String Monofilament_left { get; set; }
        public String Burning_left { get; set; }
        public String Numbness_left { get; set; }
        public String FootUlcer_left { get; set; }
        public String Pedal_right { get; set; }
        public String Intermittent_right { get; set; }
        public String Cold_right { get; set; }
        public String Monofilament_right { get; set; }
        public String Burning_right { get; set; }
        public String Numbness_right { get; set; }
        public String FootUlcer_right { get; set; }
        public DateTime DateNext { get; set; }
    }
}
