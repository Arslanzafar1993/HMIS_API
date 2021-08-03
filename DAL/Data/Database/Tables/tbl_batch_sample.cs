using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_batch_sample
    {
        public long id { get; set; }
        public int? sample_number { get; set; }
        public int? batch_id { get; set; }
        public int? user_id { get; set; }
        public int? created { get; set; }
        public int? updated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
