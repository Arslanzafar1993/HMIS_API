using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_patient_refer_receive_history
    {
        public int id { get; set; }
        public long? patientID { get; set; }
        public string cnic { get; set; }
        public string investigation_nurse { get; set; }
        public string investigation_mo { get; set; }
        public string diagnosis { get; set; }
        public string symptoms { get; set; }
        public string medicine { get; set; }
        public int? created { get; set; }
        public int? created_by { get; set; }
        public bool? status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
