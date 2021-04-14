using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EMR.Models
{
    public class DOCTORS : DEFAULT
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Display(Name = "Email")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} is required")]
        public string EMAIL_ID { get; set; }

        [Display(Name = "Password")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        //[Remote(action: "VerifyPassword", controller: "User")]
        [DataType(DataType.Password)]
        public string PASSWORD { get; set; }

        [Display(Name = "Name")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string DOCTOR_NAME { get; set; }

        [Display(Name = "Mobile")]
        // [RegularExpression("([-+]?[0-9]\.?[0-9]+[\/\+\-\])+([-+]?[0-9]*\.?[0-9]+)")]
        [StringLength(15, MinimumLength = 11, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string MOBILE_NO { get; set; }

        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "{0} is required")]
        public DateTime DATE_OF_BIRTH { get; set; }

        [Display(Name = "Sex")]
        [Required(ErrorMessage = "{0} is required")]
        public int SEXS_ID { get; set; }
        [ForeignKey("SEXS_ID")]
        public SEXS SEXS { get; set; }

        [Display(Name = "Certification")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string CERTIFICATION { get; set; }

        [Display(Name = "Subscription")]
        [Required(ErrorMessage = "{0} is required")]
        public int SUBSCRIPTIONS_ID { get; set; }
        [ForeignKey("SUBSCRIPTIONS_ID")]
        public SUBSCRIPTIONS SUBSCRIPTIONS { get; set; } //Default ID=2 need to Set (Automatically)
    }
}
