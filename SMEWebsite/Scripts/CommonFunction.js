//Validation of Estimates Tab
function EstimatesValidation() {
    var Lo_Obj = ["ddlFacilitesType", "txtCurrentYear", "txtFirst", "txtSecond", "txtNextYear"];
    var Ls_Msg = ["Facilites Type", "Current Year", "First Year", "Second Year", "Next Year"];
    var bool = true;
    if (!CheckMandatory(Lo_Obj, Ls_Msg)) {
        bool = false;
        return false;
    }
    return bool;
}

//Validation of Summary Tab
function SummaryValidation() {
    
    var Lo_Obj = ["ddlCollateralType", "txtArea", "ddlSummState", "ddlSummCity", "txtAge", "txtValue", "txtLocation", "textBusinessActivity", "textFuturePlanes"];
    var Ls_Msg = ["Collateral Type", "Area", "State", "City", "Age", "Value", "Location", "Bussiness Activity", "Future Plans"];
    var bool = true;
    if (!CheckMandatory(Lo_Obj, Ls_Msg)) {
        bool = false;
        return false;
    }
    return bool;
}

//Validation of Statutory Tab
function StatutoryValidation() {
    var Lo_Obj = ["ChkIsShopYes", "ChkIsShopNo", "txtRegShop", "ChkRegUnderSSIYes", "ChkRegUnderSSINo", "txtRegUnderSSI", "ChkDrugLicenceYes", ];
    var Ls_Msg = ["Facilites Type", "Current Year", "First Year", "Second Year", "Next Year"];

    if (!CheckMandatory(Lo_Obj, Ls_Msg)) {
        return false;
    }
}

//Validation of Machine Tab
function MachineValidation() {
    var Lo_Obj = ["txtMachine", "txtMachinePurpose", "txtMachineSupplier", "txtMachineCost"];
    var Ls_Msg = ["Machine Type", "Machine Purpose", "Machine Supplier",  "Machine Cost"];

    if (!CheckMandatory(Lo_Obj, Ls_Msg)) {
        return false;
    }
    else
    {
        return true;
    }
}

//Validation of Bank Tab
function BankValidation() {
    var Lo_Obj = ["txtAsociateName", "txtBankName", "txtNatureAssociation", "textBankRAddres"];
    var Ls_Msg = ["Name", "Bank Name", "Nature Of Association", "Bank Addres"];

    if (!CheckMandatory(Lo_Obj, Ls_Msg)) {
        return false;
    }
}

//Validation of Facilities Tab
function FacilitiesValidation() {
    var bool = true;
    var Lo_Obj = ["ddlFacType", "txtFacLimit", "txtFacOutstand", "txtFacBanker", "txtFacCollateral", "txtFacROI", "txtFacTenure"];
    var Ls_Msg = ["Facilites Type", "Limit", "Outstand", "Banker", "Collateral", "ROI", "Tenure"];

    if (!CheckMandatory(Lo_Obj, Ls_Msg)) {
        return false;
    }
    return bool;
}

//Validation of  Proposed Tab
function ProposedValidation() {
    var bool = true;
    var Lo_Obj = ["ddlProType", "txtProLimit", "txtProOutstand", "txtProBanker", "txtProCollateral", "txtProROI", "txtProTenure"];
    var Ls_Msg = ["Facilites Type", "Limit", "Outstand", "Banker", "Collateral", "ROI", "Tenure"];

    if (!CheckMandatory(Lo_Obj, Ls_Msg)) {
        return false;
    }
    return bool;
}

//Validation of  Associate Tab
function AssociateValidation() {
    var bool = true;
    var Lo_Obj = ["ddlAssociateType", "txtAssociateName", "txtAssociateLimit", "txtAssociateOutstand", "txtAssociateBanker", "txtAssociateCollateral",
                  "txtAssociateROI", "txtAssociateTenure"];
    var Ls_Msg = ["Facilites Type", "Associate Name", "Limit", "Outstand", "Banker", "Collateral", "ROI", "Tenure"];

    if (!CheckMandatory(Lo_Obj, Ls_Msg)) {
        return false;
    }
    return bool;
}

