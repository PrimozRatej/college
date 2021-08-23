using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Spotyfly.Controllers
{
    public class UsersController : Controller
    {
        // GET: Uporabniki
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AllUsers()
        {
            return View("AllUsers");
        }
    }
}