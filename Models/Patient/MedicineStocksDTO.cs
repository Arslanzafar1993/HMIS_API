using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Patient
{
    public class MedicineStocksDTO
    {
        public int id { get; set; }
        public int? hospital_id { get; set; }
        public int remaining { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
