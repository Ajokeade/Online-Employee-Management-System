<%@ Control Language="C#" AutoEventWireup="true" CodeFile="InterviewPage.ascx.cs" Inherits="Bilikis.HRManagementSystem.InterviewPage" %>
<style type="text/css">
    .auto-style1 {
        height: 23px;
    }
    .auto-style6 {
        height: 23px;
    }
    .auto-style7 {
        width: 387px;
    }
    .auto-style14 {
        height: 23px;
        width: 174px;
    }
    .auto-style15 {
        width: 174px;
    }
    .auto-style16 {
        width: 554px;
    }
    .auto-style17 {
        width: 359px;
        height: 23px;
    }
    .auto-style18 {
        width: 919px;
        margin-left: 80px;
    }
    .auto-style23 {
        height: 23px;
        width: 181px;
    }
    .auto-style24 {
        width: 359px;
    }
    .auto-style26 {
        width: 203px;
    }
    .auto-style27 {
        height: 23px;
        width: 203px;
    }
    .auto-style28 {
    }
    .auto-style33 {
        height: 23px;
        width: 123px;
    }
    .auto-style37 {
    }
    .auto-style42 {
        height: 23px;
        width: 331px;
    }
    .auto-style43 {
        width: 331px;
    }
    .auto-style44 {
        width: 601px;
    }
    .auto-style45 {
        height: 23px;
        width: 352px;
    }
    .auto-style46 {
    }
    .auto-style47 {
        width: 352px;
    }
    .auto-style48 {
        height: 177px;
    }
    .auto-style50 {
        color: #006699;
    }
    .auto-style51 {
        color: #333333;
    }
    .auto-style52 {
        list-style-type: square;
    }
    .auto-style53 {
        color: #CC3300;
    }
    .auto-style54 {
        color: #CC3300;
        font-size: medium;
    }
    .auto-style55 {
        height: 23px;
        color: #CC3300;
    }
    .auto-style56 {
    }
    .auto-style58 {
        width: 185px;
    }
    .auto-style59 {
    }
    .auto-style61 {
        height: 23px;
        }
    .auto-style62 {
        width: 919px;
        margin-left: 80px;
        height: 23px;
    }
    .auto-style63 {
        width: 445px;
    }
    .auto-style64 {
        height: 23px;
    }
    .auto-style65 {
    }
    .auto-style66 {
        width: 20%;
    }
    .auto-style67 {
        width: 27%;
    }
    .auto-style68 {
        width: 30%;
    }
    .auto-style69 {
    }
    .auto-style70 {
        width: 137px;
        height: 23px;
    }
    .auto-style71 {
        height: 99px;
    }
    .auto-style72 {
    }
    .auto-style73 {
        width: 196px;
        height: 23px;
    }
    .auto-style74 {
        height: 26px;
    }
    .auto-style79 {
        width: 199px;
    }
    .auto-style82 {
        width: 173px;
    }
</style>



