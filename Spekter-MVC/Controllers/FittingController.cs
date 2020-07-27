using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Spekter_MVC.Controllers
{
    public class FittingController : Controller
    {
        // GET: Fitting
        public ActionResult Index()
        {
            return View();
        }

        // GET: Fitting/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Fitting/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fitting/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Fitting/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Fitting/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Fitting/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Fitting/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
