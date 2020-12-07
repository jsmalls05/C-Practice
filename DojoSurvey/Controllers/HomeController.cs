using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View("Index"); 
        }

        [HttpGet("result")]
        public IActionResult Result()
        {
            return View();
        }

        [HttpPost("result")]
        public IActionResult Result(DojoSurvey.Models.Survey form)
        {            
            if(ModelState.IsValid)
            {
                return RedirectToAction("result");
            }
            else
            {
                
            return View("Index");
            }
        }
    }
}
