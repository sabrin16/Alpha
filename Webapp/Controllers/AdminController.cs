﻿using Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace Webapp.Controllers;

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

    [HttpPost]

    public IActionResult AddClient(AddClientForm form)
    {
        if (!ModelState.IsValid)
            return RedirectToAction("Client");

        return View();
    }

    [HttpPost]

    public IActionResult EditClient(AddClientForm form)
    {
        if (!ModelState.IsValid)
            return RedirectToAction("Client");

        return View();
    }
}
