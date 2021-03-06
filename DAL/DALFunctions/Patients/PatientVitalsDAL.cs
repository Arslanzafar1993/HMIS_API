using AutoMapper;
using DAL.Data.Database.HMISDBContext;
using DAL.Data.Database.Tables;
using Models.Patient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DALFunctions.Patients
{
  public  class PatientVitalsDAL
    {
        #region Class Level Fields and Objects
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public PatientVitalsDAL(IMapper imapper)
        {
            _mapper = imapper;
        }
        #endregion
        #region SavePatientVitals
        public int AddPatientVitals(PatientVitalsDTO model)
        {
            int Result = 0;
            using (var db = new HMISDBContext())
            {
                try
                {
                    model.CreatedOn = DateTime.Now;
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
