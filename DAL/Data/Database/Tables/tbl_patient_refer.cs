using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_patient_refer
    {
        public int id { get; set; }
        public long? PatientID { get; set; }
        public int? refer_in_facility { get; set; }
        public int? refer_in_tehsil { get; set; }
        public int? refer_in_district { get; set; }
        public int? refer_in_province { get; set; }
        public int? refer_out_facility { get; set; }
        public string refer_request_date { get; set; }
        public DateTime? refer_requestdate { get; set; }
        public string action_date { get; set; }
        public DateTime? actiondate { get; set; }
        public string refer_status { get; set; }
        public int? created_by { get; set; }
        public int? created { get; set; }
        public string patient_stage { get; set; }
        public string patient_type { get; set; }
        public string refer_reason { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
