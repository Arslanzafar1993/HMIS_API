using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_uc
    {
        public int id { get; set; }
        public string uc_name { get; set; }
        public int? tehsil_id { get; set; }
        public int? tehsil_code { get; set; }
        public bool? is_active { get; set; }
    }
}
