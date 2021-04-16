using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class Patient_MRNO
    {
        public long id { get; set; }
        public string MRNO { get; set; }
        public int? patientID { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
