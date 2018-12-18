using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HIS.Model
{
    [Table("RELIGION")]
    public class Religion : IAggregateRoot
    {
        public String Name { get; set; }
        [Key]
        public Int32 ID { get; set; }
    }
}