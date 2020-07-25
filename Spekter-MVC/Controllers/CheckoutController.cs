using Spekter_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Spekter_MVC.Controllers
{
    public class CheckoutController : Controller
    {
        // GET: Checkout
        public ActionResult Index()
        {
            List<Breadcrumbs> list = new List<Breadcrumbs>();
            list.Add(new Breadcrumbs { URL = "/Home", Label = "Home" });
            list.Add(new Breadcrumbs { URL = "/Product/CategoryDetails/Men", Label = "Men" });
            list.Add(new Breadcrumbs { URL = "Product/Details/1", Label = "Leather Jacket" });
            list.Add(new Breadcrumbs { URL = "Cart", Label = "Shopping" });
            list.Add(new Breadcrumbs { URL = null, Label = "Checkout" });


            return View("Index", list);
        }

        // GET: Checkout/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Checkout/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Checkout/Create
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

        // GET: Checkout/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Checkout/Edit/5
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

        // GET: Checkout/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Checkout/Delete/5
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
