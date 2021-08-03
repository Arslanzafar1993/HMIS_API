using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_new_regime_stock_log
    {
        public int id { get; set; }
        public int? medicine_id { get; set; }
        public int? district_id { get; set; }
        public int? tehsil_id { get; set; }
        public int? hospital_id { get; set; }
        public int? quantity { get; set; }
        public long? PatientID { get; set; }
        public int? created { get; set; }
        public int? created_by { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
