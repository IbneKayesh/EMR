using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EMR.Models
{
    public class SUBSCRIPTIONS : DEFAULT
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Display(Name = "Name")]
        [StringLength(3, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string SUBSCRIPTION_NAME { get; set; } //1 For Super Admin, 2 for Register Doctor, 3 for 100 pay, 4 for 200 Pay 
    }
}