<table style="width:100%;">
    <tr>
        <td valign="top"  style="width: 150px"><table><tr><td>
            <asp:Button ID="Button1" runat="server" Height="35px" OnClick="Button1_Click" style="color: #CC3300; font-size: medium; font-weight: 700" Text=" Send Invite" Width="173px" />
            </td></tr>
            <tr><td>
                <asp:Button ID="Button4" runat="server" Height="35px" style="color: #CC3300; font-size: small; font-weight: 700" Text="Interviewer Decision" Width="173px" OnClick="Button4_Click" />
                </td></tr>
            <tr><td>
                <asp:Button ID="Button15" runat="server" Height="35px" style="color: #CC3300; font-size: small; font-weight: 700" Text="Management Decision" Width="173px" OnClick="Button15_Click" />
                </td></tr>
            <tr><td>
                <asp:Button ID="Button19" runat="server" Height="35px" style="color: #CC3300; font-size: small; font-weight: 700" Text="Send Offer" Width="173px" OnClick="Button19_Click" />
                </td></tr>
            <tr><td>
                <asp:Button ID="Button2" runat="server" Height="35px" OnClick="Button2_Click" style="color: #CC3300; font-size: medium; font-weight: 700" Text="Interview " Width="173px" Visible="False" />
                </td></tr><tr><td>
                <asp:Button ID="Button3" runat="server" Height="35px" style="color: #CC3300; font-size: medium; font-weight: 700" Text="Evaluation" Width="173px" OnClick="Button3_Click" Visible="False" />
                </td></tr><tr><td>
                <asp:Button ID="Button11" runat="server" Height="35px" style="color: #CC3300; font-size: medium; font-weight: 700" Text="Report" Width="173px" OnClick="Button11_Click" Visible="False" />
                </td></tr><tr><td></td></tr>
                         </table></td>
        <td valign="top"><asp:MultiView ID="MViewInterview" runat="server">
    <asp:View ID="ViewWelcomePage" runat="server">
        <table style="border: medium solid #CC0066; width:100%;">
            <tr>
                <td colspan="3">
                    <asp:Label ID="LbWelcom0" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="12pt" ForeColor="#CC0066" Text=" Welcome to Interview Session, Please click the action you want to perform" style="font-size: medium"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style18">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style62">
                    </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

             <tr>
                <td></td>
                <td class="auto-style18">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                <td></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:View>

    <asp:View ID="ViewSendInvite" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
            <tr>
                <td colspan="3">
                    <asp:Label ID="LbWelcom1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="12pt" ForeColor="#CC0066" Text="ShortList Applicants"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="3">
                    <ul class="auto-style52">
                        <li>Select position to view all the applicants for that particular position.</li>
                        <li>You&nbsp; can view more details about a particular applicant by&nbsp; clicking on <span class="auto-style53">view</span>.</li>
                        <li>You can shortlist an applicant for interview by&nbsp; checking the check box.</li>
                        <li>You can also send invite for interview</li>
                    </ul>
                </td>
            </tr>
            <tr>
                <td class="auto-style37">&nbsp;</td>
                <td>
                    <asp:Label ID="Label26" runat="server" style="font-weight: 700" Text="Available Positions:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlAvailablePosition" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlAvailablePosition_SelectedIndexChanged">
                        <asp:ListItem>--Please  Select--</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style37">&nbsp;&nbsp; &nbsp;</td>
                <td></td>
                <td></td>
            </tr>
              <tr>
                <td class="auto-style37">
                    <asp:Label ID="lblInterMsg0" runat="server" Text="Label" Visible="False"></asp:Label>
                  </td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:GridView ID="GViewAllApplicantsList" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False" OnRowCommand="GViewAllApplicantsList_RowCommand" >
                       
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="ApplicantNum" HeaderText="Applicant No" />
                            <asp:BoundField DataField="PositionAppliedFor" HeaderText="Position AppliedFor" />
                            <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
                            <asp:BoundField DataField="MiddleName" HeaderText="Middle Name" />
                            <asp:BoundField DataField="LastName" HeaderText="LastName" />
                            <asp:BoundField DataField="Gender" HeaderText="Gender" />
                            <asp:BoundField DataField="Age" HeaderText="Age" />
                            <asp:BoundField DataField="MaritalStatus" HeaderText="Marital Status" />
                            <asp:BoundField DataField="Email" HeaderText="Email" />
                            <asp:BoundField DataField="PhoneNo" HeaderText="PhoneNo" />
                            <asp:TemplateField ShowHeader="False">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" CommandName="View" Text="View" CommandArgument='<%# DataBinder.Eval(Container,"DataItem.ApplicantID") %>' ></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Short List">
                                <EditItemTemplate>
                                    <asp:CheckBox ID="CheckBox2" runat="server" />
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="CheckBox1" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField >
                                <ItemTemplate>
                                    <asp:TextBox ID="TextBox2" Text='<%# DataBinder.Eval(Container,"DataItem.ApplicantID") %>' runat="server" Visible="false"></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                       
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style37">
                    <asp:Label ID="lblShortlist" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="lblInviteSend" runat="server" style="font-style: italic; color: #009900"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style37" style="width: 120px">
                    &nbsp;</td>
                <td colspan="2">
                    <asp:Panel ID="PanelInterviewParameter" runat="server" Visible="False">
                        <table style="width: 60%; margin-left:100px;">
                            <tr>
                                <td class="auto-style55" colspan="3"><strong>Set interview parameters</strong></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label53" runat="server" style="font-weight: 700" Text="Interview Date:"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlInterviewDay" runat="server">
                                    </asp:DropDownList>
                                    &nbsp;
                                    <asp:DropDownList ID="ddlInterviewMonth" runat="server">
                                        <asp:ListItem Value="00">Month</asp:ListItem>
                                        <asp:ListItem Value="01">Jan</asp:ListItem>
                                        <asp:ListItem Value="02">Feb</asp:ListItem>
                                        <asp:ListItem Value="03">March</asp:ListItem>
                                        <asp:ListItem Value="04">april</asp:ListItem>
                                        <asp:ListItem Value="05">May</asp:ListItem>
                                        <asp:ListItem Value="06">June</asp:ListItem>
                                        <asp:ListItem Value="07">July</asp:ListItem>
                                        <asp:ListItem Value="08">August</asp:ListItem>
                                        <asp:ListItem Value="09">Sept</asp:ListItem>
                                        <asp:ListItem Value="10">Oct</asp:ListItem>
                                        <asp:ListItem Value="11">Nov</asp:ListItem>
                                        <asp:ListItem Value="12">Dec</asp:ListItem>
                                    </asp:DropDownList>
                                    &nbsp;<asp:DropDownList ID="ddlInterviewYear" runat="server">
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label54" runat="server" style="font-weight: 700" Text="Time"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtInterviewTime" runat="server" Width="341px"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label55" runat="server" style="font-weight: 700" Text="Venue:"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtInterviewVenue" runat="server" Width="363px"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:Button ID="Button8" runat="server" OnClick="Button6_Click" style="color: #CC3300; font-weight: 700; margin-bottom: 0px;" Text="Shorlist and send Invite" />
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style37">
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style37" colspan="3">
                    <asp:Panel ID="PanelApplicantDetails" runat="server" Visible="False">
                        <table style="border: 1px solid #990033; width: 80%;  margin-left:75px; ">
                            <tr>
                                <td class="auto-style85" colspan="5"><strong class="auto-style54"><em>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Applicant Information</em></strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style48" colspan="5">
                                    <asp:Image ID="ImagePassport" runat="server" BorderColor="#CC3300" BorderWidth="3px" Height="167px" ImageAlign="Middle" Width="171px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Position applied for:</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblPositionAppliedFor" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>Applicant No:</strong></td>
                                <td>
                                    <asp:Label ID="lblApplicantNum" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>First Name</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblFirstName" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>Nationality</strong></td>
                                <td>
                                    <asp:Label ID="lblNationality" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Middle Name</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblMiddleName" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style50"><strong style="color: #333333">State of Origin</strong></td>
                                <td>
                                    <asp:Label ID="lblStateofOrigin" runat="server" Enabled="False" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Last Name</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblLastName" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>LGA</strong></td>
                                <td>
                                    <asp:Label ID="lblLGA" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Gender</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblGender" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>Home Town</strong></td>
                                <td>
                                    <asp:Label ID="lblHomeTown" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Marital Status</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblMaritalStatus" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>Email</strong></td>
                                <td>
                                    <asp:Label ID="lblEmail" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>DOB</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblDOB" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style50"><strong style="color: #333333">PhoneNo</strong></td>
                                <td>
                                    <asp:Label ID="lblPhoneNo" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Age</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblAge" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>ContactAddress</strong></td>
                                <td>
                                    <asp:Label ID="lblContactAddress" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style50" colspan="5"><em><strong>Qualification</strong></em></td>
                            </tr>
                            <tr>
                                <td class="auto-style58" colspan="5">
                                    <asp:GridView ID="GViewQualification" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Vertical">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="InstitutionName" HeaderText="Institution" />
                                            <asp:BoundField DataField="Course" HeaderText="Course" />
                                            <asp:BoundField DataField="QualificationType" HeaderText="Qualification" />
                                            <asp:BoundField DataField="Grade" HeaderText="Grade" />
                                            <asp:BoundField DataField="StartYear" HeaderText="StartYear" />
                                            <asp:BoundField DataField="EndYear" HeaderText="EndYear" />
                                        </Columns>
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#F7F7DE" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style58"></td>
                                <td class="auto-style53"></td>
                                <td class="auto-style52"></td>
                                <td class="auto-style54"></td>
                                <td class="auto-style52"></td>
                            </tr>
                            <tr>
                                <td class="auto-style50" colspan="5"><strong><em>Professional Qualification</em></strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style58" colspan="5">
                                    <asp:GridView ID="GViewProfQualification" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Vertical">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="CertificationName" HeaderText="Certification" />
                                            <asp:BoundField DataField="Stage" HeaderText="Stage" />
                                            <asp:BoundField DataField="CertYear" HeaderText="Year Obtained" />
                                        </Columns>
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#F7F7DE" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style58">&nbsp;</td>
                                <td class="auto-style53">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style50" colspan="5"><strong><em>Work Experience</em></strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style58" colspan="5">
                                    <asp:GridView ID="GViewWrkExp" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Vertical">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="CompanyName" HeaderText="Company Name" />
                                            <asp:BoundField DataField="PositionHeld" HeaderText="Position Held" />
                                            <asp:BoundField DataField="JobDescriprtion" HeaderText="Job Descriprtion" />
                                            <asp:BoundField DataField="SalaryReceived" HeaderText="Salary Received" />
                                            <asp:BoundField DataField="StartYear" HeaderText="Start Year" />
                                            <asp:BoundField DataField="EndYear" HeaderText="End Year" />
                                        </Columns>
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#F7F7DE" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style58">&nbsp;</td>
                                <td class="auto-style53">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style50"><strong><em>Uploaded Documents</em></strong></td>
                                <td class="auto-style53">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style58" colspan="5">
                                    <asp:GridView ID="GViewDocument" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Vertical">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="DocumentType" HeaderText="Document Type" />
                                            <asp:BoundField DataField="DocumentPath" HeaderText="Document" />
                                        </Columns>
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#F7F7DE" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style58">&nbsp;</td>
                                <td class="auto-style53">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style37">&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" style="font-weight: 700; color: #CC3300" Text="Close" Visible="False" Width="77px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style37">
                    &nbsp;</td>
                        <td>&nbsp;</td>
                <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style37" colspan="3">
                                <asp:Panel ID="Panel1" runat="server" Visible="False">
                                    <table style="width:75%; margin-left:50px">
                                        <tr>
                                            <td class="auto-style46">&nbsp;</td>
                                            <td class="auto-style47">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style46">&nbsp;</td>
                                            <td class="auto-style47">&nbsp;</td>
                                            <td valign="right">
                                                <asp:Label ID="Label42" runat="server" Text="Neetbeet Technologies Limited"></asp:Label>
                                                <br />
                                                <asp:Label ID="Label43" runat="server" Text="13, Adekunbi Cresent , Off Toyin Street, Ikeja, Lagos."></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style46">&nbsp;</td>
                                            <td class="auto-style47">&nbsp;</td>
                                            <td>
                                                <asp:Label ID="Label44" runat="server" Text="Label"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style33">&nbsp;</td>
                                            <td class="auto-style45"></td>
                                            <td class="auto-style1"></td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style46">Dear
                                                <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
                                            </td>
                                            <td class="auto-style47">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style46" colspan="3">
                                                <table style="width: 90%;">
                                                    <tr>
                                                        <td>
                                                            <center>
                                                                <b><u>Invitation to Interview&nbsp; </u></b>
                                                            </center>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="3">
                                                <p>
                                                    In response&nbsp; to your application&nbsp;&nbsp; for the post of
                                                    <asp:Label ID="lblPositionApplied" runat="server" style="color: #CC3300; font-weight: 700" Text="Label"></asp:Label>
                                                    &nbsp; at Neetbeet Technogies Limited, we are please to invite you for interview as schedule below:
                                                    <br />
                                                    <ul>
                                                        <li>Date:&nbsp;&nbsp;
                                                            <asp:Label ID="Label47" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                                                        </li>
                                                        <li>Time:&nbsp;&nbsp;
                                                            <asp:Label ID="Label48" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                                                        </li>
                                                        <li>Venue:&nbsp;
                                                            <asp:Label ID="Label49" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                                                        </li>
                                                    </ul>
                                                    <p>
                                                        <asp:Label ID="lblApplicantEmail" runat="server" Text="Label"></asp:Label>
                                                    </p>
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
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                    </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style46">&nbsp;</td>
                                        <td class="auto-style44">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style46">&nbsp;</td>
                                        <td class="auto-style44">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style46">&nbsp;</td>
                                        <td class="auto-style44">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style46">&nbsp;</td>
                                        <td class="auto-style44">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    </table>
                                </asp:Panel>
                            </td>
                        </tr>
                    <tr>
                        <td class="auto-style37">&nbsp;</td>
                        <td>
                            <asp:Button ID="sendInterviewInvite1" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="sendInterviewInvite1_Click" style="font-size: small; color: #CC3300" Text="Send Invite" Width="118px" Visible="False" />
                        </td>
                        <td>&nbsp;</td>
            </tr>
                    </table>
    </asp:View>
    <asp:View ID="ViewInterviewerPage" runat="server">
         <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style14">
                &nbsp;</td>
            <td class="auto-style42">
                &nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
             <tr>
                 <td class="auto-style6"></td>
                 <td class="auto-style14">
                     <asp:Label ID="LbPosition" runat="server" Font-Bold="True" Text="Position"></asp:Label>
                 </td>
                 <td class="auto-style42">
                     <asp:DropDownList ID="applicantPositionList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="applicantPositionList_SelectedIndexChanged">
                         <asp:ListItem>---Please Select---</asp:ListItem>
                     </asp:DropDownList>
                 </td>
                 <td class="auto-style1"></td>
             </tr>
        <tr>
            <td class="auto-style7">
                &nbsp;</td>
            <td class="auto-style15">
                &nbsp;</td>
            <td class="auto-style43">
                &nbsp;</td>
            <td class="auto-style1">
                &nbsp;</td>
        </tr>
             <tr>
                 <td class="auto-style7">&nbsp;</td>
                 <td class="auto-style15">
                     <asp:Label ID="LbAppliName" runat="server" Font-Bold="True" Text="Applicant"></asp:Label>
                 </td>
                 <td class="auto-style43">
                     <asp:DropDownList ID="applicantList" runat="server" OnSelectedIndexChanged="applicantList_SelectedIndexChanged" AutoPostBack="True">
                         <asp:ListItem>---Please Select---</asp:ListItem>
                     </asp:DropDownList>
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Label ID="lblApplicantName" runat="server"></asp:Label>
                 </td>
                 <td class="auto-style1">&nbsp;</td>
             </tr>
              <tr>
            <td class="auto-style6">
                &nbsp;</td>
            <td class="auto-style14"></td>
            <td class="auto-style42">
                &nbsp;</td>
            <td class="auto-style1">
                &nbsp; &nbsp;
                  </td>


        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style15">
                <asp:Label ID="LbInterviewerName" runat="server" Font-Bold="True" Text="Interviewed By"></asp:Label>
            </td>
            <td class="auto-style43">
                <asp:Label ID="Label28" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style1"></td>
        </tr>
             
             <tr>
                 <td class="auto-style7">&nbsp;</td>
                 <td class="auto-style15">
                     &nbsp;</td>
                 <td class="auto-style43">
                     &nbsp;</td>
                 <td class="auto-style1">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style7">&nbsp;</td>
                 <td class="auto-style15">
                     <asp:Label ID="LbIntervDate" runat="server" Font-Bold="True" Text="Interview Date"></asp:Label>
                 </td>
                 <td class="auto-style43">
                     <asp:DropDownList ID="interviewDayList" runat="server">
                     </asp:DropDownList>
                     <asp:DropDownList ID="interviewMonthList" runat="server">
                          <asp:ListItem Value="00">Month</asp:ListItem>
                        <asp:ListItem Value="01">Jan</asp:ListItem>
                        <asp:ListItem Value="02">Feb</asp:ListItem>
                        <asp:ListItem Value="03">March</asp:ListItem>
                        <asp:ListItem Value="04">april</asp:ListItem>
                        <asp:ListItem Value="05">May</asp:ListItem>
                        <asp:ListItem Value="06">June</asp:ListItem>
                        <asp:ListItem Value="07">July</asp:ListItem>
                        <asp:ListItem Value="08">August</asp:ListItem>
                        <asp:ListItem Value="09">Sept</asp:ListItem>
                        <asp:ListItem Value="10">Oct</asp:ListItem>
                        <asp:ListItem Value="11">Nov</asp:ListItem>
                        <asp:ListItem Value="12">Dec</asp:ListItem>
                     </asp:DropDownList>
                     <asp:DropDownList ID="interviewYearList" runat="server">
                     </asp:DropDownList>
                 </td>
                 <td class="auto-style1">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style7">&nbsp;</td>
                 <td class="auto-style15">
                     <asp:Label ID="LbIntervDate0" runat="server" Font-Bold="True" Text="Interview Date"></asp:Label>
                 </td>
                 <td class="auto-style43">
                     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                     <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/calendar.png" />
                 </td>
                 <td class="auto-style1">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style7">
                     <asp:Label ID="LbEvaluation" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Interview Session"></asp:Label>
                 </td>
                 <td class="auto-style15">&nbsp;</td>
                 <td class="auto-style43">&nbsp;</td>
                 <td class="auto-style1">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style7">&nbsp;</td>
                 <td class="auto-style15">&nbsp;</td>
                 <td class="auto-style43">&nbsp;</td>
                 <td class="auto-style1">&nbsp;</td>
             </tr>
        <tr>
            <td class="auto-style6" colspan="4">
                <strong>PURPOSE</strong> - This evaluation is to standardize the recording of information collected during an interview and assist in evaluating and comparing differrent applicants when interviews are completed.
              <br> Interviewers are encouraged to use the &quot;<em><strong>Comment</strong></em>&quot; section to support each applicant rating. This form is to be completed during interview. 
                 <%--<asp:Label ID="LbPurpose" runat="server" Font-Bold="True" Text="PURPOSE - This evaluation is to standardize the recording of information collected during an interview and assist in evaluating and comparing differrent applicants when interviews are completed.
                   "></asp:Label>--%>
            </td>
        </tr>
               <tr>
                   <td class="auto-style6">&nbsp;</td>
                   <td class="auto-style14">&nbsp;</td>
                   <td class="auto-style42">&nbsp;</td>
                   <td class="auto-style1">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style6" colspan="4"><strong>RATING KEY</strong> - <strong>NS</strong>: NOT SATISFACTORY; <strong>S</strong>: SATISFACTORY; <strong>VS:</strong> VERY SATISFACTORY; <strong>NA</strong>: NOT APPLICABLE</td>
             </tr>
               <tr>
            <td class="auto-style7">
                <asp:Label ID="Lbcriteria" runat="server" Font-Bold="True" Text="CRITERIA"></asp:Label>
                   </td>
            <td class="auto-style15">
                <asp:Label ID="LbRating" runat="server" Font-Bold="True" Text="RATING KEY"></asp:Label>
                   </td>
            <td class="auto-style43">
                <asp:Label ID="LbComment" runat="server" Font-Bold="True" Text="COMMENTS"></asp:Label>
                   </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="LbExper" runat="server" Font-Bold="True" Text="Experience"></asp:Label>
                &nbsp;
                <asp:Label ID="LbAdditinalInfo1" runat="server" Font-Bold="False" Font-Size="Smaller" ForeColor="Red" Text="(as related to the position)"></asp:Label>
            </td>
            <td class="auto-style14">
                <asp:DropDownList ID="ExperienceKeyList" runat="server">
                    <asp:ListItem>---Please Select---</asp:ListItem>
                    <asp:ListItem>Very Satisfactory</asp:ListItem>
                    <asp:ListItem>Satisfactory</asp:ListItem>
                    <asp:ListItem>Good</asp:ListItem>
                    <asp:ListItem>Not Satisactory</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style42">
                <asp:TextBox ID="txtExperience" runat="server" Width="220px"></asp:TextBox>
            </td>
            <td class="auto-style1"></td>
        </tr>
               <tr>
            <td class="auto-style6"></td>
            <td class="auto-style14"></td>
            <td class="auto-style42"></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="LbTraining" runat="server" Font-Bold="True" Text="Education/Training"></asp:Label>
                &nbsp;
                <asp:Label ID="LbAdditinalInfo2" runat="server" Font-Bold="False" Font-Size="Smaller" ForeColor="Red" Text="(relevant to the position)"></asp:Label>
            </td>
            <td class="auto-style15">
                <asp:DropDownList ID="edcationKeyList" runat="server">
                    <asp:ListItem>---Please Select---</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style43">
                <asp:TextBox ID="txtEducation" runat="server" Width="220px"></asp:TextBox>
            </td>
            <td class="auto-style1"></td>
        </tr>
              <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="LbCommSkill" runat="server" Font-Bold="True" Text="Communication Skills"></asp:Label>
                &nbsp;
                <asp:Label ID="LbAdditinalInfo3" runat="server" Font-Bold="False" Font-Size="Smaller" ForeColor="Red" Text="(written and verbal)"></asp:Label>
            </td>
            <td class="auto-style15">
                <asp:DropDownList ID="communicationKeyList" runat="server">
                    <asp:ListItem>---Please Select---</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style43">
                <asp:TextBox ID="txtCommunication" runat="server" Width="220px"></asp:TextBox>
            </td>
            <td class="auto-style1"></td>
        </tr>
                <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="LbInterest" runat="server" Font-Bold="True" Text="Interest and Knowledge"></asp:Label>
                &nbsp;<asp:Label ID="LbAdditinalInfo4" runat="server" Font-Bold="False" Font-Size="Smaller" ForeColor="Red" Text="(of the position)"></asp:Label>
            </td>
            <td class="auto-style15">
                <asp:DropDownList ID="interestKeyList" runat="server">
                    <asp:ListItem>---Please Select---</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style43">
                <asp:TextBox ID="txtInterest" runat="server" Width="220px"></asp:TextBox>
            </td>
            <td class="auto-style1"></td>
        </tr>

                <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="LbPresentation" runat="server" Font-Bold="True" Text="Presentation"></asp:Label>
                &nbsp;<asp:Label ID="LbAdditinalInfo5" runat="server" Font-Bold="False" Font-Size="Smaller" ForeColor="Red" Text="(promptness, neetness of resume)"></asp:Label>
            </td>
            <td class="auto-style15">
                <asp:DropDownList ID="presentationKeyList" runat="server">
                    <asp:ListItem>---Please Select---</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style43">
                <asp:TextBox ID="txtPresentation" runat="server" Width="220px"></asp:TextBox>
            </td>
            <td class="auto-style1"></td>
        </tr>

                <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="LbPromSol" runat="server" Font-Bold="True" Text="Problem Solving Skills"></asp:Label>
                &nbsp;</td>
            <td class="auto-style15">
                <asp:DropDownList ID="problemKeyList" runat="server">
                    <asp:ListItem>---Please Select---</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style43">
                <asp:TextBox ID="txtProblem" runat="server" Width="220px"></asp:TextBox>
            </td>
            <td class="auto-style1"></td>
        </tr>

                <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="LbComputer" runat="server" Font-Bold="True" Text="Computer Skills"></asp:Label>
                &nbsp;<asp:Label ID="LbAdditinalInfo6" runat="server" Font-Bold="False" Font-Size="Smaller" ForeColor="Red" Text="(relevant to perform the duties of the position)"></asp:Label>
            </td>
            <td class="auto-style15">
                <asp:DropDownList ID="computerKeyList" runat="server">
                    <asp:ListItem Value="---Please Select---"></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style43">
                <asp:TextBox ID="txtComputerSkills" runat="server" Width="220px"></asp:TextBox>
            </td>
            <td class="auto-style1"></td>
        </tr>

                <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="LbJobStability" runat="server" Font-Bold="True" Text="Job Stability"></asp:Label>
            </td>
            <td class="auto-style15">
                <asp:DropDownList ID="jobStabilityKeyList" runat="server">
                    <asp:ListItem>---Please Select---</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style43">
                <asp:TextBox ID="txtJobStability" runat="server" Width="220px"></asp:TextBox>
            </td>
            <td class="auto-style1"></td>
        </tr>

                <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="LbOther" runat="server" Font-Bold="True" Text="Other Job Related Criteria "></asp:Label>
                <asp:Label ID="LbAdditinalInfo7" runat="server" Font-Bold="False" Font-Size="Smaller" ForeColor="Red" Text="(please specify)"></asp:Label>
            </td>
            <td class="auto-style15">
                <asp:DropDownList ID="otherKeyList" runat="server">
                    <asp:ListItem>---Please Select---</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style43">
                <asp:TextBox ID="txOther" runat="server" Width="220px"></asp:TextBox>
            </td>
            <td class="auto-style1"></td>
        </tr>

                <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Button ID="evaluationBackBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="evaluationBackBtn_Click" style="color: #CC3300" Text="Back" />
            </td>
            <td class="auto-style15">
                &nbsp;
                <asp:Button ID="evaluationWelcomPageBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="evaluationWelcomPageBtn_Click" style="color: #CC3300" Text="WelcomePage" />
            </td>
            <td class="auto-style43">
                &nbsp;</td>
            <td class="auto-style1">
                <asp:Button ID="interviewNextBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="interviewNextBtn_Click" style="color: #CC3300" Text="Next" />
            </td>
        </tr>
    </table>

    </asp:View>
   
    <asp:View ID="ViewInterviewerResponse" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
            <tr>
                <td colspan="4">
                    <asp:Label ID="LbInterviwerResponse" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Please Select your responses to the following questions:" style="font-style: italic; font-size: medium; color: #CC3300"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style16">
                    <asp:Label ID="Label29" runat="server" style="font-weight: 700" Text="Points"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label30" runat="server" style="font-weight: 700" Text="Rating key"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style16">The applicant has knowledge, skills, and abilities to perform the duties of the position</td>
                <td>
                    <asp:DropDownList ID="knowledgeRatingKeyList" runat="server">
                        <asp:ListItem>---Please Select---</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="auto-style16">The applicant views this position with excitment and enthusiasm</td>
                <td>
                    <asp:DropDownList ID="excitmentRatingKeyList" runat="server">
                        <asp:ListItem>---Please Select---</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="auto-style16">The applicant has the appropraite level of experience necessary for this position</td>
                <td>
                    <asp:DropDownList ID="experienceRatingKeyList" runat="server">
                        <asp:ListItem>---Please Select---</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="auto-style16">The applicant has team working spirit</td>
                <td>
                    <asp:DropDownList ID="teamRatingKeyList" runat="server">
                        <asp:ListItem>---Please Select---</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="auto-style16">The applicant display ability to communicate well with all constituents</td>
                <td>
                    <asp:DropDownList ID="communicationRatingKeyList" runat="server">
                        <asp:ListItem>---Please Select---</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style16">The applicant should be included in the final list of recommended applicants</td>
                <td>
                    <asp:DropDownList ID="RecommendtionRatingKeyList" runat="server">
                        <asp:ListItem>---Please Select---</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            
        </table>
        <table style="width:100%;">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            
        </table>
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
            <tr>
                <td class="auto-style28" colspan="4">
                    <asp:Label ID="LbInterviwerResponse0" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Interviewer Response Continues" style="color: #CC3300; font-size: medium; font-style: italic"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style24">
                    <asp:Label ID="LbcandStrnght" runat="server" Font-Bold="True" Text="Candidate Strength"></asp:Label>
                    :</td>
                <td class="auto-style26">
                    <asp:TextBox ID="txtCandStrength" runat="server" Height="110px" Width="279px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style24">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style24">
                    <asp:Label ID="LbCandWeakness" runat="server" Font-Bold="True" Text="Candidate Weakness"></asp:Label>
                    :</td>
                <td class="auto-style26">
                    <asp:TextBox ID="txtCandWeakness" runat="server" Height="127px" Width="281px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style24">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style24">
                    <asp:Label ID="LbAddComment" runat="server" Font-Bold="True" Text="Please add any additional comment (if any)"></asp:Label>
                </td>
                <td class="auto-style26">
                    <asp:TextBox ID="txtAddtionalComment" runat="server" Height="107px" Width="279px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style24">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style24">
                    <asp:Label ID="LbFianlRecom" runat="server" Font-Bold="True" Text="Your Final Recommendation"></asp:Label>
                </td>
                <td class="auto-style26">
                    <asp:RadioButtonList ID="InterviewerRadioList" runat="server">
                        <asp:ListItem>Hire</asp:ListItem>
                        <asp:ListItem>Futer Interview</asp:ListItem>
                        <asp:ListItem>Reject</asp:ListItem>
                        <asp:ListItem>Keep in View</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style23"></td>
                <td class="auto-style17"></td>
                <td class="auto-style27"></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style24">&nbsp;</td>
                <td class="auto-style26">
                    &nbsp;&nbsp;
                    <asp:Button ID="responseWelcomPage" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="responseWelcomPage_Click" Text="Finish" style="color: #CC3300; font-size: medium;" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style24">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style24">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:View>
    <asp:View ID="SummaryView" runat="server">
        <table style="border-color: #CC3300; border-style: solid; width:100%;">
            <tr>
                <td colspan="4" class="auto-style1">
                    <asp:Label ID="LbInterviwerResponse1" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Evaluation Session"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="4">
                    
                </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style55">
                    <asp:Label ID="LbHODName" runat="server" Font-Bold="True" Text="HOD Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtHODName" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style55">
                    <asp:Label ID="LbInterviewerName5" runat="server" Font-Bold="True" Text="HOD Recommendation"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="HODRadioList" runat="server">
                        <asp:ListItem>Hire</asp:ListItem>
                        <asp:ListItem>Futer Interview</asp:ListItem>
                        <asp:ListItem>Reject</asp:ListItem>
                        <asp:ListItem>Keep in View</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style55">
                    <asp:Label ID="LbMangement" runat="server" Font-Bold="True" Text="Management"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMangement" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style55">
                    <asp:Label ID="LbMangmntDecision" runat="server" Font-Bold="True" Text="Management Decision"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="managementRadioList" runat="server">
                        <asp:ListItem>Hire</asp:ListItem>
                        <asp:ListItem>Futer Interview</asp:ListItem>
                        <asp:ListItem>Reject</asp:ListItem>
                        <asp:ListItem>Keep in View</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style55">&nbsp;</td>
                <td>
                    <asp:Button ID="interviewRejectBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" style="font-size: medium; color: #CC3300" Text="Reject" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="interviewApproveBtn0" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" style="color: #CC3300; font-size: medium" Text="Approve" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style55">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:View>

    <asp:View ID="View3" runat="server">
        <table style="border: medium solid #CC3300; width:100%;">
            <tr>
                <td colspan="3" class="auto-style1">
                    <asp:Label ID="LbWelcom2" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="12pt" ForeColor="#CC0066" Text="Interviewer Decision"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3" class="auto-style71">
                    <ul class="auto-style52">
                        <li>Select position to view all&nbsp; applicants shortlisted for that particular position.</li>
                        <li>You&nbsp; can view more details about a particular applicant by&nbsp; clicking on view.</li>
                        <li>To hire applicants:</li>
                        <li>&nbsp;Select&nbsp; the check box for the applicant(s)</li>
                        <li>Set the employment parameters</li>
                        <li>click on hire button</li>
                    </ul>
                </td>
            </tr>
            <tr>
                <td class="auto-style79">&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style79">&nbsp;</td>
                <td>
                    <asp:Label ID="Label56" runat="server" style="font-weight: 700" Text="Positions Applied For:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlPositions" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPositions_SelectedIndexChanged" Width="215px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style79">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style61" colspan="2">
                    <asp:Label ID="Label57" runat="server" style="font-weight: 700; color: #CC3300" Text="List of shortlisted Applicants" Visible="False"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:Label ID="lblhire" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style59" colspan="3">
                    <asp:GridView ID="GVShortlistedApplicants" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" OnRowCommand="GVShortlistedApplicants_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="ApplicantNum" HeaderText="Applicant No" />
                            <asp:BoundField DataField="PositionAppliedFor" HeaderText="Position Applied For" />
                            <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
                            <asp:BoundField DataField="LastName" HeaderText="LastName" />
                            <asp:BoundField DataField="Gender" HeaderText="Gender" />
                            <asp:BoundField DataField="Age" HeaderText="Age" />
                            <asp:BoundField DataField="MaritalStatus" HeaderText="MaritalStatus" />
                            <asp:BoundField DataField="Email" HeaderText="Email" />
                            <asp:BoundField DataField="PhoneNo" HeaderText="PhoneNo" />
                            <asp:BoundField DataField="ApplicationStatus" HeaderText="Application Status" />
                            <asp:TemplateField ShowHeader="False">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton" runat="server" CausesValidation="false" CommandName="View" Text="View" CommandArgument='<%# DataBinder.Eval(Container,"DataItem.ApplicantID") %>' ></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Hire">
                                <EditItemTemplate>
                                    <asp:CheckBox ID="CheckBox1" runat="server" />
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="CheckBox2" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:TextBox ID="TextBoxApplicantID" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.ApplicantID") %>' runat="server"></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style79">&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style79">&nbsp;</td>
                <td colspan="2">
                    <asp:Panel ID="PanelEmploymentParameter" runat="server" Visible="False">
                        <table style="border: medium solid #CC3300; width: 65%; margin-left:30px;">
                            <tr>
                                <td class="auto-style55" colspan="3"><strong>Set&nbsp;&nbsp; Employment Parameter</strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style82"><strong>Department</strong>:</td>
                                <td>&nbsp;<asp:DropDownList ID="ddlDept" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlDept_SelectedIndexChanged" Width="215px">
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style82">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style82"><strong>Approved</strong> <strong>Position:</strong></td>
                                <td>
                                    <asp:DropDownList ID="ddlApprovePosition" runat="server" Width="215px">
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style82">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style82"><strong>Level:</strong></td>
                                <td>
                                    <asp:DropDownList ID="ddlLevel" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlLevel_SelectedIndexChanged" Width="215px">
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style82">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style82"><strong>Salary:</strong></td>
                                <td>
                                    <asp:Label ID="lblSalary" runat="server" style="color: #CC3300; font-weight: 700"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style82">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style82"><strong>Work</strong> <strong>Location:</strong></td>
                                <td>
                                    <asp:DropDownList ID="ddlWorkLocation" runat="server" Width="215px">
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style82">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style82"><strong>Resumption Date:</strong></td>
                                <td>
                                    <asp:DropDownList ID="ddlDay" runat="server">
                                    </asp:DropDownList>
                                    <asp:DropDownList ID="ddlMonth" runat="server">
                                        <asp:ListItem Value="00">Month</asp:ListItem>
                                        <asp:ListItem Value="01">Jan</asp:ListItem>
                                        <asp:ListItem Value="02">Feb</asp:ListItem>
                                        <asp:ListItem Value="03">March</asp:ListItem>
                                        <asp:ListItem Value="04">april</asp:ListItem>
                                        <asp:ListItem Value="05">May</asp:ListItem>
                                        <asp:ListItem Value="06">June</asp:ListItem>
                                        <asp:ListItem Value="07">July</asp:ListItem>
                                        <asp:ListItem Value="08">August</asp:ListItem>
                                        <asp:ListItem Value="09">Sept</asp:ListItem>
                                        <asp:ListItem Value="10">Oct</asp:ListItem>
                                        <asp:ListItem Value="11">Nov</asp:ListItem>
                                        <asp:ListItem Value="12">Dec</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:DropDownList ID="ddlYear" runat="server">
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style82">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style82">&nbsp;</td>
                                <td>
                                    <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" style="font-weight: 700" Text="Hire Applicants" />
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style79">&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="lblNoShortlistedApplicant" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style79">&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style79">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56" colspan="3"><asp:Panel ID="Panel2" runat="server" Visible="False">
                        <table style="border: 1px solid #990033; width: 80%;  margin-left:75px; ">
                            <tr>
                                <td class="auto-style85" colspan="5"><strong class="auto-style54"><em>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Applicant Information</em></strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style48" colspan="5">
                                    <asp:Image ID="Image1" runat="server" BorderColor="#CC3300" BorderWidth="3px" Height="167px" ImageAlign="Middle" Width="171px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Position applied for:</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="LabelPosition" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>Applicant No:</strong></td>
                                <td>
                                    <asp:Label ID="LabelApplicantNo" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>First Name</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="LabelFName" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>Nationality</strong></td>
                                <td>
                                    <asp:Label ID="LabelNationality" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Middle Name</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="LabelMidName" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style50"><strong style="color: #333333">State of Origin</strong></td>
                                <td>
                                    <asp:Label ID="LabelState" runat="server" Enabled="False" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Last Name</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="LabelLName" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>LGA</strong></td>
                                <td>
                                    <asp:Label ID="LabelLga" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Gender</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="LabelGender" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>Home Town</strong></td>
                                <td>
                                    <asp:Label ID="LabelHomeTown" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Marital Status</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="LabelMaritalStatus" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>Email</strong></td>
                                <td>
                                    <asp:Label ID="LabelEmail" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>DOB</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="LabelDob" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style50"><strong style="color: #333333">PhoneNo</strong></td>
                                <td>
                                    <asp:Label ID="LabelPhoneNo" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Age</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="LabelAge" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>ContactAddress</strong></td>
                                <td>
                                    <asp:Label ID="LabelAddress" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style50" colspan="5"><em><strong>Qualification</strong></em></td>
                            </tr>
                            <tr>
                                <td class="auto-style58" colspan="5">
                                    <asp:GridView ID="GridViewQualification" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Vertical">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="InstitutionName" HeaderText="Institution" />
                                            <asp:BoundField DataField="Course" HeaderText="Course" />
                                            <asp:BoundField DataField="QualificationType" HeaderText="Qualification" />
                                            <asp:BoundField DataField="Grade" HeaderText="Grade" />
                                            <asp:BoundField DataField="StartYear" HeaderText="StartYear" />
                                            <asp:BoundField DataField="EndYear" HeaderText="EndYear" />
                                        </Columns>
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#F7F7DE" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style58"></td>
                                <td class="auto-style53"></td>
                                <td class="auto-style52"></td>
                                <td class="auto-style54"></td>
                                <td class="auto-style52"></td>
                            </tr>
                            <tr>
                                <td class="auto-style50" colspan="5"><strong><em>Professional Qualification</em></strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style58" colspan="5">
                                    <asp:GridView ID="GridViewProfQualification" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Vertical">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="CertificationName" HeaderText="Certification" />
                                            <asp:BoundField DataField="Stage" HeaderText="Stage" />
                                            <asp:BoundField DataField="CertYear" HeaderText="Year Obtained" />
                                        </Columns>
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#F7F7DE" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style58">&nbsp;</td>
                                <td class="auto-style53">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style50" colspan="5"><strong><em>Work Experience</em></strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style58" colspan="5">
                                    <asp:GridView ID="GridViewWorkExperience" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Vertical">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="CompanyName" HeaderText="Company Name" />
                                            <asp:BoundField DataField="PositionHeld" HeaderText="Position Held" />
                                            <asp:BoundField DataField="JobDescriprtion" HeaderText="Job Descriprtion" />
                                            <asp:BoundField DataField="SalaryReceived" HeaderText="Salary Received" />
                                            <asp:BoundField DataField="StartYear" HeaderText="Start Year" />
                                            <asp:BoundField DataField="EndYear" HeaderText="End Year" />
                                        </Columns>
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#F7F7DE" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style58">&nbsp;</td>
                                <td class="auto-style53">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style50"><strong><em>Uploaded Documents</em></strong></td>
                                <td class="auto-style53">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style58" colspan="5">
                                    <asp:GridView ID="GridViewDocument" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Vertical">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="DocumentType" HeaderText="Document Type" />
                                            <asp:BoundField DataField="DocumentPath" HeaderText="Document" />
                                        </Columns>
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#F7F7DE" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style58">&nbsp;</td>
                                <td class="auto-style53">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel></td>
            </tr>
            <tr>
                <td class="auto-style79">&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" style="font-weight: 700" Text="close" />
                </td>
            </tr>
        </table>
    </asp:View><asp:View ID="View1" runat="server">
        <table style="width: 100% ; border: medium solid #CC3300">
            <tr>
                <td colspan="6">
                    <asp:Label ID="Label59" runat="server" style="font-weight: 700; color: #CC3300" Text="Reports"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="6">
                    <ul class="auto-style52">
                        <li>
                            <p>
                                Select the position to view report of applicants for that position.</p>
                        </li>
                        <li>
                            <p>
                                Click on the report you will like to view</p>
                        </li>
                    </ul>
                </td>
            </tr>
            <tr>
                <td class="auto-style66">&nbsp;</td>
                <td class="auto-style67">
                    <asp:Label ID="Label58" runat="server" style="font-weight: 700" Text="Vacant Position"></asp:Label>
                </td>
                <td class="auto-style68">
                    <asp:DropDownList ID="ddlVacantPosition" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlVacantPosition_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style65" colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblSelect" runat="server" style="font-style: italic; color: #CC3300; font-weight: 700"></asp:Label>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="6">
                    <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" style="font-weight: 700; color: #000099; background-color: #C0C0C0" Text="All Applicants" Visible="False" />
                    &nbsp;
                    <asp:Button ID="Button13" runat="server" style="font-weight: 700; color: #000099; background-color: #C0C0C0" Text="Shortlisted  applicants" Visible="False" />
                    &nbsp;
                    <asp:Button ID="Button14" runat="server" style="font-weight: 700; color: #000099; background-color: #C0C0C0" Text="Hired applicants" Visible="False" />
                </td>
            </tr>
            <tr>
                <td class="auto-style64" colspan="4">
                    <asp:LinkButton ID="linkAllapplicants" runat="server" OnClick="LinkButton2_Click" Visible="False">All Applicant</asp:LinkButton>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="linkShortlistedApplicants" runat="server" OnClick="linkShortlistedApplicants_Click" Visible="False">Shortlisted Applicants</asp:LinkButton>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="linkHireApplicants" runat="server" Visible="False" OnClick="linkHireApplicants_Click">Hire Applicants</asp:LinkButton>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkApproveApplicant" runat="server" OnClick="LinkApproveApplicant_Click" Visible="False">Approved Applicants</asp:LinkButton>
                </td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style64" colspan="6">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="6">
                    <asp:GridView ID="GVReport" runat="server" AutoGenerateColumns="False" EnableModelValidation="True">
                        <Columns>
                            <asp:BoundField DataField="ApplicantNum" HeaderText="ApplicantNum" />
                            <asp:BoundField DataField="PositionAppliedFor" HeaderText="Position AppliedFor" />
                            <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
                            <asp:BoundField DataField="LastName" HeaderText="LastName" />
                            <asp:BoundField DataField="Gender" HeaderText="Gender" />
                            <asp:BoundField DataField="Age" HeaderText="Age" />
                            <asp:BoundField DataField="MaritalStatus" HeaderText="MaritalStatus" />
                            <asp:BoundField DataField="PhoneNo" HeaderText="PhoneNo" />
                            <asp:BoundField DataField="ApplicationStatus" HeaderText="Application Status" />
                            <asp:BoundField DataField="InterviewerDecision" HeaderText="Interviewer Decision" />
                            <asp:BoundField DataField="ManagementDecision" HeaderText="Management Decision" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style63" colspan="4">
                    <asp:Label ID="lblReport" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style64" colspan="4"></td>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style63" colspan="4">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:View>
