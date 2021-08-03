using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_PatientRegistration
    {
        public long id { get; set; }
        public string EntryType { get; set; }
        public string CNICStatus { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CNIC { get; set; }
        public string FatherName { get; set; }
        public DateTime? DOB { get; set; }
        public double? Age { get; set; }
        public string Gender { get; set; }
        public string MartialStatus { get; set; }
        public int? Occcupation { get; set; }
        public int? Qualification { get; set; }
        public string ContactNo { get; set; }
        public string OtherContactNo { get; set; }
        public string Address { get; set; }
        public string HealthFacilityCode { get; set; }
        public string UserHealthFacilityCode { get; set; }
        public string Previous_HCV { get; set; }
        public string Previous_HBV { get; set; }
        public string PCRConfirmation_HBV { get; set; }
        public string PCRConfirmation_HCV { get; set; }
        public string PatientType { get; set; }
        public string CompletedVaccination_HBV { get; set; }
        public bool? patient_age_80 { get; set; }
        public string finger_print1 { get; set; }
        public string finger_print2 { get; set; }
        public bool? is_pregnant { get; set; }
        public DateTime? dod_date { get; set; }
        public bool? is_re_register { get; set; }
        public int? lost_followup_id { get; set; }
        public bool? is_lmp_date { get; set; }
        public bool? is_blood_bank_patient { get; set; }
        public bool? is_reg_completed { get; set; }
        public int? bbl_user_id { get; set; }
        public bool? is_patient_prison { get; set; }
        public bool? is_annual_pcr { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
