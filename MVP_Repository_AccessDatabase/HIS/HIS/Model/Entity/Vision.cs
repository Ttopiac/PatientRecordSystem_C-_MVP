using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HIS.Model
{
    [Table("VISION")]
    public class Vision : IAggregateRoot, IEntityWithReocord
    {
        [Key, Column(Order = 0)]
        public Double PID { get; set; }
        [Key, Column(Order = 1)]
        public DateTime SaveDate { get; set; }
        public Boolean Available { get; set; }
        public String Vision_left { get; set; }
        public String Vision_right { get; set; }
        public String Vision_left_last { get; set; }
        public String Vision_right_last { get; set; }
        public Boolean Disturbance { get; set; }
        public DateTime DateNext { get; set; }
    }
}
