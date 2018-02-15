//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital.PatientMeasurement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.EmployeePatientDepartments = new HashSet<EmployeePatientDepartment>();
        }
    
        public System.Guid EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }
        public int EmployeePhoneNumber { get; set; }
        public System.Guid JobTypeID { get; set; }
        public System.Guid ThesisID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeePatientDepartment> EmployeePatientDepartments { get; set; }
        public virtual JobType JobType { get; set; }
        public virtual Thesis Thesis { get; set; }
    }
}
