using AutoMapper;
using Tripforo.Models.ViewModels.Supplier;
using Tripforo.Repository.EFCoreModels.ScaffoldedEntity;

namespace Tripforo.Service
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AirLineName, AirLineNameViewModel>()
       .ForMember(dest => dest.AirLineCode, o => o.MapFrom(src => src.AlCode))
       .ForMember(dest => dest.AirportName, o => o.MapFrom(src => src.AlName))
       .ForMember(dest => dest.Id, o => o.MapFrom(src => src.Counter));

        }
    }
}
