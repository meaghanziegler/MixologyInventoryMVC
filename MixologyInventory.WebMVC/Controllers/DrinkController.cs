using MixologyInventory.Model.Drink;
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
            var model = new DrinkListItem[0];
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
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}