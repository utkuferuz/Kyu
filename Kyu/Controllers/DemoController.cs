using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Kyu.Controllers
{


    public class DemoController : Controller
    {
        public DemoController()
        {
                
        }
        
        // GET: Demo
        public ActionResult Index()
        {


            return View();
        }
    }
}