using Moeilijkere_Oefeningen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Moeilijkere_Oefeningen.Controllers
{
    public class Oefening3Controller : Controller
    {
        public ActionResult Index(string username, string password, string email)
        {
            OefeningModel oefeningModel;

            if (username != null || password != null || email != null)
            {
                oefeningModel = Login(username, password, email);
            }
            else
            {
                oefeningModel = new OefeningModel(username, password, email);
            }

            return View(oefeningModel);
        }

        public OefeningModel Login(string username, string password, string email)
        {
            return null;
        }

        public ActionResult SessionView()
        {
            return View();
        }
    }
}