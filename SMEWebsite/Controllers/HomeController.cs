using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SMEWebsite.Controllers
{
    public class HomeController : Controller
    {
        ServiceReference1.CustomerRegistrationClient Clients = new ServiceReference1.CustomerRegistrationClient();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult CompanyMaster()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult Regsitration()
        {

            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult SearchCompany()
        {
            return View();
        }
        public ActionResult AddCompany()
        {
            return View();
        }

        public ActionResult Test()
        {
            return View();
        }

        [HttpPost]
        public JsonResult City(string Id)
        {
            Clients.Open();
            var City = JsonConvert.SerializeObject(Clients.GetCityDetails(Convert.ToInt32(Id)));
            Clients.Close();
            return Json(City, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult State()
        {
            Clients.Open();
            var State = JsonConvert.SerializeObject(Clients.GetStateDetails());
            Clients.Close();
            return Json(State, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Dashbord()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SearchCompanyDetails(ServiceReference1.SearchCompanyBO ObjSearch)
        {
            var Company = JsonConvert.SerializeObject(Clients.SearchCompanyDetails(ObjSearch));
            return Json(Company, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult InsertCompanyDetails(ServiceReference1.CompanyDetailsBO objCompany)
        {
            objCompany.IsActive = "true";
            var Company = JsonConvert.SerializeObject(Clients.CompanyInsert(objCompany));
            return Json(Company, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetAllCompanyDetails()
        {
            var Company = JsonConvert.SerializeObject(Clients.GetAllCompanyInsert());
            return Json(Company, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult InsertPromoterDetails(ServiceReference1.CustomerDetailsBO objCustomer)
        {
            var Customer = JsonConvert.SerializeObject(Clients.CustomerInsert(objCustomer));
            return Json(Customer, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult InsertDocumentDetails(ServiceReference1.DocumentDetailsBO objDocument)
        {
            var Document = JsonConvert.SerializeObject(Clients.DocumentDetailsInsert(objDocument));
            return Json(Document, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult InsertFacilitiesDetails(ServiceReference1.FacilitiesTypesBO objFacilites)
        {
            var Facilites = JsonConvert.SerializeObject(Clients.FacilitiesTypesInsert(objFacilites));
            return Json(Facilites, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult InsertProposedDetails(ServiceReference1.FacilitiesTypesBO objFacilites)
        {
            var Proposed = JsonConvert.SerializeObject(Clients.ProposeTypesInsert(objFacilites));
            return Json(Proposed, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult InsertAssociateDetails(ServiceReference1.AssociateBO objAssociate)
        {
            var Associate = JsonConvert.SerializeObject(Clients.AssociateInsert(objAssociate));
            return Json(Associate, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult InsertMachineDetails(ServiceReference1.MachineDetailsBO objMachineDetails)
        {
            var Machine = JsonConvert.SerializeObject(Clients.MachineDetailsInsert(objMachineDetails));
            return Json(Machine, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult InsertStatutoryDetails(ServiceReference1.StatutoryBO objStatutory)
        {
            var Statutory = JsonConvert.SerializeObject(Clients.StatutoryInsert(objStatutory));
            return Json(Statutory, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult InsertSummaryDetails(ServiceReference1.CollateralsSummaryBO objCollaterals)
        {
            var Collaterals = JsonConvert.SerializeObject(Clients.CollateralsSummaryInsert(objCollaterals));
            return Json(Collaterals, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult InsertEstimatesDetails(ServiceReference1.PerformanceEstimateBO objEstimates)
        {
            var Estimates = JsonConvert.SerializeObject(Clients.PerformanceEstimatesInsert(objEstimates));
            return Json(Estimates, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult InsertScoreDetails(ServiceReference1.ScoreBO objScore)
        {
            var Score = JsonConvert.SerializeObject(Clients.ScoreInsert(objScore));
            return Json(Score, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetUser()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        [HttpPost]
        public JsonResult SearchUser(ServiceReference1.UserRegistrationBO ObjRegistration)
        {
            var User = JsonConvert.SerializeObject(Clients.GetAllUser(ObjRegistration));
            return Json(User, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Govind
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SaveProfileImage()
        {
            try
            {
                if (System.Web.HttpContext.Current.Request.Files.AllKeys.Any())
                {
                    var pic = System.Web.HttpContext.Current.Request.Files["HelpSectionImages"];
                    HttpPostedFileBase filebase = new HttpPostedFileWrapper(pic);
                    var fileName = Path.GetFileName(filebase.FileName);
                    string fileExtension = Path.GetExtension(fileName);
                    var path = string.Empty;
                    if (fileExtension == ".pdf" || fileExtension == ".jpg" || fileExtension == ".jpeg")
                    {
                        //path = Path.Combine(Server.MapPath("~/TempImageUpload/"), DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('-', '_') + "_" + fileName);

                        path = @"D:\RBSMEWEB\TempImageUpload\" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('-', '_').Replace('\\','_').Replace('/','_') + "_" + fileName;
                        filebase.SaveAs(path);
                    }
                    else
                    {
                        return Json("Wrong file format given");
                    }


                    return Json(path);
                }
                else { return Json("No File Saved."); }
            }
            catch (Exception ex) {
                return Json("Error While Saving.");
            }
        }
       
        /// <summary>
        /// Govind
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult SaveRecords(ServiceReference1.DocumentDetailsBO ddbo)
        {
            var fileName = Path.GetFileName(ddbo.Path);
            var ext = Path.GetExtension(ddbo.Path);
            string strpath = @"D:\UploadDocs\";// Server.MapPath("/CompanyDocuments/");
            string destinationpath = string.Empty;
            strpath = strpath + ddbo.CompanyId + "\\" + ddbo.UserId + "\\";
            destinationpath = strpath + ddbo.ChildDocumentId + ext;
            var temppath = ddbo.Path;
            ddbo.Path = destinationpath;

            if (!Directory.Exists(strpath))
            {
                Directory.CreateDirectory(strpath);
                if (System.IO.File.Exists(temppath))
                {
                    System.IO.File.Copy(temppath, destinationpath, true);
                    System.IO.File.Delete(temppath);
                }               
            }
            else
            {
                if (System.IO.File.Exists(temppath))
                {
                    System.IO.File.Copy(temppath, destinationpath, true);
                    System.IO.File.Delete(temppath);
                }
            }
            int index = Clients.DocumentDetailsInsert(ddbo);
            ddbo.Action = "I";
            return Json(JsonConvert.SerializeObject(Clients.GetDocumentDetails(ddbo)));
        }

        /// <summary>
        /// Govind
        /// Returns document list on search
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetRecords(ServiceReference1.DocumentDetailsBO ddbo)//int compid, int userid, int doctype, int pdoctype)
        {
            var text = JsonConvert.SerializeObject(Clients.GetDocumentDetails(ddbo));
            return Json(text);
        }

        /// <summary>
        /// Govind
        /// It deletes record and return document for the promotors
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult DeleteRecord(ServiceReference1.DocumentDetailsBO ddbo)
        {
            try
            {
                var list = Clients.GetDocumentDetails(ddbo);
                var text = JsonConvert.SerializeObject(list);
                return Json(text);
            }
            catch (Exception ex) { throw ex; }
        }


        /// <summary>
        /// Govind
        /// </summary>
        /// <returns></returns>
        public JsonResult getDocumentList(int parent)
        {
            ServiceReference1.CustomerRegistrationClient clients = new ServiceReference1.CustomerRegistrationClient();
            var list = clients.GetDocumentsList(parent);
            return Json(list);
        }

        [HttpPost]
        public JsonResult Download(string path)
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(@path);
            var fileName = Path.GetFileName(path);

            Byte[] bytes = System.IO.File.ReadAllBytes(path);
            String file = Convert.ToBase64String(bytes);

            return Json(file);
        }

        /// <summary>
        /// Govind
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetCompanyDetailList(string type, int compid)
        {
            ServiceReference1.CustomerRegistrationClient clients = new ServiceReference1.CustomerRegistrationClient();
            var list = clients.GetCompanyDetails(type, compid);
            //var text = JsonConvert.SerializeObject(list);
            return Json(list);
        }

        /// <summary>
        /// Govind
        /// Checks file is exist or not if yes then
        /// </summary>
        /// <param name="ddbo"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult CheckfileExist(ServiceReference1.DocumentDetailsBO ddbo)
        {
            return Json(Clients.Checkfileexist(ddbo));
        }

        [HttpPost]
        public JsonResult SetSession(string ID,string value)
        {            
            System.Web.HttpContext.Current.Session[ID] = value;
            return Json(System.Web.HttpContext.Current.Session[ID].ToString());
        }

        [HttpPost]
        public JsonResult GetSession(string ID)
        {
            return Json(System.Web.HttpContext.Current.Session[ID].ToString());
        }

        [HttpPost]
        public JsonResult GetPromotorsDetails(ServiceReference1.CustomerDetailsBO objCustomer)
        {
            return Json(JsonConvert.SerializeObject(Clients.GetPromotorsDetails(objCustomer)));
        }

        [HttpPost]
        public JsonResult GetFacilitiesTypes(ServiceReference1.FacilitiesTypesBO objFacility)
        {
            return Json(JsonConvert.SerializeObject(Clients.GetFacilitiesTypes(objFacility)));
        }

        [HttpPost]
        public JsonResult GetProposeTypes(ServiceReference1.FacilitiesTypesBO objFacility)
        {
            return Json(JsonConvert.SerializeObject(Clients.GetProposeTypes(objFacility)));
        }

        [HttpPost]
        public JsonResult GetMachineDetails(ServiceReference1.MachineDetailsBO objMachine)
        {
            return Json(JsonConvert.SerializeObject(Clients.GetMachineDetails(objMachine)));
        }

        [HttpPost]
        public JsonResult GetAssociate(ServiceReference1.AssociateBO objAssociate)
        {
            return Json(JsonConvert.SerializeObject(Clients.GetAssociate(objAssociate)));
        }

        [HttpPost]
        public JsonResult GetSummaryDetails(ServiceReference1.CollateralsSummaryBO objSummary)
        {
            return Json(JsonConvert.SerializeObject(Clients.GetCollateralsSummary(objSummary)));
        }

        [HttpPost]
        public JsonResult GetPerformanceEstimates(ServiceReference1.PerformanceEstimateBO ObjPerformance)
        {
            return Json(JsonConvert.SerializeObject(Clients.GetPerformanceEstimates(ObjPerformance)));
        }

        [HttpPost]
        public JsonResult GetScore(ServiceReference1.ScoreBO objScore)
        {
            return Json(JsonConvert.SerializeObject(Clients.GetScore(objScore)));
        }

        [HttpPost]

        public JsonResult GetStatutoryDetails(ServiceReference1.StatutoryBO objStatutory)
        {
            return Json(JsonConvert.SerializeObject(Clients.GetStatutoryDetails(objStatutory)));
        }

        [HttpPost]
        public JsonResult GetMenulist(int userid)
        {
            //ServiceReference.CustomerRegistrationClient clients = new ServiceReference.CustomerRegistrationClient();
            DataSet ds = Clients.GetMenuList(userid);

            var strmenu = string.Empty;

            var parentmenu = (from data in ds.Tables[0].AsEnumerable() select data).Where(x => x.Field<int?>("ParentId") == null).CopyToDataTable();


            strmenu = "<ul class='nav nav-pills nav-stacked' id='ulMenu'>";
            for (int i = 0; i < parentmenu.Rows.Count; i++)
            {
                DataTable childmenu = null;
                try
                {
                    childmenu = (from childdata in ds.Tables[0].AsEnumerable() select childdata).Where(x => x.Field<int?>("ParentId") == Convert.ToInt32(parentmenu.Rows[i]["Id"])).CopyToDataTable();
                }
                catch (Exception ex) { childmenu = null; }

                if (childmenu == null)
                {
                    strmenu = strmenu + "<li><a href='#'><span class='" + parentmenu.Rows[i]["menu_class"].ToString() + "'></span>" + parentmenu.Rows[i]["Menu_Name"].ToString() + "</a></li>";
                }
                else
                {
                    strmenu = strmenu + "<li onclick='checktest(this)'><a href='#'><span class='" + parentmenu.Rows[i]["menu_class"].ToString() + "'></span>" + parentmenu.Rows[i]["Menu_Name"].ToString() + "<span class='caret menucaret'></span></a>";
                    strmenu = strmenu + "<ul class='nav nav-pills nav-stacked submenu bg-info'>";
                    for (int j = 0; j < childmenu.Rows.Count; j++)
                    {
                        strmenu += "<li><a href = '" + childmenu.Rows[j]["Url"].ToString() + "'> " + childmenu.Rows[j]["Menu_Name"].ToString() + " </a></li>";
                    }
                    strmenu = strmenu + "</ul></li>";
                }
            }
            strmenu = strmenu + "</ul>";
            return Json(strmenu);
        }

        [HttpPost]
        public JsonResult InsertUserDetails(ServiceReference1.UsermasterBO objusermaster)
        {
            return Json(JsonConvert.SerializeObject(Clients.UserMasterInsert(objusermaster)));
        }

        [HttpPost]
        public JsonResult GetUserDetails(ServiceReference1.UsermasterBO objusermaster)
        {
            return Json(JsonConvert.SerializeObject(Clients.GetUserMaster(objusermaster)));
        }

        [HttpPost]
        public JsonResult GetConstitution()
        {
            return Json(JsonConvert.SerializeObject(Clients.GetConstitution()));
        }

        
             
    }

}
