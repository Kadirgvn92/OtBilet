using Microsoft.AspNetCore.Mvc;
using OtBilet.BusinessLayer.Abstract;
using OtBilet.DTOLayer.TicketDTO;
using OtBilet.EntityLayer;

namespace OtBilet.PresentationLayer.Controllers;
public class TicketController : Controller
{
    private readonly ITicketService _ticketService;

    public TicketController(ITicketService ticketService)
    {
        _ticketService = ticketService;
    }
    public IActionResult Index(int id)
    {
        var values = _ticketService.TCreateTicketByDestinationID(id);
        return View(values);
    }
    //[HttpPost]
    //public IActionResult Index(CreateTicketDTO dto)
    //{
    //    Ticket ticket = new Ticket()
    //    {
    //        DestinationID = dto.DestinationID,
    //        SeatID = dto.SeatID,
    //        PNR = PNRGenerator.GeneratePNR(),
            
    //    };

    //    _ticketService.TAdd(ticket);
    //    return RedirectToAction("Index","Dashboard");
    //}
}
