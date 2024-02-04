using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OtBilet.DAL.Context;

namespace OtBilet.WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PassengerController : ControllerBase
{
    private readonly OtBiletDbContext _db;

    public PassengerController(OtBiletDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public IActionResult GetPassenger()
    {
        var values = _db.Passengers.ToList();
        return Ok(values);
    }
}
