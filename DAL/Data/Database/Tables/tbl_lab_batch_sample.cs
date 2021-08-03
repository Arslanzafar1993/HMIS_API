using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_lab_batch_sample
    {
        public int id { get; set; }
        public int? sample_id { get; set; }
        public int? batch_id { get; set; }
        public bool is_discard { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
