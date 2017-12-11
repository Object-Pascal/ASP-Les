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
            Session["test"] = "test";
            return View();
        }

        [HttpPost]
        public ActionResult Sessions(string txtName, string txtLastName, int txtAge)
        {
            UserSession.currentUser.name = txtName;   
            UserSession.currentUser.lastName = txtLastName;   
            UserSession.currentUser.age = txtAge;
            return View();
        }


        // Ajax actions
        [HttpGet]
        public JsonResult AjaxGet()
        {
            string fullName = "Pascal Stoop";
            string school = "Radius College";
            string age = "19";
            string dateOfBirth = "01-09-1998";

            return Json(new { fullName = fullName, school = school, age = age, dateOfBirth = dateOfBirth }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult AjaxPost(ProfileModel values)
        {
            return Json(new { fullName = values.fullName, school = values.school, age = values.age, dateOfBirth = values.dateOfBirth }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public PartialViewResult AjaxPartial()
        {
            return PartialView("PartialViewTest");
        }
    }
}