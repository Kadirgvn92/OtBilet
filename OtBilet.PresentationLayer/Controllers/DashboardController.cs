using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OtBilet.BusinessLayer.Abstract;
using OtBilet.DTOLayer.DestinationDTO;
using OtBilet.EntityLayer;
using OtBilet.PresentationLayer.Models;
using System;

namespace OtBilet.PresentationLayer.Controllers;
public class DashboardController : Controller
{
	private readonly IDestinationService _destinationService;
    private readonly ISeatService _seatService;

    public DashboardController(IDestinationService destinationService, ISeatService seatService)
    {
        _destinationService = destinationService;
        _seatService = seatService;
    }
    public IActionResult Index()
    {
        return View();
    }


    [HttpGet]
    public IActionResult SearchDestination()
    {

        var departure = Enum.GetValues(typeof(Departure))
                               .Cast<Departure>()
                               .Select(x => new SelectListItem
                               {
                                   Text = x.ToString(),
                                   Value = ((int)x).ToString()
                               })
                               .ToList();

        var arrive = Enum.GetValues(typeof(Arrive))
                                .Cast<Arrive>()
                                .Select(x => new SelectListItem
                                {
                                    Text = x.ToString(),
                                    Value = ((int)x).ToString()
                                })
                                .ToList();

        ViewBag.Departure = departure;
        ViewBag.Arrive = arrive;
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
