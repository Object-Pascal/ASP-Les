using Moeilijkere_Oefeningen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Moeilijkere_Oefeningen.Controllers
{
    public class Oefening2Controller : Controller
    {
        public ActionResult Index()
        {
            return View(new OefeningModel("Admin", "Admin", "admin@admin.nl"));
        }
    }
}