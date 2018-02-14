using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid EmployeeID { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Employee {0} is required")]
        public string EmployeeName { get; set; }

        [DataType(DataType.Text)]
        public string EmployeeAddress { get; set; }

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
