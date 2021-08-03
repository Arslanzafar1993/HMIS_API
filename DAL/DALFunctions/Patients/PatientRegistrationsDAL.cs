using AutoMapper;
using DAL.Data.Database.HMISDBContext;
using DAL.Data.Database.Tables;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Models.Common;
using Models.Patient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.DALFunctions
{
    public class PatientRegistrationsDAL
    {
        #region Class Level Fields and Objects
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public PatientRegistrationsDAL(IMapper imapper)
        {
            _mapper = imapper;
        }
        #endregion
        #region Save Patient
        public int SavePatient(PatientRegistrationDTO model)
        {
            int Result = 0;
            using (var db = new HMISDBContext())
            {
                var trans = db.Database.BeginTransaction();
                try
                {
                    if (model != null && !string.IsNullOrEmpty(model.CNIC))
                    {
                        var PatientData = db.tbl_PatientRegistrations.Where(a => a.id == model.ID).FirstOrDefault();
                        if (PatientData != null)
                        {
                            var UpdatedHealthFacility = this._mapper.Map<PatientRegistrationDTO, tbl_PatientRegistration>(model, PatientData);
                            db.Entry(UpdatedHealthFacility).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        }
                        else
                        {
                            var CurrentDate = DateTime.Now;
                            var NewPatient = this._mapper.Map<tbl_PatientRegistration>(model);
                            db.tbl_PatientRegistrations.AddAsync(NewPatient);
                        }
                    }
                    else
                    {
                        Result = -1;
                    }

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
        #region GetPatientDataForUpdate
        public DataTable GetPatientDataForUpdate(int PatientID)
        {
            DataTable dt = new DataTable();
            using (var db = new HMISDBContext())
            {
                var conn = (SqlConnection)db.Database.GetDbConnection();
                try
                {
                    DataSet ds = new DataSet();
                    SqlCommand sqlComm = new SqlCommand("GetPatientList", conn);
                    sqlComm.Parameters.AddWithValue("@PatientID", PatientID);
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = sqlComm;
                    da.Fill(ds);
                    dt = ds.Tables[0];
                    return dt;
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        #endregion
        #region GetAllPatientList
        public DataTable GetAllPatientList(PaginationViewModel paginatedDTO, string CNIC = "")
        {
            DataTable dt = new DataTable();
            using (var db = new HMISDBContext())
            {
                var conn = (SqlConnection)db.Database.GetDbConnection();
                try
                {
                    DataSet ds = new DataSet();
                    SqlCommand sqlComm = new SqlCommand("GetPatientList", conn);
                    sqlComm.Parameters.AddWithValue("@vCNIC", CNIC);
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = sqlComm;
                    da.Fill(ds);
                    dt = ds.Tables[0];
                    return dt;
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        #endregion
    }
}
