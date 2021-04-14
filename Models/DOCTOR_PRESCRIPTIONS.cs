using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EMR.Models
{
    public class DOCTOR_PRESCRIPTIONS : DEFAULT
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Display(Name = "Doctor")]
        [Required(ErrorMessage = "{0} is required")]
        public int DOCTORS_ID { get; set; }
        [ForeignKey("DOCTORS_ID")]
        public DOCTORS DOCTORS { get; set; }


        [Display(Name = "Name")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string DOCTOR_NAME { get; set; }

        [Display(Name = "Name Bangla")]
        [StringLength(150, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string DOCTOR_NAME_BANGLA { get; set; }



        [Display(Name = "Address")]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        public string ADDRESS { get; set; }

        [Display(Name = "Address Bangla")]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        public string ADDRESS_BANGLA { get; set; }


        [Display(Name = "Degree")]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string DEGREE { get; set; }

        [Display(Name = "Degree Bangla")]
        [StringLength(300, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        public string DEGREE_BANGLA { get; set; }


        [Display(Name = "Speciality")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        public string SPECIALITY { get; set; }

        [Display(Name = "Speciality Bangla")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        public string SPECIALITY_BANGLA { get; set; }


        [Display(Name = "Others")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        public string OTHERS { get; set; }

        [Display(Name = "Others Bangla")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        public string OTHERS_BANGLA { get; set; }


        [Display(Name = "Reg. No")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        public string REG_NO { get; set; }

        [Display(Name = "Reg. No Bangla")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        public string REG_NO_BANGLA { get; set; }
    }
}
