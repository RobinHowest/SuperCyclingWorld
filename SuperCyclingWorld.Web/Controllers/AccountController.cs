using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialCyclingWorld.Web.Data;
using SuperCyclingWorld.Core.Entities;
using SuperCyclingWorld.Core.Enums;
using SuperCyclingWorld.Core.Services;
using SuperCyclingWorld.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCyclingWorld.Web.Controllers
{
    public class AccountController : Controller
    {

        private readonly SCWDbContext _dbContext;
        private readonly AccountTileService _accountTileService;

        public AccountController(SCWDbContext dbContext)
        {
            _dbContext = dbContext;
            _accountTileService = new AccountTileService();
        }

        [Route("/AccountController")]
        public async Task<IActionResult> Index()
        {
            //Als het een wielrenner is die binnen komt (inlogt) -> if(Persoon is Wielrenner)else{ Supporter account1 = _dbContext.Supporters}  <-- nog te schrijven
            Wielrenner account1 = await _dbContext.Wielrenners.Where(w => w.Id == Guid.Parse("D5EDE78C-E319-44DF-9F37-55ED626CE1A3")).Include(w => w.Club).Include(w => w.Wielrenners).SingleOrDefaultAsync();

            AccountViewModel accountVm = new AccountViewModel(account1, _accountTileService.AccountTiles);

            return View(accountVm);
        }

        // GET: AccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [Route("/AccountController/NewAccount")]
        public IActionResult NewAccount()
        {
            return View();
        }

        [HttpPost]
        [Route("/AccountController/NewAccount")]
        public IActionResult NewAccount(NewAccountFormViewModel newAccountFormVm)
        {


            if (ModelState.IsValid)
            {
                if (newAccountFormVm.RegisteredAS == "Supporter")
                {
                    Supporter newSupporter = new Supporter(newAccountFormVm.Voornaam, newAccountFormVm.Achternaam, newAccountFormVm.Paswoord);
                    _dbContext.Supporters.Add(newSupporter);
                    _dbContext.SaveChanges();

                    TempData["NewAccount"] = $"Uw account is gereed, {newAccountFormVm.Voornaam} !";
                    return RedirectToAction("NewAccount");
                }
                else
                {
                    Wielrenner newWielrenner = new Wielrenner((Guid)newAccountFormVm.ClubId, newAccountFormVm.Voornaam, newAccountFormVm.Achternaam, newAccountFormVm.Paswoord);
                   
                    _dbContext.Wielrenners.Add(newWielrenner);
                   
                    _dbContext.SaveChanges();
                    TempData["NewAccount"] = $"Uw account is gereed, {newAccountFormVm.Voornaam} !";
                    return RedirectToAction("NewAccount");
                }

            }



            if (newAccountFormVm.RegisteredAS == "Supporter")
            {
                      newAccountFormVm.Clubs = null;
                      return View("newSupporterForm", newAccountFormVm);
            }
            else
            {
                      newAccountFormVm.Clubs = _dbContext.Clubs.OrderBy(c => c.Clubnaam).ToList();
                      return View("newWielrennerForm", newAccountFormVm);
            }

        }

        // POST: AccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
