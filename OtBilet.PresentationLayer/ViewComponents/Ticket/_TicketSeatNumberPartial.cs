using Microsoft.AspNetCore.Mvc;
using OtBilet.BusinessLayer.Abstract;

namespace OtBilet.PresentationLayer.ViewComponents.Ticket;

public class _TicketSeatNumberPartial : ViewComponent
{
    private readonly ISeatService _seatService;

    public _TicketSeatNumberPartial(ISeatService seatService)
    {
        _seatService = seatService;
    }

    public IViewComponentResult Invoke(int id)
    {
        var values = _seatService.TGetSeatsByBusID(id);
        return View(values);  
    }
}
