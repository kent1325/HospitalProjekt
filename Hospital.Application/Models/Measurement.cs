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
    
    public partial class Measurement
    {
        public System.Guid MeasurementID { get; set; }
        public System.DateTime MeasurementTime { get; set; }
        public double MeasurementValue { get; set; }
        public System.Guid PatientID { get; set; }
        public System.Guid MeasurementTypeID { get; set; }
    
        public virtual MeasurementType MeasurementType { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
