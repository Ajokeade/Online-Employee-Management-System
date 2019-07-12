
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Reflection;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


using DotNetNuke;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using System.Web.SessionState;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Mail;
using DotNetNuke.Entities.Users;
using DotNetNuke.Security.Roles;
using DotNetNuke.Security.Membership;
using AspNetSecurity = System.Web.Security;
//using ola.HRMangmntSyst;
using Bilikis.HRManagementSystem;

namespace Bilikis.HRManagementSystem
{
    // public partial class EmployeePage : PortalModuleBase, IActionable
    public partial class EmployeePage : Bilikis.ModuleBase.ModuleBase, IActionable
    {
        string passport;
        string filepath2;
        int applicantID;
        int employeeID;
        int EmployeeUserID_FK;
        // int uid;
        // int UserID;
        int EmployeeID;
        string employeeNum;
        DataTable dt1 = new DataTable();
        bool flag = false;


        UserController objUserController = new UserController();

        RoleController objRoleController = new RoleController();

        public class PageUtility
        {
            public static void MessageBox(System.Web.UI.Page page, string strMsg)
            {
                ScriptManager.RegisterClientScriptBlock(page, page.GetType(), "alertMessage", "alert('+strMsg')", true);
            }
        }

        #region Optional Interfaces
        public ModuleActionCollection ModuleActions
        {
            get
            {
                ModuleActionCollection Actions = new ModuleActionCollection();
                Actions.Add(this.GetNextActionID(), Localization.GetString(ModuleActionType.AddContent, this.LocalResourceFile), ModuleActionType.AddContent, "", "", this.EditUrl(), false, SecurityAccessLevel.Edit, true, false);
                return Actions;
            }

        }
        #endregion


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MViewEmployee.ActiveViewIndex = 0;

                //loading Qualifications

                ArrayList objQualifications = new ArrayList();
                objQualifications = (new QualificationTableController()).List();

                if (objQualifications.Count > 0)
                {
                    qualifList.DataSource = objQualifications;
                    qualifList.DataTextField = "QualificationName";
                    qualifList.DataValueField = "QualificationID";
                    qualifList.DataBind();

                }
                qualifList.Items.Insert(0, new ListItem("***Please select***", "-1"));
          //      gradeList.Items.Insert(0, new ListItem("***Please select***", "-1"));

