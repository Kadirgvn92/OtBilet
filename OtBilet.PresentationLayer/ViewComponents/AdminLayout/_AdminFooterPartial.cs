﻿using Microsoft.AspNetCore.Mvc;

namespace OtBilet.PresentationLayer.ViewComponents.AdminLayout;

public class _AdminFooterPartial :ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();  
    }
}
