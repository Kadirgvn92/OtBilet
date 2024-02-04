using Microsoft.AspNetCore.Mvc;
namespace OtBilet.PresentationLayer.ViewComponents.AdminLayout;

public class _AdminHeaderPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
