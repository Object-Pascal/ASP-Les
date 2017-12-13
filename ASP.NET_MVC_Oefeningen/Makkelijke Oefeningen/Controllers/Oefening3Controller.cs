using Makkelijke_Oefeningen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Makkelijke_Oefeningen.Controllers
{
    public class Oefening3Controller : Controller
    {
        public ActionResult Index()
        {
            return View(new OefeningModel("Admin", "Admin", "Admin@admin.nl"));
        }

        public ActionResult List()
        {
            List<OefeningModel> models = new List<OefeningModel>();

            for (int i = 0; i < 50; i++)
            {
                models.Add(new OefeningModel("Admin", "Admin", "Admin@admin.nl"));
            }

            return View(models);
        }
    }
}