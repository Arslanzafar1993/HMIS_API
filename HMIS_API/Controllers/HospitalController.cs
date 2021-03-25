using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BAL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Models.Common;
using Models.HealthFacility;
using HMIS_API.Models.Common;

namespace HMIS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        #region Class Level Fields And Objects 

        private HospitalServices _hospitalservices;
        #endregion
        #region Constructor
        public HospitalController(IMapper mapper)
        {
            _hospitalservices = new HospitalServices(mapper);
        }

        #endregion
        #region GetHospitalList
        [HttpPost]
        [Route("GetHospitalList")]
        public IActionResult GetHospitalList([FromBody] PaginationViewModel model)
        {
            try
            {
                var HospitalList = _hospitalservices.GetHospitalList(model);
                return Ok(new { HospitalList.Data, HospitalList.RecordsTotal });
            }
            catch (Exception ex)
            {
                return Ok(CommonUtility.GetExResponse<Exception>(ex));
            }
        }
        #endregion
        #region RegisterHospital
        [HttpPost]
        [Route("RegisterHospital")]
        public IActionResult SaveHospital([FromBody] HealthFacilityModel model)
        {
            try
            {
                int Result = _hospitalservices.SaveHospital(model);
                return Ok(Result);
            }
            catch (Exception ex) { return Ok(CommonUtility.GetExResponse<Exception>(ex)); }
        }
        #endregion
        #region GetHealthFacilityForUpdate
        [HttpGet]
        [Route("GetHealthFacilityForUpdate")]
        public IActionResult GetHealthFacility(string HFMISCode)
        {
            try
            {
                var HospitalList = _hospitalservices.GetHealthFacility(HFMISCode);
                return Ok(CommonUtility.GetResponse(HospitalList));
            }
            catch (Exception ex)
            {
                return Ok(CommonUtility.GetExResponse<Exception>(ex));
            }
        }
        #endregion
        #region DeleteHealthFacility
        [HttpGet]
        [Route("DeleteHealthFacility")]
        public IActionResult DeleteHealthFacility(string HFMISCode)
        {
            try
            {
                var Response = _hospitalservices.DeleteHealthFacility(HFMISCode);
                return Ok(CommonUtility.GetResponse(Response));
            }
            catch (Exception ex)
            {
                return Ok(CommonUtility.GetExResponse<Exception>(ex));
            }
        }
        #endregion
    }
}
