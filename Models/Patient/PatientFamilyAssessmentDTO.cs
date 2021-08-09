using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Patient
{
   public class PatientFamilyAssessmentDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string CNIC { get; set; }
        public string Contact { get; set; }
        public string Relation { get; set; }
        public int parent_id { get; set; }
        public bool previous_hbv_test { get; set; }
        public bool previous_hcv_test { get; set; }
        public bool pcr_confirmation_hbv { get; set; }
        public bool pcr_confirmation_hcv { get; set; }
        public DateTime DOB { get; set; }
        
        public string mrn_no { get; set; }

    }
}
