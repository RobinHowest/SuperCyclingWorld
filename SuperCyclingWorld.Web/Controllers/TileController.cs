using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialCyclingWorld.Web.Data;
using SuperCyclingWorld.Core.Entities;
using SuperCyclingWorld.Core.Entities.Base;
using SuperCyclingWorld.Core.Services;
using SuperCyclingWorld.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCyclingWorld.Web.Controllers
{
    public class TileController : Controller
    {
        private readonly SCWDbContext _dbContext;
        private readonly AccountTileService _accountTileService;

        public TileController(SCWDbContext dbContext)
        {
            _dbContext = dbContext;
            _accountTileService = new AccountTileService();
        }

        [Route("/Tile/{id}")]
        public async Task<IActionResult> Index(int id)
        {
            string personId = "";

            if (HttpContext.Session.Keys.Contains("LoggedInId"))
            {
                personId = HttpContext.Session.GetString("LoggedInId");
            }
            else
            {
                return NotFound();
            }

            Persoon account1 = await _dbContext.Wielrenners.Where(w => w.Id == Guid.Parse(personId)).Include(w => w.Club).Include(w => w.Wielrenners).Include(f => f.Fietsen).SingleOrDefaultAsync();
            if(account1 == null)
            {
                account1 = await _dbContext.Supporters.Where(w => w.Id == Guid.Parse(personId)).Include(w => w.Wielrenners).Include(w => w.Clubs).SingleOrDefaultAsync();
            }
            AccountViewModel accountVm = new AccountViewModel(account1, _accountTileService.AccountTiles);
            accountVm.SelectedAccountTile = id;

            return View(accountVm);
        }
    }
}
