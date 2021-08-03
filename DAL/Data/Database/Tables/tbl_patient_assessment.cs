using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_patient_assessment
    {
        public long id { get; set; }
        public bool frequent_therapeutic_injections { get; set; }
        public bool confirmed_case_of_stds { get; set; }
        public bool invasive_medical_and_surgical_intervention { get; set; }
        public bool close_contact_of_a_known_case_of_hcv_hbv { get; set; }
        public bool blood_transfusion { get; set; }
        public bool confirmed_hiv_positive_persons { get; set; }
        public bool ever_been_hospitalized { get; set; }
        public bool individuals_with_tattooing_ear_nose_piercing { get; set; }
        public bool injectable_drug_user { get; set; }
        public bool dental_intervention { get; set; }
        public bool history_of_multiple_sex_partners { get; set; }
        public bool truck_driver_or_transgender { get; set; }
        public bool jaundice { get; set; }
        public bool unexplained_fever { get; set; }
        public bool dark_colored_urine { get; set; }
        public bool loss_of_appetite { get; set; }
        public bool light_colored_faeces { get; set; }
        public bool fatigue { get; set; }
        public bool muscle_pain { get; set; }
        public bool nausea { get; set; }
        public bool stomach_ache { get; set; }
        public bool right_upper_quadrant_tenderness { get; set; }
        public bool gastric_irritation_burning { get; set; }
        public bool unusual_urethral_discharge { get; set; }
        public int? created { get; set; }
        public int? updated { get; set; }
        public int? user_id { get; set; }
        public int? user_hospital { get; set; }
        public long? PatientID { get; set; }
        public string note { get; set; }
        public bool? is_new_patient { get; set; }
        public bool? pcr { get; set; }
        public string pcr_option { get; set; }
        public bool? vaccination { get; set; }
        public bool? is_hbv_test { get; set; }
        public bool? is_hcv_test { get; set; }
        public bool? raPatientID_testing { get; set; }
        public bool? counselling { get; set; }
        public bool? vacination { get; set; }
        public bool? is_sample_svr { get; set; }
        public bool? is_legacy_svr { get; set; }
        public string surgery_type { get; set; }
        public string surgery_when { get; set; }
        public string blood_transfusion_when { get; set; }
        public string blood_bank { get; set; }
        public bool? hospitalization_within_last_2_years { get; set; }
        public string dental_clinic { get; set; }
        public bool? close_contact_is_on_treatment { get; set; }
        public bool? is_already_vaccinated { get; set; }
        public int? no_of_doses_taken { get; set; }
        public int? vac_dose_date_1 { get; set; }
        public int? vac_dose_date_2 { get; set; }
        public DateTime? vac_dose_date1 { get; set; }
        public DateTime? vac_dose_date2 { get; set; }
        public bool? vac_administered { get; set; }
        public int? dose_eligibility { get; set; }
        public bool? is_temporary_delete { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
