using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_drug_interaction_med_sec
    {
        public int id { get; set; }
        public int? PatientID { get; set; }
        public int? sample_id { get; set; }
        public string sample_svr_flag { get; set; }
        public bool? drug_interaction { get; set; }
        public bool? enticavir { get; set; }
        public bool? tenofovir { get; set; }
        public bool? telbuvidine { get; set; }
        public bool? disburse_3_mnth_dose { get; set; }
        public bool? disburse_6_mnth_dose { get; set; }
        public string baseline_type { get; set; }
        public int? created { get; set; }
        public int? updated { get; set; }
        public int? created_by { get; set; }
        public int? updated_by { get; set; }
        public bool? sd_pack { get; set; }
        public bool? sr_pack { get; set; }
        public bool? sdr_pack { get; set; }
        public bool? is_demote { get; set; }
        public bool? is_imported_data { get; set; }
        public int? medicine_id { get; set; }
        public bool? sample_recommended { get; set; }
        public bool? is_admin_follow_up { get; set; }
        public int? admin_follow_up_date { get; set; }
        public DateTime? admin_followup_date { get; set; }
        public int? admin_user { get; set; }
        public int? hospital_id { get; set; }
        public bool is_terminate { get; set; }
        public string is_duplicate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
