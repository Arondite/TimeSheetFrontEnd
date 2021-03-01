using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeSheetFrontEnd.ViewModels;
using TimeSheetFrontEnd.DAL;
using TimeSheetFrontEnd.Models;

namespace TimeSheetFrontEnd.Controllers
{
    public class ShiftCreatorController : Controller
    {
        private DatabaseHelper database = new DatabaseHelper();
        // GET: ShiftCreator
        public ActionResult Index()
        {
            return View(database.ListOfEmployees());
        }
        public ActionResult ReviewShift(TimeSpan startTime, TimeSpan endTime, DateTime date)
        {

            return View();
        }

    }
}
