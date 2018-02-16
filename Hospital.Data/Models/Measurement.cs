using Hospital.Data.CustomDataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Models
{
    [Table("Measurements")]
    public class Measurement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MeasurementID { get; set; }

        [Required(ErrorMessage = "{0} is a required field")]
        [DataType(DataType.DateTime)]
        [DateRange(ErrorMessage = "Valid dates for the Property {0} between {1} and {2}")] // (ErrorMessage = "{0} has to be a valid date and can not exceed todays date.")
        public DateTime MeasurementTime { get; set; }

        [Required(ErrorMessage = "{0} is a required field")]
        public double MeasurementValue { get; set; }

        public Guid PatientID { get; set; }
        [ForeignKey("PatientID")]
        [Required(ErrorMessage = "{0} is a required field")]
        public virtual Patient Patient { get; set; }

        public Guid MeasurementTypeID { get; set; }
        [ForeignKey("MeasurementTypeID")]
        [Required(ErrorMessage = "{0} is a required field")]
        public virtual MeasurementType MeasurementType { get; set; }
    }
}
