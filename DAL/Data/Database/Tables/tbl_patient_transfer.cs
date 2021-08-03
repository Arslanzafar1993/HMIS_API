using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_patient_transfer
    {
        public int id { get; set; }
        public long PatientID { get; set; }
        public int? transfer_in_facility { get; set; }
        public string transfer_in_facility_name { get; set; }
        public int? transfer_out_facility { get; set; }
        public string transfer_request_date { get; set; }
        public DateTime? transfer_requestdate { get; set; }
        public string action_date { get; set; }
        public DateTime? Actiondate { get; set; }
        public string transfer_status { get; set; }
        public int? created_by { get; set; }
        public int? created { get; set; }
        public string patient_stage { get; set; }
        public string patient_type { get; set; }
        public string Vaccination { get; set; }
        public int? Vaccination_doses_count { get; set; }
        public string screening_hbv { get; set; }
        public string screening_hcv { get; set; }
        public int? hbv_med_delivered { get; set; }
        public int? hcv_med_delivered { get; set; }
        public int? hbv_followups { get; set; }
        public int? hcv_followups { get; set; }
        public string hbv_medicine_name { get; set; }
        public string hcv_medicine_name { get; set; }
        public string transfer_reason { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
