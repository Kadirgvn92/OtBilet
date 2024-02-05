using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OtBilet.BusinessLayer.Abstract;
using OtBilet.DTOLayer.DestinationDTO;
using OtBilet.EntityLayer;

namespace OtBilet.PresentationLayer.Controllers;
public class DestinationController : Controller
{
	private readonly IDestinationService _destinationService;

    public DestinationController(IDestinationService destinationService)
    {
        _destinationService = destinationService;
    }

    public IActionResult Index()
	{
		return View();
	}
    [HttpGet]
    public IActionResult CreateDestination()
    {
        List<SelectListItem> values = (from x in _destinationService.TGetAll()
                                       select new SelectListItem
                                       {
                                           Text = x.Departure.ToString(),
                                           Value = x.DestinationID.ToString()
                                       }).ToList();
        List<SelectListItem> values2 = (from x in _destinationService.TGetAll()
                                       select new SelectListItem
                                       {
                                           Text = x.Arrive.ToString(),
                                           Value = x.DestinationID.ToString()
                                       }).ToList();
        ViewBag.v = values;
        ViewBag.v2 = values2;
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> CreateDestination(CreateDestinationDTO destination)
    {

        Destination des = new Destination()
        {
            Arrive = destination.Arrive,
            Departure = destination.Departure,
            DepartureHour = destination.DepartureHour,
            DepatureDate = destination.DepatureDate,
            Price = destination.Price,
            BusID = destination.BusID,
        };

        _destinationService.TAdd(des);
        return RedirectToAction("Index", "Destination");
    }
}
