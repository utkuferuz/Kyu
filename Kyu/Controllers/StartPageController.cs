using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kyu.Controllers
{
    public class StartPageController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

      
    }
}