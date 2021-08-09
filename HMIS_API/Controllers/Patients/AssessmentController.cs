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
    public class AssessmentController : ControllerBase
    {
        #region Class Level Fields And Objects 

        private AssessmentServices _patientservices;
        #endregion
        #region Constructor
        public AssessmentController(IMapper mapper)
        {
            _patientservices = new AssessmentServices(mapper);
        }

        #endregion
        #region AddPatientAssessment
        [HttpPost]
        [Route("AddPatientAssessment")]
        public IActionResult AddPatientAssessment([FromBody] PatientAssessmentDTO model)
        {
            try
            {
                model.CreatedOn = CommonUtility.GetCurrentDate();
                int Result = _patientservices.AddAssesment(model);
                return Ok(Result);
            }
            catch (Exception ex) { return Ok(CommonUtility.GetExResponse<Exception>(ex)); }
        }
        #endregion
        #region AddFamilyAssessment
        [HttpPost]
        [Route("AddFamilyAssessment")]
        public IActionResult AddFamilyAssessment([FromBody] List<PatientFamilyAssessmentDTO> model)
        {
            try
            {
               // model.CreatedOn = CommonUtility.GetCurrentDate();
                int Result = _patientservices.AddFamilyAssessment(model);
                return Ok(Result);
            }
            catch (Exception ex) { return Ok(CommonUtility.GetExResponse<Exception>(ex)); }
        }
        #endregion
    }
}
