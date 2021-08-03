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
        private SamplingDAL _DAL;
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public SamplingServices(IMapper mapper)
        {
            _DAL = new SamplingDAL(mapper);
            _mapper = mapper;
        }
        #endregion
        #region AddSample
        public int AddSample (PatientSamplingDTO model)
        {
            return _DAL.AddSample(model);
        }
        #endregion
    }
}
