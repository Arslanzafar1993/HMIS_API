using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_bp_normalization
    {
        public int id { get; set; }
        public int? pid { get; set; }
        public int? sample_id { get; set; }
        public int? pulse { get; set; }
        public int? systolic { get; set; }
        public int? diastolic { get; set; }
        public int? weight { get; set; }
        public string baseline_type { get; set; }
        public int? created { get; set; }
        public int? updated { get; set; }
        public int? created_by { get; set; }
        public int? updated_by { get; set; }
    }
}
