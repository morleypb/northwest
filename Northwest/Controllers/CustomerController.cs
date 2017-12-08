using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwest.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View("CustomerPortal");
        }

        public ActionResult Orders()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }

        public ActionResult CustProfile()
        {
            return View();
        }

        public ActionResult Navbar()
        {
            return View();
        }

        public ActionResult CreateOrder()
        {
            return View();
        }

        public ActionResult CompoundDetails()
        {
            return View();
        }

        public ActionResult OrderSummary()
        {
            return View();
        }
    }
}