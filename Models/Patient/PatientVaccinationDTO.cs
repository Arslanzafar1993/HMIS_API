using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Patient
{
    public class PatientVaccinationDTO
    {
        public long id { get; set; }
        public long PatientID { get; set; }
        public int stage { get; set; }
        public int dose_date { get; set; }
        public DateTime? Dosedate { get; set; }
        public int created { get; set; }
        public int updated { get; set; }
        public int user_id { get; set; }
        public int? user_hospital { get; set; }
        public int? updated_by { get; set; }
        public string entry_type { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
