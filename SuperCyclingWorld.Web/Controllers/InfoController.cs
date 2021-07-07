using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCyclingWorld.Web.Controllers
{
    public class InfoController : Controller
    {
        [Route("/Info")]
        [Route("/Info/{navId}")]
        public IActionResult Index(string navId)
        {
            ViewData["navId"] = navId;

            return View();
        }
        
    }
}
