using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_new_regime_med_log
    {
        public int id { get; set; }
        public long? PatientID { get; set; }
        public int? hospital_id { get; set; }
        public string baseline_type { get; set; }
        public int? no_of_dosage { get; set; }
        public int? medicine_id { get; set; }
        public bool? is_demote { get; set; }
        public int? created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
