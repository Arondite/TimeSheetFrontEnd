using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TimeSheetFrontEnd.Controllers
{
    public class UserLogInController : Controller
    {
        // GET: UserLogIn
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AdminPage()
        {
            return View();
        }
    }
}