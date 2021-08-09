using AutoMapper;
using Models.Common;
using DAL.Data.Database.Tables;
using Models.HealthFacility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.Patient;

namespace HMIS_API.Models.Common
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<HealthFacilityModel, HealthFacilityDetail>()
                .ForMember(destination => destination.Id,
                options => options.MapFrom(source => source.id))
                .ForMember(destination => destination.DivisionCode,
                options => options.MapFrom(source => source.DivisionCode))
                .ForMember(destination => destination.DistrictCode,
                options => options.MapFrom(source => source.DistrictCode))
                .ForMember(destination => destination.TehsilCode,
                options => options.MapFrom(source => source.TehsilCode))
                .ForMember(destination => destination.FullName,
                options => options.MapFrom(source => source.HospitalName));
            CreateMap<PatientRegistrationDTO, tbl_PatientRegistration>();
            CreateMap<PatientVitalsDTO, tbl_patient_vital>();

            CreateMap<MedicineStocksDTO, tbl_final_stock>();
            CreateMap<PatientAssessmentDTO, tbl_patient_assessment>();
            CreateMap<PatientFamilyAssessmentDTO, tbl_family_assesment>();
            CreateMap<PatientFollowupsDTO, tbl_patient_vital>();
            CreateMap<PatientSamplingDTO, tbl_sample>();
            CreateMap<PatientVaccinationDTO, tbl_patientvaccination>();
        }
    }
}
