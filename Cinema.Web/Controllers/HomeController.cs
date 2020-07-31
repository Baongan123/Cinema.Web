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
using Cinema.Web.Models.Reponses.Film;

namespace Cinema.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Cinema NPT";
            return View();
        }

        public JsonResult Gets()
        {
            var films = new List<Film>();
            films = ApiHelper<List<Film>>.HttpGetAsync($"{Helper.ApiUrl}api/RoomFilm/Home");
            return Json(new { films });
        }

        [HttpPost]
        public JsonResult CreateFilm([FromBody] CreateFilmRequests model)
        {
            var result = new SaveFilmResult();
            result = ApiHelper<SaveFilmResult>.HttpPostAsync(
                                                    $"{Helper.ApiUrl}api/Film/Create",
                                                    model
                                                );
            return Json(new { result });
        }
    }
}
