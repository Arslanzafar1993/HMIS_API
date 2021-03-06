using AutoMapper;
using DAL.Data.Database.HMISDBContext;
using DAL.Data.Database.Tables;
using Models.Patient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DALFunctions.Patients
{
  public  class VaccinationsDAL
    {
        #region Class Level Fields and Objects
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public VaccinationsDAL(IMapper imapper)
        {
            _mapper = imapper;
        }
        #endregion
        #region AddVaccination
        public int AddVaccination(PatientVaccinationDTO model)
        {
            int Result = 0;
            using (var db = new HMISDBContext())
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    var PatientVaccination = this._mapper.Map<tbl_patientvaccination>(model);
                    db.tbl_patientvaccinations.AddAsync(PatientVaccination);
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
