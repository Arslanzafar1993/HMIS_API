using AutoMapper;
using DAL.Data.Database.HMISDBContext;
using DAL.Data.Database.Tables;
using Microsoft.Extensions.Configuration;
using Models.Common;
using Models.HealthFacility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class HospitalDAL
    {
        #region Class Level Fields and Objects
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public HospitalDAL(IMapper imapper)
        {
            _mapper = imapper;
        }
        #endregion
        public int SaveHospital(HealthFacilityModel model)
        {
            using (var db = new HMISDBContext())
            {
                try
                {
                    if (model != null && !string.IsNullOrEmpty(model.HFMISCode))
                    {
                        var HealthFacility = db.HealthFacilityDetails.Where(a => a.HFMISCode == model.HFMISCode).FirstOrDefault();
                        if (string.IsNullOrEmpty(HealthFacility.HFMISCode))
                        {
                            var UpdatedHealthFacility = this._mapper.Map<HealthFacilityModel, HealthFacilityDetail>(model, HealthFacility);
                            db.Entry(UpdatedHealthFacility).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        }
                    }
                    else
                    {
                        var NewHF = this._mapper.Map<HealthFacilityDetail>(model);
                        NewHF.HFMISCode = NewHF.DivisionCode + NewHF.DistrictCode + NewHF.TehsilCode;
                        db.HealthFacilityDetails.AddAsync(NewHF);
                    }
                    db.SaveChanges();
                    return 1;
                }
                catch(Exception ex) 
                {
                    return -1;
                }
            }
        }
        public PaginationResult<HealthFacilityListModel> GetHospitalList(PaginationViewModel model)
        {
            try
            {
                using (var db = new HMISDBContext())
                {
                    var HospitalList = (from HF in db.HealthFacilityDetails
                                  select new HealthFacilityListModel
                                  {
                                      id  = HF.Id,
                                      HFMISCode = HF.HFMISCode,
                                      DivisionName = HF.DivisionName,
                                      DistrictName = HF.DistrictName,
                                      TehsilName = HF.TehsilName,
                                      HospitalName = HF.FullName
                                  }).ToList().AsQueryable();
                    var TotalCount = HospitalList.Count();
                    HospitalList = HospitalList.OrderByDescending(x => x.id).Skip((model.Page - 1) * (model.PageSize)).Take(model.PageSize);
                    var res = HospitalList.OrderByDescending(a=>a.id).ToList();
                    return new PaginationResult<HealthFacilityListModel> { Data = res, RecordsTotal = TotalCount };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public HealthFacilityModel GetHealthFacilityData(string HFMISCode)
        {
            try
            {
                using (var db = new HMISDBContext())
                {
                    HealthFacilityModel HealthFacility;
                    HealthFacility = db.HealthFacilityDetails.Where(a => a.HFMISCode == HFMISCode).Select(x => new HealthFacilityModel
                    {
                        id = x.Id,
                        HFMISCode = x.DivisionCode + x.DistrictCode + x.TehsilCode,
                        DivisionCode = x.DivisionCode,
                        DistrictCode = x.DistrictCode,
                        TehsilCode = x.TehsilCode,
                        HospitalName = x.FullName
                    }).FirstOrDefault();
                    return HealthFacility;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object DeleteHealthFacility(string HFMISCode)
        { 
            try
            {
                using (var db = new HMISDBContext())
                {
                    var HealthFacility = db.HealthFacilityDetails.Where(a => a.HFMISCode == HFMISCode).FirstOrDefault();
                    if(HealthFacility !=null && HealthFacility.HFMISCode == HFMISCode)
                    {
                        db.HealthFacilityDetails.Remove(HealthFacility);
                        db.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
