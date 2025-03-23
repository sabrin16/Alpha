﻿using Business.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Webapp.Controllers;

[Authorize]
[Route("admin")]

public class AdminController : Controller
{

    [Route("members")]

    public IActionResult Members()
    {
        return View();
    }

    [Route("clients")]

    public IActionResult Clients()
    {
        return View();
    }
}