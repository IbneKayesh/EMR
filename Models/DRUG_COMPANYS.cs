using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EMR.Models
{
    public class DRUG_COMPANYS : DEFAULT
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Display(Name = "Name")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string COMPANY_NAME { get; set; }  //Square, Beximco

        [Display(Name = "Type")]
        [Required(ErrorMessage = "{0} is required")]
        public int DRUG_COMPANY_TYPES_ID { get; set; }
        [ForeignKey("DRUG_COMPANY_TYPES_ID")]
        public DRUG_COMPANY_TYPES DRUG_COMPANY_TYPES { get; set; }
    }
}
