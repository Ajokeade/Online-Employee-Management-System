using System.Web;
using System.Text;
using System.Web.UI;using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNetNuke;
using DotNetNuke.Framework;
using System.Data;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Text;
using System;
using System.Data;
using System.Configuration;

using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web.SessionState;
using System.Net.Mail;




/// <summary>
/// A JavaScript alert
/// </summary>

namespace Bilikis.HRManagementSystem
{
    public static class Utility
    {

        /// <summary>
        /// Shows a client-side JavaScript alert in the browser.
        /// </summary>
        /// <param name="message">The message to appear in the alert.</param>
        public static void Alert(string message)
        {
            // Cleans the message to allow single quotation marks
            string cleanMessage = message.Replace("'", "\\'");
            string script = "<script type=\"text/javascript\">alert('" + cleanMessage + "');</script>";

            // Gets the executing web page
            Page page = HttpContext.Current.CurrentHandler as Page;

            // Checks if the handler is a Page and that the script isn't allready on the Page
            if (page != null && !page.ClientScript.IsClientScriptBlockRegistered("alert"))
            {
                page.ClientScript.RegisterClientScriptBlock(typeof(Utility), "alert", script);
            }
        }

        public static void SendMail(string mailSubject, string mailBody, string receiverEmail )
        {
            //send an email from a Gmail address using SMTP server.  
            //The Gmail SMTP server name is smtp.gmail.com and
            //the port using send mail is 587 and also using  

            //NetworkCredential for password based authentication;
            MailMessage mail = new MailMessage();
            //SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            //mail.IsBodyHtml = true;
            ////mail.From = new MailAddress("your_email_address@gmail.com");
            //mail.From = new MailAddress("olami@neetbeettech@gmail.com");

            //mail.Subject = mailSubject;
            //mail.Body = mailBody;
            //mail.To.Add(receiverEmail);

            //SmtpServer.Port = 587;
            //// SmtpServer.Port = 25;
            //SmtpServer.Credentials = new System.Net.NetworkCredential("olami@neetbeettech@gmail.com", "Adeniyi@2018");

            ////SmtpServer.UseDefaultCredentials = false;
            //SmtpServer.EnableSsl = true;

            //SmtpServer.Send(mail);
       
            //mail.Dispose();
        }

        public static void PrintWebControl(Control ctrl)
        {
            PrintWebControl(ctrl, string.Empty);
        }

        public static void PrintWebControl(Control ctrl, string Script)
        {
            StringWriter stringWrite = new StringWriter();
            System.Web.UI.HtmlTextWriter htmlWrite = new System.Web.UI.HtmlTextWriter(stringWrite);
            if (ctrl is WebControl)
            {
                Unit w = new Unit(100, UnitType.Percentage); ((WebControl)ctrl).Width = w;
            }
            Page pg = new Page();
            pg.EnableEventValidation = false;
            if (Script != string.Empty)
            {
                pg.ClientScript.RegisterStartupScript(pg.GetType(), "PrintJavaScript", Script);
            }
            HtmlForm frm = new HtmlForm();
            pg.Controls.Add(frm);
            frm.Attributes.Add("runat", "server");
            frm.Controls.Add(ctrl);
            pg.DesignerInitialize();
            pg.RenderControl(htmlWrite);
            string strHTML = stringWrite.ToString();
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.Write(strHTML);
            HttpContext.Current.Response.Write("<script>window.print();</script>");
            HttpContext.Current.Response.End();
        }
    }

    }


    //public static class PrintHelper
    //{
    //    public PrintHelper()
    //    {
    //        //
    //        // TODO: Add constructor logic here
    //        //
    //    }
    //    public static void PrintWebControl(Control ctrl)
    //    {
    //        PrintWebControl(ctrl, string.Empty);
    //    }

    //    public static void PrintWebControl(Control ctrl, string Script)
    //    {
    //        StringWriter stringWrite = new StringWriter();
    //        System.Web.UI.HtmlTextWriter htmlWrite = new System.Web.UI.HtmlTextWriter(stringWrite);
    //        if (ctrl is WebControl)
    //        {
    //            Unit w = new Unit(100, UnitType.Percentage); ((WebControl)ctrl).Width = w;
    //        }
    //        Page pg = new Page();
    //        pg.EnableEventValidation = false;
    //        if (Script != string.Empty)
    //        {
    //            pg.ClientScript.RegisterStartupScript(pg.GetType(), "PrintJavaScript", Script);
    //        }
    //        HtmlForm frm = new HtmlForm();
    //        pg.Controls.Add(frm);
    //        frm.Attributes.Add("runat", "server");
    //        frm.Controls.Add(ctrl);
    //        pg.DesignerInitialize();
    //        pg.RenderControl(htmlWrite);
    //        string strHTML = stringWrite.ToString();
    //        HttpContext.Current.Response.Clear();
    //        HttpContext.Current.Response.Write(strHTML);
    //        HttpContext.Current.Response.Write("<script>window.print();</script>");
    //        HttpContext.Current.Response.End();
    //    }
    //}

//}
