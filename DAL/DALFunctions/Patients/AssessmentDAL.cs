using AutoMapper;
using DAL.Data.Database.HMISDBContext;
using DAL.Data.Database.Tables;
using Models.Patient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DALFunctions.Patients
{
  public  class AssessmentDAL
    {
        #region Class Level Fields and Objects
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public AssessmentDAL(IMapper imapper)
        {
            _mapper = imapper;
        }
        #endregion
        #region SaveAssessement
        public int AddAssessment(PatientAssessmentDTO model)
        {
            int Result = 0;
            using (var db = new HMISDBContext())
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    var PatientVital = this._mapper.Map<tbl_patient_assessment>(model);
                    db.tbl_patient_assessments.AddAsync(PatientVital);
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
        #region SaveAssessement
        public int AddFamilyAssessment(List<PatientFamilyAssessmentDTO> model)
        {
            int Result = 0;
            using (var db = new HMISDBContext())
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    var PatientVital = this._mapper.Map<List<tbl_family_assesment>>(model);
                    db.tbl_family_assesments.AddRangeAsync(PatientVital);
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
