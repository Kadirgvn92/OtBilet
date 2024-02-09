using AutoMapper;
using OtBilet.DTOLayer.SeatDTO;
using OtBilet.EntityLayer;

namespace OtBilet.PresentationLayer.Mapping;

public class SeatMapping : Profile
{
    public SeatMapping()
    {
        CreateMap<Seat, SeatNumberDTO>().ReverseMap();
    }
}
