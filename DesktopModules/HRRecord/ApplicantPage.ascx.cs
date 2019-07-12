
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
//using System.
using Bilikis.HRManagementSystem;

namespace Bilikis.HRManagementSystem
{

    public partial class ApplicantPage : PortalModuleBase, IActionable
    {
      //  ApplicantPersonalDetailsController objApplicantPersonalDetailsController;
        string passport;
         string filepath2;
        int applicantID;
        string applicantNum;
        DataTable dt1 = new DataTable();
        bool flag = false;
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


        public class PageUtility
        {
            public static void MessageBox(System.Web.UI.Page page, string strMsg)
            {
                ScriptManager.RegisterClientScriptBlock(page, page.GetType(), "alertMessage", "alert('+strMsg')", true);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (!IsPostBack)
                {
                    MViewApplicant.ActiveViewIndex = 0;
                    // day dropdownlist
                    var day = new ArrayList();
                    day.Add("Day");
                    for (var i = 1; i <= 31; i++)
                    {
                        day.Add(i);
                    }
                    ddlDay.DataSource = day;
                    ddlDay.DataBind();
                    ddlWorkStartDay.DataSource = day;
                    ddlWorkStartDay.DataBind();
                    ddlWorkEndDay.DataSource = day;
                    ddlWorkEndDay.DataBind();

                    // year dropdownlist
                    var al = new ArrayList();
                    al.Add("Year");
                    for (var i = 2018; i >= 1900; i--)
                    {
                        al.Add(i);
                    }


                    //var al2 = new ArrayList();
                    //al2.Add("Year");
                    //for (var i = 2018; i >= 1900; i--)
                    //{
                    //    al2.Add(i);
                    //}
                   

                    ddlYear.DataSource = al;
                    ddlYear.DataBind();
                    //ddlYear2.DataSource = al;
                    //ddlYear2.DataBind();

                    ddlWorkStartYear.DataSource = al;
                    ddlWorkStartYear.DataBind();

                    ddlWorkEndYear.DataSource = al;
                    ddlWorkEndYear.DataBind();
                    

                    ddlCertYear.DataSource = al;
                    ddlCertYear.DataBind();

                    qualifStartYearList.DataSource = al;
                    qualifStartYearList.DataBind();

                    qualifEndYearList.DataSource = al;
                    qualifEndYearList.DataBind();

                    //loading conutry list

                    ArrayList objCountry = new ArrayList();
                    objCountry = (new CountryTableController()).List();
                    if (objCountry.Count > 0)
                    {
                        ddlCountry.DataSource = objCountry;
                        ddlCountry.DataTextField = "CountryName";
                        ddlCountry.DataValueField = "CountryID";
                        ddlCountry.DataBind();
                        ddlCountry.Items.Insert(0, new ListItem("---Please select---", "-1"));
                    }
                    ddlState.Items.Insert(0, new ListItem("---Please select---", "-1"));
                    ddlLga.Items.Insert(0, new ListItem("---Please select---", "-1"));

                    ////loading Qualifiactions list
                    ArrayList objQualifications = new ArrayList();
                    objQualifications = (new QualificationTableController()).List();
                    if (objQualifications.Count > 0)
                    {
                        qualifList.DataSource = objQualifications;
                        qualifList.DataTextField = "QualificationName";
                        qualifList.DataValueField = "QualificationID";
                        qualifList.DataBind();

                        qualifList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                    }
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
                   // gradeList.Items.Insert(0, new ListItem("---Please select---"));



                }
            }
            catch (Exception  ex)
            {
                
                throw ex;
            }
        }
       



        //protected void applyBtn_Click(object sender, EventArgs e)
        //{
        //    MViewApplicant.ActiveViewIndex = 1;
        //}
        protected void applicantNextBtn_Click(object sender, EventArgs e)
        {
            string applicantNum = ViewState["applicantNum"].ToString();
            int applicantID = Convert.ToInt32(applicantNum.Substring(applicantNum.LastIndexOf('/') + 1));
            ViewState.Add("applicantID", applicantID);
            ArrayList ObjArrQualification = new ArrayList();
            ObjArrQualification = (new ApplicantQualificationController()).GetByApplicantPersonalDetails(applicantID);
            if (ObjArrQualification.Count != 0)
            {
                
                    GViewQualif.DataSource = (ObjArrQualification);
                    GViewQualif.DataBind();
                    GViewQualif.Visible = true;
                    
               

                
                MViewApplicant.ActiveViewIndex = 2;
                qualifSaveBtn.Visible = true;
                qualifSaveBtn.Enabled = true;
            }
            else
            {
                MViewApplicant.ActiveViewIndex = 2;
               
            }
            

        }

