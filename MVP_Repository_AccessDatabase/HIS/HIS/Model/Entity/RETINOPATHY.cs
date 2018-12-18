using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HIS.Model
{
    [Table("RETINOPATHY")]
    public class RETINOPATHY : IAggregateRoot, IEntityWithReocord
    {
        [Key, Column(Order = 0)]
        public Double PID { get; set; }
        [Key, Column(Order = 1)]
        public DateTime SaveDate { get; set; }
        public Boolean Available { get; set; }
        public Boolean Retinopathy { get; set; }
        public DateTime DateNext { get; set; }
    }
}
