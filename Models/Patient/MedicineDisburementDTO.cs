using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Patient
{
    public class MedicineDisburementDTO
    {
        /// <summary>
        /// For tbl_drug_interaction_med_sec
        /// </summary>
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

        /// <summary>
        /// For tbl_cbc_parameter
        /// </summary>
        public int? hemoglobin { get; set; }
        public int? ast { get; set; }
        public int? alt { get; set; }
        public int? platelet { get; set; }
        public int? tlc { get; set; }
        public string apri { get; set; }
        public int? viral_count { get; set; }
        public string pcr_result { get; set; }
        public int? follow_up_no { get; set; }
        public string lab_name { get; set; }
        public string other_lab_name { get; set; }
        public string result_type { get; set; }

        /// <summary>
        /// For tbl_renal_function
        /// </summary>

        public int? urea { get; set; }
        public decimal? creatinie { get; set; }
        public int? blood_sugar_random { get; set; }
    }
}
