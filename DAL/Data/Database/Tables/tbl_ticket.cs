using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_ticket
    {
        public long id { get; set; }
        public int md_id { get; set; }
        public string ticket_id { get; set; }
        public int sender { get; set; }
        public string message { get; set; }
        public string status { get; set; }
        public int created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
