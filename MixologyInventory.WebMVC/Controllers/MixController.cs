﻿using Microsoft.AspNet.Identity;
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

        private MixService CreateMixService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new MixService(userId);
            return service;
        }
    }
}