using Microsoft.AspNetCore.Mvc;

namespace Webapp.Controllers;

[Route("projects")]

public class ProjectsController : Controller
{
    [Route("")]

    public IActionResult Projects()
    {
        return View();
    }
}
