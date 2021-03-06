using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BAL.Services;
using HMIS_API.Models.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Patient;

namespace HMIS_API.Controllers.Patients
{
    [Route("api/[controller]")]
    [ApiController]
    public class FollowupsController : ControllerBase
    {
        #region Class Level Fields And Objects 

        private FollowupsServices _patientservices;
        #endregion
        #region Constructor
        public FollowupsController(IMapper mapper)
        {
            _patientservices = new FollowupsServices(mapper);
        }

        #endregion
        #region AddPatientFollowup
        [HttpPost]
        [Route("AddPatientFollowup")]
        public IActionResult AddPatientFollowup([FromBody] PatientFollowupsDTO model)
        {
            try
            {
               // model.CreatedOn = CommonUtility.GetCurrentDate();
                int Result = _patientservices.AddFollowUp(model);
                return Ok(Result);
            }
            catch (Exception ex) { return Ok(CommonUtility.GetExResponse<Exception>(ex)); }
        }
        [HttpGet]
        [Route("AddPatientFollowup")]
        public IActionResult GetPatientFollowup(string SearchValue ,string Type)
        {
            try
            {
                // model.CreatedOn = CommonUtility.GetCurrentDate();
                int Result = -1;//_patientservices.GetPatientFollowup(SearchValue,Type);
                return Ok(Result);
            }
            catch (Exception ex) { return Ok(CommonUtility.GetExResponse<Exception>(ex)); }
        }
        #endregion
    }
}
