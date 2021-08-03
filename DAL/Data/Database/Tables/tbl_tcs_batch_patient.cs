using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_tcs_batch_patient
    {
        public int id { get; set; }
        public string batch_id { get; set; }
        public long? PatientID { get; set; }
        public long? consignment_no { get; set; }
        public int? no_of_dosage { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
