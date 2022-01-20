using MixologyInventory.Model.Mix;
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
            var model = new MixListItem[0];
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
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}