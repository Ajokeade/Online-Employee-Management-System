using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Reflection;
using System.Web.UI.WebControls;

using DotNetNuke;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using System.Web.SessionState;
using System.IO;
using Bilikis.HRManagementSystem;


using DotNetNuke.Entities.Users;
using DotNetNuke.Security.Roles;
using DotNetNuke.Security.Membership;
using AspNetSecurity = System.Web.Security;

namespace Bilikis.HRManagementSystem
{
   // public partial class SupervisorPage : PortalModuleBase, IActionable
    public partial class SupervisorPage : Bilikis.ModuleBase.ModuleBase, IActionable
    {
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

        UserController objUserController = new UserController();

      //  RoleController objRoleController = new RoleController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MViewSupervisor.ActiveViewIndex = 0;
              //  ArrayList objEmployee = new ArrayList();
              ////  objEmployee= (new EmployeeDetailsController()).Get(int emp);
              // // int supervisorId= c
              //  int supervisorId = CurrentEmployeeDetail.EmployeeID;
              //  objEmployee = (new EmployeeDetailsController()).GetBySupervisor(supervisorId);
              //  if (objEmployee.Count > 0)
              //  {
              //      queryEmployeeList.DataSource = objEmployee;
              //      queryEmployeeList.DataTextField = "EmployeeNum";
              //      queryEmployeeList.DataValueField = "EmployeeID";
              //      queryEmployeeList.DataBind();
              //  }

            }

        }
        protected void welEmplomentBtn_Click(object sender, EventArgs e)
        {
            MViewSupervisor.ActiveViewIndex = 1;
        }
       
       
        protected void selfAppraisalBtn_Click1(object sender, EventArgs e)
        {
            MViewSupervisor.ActiveViewIndex = 2;

        }
        protected void queryHomeBtn_Click(object sender, EventArgs e)
        {
            MViewSupervisor.ActiveViewIndex = 0;
        }
        protected void queryBtn_Click(object sender, EventArgs e)
        {
            MViewSupervisor.ActiveViewIndex = 1;
        }
        protected void appraisalHomeBtn_Click(object sender, EventArgs e)
        {
            MViewSupervisor.ActiveViewIndex = 0;
        }
        protected void supervisorQueryBtn_Click(object sender, EventArgs e)
        {







            
            ArrayList objEmployee = new ArrayList();
            //  objEmployee= (new EmployeeDetailsController()).Get(int emp);
            // int supervisorId= c
            int supervisorId = CurrentEmployeeDetail.EmployeeID;
            objEmployee = (new EmployeeDetailsController()).GetBySupervisor(supervisorId);
            if (objEmployee.Count > 0)
            {
                queryEmployeeList.DataSource = objEmployee;
                queryEmployeeList.DataTextField = "EmployeeNum";
                queryEmployeeList.DataValueField = "EmployeeID";
                queryEmployeeList.DataBind();
            }
            queryEmployeeList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

            lblQueryIssueDate.Text = DateTime.Now.ToString();

            lblQueryIssueDate.Visible = true;
            UserInfo objIssuedByUser = new UserInfo();
            objIssuedByUser = (new UserController()).GetUser(0, UserId);

            lblQueryIssuedBy.Text = objIssuedByUser.LastName + " " + objIssuedByUser.FirstName;

             //List queries sent by Supervisor
            int IssuedBy = objIssuedByUser.UserID;
            ArrayList objQuery = new ArrayList();

            objQuery = (new EmployeeQueryTableController()).GetByUsers(IssuedBy);
            if (objQuery.Count > 0)
            {
                GVSupervisorQuery.DataSource = objQuery;
                GVSupervisorQuery.DataBind();
                GVSupervisorQuery.Visible = true;
               // lblListQuery.Visible = true;
            }
            else
            {
              //  lblListQuery.Visible = false;
                GVSupervisorQuery.Visible = false;
            }

            MViewSupervisor.ActiveViewIndex = 1;
        }
        protected void supervisorAppraisalBtn_Click(object sender, EventArgs e)
        {
            MViewSupervisor.ActiveViewIndex = 2;
        }
        protected void txtQueryReason_TextChanged(object sender, EventArgs e)
        {

        }
        protected void issueQueryBtn_Click(object sender, EventArgs e)
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
            objQuery.IssueDate = DateTime.Now.ToString();

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
        }
        protected void queryEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int employeeID = Convert.ToInt32(queryEmployeeList.SelectedValue);
            EmployeeDetailsInfo objEmployee = new EmployeeDetailsInfo();
            objEmployee = (new EmployeeDetailsController()).Get(employeeID);
            lblEmpName.Text = objEmployee.LastName + " " + objEmployee.FirstName;
            lblEmpDept.Text = objEmployee.DeptName;
            lblEmpPosition.Text = objEmployee.PositionName;
            lblEmpLevel.Text = objEmployee.LevelName;
            

        }
        protected void GVSupervisorQuery_RowCommand(object sender, GridViewCommandEventArgs e)
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

                UserInfo objUser = new UserInfo();
                objUser = (new UserController()).GetUser(0, UserId);
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
        protected void Button10_Click(object sender, EventArgs e)
        {
            PanelQuery.Visible = true;
        }
        protected void Button11_Click(object sender, EventArgs e)
        {
            PanelQuery.Visible = false;
        }
}
}