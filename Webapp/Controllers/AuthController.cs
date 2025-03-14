using Microsoft.AspNetCore.Mvc;

namespace Webapp.Controllers;

public class AuthController : Controller
{
    public IActionResult Login()
    {
        return LocalRedirect("/projects");
        //return View();
    }
}
