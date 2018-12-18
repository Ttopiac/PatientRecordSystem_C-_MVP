using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HIS.Model
{
    [Table("CLINIC")]
    public class Clinic : IAggregateRoot
    {
        public String Name { get; set; }
        public Int32 Pnum { get; set; }
        [Key]
        public Int32 ID { get; set; }
    }
}