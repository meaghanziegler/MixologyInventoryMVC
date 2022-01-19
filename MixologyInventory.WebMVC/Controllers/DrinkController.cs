using Microsoft.AspNet.Identity;
using MixologyInventory.Model.Drink;
using MixologyInventory.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MixologyInventory.WebMVC.Controllers
{
    [Authorize]
    public class DrinkController : Controller
    {
        // GET: Drink
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new DrinkService(userId);
            var model = service.GetDrinks();
            return View(model);
        }

        // GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DrinkCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var service = CreateDrinkService();

            if (service.CreateDrink(model))
            {
                TempData["SaveResult"] = "Your recipe was created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Recipe could not be created.");

            return View(model);
        }

        private DrinkService CreateDrinkService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new DrinkService(userId);
            return service;
        }
    }
}