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
using System.Net.Mail;
using System.Text.RegularExpressions;
using Bilikis.HRManagementSystem;



// copied namepace
using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Text;
using System.Web.SessionState;



namespace Bilikis.HRManagementSystem
{
    public partial class InterviewPage : PortalModuleBase, IActionable
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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MViewInterview.ActiveViewIndex = 0;
                // day dropdownlist
                var day = new ArrayList();
                day.Add("Day");
                for (var i = 1; i <= 31; i++)
                {
                    day.Add(i);
                }
                interviewDayList.DataSource = day;
                interviewDayList.DataBind();
                ddlInterviewDay.DataSource = day;
                ddlInterviewDay.DataBind();
                ddlDay.DataSource = day;
                ddlDay.DataBind();

                // year dropdownlist
                var al = new ArrayList();
                al.Add("Year");
                for (var i = 2018; i >= 1900; i--)
                {
                    al.Add(i);
                }

                interviewYearList.DataSource = al;
                interviewYearList.DataBind();
                ddlInterviewYear.DataSource = al;
                ddlInterviewYear.DataBind();
                ddlYear.DataSource = al;
                ddlYear.DataBind();


                ddlLevel.Items.Insert(0, new ListItem("---Please Select---", "-1"));
                // loading Available position applicantPosition List
                ArrayList objPosition = new ArrayList();
                objPosition = (new AvailablePositionTableController()).List();
                if (objPosition.Count > 0)
                {
                    applicantPositionList.DataSource = objPosition;
                    applicantPositionList.DataTextField = "positionName";
                    applicantPositionList.DataValueField = "positionID";
                    applicantPositionList.DataBind();

                    applicantPositionList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                    // ddlposition list
                    ddlPositions.DataSource = objPosition;
                    ddlPositions.DataTextField = "positionName";
                    ddlPositions.DataValueField = "positionID";
                    ddlPositions.DataBind();

                    ddlPositions.Items.Insert(0, new ListItem("---Please Select---", "-1"));
                    //ddlAvailablePosition list

                    ddlAvailablePosition.DataSource = objPosition;
                    ddlAvailablePosition.DataTextField = "positionName";
                    ddlAvailablePosition.DataValueField = "positionID";
                    ddlAvailablePosition.DataBind();
                    ddlAvailablePosition.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                    //ddlVacantPosition list
                    ddlVacantPosition.DataSource = objPosition;
                    ddlVacantPosition.DataTextField = "positionName";
                    ddlVacantPosition.DataValueField = "positionID";
                    ddlVacantPosition.DataBind();
                    ddlVacantPosition.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                    //ddlPositionMgt  list
                    ddlPositionMgt.DataSource = objPosition;
                    ddlPositionMgt.DataTextField = "positionName";
                    ddlPositionMgt.DataValueField = "positionID";
                    ddlPositionMgt.DataBind();
                    ddlPositionMgt.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                    //ddlAvailablePosition2 list
                    ddlAvailablePosition2.DataSource = objPosition;
                    ddlAvailablePosition2.DataTextField = "positionName";
                    ddlAvailablePosition2.DataValueField = "positionID";
                    ddlAvailablePosition2.DataBind();
                    ddlAvailablePosition2.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                }

                   // loading DEPARTMENT
                ArrayList objDept= new ArrayList();
                objDept = (new EmployeeDepartmentTableController()).List();
                if (objDept.Count > 0)
                {
                    ddlDept.DataSource = objDept;
                    ddlDept.DataTextField = "DeptName";
                    ddlDept.DataValueField = "DeptID";
                    ddlDept.DataBind();
                    ddlDept.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                }
                ddlApprovePosition.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                //loading worklocation on ddlWorkLocation

                ArrayList objLocation = new ArrayList();
                objLocation = (new EmployeeWorkLocationController()).List();
                if (objLocation.Count > 0)
                {
                    ddlWorkLocation.DataSource = objLocation;
                    ddlWorkLocation.DataTextField = "LocationName";
                    ddlWorkLocation.DataValueField = "WorkLocationID";
                    ddlWorkLocation.DataBind();
                    ddlWorkLocation.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                }



                // LOAD RATING KEY1 
                ArrayList objRatingKey1 = new ArrayList();


