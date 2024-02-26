using nApplication.Features.someFeature.Commands.CreateSomeFeature;
using nApplication.Features.someFeature.Dtos;
using AutoMapper;
using nDomain.Entities;

namespace nApplication.Features.someFeature.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {

            CreateMap<SomeFeatureEntity, CreatedSomeFeatureEntityDto>().ReverseMap();
            CreateMap<SomeFeatureEntity, CreateSomeFeatureEntityCommand>().ReverseMap();
        }
    }
}
