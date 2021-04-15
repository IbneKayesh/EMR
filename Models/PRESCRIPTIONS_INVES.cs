using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EMR.Models
{
    public class PRESCRIPTIONS_INVES
    {
        [Key, Column(Order = 0)]
        public Int64 PRESCRIPTIONS_ID { get; set; }
        [ForeignKey("PRESCRIPTIONS_ID")]
        public PRESCRIPTIONS PRESCRIPTIONS { get; set; }
        [Key, Column(Order = 1)]
        public int LINE_NO { get; set; }
        public int INVESTIGATIONS_ID { get; set; }
        public string INVESTIGATIONS_NAME { get; set; }
        public string INSTRUCTIONS { get; set; }
        public string REF_DIAGNOSTICS { get; set; }
    }
}
