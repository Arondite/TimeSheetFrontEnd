using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeSheetFrontEnd.ViewModels;

namespace TimeSheetFrontEnd.Controllers
{
    public class TimeCardController : Controller
    {
        // GET: TimeCard
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TimeCardCreation(DateTime date)
        {
            TimeCard timeCard = new TimeCard();
            return View();
        }
    }
}