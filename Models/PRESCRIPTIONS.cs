using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMR.Models
{
    public class PRESCRIPTIONS
    {
        public PRESCRIPTIONS()
        {
            DOCTORS_ID = 1;
            PRESCRIBE_DATE = DateTime.Now;
            PATIENTS_MOBILE_NUMBER = "019000000";
            PATIENTS_NAME = "Mr. Seek";
            AGE_YEAR = 17;
            PATIENTS_SEX = "Male";
            BLOOD_GROUP = "O+";
            BP = "120/90";
            TEMPERATURE = 98M;
            WEIGHT = 67M;
            PROBLEMS = "fever and cough";
            VISIT_TYPE = "New Visit";
            VISIT_FEES = 50M;
            REF_PRESCRIPTIONS_NUMBER = "0";
            REQUIRED_ADMISSION = false;
            INSTRUCTIONS = "n/a";
        }
        public Int64 ID { get; set; }
        public int DOCTORS_ID { get; set; }
        public string PRESCRIPTIONS_NUMBER { get; set; }
        public DateTime PRESCRIBE_DATE { get; set; }
        [Display(Name = "Mobile")]
        public string PATIENTS_MOBILE_NUMBER { get; set; }
        [Display(Name = "Name")]
        public string PATIENTS_NAME { get; set; }
        [Display(Name = "Age")]
        [Range(0, 130, ErrorMessage = "{0} value between {2} and {1}")]
        public int AGE_YEAR { get; set; }
        [Display(Name = "Month")]
        [Range(0, 12, ErrorMessage = "{0} value between {2} and {1}")]
        public int AGE_MONTH { get; set; }
        [Display(Name = "Day")]
        [Range(0, 31, ErrorMessage = "{0} value between {2} and {1}")]
        public int AGE_DAYS { get; set; }
        [Display(Name = "Sex")]
        public string PATIENTS_SEX { get; set; }
        [Display(Name = "BG")]
        public string BLOOD_GROUP { get; set; }
        [Display(Name = "BP")]
        public string BP { get; set; }
        [Display(Name = "Temp")]
        public decimal TEMPERATURE { get; set; }
        [Display(Name = "Weight")]
        public decimal WEIGHT { get; set; }
        [Display(Name = "Problems")]
        public string PROBLEMS { get; set; }
        [Display(Name = "Visit")]
        public string VISIT_TYPE { get; set; }
        [Display(Name = "Fee")]
        public decimal VISIT_FEES { get; set; }
        [Display(Name = "Ref.")]
        public string REF_PRESCRIPTIONS_NUMBER { get; set; }
        public bool REQUIRED_ADMISSION { get; set; }
        public string INSTRUCTIONS { get; set; }
        public List<PRESCRIPTIONS_DRUGS> PRESCRIPTIONS_DRUGS { get; set; }
        public List<PRESCRIPTIONS_INVES> PRESCRIPTIONS_INVES { get; set; }
    }
}
