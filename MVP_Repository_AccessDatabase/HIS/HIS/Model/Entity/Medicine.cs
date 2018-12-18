using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HIS.Model
{
    [Table("MEDICINE")]
    public class Medicine : IAggregateRoot, IEntityWithReocord
    {
        [Key, Column(Order = 0)]
        public Double PID { get; set; }
        [Key, Column(Order = 1)]
        public DateTime SaveDate { get; set; }
        public Boolean Amlodipine { get; set; }
        public Single Amlodipine_mg { get; set; }
        public String Amlodipine_freq { get; set; }
        public Boolean Atenolol { get; set; }
        public Single Atenolol_mg { get; set; }
        public String Atenolol_freq { get; set; }
        public Boolean Captopril { get; set; }
        public Single Captopril_mg { get; set; }
        public String Captopril_freq { get; set; }
        public Boolean Enalapril { get; set; }
        public Single Enalapril_mg { get; set; }
        public String Enalapril_freq { get; set; }
        public Boolean Nifedi { get; set; }
        public Single Nifedi_mg { get; set; }
        public String Nifedi_freq { get; set; }
        public Boolean Hydrocho { get; set; }
        public Single Hydrocho_mg { get; set; }
        public String Hydrocho_freq { get; set; }
        public Boolean Others1 { get; set; }
        public Single Others1_mg { get; set; }
        public String Others1_freq { get; set; }
        public String Usuage1 { get; set; }
        public Boolean Gliben { get; set; }
        public Single Gliben_mg { get; set; }
        public String Gliben_freq { get; set; }
        public Boolean Metformin { get; set; }
        public Single Metformin_mg { get; set; }
        public String Metformin_freq { get; set; }
        public Boolean InsulinActrapid { get; set; }
        public Single InsulinActrapid_units { get; set; }
        public String InsulinActrapid_freq { get; set; }
        public Boolean InsulinMixtard { get; set; }
        public Single InsulinMixtard_units { get; set; }
        public String InsulinMixtard_freq { get; set; }
        public Boolean InsulinProtaphane { get; set; }
        public Single InsulinProtaphane_units { get; set; }
        public String InsulinProtaphane_freq { get; set; }
        public Boolean Simvastatin { get; set; }
        public Single Simvastatin_mg { get; set; }
        public String Simvastatin_freq { get; set; }
        public String Usuage3 { get; set; }
        public Boolean Aspirin { get; set; }
        public Single Aspirin_mg { get; set; }
        public String Aspirin_freq { get; set; }
        public Boolean Warfarin { get; set; }
        public Single Warfarin_mg { get; set; }
        public String Warfarin_freq { get; set; }
        public Boolean Spironolactone { get; set; }
        public Single Spironolactone_mg { get; set; }
        public String Spironolactone_freq { get; set; }
        public Boolean Frusemide { get; set; }
        public Single Frusemide_mg { get; set; }
        public String Frusemide_freq { get; set; }
        public Boolean Digoxin { get; set; }
        public Single Digoxin_mg { get; set; }
        public String Digoxin_freq { get; set; }
        public Boolean GlycerylTrinitrate { get; set; }
        public Single GlycerylTrinitrate_mg { get; set; }
        public String GlycerylTrinitrate_freq { get; set; }
        public Boolean IsosorbideDinitrate { get; set; }
        public Single IsosorbideDinitrate_mg { get; set; }
        public String IsosorbideDinitrate_freq { get; set; }
        public String Others { get; set; }
    }
}
