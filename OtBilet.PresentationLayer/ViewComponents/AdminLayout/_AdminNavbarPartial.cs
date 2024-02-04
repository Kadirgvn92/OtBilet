using Microsoft.AspNetCore.Mvc;

namespace OtBilet.PresentationLayer.ViewComponents.AdminLayout;

public class _AdminNavbarPartial :ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
