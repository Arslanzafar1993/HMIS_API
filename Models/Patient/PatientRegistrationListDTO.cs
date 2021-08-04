using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Patient
{
    public class PatientRegistrationListDTO
    {
        public long Id { get; set; }
        public string PatientName { get; set; }
        public string SWO { get; set; }
        public string CNIC { get; set; }
        public DateTime? DOB { get; set; }
        public string Gender { get; set; }
        public bool? Isguardian { get; set; }
        public string MRNO { get; set; }
        public string GuardianRelation { get; set; }
        public string Mobile { get; set; }
        public string HealthFacility { get; set; }
        public int? Age { get; set; }
    }
}
