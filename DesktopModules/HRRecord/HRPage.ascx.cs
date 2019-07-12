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
using Bilikis.HRManagementSystem;


namespace Bilikis.HRManagementSystem
{
    public partial class HRPage : PortalModuleBase, IActionable
    {
        string passport;
        string filepath2;
        int applicantID;
        int employeeID;
        string employeeNum;
        int employeeUserID;
        string usernameid;
        string empUser;
        DataTable dt1 = new DataTable();
        bool flag = false;

        UserController objUserController = new UserController();

        RoleController objRoleController = new RoleController();

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
                MViewHRPage.ActiveViewIndex = 0;
                var days = new ArrayList();
                days.Add("*Day*");
                for (var i = 1; i <= 31; i++)
                {
                    days.Add(i);
                }
              //  disiciplinedDayList.DataSource = days;
                //disiciplinedDayList.DataBind();

                sendOfferResumptionDayList.DataSource = days;
                sendOfferResumptionDayList.DataBind();

                trainingStartDayList.DataSource = days;
                trainingStartDayList.DataBind();

                trainingEndDayList.DataSource = days;
                trainingEndDayList.DataBind();

                //transferDayList.DataSource = days;
                //transferDayList.DataBind();

                leaveStartDayList.DataSource = days;
                leaveStartDayList.DataBind();

                LeaveEndDayList.DataSource = days;
                LeaveEndDayList.DataBind();

                //queryIssuedDayList.DataSource = days;
                //queryIssuedDayList.DataBind();

                //disiciplinedDayList.DataSource = days;
                // disiciplinedDayList.DataBind();

                promoDayList.DataSource = days;
                promoDayList.DataBind();

                var yrs = new ArrayList();
                yrs.Add("*Year*");
                for (var i = 2018; i >= 1900; i--)
                {
                    yrs.Add(i);
                }
             //   disiciplinedYearList.DataSource = yrs;
               // disiciplinedYearList.DataBind();
                sendOfferResumptionYearList.DataSource = yrs;
                sendOfferResumptionYearList.DataBind();

                trainingStartYearList.DataSource = yrs;
                trainingStartYearList.DataBind();

                //transferYearList.DataSource = yrs;
                //transferYearList.DataBind();

                leaveStartYearList.DataSource = yrs;
                leaveStartYearList.DataBind();

                //queryIssuedYearList.DataSource = yrs;
                //queryIssuedYearList.DataBind();

                // disiciplinedYearList.DataSource = yrs;
                // disiciplinedYearList.DataBind();

                promoYearList.DataSource = yrs;
                promoYearList.DataBind();

                retireStartYearofService.DataSource = yrs;
                retireStartYearofService.DataBind();

                retireEndYearofService.DataSource = yrs;
                retireEndYearofService.DataBind();
                //loading applicantID
                #region
                //ArrayList objApplicantID = new ArrayList();
                //objApplicantID = (new ApplicantPersonalDetailsController()).ManagementApprovedList();

                //if (objApplicantID.Count > 0)
                //{
                //  sendOfferAppIDList.DataSource = objApplicantID;
                //sendOfferAppIDList.DataTextField = "ApplicantNum";
                //sendOfferAppIDList.DataValueField = "ApplicantID";
                //sendOfferAppIDList.DataBind();
                //}
                //sendOfferAppIDList.Items.Insert(0, new ListItem("***Please select", "-1"));



                //if (objApplicantID.Count > 0)
                //{
                //  sendOfferApplicantList.DataSource = objApplicantID;
                //sendOfferApplicantList.DataTextField = "ApplicantNum";
                //sendOfferApplicantList.DataValueField = "ApplicantID";
                //sendOfferApplicantList.DataBind();
                //}
                //sendOfferApplicantList.Items.Insert(0, new ListItem("***Please select", "-1"));

                //Loading AcceptanceapplicantList  from Ola

                //ArrayList objApplID = new ArrayList();
                //objApplID = (new ApplicantPersonalDetailsController()).AcceptanceAppList();

                //if (objApplID.Count > 0)
                //{
                //    AcceptanceapplicantList.DataSource = objApplID;
                //    AcceptanceapplicantList.DataTextField = "ApplicantNum";
                //    AcceptanceapplicantList.DataValueField = "ApplicantID";
                //    AcceptanceapplicantList.DataBind();
                //}
                //AcceptanceapplicantList.Items.Insert(0, new ListItem("***Please select", "-1"));

                ArrayList objApplID = new ArrayList();
                objApplID = (new ApplicantPersonalDetailsController()).ListAllApprovedApplicants();

                if (objApplID.Count > 0)
               {
                   AcceptanceapplicantList.DataSource = objApplID;
                    AcceptanceapplicantList.DataTextField = "ApplicantNum";
                    AcceptanceapplicantList.DataValueField = "ApplicantID";
                    AcceptanceapplicantList.DataBind();
                }
                AcceptanceapplicantList.Items.Insert(0, new ListItem("***Please select", "-1"));

                #endregion



                //Loading EmployeeID
                #region

                // ArrayList objEmpIDList = new ArrayList();
                // objEmpIDList = (new EmployeeDetailsController()).List();

                // if (objEmpIDList.Count > 0)
                //{

                //  queryDeptList.DataSource = objEmpIDList;
                //  queryDeptList.DataTextField = "EmployeeNum";
                //  queryDeptList.DataValueField = "EmployeeID";
                //  queryDeptList.DataBind();
                //}
                //  queryDeptList.Items.Insert(0, new ListItem("***Please select***", "-1"));
                // //if (objEmpIDList.Count > 0)
                // {

                //   hrEmpProfileIDList.DataSource = objEmpIDList;
                // hrEmpProfileIDList.DataTextField = "EmployeeNum";
                //hrEmpProfileIDList.DataValueField = "EmployeeID";
                //hrEmpProfileIDList.DataBind();
                //  }
                //hrEmpProfileIDList.Items.Insert(0, new ListItem("***Please select***", "-1"));


                // if (objEmpIDList.Count > 0)
                // {
                //  transferEmployeeList.DataSource = objEmpIDList;
                //   transferEmployeeList.DataTextField = "EmployeeNum";
                // transferEmployeeList.DataValueField = "EmployeeID";
                //transferEmployeeList.DataBind();
                //}
                //transferEmployeeList.Items.Insert(0, new ListItem("***Please select", "-1"));

                // Loading employee that are yet to be confirmed
                ArrayList objEmpUnconfirmedList = new ArrayList();
                objEmpUnconfirmedList = (new EmployeeDetailsController()).UnconfirmedList();
                if (objEmpUnconfirmedList.Count > 0)
                {
                    confirmEmployeeList.DataSource = objEmpUnconfirmedList;
                    confirmEmployeeList.DataTextField = "EmployeeNum";
                    confirmEmployeeList.DataValueField = "EmployeeID";
                    confirmEmployeeList.DataBind();
                }
                confirmEmployeeList.Items.Insert(0, new ListItem("***Please select_***", "-1"));


                //Qualification

                // ArrayList objHrApprove = new ArrayList();
                // objHrApprove = (new EmployeeDetailsController()).QualifUnApprovedList();

                // if (objHrApprove.Count > 0)
                // {
                //     hrUnApprovedQualifList.DataSource = objHrApprove;
                //     hrUnApprovedQualifList.DataTextField = "EmployeeNum";
                //     hrUnApprovedQualifList.DataValueField = "EmployeeID";
                //      hrUnApprovedQualifList.DataBind();
                //  }

                //Certification

                //  ArrayList objProfQualifHrApprove = new ArrayList();
                //  objProfQualifHrApprove = (new EmployeeDetailsController()).ProfQualifUnApprovedList();

                //   if (objProfQualifHrApprove.Count > 0)
                //   {

                //       hrUnApprovedCertList.DataSource = objProfQualifHrApprove;
                //       hrUnApprovedCertList.DataTextField = "EmployeeNum";
                //      hrUnApprovedCertList.DataValueField = "EmployeeID";
                //      hrUnApprovedCertList.DataBind();
                //  }
                //  hrUnApprovedCertList.Items.Insert(0, new ListItem("***Please select***", "-1"));


                //Document
                //  ArrayList objDocHrApprove = new ArrayList();
                //   objDocHrApprove = (new EmployeeDetailsController()).DocUnApprovedList();


                //   if (objDocHrApprove.Count > 0)
                //   {

                //       hrUnApprovedDocList.DataSource = objDocHrApprove;
                ////       hrUnApprovedDocList.DataTextField = "EmployeeNum";
                //      hrUnApprovedDocList.DataValueField = "EmployeeID";
                //      hrUnApprovedDocList.DataBind();
                //  }
                //  hrUnApprovedDocList.Items.Insert(0, new ListItem("***Please select***", "-1"));






                #endregion

                // Loading Department
                #region
                ArrayList objEmpDept = new ArrayList();
                objEmpDept = (new EmployeeDepartmentTableController()).List();
                if (objEmpDept.Count > 0)
                {

                    queryDeptList.DataSource = objEmpDept;
                    queryDeptList.DataTextField = "DeptName";
                    queryDeptList.DataValueField = "DeptID";
                    queryDeptList.DataBind();

                }
                queryDeptList.Items.Insert(0, new ListItem("***Please select***", "-1"));
                queryEmployeeList.Items.Insert(0, new ListItem("***Please select***", "-1"));
                // if (objEmpDept.Count > 0)
                // {
                //    HrSendOfferDeptList.DataSource = objEmpDept;
                //   HrSendOfferDeptList.DataTextField = "DeptName";
                //   HrSendOfferDeptList.DataValueField = "DeptID";
                //  HrSendOfferDeptList.DataBind();

                // }
                // HrSendOfferDeptList.Items.Insert(0, new ListItem("***Please select***", "-1"));

                // if (objEmpDept.Count > 0)
                // {

                //   transferNewDeptList.DataSource = objEmpDept;
                //   transferNewDeptList.DataTextField = "DeptName";
                //   transferNewDeptList.DataValueField = "DeptID";
                //   transferNewDeptList.DataBind();

                // }
                //  transferNewDeptList.Items.Insert(0, new ListItem("***Please select***", "-1"));


                // these were comment out by mrs ola
                // if (objEmpDept.Count > 0)
                //{
                // AcceptanceDeptList.DataSource = objEmpDept;
                // AcceptanceDeptList.DataTextField = "DeptName";
                // AcceptanceDeptList.DataValueField = "DeptID";
                // AcceptanceDeptList.DataBind();

                //}
                // AcceptanceDeptList.Items.Insert(0, new ListItem("***Please select***", "-1"));
                // AccptPositionList.Items.Insert(0, new ListItem("***Please select***", "-1"));
                #endregion

                //Load Level
                #region

                //                ArrayList objEmpLevel = new ArrayList();
                //                objEmpLevel = (new EmployeeLevelController()).List();

                //                if (objEmpLevel.Count > 0)
                //                {
                //                    hrSendOfferLevelList.DataSource = objEmpLevel;
                //                    hrSendOfferLevelList.DataTextField = "LevelName";
                //                    hrSendOfferLevelList.DataValueField = "LevelID";
                //                    hrSendOfferLevelList.DataBind();
                //                }
                //                hrSendOfferLevelList.Items.Insert(0, new ListItem("***Please select", "-1"));


                //                //if (objEmpLevel.Count > 0)
                //                //{

