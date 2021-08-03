using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_temporary_result_upload
    {
        public int id { get; set; }
        public string sample_no { get; set; }
        public int? sample_id { get; set; }
        public string test_required { get; set; }
        public string result_hbv { get; set; }
        public string hbv_viral_load { get; set; }
        public string result_hcv { get; set; }
        public string hcv_viral_load { get; set; }
        public bool? is_found { get; set; }
        public int? created { get; set; }
        public bool? is_batch_count_matched { get; set; }
        public int? batch_id { get; set; }
        public int? PatientID { get; set; }
        public string is_svr_sample { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
