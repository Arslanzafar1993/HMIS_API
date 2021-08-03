using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_event
    {
        public int id { get; set; }
        public string event_name { get; set; }
        public string industry { get; set; }
        public int? start_date { get; set; }
        public int? end_date { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string address { get; set; }
        public string description { get; set; }
        public int? division_id { get; set; }
        public int? district_id { get; set; }
        public int? tehsil_id { get; set; }
        public int? hospital_id { get; set; }
        public bool? status { get; set; }
        public int? created_by { get; set; }
        public int? created { get; set; }
        public int? updated_by { get; set; }
        public int? updated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
