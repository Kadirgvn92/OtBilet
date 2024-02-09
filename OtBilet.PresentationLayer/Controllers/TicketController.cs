using Microsoft.AspNetCore.Mvc;
using OtBilet.BusinessLayer.Abstract;
using OtBilet.DTOLayer.TicketDTO;
using OtBilet.EntityLayer;

namespace OtBilet.PresentationLayer.Controllers;
public class TicketController : Controller
{
    private readonly ITicketService _ticketService;
    private readonly IDestinationService _destinationService;
    public TicketController(ITicketService ticketService, IDestinationService destinationService)
    {
        _destinationService = destinationService;
        _ticketService = ticketService;
    }

    public IActionResult Index(int id)
    {

        var destination = _destinationService.GetDestinationByID(id);
        int seatNumber = Convert.ToInt32(Request.Query["seatNumber"]);

        _ticketService.TAdd(new Ticket()
        {
            DestinationID = destination.DestinationID,
            SeatNumber = seatNumber,
            PassengerID = 1,
            PNR = PNRGenerator.GeneratePNR()
        });

        var values = _ticketService.GetTicketByDestinationID(id);

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
