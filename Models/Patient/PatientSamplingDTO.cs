using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Patient
{
    public class PatientSamplingDTO
    {
        public long id { get; set; }
        public string number { get; set; }
        public int? user_id { get; set; }
        public int? user_hospital { get; set; }
        public int? created { get; set; }
        public long? PatientID { get; set; }
        public int? updated { get; set; }
        public int? updated_by { get; set; }
        public int? action_id { get; set; }
        public int? lab_receptionist_id { get; set; }
        public bool? is_dispatch { get; set; }
        public bool? is_reception { get; set; }
        public bool? is_lab_batch { get; set; }
        public bool? is_sample_svr { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
