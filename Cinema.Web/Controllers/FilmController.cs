using Cinema.Web.Models.CategoryFilm;
using Cinema.Web.Models.Film;
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
            return View();
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
            result = ApiHelper<CreateFilmResult>.HttpPostAsync(
                                                    $"{Helper.ApiUrl}api/Film/Create",
                                                    model
                                                );
            return Json(new { result });
        }
    }
}
