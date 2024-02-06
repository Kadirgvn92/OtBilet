using AutoMapper;
using OtBilet.DTOLayer.TicketDTO;
using OtBilet.EntityLayer;

namespace OtBilet.PresentationLayer.Mapping;

public class TicketMapping : Profile
{
    public TicketMapping()
    {
        CreateMap<Ticket, CreateTicketDTO>().ReverseMap();
    }
}
