using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_new_regime_medicine
    {
        public int id { get; set; }
        public string medicine_name { get; set; }
        public string medicine_type { get; set; }
    }
}
