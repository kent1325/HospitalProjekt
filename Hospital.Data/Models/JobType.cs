using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Models
{
    public class JobType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid JobTypeID { get; set; }
        public string JobTypeTitle { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
