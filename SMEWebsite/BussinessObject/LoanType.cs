using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMEWebsite.BussinessObject
{
    public class CompanyDetailsBO
    {

        public String Id { get; set; }
        public String Name { get; set; }
        public String Type { get; set; }

        public String Address { get; set; }

        public String City { get; set; }

        public String State { get; set; }

        public String PinCode { get; set; }

        public string DOE { get; set; }

        public string Pan { get; set; }

        public string FactoryAddress { get; set; }

        public String FactoryCity { get; set; }

        public String FactoryState { get; set; }

        public string FactoryPinCode { get; set; }

        public string PermanentAddress { get; set; }

        public String PermanentCity { get; set; }

        public String PermanentState { get; set; }

        public string PermanentPinCode { get; set; }

        public string PhoneNumber { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }

        //public string BusinessActivit { get; set; }

        //public string FuturePlans { get; set; }

        //public bool IsRegUnderShopAct { get; set; }

        //public string DescriptionRegUnderShopAct { get; set; }

        //public bool IsRegUnderSSI { get; set; }

        //public string DescriptionRegUnderSSI { get; set; }

        //public bool IsDrugLicence { get; set; }

        //public string DescriptionDrugLicence { get; set; }

        //public bool IsLSalesTax { get; set; }

        //public string DescriptionLSalesTax { get; set; }

        //public bool IsLIncomeTax { get; set; }

        //public string DescriptionLIncomeTax { get; set; }

        //public bool IsAnyotherdues { get; set; }

        //public string DescriptionAnyotherdues { get; set; }

        //public bool IsCreditFacilitesc { get; set; }

        public string IsActive { get; set; }

        public string CrtBy { get; set; }

        public string Action { get; set; }
    }

    public class CustomerDetailsBO
    {
        public string Id { get; set; }

        public string CompOwnerType { get; set; }

        public string CompanyId { get; set; }

        public string Company { get; set; }

        public string Prefix { get; set; }

        public string FName { get; set; }

        public string MName { get; set; }

        public string LName { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public string DOB { get; set; }

        public string Gender { get; set; }

        public string CurrentAddress { get; set; }

        public string CurrentCity { get; set; }

        public string CurrentState { get; set; }

        public string CurrentPinCode { get; set; }

        public string PermanentAddress { get; set; }

        public string PermanentCity { get; set; }

        public string PermanentState { get; set; }

        public string PermanentPinCode { get; set; }

        public string PhoneNumber { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }

        public string PAN { get; set; }

        public string Adhar { get; set; }

        public string Qualification { get; set; }

        public string IsActive { get; set; }

        public string CrtBy { get; set; }

        public string Action { get; set; }

    }

    public class MachineDetailsBO
    {
        public string Id { get; set; }

        public string CompanyId { get; set; }

        public string MachineType { get; set; }

        public string Purpose { get; set; }

        public string DI { get; set; }

        public string SupplierName { get; set; }

        public string TotalMachineCost { get; set; }

        public string IsSelfContribution { get; set; }

        public string IsLoanRequired { get; set; }

        public string IsActive { get; set; }

        public string CrtBy { get; set; }

        public string Action { get; set; }
    }

    public class BankDetailsBO
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int BankId { get; set; }

        public bool IsActive { get; set; }

        public DateTime CtdDate { get; set; }

        public int CrtBy { get; set; }

        public String Action { get; set; }
    }

    public class AssociateBO
    {
        public string Id { get; set; }

        public string AssociateName { get; set; }

        public string CompanyId { get; set; }

        public string Type { get; set; }

        public string Limit { get; set; }

        public string Outstand { get; set; }

        public string CurrentBanker { get; set; }

        public string Collater { get; set; }

        public string ROI { get; set; }

        public string TenureOD { get; set; }

        public string IsActive { get; set; }

        public string Action { get; set; }
    }

    public class CollateralsSummaryBO
    {
        public string Id { get; set; }

        public string CompanyId { get; set; }

        public string Type { get; set; }

        public string Area { get; set; }

        public string City { get; set; }

        public string Location { get; set; }

        public string PropertyAge { get; set; }

        public string Value { get; set; }

        public string SummaryBusinessActivity { get; set; }

        public string SummaryFuturePlanes { get; set; }

        public string IsActive { get; set; }

        public string CrtBy { get; set; }

        public string Action { get; set; }
    }

    public class PerformanceEstimateBO
    {
        public string Id { get; set; }

        public string CompanyId { get; set; }

        public string Type { get; set; }

        public string CurrentYear { get; set; }

        public string FirstYear { get; set; }

        public string SecondYear { get; set; }

        public string ThirdYear { get; set; }

        public string CrtBy { get; set; }

        public string Action { get; set; }
    }

    public class ScoreBO
    {
        public string Id { get; set; }

        public string CompanyId { get; set; }

        public string AgencyName { get; set; }

        public string Rating { get; set; }

        public string IsActive { get; set; }

        public string CrtBy { get; set; }

        public string Action { get; set; }
    }

    public class StatutoryBO
    {
        public string Id { get; set; }

        public string Company { get; set; }

        public string IsRegUnderShopAct { get; set; }

        public string DescriptionRegUnderShopAct { get; set; }

        public string IsRegUnderSSI { get; set; }

        public string DescriptionRegUnderSSI { get; set; }

        public string IsDrugLicence { get; set; }

        public string DescriptionDrugLicence { get; set; }

        public string IsLSalesTax { get; set; }

        public string DescriptionLSalesTax { get; set; }

        public string IsLIncomeTax { get; set; }

        public string DescriptionLIncomeTax { get; set; }

        public string IsAnyotherdues { get; set; }

        public string DescriptionAnyotherdues { get; set; }

        public string IsCreditFacilitesc { get; set; }

        public string IsActive { get; set; }

        public string CrtBy { get; set; }

        public string Action { get; set; }
    }

    public class DocumentDetailsBO
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string CompanyName { get; set; }

        public int UserId { get; set; }

        public string UserName { get; set; }

        public int ParentDocumentId { get; set; }

        public string ParentDocumentName { get; set; }

        public int ChildDocumentId { get; set; }

        public string ChildDocumentName { get; set; }

        public string Path { get; set; }

        public bool IsActive { get; set; }

        public int CrtBy { get; set; }
        public string Action { get; set; }
    }

    public class LoginBO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class CityDetailsBO
    {
        public int Id { get; set; }
        public string CityName { get; set; }
    }

    public class CommonBO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class StateDetailsBO
    {

        public int Id { get; set; }
        public string StateName { get; set; }
    }

    public class UserRegistrationBO
    {
        public string UserId { get; set; }

        public string Name { get; set; }

        public string EmpCode { get; set; }

        public string Pass { get; set; }

        public string EMail { get; set; }

        public string Role { get; set; }

        public string IsActive { get; set; }

        public string CrtBy { get; set; }

        public string Action { get; set; }
    }

    public class FacilitiesTypesBO
    {
        public string Id { get; set; }

        public string CompanyId { get; set; }

        public string Type { get; set; }

        public int TypeId { get; set; }

        public string Limit { get; set; }

        public string Outstand { get; set; }

        public string CurrentBanker { get; set; }

        public string Collater { get; set; }

        public string ROI { get; set; }

        public string TenureOD { get; set; }

        public string IsExist { get; set; }

        public string IsActive { get; set; }

        public string CrtBy { get; set; }

        public string Action { get; set; }
    }

    public class GetFacilitiesTypesBO
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string CompanyName { get; set; }

        public string Type { get; set; }

        public int TypeId { get; set; }

        public decimal Limit { get; set; }

        public decimal Outstand { get; set; }

        public string CurrentBanker { get; set; }

        public decimal Collater { get; set; }

        public string ROI { get; set; }

        public string TenureOD { get; set; }

        public bool IsExist { get; set; }

        public bool IsActive { get; set; }

        public DateTime CtdDate { get; set; }

        public int CrtBy { get; set; }

        public String Action { get; set; }
    }

    public class SearchCompanyBO
    {
        public string SearchKey { get; set; }
        public string CompayName { get; set; }
    }

    public class GetCompanyDetailsBO
    {

        public int Id { get; set; }

        public String Name { get; set; }

        public int Type { get; set; }

        public String Address { get; set; }

        public int City { get; set; }

        public int State { get; set; }

        public String PinCode { get; set; }

        public DateTime DOE { get; set; }

        public string Pan { get; set; }

        public string FactoryAddress { get; set; }

        public int FactoryCity { get; set; }

        public int FactoryState { get; set; }

        public string FactoryPinCode { get; set; }

        public string PermanentAddress { get; set; }

        public int PermanentCity { get; set; }

        public int PermanentState { get; set; }

        public string PermanentPinCode { get; set; }

        public string PhoneNumber { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }

        public string BusinessActivit { get; set; }

        public string FuturePlans { get; set; }

        public bool IsRegUnderShopAct { get; set; }

        public string DescriptionRegUnderShopAct { get; set; }

        public bool IsRegUnderSSI { get; set; }

        public string DescriptionRegUnderSSI { get; set; }

        public bool IsDrugLicence { get; set; }

        public string DescriptionDrugLicence { get; set; }

        public bool IsLSalesTax { get; set; }

        public string DescriptionLSalesTax { get; set; }

        public bool IsLIncomeTax { get; set; }

        public string DescriptionLIncomeTax { get; set; }

        public bool IsAnyotherdues { get; set; }

        public string DescriptionAnyotherdues { get; set; }

        public bool IsCreditFacilitesc { get; set; }

        public bool IsActive { get; set; }

        public int CrtBy { get; set; }

        public string Action { get; set; }
    }

    public class GetUserRegistrationBO
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string EmpCode { get; set; }

        public string Pass { get; set; }

        public string Email { get; set; }

        public int groupid { get; set; }

        public string IsActive { get; set; }

        public int CrtBy { get; set; }

        public String Action { get; set; }
    }

    public class GetAssociateBO
    {
        public int Id { get; set; }

        public string AssociateName { get; set; }

        public int CompanyId { get; set; }

        public string CompanyName { get; set; }

        public string Type { get; set; }

        public decimal Limit { get; set; }

        public decimal Outstand { get; set; }

        public string CurrentBanker { get; set; }

        public decimal Collater { get; set; }

        public string ROI { get; set; }

        public string TenureOD { get; set; }

        public bool IsExist { get; set; }

        public bool IsActive { get; set; }

        public DateTime CtdDate { get; set; }

        public int CrtBy { get; set; }

        public String Action { get; set; }
    }

    public class GetMachineDetailsBO
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string Company { get; set; }

        public string MachineType { get; set; }

        public string Purpose { get; set; }

        public bool DI { get; set; }

        public string SupplierName { get; set; }

        public decimal TotalMachineCost { get; set; }

        public bool IsSelfContribution { get; set; }

        public bool IsLoanRequired { get; set; }

        public bool IsActive { get; set; }

        public int CrtBy { get; set; }

        public string Action { get; set; }
    }

    public class GetCollateralsSummaryBO
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string Company { get; set; }

        public string Type { get; set; }

        public string Area { get; set; }

        public int City { get; set; }

        public string Location { get; set; }

        public string CityName { get; set; }

        public decimal PropertyAge { get; set; }

        public decimal Value { get; set; }

        public bool IsActive { get; set; }

        public int CrtBy { get; set; }

        public int State { get; set; }

        public string SummaryBusinessActivity { get; set; }

        public string SummaryFuturePlanes { get; set; }

        public string Action { get; set; }
    }

    public class GetStatutoryBO
    {
        public int Id { get; set; }

        public int Companyid { get; set; }

        public string Company { get; set; }

        public string BusinessActivit { get; set; }

        public string FuturePlans { get; set; }

        public bool IsRegUnderShopAct { get; set; }

        public string DescriptionRegUnderShopAct { get; set; }

        public bool IsRegUnderSSI { get; set; }

        public string DescriptionRegUnderSSI { get; set; }

        public bool IsDrugLicence { get; set; }

        public string DescriptionDrugLicence { get; set; }

        public bool IsLSalesTax { get; set; }

        public string DescriptionLSalesTax { get; set; }

        public bool IsLIncomeTax { get; set; }

        public string DescriptionLIncomeTax { get; set; }

        public bool IsAnyotherdues { get; set; }

        public string DescriptionAnyotherdues { get; set; }

        public bool IsCreditFacilitesc { get; set; }

        public string Action { get; set; }
    }

    public class GetScoreBO
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string Company { get; set; }

        public string AgencyName { get; set; }

        public string Rating { get; set; }

        public bool IsActive { get; set; }

        public int CrtBy { get; set; }

        public String Action { get; set; }
    }

    public class GetPerformanceEstimatesBO
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string Company { get; set; }

        public string Type { get; set; }

        public decimal CurrentYear { get; set; }

        public decimal FirstYear { get; set; }

        public decimal SecondYear { get; set; }

        public decimal ThirdYear { get; set; }

        public bool IsActive { get; set; }

        public int CrtBy { get; set; }

        public string Action { get; set; }
    }

    public class GetCustomerDetailsBO
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string Company { get; set; }

        public string Prefix { get; set; }

        public string FName { get; set; }

        public string MName { get; set; }

        public string LName { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public DateTime DOB { get; set; }

        public string CurrentAddress { get; set; }

        public int CurrentCity { get; set; }

        public string CurrentCityName { get; set; }

        public int CurrentState { get; set; }

        public string CurrentStateName { get; set; }

        public string CurrentPinCode { get; set; }

        public string PermanentAddress { get; set; }

        public int PermanentCity { get; set; }

        public string PermanentCityName { get; set; }

        public int PermanentState { get; set; }

        public string PermanentStateName { get; set; }

        public string PermanentPinCode { get; set; }

        public string PhoneNumber { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }

        public string PAN { get; set; }

        public string Adhar { get; set; }

        public string Qualification { get; set; }

        public bool IsActive { get; set; }

        public int CrtBy { get; set; }

        public string Gender { get; set; }

        public string CompOwnerType { get; set; }

        public string Action { get; set; }

    }

    public class MenuMappingBO
    {
        public int id { get; set; }
        public int menuid { get; set; }
        public int roleid { get; set; }
        public string createdate { get; set; }
        public int createby { get; set; }
        public string modifieddate { get; set; }
        public int modifiedby { get; set; }
        public string isview { get; set; }
        public bool isRead { get; set; }
        public bool isWrite { get; set; }
        public bool isDelete { get; set; }
        public int userid { get; set; }
        public string action { get; set; }
    }


    public class MenuMasterBo
    {
        public int Id { get; set; }

        public string Menu_Name { get; set; }

        public int ParentId { get; set; }

        public string ParentName { get; set; }

        public string Url { get; set; }

        public bool IsActive { get; set; }

        public bool IsRead { get; set; }

        public bool IsWrite { get; set; }

        public bool Isdelete { get; set; }

        public int Crt_By { get; set; }

        public string Crt_Dt { get; set; }

        public string Modified_Dt { get; set; }

        public int Modified_By { get; set; }

        public int userid { get; set; }

        public string Action { get; set; }
    }

    public class TestData
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class UsermasterBO
    {
        public int userid { get; set; }

        public string username { get; set; }

        public string empcode { get; set; }

        public string password { get; set; }

        public int groupid { get; set; }

        public string ip { get; set; }

        public string sysdate { get; set; }

        public int cuserid { get; set; }

        public string isactive { get; set; }

        public string createdon { get; set; }

        public string isadmin { get; set; }

        public string email { get; set; }

        public string deviceid { get; set; }

        public string tokenId { get; set; }

        public string Action { get; set; }
    }

    public class ConstitutionBO
    {
        public int Id { get; set; }
        public string Constitution { get; set; }
    }

    public class GetEquitiesLiabilitiesBO
    {
        public int Id { get; set; }
        public int CompId { get; set; }
        public int Year { get; set; }
        public decimal ShareCapital { get; set; }
        public decimal ReserveSurplus { get; set; }
        public decimal TotalNetWorth { get; set; }
        public decimal LongBorrowings { get; set; }
        public decimal LongLiabilities { get; set; }
        public decimal totalliabilities { get; set; }
        public decimal bankfinance { get; set; }
        public decimal tradepayables { get; set; }
        public decimal statutorydues { get; set; }
        public decimal othercurrentliabilities { get; set; }
        public decimal totalcurrentliabilities { get; set; }
        public decimal totalequitiesliabilities { get; set; }
        public decimal netfiextangible { get; set; }
        public decimal netfixedintangible { get; set; }
        public decimal capitalwork { get; set; }
        public decimal othernoncurrentAssets { get; set; }
        public decimal currentAssets { get; set; }
        public decimal RawMaterials { get; set; }
        public decimal WIP { get; set; }
        public decimal storesConsumables { get; set; }
        public decimal FinishedGoods { get; set; }
        public decimal TotalInventories { get; set; }
        public decimal Lessdays { get; set; }
        public decimal Moredays { get; set; }
        public decimal TotalDebtors { get; set; }
        public decimal ShortTermloans { get; set; }
        public decimal OthercurrentAssets { get; set; }
        public decimal TotalAssets { get; set; }
        public decimal check { get; set; }
        public string Action { get; set; }
    }

    public class GetProfitDetailsBO
    {
        public int Id { get; set; }
        public int CompId { get; set; }
        public int Year { get; set; }
        public decimal Sales { get; set; }
        public decimal OtherIncome { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal RowMaterialConsumed { get; set; }
        public decimal StoresAndConsumables { get; set; }
        public decimal DirectManPower { get; set; }
        public decimal PowerAndFuel { get; set; }
        public decimal OtherDirectManufacturing { get; set; }
        public decimal ChangesInInventories { get; set; }
        public decimal Administrative { get; set; }
        public decimal SellingAndDistribution { get; set; }
        public decimal TotalExpenditure { get; set; }
        public decimal EBIDTA { get; set; }
        public decimal Depriciation { get; set; }
        public decimal FinanceCost { get; set; }
        public decimal PBT { get; set; }
        public decimal Tax { get; set; }
        public decimal PAT { get; set; }
        public string Action { get; set; }
    }
    public class LoanTypeDetailsBO
    {
        public int Company { get; set; }
        public int Year { get; set; }
        public int Loan_Type { get; set; }
        public decimal Opening { get; set; }
        public decimal Interest { get; set; }
        public decimal Principal { get; set; }
        public decimal Closing { get; set; }
        public decimal WC_Loan { get; set; }
        public decimal LC_Charges { get; set; }
        public decimal BC_Charges { get; set; }
        public decimal Other_Charges { get; set; }
        public decimal Total { get; set; }
    }
}