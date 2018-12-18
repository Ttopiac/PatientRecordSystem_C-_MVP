using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HIS.Model
{
    [Table("OPERATOR")]
    public class Operator : IAggregateRoot
    {
        [Key]
        public Int32 OID { get; set; }
        public DateTime SaveDate { get; set; }
        public String FName { get; set; }
        public String SName { get; set; }
        public String Username { get; set; }
        public String Pswd { get; set; }
        public Int16 EnrollFingers { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
