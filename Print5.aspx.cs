using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bilikis.HRManagementSystem;
public partial class DesktopModules_HR_Record_Print5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request["id"].ToString();
        ApplicantPersonalDetailsInfo objPersonalInfo = new ApplicantPersonalDetailsInfo();
        objPersonalInfo = new ApplicantPersonalDetailsController().GetOfferDetails(Convert.ToInt32(id));
        lblName2.Text = objPersonalInfo.LastName + " " + objPersonalInfo.FirstName;
        lblPosition.Text = objPersonalInfo.ApprovedPositionName;
        lblOfferDept.Text = objPersonalInfo.DeptName;

        lblOfferPosition.Text = objPersonalInfo.ApprovedPositionName;
        lblOfferDept2.Text = objPersonalInfo.DeptName;
        lblOfferLevel.Text = objPersonalInfo.LevelName;
        lblOfferSalary.Text = objPersonalInfo.Salary;
        lblOfferWrkLocatn.Text = objPersonalInfo.LocationName;
        lblOfferRsmptDate.Text = objPersonalInfo.ResumptionDate;
        MultiView1.ActiveViewIndex = 0;
    }
    protected void btnPrint_Click(object sender, EventArgs e)
    {
        //Session["ctrl"] = Panel3;
        //Control ctrl = (Control)Session["ctrl"];
        // PrintHelper.PrintWebControl(ctrl);
      //  PrinterHelper.PrintWebControl(Panel3);
    //javascript: Print5.print();
        HttpContext.Current.Response.Write("<script>Print5.print();</script>");
    }
}