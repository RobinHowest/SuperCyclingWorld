using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialCyclingWorld.Web.Data;
using SuperCyclingWorld.Core.Entities;
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

        public AccountController(SCWDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Route("/AccountController")]
        public async Task<IActionResult> Index()
        {

            Supporter account1 = await _dbContext.Supporters.Where(w => w.Id == Guid.Parse("2B2E839D-0162-4D34-872A-0061C9E69AA0")).SingleOrDefaultAsync();

            AccountViewModel accountVm = new AccountViewModel(account1);

            return View(accountVm);
        }

        // GET: AccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountController/Create
        public ActionResult Create()
        {
            return View();
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
