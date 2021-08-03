using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_dispatch
    {
        public int id { get; set; }
        public string batchno { get; set; }
        public string courier { get; set; }
        public string consignment { get; set; }
        public string name { get; set; }
        public string cnic { get; set; }
        public string contactno { get; set; }
        public string designation { get; set; }
        public string organization { get; set; }
        public int? created { get; set; }
        public int? user_id { get; set; }
        public bool dispatchmade { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
