using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OtBilet.BusinessLayer.Abstract;
using OtBilet.DAL.Context;

namespace OtBilet.WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PassengerController : ControllerBase
{
    private readonly IPassengerService _passengerService;

    public PassengerController(IPassengerService passengerService)
    {
        _passengerService = passengerService;
    }
    [HttpGet]
    public IActionResult GetPassanger()
    {
        var values =  _passengerService.TGetAll();
        return Ok(values);  
    }
}
