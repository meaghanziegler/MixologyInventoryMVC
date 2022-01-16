using MixologyInventory.Model.Liquid;
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
            var model = new LiquidListItem[0];
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
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}