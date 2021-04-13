using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EMR.Models
{
    public class DOCTORS
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string MOBILE_NO { get; set; }
        public string DOCTOR_NAME { get; set; }
        public DateTime DATE_OF_BIRTH { get; set; }
        public string CERTIFICATION { get; set; }
        public string DOCTOR_SEX { get; set; }
    }
}
