using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SuperCyclingWorld.Core.Entities;
using SuperCyclingWorld.Core.Services;
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
            ViewData["info"] = null;

            ChartBoxListViewModel listChartBoxVM = new ChartBoxListViewModel();
            ChartBox signIn = new ChartBox("Sign Up", "signIn2.png", "Sign up ! En volg je eigen parcours...", MeerWetenService.GetMeerWetenOverSignIn());
            ChartBox clubs = new ChartBox("Clubs", "clubPicto.png", "Ontdek al onze aangesloten clubs !", MeerWetenService.GetMeerWetenOverClubs());
            ChartBox wielrenners = new ChartBox("Wielrenners", "clubPicto.png", "Ontdek al onze wielrenners !", MeerWetenService.GetMeerWetenOverClubs());

            listChartBoxVM.ChartBoxViewModels.Add(new ChartBoxViewModel(signIn, "NewAccount"));
            listChartBoxVM.ChartBoxViewModels.Add(new ChartBoxViewModel(clubs, "ViewAllClubs"));
            listChartBoxVM.ChartBoxViewModels.Add(new ChartBoxViewModel(wielrenners, "ViewAllWielrenners"));

            return View(listChartBoxVM);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
