using AutoMapper;
using DAL.DALFunctions;
using DAL.DALFunctions.Patients;
using Models.Patient;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.Services
{
    public class AssessmentServices
    {
        #region Class Level Fields and Objects
        private AssessmentDAL _DAL;
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public AssessmentServices(IMapper mapper)
        {
            _DAL = new AssessmentDAL(mapper);
            _mapper = mapper;
        }
        #endregion
        #region AddPatientAssessment
        public int AddAssesment(PatientAssessmentDTO model)
        {
            return _DAL.AddAssessment(model);
        }
        #endregion
    }
}
