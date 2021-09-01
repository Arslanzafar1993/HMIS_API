using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_lost_followup_reason
    {
        public int Id { get; set; }
        public string Reason { get; set; }
        public DateTime? created { get; set; }
    }
}
