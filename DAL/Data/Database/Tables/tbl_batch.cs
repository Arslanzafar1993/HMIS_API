using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_batch
    {
        public int id { get; set; }
        public string bactch_number { get; set; }
        public bool is_batch_dispatched { get; set; }
        public bool is_batch_received { get; set; }
        public int? user_hospital { get; set; }
        public int? user_id { get; set; }
        public int? created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