                //                //    AcceptanceLevelList.DataSource = objEmpLevel;
                //                //    AcceptanceLevelList.DataTextField = "LevelName";
                //                //    AcceptanceLevelList.DataValueField = "LevelID";
                //                //    AcceptanceLevelList.DataBind();
                //                //}
                //                //AcceptanceLevelList.Items.Insert(0, new ListItem("***Please select", "-1"));

                #endregion


                //Loading Working Location
                #region
                ArrayList objEmpWorkLocation = new ArrayList();
                objEmpWorkLocation = (new EmployeeWorkLocationController()).List();

                //if (objEmpWorkLocation.Count > 0)
                //{
                //    hrSendOfferWorkLocList.DataSource = objEmpWorkLocation;
                //    hrSendOfferWorkLocList.DataTextField = "LocationName";
                //    hrSendOfferWorkLocList.DataValueField = "WorkLocationID";
                //    hrSendOfferWorkLocList.DataBind();
                //}
                //hrSendOfferWorkLocList.Items.Insert(0, new ListItem("***Please select***", "-1"));


                if (objEmpWorkLocation.Count > 0)
                {

                    transferNewWokLocList.DataSource = objEmpWorkLocation;
                    transferNewWokLocList.DataTextField = "LocationName";
                    transferNewWokLocList.DataValueField = "WorkLocationID";
                    transferNewWokLocList.DataBind();
                }
                transferNewWokLocList.Items.Insert(0, new ListItem("***Please select***", "-1"));




                #endregion         



                //loading Discipline type
                #region"Discipline type"
               

                //ArrayList DisciplineType = new ArrayList();
                //DisciplineType = new EmployeeDisciplineTableController().List();
                //if (DisciplineType.Count > 0)
                //{
                //    ddlDisciplineType.DataSource = DisciplineType;
                //    ddlDisciplineType.DataValueField = "DisciplineID";
                //    ddlDisciplineType.DataTextField = "DiscplineDescription";
                //    ddlDisciplineType.DataBind();
                //    ddlDisciplineType.Visible = true;
                //}
                //lblDisciplineDate.Text = DateTime.Now.ToString();
                #endregion

            }

