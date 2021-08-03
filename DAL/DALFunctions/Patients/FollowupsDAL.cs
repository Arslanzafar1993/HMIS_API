using AutoMapper;
using DAL.Data.Database.HMISDBContext;
using DAL.Data.Database.Tables;
using Models.Patient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DALFunctions.Patients
{
  public  class FollowupsDAL
    {
        #region Class Level Fields and Objects
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public FollowupsDAL(IMapper imapper)
        {
            _mapper = imapper;
        }
        #endregion
        #region SavePatientFollowup
        public int AddFollowUp(PatientFollowupsDTO model)
        {
            int Result = 0;
            using (var db = new HMISDBContext())
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    var PatientVital = this._mapper.Map<tbl_patient_vital>(model);
                    db.tbl_patient_vitals.AddAsync(PatientVital);
                    db.SaveChanges();
                    Result = 1;
                }
                catch (Exception ex)
                {
                    Result = -1;
                }
                return Result;
            }
        }
        #endregion
    }
}