        protected void qualifNextBtn_Click(object sender, EventArgs e)
        {
            string applicantNum = ViewState["applicantNum"].ToString();
            int applicantID = Convert.ToInt32(applicantNum.Substring(applicantNum.LastIndexOf('/') + 1));
            ArrayList ObjArrProfQualification = new ArrayList();
            ObjArrProfQualification = (new ApplicantProfQualificationController()).GetByApplicantPersonalDetails(applicantID);
            if (ObjArrProfQualification.Count != 0)
            {
                foreach (var item in ObjArrProfQualification)
                {
                    GViewCert.DataSource = (ObjArrProfQualification);
                    GViewCert.DataBind();
                    GViewCert.Visible = true;
                }


                MViewApplicant.ActiveViewIndex = 3;
               // qualifSaveBtn.Visible = true;
               // qualifSaveBtn.Enabled = true;
            }
            else
            {
                MViewApplicant.ActiveViewIndex = 3;
            }
            
            
            
            
            
            
            
            MViewApplicant.ActiveViewIndex = 3;
        }
        protected void qualifBackBtn_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 1;
        }
        protected void certNextBtn_Click(object sender, EventArgs e)
        {
            string applicantNum = ViewState["applicantNum"].ToString();
            int applicantID = Convert.ToInt32(applicantNum.Substring(applicantNum.LastIndexOf('/') + 1));
            ArrayList ObjArrWorExp = new ArrayList();
            ObjArrWorExp = (new ApplicantWorkExperienceController()).GetByApplicantPersonalDetails(applicantID);
            if (ObjArrWorExp.Count != 0)
            {
                foreach (var item in ObjArrWorExp)
                {
                    GViewWorkExp.DataSource = (ObjArrWorExp);
                    GViewWorkExp.DataBind();
                    GViewWorkExp.Visible = true;
                }


                MViewApplicant.ActiveViewIndex = 4;
                workSaveBtn.Visible = true;
                // qualifSaveBtn.Visible = true;
                // qualifSaveBtn.Enabled = true;
            }
            else
            {
                MViewApplicant.ActiveViewIndex = 4;
            } 
          
            
        }
        protected void certBackBtn_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 2;
        }
        protected void workNextBtn_Click(object sender, EventArgs e)
        {
            string applicantNum = ViewState["applicantNum"].ToString();
            int applicantID = Convert.ToInt32(applicantNum.Substring(applicantNum.LastIndexOf('/') + 1));
            ArrayList ObjArrDoc = new ArrayList();
            ObjArrDoc = (new ApplicantDocumentController()).GetByApplicantPersonalDetails(applicantID);
            if (ObjArrDoc.Count != 0)
            {
                foreach (var item in ObjArrDoc)
                {
                    GViewDoc.DataSource = (ObjArrDoc);
                    GViewDoc.DataBind();
                    GViewDoc.Visible = true;
                }


                MViewApplicant.ActiveViewIndex = 5;
                // qualifSaveBtn.Visible = true;
                // qualifSaveBtn.Enabled = true;
            }
            else
            {
                MViewApplicant.ActiveViewIndex = 5;
            } 
          
        }
        protected void workBackBtn_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 3;
        }
        protected void docBackBtn_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 4;
        }
        protected void docSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int applicantID = Convert.ToInt32(ViewState["applicantID"]);


                ArrayList objDocArr = new ArrayList();
                objDocArr = (new ApplicantDocumentController()).GetByApplicantPersonalDetails(applicantID);
                if (objDocArr.Count > 0)
                    foreach (ApplicantDocumentInfo Obj in objDocArr)
                    {

                        int docID = Obj.DocumentID;
                        (new ApplicantDocumentController()).Delete(docID);
                    }
                
                ArrayList ObjArr = new ArrayList();
                foreach (GridViewRow g1 in GViewDoc.Rows)
                {
                    ApplicantDocumentInfo objDocInfo = new ApplicantDocumentInfo();

                   
                    objDocInfo.DocumentType = g1.Cells[0].Text;
                    objDocInfo.DocumentPath = g1.Cells[1].Text;                  
                    objDocInfo.ApplicantID_FK = Convert.ToInt32(g1.Cells[2].Text);
                   // ObjArr.Add(objDocInfo);
                    int DocID = (new ApplicantDocumentController()).Add(objDocInfo);
                    if (DocID > 0)
                    {
                        //lblQualificationMessage.Visible = true;
                        lblDoc.Text = "Document uploaded  successfully, click next to continue";
                    }
                    else
                    {
                        lblDoc.Text = "Error! Documents not uploaded";
                    }
                }
            }
            catch { }
        }
        protected void docUploadBtn_Click(object sender, EventArgs e)
        {
            if (UploadDocument.HasFile)
            {



                string DocName = UploadDocument.FileName.ToString();
                string folder = "~/UploadedDocument/";
                string DocPath = HttpContext.Current.Server.MapPath(folder).ToString();

                //lblPassportName.Text = DocName;
                Session["DocPath"] = DocPath;
                ViewState.Add("DocName", DocName);
            }
        }
        protected void qualiSaveBtn_Click(object sender, EventArgs e)
        {
            try 
            {
                int applicantID = Convert.ToInt32(ViewState["applicantID"]);

                //ArrayList ObjArr = new ArrayList();
                ArrayList ObjArrQualification = new ArrayList();
                ObjArrQualification = (new ApplicantQualificationController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrQualification.Count > 0)
                    foreach (ApplicantQualificationInfo Obj in ObjArrQualification)
                    {
                        //ApplicantQualificationInfo objQualif = new ApplicantQualificationInfo();
                        //objQualif.QualificationID = Obj.QualificationID;
                        int qualificationID = Obj.QualificationID;
                        (new ApplicantQualificationController()).Delete(qualificationID);
                    }
                ArrayList ObjArr = new ArrayList();
                foreach (GridViewRow g1 in GViewQualif.Rows)
                {
                    ApplicantQualificationInfo objQualificationInfo = new ApplicantQualificationInfo();

                    //objQualificationInfo.QualificationID= Convert.ToInt32(GridView1.Rows[i].Cells[1].Text);
                    objQualificationInfo.InstitutionName = g1.Cells[0].Text;

                    objQualificationInfo.QualificationType = g1.Cells[1].Text;
                    objQualificationInfo.Course = g1.Cells[2].Text;
                    objQualificationInfo.Grade = g1.Cells[3].Text;
                    objQualificationInfo.StartYear = g1.Cells[4].Text;
                    objQualificationInfo.EndYear = g1.Cells[5].Text;
                    objQualificationInfo.ApplicantID_FK = Convert.ToInt32(g1.Cells[6].Text);
                    ObjArr.Add(objQualificationInfo);
                    int qualiicationID = (new ApplicantQualificationController()).Add(objQualificationInfo);
                    if (qualiicationID > 0)
                    {
                        //lblQualificationMessage.Visible = true;
                        lblqualif.Text = "Qualifications Added Successfully, Click next to provide your professional qualification";
                    }
                    else
                    {
                        lblqualif.Text = " Error! Qualification not added.";
                    }
                }
               
              
            }
            catch (Exception ex)
            {
                
                    string msg = "You are inserting duplicate values  ";
                    msg += ex.Message;
                    Utility.Alert(msg);
                   // Alert.Show("You are inserting duplicate values");
                
            }
                
            
        }

        protected void certSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int applicantID = Convert.ToInt32(ViewState["applicantID"]);

               
                ArrayList ObjArrProfQualification = new ArrayList();
                ObjArrProfQualification = (new ApplicantProfQualificationController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrProfQualification.Count > 0)
                    foreach (ApplicantProfQualificationInfo Obj in ObjArrProfQualification)
                    {
                        
                        int profQualificationID = Obj.ProfQualificationID;
                        (new ApplicantProfQualificationController()).Delete(profQualificationID);
                    }
                ArrayList ObjArr = new ArrayList();
                foreach (GridViewRow g1 in GViewCert.Rows)
                {
                    ApplicantProfQualificationInfo objProfQualificationInfo = new ApplicantProfQualificationInfo();

                    //objQualificationInfo.QualificationID= Convert.ToInt32(GridView1.Rows[i].Cells[1].Text);
                    objProfQualificationInfo.CertificationName = g1.Cells[0].Text;
                    objProfQualificationInfo.Stage = g1.Cells[1].Text;
                    objProfQualificationInfo.CertificateNo = g1.Cells[2].Text;
                    objProfQualificationInfo.CertYear = g1.Cells[3].Text;                 
                    objProfQualificationInfo.ApplicantID_FK = Convert.ToInt32(g1.Cells[4].Text);
                    ObjArr.Add(objProfQualificationInfo);
                    int ProfqualiicationID = (new ApplicantProfQualificationController()).Add(objProfQualificationInfo);
                    if (ProfqualiicationID > 0)
                    {
                        //lblQualificationMessage.Visible = true;
                        lblprof.Text = "Professional Qualifications Added Successfully, Click next to enter your Working Experience";
                    }
                    else
                    {
                        lblprof.Text = "Error! Professional Qualifications  not Added ";
                    }
                }
            }
            catch { }
        }
        protected void workSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int applicantID = Convert.ToInt32(ViewState["applicantID"]);


                ArrayList ObjWrkExp = new ArrayList();
                ObjWrkExp = (new ApplicantWorkExperienceController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjWrkExp.Count > 0)
                    foreach (ApplicantWorkExperienceInfo Obj in ObjWrkExp)
                    {

                        int workExpID = Obj.WorkExperienceID;
                        (new ApplicantWorkExperienceController()).Delete(workExpID);
                    }
                ArrayList ObjArr = new ArrayList();
                foreach (GridViewRow g1 in GViewWorkExp.Rows)
                {
                    ApplicantWorkExperienceInfo objWorkExpInfo = new ApplicantWorkExperienceInfo();

                    //objQualificationInfo.QualificationID= Convert.ToInt32(GridView1.Rows[i].Cells[1].Text);
                    objWorkExpInfo.CompanyName = g1.Cells[0].Text;
                    objWorkExpInfo.PositionHeld = g1.Cells[1].Text;
                    objWorkExpInfo.JobDescriprtion = g1.Cells[2].Text;
                    objWorkExpInfo.SalaryReceived = g1.Cells[3].Text;
                    objWorkExpInfo.StartYear = g1.Cells[4].Text;
                    objWorkExpInfo.EndYear = g1.Cells[5].Text;
                    objWorkExpInfo.ApplicantID_FK = Convert.ToInt32(g1.Cells[6].Text);
                    ObjArr.Add(objWorkExpInfo);
                    int workExpID = (new ApplicantWorkExperienceController()).Add(objWorkExpInfo);
                    if (workExpID > 0)
                    {
                        //lblQualificationMessage.Visible = true;
                        lblworkExp.Text = "Working Experience added successfully, click next to upload document";
                    }
                    else
                    {
                        lblworkExp.Text = "Error! Working Experience  not added";
                    }
                }
            }
            catch { }
        }
        protected void DocumentNextBtn_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 6;
           // int applicantID = Convert.ToInt32(Session["applicantnumber"]);
            int applicantID = Convert.ToInt32(ViewState["applicantID"]);
            ArrayList ObjArr = new ArrayList();
            ApplicantPersonalDetailsInfo objPersonalDetailInfo = new ApplicantPersonalDetailsInfo();
            objPersonalDetailInfo = (new ApplicantPersonalDetailsController()).Get(applicantID);
            lblPositionAppliedFor.Text = objPersonalDetailInfo.PositionAppliedFor;
            lbltitle.Text = objPersonalDetailInfo.Title;
            lblApplicantNum.Text = objPersonalDetailInfo.ApplicantNum;
            lblFirstName.Text = objPersonalDetailInfo.FirstName;
            lblLastName.Text = objPersonalDetailInfo.LastName;
            lblMiddleName.Text = objPersonalDetailInfo.MiddleName;
            lblGender.Text = objPersonalDetailInfo.Gender;
            lblMaritalStatus.Text = objPersonalDetailInfo.MaritalStatus;
            lblReligion.Text = objPersonalDetailInfo.Title;
            lblDOB.Text = objPersonalDetailInfo.DateOfBirth;
            lblAge.Text = objPersonalDetailInfo.Age.ToString();
            lblNationality.Text = objPersonalDetailInfo.Nationality;
            lblStateofOrigin.Text = objPersonalDetailInfo.StateOfOrigin;
            lblLGA.Text = objPersonalDetailInfo.LGA;
            lblHomeTown.Text = objPersonalDetailInfo.HomeTown;
            lblEmail.Text = objPersonalDetailInfo.Email;
            lblPhoneNo.Text = objPersonalDetailInfo.PhoneNo;
            lblContactAddress.Text = objPersonalDetailInfo.ContactAddress;
            ImagePassport.ImageUrl = "~/image/" + objPersonalDetailInfo.Passport.Substring(objPersonalDetailInfo.Passport.LastIndexOf('\\')+1);
           
            

            // Qualification summary
            ArrayList ObjArrQualification = new ArrayList();
            ObjArrQualification = (new ApplicantQualificationController()).GetByApplicantPersonalDetails(applicantID);
            if (ObjArrQualification.Count > 0)
            {
            
                GViewQualifSummary.DataSource = (ObjArrQualification);
                GViewQualifSummary.DataBind();
                GViewQualifSummary.Visible = true;
            }

            //  professional Qualification summary
            ArrayList ObjArrProfQualification = new ArrayList();
            ObjArrProfQualification = (new ApplicantProfQualificationController()).GetByApplicantPersonalDetails(applicantID);
            if(ObjArrProfQualification.Count >0)
            {
                GViewProfQualifSummary.DataSource = (ObjArrProfQualification);
                GViewProfQualifSummary.DataBind();
                GViewProfQualifSummary.Visible = true;
            }
            //  Wwork Experience summary
            ArrayList ObjArrWorkExp = new ArrayList();
            ObjArrWorkExp = (new ApplicantWorkExperienceController()).GetByApplicantPersonalDetails(applicantID);
            if (ObjArrWorkExp.Count > 0)
            {
                GViewWorkExpSummary.DataSource = (ObjArrWorkExp);
                GViewWorkExpSummary.DataBind();
                GViewWorkExpSummary.Visible = true;
            }

            //  Document summary
            ArrayList ObjArrDoc = new ArrayList();
            ObjArrDoc = (new ApplicantDocumentController()).GetByApplicantPersonalDetails(applicantID);
            if (ObjArrDoc.Count > 0)
            {
                GViewDocSummary.DataSource = (ObjArrDoc);
                GViewDocSummary.DataBind();
                GViewDocSummary.Visible = true;
            }
        }

      


        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList objCountry = new ArrayList();
            int countryID = Convert.ToInt32(ddlCountry.SelectedValue);
            objCountry = (new StateTableController()).GetByCountryTable(countryID);
            if (objCountry.Count > 0)
            {
                ddlState.DataSource = objCountry;
                ddlState.DataTextField = "StateName";
                ddlState.DataValueField = "StateID";
                ddlState.DataBind();

                ddlState.Items.Insert(0, new ListItem("---Please selct---", "-1"));
            }
        }
        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList objState = new ArrayList();
            int stateID = Convert.ToInt32(ddlState.SelectedValue);
            objState = (new LGATableController()).GetByStateTable(stateID);
            if (objState.Count > 0)
            {
                ddlLga.DataSource = objState;
                ddlLga.DataTextField = "LgaName";
                ddlLga.DataValueField = "LgaID";
                ddlLga.DataBind();

                ddlLga.Items.Insert(0, new ListItem("---Please select---", "-1"));
            }
        }
        protected void qualifList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ArrayList objQualifications = new ArrayList();
            //int qualifID = Convert.ToInt32(qualifList.SelectedValue);
            //objQualifications = (new GradeTableController()).GetByQualifications(qualifID);

            //if (objQualifications.Count > 0)
            //{
            //    gradeList.DataSource = objQualifications;
            //    gradeList.DataTextField = "gradeName";
            //    gradeList.DataValueField = "gradeID";
            //    gradeList.DataBind();

            //    gradeList.Items.Insert(0, new ListItem("---Grades---", "-1"));
            //}
        }


        protected void passportUploadBtn_Click(object sender, EventArgs e)
        {
            if (UploadPassport.HasFile)
            {
                HttpPostedFile file = UploadPassport.PostedFile;
                int filesize = file.ContentLength; // get file size
                string filename = UploadPassport.FileName.ToString(); // get file  full name  including extension

                // upload the file

                    string uploadfolderpath = "~/Image/";
                    filepath2 = HttpContext.Current.Server.MapPath(uploadfolderpath).ToString();
                    UploadPassport.SaveAs(filepath2 + "\\" + filename);
                    Image1.ImageUrl = "~/Image/" + "/" + UploadPassport.FileName.ToString();
                    lblPassportName.Text = filename;
                    Session["passportPath"] = filepath2;
                    ViewState.Add("var", filename);
                            
                var fileExtension = filename.Substring(filename.LastIndexOf("."));// file extension

                // validating file type and size
                //if (fileExtension != ".png" || fileExtension != ".jpg")//|| fileExtension != ".jpeg" || fileExtension != ".jpg")
                //{
                //    lblinvalidPicture.Text = "Error! You can only upload an image file";
                //}
                //else if (filesize > 13312) //1MB 1048576  //13312=13kb
                //{
                //    lblinvalidPicture.Text = "Error! Picture size must not exceed 13kb";
                //}
                //else
                //{
                //    // upload the file

                //    string uploadfolderpath = "~/Image/";
                //    filepath2 = HttpContext.Current.Server.MapPath(uploadfolderpath).ToString();
                //    UploadPassport.SaveAs(filepath2 + "\\" + filename);
                //    Image1.ImageUrl = "~/Image/" + "/" + UploadPassport.FileName.ToString();
                //    lblPassportName.Text = filename;
                //    Session["passportPath"] = filepath2;
                //    ViewState.Add("var", filename);

                //}

                          

              
                // string filepath3 = "~/Image/"+ "/" + UploadPassport.FileName.ToString();

                // ViewState.Add("passportNameView", lblPassportName);

                //string uploadfolderpath = "~/Image/";

                //ViewState["PassportName"] = UploadPassport.FileName.ToString();

                //string filepath = HttpContext.Current.Server.MapPath(uploadfolderpath);
                // filepath2 = HttpContext.Current.Server.MapPath(uploadfolderpath).ToString();
                // Session["passportPath"] = filepath2;
                //UploadPassport.SaveAs(filepath + "\\" + ViewState["PassportName"]);
                //Image1.ImageUrl = "~/Image/" + "/" + UploadPassport.FileName.ToString();
                //string passportNameView = ViewState["PassportName"].ToString();

                // alternative
               //string var2 = ViewState["var"].ToString();


               // lblPassportName.Text = ViewState["passPortName"].ToString();
               // filepath2 = HttpContext.Current.Server.MapPath(uploadfolderpath);
               // UploadPassport.SaveAs(ViewStafilepath"] + "\\" + ViewState["passPortName"]);
               // Image1.ImageUrl = "~/Image/" + "/" + UploadPassport.FileName.ToString();
                //LbUploadSuccessful.Visible = true;
                //LbUploadSuccessful.Text = "Image successfully uploaded";
                //UploadPassport.PostedFile.SaveAs(Server.MapPath("~/Image/") + passPortName);
                // passport = "~/Image/" + passPortName.ToString();

                //Bitmap myBmp = Bitmap.FromFile("path here");

            }

            else
            {
               // LbUploadSuccessful.Visible = true;
               // LbUploadSuccessful.Text = "Plz try uploading again";
            }
        }

        //Calculate age
       

        protected void appSaveBtn_Click(object sender, EventArgs e)
        {

           
            try
            {
               
                ApplicantPersonalDetailsInfo objApplicant = new ApplicantPersonalDetailsInfo();

                //Collecting applicant personal details

                objApplicant.PositionAppliedFor = this.ddlAvailablePosition.SelectedValue.Trim();
                objApplicant.Title = this.ddlTitle.SelectedValue;
                objApplicant.FirstName = this.txtFName.Text.Trim();
                objApplicant.MiddleName = this.txtMName.Text.Trim();
                objApplicant.LastName = this.txtLName.Text.Trim();
                objApplicant.Gender = this.rbtnGender.SelectedValue.Trim();

                objApplicant.DateOfBirth = ddlDay.SelectedItem + "-" + ddlMonth.SelectedItem + "-" + ddlYear.SelectedItem;
                objApplicant.Age = txtAge.Text;
                objApplicant.MaritalStatus = this.ddlMaritalStatus.SelectedValue.Trim();
                objApplicant.Religion = this.ddlReligion.SelectedValue;
                objApplicant.Nationality_FK = Convert.ToInt32(this.ddlCountry.SelectedItem.Value);
                objApplicant.StateOfOrigin_FK = Convert.ToInt32(this.ddlState.SelectedItem.Value);


                objApplicant.LGA_FK = Convert.ToInt32(this.ddlLga.SelectedItem.Value);
                objApplicant.HomeTown = txtHometown.Text.Trim();
                objApplicant.Email = this.txtEmail.Text.Trim();
                objApplicant.PhoneNo = this.txtPhnNum.Text.Trim();
                objApplicant.ContactAddress = this.txtContAddr.Text.Trim();


                string var2 = ViewState["var"].ToString();
                string path2 = Session["passportPath"].ToString();
                objApplicant.Passport = path2 + var2;
                string applicantNum2;
                if (txtApplicationNum.Text != "")
                {
                    applicantNum2 = txtApplicationNum.Text;
                }
                else
                {
                    applicantNum2 = lblNotVisibleApplicantNum.Text;
                    lblNotVisibleApplicantNum.Visible = false;
                }
               // string applicantNumFrmContinueApp = txtApplicationNum.Text;

                // ViewState["applicantNum"].ToString==""
               // string APPNO = lblNotVisibleApplicantNum.Text; 

               // string applicantNumFrmContinueApp = txtApplicationNum.Text;
                if (applicantNum2 == "")
                {
                    applicantID = (new ApplicantPersonalDetailsController()).Add(objApplicant);

                    if (applicantID > 0)
                    {
                        string appplicantid = applicantID.ToString();


                        string applicantNum = ("NTL" + "/" + DateTime.Now.ToString("yyyy") + "/" + appplicantid).ToString();
                        //string applicantNum = ("NTL"  + "/" + appplicantid).ToString();
                        ViewState.Add("applicantID", applicantID);
                        ViewState.Add("applicantNum", applicantNum);
                        ApplicantPersonalDetailsInfo objApplicant2 = new ApplicantPersonalDetailsInfo();
                        objApplicant2.ApplicantID = Convert.ToInt32(applicantID);
                        objApplicant2.ApplicantNum = applicantNum;
                        (new ApplicantPersonalDetailsController()).UpdateApplicantNum(objApplicant2);

                        //  Alert.Show("Detail added successfully" + "\n" + "Your application number is: " + applicantNum);
                        qualifSaveBtn.Visible = true;
                        LbDetailsAdded.Visible = true;
                        LbDetailsAdded.Text = "Detial Successfully Added,Your application number is:  " + applicantNum;
                        Utility.Alert("Detail added successfully.  Your application number is: " + applicantNum+ "   Click next to continue");
                        ApplicantNextBtn.Visible = true;
                        ApplicantNextBtn.Enabled = true;
                        //refereshPage();
                    }
                    else
                    {
                        LbDetailsAdded.Text = "Error! Details not added.";
                        LbDetailsAdded.Visible = true;
                    }
                }
                else 
                {
                    objApplicant.ApplicantNum = applicantNum2;
                    objApplicant.ApplicantID = Convert.ToInt32(applicantNum2.Substring(applicantNum2.LastIndexOf('/') + 1));
                    (new ApplicantPersonalDetailsController()).UpdateUsingApplicantNum(objApplicant);
                    string applicantNum = applicantNum2;
                    
                    ViewState.Add("applicantNum", applicantNum);
                    qualifSaveBtn.Visible = true;
                    LbDetailsAdded.Text = "Detial Successfully Updated, Click next to continue";
                    ApplicantNextBtn.Visible = true;
                    ApplicantNextBtn.Enabled = true;
                    Utility.Alert("Detial Successfully Updated, Click next to continue");
                   
                }                
                 
            }

            catch
            {

            }

            //Session["applicantnumber"] = applicantID;
        }
        
       
        protected void ddlYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Today; //get today's date
            int age = now.Year - Convert.ToInt32(ddlYear.SelectedValue);
            txtAge.Text = Convert.ToString(age);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 0;
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 1;
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 2;
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 3;
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 4;
        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 5;
        }
        protected void Button9_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 6;
           // Button9.ForeColor = CC3300;
        }

       

        protected void qualifAddBtn_Click1(object sender, EventArgs e)
        {
          
            int applicantID = Convert.ToInt32(ViewState["applicantID"]);                    

            ArrayList ObjArr = new ArrayList();

            if (GViewQualif.Rows.Count > 0)
            {
                for (int i = 0; i < GViewQualif.Rows.Count; i++)
                {
                    ApplicantQualificationInfo ObjApplicantQualification = new ApplicantQualificationInfo();
                    ObjApplicantQualification.InstitutionName = GViewQualif.Rows[i].Cells[0].Text.ToString();
                    ObjApplicantQualification.QualificationType = GViewQualif.Rows[i].Cells[1].Text.ToString();
                    ObjApplicantQualification.Course = GViewQualif.Rows[i].Cells[2].Text.ToString();
                    ObjApplicantQualification.Grade = GViewQualif.Rows[i].Cells[3].Text.ToString();
                    ObjApplicantQualification.StartYear = GViewQualif.Rows[i].Cells[4].Text.ToString();
                    ObjApplicantQualification.EndYear = GViewQualif.Rows[i].Cells[5].Text.ToString();
                    ObjApplicantQualification.ApplicantID_FK = Convert.ToInt32(GViewQualif.Rows[i].Cells[6].Text);
                    ObjArr.Add(ObjApplicantQualification);
                   
                }


            }
            ApplicantQualificationInfo ObjApplicantQualification2 = new ApplicantQualificationInfo();
            ObjApplicantQualification2.InstitutionName = this.txtQualifSchName.Text.Trim();
            ObjApplicantQualification2.QualificationType = this.qualifList.SelectedItem.Text;
            ObjApplicantQualification2.Course = this.courseList.SelectedItem.Text.Trim();
            ObjApplicantQualification2.Grade = this.gradeList.SelectedItem.Text;
            ObjApplicantQualification2.StartYear = this.qualifStartYearList.SelectedItem.Text;
            ObjApplicantQualification2.EndYear = this.qualifEndYearList.SelectedItem.Text;
            ObjApplicantQualification2.ApplicantID_FK = applicantID;
            ObjArr.Add(ObjApplicantQualification2);
            GViewQualif.DataSource = ObjArr;
            GViewQualif.DataBind();
            GViewQualif.Visible = true;
            txtQualifSchName.Text = "";
            courseList.ClearSelection();
            qualifList.ClearSelection();
            gradeList.ClearSelection();
            qualifStartYearList.ClearSelection();
            qualifEndYearList.ClearSelection();
            qualifSaveBtn.Visible = true;
            qualifSaveBtn.Enabled = true;
            

        }


        private void refereshPage()
        {
            ddlAvailablePosition.ClearSelection();
            this.txtFName.Text = "";
            this.txtMName.Text = "";
            this.txtLName.Text = "";
            this.txtLName.Text = "";
            this.txtEmail.Text = "";
            this.txtContAddr.Text = "";
            this.txtAge.Text = "";
            rbtnGender.ClearSelection();
            ddlCountry.ClearSelection();
            ddlState.ClearSelection();
            ddlLga.ClearSelection();
            this.txtHometown.Text = "";


        }
        protected void certAddBtn_Click(object sender, EventArgs e)
        {
            //int appicantID = Convert.ToInt32(Session["applicantnumber"]);
            int applicantID = Convert.ToInt32(ViewState["applicantID"]);
            GViewCert.Visible = true;
            certSaveBtn.Visible = true;
            ArrayList ObjArr = new ArrayList();

            if (GViewCert.Rows.Count > 0)
            {
                for (int i = 0; i < GViewCert.Rows.Count; i++)
                {
                    ApplicantProfQualificationInfo objProfQualification2 = new ApplicantProfQualificationInfo();
                    objProfQualification2.CertificationName = GViewCert.Rows[i].Cells[0].Text.ToString();
                    objProfQualification2.Stage = GViewCert.Rows[i].Cells[1].Text.ToString();
                    objProfQualification2.CertificateNo = GViewCert.Rows[i].Cells[2].Text.ToString();
                    objProfQualification2.CertYear = GViewCert.Rows[i].Cells[3].Text.ToString();


                   objProfQualification2.ApplicantID_FK = Convert.ToInt32(GViewCert.Rows[i].Cells[4].Text);
                    ObjArr.Add(objProfQualification2);

                }


            }

            ApplicantProfQualificationInfo objProfQualification = new ApplicantProfQualificationInfo();
            objProfQualification.CertificationName = txtCertName.Text.Trim();
            objProfQualification.Stage = certStageList.SelectedItem.Text.Trim();
            objProfQualification.CertificateNo = txtCertNum.Text.Trim();
            objProfQualification.CertYear = ddlCertYear.SelectedItem.Text.Trim();

            objProfQualification.ApplicantID_FK = applicantID;
            ObjArr.Add(objProfQualification);
            GViewCert.DataSource = ObjArr;
            GViewCert.DataBind();
            GViewCert.Visible = true;
            txtCertName.Text = " ";
            certStageList.ClearSelection();
            txtCertNum.Text = " ";
            ddlCertYear.ClearSelection();

        }
        protected void workAddBtn_Click(object sender, EventArgs e)
        {
            //int applicantID = Convert.ToInt32(Session["applicantnumber"]);
            int applicantID = Convert.ToInt32(ViewState["applicantID"]);
            
            workSaveBtn.Visible = true;


            ArrayList objArr = new ArrayList();
            if (GViewWorkExp.Rows.Count > 0)
            {
                for (int i = 0; i < GViewWorkExp.Rows.Count; i++)
                {
                    ApplicantWorkExperienceInfo objworkExp = new ApplicantWorkExperienceInfo();
                    objworkExp.CompanyName = GViewWorkExp.Rows[i].Cells[0].Text.ToString();
                    objworkExp.PositionHeld = GViewWorkExp.Rows[i].Cells[1].Text.ToString();
                    objworkExp.JobDescriprtion = GViewWorkExp.Rows[i].Cells[2].Text.ToString();
                    objworkExp.SalaryReceived = GViewWorkExp.Rows[i].Cells[3].Text.ToString();
                    objworkExp.StartYear = GViewWorkExp.Rows[i].Cells[4].Text.ToString();
                    objworkExp.EndYear = GViewWorkExp.Rows[i].Cells[5].Text.ToString();
                    objworkExp.ApplicantID_FK = Convert.ToInt32(GViewWorkExp.Rows[i].Cells[6].Text);
                    objArr.Add(objworkExp);
                }
            }
            ApplicantWorkExperienceInfo objworkExp2 = new ApplicantWorkExperienceInfo();
            objworkExp2.CompanyName = txtCompanyName.Text.Trim();
            objworkExp2.PositionHeld = txtPositionHeld.Text.Trim();
            objworkExp2.JobDescriprtion = txtWorkJobDesc.Text.Trim();
            objworkExp2.SalaryReceived = txtWorkSalary.Text.Trim();
            objworkExp2.StartYear = this.ddlWorkStartDay.SelectedItem + "-" + this.ddlWorkStartMonth.SelectedItem + "-" + this.ddlWorkStartYear.SelectedItem;
            objworkExp2.EndYear = this.ddlWorkEndDay.SelectedItem + "-" + this.ddlWorkEndMonth.SelectedItem + "-" + this.ddlWorkEndYear.SelectedItem;
            objworkExp2.ApplicantID_FK = applicantID;
            objArr.Add(objworkExp2);
            GViewWorkExp.DataSource = objArr;
            GViewWorkExp.DataBind();
            GViewWorkExp.Visible = true;
            txtCompanyName.Text = "";
            txtPositionHeld.Text = "";
            txtWorkJobDesc.Text = "";
            txtWorkSalary.Text = "";
            ddlWorkStartDay.ClearSelection();
            ddlWorkStartMonth.ClearSelection();
            ddlWorkStartYear.ClearSelection();
            ddlWorkEndDay.ClearSelection();
            ddlWorkEndMonth.ClearSelection();
            ddlWorkEndYear.ClearSelection();

        }
       
       
        protected void ddlYear2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 5;
        }
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 0;
        }
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 1;
        }
        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 2;
        }
        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 3;
        }
        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 4;
        }
        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 6;
        }
        protected void docAddBtn_Click(object sender, EventArgs e)
        {
            //int applicantID = Convert.ToInt32(Session["applicantnumber"]);
            int applicantID = Convert.ToInt32(ViewState["applicantID"]);
            docSaveBtn.Visible = true;

            ArrayList objArr = new ArrayList();


            if (UploadDocument.HasFile)
            {



                string DocName = UploadDocument.FileName.ToString();
                string folder = "~/UploadedDocument/";
                string DocPath = HttpContext.Current.Server.MapPath(folder).ToString();
                UploadPassport.SaveAs(DocPath + "\\" + DocName);
                //lblPassportName.Text = DocName;
                //Session["DocPath"] = DocPath;
                //ViewState.Add("DocName", DocName);


                if (GViewDoc.Rows.Count > 0)
                {
                    for (int i = 0; i < GViewDoc.Rows.Count; i++)
                    {
                        ApplicantDocumentInfo objDoc2 = new ApplicantDocumentInfo();
                        objDoc2.DocumentType = GViewDoc.Rows[i].Cells[0].Text.ToString();
                        objDoc2.DocumentPath = GViewDoc.Rows[i].Cells[1].Text.ToString();
                        objDoc2.ApplicantID_FK = Convert.ToInt32(GViewDoc.Rows[i].Cells[2].Text);
                        objArr.Add(objDoc2);
                    }
                }
                ApplicantDocumentInfo objDoc = new ApplicantDocumentInfo();
                objDoc.DocumentType = ddlDocumentTpe.SelectedItem.Text;
                objDoc.DocumentPath = (DocPath + "\\" + DocName);
                objDoc.ApplicantID_FK = applicantID;
                objArr.Add(objDoc);
                GViewDoc.DataSource = objArr;
                GViewDoc.DataBind();
                GViewDoc.Visible = true;
                ddlDocumentTpe.ClearSelection();
            }
            
            
        }

        protected void btnEditPersonalDetails_Click(object sender, EventArgs e)
        {

            MViewApplicant.ActiveViewIndex = 1;
            string applicantNum = lblApplicantNum.Text;

            ApplicantPersonalDetailsInfo objPersonalDetail = new ApplicantPersonalDetailsInfo();

            objPersonalDetail = new ApplicantPersonalDetailsController().GetByApplicantNum(applicantNum);
            ddlAvailablePosition.ClearSelection();
            ddlAvailablePosition.Items.FindByText(objPersonalDetail.PositionAppliedFor).Selected = true;
            ddlTitle.ClearSelection();
            ddlTitle.Items.FindByText(objPersonalDetail.Title).Selected = true;
            txtFName.Text = objPersonalDetail.FirstName;
            txtMName.Text = objPersonalDetail.MiddleName;
            txtLName.Text = objPersonalDetail.LastName;
            ddlMaritalStatus.ClearSelection();
            ddlMaritalStatus.Items.FindByText(objPersonalDetail.MaritalStatus).Selected = true;
            ddlReligion.ClearSelection();
            ddlReligion.Items.FindByText(objPersonalDetail.Religion).Selected = true;
            txtEmail.Text = objPersonalDetail.Email;
            txtContAddr.Text = objPersonalDetail.ContactAddress;
            txtPhnNum.Text = objPersonalDetail.PhoneNo;
            if (objPersonalDetail.Gender == "Male")
            {
                rbtnGender.SelectedIndex = 0;
            }
            else
            {
                rbtnGender.SelectedIndex = 1;
            }
            ddlDay.ClearSelection();
            ddlDay.Items.FindByText(objPersonalDetail.DateOfBirth.Substring(0, 2)).Selected = true;
            ddlMonth.ClearSelection();
            ddlMonth.SelectedItem.Text = objPersonalDetail.DateOfBirth.Substring(3, objPersonalDetail.DateOfBirth.LastIndexOf('-') - 3);
            ddlYear.ClearSelection();
            ddlYear.SelectedItem.Text = objPersonalDetail.DateOfBirth.Substring(objPersonalDetail.DateOfBirth.LastIndexOf('-') + 1);


            txtAge.Text = objPersonalDetail.Age;
            ddlCountry.ClearSelection();
            ddlCountry.Items.FindByText(objPersonalDetail.Nationality).Selected = true;

            // reload state drop downlist
            ddlState.ClearSelection();
            ddlState.DataSource = (new StateTableController()).List();
            ddlState.DataValueField = "StateID";
            ddlState.DataTextField = "StateName";
            ddlState.DataBind();
            ddlState.Items.Insert(0, new ListItem((new StateTableController()).Get(objPersonalDetail.StateOfOrigin_FK).StateName, objPersonalDetail.StateOfOrigin_FK.ToString()));

            // reload lga drop downlist
            ddlLga.ClearSelection();
            ddlLga.DataSource = (new LGATableController()).List();
            ddlLga.DataValueField = "LgaID";
            ddlLga.DataTextField = "LgaName";
            ddlLga.DataBind();
            ddlLga.Items.Insert(0, new ListItem((new LGATableController()).Get(objPersonalDetail.LGA_FK).LgaName, objPersonalDetail.LGA_FK.ToString()));


            // ddlLga.SelectedItem.Text = objPersonalDetail.LGA;

            
            txtHometown.Text = objPersonalDetail.HomeTown;
            Image1.ImageUrl = "~/Image/" + objPersonalDetail.Passport.Substring(objPersonalDetail.Passport.LastIndexOf('\\') + 1);
            // UploadPassport.DataBind = objPersonalDetail.Passport;
            ImagePassport.Visible = true;
            lblNotVisibleApplicantNum.Text = objPersonalDetail.ApplicantNum;


            // UploadPassport.
           // lblNotVisibleApplicantNum.Text = lblApplicantNum.Text;
           // ddlAvailablePosition.SelectedItem.Text = lblPositionAppliedFor.Text;
           // txtFName.Text = lblFirstName.Text;
           // txtMName.Text = lblMiddleName.Text;
           // txtLName.Text = lblLastName.Text;
           // ddlMaritalStatus.SelectedItem.Text = lblMaritalStatus.Text;
           // txtEmail.Text = lblEmail.Text;
           // txtPhnNum.Text = lblPhoneNo.Text;
           // txtContAddr.Text = lblContactAddress.Text;

            
           // if (lblGender.Text == "Male")
           // {
           //     rbtnGender.SelectedIndex = 0;
           // }
           // else
           // {
           //     rbtnGender.SelectedIndex = 1;
           // }

           // // remaing dob
         //   ddlDay.SelectedItem.Text = lblDOB.Text;
       //   DateTime ttdate = Convert.ToDateTime(lblDOB.Text);
        
        //  int  month=     ttdate.Month;
        //  int day = ttdate.Day;
        //  int year = ttdate.Year;
          //  string month = lblDOB.Text;
           // ddlDay.ClearSelection();
           // ddlDay.Items.FindByValue(ttdate.Day.ToString()).Selected = true;
           // ddlMonth.ClearSelection();
           // ddlMonth.Items.FindByValue(ttdate.Month.ToString()).Selected = true;
           // ddlYear.ClearSelection();
           // ddlYear.Items.FindByValue(ttdate.Year.ToString()).Selected = true;
           // //ddlMonth.SelectedItem.Text = month.Substring(4, month.LastIndexOf('-'));
           //// ddlYear.SelectedItem.Text = month.Substring(month.LastIndexOf('-'));
           // //ddlMonth.SelectedItem.Text=lbl
           // txtAge.Text = lblAge.Text;
           // ddlCountry.SelectedItem.Text = lblNationality.Text;
           // ddlState.SelectedItem.Text = lblStateofOrigin.Text;
           // ddlLga.SelectedItem.Text = lblLGA.Text;
           // txtHometown.Text = lblHomeTown.Text;
            

           
                       
        }
        //protected void GViewQualif_RowEditing(object sender, GridViewEditEventArgs e)
        //{
        //    GViewQualif.EditIndex = e.NewEditIndex;

        // txtQualifSchName.Text=   GViewQualif.Rows[e.NewEditIndex].Cells[0].Text;
        // courseList.SelectedItem.Text = GViewQualif.Rows[e.NewEditIndex].Cells[1].Text;
        // qualifList.SelectedItem.Text = GViewQualif.Rows[e.NewEditIndex].Cells[2].Text;
        // gradeList.SelectedItem.Text = GViewQualif.Rows[e.NewEditIndex].Cells[3].Text;
        // qualifStartYearList.SelectedItem.Text = GViewQualif.Rows[e.NewEditIndex].Cells[4].Text;
        // qualifEndYearList.SelectedItem.Text = GViewQualif.Rows[e.NewEditIndex].Cells[5].Text;
            
        //}
        protected void GViewQualif_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Update")
            {
                //find your textbox
                GridViewRow gvr = (GridViewRow)((LinkButton)e.CommandSource).NamingContainer;
                TextBox txtQualifSchName = (TextBox)gvr.FindControl("txtQualifSchName");
                string name = txtQualifSchName.Text;
            }

            if (e.CommandName == "Delete")
            {
                
                new ApplicantQualificationController().Delete(Convert.ToInt32(e.CommandArgument));
                int applicantID = (int)ViewState["applicantID"];
              
                ArrayList ObjArrQualification = new ArrayList();
                ObjArrQualification = (new ApplicantQualificationController()).GetByApplicantPersonalDetails(applicantID);
                 if (ObjArrQualification.Count != 0)
                {

                    GViewQualif.DataSource = (ObjArrQualification);
                    GViewQualif.DataBind();

                }
              
            }

        }
        protected void Button10_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 1;
        }
        protected void GViewDoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void submitAppBtn_Click(object sender, EventArgs e)
        {
           // Response.("<script>alert('Application successfull'))</script>");
           // PageUtility.MessageBox(this, "Application SuccessFull");
           // string msg = "You have successfully apply for the post of ";

            Utility.Alert("You save successfully applied for the post of "+ lblPositionAppliedFor.Text +" your application number is: "+ lblApplicantNum.Text );
           

        }
        protected void Button11_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 7;
        }
        protected void Button12_Click(object sender, EventArgs e)
        {
           
            string applicantNum= txtApplicationNum.Text;
            ViewState.Add("applicantNum", applicantNum);
            //int applicantID= Convert.ToInt32( applicantNum.Substring(applicantNum.LastIndexOf("\\")));

            ApplicantPersonalDetailsInfo objPersonalDetail = new ApplicantPersonalDetailsInfo();
            
            objPersonalDetail = new ApplicantPersonalDetailsController().GetByApplicantNum(applicantNum);
            ddlAvailablePosition.ClearSelection();
            ddlAvailablePosition.Items.FindByText(objPersonalDetail.PositionAppliedFor).Selected = true;
            txtFName.Text = objPersonalDetail.FirstName;
            txtMName.Text = objPersonalDetail.MiddleName;
            txtLName.Text = objPersonalDetail.LastName;
            ddlMaritalStatus.ClearSelection();
            ddlMaritalStatus.Items.FindByText(objPersonalDetail.MaritalStatus).Selected = true;
            txtEmail.Text = objPersonalDetail.Email;
            txtContAddr.Text = objPersonalDetail.ContactAddress;
            txtPhnNum.Text = objPersonalDetail.PhoneNo;
            if (objPersonalDetail.Gender == "Male")
            {
                rbtnGender.SelectedIndex = 0;
            }
            else
            {
                rbtnGender.SelectedIndex = 1;
            }
            ddlDay.ClearSelection();
            ddlDay.Items.FindByText(objPersonalDetail.DateOfBirth.Substring(0, 2)).Selected = true;
            ddlMonth.ClearSelection();
            ddlMonth.SelectedItem.Text = objPersonalDetail.DateOfBirth.Substring(3, objPersonalDetail.DateOfBirth.LastIndexOf('-')-3);
            ddlYear.ClearSelection();
            ddlYear.SelectedItem.Text = objPersonalDetail.DateOfBirth.Substring(objPersonalDetail.DateOfBirth.LastIndexOf('-')+1);

           
            txtAge.Text = objPersonalDetail.Age;
            ddlCountry.ClearSelection();
            ddlCountry.Items.FindByText(objPersonalDetail.Nationality).Selected = true;
            
            // reload state drop downlist
            ddlState.ClearSelection();
            ddlState.DataSource = (new StateTableController()).List();
            ddlState.DataValueField = "StateID";
            ddlState.DataTextField = "StateName";
            ddlState.DataBind();
            ddlState.Items.Insert(0, new ListItem((new StateTableController()).Get(objPersonalDetail.StateOfOrigin_FK).StateName, objPersonalDetail.StateOfOrigin_FK.ToString()));

            // reload lga drop downlist
            ddlLga.ClearSelection();
            ddlLga.DataSource = (new LGATableController()).List();
            ddlLga.DataValueField = "LgaID";
            ddlLga.DataTextField = "LgaName";
            ddlLga.DataBind();
            ddlLga.Items.Insert(0, new ListItem((new LGATableController()).Get(objPersonalDetail.LGA_FK).LgaName, objPersonalDetail.LGA_FK.ToString()));

            
           // ddlLga.SelectedItem.Text = objPersonalDetail.LGA;
            
            //ddlLga.Text = objPersonalDetail.LGA; 
           // ddlState.Items.FindByText(objPersonalDetail.StateOfOrigin).Selected = true;
            //ddlLga.ClearSelection();
            //ddlLga.Items.FindByText(objPersonalDetail.LGA).Selected = true;
            //ddlCountry.Items.FindByValue(objPersonalDetail.Nationality).Selected = true;
            //ddlState.Items.FindByValue(objPersonalDetail.StateOfOrigin).Selected = true;
           // ddlLga.Items.FindByValue(objPersonalDetail.LGA).Selected = true;
            txtHometown.Text = objPersonalDetail.HomeTown;
            Image1.ImageUrl = "~/Image/" + objPersonalDetail.Passport.Substring(objPersonalDetail.Passport.LastIndexOf('\\') + 1);
           // UploadPassport.DataBind = objPersonalDetail.Passport;
            ImagePassport.Visible = true;
           // UploadPassport.
            
            MViewApplicant.ActiveViewIndex = 1;
            ApplicantNextBtn.Enabled = true;

           // ApplicantNextBtn.Visible = false;
            
        }
        protected void GViewQualif_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //GViewQualif.EditIndex = e.NewEditIndex;
            //int index = Convert.ToInt32(e.RowIndex);
            //DataTable dt = ViewState["dt"] as DataTable;
            //GViewQualif.Rows[index].Delete();
        }
        protected void GViewCert_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                //ApplicantQualificationController objAPcon = new ApplicantQualificationController();
                //objAPcon.Delete(Convert.ToInt32(e.CommandArgument));
              
                new ApplicantProfQualificationController().Delete(Convert.ToInt32(e.CommandArgument));
                int applicantID = (int)ViewState["applicantID"];
                ArrayList ObjArrProfQualification = new ArrayList();
                ObjArrProfQualification = (new ApplicantProfQualificationController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrProfQualification.Count != 0)
                {

                    GViewCert.DataSource = (ObjArrProfQualification);
                    GViewCert.DataBind();

                }
               
            }
        }
        protected void GViewWorkExp_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                
                new ApplicantWorkExperienceController().Delete(Convert.ToInt32(e.CommandArgument));
                int applicantID = (int)ViewState["applicantID"];
                ArrayList ObjArrWrkExp = new ArrayList();
                ObjArrWrkExp = (new ApplicantWorkExperienceController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrWrkExp.Count != 0)
                {

                    GViewWorkExp.DataSource = (ObjArrWrkExp);
                    GViewWorkExp.DataBind();

                }

            }
        }
        protected void GViewDoc_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {

                new ApplicantDocumentController().Delete(Convert.ToInt32(e.CommandArgument));
                int applicantID = (int)ViewState["applicantID"];
                ArrayList ObjArrDoc = new ArrayList();
                ObjArrDoc = (new ApplicantDocumentController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrDoc.Count != 0)
                {

                    GViewDoc.DataSource = (ObjArrDoc);
                    GViewDoc.DataBind();

                }

            }
        }

        protected void GViewCert_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void GViewWorkExp_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void GViewDoc_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
}
}