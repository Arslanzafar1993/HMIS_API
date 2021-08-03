using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_patient_stage
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool? stage_status { get; set; }
    }
}
