using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace TimeDisplay.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            var now = DateTime.Now;
            
            return View("Index", now);
        }
    }
}