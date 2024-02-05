using Microsoft.AspNetCore.Mvc;
using OtBilet.BusinessLayer.Abstract;

namespace OtBilet.PresentationLayer.ViewComponents.Dashboard;

public class _DashboardSearchBusPartial : ViewComponent
{
    private readonly IDestinationService _destinationService;

    public _DashboardSearchBusPartial(IDestinationService destinationService)
    {
        _destinationService = destinationService;
    }

    public IViewComponentResult Invoke()
    {
        return View();  
    }
}
