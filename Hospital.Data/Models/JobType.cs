using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Models
{
    [Table("JobTypes")]
    public class JobType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid JobTypeID { get; set; }

        [Required(ErrorMessage = "{0} is a required field")]
        [DataType(DataType.Text)]
        [StringLength(maximumLength: 50, MinimumLength = 1,
            ErrorMessage = "The property {0} should have {1} maximum characters and {2} minimum characters")]
        public string JobTypeTitle { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
