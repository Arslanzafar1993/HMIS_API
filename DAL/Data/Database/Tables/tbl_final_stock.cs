using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_final_stock
    {
        public int id { get; set; }
        public string HEALTHCARE_FACILITY { get; set; }
        public int? medicine_id { get; set; }
        public string DISTRICTS { get; set; }
        public double? SD_Stock_Entry { get; set; }
        public int remaining_stock { get; set; }
        public int? Hospital_ID { get; set; }
        public int? District { get; set; }
        public int? Tehsil { get; set; }
        public int? remaining_stock_2 { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
