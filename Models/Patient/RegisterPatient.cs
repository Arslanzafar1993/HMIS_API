using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Patient
{
    public class RegisterPatient
    {
        public string EntryType { get; set; }
        public string CnicStatus { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Cnic { get; set; }
        public string Swo { get; set; }
        public DateTimeOffset Dob { get; set; }
        public double Age { get; set; }
        public string Gender { get; set; }
        public string MartialStatus { get; set; }
        public double Occcupation { get; set; }
        public double Qualification { get; set; }
        public string ContactNo { get; set; }
        public string OtherContactNo { get; set; }
        public string Address { get; set; }
        public string HealthFacilityCode { get; set; }
        public string DiagnosedHbvViaRs { get; set; }
        public string DiagnosedHcvViaRs { get; set; }
        public string PcrConfirmationHbv { get; set; }
        public string PcrConfirmationHcv { get; set; }
        public string PatientType { get; set; }
        public string CompletedVaccinationHbv { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public double PatientID { get; set; }
        
    }
}
