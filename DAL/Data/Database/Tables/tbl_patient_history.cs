using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_patient_history
    {
        public long id { get; set; }
        public long? PatientID { get; set; }
        public int? transfer_id { get; set; }
        public int? transfer_in_facility { get; set; }
        public int? transfer_out_facility { get; set; }
        public int? created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
