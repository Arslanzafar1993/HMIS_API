using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_refer_hospital
    {
        public int id { get; set; }
        public string clinic_name { get; set; }
        public string clinic_code { get; set; }
        public string city { get; set; }
        public int? province_id { get; set; }
        public int? district_id { get; set; }
        public int? tehsil_id { get; set; }
        public string clinic_address { get; set; }
        public string clinic_lat { get; set; }
        public string clinic_lon { get; set; }
        public bool is_pacslink { get; set; }
        public string status { get; set; }
        public int? created { get; set; }
        public int? updated { get; set; }
        public int? clinic_code_no { get; set; }
        public string clinic_type { get; set; }
        public string facility_type { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
