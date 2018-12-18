using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HIS.Model
{
    [Table("NEPHROPATHY")]
    public class NEPHROPATHY : IAggregateRoot, IEntityWithReocord
    {
        [Key, Column(Order = 0)]
        public Double PID { get; set; }
        [Key, Column(Order = 1)]
        public DateTime SaveDate { get; set; }
        public Boolean Available { get; set; }
        public Int32 Nephropathy { get; set; }
        public DateTime DateNext { get; set; }
    }
}
