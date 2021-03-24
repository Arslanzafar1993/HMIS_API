using Microsoft.AspNetCore.Identity;
using Models.Users;
using HMIS_API.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMIS_API.Services
{
    public class UserService
    {
        private readonly UserManager<ApplicationUser> userManager;

        public UserService(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }
        public async Task UpdateUser(ApplicationUser UserInfo, RegisterModel model)
        {
            string Response = "";
            if (UserInfo != null)
            {
                UserInfo.UserName = model.Username;
                UserInfo.CNIC = model.CNIC;
                UserInfo.Email = model.Email;
                UserInfo.PhoneNumber = model.ContactNumber;
                UserInfo.HealthFacilityCode = model.HealthFacilityCode;
                UserInfo.StartRange = model.StartRange;
                UserInfo.EndRange = model.EndRange;
                UserInfo.Identifer = model.Identifier;
                UserInfo.IMEI = model.IMEI;
                UserInfo.UpdatedOn = DateTime.Now;
                await userManager.UpdateAsync(UserInfo);
                Response = "Success";
            }
            else
            {
                Response = "Failure";
            }
        }
    }
}
