using Microsoft.AspNetCore.Mvc;

namespace OtBilet.PresentationLayer.ViewComponents.AdminLayout;

public class _AdminSidebarPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
