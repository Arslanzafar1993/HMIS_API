using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_lab_batch
    {
        public int id { get; set; }
        public string batch_number { get; set; }
        public int? user_id { get; set; }
        public int? assigned_to { get; set; }
        public int? assigned_by { get; set; }
        public int? created_time { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? UpdationTime { get; set; }
        public int? update_time { get; set; }
        public bool is_result { get; set; }
        public int? result_time { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
