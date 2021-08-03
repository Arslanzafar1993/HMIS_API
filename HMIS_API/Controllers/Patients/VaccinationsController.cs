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
    public class VaccinationsController : ControllerBase
    {
        #region Class Level Fields And Objects 

        private VaccinationsServices _patientservices;
        #endregion
        #region Constructor
        public VaccinationsController(IMapper mapper)
        {
            _patientservices = new VaccinationsServices(mapper);
        }
        #endregion
        #region AddVaccination
        [HttpPost]
        [Route("AddVaccination")]
        public IActionResult AddVaccination([FromBody] PatientVaccinationDTO model)
        {
            try
            {
                model.CreatedOn = CommonUtility.GetCurrentDate();
                int Result = _patientservices.AddVaccination(model);
                return Ok(Result);
            }
            catch (Exception ex) { return Ok(CommonUtility.GetExResponse<Exception>(ex)); }
        }
        #endregion
    }
}
