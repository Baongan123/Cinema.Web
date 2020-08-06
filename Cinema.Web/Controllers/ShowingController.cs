using Cinema.Web.Models.Showing;
using Cinema.Web.Ultilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Web.Controllers
{
    public class ShowingController:Controller
    {
        [Route("/Showing/DeleteByTime")]
        public JsonResult DeleteByTime()
        {
            var message = new MessageSuccess();
            message = ApiHelper<MessageSuccess>.HttpGetAsync($"{Helper.ApiUrl}api/Showing/DeleteByTime","DELETE");
            return Json(new { message });
        }
        
        public JsonResult Seats(int id)
        {
            var seats = new List<Seat>();
            seats = ApiHelper<List<Seat>>.HttpGetAsync($"{Helper.ApiUrl}api/Showing/Seats/{id}");
            return Json(new { seats });
        }
        public JsonResult DescriptionShowing(int id)
        {
            var descriptionShowing = new DescriptionShowing();
            descriptionShowing = ApiHelper<DescriptionShowing>.HttpGetAsync($"{Helper.ApiUrl}api/Showing/Description/{id}");
            return Json(new { descriptionShowing });
        }
    }
}
