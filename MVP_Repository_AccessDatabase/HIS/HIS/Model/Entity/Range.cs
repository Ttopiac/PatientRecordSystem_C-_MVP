using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HIS.Model
{
    [Table("RANGE")]
    public class Range : IAggregateRoot
    {
        [Key]
        public String Item { get; set; }
        public Single Min { get; set; }
        public Single Max { get; set; }
    }
}