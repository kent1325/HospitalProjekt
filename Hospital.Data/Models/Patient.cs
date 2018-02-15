using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Models
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PatientID { get; set; }

        [Required(ErrorMessage = "{0} is a required field")]
        [DataType(DataType.Text)]
        [StringLength(maximumLength: 50, MinimumLength = 1,
            ErrorMessage = "The property {0} should have {1} maximum characters and {2} minimum characters")]
        public string PatientName { get; set; }

        [Required(ErrorMessage = "{0} is a required field")]
        [StringLength(maximumLength: 11, MinimumLength = 11,
            ErrorMessage = "The property {0} should have {2} characters")]
        [RegularExpression("\\d{6}-\\d{4}", ErrorMessage = "{0} must be formatted correctly (012345-6789")]
        public string PatientCPR { get; set; }

        public virtual ICollection<EmployeePatientDepartment> EmployeePatientDepartments { get; set; }

        public virtual ICollection<Measurement> Measurements { get; set; }
    }
}
