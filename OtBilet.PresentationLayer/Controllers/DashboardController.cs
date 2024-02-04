using Microsoft.AspNetCore.Mvc;
using OtBilet.BusinessLayer.Abstract;
using OtBilet.DTOLayer.DestinationDTO;
using OtBilet.EntityLayer;

namespace OtBilet.PresentationLayer.Controllers;
public class DashboardController : Controller
{
	private readonly IDestinationService _destinationService;

    public DashboardController(IDestinationService destinationService)
    {
        _destinationService = destinationService;
    }

    public IActionResult Index(Destination destination2)
	{
		var values = _destinationService.TGetDestinationsByFilter(destination2);
		return RedirectToAction("SearchDestination");
	}

	//burada en son Index kısmında nereden nereye görsel oluşturduk daha sonra araya bastığında destination 
	//arama yapacak ve alttaki searchdestination methodu çalışacak ve liste diğer sayfada görülecek

	public IActionResult SearchDestination(Destination destination)
	{
		var values = _destinationService.TGetDestinationsByFilter(destination);
		return View(values);
	}
}
