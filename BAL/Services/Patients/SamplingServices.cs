using AutoMapper;
using DAL.DALFunctions;
using DAL.DALFunctions.Patients;
using Models.Patient;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.Services
{
   public class SamplingServices
    {
        #region Class Level Fields and Objects
        private SamplingDAL _PatientVitalsDAL;
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public SamplingServices(IMapper mapper)
        {
            _PatientVitalsDAL = new SamplingDAL(mapper);
            _mapper = mapper;
        }
        #endregion
        #region Add Patient
        public int AddSample (PatientSamplingDTO model)
        {
            return _PatientVitalsDAL.AddSample(model);
        }
        #endregion
    }
}
