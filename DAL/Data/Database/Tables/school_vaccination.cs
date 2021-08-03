using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class school_vaccination
    {
        public int id { get; set; }
        public string cnic { get; set; }
        public string reg_no { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string spouse_name { get; set; }
        public DateTime? dob { get; set; }
        public double? age { get; set; }
        public int? gender { get; set; }
        public string contact_number { get; set; }
        public string alt_contact_number { get; set; }
        public int? district { get; set; }
        public int? tehsil { get; set; }
        public int? hospital_id { get; set; }
        public bool is_pcr_drawn { get; set; }
        public string test_required { get; set; }
        public int? sample_id { get; set; }
        public bool is_found { get; set; }
        public int? user_id { get; set; }
        public int? user_hospital { get; set; }
        public int? created { get; set; }
        public bool? is_reception { get; set; }
        public int? lab_receptionist_id { get; set; }
        public string health_type { get; set; }
        public string cnic_status { get; set; }
        public string next_of_kin { get; set; }
        public string next_of_kin_cnic { get; set; }
        public string rel_contact { get; set; }
        public bool? is_hbv_test { get; set; }
        public bool? is_hcv_test { get; set; }
        public string pcr_option { get; set; }
        public string uc_number { get; set; }
        public string marital_status { get; set; }
        public string pcr_type { get; set; }
        public string districts_referral { get; set; }
        public string tehsil_referral_name { get; set; }
        public int? referral_clinic { get; set; }
        public bool is_discharge { get; set; }
        public int? updated { get; set; }
        public string cnic_not_available { get; set; }
        public string school_registration_no { get; set; }
        public string school_name { get; set; }
        public string patient_class { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
