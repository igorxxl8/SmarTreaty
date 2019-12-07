﻿using System.Web.Mvc;

namespace SmarTreaty.Controllers
{
    [RoutePrefix("contracts")]
    public class ContractsController : DefaultController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}