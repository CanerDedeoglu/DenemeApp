﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DenemeApp.Models;

namespace DenemeApp.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

}
