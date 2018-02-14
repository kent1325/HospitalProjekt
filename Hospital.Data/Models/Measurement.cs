using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Models
{
    public class Measurement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MeasurementID { get; set; }
        public DateTime MeasurementTime { get; set; }
        public double MeasurementValue { get; set; }

        public Guid PatientID { get; set; }
        [ForeignKey("PatientID")]
        public virtual Patient Patient { get; set; }

        public Guid MeasurementTypeID { get; set; }
        [ForeignKey("MeasurementTypeID")]
        public virtual MeasurementType MeasurementType { get; set; }
    }
}
