using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Models
{
    public class EmployeePatientDepartment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid EmployeePatientDepartmentID { get; set; }

        public Guid EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public virtual Employee Employee { get; set; }

        public Guid PatientID { get; set; }
        [ForeignKey("PatientID")]
        public virtual Patient Patient { get; set; }

        public Guid DepartmentID { get; set; }
        [ForeignKey("DepartmentID")]
        public virtual Department Department { get; set; }
    }
}
