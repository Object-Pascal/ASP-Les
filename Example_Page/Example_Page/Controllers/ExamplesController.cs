using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example_Page.Controllers
{
    public class ExamplesController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
    }
}