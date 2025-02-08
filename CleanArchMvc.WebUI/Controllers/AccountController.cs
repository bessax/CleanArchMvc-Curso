﻿using CleanArchMvc.Domain.Account;
using CleanArchMvc.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchMvc.WebUI.Controllers;
public class AccountController : Controller
{
    private readonly IAuthenticate _authentication;

    public AccountController(IAuthenticate authentication)
    {
        _authentication = authentication;
    }

    [HttpGet]
    public IActionResult Login(string returnUrl)
    {
        return View(
           new LoginViewModel()
           {
               ReturnUrl = returnUrl
           });
    }
    [HttpPost]
    public  async Task<IActionResult> Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var result = await _authentication.Authenticate(model.Email!, model.Password!);
            if (result)
            {
                if (!string.IsNullOrEmpty(model.ReturnUrl))
                {
                    return Redirect(model.ReturnUrl);
                }
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
        }
        return View(model);

    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            var result = await _authentication.RegisterUser(model.Email!, model.Password!);
            if (result)
            {
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError(string.Empty, "Invalid registration attempt.");
        }
        return View(model);
    }

    public async Task<IActionResult> Logout()
    {
        await _authentication.Logout();
        return RedirectToAction("Index", "Home");
    }

}
