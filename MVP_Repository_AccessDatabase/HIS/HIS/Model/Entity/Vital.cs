using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HIS.Model
{
    [Table("VITAL")]
    public class Vital : IAggregateRoot, IEntityWithReocord
    {
        [Key, Column(Order = 0)]
        public Double PID { get; set; }
        [Key, Column(Order = 1)]
        public DateTime SaveDate { get; set; }
        public Single Temperature { get; set; }
        public Int32 Pulse { get; set; }
        public Int32 BPres_init_high { get; set; }
        public Int32 BPres_init_low { get; set; }
        public Int32 BPres_cur_high { get; set; }
        public Int32 BPres_cur_low { get; set; }
        public Int32 BPres_recheck_high { get; set; }
        public Int32 BPres_recheck_low { get; set; }
        public String BSugarType { get; set; }
        public String BSugar { get; set; }
        public String BSugar_recheck { get; set; }
        public Boolean BSHigh { get; set; }
        public DateTime DateNextRegular { get; set; }
        public Single HbA1C { get; set; }
        public String TCholest_initial { get; set; }
        public String TCholest_current { get; set; }
    }
}
