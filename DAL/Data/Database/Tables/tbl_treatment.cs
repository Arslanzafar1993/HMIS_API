using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_treatment
    {
        public int id { get; set; }
        public bool raPatientID_testing { get; set; }
        public bool? is_hbv_test { get; set; }
        public bool? is_hcv_test { get; set; }
        public bool prescribe_medicine { get; set; }
        public bool? is_hbv_medicine { get; set; }
        public bool? is_hcv_medicine { get; set; }
        public bool counselling { get; set; }
        public bool vaccination { get; set; }
        public string vaccination_option { get; set; }
        public string pcr { get; set; }
        public bool discharge { get; set; }
        public bool deferred { get; set; }
        public bool referral_pkli { get; set; }
        public long PatientID { get; set; }
        public int created { get; set; }
        public int user_id { get; set; }
        public string hcv_medicine { get; set; }
        public string hbv_medicine { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
