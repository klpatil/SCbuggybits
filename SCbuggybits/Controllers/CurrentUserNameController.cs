using SCbuggybits.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCbuggybits.Controllers
{
    public class CurrentUserNameController : Controller
    {
        private const string USERNAME = "UserName";
        // GET: CurrentUserName
        public ActionResult Index()
        {
            var currentUser = new UserDetail();
            currentUser.UserName = (HttpContext.Session[USERNAME] != null) ?
                Convert.ToString(HttpContext.Session[USERNAME]) : string.Empty;
            return View(currentUser);
        }

        [HttpPost]
        public ActionResult Index(UserDetail model)
        {
            if(!string.IsNullOrWhiteSpace(model.UserName))
            {
                HttpContext.Session.Clear();
                HttpContext.Session.Add(USERNAME, model.UserName);
                return Redirect(this.Request.UrlReferrer.AbsolutePath);
            }           
            return View();
        }
    }
}