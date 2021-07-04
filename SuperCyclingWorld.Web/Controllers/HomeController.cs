using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SuperCyclingWorld.Core.Entities;
using SuperCyclingWorld.Web.Models;
using SuperCyclingWorld.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCyclingWorld.Web.Controllers
{
    public class HomeController : Controller
    {
        public IHostingEnvironment _enviroment { get; set; }

        public HomeController(IHostingEnvironment environment)
        {
            _enviroment = environment;
        }

        [Route("/")]
        public IActionResult Index()
        {
            ChartBoxListViewModel listChartBoxVM = new ChartBoxListViewModel();
            ChartBox signIn = new ChartBox("Sign Up", "signIn2.png", "Sign up ! En volg je eigen parcours...");
            ChartBox clubs = new ChartBox("Clubs", "clubPicto.png", "Ontdek al onze aangesloten clubs !");


            listChartBoxVM.ChartBoxViewModels.Add(new ChartBoxViewModel(signIn));
            listChartBoxVM.ChartBoxViewModels.Add(new ChartBoxViewModel(clubs));


            return View(listChartBoxVM);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
