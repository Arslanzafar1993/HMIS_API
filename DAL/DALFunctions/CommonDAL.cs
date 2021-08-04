using DAL.Data.Database.HMISDBContext;
using Models.Common;
using Models.HealthFacility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Models.Common.CommonModels;

namespace DAL
{
    public class CommonDAL
    {
        #region GetDropdowns
        public List<DDLModel> GetProvince()
        {
            try
            {
                using (var db = new HMISDBContext())
                {

                    return null;// db.TblLocation.Where(x => x.Type == "Province").OrderBy(x => x.Name).Select(x => new DDLModel { Id = x.Id, Code = x.Code, Name = x.Name }).ToList();


                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<DDLModel> GetDivision(string provinceCode)
        {
            try
            {
                using (var db = new HMISDBContext())
                {
                    return db.HealthFacilityDetails.OrderBy(x => x.DivisionName).Select(x => new DDLModel { Code = x.DivisionCode, Name = x.DivisionName }).Distinct().ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<DDLModel> GetDistrict(string divisionCode)
        {
            try
            {
                using (var db = new HMISDBContext())
                {

                    return db.HealthFacilityDetails.Where(a=>a.DivisionCode == divisionCode).OrderBy(x => x.DistrictName).Select(x => new DDLModel {  Code = x.DistrictCode, Name = x.DistrictName }).Distinct().ToList();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<DDLModel> GetTehsil(string districtCode)
        {
            try
            {
                using (var db = new HMISDBContext())
                {
                    var abc = db.HealthFacilityDetails.Where(a => a.DistrictCode == districtCode).OrderBy(x => x.TehsilName).Select(x => new DDLModel {  Code = x.TehsilCode, Name = x.TehsilName }).Distinct().ToList();
                    return abc;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<DDLModel> GetHealthfacilities(string tehsilCode = "",string HealthFacilityCode = "")
        {
            try
            {
                using (var db = new HMISDBContext())
                {
                    return db.HealthFacilityDetails.Where(a=>a.TehsilCode == (string.IsNullOrEmpty(tehsilCode) ? a.TehsilCode : tehsilCode) && a.Id.ToString() == (string.IsNullOrEmpty(HealthFacilityCode) ? a.Id.ToString() : HealthFacilityCode)).Select(x => new DDLModel { Code = x.HFMISCode, Name = x.FullName }).Distinct().ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public HealthFacilityListModel GetHealthFacilitiesData(string HealthFacilityCode = "")
        {
            try
            {
                using (var db = new HMISDBContext())
                {
                    return db.HealthFacilityDetails.Where(a => a.HFMISCode == HealthFacilityCode).Select(x => new HealthFacilityListModel
                    {
                        id = x.Id,
                        divisionCode = x.DivisionCode,
                        districtCode = x.DistrictCode,
                        tehsilCode = x.TehsilCode
                    }).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<DDLModel> GetAllRoles()
        {
            try
            {
                using (var db = new HMISDBContext())
                {
                    return null;// db.AspNetRoles.Select(x => new DDLRolesModel { Id = x.Id, Name = x.Name }).ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<DDLModel> GetOccupationList ()
        {
            try
            {
                using (var db = new HMISDBContext())
                {
                    return db.Occupations.Select(x => new DDLModel { Id = x.Id, Name = x.Name }).ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<DDLModel> GetDesignationList()
        {
            try
            {
                using (var db = new HMISDBContext())
                {
                    return db.Designations.Select(x => new DDLModel { Id = x.Id, Name = x.Name }).ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<DDLModel> GetMaritalStatusList()
        {
            try
            {
                using (var db = new HMISDBContext())
                {
                    return db.HealthFacilityDetails.Select(x => new DDLModel { Id = x.Id, Name = x.Name }).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        public String GetLastMRNO()
        {
            String LastMRNO = "";
            try
            {
                using (var db = new HMISDBContext())
                {
                   var Data = db.tbl_PatientRegistrations.Where(a => a.CreatedOn.Date == DateTime.Now.Date).OrderByDescending(a => a.id).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return LastMRNO;
        }

        #region CheckMRNO

        #endregion
       

    }
}
