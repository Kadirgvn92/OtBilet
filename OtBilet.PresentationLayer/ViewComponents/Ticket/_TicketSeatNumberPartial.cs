using Microsoft.AspNetCore.Mvc;

namespace OtBilet.PresentationLayer.ViewComponents.Ticket;

public class _TicketSeatNumberPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();  
    }
}
