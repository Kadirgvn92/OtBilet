using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OtBilet.BusinessLayer.Abstract;
using OtBilet.EntityLayer;
using OtBilet.PresentationLayer.DTO.PassengerDTO;

namespace OtBilet.PresentationLayer.Controllers;
public class PassengerController : Controller
{
   private readonly IPassengerService _passengerService;

    public PassengerController(IPassengerService passengerService)
    {
        _passengerService = passengerService;
    }

    public IActionResult Index()
    {
        var values = _passengerService.TGetAll();
        return View(values);
    }
}
