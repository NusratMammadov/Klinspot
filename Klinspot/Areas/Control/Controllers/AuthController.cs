using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Klinspot.Areas.Control.Controllers
{
    public class AuthController : Controller
    {
        // GET: Control/Auth
        public ActionResult Login()
        {
            return View();
        }
    }
}