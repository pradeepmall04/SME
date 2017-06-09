using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using SMEWebsite.BussinessObject;

namespace SMEWebsite.Controllers
{
    public class IncomeController : Controller
    {
        ServiceReference1.CustomerRegistrationClient Clients = new ServiceReference1.CustomerRegistrationClient();
        // GET: Income
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EquitiesAndLiabilities()
        {
            return View();
        }

        public ActionResult UploadCompanyExcel()
        {
            return View();
        }

        public ActionResult LoanType()
        {
            return View();
        }

        public JsonResult InsertEquitiesAndLiabilities(List<GetEquitiesLiabilitiesBO> objEquiLib)
        {
            DataTable dt = ToDataTable(objEquiLib);
 
            dt.TableName = "TblEquiLib";
            DataTable testdt = Clients.InsertCompanyLiabilities(dt);
                        
            return Json(DataTableToJSONWithStringBuilder(testdt));
        }

        public JsonResult InsertIncomeDetails(List<GetProfitDetailsBO> objIncome)
        {
            DataTable dt = ToIncomeDataTable(objIncome);
            dt.TableName = "TblIncome";
            DataTable dtIncome = Clients.InsertCompanyIncome(dt);
            return Json(DataTableToJSONWithStringBuilder(dtIncome));
        }

        public DataTable ToDataTable(List<GetEquitiesLiabilitiesBO> data)
        {
            
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(GetEquitiesLiabilitiesBO));
            DataTable table = new DataTable();
            
            table.Columns.Add("CompId",typeof(int));
            table.Columns.Add("Year",typeof(int));
            table.Columns.Add("ShareCapital",typeof(decimal));
            table.Columns.Add("ReserveSurplus",typeof(decimal));
            table.Columns.Add("TotalNetWorth", typeof(decimal));
            table.Columns.Add("LongBorrowings", typeof(decimal));
            table.Columns.Add("LongLiabilities", typeof(decimal));
            table.Columns.Add("totalliabilities", typeof(decimal));
            table.Columns.Add("bankfinance", typeof(decimal));
            table.Columns.Add("tradepayables", typeof(decimal));
            table.Columns.Add("statutorydues", typeof(decimal));
            table.Columns.Add("othercurrentliabilities", typeof(decimal));
            table.Columns.Add("totalcurrentliabilities", typeof(decimal));
            table.Columns.Add("totalequitiesliabilities", typeof(decimal));
            table.Columns.Add("netfiextangible", typeof(decimal));
            table.Columns.Add("netfixedintangible", typeof(decimal));
            table.Columns.Add("capitalwork", typeof(decimal));
            table.Columns.Add("othernoncurrentAssets", typeof(decimal));
            table.Columns.Add("currentAssets", typeof(decimal));
            table.Columns.Add("RawMaterials", typeof(decimal));
            table.Columns.Add("WIP", typeof(decimal));
            table.Columns.Add("storesConsumables", typeof(decimal));
            table.Columns.Add("FinishedGoods", typeof(decimal));
            table.Columns.Add("TotalInventories", typeof(decimal));
            table.Columns.Add("Lessdays", typeof(decimal));
            table.Columns.Add("Moredays", typeof(decimal));
            table.Columns.Add("TotalDebtors", typeof(decimal));
            table.Columns.Add("ShortTermloans", typeof(decimal));
            table.Columns.Add("OthercurrentAssets", typeof(decimal));
            table.Columns.Add("TotalAssets", typeof(decimal));
            table.Columns.Add("check", typeof(decimal));
            table.Columns.Add("IsActive", typeof(bool));


