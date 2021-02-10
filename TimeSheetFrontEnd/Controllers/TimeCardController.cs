using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TimeSheetFrontEnd.Controllers
{
    public class TimeCardController : Controller
    {
        // GET: TimeCard
        public ActionResult Index()
        {
            return View();
        }
    }
}