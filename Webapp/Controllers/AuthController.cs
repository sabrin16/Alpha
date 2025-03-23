using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Webapp.Models;
using Webapp.Services;

namespace Webapp.Controllers;

public class AuthController(UserService userService, SignInManager<AppUser> signInManager) : Controller
{
    private readonly UserService _userService;
    private readonly SignInManager<AppUser> _signInManager = SignInManager;

    public AuthController(UserService userService)
    {
        _userService = userService;
    }

    public IActionResult Login()
    {
        return LocalRedirect("/projects");
        //return View();
    }

        public IActionResult SignUp()
        {
            return View();
        }

    [HttpPost]
    public async Task<IActionResult> SignUp(UserSignUpForm form) 
    {
        if (!ModelState.IsValid)
            return View(form);

        if (await _userService.ExistsAsync(form.Email))
        {
            ModelState.AddModelError("Exists", "User already exists.");
            return View(form);
        }

        var result = await _userService.CreateAsync(form);
        if (result)
            return RedirectToAction("SignIn", "Auth");

        ModelState.AddModelError("NotCreated", "User was not created.");
        return View(result);
    }

    public IActionResult SignIn()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> SignIn(UserSignInForm form)
    {
        if (ModelState.IsValid)
        {
            var result = await _signInManager.PasswordSignInAsync(form.Email, form.Password, false, false);
            if (result.Succeeded)
                return RedirectToAction("Index", "Home");
        }

        ViewData["ErrorMessage"] = "Incorrect email or password";
        return View(form);        
    }

    public new async Task<IActionResult> SignOut() 
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction("Index", "Home");
    }
}
