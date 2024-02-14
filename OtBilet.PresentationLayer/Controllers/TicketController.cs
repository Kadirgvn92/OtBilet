using Humanizer;
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
    private readonly ISeatService _seatService;
    public TicketController(ITicketService ticketService, IDestinationService destinationService, IPassengerService passengerService, ISeatService seatService)
    {
        _destinationService = destinationService;
        _ticketService = ticketService;
        _passengerService = passengerService;
        _seatService = seatService;
    }
    public IActionResult Index(int id)
    {

        var destination = _destinationService.GetDestinationByID(id);
        var PNR = PNRGenerator.GeneratePNR();
        var passenger = _passengerService.TGetByID(1);
        var seat = Request.Query["seatNumber"];

        ViewBag.Destination = destination;
        ViewBag.PNR = PNR;
        ViewBag.Passenger = passenger;
        ViewBag.Firm = destination.Bus;
        ViewBag.SeatNumber = seat;

        return View();

    }

    public IActionResult CreateTicket(int id, int seatNumber)
    {

        var destination = _destinationService.GetDestinationByID(id);
        var PNR = PNRGenerator.GeneratePNR();
        var passenger = _passengerService.TGetByID(1);

        _ticketService.TAdd(new Ticket()
        {
            DestinationID = destination.DestinationID,
            SeatNumber = seatNumber,
            PassengerID = 1,
            PNR = PNR
        });

        ViewBag.Destination = destination;
        ViewBag.PNR = PNR;
        ViewBag.SeatNumber = seatNumber.ToString(); 
        ViewBag.Passenger = passenger;
        ViewBag.Price = destination.Price - (destination.Price * 18) / 100;
        ViewBag.KDV = (destination.Price * 18) / 100;
        ViewBag.Firm = destination.Bus;


        return View();
    }
}
