using SCbuggybits.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCbuggybits.Controllers
{
    public class CompanyInformationController : Controller
    {
        // GET: CompanyInformation
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendEmail(string message)
        {   
            BuggyMail mail = new BuggyMail();
            mail.SendEmail(message, "whocares-at-buggymail");
            return View();
        }
    }
}