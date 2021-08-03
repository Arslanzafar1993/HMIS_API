using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_medicine_disbursement_old_regime
    {
        public int id { get; set; }
        public long? PatientID { get; set; }
        public bool dose_delivered_by_hand { get; set; }
        public int? no_of_med_given { get; set; }
        public bool patient_demote { get; set; }
        public string demote_status { get; set; }
        public DateTime created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
