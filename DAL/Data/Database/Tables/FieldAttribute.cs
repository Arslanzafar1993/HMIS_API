using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class FieldAttribute
    {
        public int id { get; set; }
        public string OnClickfunction { get; set; }
        public string Onblurfunction { get; set; }
        public string OnChangefunction { get; set; }
        public int? UI_DetailID { get; set; }
    }
}
