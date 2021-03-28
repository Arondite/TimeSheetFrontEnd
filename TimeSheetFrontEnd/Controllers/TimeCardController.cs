using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeSheetFrontEnd.ViewModels;
using TimeSheetFrontEnd.DAL;

namespace TimeSheetFrontEnd.Controllers
{
    public class TimeCardController : Controller
    {
        private DatabaseHelper databaseHelper = new DatabaseHelper();
        // GET: TimeCard
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TimeCardCreation(DateTime date)
        {
            private List<Shift> shifts = databaseHelper.ReturnShiftsOnGivenDate(date);
            //private TimeCard timeCard = new TimeCard(shifts.Employ);

            return View();
        }
    }
}