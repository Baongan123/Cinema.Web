using Cinema.Web.Models.ComboFood;
using Cinema.Web.Ultilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Web.Controllers
{
    public class ComboFoodController : Controller
    {
        public JsonResult Gets()
        {
            var comboFoods = new List<ComboFood>();
            comboFoods = ApiHelper<List<ComboFood>>.HttpGetAsync($"{Helper.ApiUrl}api/combofood/gets");
            return Json(new { comboFoods });
        }
        public JsonResult Get(int id)
        {
            var comboFood = new ComboFood();
            comboFood = ApiHelper<ComboFood>.HttpGetAsync($"{Helper.ApiUrl}api/combofood/get/{id}");
            return Json(new { comboFood });
        }
    }
}
