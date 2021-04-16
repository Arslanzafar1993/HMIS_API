using AutoMapper;
using BAL.Services.Common;
using DAL;
using DAL.DALFunctions;
using Models.Common;
using Models.Patient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BAL.Services
{
  public  class PatientRegistrationsServices
    {
        #region Class Level Fields and Objects
        private PatientRegistrationsDAL _PatientDAL;
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public PatientRegistrationsServices(IMapper mapper)
        {
            _PatientDAL = new PatientRegistrationsDAL(mapper);
            _mapper = mapper;
        }
        #endregion
        #region Add Patient
        public int SavePatient(PatientRegistrationDTO model)
        {
            model.MRNO = CreateMRNO();
             model.CreatedOn = DateTime.Now;
            model.CreatedBy = "New User";
            if (model.DOB != null)
            {
                model.Age = (int?)(DateTime.Now.Year - model.DOB?.Year);
            }
            return _PatientDAL.SavePatient(model);
        }
        public String CreateMRNO()
        {
            try
            {
                CommonDAL CS = new CommonDAL();
                var Date = DateTime.Now;
                var MRNO = "";
                String LastMRNO = CS.GetLastMRNO();
                if (string.IsNullOrEmpty(LastMRNO))
                    MRNO = "MRNO-" + Date.ToString("yy") + Date.ToString("MM") + Date.ToString("dd") + "-" + 1;
                else
                {
                    var MRData = LastMRNO.Split('-');
                    if(MRData != null && MRData.Length > 0 && MRData.Length == 3)
                    {
                        MRNO = "MRNO-" + Date.ToString("yy") + Date.ToString("MM") + Date.ToString("dd") + "-" + (Convert.ToInt32(MRData[2])+1);
                    }
                }
                return MRNO;
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion
        #region GetAllPatientList
        public PaginationResult<PatientRegistrationListDTO> GetAllPatientList(PaginationViewModel model)
        {
            try
            {
                CommonUtility Common = new CommonUtility();
                DataTable dt = _PatientDAL.GetAllPatientList(model);
                List<PatientRegistrationListDTO> PatientResult = Common.ConvertDataTableToList<PatientRegistrationListDTO>(dt);
                return new PaginationResult<PatientRegistrationListDTO> { Data = PatientResult, RecordsTotal = PatientResult.Count };
              
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region GetPatientData
        public PaginationResult<PatientRegistrationListDTO> GetPatientData(string CNIC)
        {
            try
            {
                CommonUtility Common = new CommonUtility();
                DataTable dt = _PatientDAL.GetAllPatientList(null,CNIC);
                List<PatientRegistrationListDTO> PatientResult = Common.ConvertDataTableToList<PatientRegistrationListDTO>(dt);
                return new PaginationResult<PatientRegistrationListDTO> { Data = PatientResult, RecordsTotal = PatientResult.Count };
            }
            catch
            {
                throw;
            }
        }
        #endregion
        #region GetPatientDataForUpdate
        public dynamic GetPatientDataForUpdate(int PatientID)
        {
            try
            {
                CommonUtility Common = new CommonUtility();
                DataTable dt = _PatientDAL.GetPatientDataForUpdate(PatientID);
                List<PatientRegistrationDTO> PatientResult = Common.ConvertDataTableToList<PatientRegistrationDTO>(dt);
                dynamic PatientData = PatientResult[0];
                return PatientData;
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}
