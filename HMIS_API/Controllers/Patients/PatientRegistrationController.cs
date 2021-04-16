using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BAL.Services;
using HMIS_API.Models.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Common;
using Models.Patient;

namespace HMIS_API.Controllers.Patients
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientRegistrationController : ControllerBase
    {
        #region Class Level Fields And Objects 

        private PatientRegistrationsServices _patientservices;
        #endregion
        #region Constructor
        public PatientRegistrationController(IMapper mapper)
        {
            _patientservices = new PatientRegistrationsServices(mapper);
        }

        #endregion
        #region SavePatient
        [HttpPost]
        [Route("SavePatient")]
        public IActionResult SavePatient([FromBody] PatientRegistrationDTO model)
        {
            try
            {
                int Result = _patientservices.SavePatient(model);
                return Ok(Result);
            }
            catch (Exception ex) { return Ok(CommonUtility.GetExResponse<Exception>(ex)); }
        }
        #endregion
        #region GetAllPatientList
        [HttpPost]
        [Route("GetAllPatientList")]
        public IActionResult GetAllPatientList([FromBody] PaginationViewModel model)
        {
            try
            {
                var PatientList = _patientservices.GetAllPatientList(model);
                return Ok(new { PatientList.Data, PatientList.RecordsTotal });
            }
            catch (Exception ex)
            {
                return Ok(CommonUtility.GetExResponse<Exception>(ex));
            }
        }
        #endregion
        #region GetPatientData
        [HttpGet]
        [Route("GetPatientData")]
        public IActionResult GetPatientData(string CNIC)
        {
            try
            {
                var PatientList = _patientservices.GetPatientData(CNIC);
                return Ok(new { PatientList.Data, PatientList.RecordsTotal });
            }
            catch (Exception ex)
            {
                return Ok(CommonUtility.GetExResponse<Exception>(ex));
            }
        }
        #endregion
        #region GetPatientDataForUpdate
        [HttpGet]
        [Route("GetPatientDataForUpdate")]
        public IActionResult GetPatientDataForUpdate(int PatientID)
        {
            try
            {
                var PatientList = _patientservices.GetPatientDataForUpdate(PatientID);
                return Ok(PatientList);
            }
            catch (Exception ex)
            {
                return Ok(CommonUtility.GetExResponse<Exception>(ex));
            }
        }
        #endregion


    }
}
