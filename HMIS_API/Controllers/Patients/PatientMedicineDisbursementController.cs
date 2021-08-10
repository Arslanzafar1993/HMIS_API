using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BAL.Services.Patients;
using HMIS_API.Models.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Patient;

namespace HMIS_API.Controllers.Patients
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientMedicineDisbursementController : ControllerBase
    {
        #region Class Level Fields And Objects 

        private MedicineDisbursementServices _patientservices;
        #endregion
        #region Constructor
        public PatientMedicineDisbursementController(IMapper mapper)
        {
            _patientservices = new MedicineDisbursementServices(mapper);
        }

        #endregion
        #region AddPatientMedicineDisbursement
        [HttpPost]
        [Route("AddMedicineDisbursement")]
        public IActionResult AddHCVMedicineDisbursement([FromBody] MedicineDisburementDTO model)
        {
            try
            {
               // model.CreatedOn = CommonUtility.GetCurrentDate();
                int Result = _patientservices.AddPatientMedicineDisbursement(model);
                return Ok(Result);
            }
            catch (Exception ex) { return Ok(CommonUtility.GetExResponse<Exception>(ex)); }
        }
        [HttpPost]
        [Route("AddMedicineDisbursement")]
        public IActionResult AddHBVMedicineDisbursement([FromBody] MedicineDisburementDTO model)
        {
            try
            {
                // model.CreatedOn = CommonUtility.GetCurrentDate();
                int Result = _patientservices.AddPatientMedicineDisbursement(model);
                return Ok(Result);
            }
            catch (Exception ex) { return Ok(CommonUtility.GetExResponse<Exception>(ex)); }
        }
        #endregion
    }
}
