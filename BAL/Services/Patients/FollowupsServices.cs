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
        private FollowupsDAL _DAL;
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public FollowupsServices(IMapper mapper)
        {
            _DAL = new FollowupsDAL(mapper);
            _mapper = mapper;
        }
        #endregion
        #region AddFollowUp
        public int AddFollowUp(PatientFollowupsDTO model)
        {
            return _DAL.AddFollowUp(model);
        }
        #endregion
    }
}
