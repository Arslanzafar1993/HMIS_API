using AutoMapper;
using DAL.Data.Database.HMISDBContext;
using DAL.Data.Database.Tables;
using Models.Patient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DALFunctions.Patients
{
  public  class SamplingDAL
    {
        #region Class Level Fields and Objects
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public SamplingDAL(IMapper imapper)
        {
            _mapper = imapper;
        }
        #endregion
        #region SavePatientVitals
        public int AddSample(PatientSamplingDTO model)
        {
            int Result = 0;
            using (var db = new HMISDBContext())
            {
                var trans = db.Database.BeginTransaction();
                try
                {
                    var CurrentDate = DateTime.Now;
                    var PatientSample = this._mapper.Map<tbl_sample>(model);
                    db.tbl_samples.AddAsync(PatientSample);
                    db.SaveChanges();
                    trans.Commit();
                    Result = 1;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    Result = -1;
                }
                return Result;
            }
        }
        #endregion
    }
}
