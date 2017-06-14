using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace app_latimerwedding.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id)
        {
            if (!string.IsNullOrEmpty(id) && id.Trim().ToLower() == "penis")
            {
                Session["PenisMode"] = true;
                Response.Redirect("/");
            }
            return View();
        }

        public ActionResult Her()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Him()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Location()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Registry()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Rsvp()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}