            //Loading years DOB
            //if (IsPostBack) return;
            //else
            //{}
              

        }
        protected void welHometBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 0;
        }
        protected void welEmplomentBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 1;

        }

        protected void sendemploy_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 2;
        }
        protected void hrEmpAccptMenuBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 3;
        }
        protected void hrEmpMenuBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 4;
        }
        protected void Approval_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 5;
        }

        protected void welConfirmBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 8;
        }
        protected void trainingMenuBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 9;
        }
        protected void welTransferBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 10;
        }
        protected void welLeave_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 11;
            ArrayList objDept = new ArrayList();
            objDept = (new EmployeeDepartmentTableController()).List();
            if (objDept.Count > 0)
            {
                ddlLeaveDeptList.DataSource = objDept;
                ddlLeaveDeptList.DataTextField = "DeptName";
                ddlLeaveDeptList.DataValueField = "DeptID";
                ddlLeaveDeptList.DataBind();
                ddlLeaveDeptList.Items.Insert(0,new  ListItem("---Please select", "-1"));
                
            }
        }
        protected void welQuery_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 12;
            PanelDiscipline.Visible = false;
            // displaying panel for issuing query
            PanelQuery.Visible = false;
            //LbHrQueryIssueDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            LbHrQueryIssueDate.Text = DateTime.Now.ToString();

            LbHrQueryIssueDate.Visible = true;
            UserInfo objIssuedByUser = new UserInfo();
            objIssuedByUser = (new UserController()).GetUser(0, UserId);

            LbIssuedBy.Text = objIssuedByUser.LastName + " " + objIssuedByUser.FirstName;
            
            //List queries sent by hr
            int IssuedBy = objIssuedByUser.UserID;
            ArrayList objQuery = new ArrayList();

            objQuery = (new EmployeeQueryTableController()).GetByUsers(IssuedBy);
            if (objQuery.Count > 0)
            {
                GVHRQuery.DataSource = objQuery;
                GVHRQuery.DataBind();
                GVHRQuery.Visible = true;
                lblListQuery.Visible = true;
            }
            else
            {
                lblListQuery.Visible = false;
                GVHRQuery.Visible = false;
            }
        }

        protected void welAppraisal_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 13;
        }
        protected void welPromotion_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 14;
        }
        protected void welPensionRetirement_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 15;
        }

        protected void appraisalNextBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 13;
        }
        protected void appraisalBackBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 11;
        }
        protected void appraisalHomeBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 0;
        }


        protected void hrHomeLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 0;
        }
        protected void hrEmploymentLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 1;
        }


        protected void hrAcceptanceLinkButton_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 2;
        }
        protected void hrEmployeeLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 3;
        }
        protected void hrConfirmationLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 7;
        }


        protected void hrTrainingLinkBtn0_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 8;
        }
        protected void hrTransferLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 9;
        }
        protected void hrLeaveLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 10;
        }
        protected void hrQueryLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 11;
        }

        protected void hrAppraisalLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 12;
        }
        protected void hrPromotionLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 13;
        }
        protected void hrRetirementLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 14;
        }

       
        protected void leaveStartDayCalenderImageBtn_Click(object sender, ImageClickEventArgs e)
        {
            leaveStartDateCalender.Visible = true;
            txtLeaveStartDate.Text = leaveStartDateCalender.SelectedDate.ToShortDateString();
        }
        protected void leaveEndDayCalenderImageBtn_Click(object sender, ImageClickEventArgs e)
        {
            leaveEndDateCalender.Visible = true;
            txtLeaveEndDate.Text = leaveEndDateCalender.SelectedDate.ToShortDateString();
        }
        protected void disciplinedDateCalenderImageBtn_Click(object sender, ImageClickEventArgs e)
        {
           // disciplineDateCalendar.Visible = true;
            //txtDisciplineDate.Text = disciplineDateCalendar.SelectedDate.ToShortDateString();
        }

        protected void BioDataLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 2;
        }
        protected void qualifLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 3;
        }
        protected void certLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 4;
        }
        protected void docLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 5;
        }
        protected void refreeLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 6;
        }

    
        protected void HREmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
           // GViewCert.Visible = true;
        }
        protected void HRDocEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
           // GViewDoc.Visible = true;
        }
        
        protected void appraisalFinishBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 0;
        }
        protected void SupPreYearGoalDateCalenderImageBtn_Click(object sender, ImageClickEventArgs e)
        {
            preYearGoalCompletionDateCalendar.Visible = true;
            txtSupPreYearGoalDate.Text = preYearGoalCompletionDateCalendar.SelectedDate.ToShortDateString();
        }
        protected void SupNextYearGoalDateCalenderImageBtn_Click(object sender, ImageClickEventArgs e)
        {
            nxtYearCompletionDateCalendar.Visible = true;
            txtSupNextYearGoalDate.Text = nxtYearCompletionDateCalendar.SelectedDate.ToShortDateString();
        }
        protected void HRBiodataFinishBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 0;
        }
        protected void QualifFinishBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 0;
        }


        //Loading Position 
        #region
        protected void HrSendOfferDeptList_SelectedIndexChanged(object sender, EventArgs e)
        {

            ArrayList objEmpPosition = new ArrayList();
            int DeptID = Convert.ToInt32(HrSendOfferDeptList.SelectedValue);
            objEmpPosition = (new EmployeePositionTableController()).GetByEmployeeDepartmentTable(DeptID);

            if (objEmpPosition.Count > 0)
            {
                approvedPositionList.DataSource = objEmpPosition;
                approvedPositionList.DataTextField = "PositionName";
                approvedPositionList.DataValueField = "PositionID";
                approvedPositionList.DataBind();

                approvedPositionList.Items.Insert(0, new ListItem("***Please select***", "-1"));

            }
            //where i am

            ArrayList objEmpLevel = new ArrayList();
           // objEmpPosition = (new EmployeePositionTableController()).GetByEmployeeDepartmentTable(DeptID);
            objEmpLevel = (new EmployeeLevelTableController()).GetByEmployeeDepartmentTable(DeptID);

            if (objEmpLevel.Count > 0)
            {
                hrSendOfferLevelList.DataSource = objEmpLevel;
                hrSendOfferLevelList.DataTextField = "LevelName";
                hrSendOfferLevelList.DataValueField = "LevelID";
                hrSendOfferLevelList.DataBind();
            }
            hrSendOfferLevelList.Items.Insert(0, new ListItem("***Please select", "-1"));

        }

        //protected void AcceptanceDeptList_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ArrayList objAcceptPosition = new ArrayList();
        //    int DeptID = Convert.ToInt32(AcceptanceDeptList.SelectedValue);
        //    objAcceptPosition = (new EmployeePositionTableController()).GetByEmployeeDepartmentTable(DeptID);

        //    if (objAcceptPosition.Count > 0)
        //    {
        //        AccptPositionList.DataSource = objAcceptPosition;
        //        AccptPositionList.DataTextField = "PositionName";
        //        AccptPositionList.DataValueField = "PositionID";
        //        AccptPositionList.DataBind();

        //        AccptPositionList.Items.Insert(0, new ListItem("***Please select***", "-1"));

        //    }

        //}

        #endregion


        //Offer Employment

        #region

        protected void sendOfferAppIDList_SelectedIndexChanged(object sender, EventArgs e)
        {

            PanelSendOfferLabel.Visible = true;
            PanelSendOfferLetter.Visible = true;

            ApplicantPersonalDetailsInfo objViewSendOfferAppInfo = new ApplicantPersonalDetailsInfo();
            int applicantID = Convert.ToInt32(sendOfferAppIDList.SelectedValue);
            objViewSendOfferAppInfo = (new ApplicantPersonalDetailsController()).Get(applicantID);

            EmployeeDepartmentTableInfo objAppDept = new EmployeeDepartmentTableInfo();
            int DeptID = objViewSendOfferAppInfo.DepartmentID_FK;
            objAppDept = (new EmployeeDepartmentTableController()).Get(DeptID);


            EmployeePositionTableInfo objAppPosition = new EmployeePositionTableInfo();
            int PositionID = objViewSendOfferAppInfo.PositionApproved_FK;
            objAppPosition = (new EmployeePositionTableController()).Get(PositionID);


            EmployeeLevelTableInfo objAppLevel = new EmployeeLevelTableInfo();
            int LevelID = objViewSendOfferAppInfo.LevelID_FK;
            objAppLevel = (new EmployeeLevelTableController()).Get(LevelID);

            EmployeeWorkLocationInfo objAppWorkLoc = new EmployeeWorkLocationInfo();
            int WorkLocationID = objViewSendOfferAppInfo.WorkLocationID_FK;
            objAppWorkLoc = (new EmployeeWorkLocationController()).Get(WorkLocationID);

            LbSendOfferDept.Text = objAppDept.DeptName;
            LbSendOfferApprovedPosition.Text = objAppPosition.PositionName;
            LbSendOfferLevel.Text = objAppLevel.LevelName;
            LbSendOfferSalary.Text = objAppLevel.Salary;
            LbSendOfferWorkLoc.Text = objAppWorkLoc.LocationName + "," + " " + objAppWorkLoc.LocationAddress;
            
           // LbSendOfferResumptionDate = objViewSendOfferAppInfo.resumptionDate; 
                
               // Convert.ToString(approvedPositionList.SelectedItem);

            string myDate = DateTime.Now.ToShortDateString();
            sendOfferLetterDate.Text = myDate;
            sendOfferNames.Text = objViewSendOfferAppInfo.LastName + " " + objViewSendOfferAppInfo.MiddleName + " " + objViewSendOfferAppInfo.FirstName;
            sendOfferAddr.Text = objViewSendOfferAppInfo.ContactAddress;
            sendOfferLName.Text = objViewSendOfferAppInfo.LastName;
            sendOfferLetterDept1.Text = LbSendOfferDept.Text;
            sendOfferLetterDept2.Text = objAppDept.DeptName;
            sendOfferLetterPosition1.Text = objAppPosition.PositionName;
            sendOfferLetterPosition2.Text = LbSendOfferApprovedPosition.Text;
            sendOfferLetterLevel.Text = objAppLevel.LevelName;
            sendOfferLetterSalary.Text = objAppLevel.Salary;
            sendOfferLetterWorkLoc.Text = objAppWorkLoc.LocationName + "," + " " + objAppWorkLoc.LocationAddress;
            

        }
        protected void sendOfferResumptionYearList_SelectedIndexChanged(object sender, EventArgs e)
        {
            sendOfferPanel.Visible = true;           
            ApplicantPersonalDetailsInfo objViewSendOfferAppDetailInfo = new ApplicantPersonalDetailsInfo();
            //objViewSendOfferAppDetailInfo.ApplicantID=Convert.ToInt32(sendOfferApplicantList.SelectedValue);
            int applicantID = Convert.ToInt32(sendOfferApplicantList.SelectedValue);
            objViewSendOfferAppDetailInfo = (new ApplicantPersonalDetailsController()).Get(applicantID);

           // EmployeeLevelInfo objEmpLevelInfo = new EmployeeLevelInfo();
            //int LevelID = Convert.ToInt32(hrSendOfferLevelList.SelectedValue);
            //objEmpLevelInfo = (new EmployeeLevelController()).Get(LevelID);

            // var todayDate = DateTime.Now.ToString("DD-MM-YYYY");

            string myDate = DateTime.Now.ToShortDateString();
            LbSysDate.Text = myDate;
            LbPosition1.Text = Convert.ToString(approvedPositionList.SelectedItem);
            LbsendOfferDept1.Text = Convert.ToString(HrSendOfferDeptList.SelectedItem);
            LbPosition.Text = Convert.ToString(approvedPositionList.SelectedItem);
            LbsendOfferDept2.Text = Convert.ToString(HrSendOfferDeptList.SelectedItem);
            LbLevel.Text = Convert.ToString(hrSendOfferLevelList.SelectedItem);
            LbApplicantNames.Text = objViewSendOfferAppDetailInfo.LastName + " " + objViewSendOfferAppDetailInfo.FirstName + " " + objViewSendOfferAppDetailInfo.MiddleName;
            LbHomeAddres.Text = objViewSendOfferAppDetailInfo.HomeTown;
            LbAppLName.Text = objViewSendOfferAppDetailInfo.LastName;
            
            // objEmpLevelInfo.Salary;
            LbSalary2.Text = LbSalary1.Text;
            LbWorkLocation.Text = Convert.ToString(hrSendOfferWorkLocList.SelectedItem);
            string resumptionDate = sendOfferResumptionDayList.SelectedItem + "-" + sendOfferResumptionMonthList.SelectedItem + "-" + sendOfferResumptionYearList.SelectedItem;
            LbResumptionDate.Text = resumptionDate;
        }


        protected void hrSendOfferLevelList_SelectedIndexChanged(object sender, EventArgs e)
        {

            LbSalary1.Visible = true;

            EmployeeLevelTableInfo objEmpLevelInfo = new EmployeeLevelTableInfo();
            int LevelID = Convert.ToInt32(hrSendOfferLevelList.SelectedValue);
            objEmpLevelInfo = (new EmployeeLevelTableController()).Get(LevelID);

            LbSalary1.Text = objEmpLevelInfo.Salary;
        }



        //protected void AcceptanceLevelList_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    LbAcceptanceSalary1.Visible = true;
           

        //    EmployeeLevelInfo objEmpLevelInfo = new EmployeeLevelInfo();
        //    int LevelID = Convert.ToInt32(AcceptanceLevelList.SelectedValue);
        //    objEmpLevelInfo = (new EmployeeLevelController()).Get(LevelID);

        //    LbAcceptanceSalary1.Text = objEmpLevelInfo.Salary;

        //}


        protected void sendEmploymentLetterBtn_Click(object sender, EventArgs e)
        {

            try
            {
                ApplicantPersonalDetailsInfo objSendOfferAppDetails = new ApplicantPersonalDetailsInfo();
                int ApplicantID = Convert.ToInt32(sendOfferApplicantList.SelectedValue);

                objSendOfferAppDetails.ApplicantID = ApplicantID;
                objSendOfferAppDetails.PositionApproved_FK = Convert.ToInt32(approvedPositionList.SelectedValue);
                objSendOfferAppDetails.DepartmentID_FK = Convert.ToInt32(HrSendOfferDeptList.SelectedValue);
                objSendOfferAppDetails.LevelID_FK = Convert.ToInt32(hrSendOfferLevelList.SelectedValue);
                objSendOfferAppDetails.WorkLocationID_FK = Convert.ToInt32(hrSendOfferWorkLocList.SelectedValue);
                (new ApplicantPersonalDetailsController()).SendingOfferUpdate(objSendOfferAppDetails);

                if (ApplicantID == objSendOfferAppDetails.ApplicantID)
                {
                    LbOffersent.Visible = true;
                    LbOffersent.Text ="Details updated successfull";
                }
                else
                {
                    LbOffersent.Visible = true;
                    LbOffersent.Text = "Details Not updated ";
                }


            }

            //    //send an email from a Gmail address using SMTP server.  
            //    //The Gmail SMTP server name is smtp.gmail.com and
            //    //the port using send mail is 587 and also using  

            //    //NetworkCredential for password based authentication;
            //    string _subjectEmail = "";
            //    MailMessage mail = new MailMessage();
            //    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            //    mail.IsBodyHtml = true;
            //    //mail.From = new MailAddress("your_email_address@gmail.com");
            //    mail.From = new MailAddress("olami@neetbeettech@gmail.com");


            //    //Loading all Mail contents

            //    ApplicantPersonalDetailsInfo objAppDetailInfo = new ApplicantPersonalDetailsInfo();
            //    //int ApplicantID = Convert.ToInt32(sendOfferApplicantList.SelectedValue);
            //   objAppDetailInfo = (new ApplicantPersonalDetailsController()).Get(ApplicantID);

            //    EmployeeDepartmentTableInfo objEmpDeptInfo = new EmployeeDepartmentTableInfo();
            //    int DeptID = Convert.ToInt32(HrSendOfferDeptList.SelectedValue);
            //    objEmpDeptInfo = (new EmployeeDepartmentTableController()).Get(DeptID);

            //    EmployeePositionTableInfo objEmpPositionInfo = new EmployeePositionTableInfo();
            //    int PositionID = Convert.ToInt32(approvedPositionList.SelectedValue);
            //    objEmpPositionInfo = (new EmployeePositionTableController()).Get(PositionID);

            //    EmployeeLevelInfo objEmpLevelInfo = new EmployeeLevelInfo();
            //    int LevelID = Convert.ToInt32(hrSendOfferLevelList.SelectedValue);
            //    objEmpLevelInfo = (new EmployeeLevelController()).Get(LevelID);


            //    EmployeeWorkLocationsInfo objEmpWorkLocInfo = new EmployeeWorkLocationsInfo();
            //    int WorkLocationID = Convert.ToInt32(hrSendOfferWorkLocList.SelectedValue);
            //    objEmpWorkLocInfo = (new EmployeeWorkLocationsController()).Get(WorkLocationID);

            //    //Composing mail content

            //    string salutaion = ("dear" + objAppDetailInfo.LastName + ",");
            //    string subjectEmail = "Employment Offer";
            //    string bodyEmail = ("Further to your application and subsquent interviewat Neetbeet Technogies Limited, we are please to offer you"
            //       + approvedPositionList.SelectedItem + "under the department of" + HrSendOfferDeptList.SelectedItem);
            //    string offerDetails = ("The following are your appointment detail: " +
            //        "Position: " + approvedPositionList.SelectedItem +
            //        "Department: " + HrSendOfferDeptList.SelectedItem +
            //        "Level: " + hrSendOfferLevelList.SelectedItem +
            //        "Salary: " + objEmpLevelInfo.Salary +
            //        "Work Loction: " + hrSendOfferWorkLocList.SelectedItem +
            //        "Resumption Date:" + sendOfferResumptionDayList.SelectedItem + "-" + sendOfferResumptionMonthList.SelectedItem + "-" + sendOfferResumptionYearList.SelectedItem +
            //        "The first six months of your employment with us will be regarded as a propationary period, during which , either you o the company could terminate the appointment by giving one (1) month's notice in writing or paying one (1) month's basic salary in lieuof notice. ");

            //    bodyEmail += offerDetails;
            //    mail.To.Add(objAppDetailInfo.Email);

            //    //mail.To = _to;
            //    // mail.IsBodyHtml = true;
            //    mail.Subject = subjectEmail;
            //    mail.Body = bodyEmail;

            //    //Adding an attachments
            //    //mail.Attachments.Add(new Attachment(MailAttachementPath));
            //    SmtpServer.Port = 587;
            //    // SmtpServer.Port = 25;
            //    SmtpServer.Credentials = new System.Net.NetworkCredential("olami@neetbeettech@gmail.com", "Adeniyi@2018");

            //    //SmtpServer.UseDefaultCredentials = false;
            //    SmtpServer.EnableSsl = true;

            //    SmtpServer.Send(mail);
            //    LbOffersent.Text = "Offer Letter SUCCESSFULLY sent";
            //    mail.Dispose();
            //}

            //catch (Exception ex)
            //{
            //    LbOffersent.Text = "Offer Letter NOT sent";
            //    //XP.Utility..Logger.WriteLogXml(ex);
            //    //this.lbmsg.Text = ex.Message.ToString();
            //    // ret = -1;
            //}
            catch
            {

            }
       }

