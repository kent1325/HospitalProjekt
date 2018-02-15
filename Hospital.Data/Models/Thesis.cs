using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Models
{
    public class Thesis
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ThesisID { get; set; }

        [Required(ErrorMessage = "{0} is a required field")]
        [DataType(DataType.Text)]
        [StringLength(maximumLength: 25, MinimumLength = 1,
           ErrorMessage = "The property {0} should have {1} maximum characters and {2} minimum characters")]
        public string ThesisTitle { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
