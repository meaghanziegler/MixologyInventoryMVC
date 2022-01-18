using Microsoft.AspNet.Identity;
using MixologyInventory.Model.Liquid;
using MixologyInventory.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MixologyInventory.WebMVC.Controllers
{
    [Authorize]
    public class LiquidController : Controller
    {
        // GET: Liquid
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new LiquidService(userId);
            var model = service.GetLiquids();

            return View(model);
        }

        // GET: Liquid/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Liquid
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LiquidCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateLiquidService();

            if (service.CreateLiquid(model))
            {
                TempData["SaveResult"] = "Your liquid was added.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Liquid could not be added.");

            return View(model);
        }

        // GET: Liquid/Details/{id}
        public ActionResult Details(int id)
        {
            var svc = CreateLiquidService();
            var model = svc.GetLiquidById(id);

            return View(model);
        }

        // EDIT: Liquid/Edit/{id}
        public ActionResult Edit(int id)
        {
            var service = CreateLiquidService();
            var detail = service.GetLiquidById(id);
            var model =
                new LiquidEdit
                {
                    InventoryID = detail.InventoryID,
                    Brand = detail.Brand,
                    Name = detail.Name,
                    Amount = detail.Amount,
                    LiquidType = detail.LiquidType,
                    Proof = detail.Proof,
                    Comment = detail.Comment
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, LiquidEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if(model.InventoryID != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateLiquidService();

            if (service.UpdateLiquid(model))
            {
                TempData["SaveResult"] = "Your liquid has been updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your liquid could not be updated.");
            return View();
        }

        private LiquidService CreateLiquidService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new LiquidService(userId);
            return service;
        }
    }
}