#endregion

        #region
        //Employment Acceptance Module

      
        protected void AcceptanceapplicantList_SelectedIndexChanged(object sender, EventArgs e)
        {       
            hrEmpProfilePanel.Visible = true;

            ApplicantPersonalDetailsInfo objAppDetailInfo = new ApplicantPersonalDetailsInfo();
            int ApplicantID = Convert.ToInt32(AcceptanceapplicantList.SelectedValue);
            objAppDetailInfo = (new ApplicantPersonalDetailsController()).Get(ApplicantID);

            EmployeeDepartmentTableInfo objEmpDeptInfo = new EmployeeDepartmentTableInfo();
            int DeptID = objAppDetailInfo.DepartmentID_FK;
            objEmpDeptInfo = (new EmployeeDepartmentTableController()).Get(DeptID);

            EmployeePositionTableInfo objEmpPositionInfo = new EmployeePositionTableInfo();
            int PositionID = objAppDetailInfo.PositionApproved_FK;           
            objEmpPositionInfo = (new EmployeePositionTableController()).Get(PositionID);

            EmployeeLevelTableInfo objEmpLevelInfo = new EmployeeLevelTableInfo();
            int LevelID = objAppDetailInfo.LevelID_FK;
            objEmpLevelInfo = (new EmployeeLevelTableController()).Get(LevelID);

            EmployeeWorkLocationInfo objEmpWorkLocInfo = new EmployeeWorkLocationInfo();
            int WorkLocationID = objAppDetailInfo.WorkLocationID_FK;
            objEmpWorkLocInfo = (new EmployeeWorkLocationController()).Get(WorkLocationID);

            CountryTableInfo objAppCountryInfo = new CountryTableInfo();
            int countryID = objAppDetailInfo.Nationality_FK;
            objAppCountryInfo = (new CountryTableController()).Get(countryID);

            StateTableInfo objAppStateInfo = new StateTableInfo();
            int stateID = objAppDetailInfo.StateOfOrigin_FK;
            objAppStateInfo = (new StateTableController()).Get(stateID);

            LGATableInfo objAppLgaInfo = new LGATableInfo();
            int lgaID = objAppDetailInfo.LGA_FK;
            objAppLgaInfo = (new LGATableController()).Get(lgaID);


           LbempAccpTitle.Text = objAppDetailInfo.Title;
            LbEmpAccpFName.Text = objAppDetailInfo.FirstName;
            LbempAccpMName.Text = objAppDetailInfo.MiddleName;
            LbEmpAccpLName.Text = objAppDetailInfo.LastName;
            LbEmpAccpEmail.Text = objAppDetailInfo.Email;
            LbempAccpPhnNo.Text = objAppDetailInfo.PhoneNo;
            LbEmpAccpHomeTown.Text = objAppDetailInfo.HomeTown;
            LbEmpAccpGender.Text = objAppDetailInfo.Gender;
            LbEmpAccpContAddr.Text = objAppDetailInfo.ContactAddress;
            LbEmpAccptReligion.Text = objAppDetailInfo.Religion;
            LbEmpAccpNationality.Text = objAppCountryInfo.CountryName;
            LbEmpAccptState.Text = objAppStateInfo.StateName;
            LbEmpAccpLGA.Text = objAppLgaInfo.LgaName;
            LbEmpAccpDoB.Text = objAppDetailInfo.DateOfBirth;
            LbEmpAccptAge.Text = objAppDetailInfo.Age;
            LbempAccpMaritaStatus.Text = objAppDetailInfo.MaritalStatus;
            LbEmpAccptDept.Text = objEmpDeptInfo.DeptName;
            LbempAccpPosition.Text = objEmpPositionInfo.PositionName;
            LbEmpAccptLevel.Text = objEmpLevelInfo.LevelName;
            LbAcceptanceSalary2.Text = objEmpLevelInfo.Salary;
            LbEmpAccptWorkLoc.Text = objEmpWorkLocInfo.LocationName;
            string myDate = DateTime.Now.ToShortDateString();  
            LbEmpAccptStartDate.Text = myDate;
            AcceptanceImagePassport.ImageUrl = "~/Image/" + objAppDetailInfo.Passport.Substring(objAppDetailInfo.Passport.LastIndexOf('\\') + 1);

            //Qualification

          
            //int applicantID_FK = objAppDetailInfo.ApplicantID;
            ArrayList objQaulifList = new ArrayList();
            objQaulifList = (new ApplicantQualificationController()).GetByApplicantPersonalDetails(ApplicantID);

            if (objQaulifList.Count > 0)
            {
               
                GViewQualification.DataSource = objQaulifList;
                GViewQualification.DataBind();
                GViewQualification.Visible = true;

            }

            //ProfQualification
           

            ArrayList objProfQaulifList = new ArrayList();

            objProfQaulifList = (new ApplicantProfQualificationController()).GetByApplicantPersonalDetails(ApplicantID);

            if (objProfQaulifList.Count > 0)
            {

                GViewCert.Visible = true;
                GViewCert.DataSource = objProfQaulifList;
                GViewCert.DataBind();
            }

            // Loading documents from applicantDocumentTable

           // int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
           // int empID = CurrentEmployeeDetail.EmployeeID;
            //int applicantID = CurrentEmployeeDetail.ApplicantID_FK;
            ArrayList objDocList = new ArrayList();
            objDocList = (new ApplicantDocumentController()).GetByApplicantPersonalDetails(ApplicantID);

            if (objDocList.Count > 0)
            {

                GViewDoc.Visible = true;
                GViewDoc.DataSource = objDocList;
                GViewDoc.DataBind();
                
            }

        }
        #endregion

        //Moving ApplicantDetails into EmployeeDetails
        

        protected void AcceptEmploymentBtn_Click(object sender, EventArgs e)
        
        {

        
            try
            {
                ApplicantPersonalDetailsInfo objAcceptAppDetailInfo = new ApplicantPersonalDetailsInfo();
                int ApplicantID = Convert.ToInt32(AcceptanceapplicantList.SelectedValue);
                objAcceptAppDetailInfo = (new ApplicantPersonalDetailsController()).Get(ApplicantID);

                EmployeeDepartmentTableInfo objAccptDeptInfo = new EmployeeDepartmentTableInfo();
                int DeptID = objAcceptAppDetailInfo.DepartmentID_FK;
                objAccptDeptInfo = (new EmployeeDepartmentTableController()).Get(DeptID);
                
                EmployeePositionTableInfo objAccptPositionInfo = new EmployeePositionTableInfo();
                int PositionID = objAcceptAppDetailInfo.PositionApproved_FK;
                objAccptPositionInfo = (new EmployeePositionTableController()).Get(PositionID);

                EmployeeLevelTableInfo objAccptLevelInfo = new EmployeeLevelTableInfo();
                int LevelID = objAcceptAppDetailInfo.LevelID_FK;
                objAccptLevelInfo = (new EmployeeLevelTableController()).Get(LevelID);

                EmployeeWorkLocationInfo objAccptWorkLocInfo = new EmployeeWorkLocationInfo();
                int WorkLocationID = objAcceptAppDetailInfo.WorkLocationID_FK;
                objAccptWorkLocInfo = (new EmployeeWorkLocationController()).Get(WorkLocationID);


                CountryTableInfo objEmpCountryInfo = new CountryTableInfo();
                int countryID = objAcceptAppDetailInfo.Nationality_FK;
                objEmpCountryInfo = (new CountryTableController()).Get(countryID);

                StateTableInfo objEmpStateInfo = new StateTableInfo();
                int stateID = objAcceptAppDetailInfo.StateOfOrigin_FK;
                objEmpStateInfo = (new StateTableController()).Get(stateID);

                LGATableInfo objEmpLgaInfo = new LGATableInfo();
                int lgaID = objAcceptAppDetailInfo.LGA_FK;
                objEmpLgaInfo = (new LGATableController()).Get(lgaID);

               // LbempAccpPosition.Text = objAccptPositionInfo.PositionName;
                LbempAccpTitle.Text = objAcceptAppDetailInfo.Title;
                LbEmpAccpFName.Text = objAcceptAppDetailInfo.FirstName;
                LbempAccpMName.Text = objAcceptAppDetailInfo.MiddleName;
                LbEmpAccpLName.Text = objAcceptAppDetailInfo.LastName;
                LbEmpAccpEmail.Text = objAcceptAppDetailInfo.Email;
                LbempAccpPhnNo.Text = objAcceptAppDetailInfo.PhoneNo;
                LbEmpAccpHomeTown.Text = objAcceptAppDetailInfo.HomeTown;
                LbEmpAccpGender.Text = objAcceptAppDetailInfo.Gender;
                LbEmpAccpContAddr.Text = objAcceptAppDetailInfo.ContactAddress;
                LbEmpAccptReligion.Text = objAcceptAppDetailInfo.Religion;
                LbEmpAccpNationality.Text = objEmpCountryInfo.CountryName;
                LbEmpAccptState.Text = objEmpStateInfo.StateName;
                LbEmpAccpLGA.Text = objEmpLgaInfo.LgaName;
                LbEmpAccpDoB.Text = objAcceptAppDetailInfo.DateOfBirth;
                LbEmpAccptAge.Text = objAcceptAppDetailInfo.Age;
                LbempAccpMaritaStatus.Text = objAcceptAppDetailInfo.MaritalStatus;
                LbEmpAccptDept.Text = objAccptDeptInfo.DeptName;
                LbempAccpPosition.Text = objAccptPositionInfo.PositionName; 
                LbEmpAccptLevel.Text = objAccptLevelInfo.LevelName;
                LbEmpAccptWorkLoc.Text = objAccptWorkLocInfo.LocationName;
                string myDate = DateTime.Now.ToShortDateString();
                //int date1 =Convert.ToInt32(DateTime.Now.ToShortDateString());
                //int myDay = Convert.ToInt32(date1.Day);
                //in
                //LbSysDate.Text = myDate;    
                LbEmpAccptStartDate.Text = myDate;
                //.Text = DateTime.Now.ToString("DD-MM-YYYY");
                AcceptanceImagePassport.ImageUrl = "~/Image/" + objAcceptAppDetailInfo.Passport.Substring(objAcceptAppDetailInfo.Passport.LastIndexOf('\\') + 1);


                //Saving into EmployeeDetails

                EmployeeDetailsInfo objEmpDetailsInfo = new EmployeeDetailsInfo();

                objEmpDetailsInfo.Title = this.LbempAccpTitle.Text.Trim();
                objEmpDetailsInfo.FirstName = this.LbEmpAccpFName.Text.Trim();
                objEmpDetailsInfo.MiiddleName = this.LbempAccpMName.Text.Trim();
                objEmpDetailsInfo.LastName = this.LbEmpAccpLName.Text.Trim();
                objEmpDetailsInfo.Email = this.LbEmpAccpEmail.Text.Trim();
                objEmpDetailsInfo.PhoneNo = this.LbempAccpPhnNo.Text.Trim();
                objEmpDetailsInfo.HomeTown = this.LbEmpAccpHomeTown.Text.Trim();
                objEmpDetailsInfo.Gender = this.LbEmpAccpGender.Text.Trim();
                objEmpDetailsInfo.MaritalStatus = this.LbempAccpMaritaStatus.Text.Trim();
                objEmpDetailsInfo.ContactAddress = this.LbEmpAccpContAddr.Text.Trim();
                objEmpDetailsInfo.Religion = this.LbEmpAccptReligion.Text.Trim();
                objEmpDetailsInfo.Nationality_FK = objAcceptAppDetailInfo.Nationality_FK;
                objEmpDetailsInfo.StateOfOrigin_FK = objAcceptAppDetailInfo.StateOfOrigin_FK;
                objEmpDetailsInfo.LGA_FK = objAcceptAppDetailInfo.LGA_FK;
                objEmpDetailsInfo.DateOfBirth = this.LbEmpAccpDoB.Text.Trim();
                objEmpDetailsInfo.Age = this.LbEmpAccptAge.Text.Trim();
                objEmpDetailsInfo.Department_FK = objAcceptAppDetailInfo.DepartmentID_FK;
                objEmpDetailsInfo.PositionHeld_FK = objAcceptAppDetailInfo.PositionApproved_FK;
                objEmpDetailsInfo.EmployeeLevel_FK = objAcceptAppDetailInfo.LevelID_FK;
                objEmpDetailsInfo.WorkLocation_FK = objAcceptAppDetailInfo.WorkLocationID_FK;
                objEmpDetailsInfo.StartDate = myDate;
                LbEmpAccptStartDate.Text = myDate;
                objEmpDetailsInfo.Passport = this.AcceptanceImagePassport.ImageUrl;
                objEmpDetailsInfo.ApplicantID_FK = Convert.ToInt32(this.AcceptanceapplicantList.SelectedValue);
             
                employeeID = (new EmployeeDetailsController()).Add(objEmpDetailsInfo);
                //employeeID = (new EmployeeLevelController()).Add(objEmpDetailsInfo);
              
                string employeeid = employeeID.ToString();

                //Generating EmployeeNum
                string employeeNum = "NTL" + "/" + objEmpDetailsInfo.LastName + "/ " + DateTime.Now.ToString("yyyy") + "/" + employeeid;
               
                ViewState.Add("employeeID", employeeID);
                ViewState.Add("employeeNum", employeeNum);
                EmployeeDetailsInfo objEmpDetailsInfo2 = new EmployeeDetailsInfo();
                objEmpDetailsInfo2.EmployeeID = employeeID;
                objEmpDetailsInfo2.EmployeeNum = employeeNum;
                (new EmployeeDetailsController()).UpdateEmployeeNum(objEmpDetailsInfo2);

                //Calling CreateUser class
                int uid = CreateUser(employeeID, objEmpDetailsInfo.LastName, objEmpDetailsInfo.Email);
                
                if (uid > 0)
                {
                    UserInfo objuser = new UserInfo();
                    objuser=(new UserController()).GetUser(0, uid);

                    usernameid = objuser.Username;
                   
                }

                LbEmpIDgeneratedhere.Visible = true;
                LbEmpIDgeneratedhere.Text = "Your Login details are" + " " + "UserName= "+ usernameid + "," + " " + "Password= " + "password";
                    //uid.ToString();

                //Updating userID

               // empUser = usernameid +"," + "password";

              
                ViewState.Add("employeeID", employeeID);
                ViewState.Add("employeeUserID", employeeUserID);
                ViewState.Add("uid", uid);
                EmployeeDetailsInfo objEmpDetailsInfo3 = new EmployeeDetailsInfo();
                objEmpDetailsInfo3.EmployeeID = employeeID;
                objEmpDetailsInfo3.EmployeeUserID_FK = uid;
               // employeeUserID = uid;
                (new EmployeeDetailsController()).UpdateEmployeeUserID(objEmpDetailsInfo3);


                //Saving Qualification
              //  objEmpDetailsInfo4 = (new EmployeeDetailsController()).Get(empii);

                //EmployeeDetailsInfo objEmpInfo2 = new EmployeeDetailsInfo();
                //int empid1 = objEmpInfo2.EmployeeID;
                //objEmpInfo2 = (new EmployeeDetailsController()).Get(empid1);
                //int appid2 = objEmpInfo2.ApplicantID_FK;
                //int empid2 = objEmpInfo2.EmployeeID;

                EmployeeDetailsInfo objEmpDetailsInfo4 = new EmployeeDetailsInfo();
                int empi1 = employeeID;
               objEmpDetailsInfo4 = (new EmployeeDetailsController()).Get(empi1);
               int empi2 = employeeID;
               int appi2 = objEmpDetailsInfo4.ApplicantID_FK;

              
                ArrayList ObjArr = new ArrayList();
                foreach (GridViewRow g1 in GViewQualification.Rows)
                {

                   // int empuser = objEmpDetailsInfo.EmployeeUserID_FK;
                    //int empid = objEmpDetailsInfo.EmployeeID;
                    

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

                    //EmployeeDetailsInfo objQualifEmpInfo2  = new EmployeeDetailsInfo();
                    ////int empid1 = objQualifEmpInfo2.EmployeeID;
                    ////objQualifEmpInfo2 = (new EmployeeDetailsController()).Get(empid1);
                    //int appid2 = objQualifEmpInfo2.ApplicantID_FK;
                    //int empid2 = objQualifEmpInfo2.EmployeeID;

                    EmployeeQualificationTableInfo objQualifEmpID = new EmployeeQualificationTableInfo();                    
                   // int empUser = objEmpDetailsInfo4.EmployeeUserID_FK;
                    objQualifEmpID.ApplicantID_FK = appi2;
                    objQualifEmpID.EmployeeID_FK = empi2;
                    (new EmployeeQualificationTableController()).QualificationTableEmpIDUpdate(objQualifEmpID);

                   //// EmployeeQualificationTableInfo objQualifEmpID2 = new EmployeeQualificationTableInfo();
                   //// //int empUser = objEmpDetailsInfo4.EmployeeUserID_FK;
                   ////objQualifEmpID.ApplicantID_FK = api2;
                   ////objQualifEmpID.EmployeeID_FK =   empi2;
                   ////    //objEmpDetailsInfo4.EmployeeID;
                   //// (new EmployeeQualificationTableController()).QualificationTableEmpIDUpdate(objQualifEmpID);

                   
                }

                //Saving ProfQualification

                ArrayList ObjProQArr = new ArrayList();
                foreach (GridViewRow x in GViewCert.Rows)
                {

                    //int empuser = objEmpDetailsInfo.EmployeeUserID_FK;
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

                    //EmployeeDetailsInfo objProfQualifEmpInfo2 = new EmployeeDetailsInfo();
                    //int empid1 = objProfQualifEmpInfo2.EmployeeID;
                    //objProfQualifEmpInfo2 = (new EmployeeDetailsController()).Get(empid1);
                    //int appid2 = objProfQualifEmpInfo2.ApplicantID_FK;
                    //int empid2 = objProfQualifEmpInfo2.EmployeeID;

                    EmployeeProfQualificationTableInfo objProfQualifEmpID = new EmployeeProfQualificationTableInfo();

                    objProfQualifEmpID.ApplicantID_FK = appi2;
                    objProfQualifEmpID.employeeID_FK = empi2;
                    //objProfQualifEmpID.ApplicantID_FK = Convert.ToInt32(appid);
                    //Convert.ToInt32(g1.Cells[4].Text);
                    //objProfQualifEmpID.employeeID_FK = objEmpDetailsInfo.EmployeeID;
                    (new EmployeeProfQualificationTableController()).ProfQualificationTableEmpIDUpdate(objProfQualifEmpID);

                }

                //Document

                foreach (GridViewRow g1 in GViewDoc.Rows)
                {

                    //int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;


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


                    //EmployeeDetailsInfo objDocEmpInfo2 = new EmployeeDetailsInfo();
                    //int empid1 = objDocEmpInfo2.EmployeeID;
                    //objDocEmpInfo2 = (new EmployeeDetailsController()).Get(empid1);
                    //int appid2 = objDocEmpInfo2.ApplicantID_FK;
                    //int empid2 = objDocEmpInfo2.EmployeeID;

                    EmployeeDocumentTableInfo objDocEmpID = new EmployeeDocumentTableInfo();
                    //int empUser = CurrentEmployeeDetail.EmployeeUserID_FK;
                    //int profQualfID = objProfQualifEmpID.ProfQualificationID;
                    objDocEmpID.ApplicantID_FK = appi2;
                    objDocEmpID.EmployeeID_Fk = empi2;
                   
                   (new EmployeeDocumentTableController()).DocumentTableEmpIDUpdate(objDocEmpID);

                                  }

                  if (employeeID > 0)
                {
                    LbEmpDetailsAdded.Visible = true;
                    LbEmpDetailsAdded.Text = " Detial Successfully Added";

                }
                else
                {
                    LbEmpDetailsAdded.Text = " Error! Details not added.";
                }

            }
        
        
        
            catch
            {

            }
        }

 

      /// <summary>
      /// ////////////////////////
      /// </summary>
      /// <param name="Customerid"></param>
      /// <param name="uname"></param>
      /// <returns></returns>
  //Creating Users/////////////////////////////

        private int CreateUser(int EmployeeID, string LastName, string Email)
        {
            int uId = 0;
            try
            {

                PortalSecurity objSecurity = new PortalSecurity();
                ModuleController objModules = new ModuleController();

                EmployeeDetailsInfo objEmployeeInfo = new EmployeeDetailsInfo();
                EmployeeDetailsController objEmployeeController = new EmployeeDetailsController();

               objEmployeeInfo = (new EmployeeDetailsController()).Get(EmployeeID);
                string EmployeePassword = "password";
                string username = Email;// objCustomerInfo.EMAIL;

                //UserInfo objUserInfo = new UserInfo();
               // UserController objUserController = new UserController();

                UserInfo objUserInfo = this.objUserController.GetUserByUsername(PortalId, username);

                //erInfo objUserInfo = objUserController.GetUserByUsername(PortalId, username);
                //UserInfo objUserInfo = this.objUserController.GetUserByUsername(PortalId, username);
                if (objUserInfo != null)
                    return -1;

                objUserInfo = new UserInfo();
                objUserInfo.PortalID = PortalId;
                objUserInfo.Profile.FirstName = objEmployeeInfo.FirstName;
                objUserInfo.Profile.LastName = objEmployeeInfo.LastName;
                
                //objUserInfo.Membership.Email = objCustomerInfo.EMAIL;
                //objUserInfo.Membership.Username = username;
                objUserInfo.Email = objEmployeeInfo.Email;
                objUserInfo.Username = username;
                objUserInfo.Membership.Password = EmployeePassword;
                

                objUserInfo.Membership.Approved = true;

                DotNetNuke.Security.Membership.UserCreateStatus bol;
                bol = UserController.CreateUser(ref objUserInfo);
                if (objUserInfo.UserID > 0)
                {
                    uId = objUserInfo.UserID;
                    objEmployeeInfo.EmployeeUserID_FK = objUserInfo.UserID;
                  //  (new EmployeeDetailsController()).Update(objEmployeeInfo);//////////////problem////////////////////////////
                    DotNetNuke.Services.Log.EventLog.EventLogController
        objEventLog = new DotNetNuke.Services.Log.EventLog.EventLogController();
                    objEventLog.AddLog(objUserInfo, PortalSettings, UserId,
        username,
        DotNetNuke.Services.Log.EventLog.EventLogController.EventLogType.USER_CREATED);

                    //send notification to portal administrator of new user  registration//
                    //(PortalSettings.DefaultLanguage, PortalSettings,  "EMAIL_USER_REGISTRATION_ADMINISTRATOR_SUBJECT", objNewUser),  
                    //DotNetNuke.Services.Localization.Localization.GetSystemMessage(PortalSettings.DefaultLanguage, PortalSettings, 
                    //  "EMAIL_USER_REGISTRATION_ADMINISTRATOR_BODY", objNewUser), "", "", "", "", "",  "");

                    //complete registration
                    string strMessage = "";
                    switch (PortalSettings.UserRegistration)
                    {
                        case
        (int)DotNetNuke.Common.Globals.PortalRegistrationType.PrivateRegistration:
                            strMessage =
        string.Format(DotNetNuke.Services.Localization.Localization.GetString("PrivateConfirmationMessage", this.LocalResourceFile),
        objEmployeeInfo.Email);
                            break;
                        case
        (int)DotNetNuke.Common.Globals.PortalRegistrationType.PublicRegistration:
                            objSecurity.UserLogin(username, EmployeePassword, PortalSettings.PortalId, PortalSettings.PortalName, "", false);
                            //objSecurity.UserLogin(username, "xportal",  
                            //rtalSettings.PortalId, PortalSettings.PortalName, "", false);

                            break;
                        case
        (int)DotNetNuke.Common.Globals.PortalRegistrationType.VerifiedRegistration:
                            strMessage =
        string.Format(DotNetNuke.Services.Localization.Localization.GetString("VerifiedConfirmationMessage", this.LocalResourceFile),
        objEmployeeInfo.Email);
                            break;
                    }


                    // int id = (objRoleController.GetRoleByName(PortalId, "Employee").RoleID);
                    int id = this.objRoleController.GetRoleByName(PortalId, "Employee").RoleID;
                    objRoleController.AddUserRole(PortalId, objUserInfo.UserID, id, Null.NullDate);

                    //objRoleController.AddUserRole(PortalId, objUserInfo.UserID, id, Null.NullDate);
                    //objStudentInfo.USER_ID = objUserInfo.UserID;
                    //objStudentController.Update(objStudentInfo);
                }
                else
                {
                    AspNetSecurity.MembershipCreateStatus UserRegistrationStatus;
                    UserRegistrationStatus =
        ((AspNetSecurity.MembershipCreateStatus)(objUserInfo.UserID * -1));
                    // UserController objUserController = new UserController();
                }
            }
            catch (Exception ex)
            {
                //XP.Logger.WriteLog(ex.Message + " ---> " + ex.StackTrace);
            }
            return uId;

        }

        //Employee Profile
        protected void hrEmpProfileIDList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelEmployeeProfile.Visible = true;

            EmployeeDetailsInfo objEmpProfile = new EmployeeDetailsInfo();
            int empID = Convert.ToInt32(hrEmpProfileIDList.SelectedValue);
            objEmpProfile = (new EmployeeDetailsController()).Get(empID);

            EmployeeDepartmentTableInfo objEmpDept = new EmployeeDepartmentTableInfo();
            int DeptID = objEmpProfile.Department_FK;
            objEmpDept = (new EmployeeDepartmentTableController()).Get(DeptID);


            EmployeePositionTableInfo objEmpPosition = new EmployeePositionTableInfo();
            int PositionID = objEmpProfile.PositionHeld_FK;
            objEmpPosition = (new EmployeePositionTableController()).Get(PositionID);


            EmployeeLevelTableInfo objEMpLevel = new EmployeeLevelTableInfo();
            int LevelID = objEmpProfile.EmployeeLevel_FK;
            objEMpLevel = (new EmployeeLevelTableController()).Get(LevelID);

            EmployeeWorkLocationInfo objEmpWorkLoc = new EmployeeWorkLocationInfo();
            int WorkLocationID = objEmpProfile.WorkLocation_FK;
            objEmpWorkLoc = (new EmployeeWorkLocationController()).Get(WorkLocationID);

            CountryTableInfo objEmpCountry = new CountryTableInfo();
            int CountryID = objEmpProfile.Nationality_FK;
            objEmpCountry = (new CountryTableController()).Get(CountryID);

            StateTableInfo objEmpState = new StateTableInfo();
            int StateID = objEmpProfile.StateOfOrigin_FK;
            objEmpState = (new StateTableController()).Get(StateID);

            LGATableInfo objEmpLGA = new LGATableInfo();
            int LgaID = objEmpProfile.LGA_FK;
            objEmpLGA = (new LGATableController()).Get(LgaID);

            UserInfo objEmpConfirmUser = new UserInfo();
            int confirmUserId = objEmpProfile.ConfirmedBy;
            objEmpConfirmUser = (new UserController()).GetUser(0, confirmUserId);
 



            LbHrEmpTitle.Text = objEmpProfile.Title;
            LbHrEmpFName.Text = objEmpProfile.FirstName;
            LbHrEmpMidName.Text = objEmpProfile.MiiddleName;
            LbHrEmpLName.Text = objEmpProfile.LastName;
            LbHrEmpMaritalStatus.Text = objEmpProfile.MaritalStatus;
            LbHrEmpGender.Text = objEmpProfile.Gender;
            LbHrEmpPhnNum.Text = objEmpProfile.PhoneNo;
            LbHrEmpEmail.Text = objEmpProfile.Email;
            LbHrEmpContAddr.Text = objEmpProfile.ContactAddress;
            LbHrEmpDOB.Text = objEmpProfile.DateOfBirth;
            LbHrEmpAge.Text = objEmpProfile.Age;
            //LbHrEmpGender.Text = CurrentEmployeeDetail.Gender;
            LbHrEmpReligion.Text = objEmpProfile.Religion;
            LbHrEmpStartDate.Text = objEmpProfile.StartDate;
            EmpProfilePassport.ImageUrl = "~/images/" + objEmpProfile.Passport.Substring(objEmpProfile.Passport.LastIndexOf('/') + 1);



            LbHrEmpCountry.Text = objEmpCountry.CountryName;
            LbHrEmpState.Text = objEmpState.StateName;
            LbHrEmpLGA.Text = objEmpLGA.LgaName;

            LbHrEmpDept.Text = objEmpDept.DeptName;
            LbHrEmpPosition.Text = objEmpPosition.PositionName;
            LbHrEmpLevel.Text = objEMpLevel.LevelName;
            LbHrEmpWorkLoc.Text = objEmpWorkLoc.LocationName + "," + " " + objEmpWorkLoc.LocationAddress;


            // Collecting Employee spouse details

            LbSpouseNames.Text = objEmpProfile.SpouseNames;
            LbHrEmpSpousePhoNo.Text = objEmpProfile.SpousePhoneNo;
            LbHrEmpSpouseAddress.Text = objEmpProfile.SpouseAddress;
            LbHrEmpSpouseEmailAddr.Text = objEmpProfile.SpouseEmail;
            LbHrEmpSpouseOccupation.Text = objEmpProfile.SpouseOccupation;
            LbHrEmpSpouseEmployer.Text = objEmpProfile.SpouseEmployerNames;

            //Collecting Employee NextOfKin details

            LbHrEmpNextOfKinNames.Text = objEmpProfile.NxtOfKinLName + " " + objEmpProfile.NxtOfKinMidName + " " + objEmpProfile.NxtOfKinFName;
            LbHrEmpNextOfKinRelationship.Text = objEmpProfile.NxtOfKinRelationship;
            LbHrEmpNextOfKinEmail.Text = objEmpProfile.NxtOfKinEmail;
            LbHrEmpNextOfKinAddrs.Text = objEmpProfile.NxtOfKinAddress;
            LbHrEmpNextOfKinOccupation.Text = objEmpProfile.NxtOfKinOccupation;
            LbHrEmpNextOfKinPhnNum.Text = objEmpProfile.NxtOfKinPhoneNo;

            //Collecting Employee status Info

            LbHrEmpStatus.Text = objEmpProfile.EmployeeStatus;
            LbHrEmpConfimedDate.Text = objEmpProfile.ConfirmationDate;
            LbHrEmpConfirmedBy.Text = objEmpConfirmUser.DisplayName;

            //Collecting Employee Bank Info

            LbHrEmpBankNames.Text = objEmpProfile.BankName;
            LbHrEmpAccountName.Text = objEmpProfile.AccountName;
            LbHrEmpAcctNumber.Text = objEmpProfile.AccountNo;
            LbHrEmpGuarrantorName.Text = objEmpProfile.GuarrantorNames;

            //Collecting Employee Referee Info

            LbHrEmpReferee1Names.Text = objEmpProfile.Refree1Names;
            LbHrEmpReferee1Occupation.Text = objEmpProfile.Refree1Occupation;
            LbHrEmpReferee1Email.Text = objEmpProfile.Refree1Email;
            LbHrEmpReferee1PhnNum.Text = objEmpProfile.Refree1PhoneNum;
            LbHrEmpReferee1Addr.Text = objEmpProfile.Refree1ContactAddr;



            LbHrEmpReferee2Names.Text = objEmpProfile.Refree2Names;
            LbHrEmpReferee2Occupation.Text = objEmpProfile.Refree2Occupation;
            LbHrEmpReferee2PhnNum.Text = objEmpProfile.Refree2PhoneNum;
            LbHrEmpReferee2Email.Text = objEmpProfile.Refree2Email;
            LbHrEmpReferee2Addr.Text = objEmpProfile.Refree2ContactAddr;





            //EmpProfileQualification
           // EmployeeDetailsInfo objEmpProfile = new EmployeeDetailsInfo();
           // int empID = Convert.ToInt32(hrEmpProfileIDList.SelectedValue);
           // objEmpProfile = (new EmployeeDetailsController()).Get(empID);

            //int empuser = objEmpProfile.EmployeeUserID_FK;
            //   Convert.ToInt32(hrEmpProfileIDList.SelectedValue);
            int empID_FK = empID;
            int applicantID = objEmpProfile.ApplicantID_FK;

            ArrayList objProfileQaulifList = new ArrayList();
            objProfileQaulifList = (new EmployeeQualificationTableController()).ApprovedQualifGetByEmployeeDetails(empID_FK);

            if (objProfileQaulifList.Count > 0)
            {

                GViewHrEmpProfileQualification.Visible = true;
                GViewHrEmpProfileQualification.DataSource = objProfileQaulifList;
                GViewHrEmpProfileQualification.DataBind();

            }
            ArrayList objProfileProfQaulifList = new ArrayList();
            objProfileProfQaulifList = (new EmployeeProfQualificationTableController()).ApprovedProfQualifGetByEmployeeDetails(empID_FK);

            if (objProfileProfQaulifList.Count > 0)
            {

                GViewHrEmpProfileCert.Visible = true;
                GViewHrEmpProfileCert.DataSource = objProfileProfQaulifList;
                GViewHrEmpProfileCert.DataBind();

            }


            ArrayList objProfileDocList = new ArrayList();
            objProfileDocList = (new EmployeeDocumentTableController()).ApprovedDocGetByEmployeeDetails(empID_FK);

            if (objProfileDocList.Count > 0)
            {

                GViewHrEmpProfileDoc.Visible = true;
                GViewHrEmpProfileDoc.DataSource = objProfileDocList;
                GViewHrEmpProfileDoc.DataBind();

            }



        }







        //Employee Confirmation

        #region
        protected void confirmEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeDetailsInfo objEmpDetail1 = new EmployeeDetailsInfo();
            int confirmEmpID = Convert.ToInt32(confirmEmployeeList.SelectedValue);
            objEmpDetail1 = (new EmployeeDetailsController()).Get(confirmEmpID);

            UserInfo objConfirmByUser = new UserInfo();
            //int objConfirmByUser = objTransferEmpDetails1.EmployeeUserID_FK;
            objConfirmByUser = (new UserController()).GetUser(0, UserId);
 

           //  UserInfo objUserId1  = new UserInfo();
           // //int userid = objEmpDetail1.EmployeeUserID_FK;
           ////  objUserId1=(new EmployeeDetailsController()).GetByUserID(UserId);
           //  (new EmployeeDetailsController()).GetByUserID(UserId);

         
            LbConfirmStartDate.Text = objEmpDetail1.StartDate;
            LbConfirmStartDate.Visible = true;
            string curDate = DateTime.Now.ToShortDateString();
            LbConfrimationDate.Text = curDate;
            LbConfrimationDate.Visible = true;
            LbConfirmedBy.Text = objConfirmByUser.DisplayName;
            LbConfirmedBy.Visible = true;


            DateTime sDate = DateTime.Parse(LbConfirmStartDate.Text);
            DateTime cDate = DateTime.Parse(LbConfrimationDate.Text);

            int numOfdays = (cDate - sDate).Days;
            LbConfrimDuration.Text = numOfdays.ToString();
            LbConfrimDuration.Visible = true;

           int  minDur = 1;
            if(numOfdays >= minDur)
            {
                LbConfirmDuration.Text = "Minimum Duration for Confirmation reached, you can now confirm this employee";
                LbConfirmDuration.Visible = true;

            }
             else
            {
                LbConfirmDuration.Text = "Minimum Duration Not reached, you can not confirm this employee";
                LbConfirmDuration.Visible = true;
            }

     
        }
        protected void confirmBtn_Click(object sender, EventArgs e)
        {
            EmployeeDetailsInfo objEmpConfirm = new EmployeeDetailsInfo();
            int empID = Convert.ToInt32(confirmEmployeeList.SelectedValue);
            objEmpConfirm = (new EmployeeDetailsController()).Get(empID);

            UserInfo objConfirmByUser = new UserInfo();
            //int objConfirmByUser = objTransferEmpDetails1.EmployeeUserID_FK;
            objConfirmByUser = (new UserController()).GetUser(0, UserId);
 


            //EmployeeDetailsInfo objEmpConfirmby = new EmployeeDetailsInfo();
            //int EmpConfirmby = employee
            //objEmpConfirm = (new EmployeeDetailsController()).Get(EmpConfirmby);

            
           

            ////UserInfo objUserId2 = new UserInfo();
            ////int userId2 = objEmpConfirm.EmployeeUserID_FK;
            ////(new EmployeeDetailsController()).GetByUserID(UserId);

            //DateTime startDate = Convert.ToDateTime(LbStartDate.Text);
            //int startDay = startDate.Day;
            //int startMonth = startDate.Month;
            //int startYear = startDate.Year;

            //DateTime currentDate = Convert.ToDateTime(LbConfrimationDate.Text);
            //int curDay = currentDate.Day;
            //int curMonth = currentDate.Month;
            //int curYear = currentDate.Year;
            //TimeSpan duration = currentDate.Subtract(startDate);

            DateTime sDate = DateTime.Parse(LbConfirmStartDate.Text);
            DateTime cDate = DateTime.Parse(LbConfrimationDate.Text);

            int numOfdays = (cDate - sDate).Days;
          

            int minDuration = 1;
       
            if (numOfdays >= minDuration)
            {
               
                objEmpConfirm.EmployeeID = empID;
                objEmpConfirm.ConfirmedBy = UserId;
                objEmpConfirm.ConfirmationDate = LbConfrimationDate.Text;
                  
                (new EmployeeDetailsController()).UpdateConfirmation(objEmpConfirm);

                if (objEmpConfirm.EmployeeID == empID)
                {
                    LbConfirmSuccessful.Visible = true;
                    LbConfirmSuccessful.Text = "Confirmation Successful";
                }

                else
                {
                    LbConfirmSuccessful.Visible = true;
                    LbConfirmSuccessful.Text = "Confirmation Not Successfully ";
                }
            }

           
        }

        protected void confirmListBtn_Click(object sender, EventArgs e)
        {
            ArrayList objListConfiredEmployee = new ArrayList();
            objListConfiredEmployee = (new EmployeeDetailsController()).ConfirmedEmployeeList();

            if (objListConfiredEmployee.Count > 0)
            {
                GViewConfirmedList.DataSource = objListConfiredEmployee;
                GViewConfirmedList.DataBind();
                GViewConfirmedList.Visible = true;
            }
        }

        #endregion



        // HR Approval Module



        #region
        protected void hrApproveQualifMenuBtn_Click(object sender, EventArgs e)
        {
            PanelApproveQualif.Visible = true;
        }
        protected void HRQualifEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
             ArrayList objApproveQualif = new ArrayList();
            int empID = Convert.ToInt32(hrUnApprovedQualifList.SelectedValue);
            objApproveQualif = (new EmployeeQualificationTableController()).QualificationUnApprovedGetByEmployeeDetails(empID);

            if (objApproveQualif.Count > 0)
            {
                GViewHrEmpApproveQualif.DataSource = objApproveQualif;
                GViewHrEmpApproveQualif.DataBind();
                GViewHrEmpApproveQualif.Visible = true;
                QualifApproveBtn.Visible = true;
                QualifFinishBtn.Visible = true;
            }
            
                
        }


        protected void QualifApproveBtn_Click(object sender, EventArgs e)
        {
            
              foreach (GridViewRow x in GViewHrEmpApproveQualif.Rows)
            {
                // declare a variable as textbox

                TextBox aid = new TextBox();
                TextBox eid = new TextBox();

                // find the textbox containing the applicantID on the gridview 

                aid = (TextBox)x.FindControl("txtAppID");
                eid = (TextBox)x.FindControl("txtEmpID");
                string appid = aid.Text;
                string empid = eid.Text;
             

                CheckBox c = new CheckBox();
                c = (CheckBox)x.FindControl("CheckBoxQualif");
                if (c.Checked == true)
                {
                    // lblInterMsg.Text = id;
                    try
                    {
                        // Update HrApproval Statuson the EmployeeQualificationTable
                        EmployeeQualificationTableInfo objQualifInfo = new EmployeeQualificationTableInfo();
                        objQualifInfo.EmployeeID_FK = Convert.ToInt32(empid);
                        objQualifInfo.ApplicantID_FK = Convert.ToInt32(appid);
                        objQualifInfo.HrApproval = "Approved";
                        new EmployeeQualificationTableController().HrApprovalUpdate(objQualifInfo);
                        
                         EmployeeQualificationTableInfo objQualifInfos = new EmployeeQualificationTableInfo();
                        int ee = Convert.ToInt32(empid);
                         objQualifInfos = (new EmployeeQualificationTableController()).Get(ee);
                         LbHrQaulifHrApproval.Text = objQualifInfos.HrApproval;
                         LbHrQaulifHrApproval.Visible = true;


                        //if (objQualifInfo.EmployeeID_FK == Convert.ToInt32(empid))
                        if (objQualifInfo.HrApproval != null )
                        {
                            ///Alhaja lo so be ooooooo

                            ArrayList objApproveQualif = new ArrayList();
                            //int empID = Convert.ToInt32(hrUnApprovedQualifList.SelectedValue);
                            objApproveQualif = (new EmployeeQualificationTableController()).QualificationUnApprovedGetByEmployeeDetails(ee);

                            if (objApproveQualif.Count > 0)
                            {
                                GViewHrEmpApproveQualif.DataSource = objApproveQualif;
                                GViewHrEmpApproveQualif.DataBind();
                                GViewHrEmpApproveQualif.Visible = true;
                                QualifApproveBtn.Visible = true;
                                QualifFinishBtn.Visible = true;
                            }
                            LbHrQaulifApproved.Visible = true;
                            LbHrQaulifApproved.Text = "Qualification Approved Successfully";

                        }

                        else
                        {

                            LbHrQaulifApproved.Visible = true;
                            LbHrQaulifApproved.Text = "Qualification Not Approved";
                        }

                    }

                    catch
                    {

                    }

                }

                }
        }
    //    protected   HRQualifEmployeeList_SelectedIndexChanged;
    

        //Certification

        protected void hrApproveCertMenuBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 6;
            PanelHrApproveCert.Visible = true;
        }
        protected void hrUnApprovedCertList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList objApproveCert = new ArrayList();
            int empID = Convert.ToInt32(hrUnApprovedCertList.SelectedValue);
            objApproveCert = (new EmployeeProfQualificationTableController()).ProfQualificationUnApprovedGetByEmployeeDetails(empID);

            if (objApproveCert.Count > 0)
            {

                GViewHrEmpApproveCert.DataSource = objApproveCert;
                GViewHrEmpApproveCert.DataBind();
                GViewHrEmpApproveCert.Visible = true;
                hrCertApproveBtn.Visible = true;
                hrCertFinishBtn.Visible = true;
            }
        }
     //   protected void hrUnApprovedCertList_SelectedIndexChanged();



        protected void hrCertApproveBtn_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow x in GViewHrEmpApproveCert.Rows)
            {
                
                // declare a variable as textbox

                TextBox aid = new TextBox();
                TextBox eid = new TextBox();

                // find the textbox containing the applicantID on the gridview 

                aid = (TextBox)x.FindControl("txtCertAppID");
                eid = (TextBox)x.FindControl("txtCertEmpID");
                string appid = aid.Text;
                string empid = eid.Text;
             

                CheckBox c = new CheckBox();
                c = (CheckBox)x.FindControl("CheckBoxCert");
                if (c.Checked == true)
                {
                    // lblInterMsg.Text = id;
                    try
                    {
                        // Update HrApproval Statuson the EmployeeQualificationTable
                        EmployeeProfQualificationTableInfo objCertInfo = new EmployeeProfQualificationTableInfo();
                        objCertInfo.employeeID_FK = Convert.ToInt32(empid);
                        objCertInfo.ApplicantID_FK = Convert.ToInt32(appid);
                        objCertInfo.HrApproval = "Approved";
                        new EmployeeProfQualificationTableController().HrApprovalUpdate(objCertInfo);

                        if (objCertInfo.employeeID_FK== Convert.ToInt32(empid))
                        {
                            LbCertApproved.Visible = true;
                            LbCertApproved.Text = "Professional Qualification Approved Successfully";

                        }

                        else
                        {

                            LbCertApproved.Visible = true;
                            LbCertApproved.Text = " Professional Qualification Not Approved";
                        }

                    }

                    catch
                    {

                    }

                }

            }
        }

     //   protected void hrUnApprovedCertList_SelectedIndexChanged;

            //Document
            
        protected void hrApproveDocMenuBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 7;
                PanelHrApproveDoc.Visible = true;
        }


        protected void hrUnApprovedDocList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList objApproveDoc = new ArrayList();
            int empID = Convert.ToInt32(hrUnApprovedDocList.SelectedValue);
            objApproveDoc = (new EmployeeDocumentTableController()).DocumentUnApprovedGetByEmployeeDetails(empID);

            if (objApproveDoc.Count > 0)
            {

                GViewHrEmpApproveDoc.DataSource = objApproveDoc;
                GViewHrEmpApproveDoc.DataBind();
                GViewHrEmpApproveDoc.Visible = true;
                hrDocApproveBtn.Visible = true;
                hrDocApprovFinshBtn.Visible = true;
                


            }
        }

        protected void hrDocApproveBtn_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow x in GViewHrEmpApproveDoc.Rows)
            {
                //  
                // declare a variable as textbox

                TextBox aid = new TextBox();
                TextBox eid = new TextBox();

                // find the textbox containing the applicantID on the gridview 

                aid = (TextBox)x.FindControl("txtDocAppID");
                eid = (TextBox)x.FindControl("txtDocEmpID");
                string appid = aid.Text;
                string empid = eid.Text;
             

                CheckBox c = new CheckBox();
                c = (CheckBox)x.FindControl("CheckBoxDoc");
                if (c.Checked == true)
                {
                    // lblInterMsg.Text = id;
                    try
                    {
                        // Update HrApproval Statuson the EmployeeQualificationTable
                        EmployeeDocumentTableInfo objDocInfo = new EmployeeDocumentTableInfo();
                        objDocInfo.EmployeeID_Fk = Convert.ToInt32(empid);
                        objDocInfo.ApplicantID_FK = Convert.ToInt32(appid);
                        objDocInfo.HrApproval = "Approved";
                        new EmployeeDocumentTableController().HrApprovalUpdate(objDocInfo);

                        if (objDocInfo.EmployeeID_Fk == Convert.ToInt32(empid))
                        {
                            LbDocApproved.Visible = true;
                            LbDocApproved.Text = "Document Approved Successfully";

                        }

                        else
                        {

                            LbDocApproved.Visible = true;
                            LbDocApproved.Text = "Document Not Approved";
                        }

                    }

                    catch
                    {

                    }

                }

            }
        }

        
        #endregion




        //Tranfer Module

        #region
        protected void transferEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {

            EmployeeDetailsInfo objTransferEmpDetails1 = new EmployeeDetailsInfo();
            int transferEmpID = Convert.ToInt32(transferEmployeeList.SelectedValue);
            objTransferEmpDetails1 = (new EmployeeDetailsController()).Get(transferEmpID);

            EmployeeDepartmentTableInfo objTransferEmpDept = new EmployeeDepartmentTableInfo();
            int empDept = objTransferEmpDetails1.Department_FK;
            objTransferEmpDept = (new EmployeeDepartmentTableController()).Get(empDept);

            EmployeeWorkLocationInfo objTransferEmpWorkLoc = new EmployeeWorkLocationInfo();
            int empWorkLoc = objTransferEmpDetails1.Department_FK;
            objTransferEmpWorkLoc = (new EmployeeWorkLocationController()).Get(empWorkLoc);

            UserInfo objTransferUser = new UserInfo();
            int transferUser = objTransferEmpDetails1.EmployeeUserID_FK;
            objTransferUser = (new UserController()).GetUser(0, transferUser);
            
            
            LbTransferPreDept.Text = objTransferEmpDept.DeptName;
            LbTransferPreDept.Visible = true;
            LbTransferPreWorkLoc.Text = objTransferEmpWorkLoc.LocationName + ", " + objTransferEmpWorkLoc.LocationAddress;
            LbTransferPreWorkLoc.Visible = true;
            string myDate = DateTime.Now.ToShortDateString();
            LbTransferDate.Text = myDate;
            LbTransferDate.Visible = true;
            LbTransferedBy.Text = objTransferUser.DisplayName;
            LbTransferedBy.Visible = true;
            
                    }
       
        protected void TransferBtn_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeDetailsInfo objTransferEmpDetails1 = new EmployeeDetailsInfo();
                int transferEmpID1 = Convert.ToInt32(transferEmployeeList.SelectedValue);
                objTransferEmpDetails1 = (new EmployeeDetailsController()).Get(transferEmpID1);

                EmployeeDepartmentTableInfo objTransferEmpDept = new EmployeeDepartmentTableInfo();
                int empDept1 = objTransferEmpDetails1.Department_FK;
                objTransferEmpDept = (new EmployeeDepartmentTableController()).Get(empDept1);

                EmployeeWorkLocationInfo objTransferEmpWorkLoc = new EmployeeWorkLocationInfo();
                int empWorkLoc1 = objTransferEmpDetails1.WorkLocation_FK;
                objTransferEmpWorkLoc = (new EmployeeWorkLocationController()).Get(empWorkLoc1);

                UserInfo objTransferUser = new UserInfo();
                int transferUser = objTransferEmpDetails1.EmployeeUserID_FK;
                objTransferUser = (new UserController()).GetUser(0, transferUser);
 



                EmployeeTransferTableInfo objTransferInfo = new EmployeeTransferTableInfo();

                objTransferInfo.PreviousDept = empDept1;
                //objTransferEmpDetails1.Department_FK;
                objTransferInfo.NewDept = Convert.ToInt32(transferNewDeptList.SelectedValue);
                objTransferInfo.PrevWorkLocation = empWorkLoc1;
                //objTransferEmpDetails1.WorkLocation_FK;
                objTransferInfo.NewWorkLcation = Convert.ToInt32(transferNewWokLocList.SelectedValue);
                objTransferInfo.EmployeeID_FK = transferEmpID1;
                    //Convert.ToInt32(transferEmployeeList.SelectedValue);
                string myDate = DateTime.Now.ToShortDateString();
                objTransferInfo.TransferDate = myDate;
                objTransferInfo.TransferedBy = objTransferUser.UserID;
               

                int TransferID = (new EmployeeTransferTableController()).Add(objTransferInfo);
                

               
                string preDept = LbTransferPreDept.Text;
                string newDept = transferNewDeptList.SelectedItem.ToString();
                string preLoc =  LbTransferPreWorkLoc.Text;
                string newLoc = transferNewWokLocList.SelectedItem.ToString();

