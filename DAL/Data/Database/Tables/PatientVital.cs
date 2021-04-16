using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class PatientVital
    {
        public long Id { get; set; }
        public long PatientRegistrationId { get; set; }
        public double? Temperature { get; set; }
        public double? BloodpressureSystolic { get; set; }
        public double? BloodpressureDiastolic { get; set; }
        public double? Weight { get; set; }
        public string GrowthStatus { get; set; }
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
        public bool? IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string NutritionistStatus { get; set; }
        public double? BloodSugarReport { get; set; }
    }
}
