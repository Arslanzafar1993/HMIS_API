using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Patient
{
    public class PatientVitalsDTO
    {
        public long id { get; set; }
        public decimal? temperature { get; set; }
        public decimal? pulse { get; set; }
        public decimal? bp_systolic { get; set; }
        public decimal? bp_diastolic { get; set; }
        public decimal? height { get; set; }
        public decimal? weight { get; set; }
        public long? PatientID { get; set; }
        public int? user_id { get; set; }
        public int? created { get; set; }
        public int? updated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
