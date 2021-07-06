using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialCyclingWorld.Web.Data;
using SuperCyclingWorld.Core.Entities;
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

        [Route("/Tile/{id?}")]
        public async Task<IActionResult> Index(int? id)
        {
            //just to have an account
            Wielrenner account1 = await _dbContext.Wielrenners.Where(w => w.Id == Guid.Parse("D5EDE78C-E319-44DF-9F37-55ED626CE1A3")).Include(w => w.Club).Include(w => w.Wielrenners).Include(f => f.Fietsen).SingleOrDefaultAsync();
            AccountViewModel accountVm = new AccountViewModel(account1, _accountTileService.AccountTiles);
            //-----------------------

            if (id == null)
            {
                return NotFound();
            }

            accountVm.SelectedAccountTile = (int)id;


           
                



            return View(accountVm);
        }
    }
}
