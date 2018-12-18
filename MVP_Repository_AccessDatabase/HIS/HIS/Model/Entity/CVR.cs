using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HIS.Model
{
    [Table("CVR")]
    public class CVR : IAggregateRoot, IEntityWithReocord
    {
        [Key, Column(Order = 0)]
        public Double PID { get; set; }
        [Key, Column(Order = 1)]
        public DateTime SaveDate { get; set; }
        public Int32 CVRResult { get; set; }
        public DateTime DateNextCVR { get; set; }
    }
}
