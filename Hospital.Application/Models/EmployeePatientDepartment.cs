//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital.Application.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeePatientDepartment
    {
        public System.Guid EmployeePatientDepartmentID { get; set; }
        public System.Guid EmployeeID { get; set; }
        public System.Guid PatientID { get; set; }
        public System.Guid DepartmentID { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
