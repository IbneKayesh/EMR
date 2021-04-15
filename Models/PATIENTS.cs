using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EMR.Models
{
    public class PATIENTS : DEFAULT
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string MOBILE_NUMBER { get; set; }
        public string PATIENTS_NAME { get; set; }
        public DateTime DATE_OF_BIRTH { get; set; }
        public string PATIENTS_SEX { get; set; }
    }
}
