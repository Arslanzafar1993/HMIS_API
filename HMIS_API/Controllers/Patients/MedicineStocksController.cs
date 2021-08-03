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
    public class MedicineStocksController : ControllerBase
    {
        #region Class Level Fields And Objects 

        private MedicineStocksServices _patientservices;
        #endregion
        #region Constructor
        public MedicineStocksController(IMapper mapper)
        {
            _patientservices = new MedicineStocksServices(mapper);
        }

        #endregion
        #region AddMedicineStock
        [HttpPost]
        [Route("AddVitals")]
        public IActionResult AddMedicineStock([FromBody] MedicineStocksDTO model)
        {
            try
            {
                model.CreatedOn = CommonUtility.GetCurrentDate();
                int Result = _patientservices.AddMedicienStock(model);
                return Ok(Result);
            }
            catch (Exception ex) { return Ok(CommonUtility.GetExResponse<Exception>(ex)); }
        }
        #endregion
    }
}
