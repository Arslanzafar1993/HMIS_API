using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_lab_sample
    {
        public int id { get; set; }
        public string sample_number { get; set; }
        public string batch_number { get; set; }
        public string test_type { get; set; }
        public int? action_id { get; set; }
        public int? PatientID { get; set; }
        public int? hw_PatientID { get; set; }
        public int? micro_id { get; set; }
        public int? user_id { get; set; }
        public int? created { get; set; }
        public int? updated { get; set; }
        public bool is_lab_batch { get; set; }
        public bool is_resample { get; set; }
        public bool is_refered { get; set; }
        public int? rejected_by { get; set; }
        public int? rejected_time { get; set; }
        public bool? is_sample_svr { get; set; }
        public int? total_duplicate { get; set; }
        public bool is_terminate { get; set; }
        public bool is_ignore { get; set; }
        public int? hospital_id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
