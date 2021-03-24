using BAL.Services;
using HMIS_API.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Models.Common;
using Models.HealthFacility;
using Models.Users;
using HMIS_API.Models.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using BAL.Services;

namespace HMIS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        #region Fields
        private readonly IConfiguration _configuration;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private UserServices _userService;
        private CommonServices _Commonservice;
        private readonly UserRolesModel UserRolesModel;
        #endregion
        #region Constructor
        public UserController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            _configuration = configuration;
            _userService = new UserServices();
            _Commonservice = new CommonServices();
            UserRolesModel = new UserRolesModel();
        }

        #endregion

        #region GetUserForUpdate
        [HttpGet]
        [Route("GetUsersForupdate")]
        public async Task<IActionResult> GetUserForupdate(string userId)
        {
            ApplicationUser user = await userManager.FindByIdAsync(userId);
            HealthFacilityListModel HealthFacility = _Commonservice.GetHealthFacilityData(user.HealthFacilityCode);
            if (user != null)
            {
                RegisterModel Register = new RegisterModel
                {
                    UserID = userId,
                    Username = user.UserName,
                    CNIC = user.CNIC,
                    Email = user.Email,
                    ContactNumber = user.PhoneNumber,
                    Password = user.RawPassword,
                    ConfirmPassword = user.RawConfirmPassword,
                    StartRange = user.StartRange,
                    EndRange = user.EndRange,
                    Identifier = user.Identifer,
                    IMEI = user.IMEI,
                    tehsil = HealthFacility!=null ? HealthFacility.tehsilCode : "",
                    division = HealthFacility != null ? HealthFacility.divisionCode: "",
                    district = HealthFacility != null ? HealthFacility.districtCode : "",
                    HealthFacilityCode = HealthFacility!=null ? HealthFacility.id.ToString() : ""
                };
                return Ok(Register);
            }
            else
                return Ok(new Response { Status = "Failed", Message = "User Not Found!" });
        }
        #endregion

        #region GetUsersList
        [Authorize]
        [HttpPost]
        [Route("GetAllUsers")]
        public IActionResult GetAllUsers([FromBody] PaginationViewModel model)
        {
            try
            {
                var UserList = _userService.GetAllUsers(model);
                return Ok(new { UserList.Data, UserList.RecordsTotal });
            }
            catch (Exception ex)
            {
                return Ok(CommonUtility.GetExResponse<Exception>(ex));
            }
        }
        #endregion
        #region GetUserRoles
        [HttpGet]
        [Route("GetUserRoles")]
        public async Task<IActionResult> GetUserRoles(string userId)
        {
            try
            {

                UserRolesModel userRolesResult = await GetUserRolesAsync(userId);

                return Ok(new { allRoles = userRolesResult.AllRoles, userRoles = userRolesResult.UserRoles });
            }
            catch (Exception ex)
            {
                return Ok(CommonUtility.GetExResponse<Exception>(ex));
            }
        }
        public async Task<UserRolesModel> GetUserRolesAsync(string userId)
        {
            try
            {
                ApplicationUser applicationUser = await this.userManager.FindByIdAsync(userId);

                UserRolesModel.UserRoles = await this.userManager.GetRolesAsync(applicationUser);

                UserRolesModel.AllRoles = roleManager.Roles.OrderBy(x => x.Name).Select(y => y.Name).ToList();

                return UserRolesModel;
            }
            catch
            {
                throw;
            }
        }
        [HttpPost]
        [Route("AssignUserRoles")]
        public async Task<IActionResult> AssignUserRoles([FromBody] UserRoles userroles)
        {
            List<string> deleteRoleIds = new List<string>();
            List<string> addRoleIds = new List<string>();

            try
            {
                ApplicationUser user = await userManager.FindByIdAsync(userroles.UserId);

                if (user != null)
                {
                    foreach (string role in userroles.DeleteRoleId)
                    {
                        if (await userManager.IsInRoleAsync(user, role))
                        {
                            deleteRoleIds.Add(role);
                        }
                    }

                    foreach (string role in userroles.AddRoleId)
                    {
                        Debug.WriteLine(role);
                        if (!await userManager.IsInRoleAsync(user, role))
                        {
                            addRoleIds.Add(role);
                        }
                    }
                    await userManager.RemoveFromRolesAsync(user, deleteRoleIds);
                    await userManager.AddToRolesAsync(user, addRoleIds);
                }

                return Ok(new Response { Status = "Succeed", Message = "Roles Assigned Successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(CommonUtility.GetExResponse<Exception>(ex));
            }
        }
        #endregion
    }
}
