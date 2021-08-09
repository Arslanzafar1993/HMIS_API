using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_cbc_parameter
    {
        public int id { get; set; }
        public int? pid { get; set; }
        public int? hemoglobin { get; set; }
        public int? ast { get; set; }
        public int? alt { get; set; }
        public int? platelet { get; set; }
        public int? tlc { get; set; }
        public string apri { get; set; }
        public int? viral_count { get; set; }
        public string pcr_result { get; set; }
        public int? sample_id { get; set; }
        public string baseline_type { get; set; }
        public int? follow_up_no { get; set; }
        public string lab_name { get; set; }
        public string other_lab_name { get; set; }
        public string result_type { get; set; }
        public int? created { get; set; }
        public int? updated { get; set; }
        public int? created_by { get; set; }
        public int? updated_by { get; set; }
    }
}
