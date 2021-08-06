using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Patient
{
    public class MedicineStocksDTO
    {
        public string HEALTHCARE_FACILITY { get; set; }
        public int? medicine_id { get; set; }
        public double? SD_Stock_Entry { get; set; }
        public int remaining_stock { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
