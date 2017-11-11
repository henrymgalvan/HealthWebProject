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
            CreateMap<Person, PersonDetailModel>();
            CreateMap<PersonDetailModel, Person>();
        }
    }
}
