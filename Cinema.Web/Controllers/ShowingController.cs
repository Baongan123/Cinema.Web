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
        

    }
}
