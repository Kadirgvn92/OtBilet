using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    [HttpGet]
    public IActionResult Index()
    {
        
        return View();
    }

    [HttpGet]
    public IActionResult SearchDestination()
    {
        return View(); 
    }

    [HttpPost]
    public IActionResult SearchDestination(SearchDestinationDTO destinationDTO)
    {

        if (destinationDTO.Departure.ToString() == destinationDTO.Arrive.ToString())
        {
            ModelState.AddModelError("", "Kalkış Noktası ile Varış Noktası aynı yer seçilemez.Lütfen tekrar deneyin.");
            return View(destinationDTO);
        }
        // _destinationService.TGetDestinationsByFilter metodunu kullanarak destinasyonları çektim
        var destinations = _destinationService.TGetDestinationsByFilter(destinationDTO);

        // Elde ettiğin destinasyonları bir view'e gönderdim
        return View("Index", destinations);
    }
}
