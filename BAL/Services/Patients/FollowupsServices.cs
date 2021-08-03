using AutoMapper;
using DAL.DALFunctions;
using DAL.DALFunctions.Patients;
using Models.Patient;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.Services
{
   public class FollowupsServices
    {
        #region Class Level Fields and Objects
        private FollowupsDAL _PatientVitalsDAL;
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public FollowupsServices(IMapper mapper)
        {
            _PatientVitalsDAL = new FollowupsDAL(mapper);
            _mapper = mapper;
        }
        #endregion
        #region Add Patient
        public int AddFollowUp(PatientFollowupsDTO model)
        {
            return _PatientVitalsDAL.AddFollowUp(model);
        }
        #endregion
    }
}
