using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_tcs_batch
    {
        public int id { get; set; }
        public string batch_type { get; set; }
        public string batch_number { get; set; }
        public int? user_id { get; set; }
        public string hfc_address { get; set; }
        public int? created { get; set; }
        public int? updated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
