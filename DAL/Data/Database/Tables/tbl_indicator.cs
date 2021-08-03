using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_indicator
    {
        public int id { get; set; }
        public string IndicatorID { get; set; }
        public int? category { get; set; }
        public string name { get; set; }
        public bool status { get; set; }
        public int sort_order { get; set; }
        public bool? weekly_report { get; set; }
    }
}
