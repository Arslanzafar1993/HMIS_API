using AutoMapper;
using DAL.Data.Database.HMISDBContext;
using DAL.Data.Database.Tables;
using Models.Patient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DALFunctions.Patients
{
   public class MedicineDisbursementDAL
    {
        #region Class Level Fields and Objects
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public MedicineDisbursementDAL(IMapper imapper)
        {
            _mapper = imapper;
        }
        #endregion
        #region AddMedicineStock
        public int AddPatientMedicineDisbursement(MedicineDisburementDTO model)
        {
            int Result = 0;
            using (var db = new HMISDBContext())
            {
                var trans = db.Database.BeginTransaction();
                try
                {
                    var MedicineDisbursement = this._mapper.Map<tbl_drug_interaction_med_sec>(model);
                    db.tbl_drug_interaction_med_secs.AddAsync(MedicineDisbursement);

                    var CBCParameters = this._mapper.Map<tbl_cbc_parameter>(model);
                    db.tbl_cbc_parameters.AddAsync(CBCParameters);

                    var Renalfunctions = this._mapper.Map<tbl_renal_function>(model);
                    db.tbl_renal_functions.AddAsync(Renalfunctions);

                    db.SaveChanges();
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
