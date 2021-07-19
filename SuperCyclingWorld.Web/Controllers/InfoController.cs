using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialCyclingWorld.Web.Data;
using SuperCyclingWorld.Core.Enums;
using SuperCyclingWorld.Web.RecordZoeker;
using SuperCyclingWorld.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCyclingWorld.Web.Controllers
{
    public class InfoController : Controller
    {

        private readonly SCWDbContext _dbContext;
        private readonly RecordsZoeker _recordZoeker;

        public InfoController(SCWDbContext dbContext)
        {
            _dbContext = dbContext;
            _recordZoeker = new RecordsZoeker(_dbContext);
        }

        [Route("/Info")]
        [Route("/Info/{navId}")]
        public IActionResult Index(string navId)
        {
            ViewData["navId"] = navId;
            HttpContext.Session.Clear();

            return View();
        }

        [Route("/Info/ViewAllClubs")]
        public IActionResult ViewAllClubs()
        {
            _recordZoeker.FillInRecords(_dbContext.Clubs.OrderBy(c => c.Id).ToList());
            ClubListViewModel clubListVm = new ClubListViewModel();
            clubListVm.Clubs = _dbContext.Clubs.OrderBy(c => c.Clubnaam).Include(c => c.Leden).Include(c => c.ClubSupporters).ToList();
            foreach(var club in clubListVm.Clubs)
            {
                club.AantalRecords = RecordList.Records.Where(r => r.Wielrenner.Club.Id == club.Id && r.RecordType == Recordtype.Site).Count();
            }
            clubListVm.Clubs = clubListVm.Clubs.OrderByDescending(c => c.AantalRecords).ToList();
            return View(clubListVm);
        }

        [Route("/Info/ViewAllWielrenners")]
        public IActionResult ViewAllWielrenners()
        {
            
            return View();
        }
    }
}
