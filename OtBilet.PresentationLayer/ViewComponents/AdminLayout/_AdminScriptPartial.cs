using Microsoft.AspNetCore.Mvc;

namespace OtBilet.PresentationLayer.ViewComponents.AdminLayout;

public class _AdminScriptPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();  
    }
}
