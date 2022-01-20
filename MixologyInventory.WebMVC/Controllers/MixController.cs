using Microsoft.AspNet.Identity;
using MixologyInventory.Model.Mix;
using MixologyInventory.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MixologyInventory.WebMVC.Controllers
{
    [Authorize]
    public class MixController : Controller
    {
        // GET: Mix
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new MixService(userId);
            var model = service.GetMixes();

            return View(model);
        }

        // GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MixCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var service = CreateMixService();

            if (service.CreateMix(model))
            {
                TempData["SaveResult"] = "Your Mix was created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Mix could not be created.");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateMixService();
            var model = svc.GetMixById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateMixService();
            var detail = service.GetMixById(id);
            var model =
                new MixEdit
                {
                    MixID = detail.MixID,
                    Name = detail.Name,
                    DrinkID = detail.Drink.RecipeID,
                    LiquidID = detail.Liquid.InventoryID,
                    Amount = detail.Amount
                };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MixEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if(model.MixID != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateMixService();

            if(service.UpdateMix(model))
            {
                TempData["Saveresult"] = "Your Mix was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your mix could not be updated.");
            return View(model);
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateMixService();
            var model = svc.GetMixById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteMix(int id)
        {
            var service = CreateMixService();

            service.DeleteMix(id);

            TempData["SaveResult"] = "Your mix was deleted.";

            return RedirectToAction("Index");
        }

        private MixService CreateMixService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new MixService(userId);
            return service;
        }
    }
}