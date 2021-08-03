using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_patient_factor
    {
        public long id { get; set; }
        public long PatientID { get; set; }
        public int? xFactor { get; set; }
        public int? yFactor { get; set; }
        public int? zFactor { get; set; }
        public int aFactor { get; set; }
        public int bFactor { get; set; }
        public int? cFactor { get; set; }
        public int? dFactor { get; set; }
        public int? eFactor { get; set; }
        public int? fFactor { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
