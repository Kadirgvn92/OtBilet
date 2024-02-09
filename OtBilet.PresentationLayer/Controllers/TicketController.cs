using Microsoft.AspNetCore.Mvc;
using OtBilet.BusinessLayer.Abstract;
using OtBilet.DTOLayer.TicketDTO;
using OtBilet.EntityLayer;

namespace OtBilet.PresentationLayer.Controllers;
public class TicketController : Controller
{
    private readonly ITicketService _ticketService;
    private readonly IDestinationService _destinationService;
    private readonly IPassengerService _passengerService;
    public TicketController(ITicketService ticketService, IDestinationService destinationService, IPassengerService passengerService)
    {
        _destinationService = destinationService;
        _ticketService = ticketService;
        _passengerService = passengerService;
    }
    public IActionResult Index(int id)
    {

        var destination = _destinationService.GetDestinationByID(id);
        int seatNumber = Convert.ToInt32(Request.Query["seatNumber"]);
        var PNR = PNRGenerator.GeneratePNR();
        var passenger = _passengerService.TGetByID(1);
        
        Ticket ticket = new Ticket()
        {
            DestinationID = destination.DestinationID,
            SeatNumber = seatNumber,
            PassengerID = 1,
            PNR = PNR
        };


        _ticketService.TAdd(ticket);

        ViewBag.Destination = destination;
        ViewBag.SeatNumber = seatNumber;
        ViewBag.PNR = PNR;
        ViewBag.Passenger = passenger;

        var values = _ticketService.GetTicketByDestinationID(id);

        return View(values);

    }
    //[HttpPost]
    //public IActionResult Index(CreateTicketDTO dto)
    //{
    //    var destination = _destinationService.GetDestinationByID(dto.DestinationID);
    //    int seatNumber = Convert.ToInt32(Request.Query["seatNumber"]);
    //    _ticketService.TAdd(new Ticket()
    //    {
    //        DestinationID = destination.DestinationID,
    //        SeatNumber = seatNumber,
    //        PassengerID = 1,
    //        PNR = PNRGenerator.GeneratePNR()
    //    });

    //    _ticketService.TAdd(ticket);
    //    return RedirectToAction("Index", "Dashboard");
    //}
}
