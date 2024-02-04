using AutoMapper;
using OtBilet.DTOLayer.DestinationDTO;
using OtBilet.EntityLayer;

namespace OtBilet.PresentationLayer.Mapping;

public class DestinationMapping : Profile
{
    public DestinationMapping()
    {
        CreateMap<Destination,ResultDestinationDTO>().ReverseMap();
    }
}
