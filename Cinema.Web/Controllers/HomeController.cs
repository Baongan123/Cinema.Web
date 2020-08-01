﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cinema.Web.Models;
using Cinema.Web.Ultilities;
using Cinema.Web.Models.Film;
using Cinema.Web.Models.Showing;

namespace Cinema.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult HomeFilm()
        {
            ViewBag.Title = "Cinema NPT";
            return View();
        }

        public JsonResult Gets()
        {
            var films = new List<Film>();
            films = ApiHelper<List<Film>>.HttpGetAsync($"{Helper.ApiUrl}api/Home/Film");
            return Json(new { films });
        }

    }
}