//Validation of Document Tab
function DocumentValidation() {
    var bool = true;
    var Lo_Obj = ["ddldocTypes", "ddldocType", "ddlcompany", "ddlpromotors", "hdnfilepath"];
    var Ls_Msg = ["Document Type", "Document","Company","Promotor",""];

    if (!CheckMandatory(Lo_Obj, Ls_Msg)) {
        return false;
    }
    return bool;
}

//Validation of Promoter Tab
function PromoterValidation() {

    

    var bool = true;
    var Lo_Obj = ["ddlOwner", "ddlPromPrefer", "txtPromFName", "txtPromMName", "txtPromLName", "ddlPromNominee", "txtPromNomineeName", "txtPromDBO", "ddlGender",
                  "txtPromCAddres", "ddlPromCState", "ddlPromCCity", "txtPromCPIN", "txtPromPAddress", "ddlPromPState", "ddlPromPCity", "txtPromPPIN",
                  "txtPromPhone", "txtPromCell", "txtPromPan", "txtPromAdhar", "txtPromQualification", "txtPromEmail"];
    var Ls_Msg = ["Company Owner", "Preference", "First Name", "Middele Name", "Last Name", "Nominee Type", "Nominee Name", "Date of Birth", "Gender",
                  "Current Address", "Current state", "Current city", "Current pin", "Permanent Address", "Permanent State", "Permanent City", "Permanent PIN",
                  "Landline Number", "Mobile Number", "PAN Number", "Adhar Number", "Qualification", "Email"];

    if (!CheckMandatory(Lo_Obj, Ls_Msg)) {
        return false;
    }
    return bool;
}

//Validation of Company Tab
function CompanyValidation() {   
    var Lo_Obj = ["ddlCompPrefer", "txtCompName", "textCompRAddres", "txtCompCPIN", "txtCompDBE", "txtCompPan", "textCompPAddress",
                  "txtCompPPIN", "textCompPermanentAddress", "txtCompPermanentPPIN", "txtCompEmail", "txtCompPhone", "txtCompCell"];
    var Ls_Msg = ["Constitution Type", "Name of Enterprice", "REGD Office Address", "Pin", "Date of Establishment", "PAN Number",
                  "Address of Factory/Shop", "Pin", "Permanent Address", "Pin", "Email ", "Landline", "Mobile"];
    var bool = true;
    if (!CheckMandatory(Lo_Obj, Ls_Msg)) {
        return false;
    }
    return bool;
}

function RegistrationValidation()
{
    var Lo_Obj = ["ddlGroup", "txtEmpCode", "txtUserName", "txtPassword", "txtCPassword", "txtEmail"];
    var Ls_Msg = ["Group Type", "Employee Code", "Username", "Password", "Confirm Password", "Email"];
    var bool = true;
    if (!CheckMandatory(Lo_Obj, Ls_Msg)) {
        return false;
    }
    return bool;
}

//Validation of Score Tab
function ScoreValidation(Po_Obj, Ps_Msg) {  
    var Lo_Obj = ["txtagency", "txtRating"];
    var Ls_Msg = ["Agency Name", "Rating"];
    var bool = true;
    if (!CheckMandatory(Lo_Obj, Ls_Msg)) {      
        return false;
    } 
    return bool;
}


function isEmail(email) {
    
    var regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    return regex.test(email);
}


function CheckMandatory(Po_Obj, Ps_Msg) {
  
    var Values = null;
    var Element = null;
    for (var i = 0; i < Po_Obj.length; i++) {
        
        Values = document.getElementById(Po_Obj[i]).value;
        Element = document.getElementById(Po_Obj[i]);
        //alert("Values - " + Values + "  Element - " + Element);
        if (Element.type == "text" || Element.type == "password" || Element.type == "textarea") {      
            if (Values == "") {
                alert(Ps_Msg[i] + " cannot be left blank");           
                return false;
            }
            else if (Po_Obj[i].includes('Email')) {
                if (!isEmail(Values)) {
                    alert('Wrong Email format');
                    return false;
                }
                else {
                    return true;
                }
            }
        }
        else if(Element.type == "checkbox")
        {
            if(Element.checked == false)
            {
                alert("Plese Check " + Ps_Msg[i]);
                return false;
            }
        }
        else {
            if (Element.type == "select-one") {
                if (Values == 0) {
                    alert("Please select " + Ps_Msg[i]);
                    // Elem.focus();
                    return false;
                }
            }
        }
    }
    Po_Obj = null;
    return true;
}





