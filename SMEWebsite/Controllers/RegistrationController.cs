using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMEWebsite.Controllers
{
    public class RegistrationController : Controller
    {
        ServiceReference1.CustomerRegistrationClient objservice = new ServiceReference1.CustomerRegistrationClient();
        // GET: Registration
        public ActionResult Registration()
        {
            return View();
        }

        public JsonResult getmenu(ServiceReference1.MenuMasterBo objcls)
        {
            //ServiceReference1.MenuMasterBo objcls = new ServiceReference1.MenuMasterBo();
            //objcls.Id = 0;
            //objcls.Menu_Name = "A";
            //objcls.Url = "B";
            //objcls.Action = "S";
            var list = objservice.SmeMenuMasterInsert(objcls);
            var text = JsonConvert.SerializeObject(list);
            return Json(text);

        }

        public JsonResult InsertMenu(ServiceReference1.MenuMappingBO smemmap)
        {
            //ServiceReference.MenuMappingBO smemmap = new ServiceReference.MenuMappingBO();
            //smemmap.menuid = menuid;
            //smemmap.roleid = roleid;
            //smemmap.modifiedby = modifiedby;
            //smemmap.createby = create_by;
            //smemmap.isview = isview;
            //smemmap.action = "I";
            //smemmap.isRead = isRead;
            //smemmap.isWrite = isWrite;
            //smemmap.isDelete = isDelete;

            var list = objservice.GetSMEMapping(smemmap);
            var text = JsonConvert.SerializeObject(list);
            return Json(text);
        }
    }
}