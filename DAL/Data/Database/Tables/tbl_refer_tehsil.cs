using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_refer_tehsil
    {
        public int id { get; set; }
        public int? district_id { get; set; }
        public string name { get; set; }
        public string teshil_code { get; set; }
        public int? created { get; set; }
        public int? updated { get; set; }
        public bool status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