//Updating EmployeeTable with Transfer details

                if (TransferID > 0)
                {
                    EmployeeTransferTableInfo objTransferInfo2 = new EmployeeTransferTableInfo();
                    int tranEmpID = TransferID;
                    objTransferInfo2= (new EmployeeTransferTableController()).Get(tranEmpID);

                    EmployeeWorkLocationInfo objTransferEmpWorkLoc2 = new EmployeeWorkLocationInfo();
                int empWorkLoc2 = objTransferInfo2.NewWorkLcation;
                objTransferEmpWorkLoc2 = (new EmployeeWorkLocationController()).Get(empWorkLoc2);

                    
                    int newWokLoc = objTransferInfo2.NewWorkLcation;
                    int newDept2 = objTransferInfo2.NewDept;

                    EmployeeDetailsInfo objemployee2 = new EmployeeDetailsInfo();
                    objemployee2.EmployeeID = transferEmpID1;
                    objemployee2.Department_FK = newDept2;
                    objemployee2.WorkLocation_FK = newWokLoc;
                    (new EmployeeDetailsController()).TransferUpdate(objemployee2);


                    LbTransferSuccessful.Text = "Employee " + objTransferEmpDetails1.LastName + " " + "has been moved from " + preLoc + " " + "to " + newLoc + ", " + objTransferEmpWorkLoc2.LocationAddress;
                    LbTransferSuccessful.Visible = true;
                }


                //if (TransferID > 0)
                //{
                //    LbTransferSuccessful.Text = "Employee " + objTransferEmpDetails1.LastName + "has been moved from " + preLoc + "to" + newLoc;
                //}

                else
                {
                    LbTransferSuccessful.Text = " Transfer Not Successful";
                    LbTransferSuccessful.Visible = true;
                }

            }

            catch { }

        }
        #endregion

        protected void queryEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        protected void LinkQuery_Click(object sender, EventArgs e)
        {
            PanelQuery.Visible = true;
            PanelDiscipline.Visible = false;
            GVHRQuery.Visible = false;
            lblListQuery.Visible = false;

        }
        protected void LinkDiscipline_Click(object sender, EventArgs e)
        {
            PanelQuery.Visible = false ;
            PanelDiscipline.Visible = true;
        }
        protected void queryDeptList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int deptId = Convert.ToInt32(queryDeptList.SelectedValue);
            ArrayList EmpdeptInfo = new ArrayList();
            EmpdeptInfo = (new EmployeeDetailsController()).GetByEmployeeDepartmentTable(deptId);
            if (EmpdeptInfo.Count > 0)
            {
                queryEmployeeList.DataSource = EmpdeptInfo;
                queryEmployeeList.DataTextField = "EmployeeNum";
                queryEmployeeList.DataValueField = "EmployeeID";
                queryEmployeeList.DataBind();
                queryEmployeeList.Items.Insert(0, new ListItem("***Please select***", "-1"));


            }
        }


        #region"Query"
        protected void btnSendQuery_Click(object sender, EventArgs e)
        {
            EmployeeQueryTableInfo objQuery = new EmployeeQueryTableInfo();
            objQuery.QueryReceivedBy = Convert.ToInt32(queryEmployeeList.SelectedValue);
            objQuery.QueryTitle = txtQueryTitle.Text;
            objQuery.Description = txtQueryDesc.Text;
            if (QueryFileUpload.HasFile)
            {
               string filepath = HttpContext.Current.Server.MapPath("~/QueryLetters/").ToString();
                QueryFileUpload.SaveAs(filepath + "\\" + QueryFileUpload.FileName.ToString());
                objQuery.QueryLetter = "~/QueryLetters/" + "/" + QueryFileUpload.FileName.ToString();

            }
            objQuery.IssueDate=DateTime.Now.ToString();

            // get the  user that login
             UserInfo objIssuedByUser = new UserInfo();
            objIssuedByUser = (new UserController()).GetUser(0, UserId);
            objQuery.QueryIssuedBy = objIssuedByUser.UserID;

            int queryId = (new EmployeeQueryTableController()).AddQuery(objQuery);
            if (queryId > 0)
            {
                lblQueryIssueReport.Text = "Query send succesfully";
            }
            else
            {
                lblQueryIssueReport.Text = "Query fail";
            }

            //string uploadfolderpath = "~/QueryLetters/";
            //    filepath2 = HttpContext.Current.Server.MapPath(uploadfolderpath).ToString();
            //    UploadPassport.SaveAs(filepath2 + "\\" + filename);
            //    Image1.ImageUrl = "~/Image/" + "/" + UploadPassport.FileName.ToString();
            //    lblPassportName.Text = filename;
            //    Session["passportPath"] = filepath2;
        }
