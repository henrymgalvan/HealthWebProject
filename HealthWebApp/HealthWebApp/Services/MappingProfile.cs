using AutoMapper;
using HealthWebApp.Data.EntityModel;
using HealthWebApp.Models.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Person, PersonDetailModel>()
                .ForMember(dest => dest.ExtensionName, opt => opt.MapFrom(src => src.ExtensionName.ToString()))
                .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.DateOfBirth.ToString("yyyy, MMM-dd")))
                .ForMember(dest => dest.Sex, opt => opt.MapFrom(src => src.Sex.ToString())) 
                .ForMember(dest => dest.CivilStatus, opt => opt.MapFrom(src => src.CivilStatus.ToString()))
                .ForMember(dest => dest.Work, opt => opt.MapFrom(src => src.Work.ToString()))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.HouseholdMember.HouseholdProfile.Address))
                .ForMember(dest => dest.Barangay, opt => opt.MapFrom(src => src.HouseholdMember.HouseholdProfile.Barangay.Name))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.HouseholdMember.HouseholdProfile.Barangay.CityMunicipality.Name.ToString()))
                .ForMember(dest => dest.Province, opt => opt.MapFrom(src => src.HouseholdMember.HouseholdProfile.Barangay.CityMunicipality.Province.Name.ToString()))
                .ForMember(dest => dest.Region, opt => opt.MapFrom(src => src.HouseholdMember.HouseholdProfile.Barangay.CityMunicipality.Province.Region.Name.ToString()))
                .ForMember(dest => dest.PhilHealthID, opt => opt.MapFrom(src => src.PhilHealth.Identification.ToString()))
                .ForMember(dest => dest.Religion, opt => opt.MapFrom(src => src.Religion.LongName))
                .ForMember(dest => dest.Father, opt => opt.MapFrom(src => src.Father.FullName))
                .ForMember(dest => dest.Mother, opt => opt.MapFrom(src => src.Mother.FullName));

            .CreateMap<PersonCreateModel, Person>();

            .CreateMap<Person, PersonEditModel>();
            .CreateMap<PersonEditModel, Person>();
                  


        
        }
    }
}
