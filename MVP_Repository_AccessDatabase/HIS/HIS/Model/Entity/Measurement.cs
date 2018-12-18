using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HIS.Model
{
    [Table("MEASUREMENT")]
    public class Measurement : IAggregateRoot, IEntityWithReocord
    {
        [Key, Column(Order = 0)]
        public Double PID { get; set; }
        [Key, Column(Order = 1)]
        public DateTime SaveDate { get; set; }
        public Double Height { get; set; }
        public Double Weight { get; set; }
        public Double BMI { get; set; }
        public Single Waist { get; set; }
    }
}