<asp:View ID="View2" runat="server">
    <table style="border: medium solid #CC3300; width: 100%;">
        <tr>
            <td class="auto-style69">
                <asp:Label ID="Label60" runat="server" Text="Management Decision" style="font-weight: 700; color: #CC3300"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style69">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <ul class="auto-style52">
                    <li><p>Select position to view applicant and interviewer decision</p></li>
                    <li><p>Approve the decision by selecting the checkbox and click on the approve button.</p></li>
                </ul>
            </td>
        </tr>
        <tr>
            <td class="auto-style74"></td>
            <td class="auto-style74">
                <asp:Label ID="Label61" runat="server" Text="Available position"></asp:Label>
            </td>
            <td class="auto-style74">
                <asp:DropDownList ID="ddlPositionMgt" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPositionMgt_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style70"></td>
            <td class="auto-style1"></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style69" colspan="3">
                <asp:GridView ID="GVHireApplicants" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" OnRowCommand="GVHireApplicants_RowCommand">
                    <Columns>
                        <asp:BoundField DataField="ApplicantNum" HeaderText="ApplicantNum" />
                        <asp:BoundField DataField="PositionAppliedFor" HeaderText="Position AppliedFor" />
                        <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
                        <asp:BoundField DataField="LastName" HeaderText="LastName" />
                        <asp:BoundField DataField="Gender" HeaderText="Gender" />
                        <asp:BoundField DataField="Age" HeaderText="Age" />
                        <asp:BoundField DataField="InterviewerDecision" HeaderText="Interviewer Decision" />
                        <asp:BoundField DataField="DeptName" HeaderText="Dept" />
                        <asp:BoundField DataField="ApprovedPositionName" HeaderText="Approved Position" />
                        <asp:BoundField DataField="LevelName" HeaderText="Level" />
                        <asp:BoundField DataField="Salary" HeaderText="Salary" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%#DataBinder.Eval (Container,"DataItem.ApplicantID")%>' CommandName="View">View</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Approve">
                            <EditItemTemplate>
                                <asp:CheckBox ID="CheckBox1" runat="server" />
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="CheckBox1" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField >
                            <ItemTemplate>
                                <asp:TextBox ID="TextBoxID" runat="server" Visible="false" Text='<%#DataBinder.Eval (Container,"DataItem.ApplicantID")%>'></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style1">
                <asp:Button ID="Button16" runat="server" OnClick="Button16_Click" style="font-weight: 700; color: #CC3300" Text="Approve" Visible="False" />
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style69">&nbsp;</td>
            <td colspan="2">
                <asp:Label ID="lblHireReport" runat="server" style="font-style: italic; font-weight: 700; color: #CC3300"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style69">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style69" colspan="3">
                <asp:Panel ID="PanelApplicants" runat="server" Visible="False">
                    <table style="border: 1px solid #990033; width: 80%;  margin-left:75px; ">
                            <tr>
                                <td class="auto-style85" colspan="5"><strong class="auto-style54"><em>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Applicant Information</em></strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style48" colspan="5">
                                    <asp:Image ID="Image2" runat="server" BorderColor="#CC3300" BorderWidth="3px" Height="167px" ImageAlign="Middle" Width="171px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Position applied for:</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblApprovePosition" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>Applicant No:</strong></td>
                                <td>
                                    <asp:Label ID="lblApproveAppNum" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>First Name</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblApproveName" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>Nationality</strong></td>
                                <td>
                                    <asp:Label ID="lblApproveNationality" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Middle Name</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblapproveMName" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style50"><strong style="color: #333333">State of Origin</strong></td>
                                <td>
                                    <asp:Label ID="lblApproveState" runat="server" Enabled="False" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Last Name</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblapproveLName" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>LGA</strong></td>
                                <td>
                                    <asp:Label ID="lblApproveLga" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Gender</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblApproveGender" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>Home Town</strong></td>
                                <td>
                                    <asp:Label ID="lblapproveHTown" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Marital Status</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblapproveMaritalStatus" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>Email</strong></td>
                                <td>
                                    <asp:Label ID="lblApproveEmail" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>DOB</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblapproveDOB" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style50"><strong style="color: #333333">PhoneNo</strong></td>
                                <td>
                                    <asp:Label ID="lblApprovePhoneNo" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Age</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblApproveAge" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>ContactAddress</strong></td>
                                <td>
                                    <asp:Label ID="lblapproveAddr" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style50" colspan="5"><em><strong>Qualification</strong></em></td>
                            </tr>
                            <tr>
                                <td class="auto-style58" colspan="5">
                                    <asp:GridView ID="GVQualif" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Vertical">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="InstitutionName" HeaderText="Institution" />
                                            <asp:BoundField DataField="Course" HeaderText="Course" />
                                            <asp:BoundField DataField="QualificationType" HeaderText="Qualification" />
                                            <asp:BoundField DataField="Grade" HeaderText="Grade" />
                                            <asp:BoundField DataField="StartYear" HeaderText="StartYear" />
                                            <asp:BoundField DataField="EndYear" HeaderText="EndYear" />
                                        </Columns>
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#F7F7DE" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style58"></td>
                                <td class="auto-style53"></td>
                                <td class="auto-style52"></td>
                                <td class="auto-style54"></td>
                                <td class="auto-style52"></td>
                            </tr>
                            <tr>
                                <td class="auto-style50" colspan="5"><strong><em>Professional Qualification</em></strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style58" colspan="5">
                                    <asp:GridView ID="GVProfQualif" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Vertical">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="CertificationName" HeaderText="Certification" />
                                            <asp:BoundField DataField="Stage" HeaderText="Stage" />
                                            <asp:BoundField DataField="CertYear" HeaderText="Year Obtained" />
                                        </Columns>
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#F7F7DE" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style58">&nbsp;</td>
                                <td class="auto-style53">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style50" colspan="5"><strong><em>Work Experience</em></strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style58" colspan="5">
                                    <asp:GridView ID="GVWrkExp" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Vertical">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="CompanyName" HeaderText="Company Name" />
                                            <asp:BoundField DataField="PositionHeld" HeaderText="Position Held" />
                                            <asp:BoundField DataField="JobDescriprtion" HeaderText="Job Descriprtion" />
                                            <asp:BoundField DataField="SalaryReceived" HeaderText="Salary Received" />
                                            <asp:BoundField DataField="StartYear" HeaderText="Start Year" />
                                            <asp:BoundField DataField="EndYear" HeaderText="End Year" />
                                        </Columns>
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#F7F7DE" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style58">&nbsp;</td>
                                <td class="auto-style53">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style50"><strong><em>Uploaded Documents</em></strong></td>
                                <td class="auto-style53">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style58" colspan="5">
                                    <asp:GridView ID="GVDoc" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Vertical" Visible="False">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="DocumentType" HeaderText="Document Type" />
                                            <asp:BoundField DataField="DocumentPath" HeaderText="Document" />
                                        </Columns>
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#F7F7DE" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style58">&nbsp;</td>
                                <td class="auto-style53">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                            </tr>
                        </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="auto-style69">&nbsp;</td>
            <td colspan="2">
                <asp:Button ID="Button18" runat="server" OnClick="Button18_Click" style="font-weight: 700" Text="close" />
            </td>
        </tr>
        <tr>
            <td class="auto-style69">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
        </tr>
    </table>
