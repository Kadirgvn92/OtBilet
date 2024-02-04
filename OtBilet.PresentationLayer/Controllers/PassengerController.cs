using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OtBilet.EntityLayer;
using OtBilet.PresentationLayer.DTO.PassengerDTO;

namespace OtBilet.PresentationLayer.Controllers;
public class PassengerController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public PassengerController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:44366/api/Passenger");
		if (responseMessage.IsSuccessStatusCode)
		{
			var jsonData = await responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<List<Passenger>>(jsonData);
			return View(values);
		}
		return View();
	}
}
