using AutoMapper;
using DAL;
using Models.Common;
using Models.HealthFacility;
using System;

namespace BAL.Services
{
    public class HospitalServices
    {
        #region Class Level Fields and Objects
        private HospitalDAL _HospitalDAL;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public HospitalServices(IMapper mapper)
        {
            _HospitalDAL = new HospitalDAL(mapper);
            _mapper = mapper;
        }
        #endregion

        public int SaveHospital(HealthFacilityModel model)
        {
            return _HospitalDAL.SaveHospital(model);
        }
        #region GetHospitalList
        public PaginationResult<HealthFacilityListModel> GetHospitalList(PaginationViewModel model)
        {
            try
            {
                PaginationResult<HealthFacilityListModel> UserResult;
                UserResult = _HospitalDAL.GetHospitalList(model);
                return UserResult;
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region GetHealthFacilityForUpdate
        public HealthFacilityModel GetHealthFacility(string HFCode)
        {
            try
            {
                HealthFacilityModel HealthFacility;
                HealthFacility = _HospitalDAL.GetHealthFacilityData(HFCode);
                return HealthFacility;
            }
            catch(Exception)
            {
                throw;
            }
        }
        #endregion
        #region DeleteHealthFacility
        public object DeleteHealthFacility(string HFMISCode)
        {
            try
            {
                 _HospitalDAL.DeleteHealthFacility(HFMISCode);
                return true;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        #endregion

    }
}
