using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WosDojoSurvey.Controllers
{
    public class DojoSurveyController : Controller
    {
        [HttpGet("")]
        public IActionResult FormFill()
        {
            return View();
        }

        [HttpGet("result")]
        public IActionResult Result()
        {
            return View("result");
        }

        // post to result
        [HttpPost("result")]
        public IActionResult ResultPost(string Name, string Location, string Language, string Comment)
            {
                // Viewbag.Name grabs from name="Name" in Result.cshtml
                ViewBag.Name = Name;
                ViewBag.Location = Location;
                ViewBag.Language = Language;
                ViewBag.Comment = Comment;
                // then go to the result
                return View("result");
            }


    }



}
