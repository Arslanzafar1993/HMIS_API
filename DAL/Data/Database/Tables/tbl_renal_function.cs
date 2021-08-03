using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_renal_function
    {
        public int id { get; set; }
        public int? pid { get; set; }
        public int? sample_id { get; set; }
        public int? urea { get; set; }
        public decimal? creatinie { get; set; }
        public int? blood_sugar_random { get; set; }
        public string baseline_type { get; set; }
        public int? created { get; set; }
        public int? updated { get; set; }
        public int? created_by { get; set; }
        public int? updated_by { get; set; }
    }
}
