using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EMR.Models
{
    public class DRUG_BRANDS : DEFAULT
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Display(Name = "Name")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string BRAND_NAME { get; set; } //Napa, 
    }
}
