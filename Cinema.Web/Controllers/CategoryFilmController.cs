using Cinema.Web.Models.Reponses.CategoryFilm;
using Cinema.Web.Ultilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Web.Controllers
{
    public class CategoryFilmController:Controller
    {
        public JsonResult Gets()
        {
            var categories = new List<CategoryFilm>();
            categories = ApiHelper<List<CategoryFilm>>.HttpGetAsync($"{Helper.ApiUrl}api/CategoryFilm/Gets");
            return Json(new { categories });
        }

    }
}
