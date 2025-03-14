using Microsoft.AspNetCore.Mvc;

namespace Webapp.Controllers;

public class AuthController : Controller
{
    public IActionResult Register()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }
}
