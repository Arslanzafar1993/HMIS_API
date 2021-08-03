using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_private_lab_result
    {
        public int id { get; set; }
        public long? PatientID { get; set; }
        public string test_required { get; set; }
        public string is_hbv_detected { get; set; }
        public string hbv { get; set; }
        public string is_hcv_detected { get; set; }
        public string hcv { get; set; }
        public int? created { get; set; }
        public int? user_id { get; set; }
        public string lab_name { get; set; }
        public string result_type { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
