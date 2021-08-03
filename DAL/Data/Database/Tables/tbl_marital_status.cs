using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_marital_status
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? status { get; set; }
    }
}
