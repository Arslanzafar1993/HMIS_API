using AutoMapper;
using Models.Common;
using Models.HealthFacility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMIS_API.Models.Common
{
    public class AutoMapperProfile
    {
        public class HealthFaciityProfile : Profile
        {
            public HealthFaciityProfile()
            {
                //CreateMap<HealthFacilityModel, tbl_health_facility>()
                //    .ForMember(destination => destination.id,
                //    options => options.MapFrom(source => source.ID))
                //    .ForMember(destination => destination.division_code,
                //    options => options.MapFrom(source => source.DivisionCode))
                //    .ForMember(destination => destination.district_code,
                //    options => options.MapFrom(source => source.DistrictCode))
                //    .ForMember(destination => destination.tehsil_code,
                //    options => options.MapFrom(source => source.TehsilCode))
                //   .ForMember(destination => destination.hf_name,
                //    options => options.MapFrom(source => source.HospitalName));

            }
        }
    }
}
