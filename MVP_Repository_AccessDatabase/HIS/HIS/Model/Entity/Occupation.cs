using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HIS.Model
{
    [Table("OCCUPATION")]
    public class Occupation : IAggregateRoot
    {
        public String Name { get; set; }
        [Key]
        public Int32 ID { get; set; }
    }
}