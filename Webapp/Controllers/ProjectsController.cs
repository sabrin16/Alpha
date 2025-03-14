using Microsoft.AspNetCore.Mvc;

namespace Webapp.Controllers;

public class ProjectsController : Controller
{
    [Route("projects")]

    public IActionResult Projects()
    {
        return View();
    }
}
