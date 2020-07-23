using Spekter_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;


namespace Spekter_MVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            List<Breadcrumbs> list = new List<Breadcrumbs>();
            list.Add(new Breadcrumbs { URL = "/Home", Label = "Home" });
            list.Add(new Breadcrumbs { URL = "/Account", Label = "Account" });
            list.Add(new Breadcrumbs { URL = null, Label = "Frank Lampard" });

            return View("Index", list);
        }

        
    }
}
