using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_family_assesment
    {
        public int id { get; set; }
        public string name { get; set; }
        public string CNIC { get; set; }
        public string Contact { get; set; }
        public string Relation { get; set; }
        public int? parent_id { get; set; }
        public bool? previous_hbv_test { get; set; }
        public bool? previous_hcv_test { get; set; }
        public bool? pcr_confirmation_hbv { get; set; }
        public bool? pcr_confirmation_hcv { get; set; }
        public DateTime? DOB { get; set; }
        public DateTime? created { get; set; }
        public int? created_by { get; set; }
        public DateTime? updated { get; set; }
        public int? updated_by { get; set; }
        public string mrn_no { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
