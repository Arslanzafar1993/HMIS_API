using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_sms_log
    {
        public int Id { get; set; }
        public string sms_type { get; set; }
        public string status { get; set; }
        public int? patient_id { get; set; }
        public string mrn_no { get; set; }
        public DateTime? created_date { get; set; }
        public string monbile_no { get; set; }
        public string response { get; set; }
        public string message { get; set; }
    }
}
