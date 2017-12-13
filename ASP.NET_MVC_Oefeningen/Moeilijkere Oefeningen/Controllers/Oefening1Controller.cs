using Moeilijkere_Oefeningen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Moeilijkere_Oefeningen.Controllers
{
    public class Oefening1Controller : Controller
    {
        public ActionResult Get()
        {
            return View(new OefeningModel("Admin", "Admin", "Admin@admin.nl"));
        }

        public ActionResult Post()
        {
            return View(new OefeningModel("Admin", "Admin", "Admin@admin.nl"));
        }
    }
}