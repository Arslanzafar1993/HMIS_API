using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_labortary
    {
        public int id { get; set; }
        public string NAME { get; set; }
        public bool IsEnable { get; set; }
        public string CREATED_BY { get; set; }
        public string CREATION_DATE { get; set; }
        public string UPDTED_BY { get; set; }
        public string UPDATION_DATE { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
