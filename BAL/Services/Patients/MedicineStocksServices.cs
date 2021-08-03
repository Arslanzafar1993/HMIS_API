using AutoMapper;
using DAL.DALFunctions;
using DAL.DALFunctions.Patients;
using Models.Patient;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.Services
{
   public class MedicineStocksServices
    {
        #region Class Level Fields and Objects
        private MedicineStocksDAL _PatientVitalsDAL;
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public MedicineStocksServices(IMapper mapper)
        {
            _PatientVitalsDAL = new MedicineStocksDAL(mapper);
            _mapper = mapper;
        }
        #endregion
        #region Add Patient
        public int AddMedicienStock(MedicineStocksDTO model)
        {
            return _PatientVitalsDAL.AddMedicienStock(model);
        }
        #endregion
    }
}