#endregion


        protected void GVHRQuery_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "View")
            {

                EmployeeQueryTableInfo objQuery = new EmployeeQueryTableInfo();
                objQuery = (new EmployeeQueryTableController()).Get(Convert.ToInt32(e.CommandArgument));
                int queryId = objQuery.QueryID;
                ViewState.Add("queryId", queryId);
                lblDisEmpNum.Text = objQuery.EmployeeNum;
                lblDisQueryTitle.Text = objQuery.QueryTitle;
                lblDisQueryDescription.Text = objQuery.Description;
                lblDisQueryIssueDay.Text = objQuery.IssueDate;
                lblDisQueryResponse.Text = objQuery.EmployeeResponse;
                lblDisResponseDate.Text = objQuery.ResponseDate;
               
                UserInfo objUser=new UserInfo();
                objUser=(new UserController()).GetUser(0, UserId);
                lblDisciplineBy.Text = objUser.LastName + " " + objUser.FirstName;
                lblDisciplineDate.Text = DateTime.Now.ToString();

                ArrayList DisciplineType = new ArrayList();
                DisciplineType = new EmployeeDisciplineTableController().List();
                if (DisciplineType.Count > 0)
                {
                    ddlDisciplineType.DataSource = DisciplineType;
                    ddlDisciplineType.DataValueField = "DisciplineID";
                    ddlDisciplineType.DataTextField = "DiscplineDescription";
                    ddlDisciplineType.DataBind();
                    ddlDisciplineType.Visible = true;
                }
                ddlDisciplineType.Items.Insert(0, new ListItem("***Please select***", "-1"));
                lblDisciplineDate.Text = DateTime.Now.ToString();
                PanelDiscipline.Visible = true;
                PanelQuery.Visible = false;
            }
        }
        protected void Button9_Click(object sender, EventArgs e)
        {
            PanelDiscipline.Visible = false;
        }
        protected void btnSendDisciplined_Click(object sender, EventArgs e)
        {
            EmployeeQueryTableInfo objQuery = new EmployeeQueryTableInfo();
            int QueryID = Convert.ToInt32(ViewState["queryId"]);
            objQuery.QueryID = QueryID;
            objQuery.DisciplineDate = DateTime.Now.ToString();         
            UserInfo objUser = new UserInfo();
            objUser = (new UserController()).GetUser(0, UserId);
            objQuery.DisciplinedBy = objUser.UserID;
            objQuery.DisciplineDetails = txtDisciplineDescription.Text;
            objQuery.DiscipliineType_FK = Convert.ToInt32(ddlDisciplineType.SelectedValue);
            if (DisciplinedLetterUpload.HasFile)
            {
                string filepath = HttpContext.Current.Server.MapPath("~/QueryLetters/").ToString();

               // lblDisciplineLetterName.Text = DisciplinedLetterUpload.FileName;
                DisciplinedLetterUpload.SaveAs(filepath + "\\" + DisciplinedLetterUpload.FileName.ToString());
                objQuery.DisciplineLetter = "~/QueryLetters/" + "/" + DisciplinedLetterUpload.FileName.ToString();
            }
            (new EmployeeQueryTableController()).UpdateQueryDiscipline(objQuery);

        }
}
}


       






