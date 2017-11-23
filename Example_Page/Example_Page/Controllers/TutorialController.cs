using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example_Page.Controllers
{
    public class TutorialController : Controller
    {
        [HttpGet]
        public ActionResult Models()
        {
            return View(new TutorialModel("Levi", "Vlasblom", 18));
        }

        [HttpPost]
        public ActionResult Models(string txtName, string txtLastName, int txtAge)
        {
            return View(new TutorialModel(txtName, txtLastName, txtAge));
        }

        public ActionResult Razor()
        {
            return View(new RazorModel());
        }

        public ActionResult Helpers()
        {
            return View();
        }

        public ActionResult GetAjax()
        {
            return View();
        }

        public ActionResult PostAjax()
        {
            return View();
        }

        public ActionResult PartialViews()
        {
            return View();
        }

        public ActionResult Sessions()
        {
            return View();
        }


        // Ajax actions
        public JsonResult AjaxGet()
        {
            string html = @"<div class='item'><h1>Test2</h1></div>";
            return Json(new { testHTML = html }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult AjaxPost()
        {
            return Json(new { }, JsonRequestBehavior.AllowGet);
        }

        public PartialViewResult AjaxPartial()
        {
            return PartialView("PartialViewTest");
        }
    }
}