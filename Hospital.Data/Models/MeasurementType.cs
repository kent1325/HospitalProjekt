using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Models
{
    [Table("MeasurementTypes")]
    public class MeasurementType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MeasurementTypeID { get; set; }

        [Required(ErrorMessage = "{0} is a required field")]
        [DataType(DataType.Text)]
        [StringLength(maximumLength: 50, MinimumLength = 1,
            ErrorMessage = "The property {0} should have {1} maximum characters and {2} minimum characters")]
        public string MeasurementTypeName { get; set; }

        public virtual ICollection<Measurement> Measurements { get; set; }
    }
}
