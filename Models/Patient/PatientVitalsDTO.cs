using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Patient
{
    public class PatientVitalsDTO
    {
        public long PatientRegistrationId { get; set; }
        public double? Temperature { get; set; }
        public double? BloodpressureSystolic { get; set; }
        public double? BloodpressureDiastolic { get; set; }
        public double? Weight { get; set; }
        public double? Hip { get; set; }
        public double? Waist { get; set; }
        public double? HipWaistStatus { get; set; }
        public double? HeightInInch { get; set; }
        public double? BodyMassIndex { get; set; }
        public string BodyMassIndexStatus { get; set; }
        public string Mauc { get; set; }
        public string Abdominal { get; set; }
        public string Pefr { get; set; }
        public double? HeadCir { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string NutritionistStatus { get; set; }
        public double? BloodSugarReport { get; set; }
    }
}
