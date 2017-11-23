using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example_Page.Models
{
    public class TestController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}