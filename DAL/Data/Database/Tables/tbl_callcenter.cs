using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_callcenter
    {
        public int id { get; set; }
        public string mrn_no { get; set; }
        public int? age { get; set; }
        public string name { get; set; }
        public string fathername { get; set; }
        public int? gender { get; set; }
        public int? cnic_status { get; set; }
        public string self_cnic { get; set; }
        public string next_of_kin_cnic { get; set; }
        public string no_cnic_reason { get; set; }
        public int? division { get; set; }
        public int? district { get; set; }
        public int? tehsil { get; set; }
        public int? hospital { get; set; }
        public string address { get; set; }
        public string land_mark { get; set; }
        public string contact_phone { get; set; }
        public string alt_phone { get; set; }
        public int? no_of_dependents { get; set; }
        public string monthly_income { get; set; }
        public int? hbv { get; set; }
        public int? hcv { get; set; }
        public string lab_name { get; set; }
        public DateTime? test_date { get; set; }
        public int user_id { get; set; }
        public int? created { get; set; }
        public string created_b { get; set; }
        public bool is_patient { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
