using AutoMapper;
using DAL.DALFunctions;
using DAL.DALFunctions.Patients;
using Models.Patient;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.Services
{
   public class PatientVitalsServices
    {
        #region Class Level Fields and Objects
        private PatientVitalsDAL _PatientVitalsDAL;
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public PatientVitalsServices(IMapper mapper)
        {
            _PatientVitalsDAL = new PatientVitalsDAL(mapper);
            _mapper = mapper;
        }
        #endregion
        #region Add Patient
        public int AddVitals(PatientVitalsDTO model)
        {
            return _PatientVitalsDAL.AddPatientVitals(model);
        }
        #endregion
    }
}
