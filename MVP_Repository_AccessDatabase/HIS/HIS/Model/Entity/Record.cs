using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HIS.Model
{
    [Table("RECORD")]
    public class Record : IAggregateRoot
    {
        [Key, Column(Order = 0)]
        public Double PID { get; set; }
        [Key, Column(Order = 1)]
        public DateTime SaveDate { get; set; }
        [Key, Column(Order = 2)]
        public String Clinic { get; set; }
        public Int32 Operator { get; set; }
        [Key, Column(Order = 3)]
        public String TableName { get; set; }
    }
}
