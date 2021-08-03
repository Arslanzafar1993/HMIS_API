using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_patient_refer_receive
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string self_cnic { get; set; }
        public string mrn_no { get; set; }
        public string father_name { get; set; }
        public string dob { get; set; }
        public int? age { get; set; }
        public int? gender { get; set; }
        public string contact_no_self { get; set; }
        public int? division_id { get; set; }
        public int? district_id { get; set; }
        public int? tehsil_id { get; set; }
        public int? hospital_id { get; set; }
        public string req_hospital { get; set; }
        public string req_dept { get; set; }
        public string receive_date { get; set; }
        public string refer_status { get; set; }
        public int? created_by { get; set; }
        public int? created { get; set; }
        public string refer_reason { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
