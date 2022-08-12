using AutoMapper;
using myApp.Core.Dtos;
using myApp.Core.Models;

namespace myApp.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Device, DeviceDto>().ReverseMap();
            CreateMap<ActiveWorks, ActiveWorksDto>().ReverseMap();
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<TechnicalService, TechnicalServiceDto>().ReverseMap();
        }
    }
}
