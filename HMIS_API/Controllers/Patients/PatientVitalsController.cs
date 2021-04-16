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
    public class PatientVitalsController : ControllerBase
    {
        #region Class Level Fields And Objects 

        private PatientVitalsServices _patientservices;
        #endregion
        #region Constructor
        public PatientVitalsController(IMapper mapper)
        {
            _patientservices = new PatientVitalsServices(mapper);
        }

        #endregion
        #region AddVitals
        [HttpPost]
        [Route("AddVitals")]
        public IActionResult AddVitals([FromBody] PatientVitalsDTO model)
        {
            try
            {
                model.CreatedOn = CommonUtility.GetCurrentDate();
                int Result = _patientservices.AddVitals(model);
                return Ok(Result);
            }
            catch (Exception ex) { return Ok(CommonUtility.GetExResponse<Exception>(ex)); }
        }
        #endregion
    }
}
