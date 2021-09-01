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
    public class SamplingController : ControllerBase
    {
        #region Class Level Fields And Objects 

        private SamplingServices _patientservices;
        #endregion
        #region Constructor
        public SamplingController(IMapper mapper)
        {
            _patientservices = new SamplingServices(mapper);
        }

        #endregion
        #region AddPatientSample
        [HttpPost]
        [Route("AddPatientSample")]
        public IActionResult AddPatientSample ([FromBody] PatientSamplingDTO model)
        {
            try
            {
                model.CreatedOn = CommonUtility.GetCurrentDate();
                int Result = _patientservices.AddSample(model);
                return Ok(Result);
            }
            catch (Exception ex) { return Ok(CommonUtility.GetExResponse<Exception>(ex)); }
        }
        #endregion
    }
}
