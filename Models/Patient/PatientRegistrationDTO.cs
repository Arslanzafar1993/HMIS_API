using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Patient
{
    public class PatientRegistrationDTO
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PatientName { get; set; }
        public string SWO { get; set; }
        public string CNICStatus { get; set; }
        public string CNIC { get; set; }
        public string Gender { get; set; }
        public DateTime? DOB { get; set; }
        public int? Age { get; set; }
        public string Guardian_or_Self { get; set; }
        public string GuardianRelation { get; set; }
        public string MRNO { get; set; }
        public string MaritalStatus { get; set; }
        public int? OccupationID { get; set; }
        public int? QualificationID { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string DivisionCode { get; set; }
        public string DistrictCode { get; set; }
        public string TehsilCode { get; set; }
        public string Address { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}
