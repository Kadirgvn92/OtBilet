using Microsoft.AspNetCore.Mvc;

namespace OtBilet.PresentationLayer.Controllers;
public class DestinationController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
