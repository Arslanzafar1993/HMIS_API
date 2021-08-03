using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_health_facility_type
    {
        public int id { get; set; }
        public int hf_type_code { get; set; }
        public string health_facility_name { get; set; }
        public int sorting { get; set; }
    }
}
