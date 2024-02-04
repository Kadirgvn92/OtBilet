using Microsoft.AspNetCore.Mvc;

namespace OtBilet.PresentationLayer.Controllers;
public class DashboardController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
