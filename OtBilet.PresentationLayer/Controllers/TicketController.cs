using Microsoft.AspNetCore.Mvc;
using OtBilet.BusinessLayer.Abstract;

namespace OtBilet.PresentationLayer.Controllers;
public class TicketController : Controller
{
    private readonly ITicketService _ticketService;

    public TicketController(ITicketService ticketService)
    {
        _ticketService = ticketService;
    }

    public IActionResult Index()
    {
        var values = _ticketService.TGetAll();
        return View(values);
    }
}
