using AutoMapper;
using DAL.DALFunctions.Patients;
using Models.Patient;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.Services.Patients
{
    public class MedicineDisbursementServices
    {
        #region Class Level Fields and Objects
        private MedicineDisbursementDAL _DAL;
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public MedicineDisbursementServices(IMapper mapper)
        {
            _DAL = new MedicineDisbursementDAL(mapper);
            _mapper = mapper;
        }
        #endregion
        #region AddPatientMedicineDisbursement
        public int AddPatientMedicineDisbursement(MedicineDisburementDTO model)
        {
            return _DAL.AddPatientMedicineDisbursement(model);
        }
        #endregion
    }
}