            object[] values = new object[props.Count];
            foreach (GetEquitiesLiabilitiesBO item in data)
            {
                DataRow dr = table.NewRow();
                {
                    dr["CompId"] = item.CompId;
                    dr["Year"] = item.Year;
                    dr["ShareCapital"] = item.ShareCapital;
                    dr["ReserveSurplus"] = item.ReserveSurplus;
                    dr["TotalNetWorth"] = item.TotalNetWorth;
                    dr["LongBorrowings"] = item.LongBorrowings;
                    dr["LongLiabilities"] = item.LongLiabilities;
                    dr["totalliabilities"] = item.totalliabilities;
                    dr["bankfinance"] = item.bankfinance;
                    dr["tradepayables"] = item.tradepayables;
                    dr["statutorydues"] = item.statutorydues;
                    dr["othercurrentliabilities"] = item.othercurrentliabilities;
                    dr["totalcurrentliabilities"] = item.totalcurrentliabilities;
                    dr["totalequitiesliabilities"] = item.totalequitiesliabilities;
                    dr["netfiextangible"] = item.netfiextangible;
                    dr["netfixedintangible"] = item.netfixedintangible;
                    dr["capitalwork"] = item.capitalwork;
                    dr["othernoncurrentAssets"] = item.othernoncurrentAssets;
                    dr["currentAssets"] = item.currentAssets;
                    dr["RawMaterials"] = item.RawMaterials;
                    dr["WIP"] = item.WIP;
                    dr["storesConsumables"] = item.storesConsumables;
                    dr["FinishedGoods"] = item.FinishedGoods;
                    dr["TotalInventories"] = item.TotalInventories;
                    dr["Lessdays"] = item.Lessdays;
                    dr["Moredays"] = item.Moredays;
                    dr["TotalDebtors"] = item.TotalDebtors;
                    dr["ShortTermloans"] = item.ShortTermloans;
                    dr["OthercurrentAssets"] = item.OthercurrentAssets;
                    dr["TotalAssets"] = item.TotalAssets;
                    dr["check"] = item.check;
                    dr["IsActive"] = 1;
                }
                table.Rows.Add(dr);
            }
            return table;
        }
       
        /// <summary>
        /// ""
        /// Data To DataTable
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public DataTable ToIncomeDataTable(List<GetProfitDetailsBO> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(GetProfitDetailsBO));
            DataTable table = new DataTable();

            
            table.Columns.Add("CompId", typeof(int));
            table.Columns.Add("Year", typeof(int));
            table.Columns.Add("Sales", typeof(decimal));
            table.Columns.Add("OtherIncome", typeof(decimal));
            table.Columns.Add("TotalIncome", typeof(decimal));
            table.Columns.Add("RowMaterialConsumed", typeof(decimal));
            table.Columns.Add("StoresAndConsumables", typeof(decimal));
            table.Columns.Add("DirectManPower", typeof(decimal));
            table.Columns.Add("PowerAndFuel", typeof(decimal));
            table.Columns.Add("OtherDirectManufacturing", typeof(decimal));
            table.Columns.Add("ChangesInInventories", typeof(decimal));
            table.Columns.Add("Administrative", typeof(decimal));
            table.Columns.Add("SellingAndDistribution", typeof(decimal));
            table.Columns.Add("TotalExpenditure", typeof(decimal));
            table.Columns.Add("EBIDTA", typeof(decimal));
            table.Columns.Add("Depriciation", typeof(decimal));
            table.Columns.Add("FinanceCost", typeof(decimal));
            table.Columns.Add("PBT", typeof(decimal));
            table.Columns.Add("Tax", typeof(decimal));
            table.Columns.Add("PAT", typeof(decimal));
            table.Columns.Add("Action", typeof(string));            


