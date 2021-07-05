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
        public IActionResult Index()
        { 
            return View();
        }
    }
}
