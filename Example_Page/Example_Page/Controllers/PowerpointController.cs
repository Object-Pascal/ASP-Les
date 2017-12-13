using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example_Page.Controllers
{
    public class PowerpointController : Controller
    {
        // GET: Powerpoint
        public ActionResult Powerpointer()
        {
            Session["showNav"] = false;
            return View();
        }

        public ActionResult RedirectHomePage()
        {
            Session["showNav"] = true;
            return RedirectToAction("Index", "Home");
        }
    }
}