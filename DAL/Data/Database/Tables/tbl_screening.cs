using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_screening
    {
        public int id { get; set; }
        public string reg_no { get; set; }
        public string old_reg_no { get; set; }
        public string mrn_no { get; set; }
        public string patient_name { get; set; }
        public string father_name { get; set; }
        public DateTime? patient_dob { get; set; }
        public double? patient_age { get; set; }
        public string patient_type { get; set; }
        public string relation_contact { get; set; }
        public int? cnic_status { get; set; }
        public string self_cnic { get; set; }
        public string next_of_kin { get; set; }
        public string next_of_kin_cnic { get; set; }
        public string no_cnic_reason { get; set; }
        public string contact_no_self { get; set; }
        public string other_contactno { get; set; }
        public int? gender { get; set; }
        public bool? address_available { get; set; }
        public string postal_address { get; set; }
        public int? division { get; set; }
        public int? district { get; set; }
        public int? tehsil { get; set; }
        public int? hospital { get; set; }
        public int? created { get; set; }
        public int? next_status { get; set; }
        public int? updated { get; set; }
        public int? next_status_updated { get; set; }
        public bool? previous_hbv { get; set; }
        public bool? previous_hcv { get; set; }
        public bool? pcr_confirmation_hbv { get; set; }
        public bool? pcr_confirmation_hcv { get; set; }
        public bool? vacination_completed { get; set; }
        public int? marital_status { get; set; }
        public int occupation { get; set; }
        public int qualification { get; set; }
        public int? user_id { get; set; }
        public int? callcenter_id { get; set; }
        public int? is_referal { get; set; }
        public bool? completed_vacination_hbv { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
