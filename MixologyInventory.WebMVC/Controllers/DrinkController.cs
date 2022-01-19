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

        public ActionResult Details(int id)
        {
            var svc = CreateDrinkService();
            var model = svc.GetDrinkById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateDrinkService();
            var detail = service.GetDrinkById(id);
            var model =
                new DrinkEdit
                {
                    RecipeID = detail.RecipeID,
                    DrinkName = detail.DrinkName,
                    LiquidName = detail.LiquidName,
                    LiquidAmount = detail.LiquidAmount,
                    Directions = detail.Directions,
                    Decription = detail.Description
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, DrinkEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if(model.RecipeID != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateDrinkService();

            if( service.UpdateDrink(model))
            {
                TempData["Saveresult"] = "Your recipe was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your recipe could not be updated.");
            return View(model);
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateDrinkService();
            var model = svc.GetDrinkById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateDrinkService();

            service.DeleteDrink(id);

            TempData["SaveResult"] = "Your recipe was deleted";

            return RedirectToAction("Index");
        }

        private DrinkService CreateDrinkService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new DrinkService(userId);
            return service;
        }
    }
}