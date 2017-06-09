using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMEWebsite.Controllers
{
    public class LoginController : Controller
    {
        ServiceReference1.CustomerRegistrationClient Clients = new ServiceReference1.CustomerRegistrationClient();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CheckLogin(string username, string password)
        {
            ServiceReference1.LoginBO lbo = new ServiceReference1.LoginBO();
            lbo.UserName = username;
            lbo.Password = password;
            int i = Clients.Login(lbo);
            if (i == 1)
                return Json(1, JsonRequestBehavior.AllowGet);
            else
                return Json(0, JsonRequestBehavior.AllowGet);
        }
    }
}