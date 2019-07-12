<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Print5.aspx.cs" Inherits="DesktopModules_HR_Record_Print5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

    .auto-style47 {
        width: 352px;
    }
    .auto-style33 {
        height: 23px;
        width: 123px;
    }
    .auto-style45 {
        height: 23px;
        width: 352px;
    }
    .auto-style1 {
        height: 23px;
    }
        .auto-style48 {
            height: 365px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
                <table style="width: 100%;">
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:Panel ID="Panel3" runat="server" Width="800px">
                                <table style="border: medium solid #C0C0C0; width:75%; margin-left:50px">
                                    <tr>
                                        <td class="auto-style46">&nbsp;</td>
                                        <td class="auto-style47">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style46">&nbsp;</td>
                                        <td class="auto-style47">&nbsp;</td>
                                        <td valign="right">
                                            <asp:Label ID="Label72" runat="server" Text="Neetbeet Technologies Limited"></asp:Label>
                                            <br />
                                            <asp:Label ID="Label73" runat="server" Text="13, Adekunbi Cresent , Off Toyin Street, Ikeja, Lagos."></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style46">&nbsp;</td>
                                        <td class="auto-style47">&nbsp;</td>
                                        <td>
                                            <asp:Label ID="Label74" runat="server" Text="Label"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style33">&nbsp;</td>
                                        <td class="auto-style45"></td>
                                        <td class="auto-style1"></td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style46">Dear&nbsp;
                                            <asp:Label ID="lblName2" runat="server"></asp:Label>
                                            ,</td>
                                        <td class="auto-style47">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style46" colspan="3">
                                            <table style="width: 90%;">
                                                <tr>
                                                    <td>
                                                        <center>
                                                            <b><u>Appointment Letter </u></b>
                                                        </center>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style48" colspan="3">
                                            <p>
                                                Further to your application and subsquent interview at Neetbeet Technogies Limited, we are please to offer you an appointment as
                                                <asp:Label ID="lblPosition" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                                                &nbsp; under the department of
                                                <asp:Label ID="lblOfferDept" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                                                . The following are your appointment detail:
                                                <ul>
                                                    <li>Position:&nbsp;&nbsp;
                                                        <asp:Label ID="lblOfferPosition" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                                                    </li>
                                                    <li>Department:&nbsp;&nbsp;
                                                        <asp:Label ID="lblOfferDept2" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                                                    </li>
                                                    <li>Level:&nbsp;&nbsp;
                                                        <asp:Label ID="lblOfferLevel" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                                                    </li>
                                                    <li>Basic Salary:&nbsp;&nbsp;
                                                        <asp:Label ID="lblOfferSalary" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                                                    </li>
                                                    <li>Work Loction:&nbsp;&nbsp;
                                                        <asp:Label ID="lblOfferWrkLocatn" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                                                    </li>
                                                    <li>Resumption Date:&nbsp;&nbsp;
                                                        <asp:Label ID="lblOfferRsmptDate" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                                                    </li>
                                                </ul>
                                                <p>
                                                    &nbsp;</p>
                                                <p>
                                                    The first six months of your employment with us will be regarded as a propationary period, during which , either you or the company could terminate the appointment by giving one (1) month&#39;s notice in writing or paying one (1) month&#39;s basic salary in lieu of notice.</p>
                                                <p>
                                                </p>
                                                <p>
                                                </p>
                                            </p>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td class="auto-style47">&nbsp;</td>
                                        <td>
                                            <asp:Label ID="lblApplicantEmail1" runat="server" Text="Label"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button21" runat="server"  style="font-weight: 700" Text="Back" />
                        </td>
                        <td>
                            <asp:Button ID="btnPrint" runat="server"  style="font-weight: 700; height: 26px;" Text="Print" OnClick="btnPrint_Click" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </asp:View>
        </asp:MultiView>
    
    </div>
    </form>
</body>
</html>
