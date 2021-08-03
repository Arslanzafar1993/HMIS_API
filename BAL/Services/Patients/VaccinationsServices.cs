using AutoMapper;
using DAL.DALFunctions;
using DAL.DALFunctions.Patients;
using Models.Patient;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.Services
{
    public class VaccinationsServices
    {
        #region Class Level Fields and Objects
        private VaccinationsDAL _DAL;
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public VaccinationsServices(IMapper mapper)
        {
            _DAL = new VaccinationsDAL(mapper);
            _mapper = mapper;
        }
        #endregion
        #region AddVaccination
        public int AddVaccination(PatientVaccinationDTO model)
        {
            return _DAL.AddVaccination(model);
        }
        #endregion
    }
}
