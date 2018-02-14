using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Models
{
    public class MeasurementType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MeasurementTypeID { get; set; }
        public string MeasurementTypeName { get; set; }

        public virtual ICollection<Measurement> Measurements { get; set; }
    }
}
