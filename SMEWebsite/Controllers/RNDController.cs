using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMEWebsite.Controllers
{
    public class RNDController : Controller
    {
        ServiceReference1.CustomerRegistrationClient objservice = new ServiceReference1.CustomerRegistrationClient();
        // GET: RND
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Download()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetAllCompanyDetails()
        {
            var Company = JsonConvert.SerializeObject(objservice.GetAllCompanyInsert());
            return Json(Company, JsonRequestBehavior.AllowGet);
        }
    }
}