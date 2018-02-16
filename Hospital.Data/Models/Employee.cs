using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid EmployeeID { get; set; }

        [Required(ErrorMessage = "{0} is a required field")]
        [DataType(DataType.Text)]
        [StringLength(maximumLength: 50, MinimumLength = 1,
            ErrorMessage = "The property {0} should have {1} maximum characters and {2} minimum characters")]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "{0} is a required field")]
        [DataType(DataType.Text)]
        [StringLength(maximumLength: 50, MinimumLength = 1,
            ErrorMessage = "The property {0} should have {1} maximum characters and {2} minimum characters")]
        [RegularExpression("^((?!^Address$)[0-9A-Za-z #.,])+$", ErrorMessage = "{0} must be properly formatted.")]
        public string EmployeeAddress { get; set; }

        [Required(ErrorMessage = "{0} is a required field")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public int EmployeePhoneNumber { get; set; }

        public Guid JobTypeID { get; set; }
        [ForeignKey("JobTypeID")]
        public virtual JobType JobType { get; set; }

        public Guid ThesisID { get; set; }
        [ForeignKey("ThesisID")]
        public virtual Thesis Thesis { get; set; }

        public virtual ICollection<EmployeePatientDepartment> EmployeePatientDepartments { get; set; }
    }
}
