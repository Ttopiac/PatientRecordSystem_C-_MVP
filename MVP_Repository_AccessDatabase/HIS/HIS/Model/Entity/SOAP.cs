using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HIS.Model
{
    [Table("SOAP")]
    public class SOAP : IAggregateRoot, IEntityWithReocord
    {
        [Key, Column(Order = 0)]
        public Double PID { get; set; }
        [Key, Column(Order = 1)]
        public DateTime SaveDate { get; set; }
        public String ProbSubject { get; set; }
        public String ProbObject { get; set; }
        public String ProbAssess { get; set; }
        public String ProbPlan { get; set; }
    }
}