                // Loading Grade list
                ArrayList objGrade = new ArrayList();
                objGrade = (new GradeTableController()).List();
                if (objGrade.Count > 0)
                {
                    gradeList.DataSource = objGrade;
                    gradeList.DataTextField = "GradeName";
                    gradeList.DataValueField = "GradeID";
                    gradeList.DataBind();

                    gradeList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                }

            }
            if (IsPostBack) return;
            else
            {
                var days = new ArrayList();
                days.Add("*Day*");
                for (var i = 1; i <= 31; i++)
                {
                    days.Add(i);
                }
                leaveStartDayList.DataSource = days;
                leaveStartDayList.DataBind();

                LeaveEndDayList.DataSource = days;
                LeaveEndDayList.DataBind();
                
                var yrs = new ArrayList();
                yrs.Add("*Year*");
                for (var i = 2018; i >= 1900; i--)
                {
                    yrs.Add(i);
                }
                qualifStartYearList.DataSource = yrs;
                qualifStartYearList.DataBind();

                qualifEndYearList.DataSource = yrs;
                qualifEndYearList.DataBind();

                certYearList.DataSource = yrs;
                certYearList.DataBind();

                appraisalYearList.DataSource = yrs;
                appraisalYearList.DataBind();

                leaveStartYearList.DataSource = yrs;
                leaveStartYearList.DataBind();

                LeaveEndYearList.DataSource = yrs;
                LeaveEndYearList.DataBind();
                
            }


        }
        protected void homeBtn_Click(object sender, EventArgs e)
        {

            MViewEmployee.ActiveViewIndex = 0;

        }
        protected void welEmplomentBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 1;

            PanelEmployeeProfile.Visible = true;

            EmployeeDepartmentTableInfo objEmpDept = new EmployeeDepartmentTableInfo();
            int DeptID = CurrentEmployeeDetail.Department_FK;
            objEmpDept = (new EmployeeDepartmentTableController()).Get(DeptID);


            EmployeePositionTableInfo objEmpPosition = new EmployeePositionTableInfo();
            int PositionID = CurrentEmployeeDetail.PositionHeld_FK;
            objEmpPosition = (new EmployeePositionTableController()).Get(PositionID);


            EmployeeLevelTableInfo objEMpLevel = new EmployeeLevelTableInfo();
            int LevelID = CurrentEmployeeDetail.EmployeeLevel_FK;
            objEMpLevel = (new EmployeeLevelTableController()).Get(LevelID);

            EmployeeWorkLocationInfo objEmpWorkLoc = new EmployeeWorkLocationInfo();
            int WorkLocationID = CurrentEmployeeDetail.WorkLocation_FK;
            objEmpWorkLoc = (new EmployeeWorkLocationController()).Get(WorkLocationID);

            CountryTableInfo objEmpCountry = new CountryTableInfo();
            int CountryID = CurrentEmployeeDetail.Nationality_FK;
            objEmpCountry = (new CountryTableController()).Get(CountryID);

            StateTableInfo objEmpState = new StateTableInfo();
            int StateID = CurrentEmployeeDetail.StateOfOrigin_FK;
            objEmpState = (new StateTableController()).Get(StateID);

            LGATableInfo objEmpLGA = new LGATableInfo();
            int LgaID = CurrentEmployeeDetail.LGA_FK;
            objEmpLGA = (new LGATableController()).Get(LgaID);

            UserInfo objEmpConfirmby = new UserInfo();
            int empConfirmID = CurrentEmployeeDetail.ConfirmedBy;
            objEmpConfirmby = (new UserController()).GetUser(0, empConfirmID);





            LbempTitle.Text = CurrentEmployeeDetail.Title;
            LbempFName.Text = CurrentEmployeeDetail.FirstName;
            LbempMName.Text = CurrentEmployeeDetail.MiiddleName;
            LbempLName.Text = CurrentEmployeeDetail.LastName;
            LbempMaritalStatus.Text = CurrentEmployeeDetail.MaritalStatus;
            LbempGender.Text = CurrentEmployeeDetail.Gender;
            LbempPhnNo.Text = CurrentEmployeeDetail.PhoneNo;
            LbempEmail.Text = CurrentEmployeeDetail.Email;
            LbempContAddres.Text = CurrentEmployeeDetail.ContactAddress;
            LbempDOB.Text = CurrentEmployeeDetail.DateOfBirth;
            LbempAge.Text = CurrentEmployeeDetail.Age;
            LbempGender.Text = CurrentEmployeeDetail.Gender;
            LbempReligion.Text = CurrentEmployeeDetail.Religion;
            LbempStartDate.Text = CurrentEmployeeDetail.StartDate;
        //    EmpProfilePassport.ImageUrl = "~/images/" + CurrentEmployeeDetail.Passport.Substring(CurrentEmployeeDetail.Passport.LastIndexOf('/') + 1);

            EmpProfilePassport.ImageUrl = "~/Image/" + CurrentEmployeeDetail.Passport.Substring(CurrentEmployeeDetail.Passport.LastIndexOf('/') + 1);


            LbempCountry.Text = objEmpCountry.CountryName;
            LbempState.Text = objEmpState.StateName;
            LbempLga.Text = objEmpLGA.LgaName;

            LbempDepts.Text = objEmpDept.DeptName;
            LbempPosition.Text = objEmpPosition.PositionName;
            LbempLevel.Text = objEMpLevel.LevelName;
            LbempWorkLoc.Text = objEmpWorkLoc.LocationName + "," + " " + objEmpWorkLoc.LocationAddress;


            // Collecting Employee spouse details

            LbSpouseNames.Text = CurrentEmployeeDetail.SpouseNames;
            LbSpousePhoNo.Text = CurrentEmployeeDetail.SpousePhoneNo;
            LbSpouseAddress.Text = CurrentEmployeeDetail.SpouseAddress;
            LbSpouseEmailAddr.Text = CurrentEmployeeDetail.SpouseEmail;
            LbSpouseOccupation.Text = CurrentEmployeeDetail.SpouseOccupation;
            LbSpouseEmployer.Text = CurrentEmployeeDetail.SpouseEmployerNames;

            //Collecting Employee NextOfKin details

            LbNextOfKinNames.Text = CurrentEmployeeDetail.NxtOfKinLName + " " + CurrentEmployeeDetail.NxtOfKinMidName + " " + CurrentEmployeeDetail.NxtOfKinFName;
            LbNextOfKinRelationship.Text = CurrentEmployeeDetail.NxtOfKinRelationship;
            LbNextOfKinEmail.Text = CurrentEmployeeDetail.NxtOfKinEmail;
            LbNextOfKinAddress.Text = CurrentEmployeeDetail.NxtOfKinAddress;
            LbNextOfKinOccupation.Text = CurrentEmployeeDetail.NxtOfKinOccupation;
            LbNextOfKinPhnNo.Text = CurrentEmployeeDetail.NxtOfKinPhoneNo;

            //Collecting Employee status Info

            LbEmployeeStatus.Text = CurrentEmployeeDetail.EmployeeStatus;
            LbEmpConfimedDate.Text = CurrentEmployeeDetail.ConfirmationDate;
         //   LbEmpConfimedBy.Text = objEmpConfirmby.DisplayName;     comment out by biikis
               // Convert.ToString(CurrentEmployeeDetail.ConfirmedBy;

            //Collecting Employee Bank Info

            LbEmpBankNames.Text = CurrentEmployeeDetail.BankName;
            LbAccountName.Text = CurrentEmployeeDetail.AccountName;
            LbAcctNumber.Text = CurrentEmployeeDetail.AccountNo;
            LbGuarrantorName.Text = CurrentEmployeeDetail.GuarrantorNames;

            //Collecting Employee Referee Info
            LbRefNames1.Text = CurrentEmployeeDetail.Refree1Names;
            LbRefOccuptn1.Text = CurrentEmployeeDetail.Refree1Occupation;
            LbRefEmailAddr1.Text = CurrentEmployeeDetail.Refree1Email;
            LbRefPhoNo1.Text = CurrentEmployeeDetail.Refree1PhoneNum;
            LbRefContAddrss1.Text = CurrentEmployeeDetail.Refree1ContactAddr;


            LbRefNames2.Text = CurrentEmployeeDetail.Refree2Names;
            LbRefOccuptn2.Text = CurrentEmployeeDetail.Refree2Occupation;
            LbRefPhoNo2.Text = CurrentEmployeeDetail.Refree2PhoneNum;
            LbRefEmailAddr2.Text = CurrentEmployeeDetail.Refree2Email;
            LbRefContAddrss2.Text = CurrentEmployeeDetail.Refree2ContactAddr;

            //EmpProfileQualification

            //int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
            //   int empID_FK = CurrentEmployeeDetail.EmployeeID;
            //   int applicantID = CurrentEmployeeDetail.ApplicantID_FK;

            int empID_FK = CurrentEmployeeDetail.EmployeeID;

            ArrayList objProfileQaulifList = new ArrayList();

            objProfileQaulifList = (new EmployeeQualificationTableController()).ApprovedQualifGetByEmployeeDetails(empID_FK);

            if (objProfileQaulifList.Count > 0)
            {
                GViewEmpProfileQualification.Visible = true;
                GViewEmpProfileQualification.DataSource = objProfileQaulifList;
                GViewEmpProfileQualification.DataBind();

            }



            //int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
           
           // int applicantID = CurrentEmployeeDetail.ApplicantID_FK;
            ArrayList objProfileProfQaulifList = new ArrayList();
            objProfileProfQaulifList = (new EmployeeProfQualificationTableController()).ApprovedProfQualifGetByEmployeeDetails(empID_FK);

            if (objProfileProfQaulifList.Count > 0)
            {
                GViewEmpProfileCert.Visible = true;
                GViewEmpProfileCert.DataSource = objProfileProfQaulifList;
                GViewEmpProfileCert.DataBind();

            }


            ////int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
            //int empID_FK = CurrentEmployeeDetail.employeeID;
            //int applicantID = CurrentEmployeeDetail.ApplicantID_FK;

            ArrayList objProfileDocList = new ArrayList();
            objProfileDocList = (new EmployeeDocumentTableController()).ApprovedDocGetByEmployeeDetails(empID_FK);

            if (objProfileDocList.Count > 0)
            {

                GViewEmpProfileDoc.Visible = true;
                GViewEmpProfileDoc.DataSource = objProfileDocList;
                GViewEmpProfileDoc.DataBind();

            }

        }

         
        //EmpProfileQualification
      

        //EmployeeProfQualification
      


        //EmpProfile Documents
        
        protected void updateMenuBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 2;
        }
        protected void empQualifBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 7;


            // loading the employee qualification
            ArrayList objQaulifList = new ArrayList();
            int empID = CurrentEmployeeDetail.EmployeeID;
            objQaulifList = (new EmployeeQualificationTableController()).ApprovedQualifGetByEmployeeDetails(empID);

            if (objQaulifList.Count > 0)
            {
                GViewQualification.Visible = true;
                GViewQualification.DataSource = objQaulifList;
                GViewQualification.DataBind();

            }
        }
        protected void empCertBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 8;
            ArrayList objProfCertList = new ArrayList();
            int empID = CurrentEmployeeDetail.EmployeeID;
            objProfCertList = (new EmployeeProfQualificationTableController()).ApprovedProfQualifGetByEmployeeDetails(empID);

            if (objProfCertList.Count > 0)
            {
                GViewCert.Visible = true;
                GViewCert.DataSource = objProfCertList;
                GViewCert.DataBind();

            }
        }

        protected void docBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 9;
            ArrayList objDocList = new ArrayList();
            int empID = CurrentEmployeeDetail.EmployeeID;
            objDocList = (new EmployeeDocumentTableController()).ApprovedDocGetByEmployeeDetails(empID);

            if (objDocList.Count > 0)
            {
                GViewDoc.Visible = true;
                GViewDoc.DataSource = objDocList;
                GViewDoc.DataBind();

            }
        }

        protected void refreeBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 5;
        }

        protected void respondBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 10;
            PanelQueryDetails.Visible = false;
            PanelDiscipline.Visible = false;

            ArrayList objQuery = new ArrayList();
            int empID = CurrentEmployeeDetail.EmployeeID;
            objQuery = (new EmployeeQueryTableController()).GetByEmployeeDetails(empID);
            if (objQuery.Count > 0)
            {
                lblQueryReport.Visible = false;
                GVQuery.DataSource = objQuery;
                GVQuery.DataBind();
                GVQuery.Visible = true;
            }
            else
            {
                GVQuery.Visible = false;
                lblQueryReport.Text = "You don't have any query for now";
                lblQueryReport.Visible = true;

            }
        }

        protected void leaveBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 11;
           
            //Loading leave types
            ArrayList objLeave = new ArrayList();
            objLeave = (new EmployeeTypeOfLeaveTableController()).List();
            if (objLeave.Count > 0)
            {
                leaveTypeList.DataSource = objLeave;
                leaveTypeList.DataValueField = "LeaveTypeID";
                leaveTypeList.DataTextField = "LeaveTypeName";
                leaveTypeList.DataBind();
               leaveTypeList.Items.Insert(0, new ListItem("---Please Select---", "-1"));
            }


            // number of leave an employee is entitle depend on his level
            // get the levelId of the current employee
            // then use it to get his leave entitle from the level table
            EmployeeLevelTableInfo objLevel = new EmployeeLevelTableInfo();
            objLevel = (new EmployeeLevelTableController()).Get(CurrentEmployeeDetail.EmployeeLevel_FK);
            lblLeave.Text = objLevel.LeaveEntitle;
            lblLeaveApplyDate.Text = DateTime.Now.ToString();
        }
        protected void selfAppraisalBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 12;
        }

        protected void appraisalBackBtn_Click(object sender, EventArgs e)
        {
        }
        protected void appraisalHomeBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 0;
        }


        protected void EmpHome_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 0;
        }
        protected void EmpBioDataLinkBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 1;
        }
        protected void EmpQualifLinkBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 2;
        }
        protected void EmpCertifLinkBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 3;
        }


        protected void docLinkBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 4;
        }
        protected void EmpRefreeLinkBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 5;
        }
        protected void EmpQueryLinkBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 6;
        }
        protected void EmpAppraisalLinkBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 7;
        }



        protected void docViewBtn_Click(object sender, EventArgs e)
        {
            GViewEmpDoc.Visible = true;
        }


        protected void spouceLinkBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 2;
        }
        protected void NextofKinLinkBtn_Click(object sender, EventArgs e)
        {

            MViewEmployee.ActiveViewIndex = 3;
        }
        protected void BankLinkBtn_Click(object sender, EventArgs e)
        {

            MViewEmployee.ActiveViewIndex = 4;
        }
        protected void guarrantorLinkBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 6;
        }

        // from mrs ola
        //protected void qualifList_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //loading Grade

        //    ArrayList objGrade = new ArrayList();
        //  //  int qualifid = Convert.ToInt32(qualifList.SelectedValue);
        //  //  objGrade = (new GradeTableController()).GetByQualifications(qualifid);
        //    //  objGrade = (new GradeTableController()).GetByQualifications(qualifid);
        //    if (objGrade.Count > 0)
        //    {
        //        gradeList.DataSource = objGrade;
        //        gradeList.DataTextField = "gradeName";
        //        gradeList.DataValueField = "gradeID";
        //        gradeList.DataBind();
        //    }
        //    // gradeList.Items.Insert(0, new ListItem("***Please select", "-1"));
        //}


        //protected void leaveStartDayCalenderImageBtn_Click(object sender, ImageClickEventArgs e)
        //{
        //    leaveStartDateCalender.Visible = true;
        //    txtLeaveStartDate.Text = leaveStartDateCalender.SelectedDate.ToShortDateString();
        //}
        //protected void leaveEndDayCalenderImageBtn_Click(object sender, ImageClickEventArgs e)
        //{
        //    leaveEndDateCalender.Visible = true;
        //    txtLeaveEndDate.Text = leaveEndDateCalender.SelectedDate.ToShortDateString();


        //}




        protected void spouseSaveBtn_Click(object sender, EventArgs e)
        {

            EmployeeDetailsInfo objEmpSpouse = new EmployeeDetailsInfo();

            int employeeID = CurrentEmployeeDetail.EmployeeID;
            int empUser = CurrentEmployeeDetail.EmployeeUserID_FK;
            objEmpSpouse.EmployeeID = employeeID;
            objEmpSpouse.EmployeeUserID_FK = empUser;
            objEmpSpouse.SpouseNames = this.txtSpouceLN.Text + " " + txtSpouseMN0.Text + " " + txtSpouseFN.Text.Trim();
            objEmpSpouse.SpousePhoneNo = this.txtSpoucePhnNum.Text.Trim();
            objEmpSpouse.SpouseEmail = this.txtSpouceEmail.Text.Trim();
            objEmpSpouse.SpouseAddress = this.txtSpouceContAddress.Text.Trim();
            objEmpSpouse.SpouseOccupation = this.txtSpouceOccupation.Text.Trim();
            objEmpSpouse.SpouseEmployerNames = this.txtSpouceEmployer.Text.Trim();

            CurrentEmployeeDetail2(objEmpSpouse);

            if (objEmpSpouse.EmployeeID == employeeID)
            {
                lbEmpSpouseAdded.Visible = true;
                lbEmpSpouseAdded.Text = " Detial Successfully updated";
                refereshPage();
            }
            else
            {
                lbEmpSpouseAdded.Text = " Error! Details not updated.";
            }

        }
        protected void nextOfKinSaveBtn_Click(object sender, EventArgs e)
        {

            EmployeeDetailsInfo objEmpNOK = new EmployeeDetailsInfo();

            int employeeID = CurrentEmployeeDetail.EmployeeID;
            int empUser = CurrentEmployeeDetail.EmployeeUserID_FK;
            objEmpNOK.EmployeeID = employeeID;
            objEmpNOK.EmployeeUserID_FK = empUser;

            objEmpNOK.NxtOfKinFName = this.txtNxtOfKinfName.Text.Trim();
            objEmpNOK.NxtOfKinMidName = this.txtNxtOfKinMidName.Text.Trim();
            objEmpNOK.NxtOfKinLName = this.txtNxtOfKinLName.Text.Trim();
            objEmpNOK.NxtOfKinPhoneNo = this.txtNxtOfKinPhNo.Text.Trim();
            objEmpNOK.NxtOfKinEmail = this.txtNxtOfKinEmail.Text.Trim();
            objEmpNOK.NxtOfKinOccupation = this.txtNxtOfKinOccupation.Text.Trim();
            objEmpNOK.NxtOfKinAddress = this.txtNxtOfKinContAdd.InnerText.Trim();
            objEmpNOK.NxtOfKinRelationship = this.txtNxtOfKinRelationship.Text.Trim();

            CurrentEmployeeDetailNOK(objEmpNOK);

            if (objEmpNOK.EmployeeID == employeeID)
            {
                lbEmpNxtOfKinAdded.Visible = true;
                lbEmpNxtOfKinAdded.Text = " Detial Successfully updated";
                refereshPage();
            }
            else
            {
                lbEmpNxtOfKinAdded.Text = " Error! Details not updated.";
            }



        }

        private void refereshPage()
        {
            this.txtSpouseFN.Text = "";
            this.txtSpouceLN.Text = "";
            this.txtSpouseMN0.Text = "";
            this.txtSpouceOccupation.Text = "";
            this.txtSpoucePhnNum.Text = "";
            this.txtSpouceEmployer.Text = "";
            this.txtSpouceContAddress.Text = "";


            this.txtNxtOfKinfName.Text = "";
            this.txtNxtOfKinMidName.Text = "";
            this.txtNxtOfKinLName.Text = "";
            this.txtNxtOfKinOccupation.Text = "";
            this.txtNxtOfKinRelationship.Text = "";
            this.txtNxtOfKinPhNo.Text = "";
            this.txtNxtOfKinEmail.Text = "";
            this.txtNxtOfKinContAdd.InnerText = "";

            this.txtAcctNum.Text = "";
            this.txtBnkName.Text = "";
            this.txtAcctName.Text = "";

            this.txtRefFName1.Text = "";
            this.txtRefMidName1.Text = "";
            this.txtRefLName1.Text = "";
            this.txtRefPhnNo1.Text = "";
            this.txtRefOccupation2.Text = "";
            this.txtRefEmail1.Text = "";
            this.txtRefContAddr1.InnerText = "";

            this.txtRefFName2.Text = "";
            this.txtRefMidName2.Text = "";
            this.txtRefLName2.Text = "";
            this.txtRefPhnNo2.Text = "";
            this.txtRefOccupation2.Text = "";
            this.txtRefEmail2.Text = "";
            this.txtRefContAddr2.InnerText = "";


        }

        //Adding Bank details
        protected void bankSaveBtn_Click(object sender, EventArgs e)
        {
            EmployeeDetailsInfo objEmpBankInfo = new EmployeeDetailsInfo();

            int employeeID = CurrentEmployeeDetail.EmployeeID;
            int empUser = CurrentEmployeeDetail.EmployeeUserID_FK;
            objEmpBankInfo.EmployeeID = employeeID;
            objEmpBankInfo.EmployeeUserID_FK = empUser;

            objEmpBankInfo.BankName = this.txtBnkName.Text.Trim();
            objEmpBankInfo.AccountName = this.txtAcctName.Text.Trim();
            objEmpBankInfo.AccountNo = this.txtAcctNum.Text.Trim();

            CurrentEmployeeDetailBankInfo(objEmpBankInfo);


            if (objEmpBankInfo.EmployeeID == employeeID)
            {
                lbEmpBankInfoAdded.Visible = true;
                lbEmpBankInfoAdded.Text = " Detial Successfully updated";
                refereshPage();
            }
            else
            {
                lbEmpBankInfoAdded.Text = " Error! Details not updated.";
            }

        }
        protected void refSaveBtn_Click(object sender, EventArgs e)
        {


            EmployeeDetailsInfo objEmpRefree = new EmployeeDetailsInfo();

            int employeeID = CurrentEmployeeDetail.EmployeeID;
            int empUser = CurrentEmployeeDetail.EmployeeUserID_FK;
            objEmpRefree.EmployeeID = employeeID;
            objEmpRefree.EmployeeUserID_FK = empUser;

            objEmpRefree.Refree1Names = this.txtRefFName1.Text + " " + txtRefMidName1.Text + " " + txtRefLName1.Text.Trim();
            objEmpRefree.Refree1Email = this.txtRefEmail1.Text.Trim();
            objEmpRefree.Refree1Occupation = this.txtRefOccupation1.Text.Trim();
            objEmpRefree.Refree1PhoneNum = this.txtRefPhnNo1.Text.Trim();
            objEmpRefree.Refree1ContactAddr = this.txtRefContAddr1.InnerText.Trim();


            objEmpRefree.Refree2Names = this.txtRefFName2.Text + " " + txtRefMidName2.Text + " " + txtRefLName2.Text.Trim();
            objEmpRefree.Refree2Email = this.txtRefEmail2.Text.Trim();
            objEmpRefree.Refree2Occupation = this.txtRefOccupation2.Text.Trim();
            objEmpRefree.Refree2PhoneNum = this.txtRefPhnNo2.Text.Trim();
            objEmpRefree.Refree2ContactAddr = this.txtRefContAddr2.InnerText.Trim();

            CurrentEmployeeDetailReferee(objEmpRefree);

            if (objEmpRefree.EmployeeID == employeeID)
            {
                lbEmpRefereeAdded.Visible = true;
                lbEmpRefereeAdded.Text = " Detial Successfully updated";
                refereshPage();
            }
            else
            {
                lbEmpRefereeAdded.Text = " Error! Details not updated.";
            }

        }


        //Adding Guarrantor details

        #region
        protected void guarantorSaveBtn_Click(object sender, EventArgs e)
        {
            if (GuarrantorFileUpload.HasFile)
            {
                string DocName = GuarrantorFileUpload.FileName.ToString();
                string folder = "~/GuarantorForms/";
                string DocPath = HttpContext.Current.Server.MapPath(folder).ToString();

                ViewState.Add("DocName", DocName);

                GuarrantorFileUpload.SaveAs(DocPath + "\\" + DocName);

                EmployeeDetailsInfo objEmpGuarrantor = new EmployeeDetailsInfo();

                int employeeID = CurrentEmployeeDetail.EmployeeID;
                int empUser = CurrentEmployeeDetail.EmployeeUserID_FK;
                objEmpGuarrantor.EmployeeID = employeeID;
                objEmpGuarrantor.EmployeeUserID_FK = empUser;

                objEmpGuarrantor.GuarrantorNames = txtGuarName.Text.Trim();
                objEmpGuarrantor.GuarrantorFormPath = (DocPath + "\\" + DocName);

                CurrentEmployeeDetailGuarrantor(objEmpGuarrantor);

                if (objEmpGuarrantor.EmployeeID == employeeID)
                {
                    lbEmpGuarrantorAdded.Visible = true;
                    lbEmpGuarrantorAdded.Text = " Detial Successfully updated";
                    refereshPage();
                }
                else
                {
                    lbEmpGuarrantorAdded.Text = " Error! Details not updated.";
                }

            }
        }
        #endregion


        #region
        //Employee Qualification
        protected void qulifViewBtn_Click(object sender, EventArgs e)
        {
            qulifVSaveBtn.Visible = true;
            int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
            int empID = CurrentEmployeeDetail.EmployeeID;
            int applicantID = CurrentEmployeeDetail.ApplicantID_FK;
            ArrayList objQaulifList = new ArrayList();
            objQaulifList = (new ApplicantQualificationController()).GetByApplicantPersonalDetails(applicantID);

            if (objQaulifList.Count > 0)
            {
                GViewQualification.Visible = true;
                GViewQualification.DataSource = objQaulifList;
                GViewQualification.DataBind();

            }

        }

        //Saving qualifications into EmployeeTable

        protected void qulifVSaveBtn_Click(object sender, EventArgs e)
        {

            ArrayList ObjArr = new ArrayList();
            foreach (GridViewRow g1 in GViewQualification.Rows)
            {

                int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
                int empid = CurrentEmployeeDetail.EmployeeID;
                // int appid = CurrentEmployeeDetail.ApplicantID_FK;

                TextBox b = new TextBox();
                // find the textbox containing the applicantID on the gridview 
                b = (TextBox)g1.FindControl("txtQualifViewAppID");
                string appid = b.Text;


                EmployeeQualificationTableInfo objEmpQualif = new EmployeeQualificationTableInfo();

                objEmpQualif.InstitutionName = g1.Cells[0].Text;
                objEmpQualif.QualificationType = g1.Cells[1].Text;
                objEmpQualif.Course = g1.Cells[2].Text;
                objEmpQualif.Grade = g1.Cells[3].Text;
                objEmpQualif.StartYear = g1.Cells[4].Text;
                objEmpQualif.EndYear = g1.Cells[5].Text;
                objEmpQualif.ApplicantID_FK = Convert.ToInt32(appid);
                int empQualificationID = (new EmployeeQualificationTableController()).Add(objEmpQualif);


                EmployeeQualificationTableInfo objQualifEmpID = new EmployeeQualificationTableInfo();
                int empUser = CurrentEmployeeDetail.EmployeeUserID_FK;
                objQualifEmpID.ApplicantID_FK = Convert.ToInt32(appid);
                objQualifEmpID.EmployeeID_FK = CurrentEmployeeDetail.EmployeeID;
                (new EmployeeQualificationTableController()).QualificationTableEmpIDUpdate(objQualifEmpID);

                if (objQualifEmpID.ApplicantID_FK == CurrentEmployeeDetail.ApplicantID_FK)
                {

                    lbEmpQualifAdded.Text = "Qualifications Added Successfully";
                }
                else
                {
                    lbEmpQualifAdded.Text = " Error! Qualification not added.";
                }
            }
        }

        protected void qulifAddMoreBtn_Click(object sender, EventArgs e)
        {
            PanelAddQualif.Visible = true;

            //ArrayList objQaulifList = new ArrayList();
            //int empID = CurrentEmployeeDetail.EmployeeID;
            //objQaulifList = (new EmployeeQualificationTableController()).GetByEmployeeDetails(empID);

            //if (objQaulifList.Count > 0)
            //{
            //    GViewAddQualification.Visible = true;
            //    GViewAddQualification.DataSource = objQaulifList;
            //    GViewAddQualification.DataBind();

            //}

        }
        //Addmore qaulification

        protected void empQulifAddBtn_Click(object sender, EventArgs e)
        {
            qulifViewSaveBtn.Visible = true;
            int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
            int empID = CurrentEmployeeDetail.EmployeeID;
            int applicantID = CurrentEmployeeDetail.ApplicantID_FK;

           // foreach (GridViewRow x in GViewAddQualification.Rows)
          //  {
                // declare a variable as textbox
           //     TextBox b = new TextBox();
             //   TextBox c = new TextBox();
                // find the textbox containing the applicantID on the gridview 
               // b = (TextBox)x.FindControl("txtQualifSaveAppID");
                //c = (TextBox)x.FindControl("txtQualifSaveEmpID");
                //string appid = b.Text;
                //string empid = c.Text;

           // }
                ArrayList ObjArr = new ArrayList();

                if (GViewAddQualification.Rows.Count > 0)
                {
                    for (int i = 0; i < GViewAddQualification.Rows.Count; i++)
                    {
                        EmployeeQualificationTableInfo objQualific = new EmployeeQualificationTableInfo();

                        objQualific.InstitutionName = GViewAddQualification.Rows[i].Cells[0].Text.ToString();
                        objQualific.QualificationType = GViewAddQualification.Rows[i].Cells[1].Text.ToString();
                        objQualific.Course = GViewAddQualification.Rows[i].Cells[2].Text.ToString();
                        objQualific.Grade = GViewAddQualification.Rows[i].Cells[3].Text.ToString();
                        objQualific.StartYear = GViewAddQualification.Rows[i].Cells[4].Text.ToString();
                        objQualific.EndYear = GViewAddQualification.Rows[i].Cells[5].Text.ToString();
                        objQualific.ApplicantID_FK = Convert.ToInt32(applicantID);
                        objQualific.EmployeeID_FK = Convert.ToInt32(empID);

                        ObjArr.Add(objQualific);


                    }
                }

                EmployeeQualificationTableInfo objQualific2 = new EmployeeQualificationTableInfo();
                objQualific2.InstitutionName = this.txtQualifSchName.Text.Trim();
                objQualific2.QualificationType = this.qualifList.SelectedItem.Text;
                objQualific2.Course = this.courseList.SelectedItem.Text.Trim();
                objQualific2.Grade = this.gradeList.SelectedItem.Text;
                objQualific2.StartYear = this.qualifStartYearList.SelectedItem.Text;
                objQualific2.EndYear = this.qualifEndYearList.SelectedItem.Text;
                objQualific2.ApplicantID_FK = Convert.ToInt32(applicantID);
                objQualific2.EmployeeID_FK = Convert.ToInt32(empID);
                ObjArr.Add(objQualific2);
                GViewAddQualification.DataSource = ObjArr;
                GViewAddQualification.DataBind();
                GViewAddQualification.Visible = true;
                txtQualifSchName.Text = "";
                courseList.ClearSelection();
                qualifList.ClearSelection();
                gradeList.ClearSelection();
                qualifStartYearList.ClearSelection();
                qualifEndYearList.ClearSelection();
                qulifVSaveBtn.Visible = true;

            
        }

        //Saving new qualifications into EmployeeTable
        protected void qulifViewSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {

                int empid = CurrentEmployeeDetail.EmployeeID;

               // ArrayList ObjArrQualific = new ArrayList();
                //ObjArrQualific = (new EmployeeQualificationTableController()).GetByEmployeeDetails(empid);
                //if (ObjArrQualific.Count > 0)
                  //  foreach (EmployeeQualificationTableInfo ObjQ in ObjArrQualific)
                    //{
                      //  empid = CurrentEmployeeDetail.EmployeeID;
                        //int appid = CurrentEmployeeDetail.ApplicantID_FK;
                        //int qualificationID = ObjQ.QualificationID;
                        //(new EmployeeQualificationTableController()).Delete(qualificationID);
                  //  }

                ArrayList ObjArr = new ArrayList();
                foreach (GridViewRow g1 in GViewAddQualification.Rows)
                {
                    int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
                    int app = CurrentEmployeeDetail.ApplicantID_FK;

                    // declare a variable as textbox

                    TextBox a = new TextBox();
                    TextBox b = new TextBox();
                    // find the textbox containing the applicantID on the gridview 
                    a = (TextBox)g1.FindControl("txtQualifSaveAppID");
                    b = (TextBox)g1.FindControl("txtQualifSaveEmpID");

                    string appid = a.Text;
                    string emd = b.Text;


                    EmployeeQualificationTableInfo objQualifInfo = new EmployeeQualificationTableInfo();
                    objQualifInfo.InstitutionName = g1.Cells[0].Text;
                    objQualifInfo.QualificationType = g1.Cells[1].Text;
                    objQualifInfo.Course = g1.Cells[2].Text;
                    objQualifInfo.Grade = g1.Cells[3].Text;
                    objQualifInfo.StartYear = g1.Cells[4].Text;
                    objQualifInfo.EndYear = g1.Cells[5].Text;
                    objQualifInfo.ApplicantID_FK = Convert.ToInt32(appid);
                    objQualifInfo.EmployeeID_FK = Convert.ToInt32(emd);

                    ObjArr.Add(objQualifInfo);
                    int qualiicationID = (new EmployeeQualificationTableController()).NewAdd(objQualifInfo);


                    if (qualiicationID > 0)
                    {
                        lbEmpQualificationAdded.Visible = true;

                        lbEmpQualificationAdded.Text = "New Qualifications Added Successfully";
                    }
                    else
                    {
                        lbEmpQualificationAdded.Visible = true;
                        lbEmpQualificationAdded.Text = " Error! Qualification not added.";
                    }
                }

            }
            catch
            {

            }
        }

        protected void GViewAddQualification_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {

                if (e.CommandName == "Delete")
                {

                    new EmployeeQualificationTableController().Delete(Convert.ToInt32(e.CommandArgument));

                    int Empnum = CurrentEmployeeDetail.EmployeeID;



                    ArrayList ObjArrQualification = new ArrayList();
                    ObjArrQualification = (new EmployeeQualificationTableController()).GetByEmployeeDetails(Empnum);

                    if (ObjArrQualification.Count != 0)
                    {

                        GViewAddQualification.DataSource = (ObjArrQualification);
                        GViewAddQualification.DataBind();
                        int count = 0;
                        count += 1;
                        GViewAddQualification.Visible = true;
                        lbEmpQualifiDeleted.Text = count + " " + "Qualification deleted";

                    }

                }
            }
            catch { }
        }
        #endregion

        // Loading certification from applicantProQualiftable

        #region

        protected void profCertViewBtn_Click(object sender, EventArgs e)
        {
            //profCertSaveBtn.Visible = true;
            //int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
            //int empID = CurrentEmployeeDetail.EmployeeID;
            //int applicantID = CurrentEmployeeDetail.ApplicantID_FK;
            //ArrayList objProfQaulifList = new ArrayList();
            //objProfQaulifList = (new ApplicantProfQualificationController()).GetByApplicantPersonalDetails(applicantID);

            //if (objProfQaulifList.Count > 0)
            //{
            //    GViewCert.Visible = true;
            //    GViewCert.DataSource = objProfQaulifList;
            //    GViewCert.DataBind();
            //}


            int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
            int empID = CurrentEmployeeDetail.EmployeeID;
            int applicantID = CurrentEmployeeDetail.ApplicantID_FK;
            profCertSaveBtn.Visible = true;

            ArrayList objProfQaulifList = new ArrayList();

            objProfQaulifList = (new ApplicantProfQualificationController()).GetByApplicantPersonalDetails(applicantID);

            if (objProfQaulifList.Count > 0)
            {

                GViewCert.Visible = true;
                GViewCert.DataSource = objProfQaulifList;
                GViewCert.DataBind();
            }
            //foreach (GridViewRow x in GViewCert.Rows)
            //{
            //    // declare a variable as textbox
            //    TextBox b = new TextBox();
            //    // find the textbox containing the applicantID on the gridview 
            //    b = (TextBox)x.FindControl("txtAppID");
            //    string appid = b.Text;
            //    // appid = x.Cells[4].Text;


            //}
        }


        //saving profQualif for the first time
        protected void profCertSaveBtn_Click(object sender, EventArgs e)
        {

            ArrayList ObjArr = new ArrayList();
            foreach (GridViewRow x in GViewCert.Rows)
            {

                int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
                // int appid = CurrentEmployeeDetail.ApplicantID_FK;


                // declare a variable as textbox
                TextBox b = new TextBox();
                // find the textbox containing the applicantID on the gridview 
                b = (TextBox)x.FindControl("txtCertAppID");
                string appid = b.Text;

                EmployeeProfQualificationTableInfo objEmpProfQualif = new EmployeeProfQualificationTableInfo();

                objEmpProfQualif.CertificationName = x.Cells[0].Text;
                objEmpProfQualif.CertificateNo = x.Cells[1].Text;
                objEmpProfQualif.Stage = x.Cells[2].Text;
                objEmpProfQualif.CertYear = x.Cells[3].Text;
                objEmpProfQualif.ApplicantID_FK = Convert.ToInt32(appid);
                //string appid= x.Cells[4].Text;

                int empProQualifID = (new EmployeeProfQualificationTableController()).Add(objEmpProfQualif);

                EmployeeProfQualificationTableInfo objProfQualifEmpID = new EmployeeProfQualificationTableInfo();
                int empUser = CurrentEmployeeDetail.EmployeeUserID_FK;
                //int profQualfID = objProfQualifEmpID.ProfQualificationID;
                int empAPPid = CurrentEmployeeDetail.ApplicantID_FK;
                objProfQualifEmpID.ApplicantID_FK = Convert.ToInt32(appid);
                //Convert.ToInt32(g1.Cells[4].Text);
                objProfQualifEmpID.employeeID_FK = CurrentEmployeeDetail.EmployeeID;
                (new EmployeeProfQualificationTableController()).ProfQualificationTableEmpIDUpdate(objProfQualifEmpID);

                if (objProfQualifEmpID.ApplicantID_FK == empAPPid)
                {
                    //lblQualificationMessage.Visible = true;
                    LbProfQualifAdded.Visible = true;
                    LbProfQualifAdded.Text = "Certification Added Successfully";
                }
                else
                {
                    LbProfQualifAdded.Visible = true;
                    LbProfQualifAdded.Text = " Error! Certification not added.";
                }
            }
        }

        protected void certAddMoreBtn_Click(object sender, EventArgs e)
        {
            PanelAddProfqualif.Visible = true;

            //ArrayList objProfCertList = new ArrayList();
            //int empID = CurrentEmployeeDetail.EmployeeID;
            //objProfCertList = (new EmployeeProfQualificationTableController()).GetByEmployeeDetails(empID);

            //if (objProfCertList.Count > 0)
            //{
            //    GViewEmpCert.Visible = true;
            //    GViewEmpCert.DataSource = objProfCertList;
            //    GViewEmpCert.DataBind();

            //}

        }
        protected void certAddBtn_Click(object sender, EventArgs e)
        {
            certSaveBtn.Visible = true;
            int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
            int empID = CurrentEmployeeDetail.EmployeeID;
            int applicantID = CurrentEmployeeDetail.ApplicantID_FK;

            //foreach (GridViewRow x in GViewEmpCert.Rows)
            //{
            //    // declare a variable as textbox
            //    TextBox b = new TextBox();
            //    TextBox c = new TextBox();
            //    // find the textbox containing the applicantID on the gridview 
            //    b = (TextBox)x.FindControl("txtCertSaveAppID");
            //    c = (TextBox)x.FindControl("txtCertSaveEmpID");
            //    string appid = b.Text;
            //    string empid = c.Text;
                // string appid = x.Cells[4].Text;
                // string empid = x.Cells[5].Text;

                ArrayList ObjArr = new ArrayList();

                if (GViewEmpCert.Rows.Count > 0)
                {
                    for (int i = 0; i < GViewEmpCert.Rows.Count; i++)
                    {
                        EmployeeProfQualificationTableInfo objProfQualific = new EmployeeProfQualificationTableInfo();

                        objProfQualific.CertificationName = GViewEmpCert.Rows[i].Cells[0].Text.ToString();
                        objProfQualific.CertificateNo = GViewEmpCert.Rows[i].Cells[1].Text.ToString();
                        objProfQualific.Stage = GViewEmpCert.Rows[i].Cells[2].Text.ToString();
                        objProfQualific.CertYear = GViewEmpCert.Rows[i].Cells[3].Text.ToString();
                        objProfQualific.ApplicantID_FK = Convert.ToInt32(applicantID);
                        objProfQualific.employeeID_FK = Convert.ToInt32(empID);
                        //objProfQualific.ApplicantID_FK = Convert.ToInt32(GViewEmpCert.Rows[i].Cells[4].Text);
                        //objProfQualific.employeeID_FK = Convert.ToInt32(GViewEmpCert.Rows[i].Cells[5].Text);
                        ObjArr.Add(objProfQualific);
                    }
                }

                EmployeeProfQualificationTableInfo objProfQualific2 = new EmployeeProfQualificationTableInfo();

                objProfQualific2.CertificationName = this.txtCertName.Text.Trim();
                objProfQualific2.CertificateNo = this.txtCertNum.Text.Trim();
                objProfQualific2.Stage = this.certStageList.SelectedItem.Text;
                objProfQualific2.CertYear = this.certYearList.SelectedItem.Text;
                objProfQualific2.ApplicantID_FK = Convert.ToInt32(applicantID);
                objProfQualific2.employeeID_FK = Convert.ToInt32(empID);
                ObjArr.Add(objProfQualific2);

                GViewEmpCert.DataSource = ObjArr;
                GViewEmpCert.DataBind();
                GViewEmpCert.Visible = true;
                txtCertName.Text = "";
                txtCertNum.Text = "";
                certStageList.ClearSelection();
                certYearList.ClearSelection();
                certSaveBtn.Visible = true;
            }
        //}

        protected void certSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {

                int empid = CurrentEmployeeDetail.EmployeeID;

                ArrayList ObjArrProfQualific = new ArrayList();
                //ObjArrProfQualific = (new EmployeeProfQualificationTableController()).GetByEmployeeDetails(empid);
                //if (ObjArrProfQualific.Count > 0)
                //    foreach (EmployeeProfQualificationTableInfo ObjQ in ObjArrProfQualific)
                //    {
                //        empid = CurrentEmployeeDetail.EmployeeID;
                //        int appid = CurrentEmployeeDetail.ApplicantID_FK;
                //        int profQualificationID = ObjQ.ProfQualificationID;
                //        (new EmployeeProfQualificationTableController()).Delete(profQualificationID);
                //    }

                ArrayList ObjArr = new ArrayList();
                foreach (GridViewRow g1 in GViewEmpCert.Rows)
                {
                    int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
                    // int appid = CurrentEmployeeDetail.ApplicantID_FK;

                    // declare a variable as textbox
                    TextBox a = new TextBox();
                    TextBox b = new TextBox();
                    // find the textbox containing the applicantID on the gridview 
                    a = (TextBox)g1.FindControl("txtCertSaveAppID");
                    b = (TextBox)g1.FindControl("txtCertSaveEmpID");

                    string appid = a.Text;
                    string emd = b.Text;
                    empid = CurrentEmployeeDetail.EmployeeID;
                    // int appid = CurrentEmployeeDetail.ApplicantID_FK;

                    EmployeeProfQualificationTableInfo objProQualifInfo = new EmployeeProfQualificationTableInfo();
                    objProQualifInfo.CertificationName = g1.Cells[0].Text;
                    objProQualifInfo.CertificateNo = g1.Cells[1].Text;
                    objProQualifInfo.Stage = g1.Cells[2].Text;
                    objProQualifInfo.CertYear = g1.Cells[3].Text;
                    objProQualifInfo.ApplicantID_FK = Convert.ToInt32(appid);
                    objProQualifInfo.employeeID_FK = Convert.ToInt32(emd);

                    ObjArr.Add(objProQualifInfo);
                    int profQualiicationID = (new EmployeeProfQualificationTableController()).NewAdd(objProQualifInfo);


                    if (profQualiicationID > 0)
                    {
                        LbProfQualifSave.Visible = true;
                        LbProfQualifSave.Text = "New Professional Qualifications Added Successfully";
                    }
                    else
                    {
                        LbProfQualifSave.Visible = true;
                        LbProfQualifSave.Text = " Error! Professional Qualification not added.";
                    }
                }

            }
            catch
            {

            }
        }


        protected void GViewEmpCert_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {

                new EmployeeDocumentTableController().Delete(Convert.ToInt32(e.CommandArgument));

                int Empnum = CurrentEmployeeDetail.EmployeeID;


                ArrayList ObjArrQualification = new ArrayList();
                ObjArrQualification = (new EmployeeProfQualificationTableController()).GetByEmployeeDetails(Empnum);

                if (ObjArrQualification.Count != 0)
                {
                    GViewEmpCert.DataSource = (ObjArrQualification);
                    GViewEmpCert.DataBind();
                int  count = 0;
                count += 1;

                lbEmpProfQualifiDeleted.Text = "You have deleted" + count + "ProfQualification(s)";
                lbEmpProfQualifiDeleted.Visible = true;

                }
            }
        }


        #endregion


        //Employee Document section

        #region
        protected void docViewSaveBtn_Click(object sender, EventArgs e)
        {
            // Loading documents from applicantDocumentTable

            int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
            int empID = CurrentEmployeeDetail.EmployeeID;
            int applicantID = CurrentEmployeeDetail.ApplicantID_FK;
            ArrayList objDocList = new ArrayList();
            objDocList = (new ApplicantDocumentController()).GetByApplicantPersonalDetails(applicantID);

            if (objDocList.Count > 0)
            {

                GViewDoc.Visible = true;
                GViewDoc.DataSource = objDocList;
                GViewDoc.DataBind();
                docVSaveBtn.Visible = true;
            }

        }
        //saving document for the first time
        protected void docVSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //  ArrayList ObjArr = new ArrayList();
                foreach (GridViewRow g1 in GViewDoc.Rows)
                {

                    int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;


                    // declare a variable as textbox
                    TextBox b = new TextBox();
                    // find the textbox containing the applicantID on the gridview 
                    b = (TextBox)g1.FindControl("txtdocAppID");
                    string appid = b.Text;


                    EmployeeDocumentTableInfo objEmpDoc = new EmployeeDocumentTableInfo();
                    objEmpDoc.DocumentType = g1.Cells[0].Text;
                    objEmpDoc.DocumentPath = g1.Cells[1].Text;
                    objEmpDoc.ApplicantID_FK = Convert.ToInt32(appid);
                    int empDocID = (new EmployeeDocumentTableController()).Add(objEmpDoc);

                    EmployeeDocumentTableInfo objDocEmpID = new EmployeeDocumentTableInfo();
                    int empUser = CurrentEmployeeDetail.EmployeeUserID_FK;
                    //int profQualfID = objProfQualifEmpID.ProfQualificationID;
                    int app = CurrentEmployeeDetail.ApplicantID_FK;
                    objDocEmpID.ApplicantID_FK = Convert.ToInt32(appid);
                    objDocEmpID.EmployeeID_Fk = CurrentEmployeeDetail.EmployeeID;
                    (new EmployeeDocumentTableController()).DocumentTableEmpIDUpdate(objDocEmpID);

                    if (objDocEmpID.ApplicantID_FK == app)
                    {
                        
                        LbProfQualifAdded.Visible = true;
                        LbProfQualifAdded.Text =  "Documents Added Successfully";
                    }
                    else
                    {
                        LbProfQualifAdded.Text = " Error! Document not added.";
                    }

                }
            }
            catch
            {

            }
        }

        protected void docAddMoreBtn_Click(object sender, EventArgs e)
        {

            PanelAddMoreDocument.Visible = true;

            //ArrayList objDocList = new ArrayList();
            //int empID = CurrentEmployeeDetail.EmployeeID;
            //objDocList = (new EmployeeDocumentTableController()).GetByEmployeeDetails(empID);

            //if (objDocList.Count > 0)
            //{
            //    GViewEmpDoc.Visible = true;
            //    GViewEmpDoc.DataSource = objDocList;
            //    GViewEmpDoc.DataBind();

            //}
        }

        //Add new document
        protected void docAddBtn_Click(object sender, EventArgs e)
        {
            string DocName = docFileUpload.FileName.ToString();
            string folder = "~/UploadedDocuments/";
            string DocPath = HttpContext.Current.Server.MapPath(folder).ToString();
            docFileUpload.SaveAs(DocPath + "/" + DocName);
            int empID = CurrentEmployeeDetail.EmployeeID;

            int applicantID = CurrentEmployeeDetail.ApplicantID_FK;



            //foreach (GridViewRow x in GViewEmpDoc.Rows)
            //{
            //    // declare a variable as textbox
            //    TextBox b = new TextBox();
            //    TextBox c = new TextBox();
            //    // find the textbox containing the applicantID on the gridview 
            //    b = (TextBox)x.FindControl("txtDocuAppID");
            //    c = (TextBox)x.FindControl("txtDocuEmpID");
            //    string appid = b.Text;
            //    string empid = c.Text;


                ArrayList objArr = new ArrayList();
                if (GViewEmpDoc.Rows.Count > 0)
                {
                    for (int i = 0; i < GViewEmpDoc.Rows.Count; i++)
                    {

                        EmployeeDocumentTableInfo objDoc = new EmployeeDocumentTableInfo();
                        objDoc.DocumentType = GViewEmpDoc.Rows[i].Cells[0].Text.ToString();
                        objDoc.DocumentPath = GViewEmpDoc.Rows[i].Cells[1].Text.ToString();
                        objDoc.ApplicantID_FK = Convert.ToInt32(applicantID);
                        objDoc.EmployeeID_Fk = Convert.ToInt32(empID);
                        objArr.Add(objDoc);
                    }
                }
                EmployeeDocumentTableInfo objDoc2 = new EmployeeDocumentTableInfo();
                objDoc2.DocumentType = ddlDocumentTpe.SelectedItem.Text;
                objDoc2.DocumentPath = (DocPath + "\\" + DocName);
                objDoc2.ApplicantID_FK = Convert.ToInt32(applicantID);
                objDoc2.EmployeeID_Fk = Convert.ToInt32(empID);
                objArr.Add(objDoc2);
                GViewEmpDoc.DataSource = objArr;
                GViewEmpDoc.DataBind();
                GViewEmpDoc.Visible = true;
                LbDocSave.Visible = true;

            }
        //}


        protected void docSaveBtn_Click(object sender, EventArgs e)
        {

            try
            {
                int applicantID = CurrentEmployeeDetail.ApplicantID_FK;


                ArrayList objDocArr = new ArrayList();
                objDocArr = (new EmployeeDocumentTableController()).GetByEmployeeDetails(applicantID);

                if (objDocArr.Count > 0)
                    foreach (EmployeeDocumentTableInfo Obj in objDocArr)
                    {

                        int docID = Obj.DocumentID;
                        (new EmployeeDocumentTableController()).Delete(docID);
                    }

                ArrayList ObjArr = new ArrayList();

                foreach (GridViewRow g1 in GViewEmpDoc.Rows)
                {
                    // declare a variable as textbox
                    TextBox a = new TextBox();
                    TextBox b = new TextBox();
                    // find the textbox containing the applicantID on the gridview 
                    a = (TextBox)g1.FindControl("txtDocuAppID");
                    b = (TextBox)g1.FindControl("txtDocuEmpID");

                    string appid = a.Text;
                    string emd = b.Text;

                    EmployeeDocumentTableInfo objDocInfo = new EmployeeDocumentTableInfo();


                    objDocInfo.DocumentType = g1.Cells[0].Text;
                    objDocInfo.DocumentPath = g1.Cells[1].Text;
                    objDocInfo.ApplicantID_FK = Convert.ToInt32(appid);
                    objDocInfo.EmployeeID_Fk = Convert.ToInt32(emd);
                    // ObjArr.Add(objDocInfo);
                    int DocID = (new EmployeeDocumentTableController()).NewAdd(objDocInfo);
                    if (DocID > 0)
                    {
                      int count = 0;
                      count += 1;
                        LbDocumentSave.Visible = true;
                        LbDocumentSave.Text = count +" " +"Document(s) uploaded  successfully";
                    }
                    else
                    {
                        LbDocumentSave.Visible = true;
                        LbDocumentSave.Text = "Error! Documents not uploaded";
                    }
                }
            }
            catch { }
        }



        //protected void GViewDoc_RowCommand(object sender, GridViewCommandEventArgs e)
        //{

        //    if (e.CommandName == "Delete")
        //    {

        //        new EmployeeDocumentTableController().Delete(Convert.ToInt32(e.CommandArgument));

        //        int Empnum = CurrentEmployeeDetail.EmployeeID;


        //        ArrayList ObjArrQualification = new ArrayList();
        //        ObjArrQualification = (new EmployeeDocumentTableController()).GetByEmployeeDetails(Empnum);
        //        if (ObjArrQualification.Count != 0)
        //        {
        //            GViewDoc.DataSource = (ObjArrQualification);
        //            GViewDoc.DataBind();

        //        }



        //    }
        //}
        protected void GViewEmpDoc_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                //Alert.Show("You are about deleting a document! Note: This cannot be retrieved after deletion");

                new EmployeeDocumentTableController().Delete(Convert.ToInt32(e.CommandArgument));

                int Empnum = CurrentEmployeeDetail.EmployeeID;


                ArrayList ObjArrQualification = new ArrayList();
                ObjArrQualification = (new EmployeeDocumentTableController()).GetByEmployeeDetails(Empnum);
                if (ObjArrQualification.Count != 0)
                {
                    GViewDoc.DataSource = (ObjArrQualification);
                    GViewDoc.DataBind();
                    int count = 0;
                    count += 1;

                    lbEmpDocDeleted.Text = "You have deleted" + count + "Document(s)";
                    lbEmpDocDeleted.Visible = true;

                }
              //  Alert.Show("You save successfully Deleted the Document");

                //Alert.Show("You save successfully applied for the post of " + lblPositionAppliedFor.Text + " your application number is: " + lblApplicantNum.Text);
           
                //string msg = "You are inserting duplicate values  ";
                //msg += ex.Message;
                //Alert.Show(msg);
                //// Alert.Show("You are inserting duplicate values");
            }
        }
        #endregion


        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Reply")
            {

                EmployeeQueryTableInfo objQuery = new EmployeeQueryTableInfo();
                objQuery = (new EmployeeQueryTableController()).Get(Convert.ToInt32(e.CommandArgument));
                lblQueryEmployeeNum.Text = objQuery.EmployeeNum.ToString();
                lblQueryTitle.Text = objQuery.QueryTitle;
                lblQueryDescription.Text = objQuery.Description;
                lblQueryDate.Text = objQuery.IssueDate;
                lblQueryBy.Text = objQuery.QueryIssueByName.ToString();
                lblQueryletter.Text = objQuery.QueryLetter;
                lblQueryResponsedate.Text = DateTime.Now.ToString();
                string res=objQuery.EmployeeResponse;
                string dis=objQuery.DisciplineDetails;
                if (res.Length < 1 && dis.Length < 1 )
                {
                    //lblResponseDate.Visible = false;
                    //lblResponseDetails.Visible = false;
                    //lblResponseDateText.Visible = false;
                    //lblResponseText.Visible = false;
                    
                    PanelResponse.Visible = true;
                }
                else
                {
                    //lblResponseText.Visible = true;
                    //lblResponseDetails.Text = objQuery.EmployeeResponse;
                    //lblResponseDetails.Visible = true;
                    //lblResponseDateText.Visible = true;
                    //lblResponseDate.Text = objQuery.ResponseDate;
                    //lblResponseDate.Visible = true;
                    //PanelResponse.Visible = false;
                    PanelResponse.Visible = false;
                    lblResponseDetails.Text = objQuery.EmployeeResponse;
                    lblResponseDate.Text = objQuery.ResponseDate;
                    lblDisDetails.Text = objQuery.DisciplineDetails;
                    lblDisDate.Text = objQuery.DisciplineDate;
                    if (dis.Length > 1)
                    {
                        lblDisBy.Text = objQuery.QueryIssueByName.ToString();
                    }
                    
                    PanelDiscipline.Visible = true;
                }
                int queryId = objQuery.QueryID;
                ViewState.Add("queryId", queryId);
                PanelQueryDetails.Visible = true;
               
             }
        }
        protected void btnSendQueryResponse_Click(object sender, EventArgs e)
        {
            int QueryID = Convert.ToInt32(ViewState["queryId"]);
           EmployeeQueryTableInfo objQuery = new EmployeeQueryTableInfo();
            objQuery = (new EmployeeQueryTableController()).Get(QueryID);
           
            EmployeeQueryTableInfo objQueryResponse = new EmployeeQueryTableInfo();
            objQueryResponse.QueryID = QueryID;
            objQueryResponse.EmployeeResponse = txtQueryResponse.Text;
            objQueryResponse.ResponseDate = lblQueryResponsedate.Text;
            if (QueryResponseUpload1.HasFile)
            {
                 string filepath = HttpContext.Current.Server.MapPath("~/QueryLetters/").ToString();
                 QueryResponseUpload1.SaveAs(filepath + "\\" + QueryResponseUpload1.FileName.ToString());
                 objQueryResponse.QueryLetter = "~/QueryLetters/" + "/" + QueryResponseUpload1.FileName.ToString();

            }
            objQueryResponse.ResponseDate = DateTime.Now.ToString();
            (new EmployeeQueryTableController()).UpdateQueryResponse(objQueryResponse);

            PanelQueryDetails.Visible = false;
            string message = "Your response to  the query title " + objQuery.QueryTitle + " has been sent successfuly";
        }
        protected void btnCloseQueryResponse_Click(object sender, EventArgs e)
        {
            PanelQueryDetails.Visible = false;
        }
        protected void grantLeaveBtn_Click(object sender, EventArgs e)
        {
            int employeeID = CurrentEmployeeDetail.EmployeeID;
            string dept = CurrentEmployeeDetail.DeptName;

           
                    
            // first check if the employee has previously applied for leave
            EmployeeLeaveTableInfo objEmployeeLeave = new EmployeeLeaveTableInfo();
            objEmployeeLeave = (new EmployeeLeaveTableController()).GetForAnEmployee(employeeID);
            if (objEmployeeLeave == null) {
               try
                 {
                     // that is has not applied for leave before

                     // number of leave an employee is entitle depend on his level
                    // get the levelId of the current employee
                    // then use it to get his leave entitle from the level table

                    EmployeeLevelTableInfo objLevel = new EmployeeLevelTableInfo();
                    objLevel = (new EmployeeLevelTableController()).Get(CurrentEmployeeDetail.EmployeeLevel_FK);
                    int LeaveEntitle = Convert.ToInt32(objLevel.LeaveEntitle);
                    int leaveDuration = Convert.ToInt32(txtLeaveDuration.Text);

                    // LeaveThreshold is the number of leave left

                    int leaveThreshold = LeaveEntitle - leaveDuration;
                    EmployeeLeaveTableInfo objEmpLeave = new EmployeeLeaveTableInfo();

                    objEmpLeave.Duration = txtLeaveDuration.Text;
                    objEmpLeave.LeaveThreshold = leaveThreshold.ToString();
                    objEmpLeave.DateApplied = DateTime.Now.ToString();
                    objEmpLeave.LeaveType_FK = Convert.ToInt32(leaveTypeList.SelectedValue);
                    objEmpLeave.LeaveDescription = txtLeaveDesc.Text;
                    objEmpLeave.StartDate = leaveStartDayList.SelectedItem + "-" + leaveStartMonthList.SelectedItem + "-" + leaveStartYearList.SelectedItem;
                    objEmpLeave.EndDate = LeaveEndDayList.SelectedItem + "-" + LeaveEndMonthList.SelectedItem + "-" + LeaveEndYearList.SelectedItem;
                    objEmpLeave.Level_FK = CurrentEmployeeDetail.EmployeeLevel_FK;
                    objEmpLeave.Dept_FK = CurrentEmployeeDetail.Department_FK;
                    objEmpLeave.EmployeeID_FK = CurrentEmployeeDetail.EmployeeID;
                    // save the info in leave table                                        
                    int leaveID = (new EmployeeLeaveTableController()).AddLeaveApplication(objEmpLeave);

                    if (leaveID > 0)
                    {

                        // also save the info in leave log table

                        EmployeeLeaveTableLogInfo objEmpLeaveLog = new EmployeeLeaveTableLogInfo();
                        objEmpLeaveLog.LeaveID_FK = leaveID;
                        objEmpLeaveLog.Duration = txtLeaveDuration.Text;
                        objEmpLeaveLog.LeaveThreshold = leaveThreshold.ToString();
                        objEmpLeaveLog.DateApplied = DateTime.Now.ToString();
                        objEmpLeaveLog.LeaveType_FK = Convert.ToInt32(leaveTypeList.SelectedValue);
                        objEmpLeaveLog.LeaveDescription = txtLeaveDesc.Text;
                        objEmpLeaveLog.StartDate = leaveStartDayList.SelectedItem + "-" + leaveStartMonthList.SelectedItem + "-" + leaveStartYearList.SelectedItem;
                        objEmpLeaveLog.EndDate = LeaveEndDayList.SelectedItem + "-" + LeaveEndMonthList.SelectedItem + "-" + LeaveEndYearList.SelectedItem;
                        objEmpLeaveLog.Level_FK = CurrentEmployeeDetail.EmployeeLevel_FK;
                        objEmpLeaveLog.Dept_FK = CurrentEmployeeDetail.Department_FK;
                        objEmpLeaveLog.EmployeeID_FK = CurrentEmployeeDetail.EmployeeID;

                        int leaveLogID = (new EmployeeLeaveTableLogController()).AddLeaveApplication(objEmpLeaveLog);
                        if (leaveLogID > 0)
                        {
                            lblLeaveMessage.Text = "Leave Request sent successfully";
                        }
                        else
                        {
                            lblLeaveMessage.Text = "Leave Request Fail";
                        }


                    }
                    else
                    {
                        lblLeaveMessage.Text = "Leave Request Fail";
                    }

            }
            catch(Exception ex)
              {
                     lblLeaveMessage.Text = ex.Message;
              }
               
            }
            else
            {
                try
                { // has applied before
                    int leavethreshold = Convert.ToInt32(objEmployeeLeave.LeaveThreshold);


                    int leaveDuration = Convert.ToInt32(txtLeaveDuration.Text);
                    int NewleaveThreshold = leavethreshold - leaveDuration;
                    EmployeeLeaveTableInfo objEmpLeave = new EmployeeLeaveTableInfo();

                    objEmpLeave.Duration = txtLeaveDuration.Text;
                    objEmpLeave.LeaveThreshold = NewleaveThreshold.ToString();
                    objEmpLeave.DateApplied = DateTime.Now.ToString();
                    objEmpLeave.LeaveType_FK = Convert.ToInt32(leaveTypeList.SelectedValue);
                    objEmpLeave.LeaveDescription = txtLeaveDesc.Text;
                    objEmpLeave.StartDate = leaveStartDayList.SelectedItem + "-" + leaveStartMonthList.SelectedItem + "-" + leaveStartYearList.SelectedItem;
                    objEmpLeave.EndDate = LeaveEndDayList.SelectedItem + "-" + LeaveEndMonthList.SelectedItem + "-" + LeaveEndYearList.SelectedItem;
                    objEmpLeave.Level_FK = CurrentEmployeeDetail.EmployeeLevel_FK;
                    objEmpLeave.Dept_FK = CurrentEmployeeDetail.Department_FK;
                    objEmpLeave.EmployeeID_FK = CurrentEmployeeDetail.EmployeeID;

                    // update the leave table

                    new EmployeeLeaveTableController().UpdateLeaveApplication(objEmpLeave);
                    // save in leave log table
                    // first get the leave id from leave table
                    EmployeeLeaveTableInfo objLeave = new EmployeeLeaveTableInfo();
                    objLeave = (new EmployeeLeaveTableController()).GetForAnEmployee(employeeID);

                    EmployeeLeaveTableLogInfo objEmpLeaveLog = new EmployeeLeaveTableLogInfo();
                    objEmpLeaveLog.LeaveID_FK = objLeave.LeaveID;
                    objEmpLeaveLog.Duration = txtLeaveDuration.Text;
                    objEmpLeaveLog.LeaveThreshold = NewleaveThreshold.ToString();
                    objEmpLeaveLog.DateApplied = DateTime.Now.ToString();
                    objEmpLeaveLog.LeaveType_FK = Convert.ToInt32(leaveTypeList.SelectedValue);
                    objEmpLeaveLog.LeaveDescription = txtLeaveDesc.Text;
                    objEmpLeaveLog.StartDate = leaveStartDayList.SelectedItem + "-" + leaveStartMonthList.SelectedItem + "-" + leaveStartYearList.SelectedItem;
                    objEmpLeaveLog.EndDate = LeaveEndDayList.SelectedItem + "-" + LeaveEndMonthList.SelectedItem + "-" + LeaveEndYearList.SelectedItem;
                    objEmpLeaveLog.Level_FK = CurrentEmployeeDetail.EmployeeLevel_FK;
                    objEmpLeaveLog.Dept_FK = CurrentEmployeeDetail.Department_FK;
                    objEmpLeaveLog.EmployeeID_FK = CurrentEmployeeDetail.EmployeeID;

                    int leaveLogID = (new EmployeeLeaveTableLogController()).AddLeaveApplication(objEmpLeaveLog);
                    if (leaveLogID > 0)
                    {
                        lblLeaveMessage.Text = "Leave Request sent successfully";
                    }
                    else
                    {
                        lblLeaveMessage.Text = "Leave Request Fail";
                    }

                }
                catch (Exception ex)
                {
                    lblLeaveMessage.Text = ex.Message;
                }
              
               // lblLeaveMessage.Text = "has  applied";
            }
         
        }
        protected void txtLeaveDuration_TextChanged(object sender, EventArgs e)
        {
            int leaveDuration = Convert.ToInt32(txtLeaveDuration.Text);
           int employeeID = CurrentEmployeeDetail.EmployeeID;       
                    
            // first check if the employee has previously applied for leave
            EmployeeLeaveTableInfo objEmployeeLeave = new EmployeeLeaveTableInfo();
            objEmployeeLeave = (new EmployeeLeaveTableController()).GetForAnEmployee(employeeID);
            if (objEmployeeLeave == null)
            {
                int LeaveEntitle = Convert.ToInt32(lblLeave.Text);
                // LeaveThreshold is the number of leave left

                int leaveThreshold = LeaveEntitle - leaveDuration;
                lblLeaveThreshold.Text = leaveThreshold.ToString();
            }
            else
            {

                int NewleaveThreshold = Convert.ToInt32(objEmployeeLeave.LeaveThreshold) - leaveDuration;
                lblLeaveThreshold.Text = NewleaveThreshold.ToString();

            }
        }
        protected void btnViewLeave_Click(object sender, EventArgs e)
        {
            
            
            
            int employeeID = CurrentEmployeeDetail.EmployeeID;
            ArrayList objLeave = new ArrayList();
            objLeave = (new EmployeeLeaveTableController()).GetByEmployeeDetails(employeeID);
            if (objLeave.Count > 0)
            {
                GVLeave.DataSource= objLeave;
                GVLeave.DataBind();
                GVLeave.Visible = true;
            }
        }
}
}

    



