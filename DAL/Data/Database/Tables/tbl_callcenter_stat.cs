using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_callcenter_stat
    {
        public int id { get; set; }
        public int? number_of_calls { get; set; }
        public int? answered_calls { get; set; }
        public int? abandoned_calls { get; set; }
        public int? hepatitis { get; set; }
        public int? total_registration { get; set; }
        public int? samplereceived { get; set; }
        public int? date { get; set; }
        public DateTime? OriginalDate { get; set; }
        public int? user_id { get; set; }
        public int? created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