                objRatingKey1 = (new InterviewRatingKey1Controller()).List();
                if (objRatingKey1.Count > 0)
                {

                    ExperienceKeyList.DataSource = objRatingKey1;
                    ExperienceKeyList.DataTextField = "ratingDescription";
                    ExperienceKeyList.DataValueField = "ratingKeyID";
                    ExperienceKeyList.DataBind();
                    ExperienceKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                    edcationKeyList.DataSource = objRatingKey1;
                    edcationKeyList.DataTextField = "ratingDescription";
                    edcationKeyList.DataValueField = "ratingKeyID";
                    edcationKeyList.DataBind();
                    edcationKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                    communicationKeyList.DataSource = objRatingKey1;
                    communicationKeyList.DataTextField = "ratingDescription";
                    communicationKeyList.DataValueField = "ratingKeyID";
                    communicationKeyList.DataBind();
                    communicationKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                    interestKeyList.DataSource = objRatingKey1;
                    interestKeyList.DataTextField = "ratingDescription";
                    interestKeyList.DataValueField = "ratingKeyID";
                    interestKeyList.DataBind();
                    interestKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                    presentationKeyList.DataSource = objRatingKey1;
                    presentationKeyList.DataTextField = "ratingDescription";
                    presentationKeyList.DataValueField = "ratingKeyID";
                    presentationKeyList.DataBind();
                    presentationKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                    problemKeyList.DataSource = objRatingKey1;
                    problemKeyList.DataTextField = "ratingDescription";
                    problemKeyList.DataValueField = "ratingKeyID";
                    problemKeyList.DataBind();
                    problemKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));


                    computerKeyList.DataSource = objRatingKey1;
                    computerKeyList.DataTextField = "ratingDescription";
                    computerKeyList.DataValueField = "ratingKeyID";
                    computerKeyList.DataBind();
                    computerKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                    jobStabilityKeyList.DataSource = objRatingKey1;
                    jobStabilityKeyList.DataTextField = "ratingDescription";
                    jobStabilityKeyList.DataValueField = "ratingKeyID";
                    jobStabilityKeyList.DataBind();
                    jobStabilityKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                    otherKeyList.DataSource = objRatingKey1;
                    otherKeyList.DataTextField = "ratingDescription";
                    otherKeyList.DataValueField = "ratingKeyID";
                    otherKeyList.DataBind();
                    otherKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));


                }


                // LOAD RATING KEY1 
                ArrayList objRatingKey2 = new ArrayList();


                objRatingKey2 = (new InterviewRatingKey2Controller()).List();
                if (objRatingKey2.Count > 0)
                {

                    knowledgeRatingKeyList.DataSource = objRatingKey2;
                    knowledgeRatingKeyList.DataTextField = "ratingKeyDescription";
                    knowledgeRatingKeyList.DataValueField = "ratingKeyID";
                    knowledgeRatingKeyList.DataBind();
                    knowledgeRatingKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                    excitmentRatingKeyList.DataSource = objRatingKey2;
                    excitmentRatingKeyList.DataTextField = "ratingKeyDescription";
                    excitmentRatingKeyList.DataValueField = "ratingKeyID";
                    excitmentRatingKeyList.DataBind();
                    excitmentRatingKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                    experienceRatingKeyList.DataSource = objRatingKey2;
                    experienceRatingKeyList.DataTextField = "ratingKeyDescription";
                    experienceRatingKeyList.DataValueField = "ratingKeyID";
                    experienceRatingKeyList.DataBind();
                    experienceRatingKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                    teamRatingKeyList.DataSource = objRatingKey2;
                    teamRatingKeyList.DataTextField = "ratingKeyDescription";
                    teamRatingKeyList.DataValueField = "ratingKeyID";
                    teamRatingKeyList.DataBind();
                    teamRatingKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                    communicationRatingKeyList.DataSource = objRatingKey2;
                    communicationRatingKeyList.DataTextField = "ratingKeyDescription";
                    communicationRatingKeyList.DataValueField = "ratingKeyID";
                    communicationRatingKeyList.DataBind();
                    communicationRatingKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                    RecommendtionRatingKeyList.DataSource = objRatingKey2;
                    RecommendtionRatingKeyList.DataTextField = "ratingKeyDescription";
                    RecommendtionRatingKeyList.DataValueField = "ratingKeyID";
                    RecommendtionRatingKeyList.DataBind();
                    RecommendtionRatingKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));



                }
            }

        }
        protected void sendInterviewInviteBtn_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 1;
        }
        protected void backToWelcomBtn_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 0;
        }
        protected void interviewApplicantBtn_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 2;
        }
        protected void interviewNextBtn_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 3;
        }
        protected void evaluationBackBtn_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 1;
        }
        protected void evaluationWelcomPageBtn_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 0;
        }

        protected void interviewBackBtn_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 2;
        }

        protected void responseWelcomPage_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 0;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 1;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 2;
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 4;
        }
        protected void ddlAvailablePosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList objArr = new ArrayList();
            string positionAppliedFor = ddlAvailablePosition.SelectedItem.Text;
            objArr = (new ApplicantPersonalDetailsController()).ListByPositionNotShortlisted(positionAppliedFor);
            if (objArr.Count > 0)
            {
                GViewAllApplicantsList.DataSource = objArr;
                GViewAllApplicantsList.DataBind();
                GViewAllApplicantsList.Visible = true;
                sendInterviewInvite1.Visible = true;
                PanelInterviewParameter.Visible = true;
                lblShortlist.Visible = false;
            }
            else
            {
                GViewAllApplicantsList.Visible = false;
                sendInterviewInvite1.Visible = false;
                PanelInterviewParameter.Visible = false;
                lblShortlist.Text = "It might be that no one applied for the position of " + ddlAvailablePosition.SelectedItem.Text+ "  or All applicants has been shortlisted";
                lblShortlist.Visible = true;
            }
            
        }
        protected void btnEditPersonalDetails_Click(object sender, EventArgs e)
        {

        }
        protected void sendInterviewInvite1_Click(object sender, EventArgs e)
        {
            try
            {
                Panel1.Visible = true;
                ArrayList ObjArr = new ArrayList();
                foreach (GridViewRow g1 in GViewAllApplicantsList.Rows)
                {

                    //ApplicantPersonalDetailsInfo objPersonalDetailInfo = new ApplicantPersonalDetailsInfo();

                    //int applicantID = Convert.ToInt32(g1.Cells[0].Text);

                    //objPersonalDetailInfo = (new ApplicantPersonalDetailsController()).Get(applicantID);
                    lblName.Text = g1.Cells[2].Text + " " + g1.Cells[4].Text; ;
                    lblPositionApplied.Text = g1.Cells[1].Text;
                    lblApplicantEmail.Text = g1.Cells[8].Text;

                }
            }
            catch { }
        }
        protected void GViewAllApplicantsList_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "View")
            {
                ApplicantPersonalDetailsInfo objPersonalInfo = new ApplicantPersonalDetailsInfo();
                objPersonalInfo = (new ApplicantPersonalDetailsController()).Get(Convert.ToInt32(e.CommandArgument));

                lblPositionAppliedFor.Text = objPersonalInfo.PositionAppliedFor;
                lblApplicantNum.Text = objPersonalInfo.ApplicantNum;
                lblFirstName.Text = objPersonalInfo.FirstName;
                lblLastName.Text = objPersonalInfo.LastName;
                lblMiddleName.Text = objPersonalInfo.MiddleName;
                lblGender.Text = objPersonalInfo.Gender;
                lblMaritalStatus.Text = objPersonalInfo.MaritalStatus;
                lblNationality.Text = objPersonalInfo.Nationality;
                lblStateofOrigin.Text = objPersonalInfo.StateOfOrigin;
                lblLGA.Text = objPersonalInfo.LGA;
                lblHomeTown.Text = objPersonalInfo.HomeTown;
                lblEmail.Text = objPersonalInfo.Email;
                lblContactAddress.Text = objPersonalInfo.ContactAddress;
                lblDOB.Text = objPersonalInfo.DateOfBirth;
                lblAge.Text = objPersonalInfo.Age;
                ImagePassport.ImageUrl = "~/Image/" + objPersonalInfo.Passport.Substring(objPersonalInfo.Passport.LastIndexOf('\\') + 1);
                int applicantID = Convert.ToInt32(e.CommandArgument);

                // Qualification summary
                ArrayList ObjArrQualification = new ArrayList();
                ObjArrQualification = (new ApplicantQualificationController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrQualification.Count > 0)
                {

                    GViewQualification.DataSource = ObjArrQualification;
                    GViewQualification.DataBind();
                    GViewQualification.Visible = true;
                }

                //  professional Qualification summary
                ArrayList ObjArrProfQualification = new ArrayList();
                ObjArrProfQualification = (new ApplicantProfQualificationController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrProfQualification.Count > 0)
                {
                    GViewProfQualification.DataSource = ObjArrProfQualification;
                    GViewProfQualification.DataBind();
                    GViewProfQualification.Visible = true;
                }
                //  Wwork Experience summary
                ArrayList ObjArrWorkExp = new ArrayList();
                ObjArrWorkExp = (new ApplicantWorkExperienceController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrWorkExp.Count > 0)
                {
                    GViewWrkExp.DataSource = ObjArrWorkExp;
                    GViewWrkExp.DataBind();
                    GViewWrkExp.Visible = true;
                }

                //  Document summary
                ArrayList ObjArrDoc = new ArrayList();
                ObjArrDoc = (new ApplicantDocumentController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrDoc.Count > 0)
                {
                    GViewDocument.DataSource = ObjArrDoc;
                    GViewDocument.DataBind();
                    GViewDocument.Visible = true;
                }

                PanelApplicantDetails.Visible = true;
                Button5.Visible = true;



                // MViewInterview.ActiveViewIndex = 4;



            }
        }


        protected void GViewAllApplicantsList_RowCommand1(object sender, GridViewCommandEventArgs e)
        {

        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            PanelApplicantDetails.Visible = false;
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow x in GViewAllApplicantsList.Rows)
            {
                // declare a variable as textbox
                TextBox b = new TextBox();
                // find the textbox containing the applicantID on the gridview 
                b = (TextBox)x.FindControl("TextBox2");
                string id = b.Text;
                string applicantName = x.Cells[2].Text + " " + x.Cells[4].Text; ;
                string PositionAppliedFor = x.Cells[1].Text;
                string applicantEmail = x.Cells[8].Text;
                // ApplicantPersonalDetailsInfo objPersonalInfo = new ApplicantPersonalDetailsInfo();

                CheckBox c = new CheckBox();
                c = (CheckBox)x.FindControl("CheckBox1");
                if (c.Checked == true)
                {
                    // lblInterMsg.Text = id;
                    try
                    {
                        // Update application Status of that applicant as shortlisted
                        ApplicantPersonalDetailsInfo objPersonalInfo = new ApplicantPersonalDetailsInfo();
                        objPersonalInfo.ApplicantID = Convert.ToInt32(id);
                        objPersonalInfo.ApplicationStatus = "Shortlisted";
                        new ApplicantPersonalDetailsController().UpdateApplicationStatus(objPersonalInfo);
                        lblInviteSend.Text = "Interview Letter SUCCESSFULLY sent";

                        //send an email from a Gmail address using SMTP server.  
                        //The Gmail SMTP server name is smtp.gmail.com and
                        //the port using send mail is 587 and also using  

                        //NetworkCredential for password based authentication;
                        //string _subjectEmail = "";
                        //MailMessage mail = new MailMessage();
                        //SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                        // mail.IsBodyHtml = true;
                        //mail.From = new MailAddress("your_email_address@gmail.com");
                        // mail.From = new MailAddress("olami@neetbeettech@gmail.com");


                        //Loading all Mail contents
                        //Composing mail content

                        //string salutaion = ("dear" + applicantName + ",");
                        //string subjectEmail = "Invitation to Interview";
                        //string bodyEmail = ("dear" + applicantName + ","+ "In response to your application for the post of "
                        //    + PositionAppliedFor  +" Neetbeet Technogies Limited, we are please to invite you for interview as scheduled below:");
                        //string InterviewDetails = ("Date: " + ddlInterviewDay.SelectedValue + ddlInterviewMonth.SelectedValue +ddlInterviewYear.SelectedValue
                        //                            + " Time: " + txtInterviewTime.Text + " Venue: " + txtInterviewVenue.Text);

                        //bodyEmail += InterviewDetails;
                        //mail.To.Add(applicantEmail);
                        //mail.Subject = subjectEmail;
                        //mail.Body = bodyEmail;

                        //Adding an attachments
                        //mail.Attachments.Add(new Attachment(MailAttachementPath));
                        //SmtpServer.Port = 587;
                        //// SmtpServer.Port = 25;
                        //SmtpServer.Credentials = new System.Net.NetworkCredential("olami@neetbeettech@gmail.com", "Adeniyi@2018");

                        ////SmtpServer.UseDefaultCredentials = false;
                        //SmtpServer.EnableSsl = true;

                        //SmtpServer.Send(mail);
                        //lblInviteSend.Text = "Interview Letter SUCCESSFULLY sent";
                        //mail.Dispose();
                    }
                    catch (Exception ex)
                    {
                        // lblInviteSend.Text = "Interview Letter NOT sent" ;
                    }

                    // reload 
                    ArrayList objArr = new ArrayList();
                    string positionAppliedFor = ddlAvailablePosition.SelectedItem.Text;
                    objArr = (new ApplicantPersonalDetailsController()).ListByPositionNotShortlisted(positionAppliedFor);
                    if (objArr.Count > 0)
                    {
                        GViewAllApplicantsList.DataSource = objArr;
                        GViewAllApplicantsList.DataBind();
                        GViewAllApplicantsList.Visible = true;
                        sendInterviewInvite1.Visible = true;
                        PanelInterviewParameter.Visible = true;
                        lblShortlist.Visible = false;
                    }



                }

            }
        }
        protected void applicantPositionList_SelectedIndexChanged(object sender, EventArgs e)
        {

            ArrayList objArr = new ArrayList();
            string position = applicantPositionList.SelectedItem.Text.Trim();
            objArr = new ApplicantPersonalDetailsController().ListByPositionShortlisted(position);
            if (objArr.Count > 0)
            {
                applicantList.DataSource = objArr;
                applicantList.DataTextField = "ApplicantNum";
                applicantList.DataValueField = "ApplicantID";
                applicantList.DataBind();

            }
        }
        protected void applicantList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplicantPersonalDetailsInfo objPersonalInfo = new ApplicantPersonalDetailsInfo();
            int id = Convert.ToInt32(applicantList.SelectedItem.Value);
            objPersonalInfo = new ApplicantPersonalDetailsController().Get(id);
            lblApplicantName.Text = objPersonalInfo.LastName + ", " + objPersonalInfo.FirstName;
        }
        protected void ddlPositions_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelEmploymentParameter.Visible = true;
            lblhire.Visible = false;
            ArrayList objArr = new ArrayList();
            string position = ddlPositions.SelectedItem.Text.Trim();
            objArr = new ApplicantPersonalDetailsController().ListByPositionShortlisted(position);
            if (objArr.Count > 0)
            {
                GVShortlistedApplicants.DataSource = objArr;
                GVShortlistedApplicants.DataBind();
                GVShortlistedApplicants.Visible = true;
                Label57.Visible = true;
                lblNoShortlistedApplicant.Visible = false;
                PanelEmploymentParameter.Visible = true;

            }
            else
            {
                GVShortlistedApplicants.Visible = false;
                Label57.Visible = false;
                lblNoShortlistedApplicant.Text = "No applicant has been shorlisted for the position of  " + ddlPositions.SelectedItem.Text.Trim()+ "Or all shortlisted applicants have been hired";
                lblNoShortlistedApplicant.Visible = true;
                PanelEmploymentParameter.Visible = false;
            }
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 5;
        }
        protected void Button9_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (GridViewRow x in GVShortlistedApplicants.Rows)
            {
                TextBox b = new TextBox();
                b = (TextBox)x.FindControl("TextBoxApplicantID");
                int id = Convert.ToInt32(b.Text);
                CheckBox c = new CheckBox();
                c = (CheckBox)x.FindControl("CheckBox2");
                
                if (c.Checked == true)
                {
                    try
                    {
                        ApplicantPersonalDetailsInfo objPersonalInfo = new ApplicantPersonalDetailsInfo();
                        objPersonalInfo.ApplicantID = Convert.ToInt32(id);
                        objPersonalInfo.WorkLocationID_FK = Convert.ToInt32(ddlWorkLocation.SelectedValue);
                        objPersonalInfo.DepartmentID_FK = Convert.ToInt32(ddlDept.SelectedValue);
                        objPersonalInfo.PositionApproved_FK = Convert.ToInt32(ddlApprovePosition.SelectedValue);
                        objPersonalInfo.LevelID_FK = Convert.ToInt32(ddlLevel.SelectedValue);
                        objPersonalInfo.ResumptionDate = ddlDay.SelectedValue + "-" + ddlMonth.SelectedValue + "-" + ddlYear.SelectedValue;
                        objPersonalInfo.InterviewerDecision = "Hire";

                        new ApplicantPersonalDetailsController().UpdateInterviewerDecision(objPersonalInfo);
                        count += 1;
                        lblhire.Text = "You have successfully hired " + count + " applicants for the position of " + ddlApprovePosition.SelectedItem.Text;
                       lblhire.Visible = true;
                    }
                    catch { }
                    

                }
            // reload the gridview
                string position = ddlPositions.SelectedItem.Text;
                ArrayList objArr = new ArrayList();
                objArr= new ApplicantPersonalDetailsController().ListByPositionShortlisted(position);
                if (objArr.Count > 0)
                {
                    GVShortlistedApplicants.DataSource = objArr;
                    GVShortlistedApplicants.DataBind();
                    GVShortlistedApplicants.Visible = true;
                    Label57.Visible = true;
                    lblNoShortlistedApplicant.Visible = false;

                }
            }
        }
        protected void GVShortlistedApplicants_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "View")
            {
                ApplicantPersonalDetailsInfo objPersonalInfo = new ApplicantPersonalDetailsInfo();
                objPersonalInfo=(new ApplicantPersonalDetailsController()).Get(Convert.ToInt32(e.CommandArgument));
                LabelPosition.Text = objPersonalInfo.PositionAppliedFor;
                LabelApplicantNo.Text = objPersonalInfo.ApplicantNum;
                LabelFName.Text = objPersonalInfo.FirstName;
                LabelMidName.Text = objPersonalInfo.MiddleName;
                LabelLName.Text = objPersonalInfo.LastName;

                LabelGender.Text = objPersonalInfo.Gender;
                LabelMaritalStatus.Text = objPersonalInfo.MaritalStatus;
                LabelNationality.Text = objPersonalInfo.Nationality;
                LabelState.Text = objPersonalInfo.StateOfOrigin;
                LabelLga.Text = objPersonalInfo.LGA;
                LabelHomeTown.Text = objPersonalInfo.HomeTown;
                LabelEmail.Text = objPersonalInfo.Email;
                LabelAddress.Text = objPersonalInfo.ContactAddress;
                LabelDob.Text = objPersonalInfo.DateOfBirth;
                LabelAge.Text = objPersonalInfo.Age;
                Image1.ImageUrl = "~/Image/" + objPersonalInfo.Passport.Substring(objPersonalInfo.Passport.LastIndexOf('\\') + 1);

               
                int applicantID = Convert.ToInt32(e.CommandArgument);

                
                //label
                ArrayList ObjArrQualification = new ArrayList();
                ObjArrQualification = (new ApplicantQualificationController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrQualification.Count > 0)
                {

                    GridViewQualification.DataSource = ObjArrQualification;
                    GridViewQualification.DataBind();
                    GridViewQualification.Visible = true;
                }

                ////  professional Qualification summary
                ArrayList ObjArrProfQualification = new ArrayList();
                ObjArrProfQualification = (new ApplicantProfQualificationController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrProfQualification.Count > 0)
                {
                    GridViewProfQualification.DataSource = ObjArrProfQualification;
                    GridViewProfQualification.DataBind();
                    GridViewProfQualification.Visible = true;
                }
                ////  Wwork Experience summary
                ArrayList ObjArrWorkExp = new ArrayList();
                ObjArrWorkExp = (new ApplicantWorkExperienceController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrWorkExp.Count > 0)
                {
                    GridViewWorkExperience.DataSource = ObjArrWorkExp;
                    GridViewWorkExperience.DataBind();
                    GridViewWorkExperience.Visible = true;
                }

                ////  Document summary
                ArrayList ObjArrDoc = new ArrayList();
                ObjArrDoc = (new ApplicantDocumentController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrDoc.Count > 0)
                {
                    GridViewDocument.DataSource = ObjArrDoc;
                    GridViewDocument.DataBind();
                    GridViewDocument.Visible = true;
                }

                Panel2.Visible = true;
                //Button5.Visible = true;
            }
        }
        protected void Button10_Click(object sender, EventArgs e)
        {
            Panel2.Visible = false;
        }
        protected void Button12_Click(object sender, EventArgs e)
        {
            string position = ddlVacantPosition.SelectedItem.Text.Trim();
            ArrayList objArr = new ArrayList();
            objArr = (new ApplicantPersonalDetailsController()).ListByPositionAppliedForAll(position);
            if (objArr.Count > 0)
            {
                GVReport.DataSource = objArr;
                GVReport.DataBind();
                GVReport.Visible = true;
                lblReport.Visible = false;
                              
            }
            else
            {
                GVReport.Visible = false;
                lblReport.Text = "No one apply for this position";
                lblReport.Visible = true;
            }
        }
        protected void Button11_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 6;
        }
        protected void ddlVacantPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelect.Text = "Select the report you want to view";
            //Button12.Visible = true;
           // Button13.Visible = true;
           // Button14.Visible = true;
            linkAllapplicants.Visible = true;
            linkShortlistedApplicants.Visible = true;
            linkHireApplicants.Visible = true;
            LinkApproveApplicant.Visible = true;
            GVReport.Visible = false;
        }
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            string position = ddlVacantPosition.SelectedItem.Text.Trim();
            ArrayList objArr = new ArrayList();
            objArr = (new ApplicantPersonalDetailsController()).ListByPositionAppliedForAll(position);
            if (objArr.Count > 0)
            {
                GVReport.DataSource = objArr;
                GVReport.DataBind();
                GVReport.Visible = true;
                lblReport.Visible = false;

            }
            else
            {
                GVReport.Visible = false;
                lblReport.Text = "No one apply for this position";
                lblReport.Visible = true;
            }

        }
        protected void linkShortlistedApplicants_Click(object sender, EventArgs e)
        {
            string position = ddlVacantPosition.SelectedItem.Text.Trim();
            ArrayList objArr = new ArrayList();
            // get shortlisted applicants either hire or not
            objArr = (new ApplicantPersonalDetailsController()).ListByPositionHireOrNot(position);
            if (objArr.Count > 0)
            {
                GVReport.DataSource = objArr;
                GVReport.DataBind();
                GVReport.Visible = true;
                lblReport.Visible = false;

            }
            else
            {
                GVReport.Visible = false;
                lblReport.Text = "No applicant has been shortlisted for the position of " + ddlVacantPosition.SelectedItem.Text.Trim();
                lblReport.Visible = true;
            }
        }
        protected void linkHireApplicants_Click(object sender, EventArgs e)
        {
            string position = ddlVacantPosition.SelectedItem.Text.Trim();
            ArrayList objArr = new ArrayList();
            objArr = (new ApplicantPersonalDetailsController()).ListByPositionHire(position);
            if (objArr.Count > 0)
            {
                GVReport.DataSource = objArr;
                GVReport.DataBind();
                GVReport.Visible = true;
                lblReport.Visible = false;

            }
            else
            {
                GVReport.Visible = false;
                lblReport.Text = "No applicant has been hire for the position of " + ddlVacantPosition.SelectedItem.Text.Trim();
                lblReport.Visible = true;
            }
        }
        protected void ddlPositionMgt_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelApplicants.Visible = false;
            string position = ddlPositionMgt.SelectedItem.Text.Trim();
            ArrayList objArr = new ArrayList();
            // get hire applicants
            objArr = new ApplicantPersonalDetailsController().ListByPositionHire(position);
            if (objArr.Count > 0)
            {
                GVHireApplicants.DataSource = objArr;
                GVHireApplicants.DataBind();
                GVHireApplicants.Visible = true;
                lblHireReport.Visible = false;
                Button16.Visible = true;
            }
            else
            {
                ArrayList objArr2 = new ArrayList();
                // get shortlisted but not hire
                objArr2 = new ApplicantPersonalDetailsController().ListByPositionShortlisted(position);
                if (objArr2.Count > 0)
                {
                    lblHireReport.Text = "No one has be hired for the position of " + ddlPositionMgt.SelectedItem.Text;
                    lblHireReport.Visible = true;
                     GVHireApplicants.Visible = false;
                     Button16.Visible = false;
            
                }
                else
                {
                    // get applied but not shortlisted
                    objArr2 = new ApplicantPersonalDetailsController().ListByPositionNotShortlisted(position);
                    if (objArr2.Count > 0)
                    {
                        lblHireReport.Text = "No one has be Shortlisted for the position of " + ddlPositionMgt.SelectedItem.Text;
                        lblHireReport.Visible = true;
                        GVHireApplicants.Visible = false;
                        Button16.Visible = false;
                    }
                    else
                    {
                        // get applied applicants
                        objArr2 = new ApplicantPersonalDetailsController().ListByPositionAppliedForAll(position);
                        if (objArr2.Count== 0)
                        {
                            lblHireReport.Text = "Nobody apply for the position of " + ddlPositionMgt.SelectedItem.Text;
                            lblHireReport.Visible = true;
                            GVHireApplicants.Visible = false;
                            Button16.Visible = false;
                        }
                    }
                }
                //GVHireApplicants.Visible = false;
                //lblHireReport.Text = "No one has be hired for the position of " + ddlPositionMgt.SelectedItem.Text;
                //lblHireReport.Visible = true;
            }
        }
        protected void Button15_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 7;
        }
        protected void Button16_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (GridViewRow x in GVHireApplicants.Rows)
            {
                TextBox b = new TextBox();
                b = (TextBox)x.FindControl("TextBoxID");
                int id = Convert.ToInt32(b.Text);
                CheckBox c = new CheckBox();
                c = (CheckBox)x.FindControl("CheckBox1");
                
                if (c.Checked == true)
                {
                    try
                    {
                        ApplicantPersonalDetailsInfo objPersonalInfo = new ApplicantPersonalDetailsInfo();
                        objPersonalInfo.ApplicantID = Convert.ToInt32(id);
                        objPersonalInfo.ManagementDecision = "Approve";
                        new ApplicantPersonalDetailsController().UpdateManagementDecision(objPersonalInfo);
                        count += 1;
                     // lblhire.Text = "You have successfully hired " + count + " applicants for the position of " + ddlPositionMgt.SelectedItem.Text;
                        lblhire.Text = "Approve successfull";
                        lblhire.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        lblhire.Text = (ex.Message);
                        lblhire.Visible = true;
                    }
                    

                }
            // /reload the gridview
                string position = ddlPositionMgt.SelectedItem.Text;
                ArrayList objArr = new ArrayList();
                objArr = new ApplicantPersonalDetailsController().ListByPositionHire(position);
                if (objArr.Count > 0)
                {
                    GVHireApplicants.DataSource = objArr;
                    GVHireApplicants.DataBind();
                    GVHireApplicants.Visible = true;
                    Label57.Visible = true;
                    //lblNoShortlistedApplicant.Visible = false;
                }
                }
        }
        protected void LinkApproveApplicant_Click(object sender, EventArgs e)
        {
            string position = ddlVacantPosition.SelectedItem.Text.Trim();
            ArrayList objArr = new ArrayList();
            objArr = (new ApplicantPersonalDetailsController()).ListByPositionApprove(position);
            if (objArr.Count > 0)
            {
                GVReport.DataSource = objArr;
                GVReport.DataBind();
                GVReport.Visible = true;
                lblReport.Visible = false;

            }
            else
            {
                GVReport.Visible = false;
                lblReport.Text = "No applicant has been approved for the position of " + ddlVacantPosition.SelectedItem.Text.Trim();
                lblReport.Visible = true;
            }
        }
        protected void GVHireApplicants_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "View")
            {
                ApplicantPersonalDetailsInfo objPersonalInfo = new ApplicantPersonalDetailsInfo();
                objPersonalInfo = (new ApplicantPersonalDetailsController()).Get(Convert.ToInt32(e.CommandArgument));
                lblApprovePosition.Text = objPersonalInfo.PositionAppliedFor;
                lblApproveName.Text = objPersonalInfo.FirstName;
                lblapproveMName.Text = objPersonalInfo.MiddleName;
                lblapproveLName.Text = objPersonalInfo.LastName;
                lblApproveGender.Text = objPersonalInfo.Gender;
                lblapproveMaritalStatus.Text = objPersonalInfo.MaritalStatus;
                lblApproveNationality.Text = objPersonalInfo.Nationality;
                lblApproveState.Text = objPersonalInfo.StateOfOrigin;
                lblApproveLga.Text = objPersonalInfo.LGA;
                lblapproveHTown.Text = objPersonalInfo.HomeTown;
                lblApproveEmail.Text = objPersonalInfo.Email;
                lblapproveAddr.Text = objPersonalInfo.ContactAddress;
                lblApproveAge.Text = objPersonalInfo.Age;
                Image2.ImageUrl = "~/Image/" + objPersonalInfo.Passport.Substring(objPersonalInfo.Passport.LastIndexOf('\\') + 1);


                int applicantID = Convert.ToInt32(e.CommandArgument);


                //label
                ArrayList ObjArrQualification = new ArrayList();
                ObjArrQualification = (new ApplicantQualificationController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrQualification.Count > 0)
                {

                    GVQualif.DataSource = ObjArrQualification;
                    GVQualif.DataBind();
                    GVQualif.Visible = true;
                }

                ////  professional Qualification summary
                ArrayList ObjArrProfQualification = new ArrayList();
                ObjArrProfQualification = (new ApplicantProfQualificationController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrProfQualification.Count > 0)
                {
                    GVProfQualif.DataSource = ObjArrProfQualification;
                    GVProfQualif.DataBind();
                    GVProfQualif.Visible = true;
                }
                ////  Wwork Experience summary
                ArrayList ObjArrWorkExp = new ArrayList();
                ObjArrWorkExp = (new ApplicantWorkExperienceController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrWorkExp.Count > 0)
                {
                    GVWrkExp.DataSource = ObjArrWorkExp;
                    GVWrkExp.DataBind();
                    GVWrkExp.Visible = true;
                }

                ////  Document summary
                ArrayList ObjArrDoc = new ArrayList();
                ObjArrDoc = (new ApplicantDocumentController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrDoc.Count > 0)
                {
                    GVDoc.DataSource = ObjArrDoc;
                    GVDoc.DataBind();
                    GVDoc.Visible = true;
                }

                PanelApplicants.Visible = true;

            }
        }
        protected void Button18_Click(object sender, EventArgs e)
        {
            PanelApplicants.Visible = false;
        }
        protected void Button19_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 8;
        }
        protected void ddlDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            int deptID = Convert.ToInt32(ddlDept.SelectedItem.Value);
            ArrayList objPosition = new ArrayList();
            objPosition = (new EmployeePositionTableController()).GetByEmployeeDepartmentTable(deptID);
                
            if (objPosition.Count > 0)
            {
                ddlApprovePosition.DataSource = objPosition;
                ddlApprovePosition.DataTextField = "PositionName";
                ddlApprovePosition.DataValueField = "PositionID";
                ddlApprovePosition.DataBind();
                ddlApprovePosition.Items.Insert(0, new ListItem("---Please Select---", "-1"));
            }


            //int deptID = Convert.ToInt32(ddlDept.SelectedItem.Value);
            ArrayList objLevel = new ArrayList();
            objLevel = (new EmployeeLevelTableController()).GetByEmployeeDepartmentTable(deptID);

            if (objLevel.Count > 0)
            {
                ddlLevel.DataSource = objLevel;
                ddlLevel.DataTextField = "LevelName";
                ddlLevel.DataValueField = "LevelID";
                ddlLevel.DataBind();
                ddlLevel.Items.Insert(0, new ListItem("---Please Select---", "-1"));
            }
        }
        protected void ddlLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int levelID = Convert.ToInt32(ddlLevel.SelectedItem.Value);
            EmployeeLevelTableInfo objLevel = new EmployeeLevelTableInfo();

            objLevel = new EmployeeLevelTableController().Get(levelID);
            lblSalary.Text = objLevel.Salary;
        }
        protected void ddlAvailablePosition2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string position = ddlAvailablePosition2.SelectedItem.Text;
            ArrayList objArr = new ArrayList();
            objArr = new ApplicantPersonalDetailsController().ListByPositionApprove(position);
            if (objArr.Count > 0)
            {
                GVSendOffer.DataSource = objArr;
                GVSendOffer.DataBind();
                GVSendOffer.Visible = true;
                lblReport2.Visible = false;
               // Button16.Visible = true;
            }
            else
            {
                GVSendOffer.Visible = false;
                lblReport2.Text = "No applicant has been approved for the position of " + ddlAvailablePosition2.SelectedItem.Text;
                lblReport2.Visible = true;
            }
        }
        protected void Button20_Click(object sender, EventArgs e)
        {

            foreach (GridViewRow x in  GVSendOffer.Rows)
            {
                // declare a variable as textbox
                TextBox b = new TextBox();
                // find the textbox containing the applicantID on the gridview 
                b = (TextBox)x.FindControl("txtApplicantID");
                string applicantID = b.Text;
                
                CheckBox c = new CheckBox();
                c = (CheckBox)x.FindControl("CheckBox1");
                
                if (c.Checked == true)
                {
                    // lblInterMsg.Text = id;
                    try
                    {
                        ApplicantPersonalDetailsInfo objPersonalInfo = new ApplicantPersonalDetailsInfo();
                        objPersonalInfo = new ApplicantPersonalDetailsController().GetOfferDetails(Convert.ToInt32(applicantID));
                        lblName2.Text = objPersonalInfo.LastName + " " + objPersonalInfo.FirstName;
                        lblPosition.Text = objPersonalInfo.ApprovedPositionName;
                        lblOfferDept.Text = objPersonalInfo.DeptName;
                       
                        lblOfferPosition.Text = objPersonalInfo.ApprovedPositionName;
                        lblOfferDept2.Text = objPersonalInfo.DeptName;
                        lblOfferLevel.Text = objPersonalInfo.LevelName;
                        lblOfferSalary.Text = objPersonalInfo.Salary;
                        lblOfferWrkLocatn.Text = objPersonalInfo.LocationName;
                        lblOfferRsmptDate.Text = objPersonalInfo.ResumptionDate;
                      

                        //Composing mail content

                        //string salutaion = ("dear" + objPersonalInfo.LastName + ",");
                        string subjectEmail = "Employment Offer";
                        string bodyEmail = ("Dear " +  objPersonalInfo.LastName + ", "+ objPersonalInfo.FirstName + " Further to your application and subsquent interviewat Neetbeet Technogies Limited, we are please to offer you"
                           + objPersonalInfo.ApprovedPositionName + " under the department of " + objPersonalInfo.DeptName);
                        string offerDetails = ("The following are your appointment detail: " +
                            "Position: " + objPersonalInfo.ApprovedPositionName +
                            "Department: " + objPersonalInfo.DeptName +
                            "Level: " + objPersonalInfo.LevelName +
                            "Salary: " + objPersonalInfo.Salary +
                            "Work Loction: " + objPersonalInfo.LocationName +
                            "Resumption Date:" + objPersonalInfo.ResumptionDate +
                            "The first six months of your employment with us will be regarded as a propationary period, during which , either you o the company could terminate the appointment by giving one (1) month's notice in writing or paying one (1) month's basic salary in lieuof notice. ");

                        bodyEmail += offerDetails;
                        string receiverEmail=objPersonalInfo.Email;

                        Utility.SendMail(subjectEmail, bodyEmail, receiverEmail);
                       // Panel3.Visible = true;
                       // Response.Write("<script language=javascript>window.open('Print5.aspx','PrintMe','height=300px,width=300px,scrollbars=1', '_blank');</script>");
                        //string sdata1 = "hello";
                        //string sdata = Server.UrlEncode(sdata1);
                      // Response.Write("<script language=javascript>");
                        //Response.Redirect("window.open('' ,+ 'http;//'+ Request.Url.Authority+'/Print5.aspx?sdata='+sdata+ ', _blank')");
                        string url = "http://" + Request.Url.Authority + "/Print5.aspx?id=" + applicantID.ToString();
                        Response.Write("<script language=javascript> window.open( '" + url + "','_blank');</script>");
                        //Response.Redirect("Print5.aspx?id=" +applicantID.ToString());
                        //Response.Write("</script>");
                    }
                    catch { }

                }
              //  MViewInterview.ActiveViewIndex = 9;
            }
        }
        protected void btnPrint_Click(object sender, EventArgs e)
        {
          // Session["ctrl"] = Panel3;
          // Page.ClientScript.RegisterStartupScript(this.GetType(), "onclick", "<script language=javascript>window.open('Print.aspx','PrintMe','height=300px,width=300px,scrollbars=1');</script>");
          HttpContext.Current.Response.Write("<script>Print5.print();</script>");
          //  javascript:Print5.print();
        }
        protected void Button21_Click(object sender, System.EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 8;
        }
        //protected void btnPrint_Click1(object sender, System.EventArgs e)
        //{
        
        //    //javascript: window.print();
        //    Session["ctrl"] = Panel3;
        //   // ClientScript.RegisterStartupScript(this.GetType(), "onclick", "<script language=javascript>window.open('Print.aspx','PrintMe','height=300px,width=300px,scrollbars=1');</script>");

        //}
}
}