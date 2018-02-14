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
        public string PatientName { get; set; }
        public int PatientCPR { get; set; }

        public virtual ICollection<EmployeePatientDepartment> EmployeePatientDepartments { get; set; }

        public virtual ICollection<Measurement> Measurements { get; set; }
    }
}
