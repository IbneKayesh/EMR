using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EMR.Models
{
    public class DRUGS : DEFAULT
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Display(Name = "Name")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string DRUGS_NAME { get; set; }


        [Display(Name = "Categorie")]
        [Required(ErrorMessage = "{0} is required")]
        public int DRUG_CATEGORIES_ID { get; set; }
        [ForeignKey("DRUG_CATEGORIES_ID")]
        public DRUG_CATEGORIES DRUG_CATEGORIES { get; set; }


        [Display(Name = "Brand")]
        [Required(ErrorMessage = "{0} is required")]
        public int DRUG_BRANDS_ID { get; set; }
        [ForeignKey("DRUG_BRANDS_ID")]
        public DRUG_BRANDS DRUG_BRANDS { get; set; }


        [Display(Name = "Generic")]
        [Required(ErrorMessage = "{0} is required")]
        public int DRUG_GENERICS_ID { get; set; }
        [ForeignKey("DRUG_GENERICS_ID")]
        public DRUG_GENERICS DRUG_GENERICS { get; set; }


        [Display(Name = "Company")]
        [Required(ErrorMessage = "{0} is required")]
        public int DRUG_COMPANYS_ID { get; set; }
        [ForeignKey("DRUG_COMPANYS_ID")]
        public DRUG_COMPANYS DRUG_COMPANYS { get; set; }


        [Display(Name = "Remarks")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        public string DRUGS_REMARKS { get; set; }
    }
}
