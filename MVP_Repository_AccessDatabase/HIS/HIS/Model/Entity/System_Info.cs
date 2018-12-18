using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HIS.Model
{
    [Table("SYSTEM_INFO")]
    public class System_Info : IAggregateRoot
    {   
        public String Clinic { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public Int32 PermanentID { get; set; }
        [Key]
        public Int32 SID { get; set; }
    }
}