using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HIS.Model
{
    [Table("FAMILY")]
    public class Family : IAggregateRoot, IEntityWithReocord
    {
        [Key, Column(Order = 0)]
        public Double PID { get; set; }
        [Key, Column(Order = 1)]
        public DateTime SaveDate { get; set; }
        public Boolean Stroke { get; set; }
        public Boolean CAD { get; set; }
        public Boolean MI { get; set; }
        public Boolean Father { get; set; }
        public Boolean Mother { get; set; }
        public Boolean NotSure { get; set; }
        public String DiabetesType { get; set; }
        public Boolean Breast { get; set; }
        public Boolean Liver { get; set; }
        public Boolean Gastric { get; set; }
        public Boolean Colon { get; set; }
        public Boolean Skin { get; set; }
        public Boolean Lung { get; set; }
        public String CancerOthers { get; set; }
        public Boolean IsEqual(Family other)
        {
            if (other == null)
                return false;
            return this.PID == other.PID
                && this.Stroke == other.Stroke
                && this.CAD == other.CAD
                && this.MI == other.MI
                && this.Father == other.Father
                && this.Mother == other.Mother
                && this.NotSure == other.NotSure
                && (this.DiabetesType == other.DiabetesType || (String.IsNullOrEmpty(this.DiabetesType) && String.IsNullOrEmpty(other.DiabetesType)))
                && this.Breast == other.Breast
                && this.Liver == other.Liver
                && this.Gastric == other.Gastric
                && this.Colon == other.Colon
                && this.Skin == other.Skin
                && this.Lung == other.Lung
                && (this.CancerOthers == other.CancerOthers || (String.IsNullOrEmpty(this.CancerOthers) && String.IsNullOrEmpty(other.CancerOthers)));
        }
    }
}
