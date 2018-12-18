using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HIS.Model
{
    [Table("REFERRAL")]
    public class Referral : IAggregateRoot, IEntityWithReocord
    {
        [Key, Column(Order = 0)]
        public Double PID { get; set; }
        [Key, Column(Order = 1)]
        public DateTime SaveDate { get; set; }
        public Boolean UrgentReferral_1 { get; set; }
        public Boolean UrgentReferral_2 { get; set; }
        public Boolean UrgentReferral_3 { get; set; }
        public Boolean UrgentReferral_4 { get; set; }
        public Boolean UrgentReferral_5 { get; set; }
        public Boolean UrgentReferral_6 { get; set; }
        public Boolean UrgentReferral_7 { get; set; }
        public Boolean UrgentReferral_8 { get; set; }
        public Boolean NonUrgentReferral_1 { get; set; }
        public Boolean NonUrgentReferral_2 { get; set; }
        public Boolean NonUrgentReferral_3 { get; set; }
        public Boolean NonUrgentReferral_4 { get; set; }
        public Boolean NonUrgentReferral_5 { get; set; }
        public Boolean NonUrgentReferral_5_1 { get; set; }
        public Boolean NonUrgentReferral_5_2 { get; set; }
        public Boolean NonUrgentReferral_5_3 { get; set; }
        public Boolean NonUrgentReferral_5_4 { get; set; }
    }
}
