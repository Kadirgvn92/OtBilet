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
         var values = Enum.GetValues(typeof(Departure))
                              .Cast<Departure>()
                              .Select(x => new SelectListItem
                              {
                                  Text = x.ToString(),
                                  Value = ((int)x).ToString()
                              })
                              .ToList();
        var values2 = Enum.GetValues(typeof(Arrive))
                           .Cast<Arrive>()
                           .Select(x => new SelectListItem
                           {
                               Text = x.ToString(),
                               Value = ((int)x).ToString()
                           })
                           .ToList();
        ViewBag.v = values;
        ViewBag.v2 = values2;
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> CreateDestination(CreateDestinationDTO destination)
    {
        if (destination.Departure.ToString() == destination.Arrive.ToString())
        {
            ModelState.AddModelError("", "Kalkış Noktası ile Varış Noktası aynı yer seçtiniz..Lütfen tekrar deneyin.");
            return View(destination);
        }
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
        return RedirectToAction("SearchDestination", "Dashboard");
    }
}
