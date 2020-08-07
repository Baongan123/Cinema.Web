using Cinema.Web.Models.CategoryFilm;
using Cinema.Web.Models.Film;
using Cinema.Web.Models.Showing;
using Cinema.Web.Ultilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Web.Controllers
{
    public class FilmController:Controller
    {
        public IActionResult FilmOfCategory(int id)
        {
            ViewBag.Title = "Film NPT";
            var category = new CategoryFilm();
            category = ApiHelper<CategoryFilm>.HttpGetAsync($"{Helper.ApiUrl}api/CategoryFilm/GetbyCateId/{id}");
            if (category != null)
            {
                ViewBag.Category = category;
            }
            List<Film> films = new List<Film>();
            films = ApiHelper<List<Film>>.HttpGetAsync($"{Helper.ApiUrl}api/Films/Category/{id}");
            ViewBag.CategoryId = id;
            return View(films);
        }
        [Route("/Film/Gets/{CateId}")]
        public JsonResult Gets(int CateId)
        {
            var films = new List<Film>();
            films = ApiHelper<List<Film>>.HttpGetAsync($"{Helper.ApiUrl}api/Films/Category/{CateId}");
            return Json(new { films });
        }
        [HttpPost]
        [Route("/Film/Create/")]
        public JsonResult Create([FromBody] CreateFilm model)
        {
            var result = new CreateFilmResult();
            model.LinkTrailer = model.LinkTrailer.Substring(model.LinkTrailer.IndexOf("=") + 1);
            result = ApiHelper<CreateFilmResult>.HttpPostAsync(
                                                    $"{Helper.ApiUrl}api/Film/Create",
                                                    model
                                                );
            return Json(new { result });
        }
        public JsonResult Get(int id)
        {
            var film = new Film();
            film = ApiHelper<Film>.HttpGetAsync($"{Helper.ApiUrl}api/Film/Get/{id}");
            return Json(new { film });
        }
        public IActionResult FilmShow(int id)
        {
            ViewBag.Title = "Film NPT";
            var category = new CategoryFilm();
            category = ApiHelper<CategoryFilm>.HttpGetAsync($"{Helper.ApiUrl}api/CategoryFilm/GetbyCateId/{id}");
            if (category != null)
            {
                ViewBag.Category = category;
            }
            ViewBag.FilmId = id;
            return View();
        }
        [HttpPost]
        [Route("/Film/Update/")]
        public JsonResult Update([FromBody] UpdateFilm model)
        {
            var result = new CreateFilmResult();
            model.LinkTrailer = model.LinkTrailer.Substring(model.LinkTrailer.IndexOf("=") + 1);
            result = ApiHelper<CreateFilmResult>.HttpPostAsync(
                                                    $"{Helper.ApiUrl}api/Film/Update",
                                                    model
                                                );
            return Json(new { result });
        }


    }
}
