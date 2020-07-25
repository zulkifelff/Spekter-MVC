using Spekter_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Spekter_MVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        // GET: Product/CategoryDetails/Men
        public ActionResult CategoryDetails(string CategoryName)
        {
            return View("~/Views/Product/ProductListing.cshtml");
        }

        // GET: Product/Details/Leather
        public ActionResult Details()
        {
            List<Breadcrumbs> list = new List<Breadcrumbs>();
            list.Add(new Breadcrumbs { URL = "/Home", Label = "Home" });
            list.Add(new Breadcrumbs { URL = "/Product/CategoryDetails/Men", Label = "Men" });
            list.Add(new Breadcrumbs { URL = null, Label = "Leather Jacket" });


            return View("~/Views/Product/Details.cshtml", list);
        }

        // POST: Product/Create
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

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
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

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
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