</asp:View>



<asp:View ID="View4" runat="server">
    <table style="border: medium solid #CC3300; width: 100%;">
        <tr>
            <td class="auto-style72" colspan="4">
                <asp:Label ID="Label71" runat="server" Text=" List and Send Employment Letter to Approved Applicants" style="font-weight: 700; font-style: italic; color: #CC3300"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style72">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style72">&nbsp;</td>
            <td>
                <asp:Label ID="Label62" runat="server" style="font-weight: 700; color: #CC3300" Text="Position Applied For"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlAvailablePosition2" runat="server" Width="254px" AutoPostBack="True" OnSelectedIndexChanged="ddlAvailablePosition2_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style72">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style72" colspan="3">
                <asp:GridView ID="GVSendOffer" runat="server" AutoGenerateColumns="False" EnableModelValidation="True">
                    <Columns>
                        <asp:BoundField DataField="ApplicantNum" HeaderText="ApplicantNum" />
                        <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
                        <asp:BoundField DataField="LastName" HeaderText="LastName" />
                        <asp:BoundField DataField="Gender" HeaderText="Gender" />
                        <asp:BoundField DataField="Age" HeaderText="Age" />
                        <asp:BoundField DataField="MaritalStatus" HeaderText="MaritalStatus" />
                        <asp:BoundField DataField="PositionAppliedFor" HeaderText="Position Applied for" />
                        <asp:BoundField DataField="ApprovedPositionName" HeaderText="Position Given" />
                        <asp:BoundField DataField="InterviewerDecision" HeaderText="Interviewer Decision" />
                        <asp:BoundField DataField="ManagementDecision" HeaderText="Mgt Decision" />
                        <asp:TemplateField HeaderText="Send Offer">
                            <EditItemTemplate>
                                <asp:CheckBox ID="CheckBox1" runat="server" />
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="CheckBox1" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:TextBox ID="txtApplicantID" runat="server" Text='<%#DataBinder.Eval(Container, "DataItem.ApplicantID")%>' Visible="false">"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style72">&nbsp;</td>
            <td>
                <asp:Label ID="lblReport2" runat="server" style="color: #FF3300; font-style: italic"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style73"></td>
            <td class="auto-style1">
                &nbsp;</td>
            <td class="auto-style1">
                <asp:Button ID="Button20" runat="server" ForeColor="#CC3300" style="font-weight: 700" Text="Send Offer" OnClick="Button20_Click" />
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style72">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style72">&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:View>
<asp:View ID="View5" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">    <asp:Panel ID="Panel3" runat="server">
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
                <td colspan="3">
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
                <asp:Button ID="Button21" runat="server" OnClick="Button21_Click" style="font-weight: 700" Text="Back" />
            </td>
            <td>
                <asp:Button ID="btnPrint" runat="server" OnClick="btnPrint_Click" style="font-weight: 700" Text="Print" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
            </asp:View>
</asp:MultiView></td>
    </tr>
    <tr>
        <td class="auto-style1"></td>
        <td class="auto-style1">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>