            object[] values = new object[props.Count];
            foreach (GetProfitDetailsBO item in data)
            {
                DataRow dr = table.NewRow();
                {                    
                    dr["CompId"] = item.CompId;
                    dr["Year"] = item.Year;
                    dr["Sales"] = item.Sales;
                    dr["OtherIncome"] = item.OtherIncome;
                    dr["TotalIncome"] = item.TotalIncome;
                    dr["RowMaterialConsumed"] = item.RowMaterialConsumed;
                    dr["StoresAndConsumables"] = item.StoresAndConsumables;
                    dr["DirectManPower"] = item.DirectManPower;
                    dr["PowerAndFuel"] = item.PowerAndFuel;
                    dr["OtherDirectManufacturing"] = item.OtherDirectManufacturing;
                    dr["ChangesInInventories"] = item.ChangesInInventories;
                    dr["Administrative"] = item.Administrative;
                    dr["SellingAndDistribution"] = item.SellingAndDistribution;
                    dr["TotalExpenditure"] = item.TotalExpenditure;
                    dr["EBIDTA"] = item.EBIDTA;
                    dr["Depriciation"] = item.Depriciation;
                    dr["FinanceCost"] = item.FinanceCost;
                    dr["PBT"] = item.PBT;
                    dr["Tax"] = item.Tax;
                    dr["PAT"] = item.PAT;
                    dr["Action"] = item.Action;                    
                }
                table.Rows.Add(dr);
            }
            return table;
        }

        /// <summary>
        /// convert DataTable in json string
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static string DataTableToJSONWithStringBuilder(DataTable table)
        {
            var JSONString = new StringBuilder();
            if (table.Rows.Count > 0)
            {
                JSONString.Append("[");
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    JSONString.Append("{");
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        if (j < table.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\",");
                        }
                        else if (j == table.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\"");
                        }
                    }
                    if (i == table.Rows.Count - 1)
                    {
                        JSONString.Append("}");
                    }
                    else
                    {
                        JSONString.Append("},");
                    }
                }
                JSONString.Append("]");
            }
            return JSONString.ToString();
        }

        /// <summary>
        /// ""
        /// DownLoad Income Excel
        /// </summary>
        /// <param name="objIncome"></param>
        /// <returns></returns>
        public JsonResult DownloadIncomeExcel(ServiceReference1.GetProfitDetailsBO objIncome)
        {
            DataTable dt = Clients.CompanyIncomeDetails(objIncome);
            string str = string.Empty;
            if (objIncome.Action == "S")
                str = CreateIncomeExcel(dt);
            else
                str = DataTableToJSONWithStringBuilder(dt);
             return Json(str);
        }

        /// <summary>
        /// ""
        /// DownLoad Equity And Liability
        /// </summary>
        /// <param name="objEquiLib"></param>
        /// <returns></returns>
        public JsonResult DownloadEquiLib(ServiceReference1.GetEquitiesLiabilitiesBO objEquiLib)
        {
            DataTable dt = Clients.CompanyEquitiesAndLiabilitiesDetails(objEquiLib);
            string str = string.Empty;
            if (objEquiLib.Action == "S")
                str = CreateEquiLibExcel(dt);
            else
                str = DataTableToJSONWithStringBuilder(dt);
            return Json(str);
        }

        public string CreateIncomeExcel(DataTable dt)
        {

            string str = "";

            var IncYrs = (from data in dt.AsEnumerable() select data.Field<int>("Years")).Distinct();

            str = str + "<table id='testexcel' style='display:none;'><tr><td style='1px solid black;'><b>Particulars</b></td>";
            string tempRow = "<tr><td></td>";
            string headTempRow = "";
            for (int i = 0; i < IncYrs.Count(); i++)
            {
                str = str + "<td style='1px solid black;'><b>" + IncYrs.ElementAt(i).ToString()+"</b></td>";
                tempRow = tempRow + "<td></td>";
                headTempRow = headTempRow + "<td></td>";
            }

            tempRow = tempRow + "</tr>";

                DataTable tabledata = (from data in dt.AsEnumerable() select data).CopyToDataTable();
                
                for (int j = 1; j < tabledata.Columns.Count;j++)
                {
                    var tddata = from d in tabledata.AsEnumerable() select d.Field<decimal>(tabledata.Columns[j].ToString());
                    str = str + "<tr><td style='1px solid black;'><b>" + tabledata.Columns[j].ToString()+"</b></td>";
                    for(int i = 0;i< tddata.Count(); i++)
                    {
                        str = str + "<td style='1px solid black;'>" + tddata.ElementAt(i).ToString()+ "</td>";
                    }
                    str = str + "</tr>";
                }            
            str = str + "</table>";
            return str;
        }

        public string CreateEquiLibExcel(DataTable dt)
        {
            string str = "";

            var IncYrs = (from data in dt.AsEnumerable() select data.Field<int>("Years")).Distinct();

            str = str + "<table id='testexcel' style='display:none;'><tr><td style='1px solid black;'><b>Equities & Liabilities</ b></td>";
                        
            for (int i = 0; i < IncYrs.Count(); i++)
            {
                str = str + "<td style='1px solid black;'><b>" + IncYrs.ElementAt(i).ToString() + "</b></td>";

            }

            DataTable tabledata = (from data in dt.AsEnumerable() select data).CopyToDataTable();

            for (int j = 1; j < tabledata.Columns.Count; j++)
            {
                var tddata = from d in tabledata.AsEnumerable() select d.Field<decimal>(tabledata.Columns[j].ToString());
                str = str + "<tr><td style='1px solid black;'><b>" + tabledata.Columns[j].ToString() + "</b></td>";
                for (int i = 0; i < tddata.Count(); i++)
                {
                    str = str + "<td style='1px solid black;'>" + tddata.ElementAt(i).ToString() + "</td>";
                }
                str = str + "</tr>";
            }
            str = str + "</table>";
            return str;
        }

        /// <summary>
        /// "" 
        /// Upload File
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
                    if (fileExtension == ".xls" || fileExtension == ".xlsx")
                    {
                        //path = Path.Combine(Server.MapPath("~/TempImageUpload/"), DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('-', '_') + "_" + fileName);

                        path = @"D:\RBSMEWEB\UploadFile\" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('-', '_').Replace('\\', '_').Replace('/', '_') + "_" + fileName;
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
            catch (Exception ex)
            {
                return Json("Error While Saving.");
            }
        }

        /// <summary>
        /// ""
        /// Insert Income Excel To DB
        /// </summary>
        /// <param name="compId"></param>
        /// <param name="Type"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult IncomeExcelInsert(int compId , int Type, string path)
        {
            try
            {               
                string fileExtension = System.IO.Path.GetExtension(path);
                string sSheetName = null;
                string sConnection = null;
                DataTable dtTablesList = default(DataTable);
                OleDbConnection oleExcelConnection = default(OleDbConnection);

                if (fileExtension == ".xls")
                    sConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"";
                else if (fileExtension == ".xlsx")
                    sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"";


                oleExcelConnection = new OleDbConnection(sConnection);
                oleExcelConnection.Open();

                dtTablesList = oleExcelConnection.GetSchema("Tables");

                if (dtTablesList.Rows.Count > 0)
                {
                    sSheetName = dtTablesList.Rows[0]["TABLE_NAME"].ToString();
                }

                for (int i = 0; dtTablesList.Rows.Count > i; i++)
                {
                    if (!string.IsNullOrEmpty(dtTablesList.Rows[i]["TABLE_NAME"].ToString()))
                    {

                        OleDbConnection con = new OleDbConnection(sConnection);
                        con.Open();
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "Select * From [" + sSheetName + "]";
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        //nOutputRow = 0;
                        OleDbDataAdapter da1 = new OleDbDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da1.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            if (Type == 1)
                            {
                                DataTable Incomedt = IncomeExcelToDataTable(compId, dt);
                                Incomedt.TableName = "IncomeDt";
                                DataTable dtIncome = Clients.InsertCompanyIncome(Incomedt);
                                return Json(DataTableToJSONWithStringBuilder(dtIncome));
                            }
                            if(Type == 2)
                            {
                                DataTable EquiLibDt = EquilibExcelToDataTable(compId, dt);
                                EquiLibDt.TableName = "EquiLibDt";
                                DataTable dtIncome = Clients.InsertCompanyLiabilities(EquiLibDt);
                                return Json(DataTableToJSONWithStringBuilder(dtIncome));
                            }
                        }
                        con.Close();
                        con.Dispose();
                        cmd.Dispose();
                    }
                    dtTablesList.Clear();
                    dtTablesList.Dispose();
                }
                return Json("File Saved Successfully.");                
        }
        catch (Exception ex)
        { return Json("Error While Processing."); }
}

        /// <summary>
        /// "" 
        /// Convert Income Excel to DataTable
        /// </summary>
        /// <param name="compId"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public DataTable IncomeExcelToDataTable(int compId,DataTable data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(GetProfitDetailsBO));
            DataTable table = new DataTable();


            table.Columns.Add("CompId", typeof(int));
            table.Columns.Add("Year", typeof(int));
            table.Columns.Add("Sales", typeof(decimal));
            table.Columns.Add("OtherIncome", typeof(decimal));
            table.Columns.Add("TotalIncome", typeof(decimal));
            table.Columns.Add("RowMaterialConsumed", typeof(decimal));
            table.Columns.Add("StoresAndConsumables", typeof(decimal));
            table.Columns.Add("DirectManPower", typeof(decimal));
            table.Columns.Add("PowerAndFuel", typeof(decimal));
            table.Columns.Add("OtherDirectManufacturing", typeof(decimal));
            table.Columns.Add("ChangesInInventories", typeof(decimal));
            table.Columns.Add("Administrative", typeof(decimal));
            table.Columns.Add("SellingAndDistribution", typeof(decimal));
            table.Columns.Add("TotalExpenditure", typeof(decimal));
            table.Columns.Add("EBIDTA", typeof(decimal));
            table.Columns.Add("Depriciation", typeof(decimal));
            table.Columns.Add("FinanceCost", typeof(decimal));
            table.Columns.Add("PBT", typeof(decimal));
            table.Columns.Add("Tax", typeof(decimal));
            table.Columns.Add("PAT", typeof(decimal));
            table.Columns.Add("Action", typeof(string));

            DataTable dt = new DataTable();

            var col = (from d in data.AsEnumerable() select d.Field<string>("Particulars"));
            dt.Columns.Add("CompId", typeof(int));
            dt.Columns.Add("Year", typeof(int));
            for (int i =0;i<col.Count();i++)
            {
                dt.Columns.Add(col.ElementAt(i).ToString(), typeof(decimal));
            }
            dt.Columns.Add("Action", typeof(string));

            for(int i =1;i<data.Columns.Count;i++)
            {

                //var colval = from d in data.AsEnumerable() select d.Field<decimal>(data.Columns[i].ToString().Replace("(","").Replace(")",""));
                DataRow dtRow = table.NewRow();
                table.Rows.Add(dtRow);
                for (int j = 0; j < data.Rows.Count; j++)
                {

                    //table.Rows[i-1][j+2] = Convert.ToDecimal(data.Rows[j][i].ToString());
                    if (j == 0)
                    {
                        table.Rows[i - 1][j] = compId;
                        table.Rows[i - 1][j + 2] = Convert.ToDecimal(data.Rows[j][i].ToString());
                    }
                    else if (j == 1)
                    {
                        table.Rows[i - 1][j] = data.Columns[i].ToString().Replace("(", "").Replace(")", "");
                        table.Rows[i - 1][j + 2] = Convert.ToDecimal(data.Rows[j][i].ToString());
                    }
                    else
                        table.Rows[i - 1][j+2] = Convert.ToDecimal(data.Rows[j][i].ToString());
                }
            }


            
            return table;
        }

        /// <summary>
        /// "" 
        /// Convert EquiLib Excel To DataTable
        /// </summary>
        /// <param name="compId"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public DataTable EquilibExcelToDataTable(int compId,DataTable data)
        {
            DataTable table = new DataTable();
            table.Columns.Add("CompId", typeof(int));
            table.Columns.Add("Year", typeof(int));
            table.Columns.Add("ShareCapital", typeof(decimal));
            table.Columns.Add("ReserveSurplus", typeof(decimal));
            table.Columns.Add("TotalNetWorth", typeof(decimal));
            table.Columns.Add("LongBorrowings", typeof(decimal));
            table.Columns.Add("LongLiabilities", typeof(decimal));
            table.Columns.Add("totalliabilities", typeof(decimal));
            table.Columns.Add("bankfinance", typeof(decimal));
            table.Columns.Add("tradepayables", typeof(decimal));
            table.Columns.Add("statutorydues", typeof(decimal));
            table.Columns.Add("othercurrentliabilities", typeof(decimal));
            table.Columns.Add("totalcurrentliabilities", typeof(decimal));
            table.Columns.Add("totalequitiesliabilities", typeof(decimal));
            table.Columns.Add("netfiextangible", typeof(decimal));
            table.Columns.Add("netfixedintangible", typeof(decimal));
            table.Columns.Add("capitalwork", typeof(decimal));
            table.Columns.Add("othernoncurrentAssets", typeof(decimal));
            table.Columns.Add("currentAssets", typeof(decimal));
            table.Columns.Add("RawMaterials", typeof(decimal));
            table.Columns.Add("WIP", typeof(decimal));
            table.Columns.Add("storesConsumables", typeof(decimal));
            table.Columns.Add("FinishedGoods", typeof(decimal));
            table.Columns.Add("TotalInventories", typeof(decimal));
            table.Columns.Add("Lessdays", typeof(decimal));
            table.Columns.Add("Moredays", typeof(decimal));
            table.Columns.Add("TotalDebtors", typeof(decimal));
            table.Columns.Add("ShortTermloans", typeof(decimal));
            table.Columns.Add("OthercurrentAssets", typeof(decimal));
            table.Columns.Add("TotalAssets", typeof(decimal));
            table.Columns.Add("check", typeof(decimal));
            table.Columns.Add("IsActive", typeof(bool));


            DataTable dt = new DataTable();

            var col = (from d in data.AsEnumerable() select d.Field<string>("Equities & Liabilities"));
            dt.Columns.Add("CompId", typeof(int));
            dt.Columns.Add("Year", typeof(int));
            for (int i = 0; i < col.Count(); i++)
            {
                dt.Columns.Add(col.ElementAt(i).ToString(), typeof(decimal));
            }
            dt.Columns.Add("IsActive", typeof(string));

            for (int i = 1; i < data.Columns.Count; i++)
            {

                //var colval = from d in data.AsEnumerable() select d.Field<decimal>(data.Columns[i].ToString().Replace("(","").Replace(")",""));
                DataRow dtRow = table.NewRow();
                table.Rows.Add(dtRow);
                for (int j = 0; j < data.Rows.Count; j++)
                {

                    //table.Rows[i-1][j+2] = Convert.ToDecimal(data.Rows[j][i].ToString());
                    if (j == 0)
                    {
                        table.Rows[i - 1][j] = compId;
                        table.Rows[i - 1][j + 2] = Convert.ToDecimal(data.Rows[j][i].ToString());
                    }
                    else if (j == 1)
                    {
                        table.Rows[i - 1][j] = data.Columns[i].ToString().Replace("(", "").Replace(")", "");
                        table.Rows[i - 1][j + 2] = Convert.ToDecimal(data.Rows[j][i].ToString());
                    }
                    else
                        table.Rows[i - 1][j + 2] = Convert.ToDecimal(data.Rows[j][i].ToString());
                }
            }

            return table;
        }

        public JsonResult InsertLoanType(List<LoanTypeDetailsBO> objLoanDetails)
        {
            DataTable dt = SetDataTable(objLoanDetails);

            dt.TableName = "TblLoanType";
            DataTable testdt = Clients.LoanDetails(dt);

            return Json("");
        }

        public DataTable SetDataTable(List<LoanTypeDetailsBO> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(LoanTypeDetailsBO));
            DataTable table = new DataTable();
            table.Columns.Add("Company", typeof(int));
            table.Columns.Add("Year", typeof(int));
            table.Columns.Add("Loan_Type", typeof(int));
            table.Columns.Add("Opening", typeof(decimal));
            table.Columns.Add("Interest", typeof(decimal));
            table.Columns.Add("Principal", typeof(decimal));
            table.Columns.Add("Closing", typeof(decimal));
            table.Columns.Add("WC_Loan", typeof(decimal));
            table.Columns.Add("LC_Charges", typeof(decimal));
            table.Columns.Add("BC_Charges", typeof(decimal));
            table.Columns.Add("Other_Charges", typeof(decimal));
            table.Columns.Add("Total", typeof(decimal));
            object[] values = new object[props.Count];
            foreach (LoanTypeDetailsBO item in data)
            {
                DataRow dr = table.NewRow();
                {
                    dr["Company"] = item.Company;
                    dr["Year"] = item.Year;
                    dr["Loan_Type"] = item.Loan_Type;
                    dr["Opening"] = item.Opening;
                    dr["Interest"] = item.Interest;
                    dr["Principal"] = item.Principal;
                    dr["Closing"] = item.Closing;
                    dr["WC_Loan"] = item.WC_Loan;
                    dr["LC_Charges"] = item.LC_Charges;
                    dr["BC_Charges"] = item.BC_Charges;
                    dr["Other_Charges"] = item.Other_Charges;
                    dr["Total"] = item.Total;
                }
                table.Rows.Add(dr);
            }
            return table;
        }
    }
}
