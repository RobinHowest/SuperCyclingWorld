using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialCyclingWorld.Web.Data;
using SuperCyclingWorld.Core.Entities;
using SuperCyclingWorld.Core.Entities.Base;
using SuperCyclingWorld.Core.Enums;
using SuperCyclingWorld.Core.HelpClasses;
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
        [Route("/AccountController/{PersonId}")]
        public async Task<IActionResult> Index(Guid personId)
        {

            Persoon account1 = await _dbContext.Wielrenners.Where(w => w.Id == personId).Include(w => w.Club).Include(w => w.Wielrenners).SingleOrDefaultAsync();
            if(account1 == null)
            {
                account1 = await _dbContext.Supporters.Where(w => w.Id == personId).Include(s => s.Wielrenners).Include(s => s.Clubs).SingleOrDefaultAsync();
            }
            AccountViewModel accountVm = new AccountViewModel(account1, _accountTileService.AccountTiles);

            return View(accountVm);
        }

        [HttpPost]
        [Route("/AccountController")]
        public async Task<IActionResult> Index(LogInViewModel logInVm)
        {

            Persoon tryToLogIn = await _dbContext.Wielrenners.Where(w => w.Email == logInVm.Email_UserName).SingleOrDefaultAsync();
            if(tryToLogIn == null)
            {
                tryToLogIn = await _dbContext.Supporters.Where(s => s.Email == logInVm.Email_UserName).SingleOrDefaultAsync();
            }

            if(tryToLogIn == null)
            {
                TempData["UnsuccesfullInlogAttempt"] = "Uw Email adres bestaat nog niet in SCW, ga naar de Sign in knop op de homepage en registreer je nu !";
                return RedirectToAction("index", "info");
            }

            Persoon ingelogde = await _dbContext.Wielrenners.Where(w => w.Paswoord == MD5.CreateMD5(logInVm.Paswoord) && w.Id == tryToLogIn.Id).SingleOrDefaultAsync();
            if (ingelogde == null)
            {
                ingelogde = await _dbContext.Supporters.Where(w => w.Paswoord == MD5.CreateMD5(logInVm.Paswoord) && w.Id == tryToLogIn.Id).SingleOrDefaultAsync();
            }

            if (ingelogde == null)
            {
                TempData["UnsuccesfullInlogAttempt"] = "Verkeerd paswoord !";
                return RedirectToAction("index", "info");
            }
            HttpContext.Session.SetString("LoggedInId", ingelogde.Id.ToString());
            return RedirectToAction("index", new { personId = ingelogde.Id });
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
                    Supporter newSupporter = new Supporter(newAccountFormVm.Voornaam, newAccountFormVm.Achternaam, newAccountFormVm.Paswoord, newAccountFormVm.Email, newAccountFormVm.GeboorteDatum);
                    _dbContext.Supporters.Add(newSupporter);
                    _dbContext.SaveChanges();

                    TempData["NewAccount"] = $"Uw account is gereed, {newAccountFormVm.Voornaam} !";
                    return RedirectToAction("NewAccount");
                }
                else
                {
                    Wielrenner newWielrenner = new Wielrenner((Guid)newAccountFormVm.ClubId, newAccountFormVm.Voornaam, newAccountFormVm.Achternaam, newAccountFormVm.Paswoord, newAccountFormVm.Email, newAccountFormVm.GeboorteDatum);
                   
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
