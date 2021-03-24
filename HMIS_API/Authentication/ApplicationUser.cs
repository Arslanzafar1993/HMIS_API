using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace HMIS_API.Authentication
{
    public class ApplicationUser: IdentityUser
    {
        [MaxLength(50)]
        public string CNIC { get; set; }
        public string RawPassword { get; set; }
        [MaxLength(120)]
        public string RawConfirmPassword { get; set; }
        [MaxLength(120)]
        public string HashConfirmPassword { get; set; }
        [MaxLength(200)]
        public string HealthFacilityCode { get; set; }
        [MaxLength(50)]
        public string StartRange { get; set; }
        [MaxLength(50)]
        public string EndRange { get; set; }
        [MaxLength(100)]
        public string Identifer { get; set; }
        [MaxLength(50)]
        public string IMEI { get; set; }
        public bool Status { get; set; }
        public bool? IsDeleted { get; set; }
        [MaxLength(200)]
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        [MaxLength(200)]
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        [MaxLength(200)]
        public string DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
