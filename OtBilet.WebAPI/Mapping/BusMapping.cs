using AutoMapper;
using OtBilet.DTOLayer.BusDto;
using OtBilet.EntityLayer;

namespace OtBilet.WebAPI.Mapping;

public class BusMapping : Profile
{
    public BusMapping()
    {
        CreateMap<Bus, ResultBusDTO>().ReverseMap();
        CreateMap<Bus, CreateBusDTO>().ReverseMap();
        CreateMap<Bus, UpdateBusDTO>().ReverseMap();
    }
}
