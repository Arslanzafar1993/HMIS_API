using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_micro_screening
    {
        public int id { get; set; }
        public string cnic { get; set; }
        public string reg_no { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string mrn_no { get; set; }
        public string spouse_name { get; set; }
        public DateTime? dob { get; set; }
        public double? age { get; set; }
        public string school_registration_no { get; set; }
        public string school_name { get; set; }
        public string patient_class { get; set; }
        public int? gender { get; set; }
        public string contact_number { get; set; }
        public string alt_contact_number { get; set; }
        public int? district { get; set; }
        public int? tehsil { get; set; }
        public int? hospital_id { get; set; }
        public bool is_pcr_drawn { get; set; }
        public string test_required { get; set; }
        public string sample_id { get; set; }
        public bool is_found { get; set; }
        public int? user_hospital { get; set; }
        public int? created { get; set; }
        public bool? is_reception { get; set; }
        public int? lab_receptionist_id { get; set; }
        public string health_type { get; set; }
        public int? cnic_status { get; set; }
        public string next_of_kin { get; set; }
        public string next_of_kin_cnic { get; set; }
        public string rel_contact { get; set; }
        public bool? is_hbv_test { get; set; }
        public bool? is_hcv_test { get; set; }
        public string pcr_option { get; set; }
        public string uc_number { get; set; }
        public string marital_status { get; set; }
        public string pcr_type { get; set; }
        public int? referral_clinic { get; set; }
        public bool is_discharge { get; set; }
        public string cnic_not_available { get; set; }
        public int? event_id { get; set; }
        public string address { get; set; }
        public string api_district_name { get; set; }
        public string tehsil_name { get; set; }
        public string uc_name { get; set; }
        public bool? frm_data_plug { get; set; }
        public bool? is_first_vaccine { get; set; }
        public bool? is_sample_add { get; set; }
        public bool? is_household_info { get; set; }
        public string activity_type { get; set; }
        public string imei_no { get; set; }
        public bool is_soft_delete { get; set; }
        public int? sample_collected_date { get; set; }
        public int? screening_date { get; set; }
        public bool? is_pat_reg_in_emr { get; set; }
        public string districts_referral { get; set; }
        public string tehsil_referral_name { get; set; }
        public bool? is_already_vaccinated { get; set; }
        public string department { get; set; }
        public bool is_hbv_detected { get; set; }
        public bool is_hcv_detected { get; set; }
        public int? token_no { get; set; }
        public bool is_assesment { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
