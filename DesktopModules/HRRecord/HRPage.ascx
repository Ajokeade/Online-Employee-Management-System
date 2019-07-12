<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HRPage.ascx.cs" Inherits="Bilikis.HRManagementSystem.HRPage" %>
<style type="text/css">
    .auto-style1 {
    }
    .auto-style2 {
        width: 496px;
    }
    .auto-style3 {
        height: 23px;
    }
    .auto-style4 {
    }
    .auto-style7 {
        height: 23px;
        width: 238px;
    }
    .auto-style8 {
        width: 136px;
    }
    .auto-style9 {
        height: 23px;
        width: 136px;
    }
    .auto-style11 {
        height: 26px;
    }
    .auto-style18 {
        width: 281px;
    }
    .auto-style19 {
    }
    .auto-style20 {
    }
    .auto-style22 {
        height: 13px;
    }
    .auto-style29 {
        height: 13px;
        width: 177px;
    }
    .auto-style40 {
    }
    .auto-style43 {
        width: 156px;
    }
    #txtRefContAddr {
        width: 206px;
    }
    #txtRefContAddr0 {
        width: 206px;
    }
    .auto-style54 {
    }
    .auto-style56 {
    }
    .auto-style59 {
    }
    .auto-style61 {
        width: 205px;
    }
    .auto-style62 {
        height: 23px;
        width: 205px;
    }
    .auto-style65 {
    }
    .auto-style75 {
        height: 23px;
        width: 169px;
    }
    .auto-style79 {
        height: 23px;
        }
    .auto-style80 {
        width: 314px;
    }
    .auto-style81 {
        height: 23px;
        width: 314px;
    }
    .auto-style86 {
        height: 23px;
        }
    .auto-style87 {
    }
    .auto-style88 {
        height: 23px;
        width: 234px;
    }
    .auto-style89 {
        width: 234px;
    }
    .auto-style90 {
        height: 23px;
        width: 276px;
    }
    .auto-style91 {
        width: 276px;
    }
    .auto-style92 {
        width: 280px;
    }
    .auto-style94 {
    }
    .auto-style99 {
        height: 30px;
    }
    .auto-style108 {
        height: 23px;
        width: 159px;
    }
    .auto-style109 {
        width: 159px;
    }
    .auto-style111 {
        height: 23px;
        width: 331px;
    }
    .auto-style112 {
        width: 331px;
    }
    .auto-style117 {
        height: 23px;
    }
    .auto-style119 {
        height: 23px;
        width: 239px;
    }
    .auto-style120 {
        width: 239px;
    }
    .auto-style121 {
        height: 23px;
        width: 226px;
    }
    .auto-style122 {
        width: 226px;
    }
    .auto-style123 {
        width: 172px;
    }
    .auto-style124 {
        height: 23px;
        width: 172px;
    }
    .auto-style132 {
        width: 16px;
    }
    .auto-style136 {
        width: 185px;
    }
    .auto-style137 {
        height: 23px;
        width: 185px;
    }
    .auto-style142 {
    }
    .auto-style145 {
        height: 13px;
        width: 320px;
    }
    .auto-style146 {
        width: 578px;
    }
    .auto-style148 {
        width: 132px;
    }
    .auto-style149 {
        width: 278px;
    }
    .auto-style154 {
        width: 162px;
    }
    .auto-style155 {
        width: 162px;
        height: 30px;
    }
    .auto-style156 {
        width: 123px;
        height: 30px;
    }
    .auto-style157 {
    }
    .auto-style159 {
    }
    .auto-style162 {
        width: 572px;
    }
    .auto-style165 {
    }
    .auto-style167 {
        width: 717px;
    }
    .auto-style168 {
        width: 211px;
    }
    .auto-style169 {
        width: 349px;
    }
    .auto-style170 {
        width: 349px;
        height: 30px;
    }
    .auto-style172 {
        width: 81px;
    }
    .auto-style173 {
        height: 26px;
        }
    .auto-style176 {
    }
    .auto-style177 {
        height: 20px;
    }
    .auto-style178 {
        width: 154px;
    }
    .auto-style180 {
    }
    .auto-style182 {
    }
    #TextArea1 {
        width: 242px;
    }
    .auto-style183 {
    }
    .auto-style186 {
        width: 116px;
    }
    .auto-style188 {
        height: 23px;
        width: 162px;
    }
    </style>
<table style="width: 100%;">
    
    <tr>
        <td valign="top">
            <table style="width: 100%;">
                <tr>
                    <td>
             <asp:Button ID="welHometBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Home" Width="150
                 px" OnClick="welHometBtn_Click" Height="45px" />
                    </td>
                    
                </tr>
                <tr>
                    <td>
             <asp:Button ID="welEmplomentBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Send Offer" Width="150
                 px" OnClick="welEmplomentBtn_Click" Height="45px" Visible="False" />
                    </td>
                   
                </tr>
                <tr>
                    <td>
             <asp:Button ID="sendemploy" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Send Offer2" Width="150
                 px" OnClick="sendemploy_Click" Height="45px" Visible="False" />
                    </td>
                   
                </tr>
                <tr>
                    <td>
            <asp:Button ID="hrEmpAccptMenuBtn" runat="server" Height="45px" Text="Acceptance" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Width="150px" OnClick="hrEmpAccptMenuBtn_Click" />
                    </td>
                    
                </tr>
                
                <tr>
                    <td>
            <asp:Button ID="hrEmpMenuBtn" runat="server" Height="45px" Text="Employee Profile" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" OnClick="hrEmpMenuBtn_Click" Width="150px" />
                    </td>
                    
                </tr>
                <tr>
                    <td>
            <asp:Button ID="hrApproval" runat="server" Height="45px" Text="Approval" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" OnClick="Approval_Click" Width="150px" />
                    </td>
                    
                </tr>
                 <tr>
                    <td>
                <asp:Button ID="welConfirmBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Confirmation " Width="150px" OnClick="welConfirmBtn_Click" Height="45px" />
                     </td>
                    
                </tr>
                <tr>
                    <td>
                <asp:Button ID="trainingMenuBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Height="45px" OnClick="trainingMenuBtn_Click" Text="Training" Width="150px" />
                    </td>
                   
                </tr>
                <tr>
                    <td>
                <asp:Button ID="welTransferBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Transfer" Width="150px" OnClick="welTransferBtn_Click" Height="45px" />
                    </td>
                    
                </tr>
                 <tr>
                    <td>
                <asp:Button ID="welLeave" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Height="45px" Text="Leave" Width="150px" OnClick="welLeave_Click" />
                     </td>
                    
                </tr>
                <tr>
                    <td>
                <asp:Button ID="welQuery" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text=" Query" Width="150px" OnClick="welQuery_Click" Height="45px" />
                    </td>
                   
                </tr>
                <tr>
                    <td>
                <asp:Button ID="welAppraisal" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Appraisal" Width="150px" OnClick="welAppraisal_Click" Height="45px" />
                    </td>
                    
                </tr>
                <tr>
                    <td>
                <asp:Button ID="welPromotion" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Promotion" Width="150px" OnClick="welPromotion_Click" Height="45px" />
                    </td>
                   
                </tr>
                <tr>
                    <td>
                <asp:Button ID="welPension" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Retirement" Width="150px" OnClick="welPensionRetirement_Click" Height="45px" />
                    </td>
                    
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    
                </tr>
            </table>
            </td>
        <td valign="top">
&nbsp;<asp:MultiView ID="MViewHRPage" runat="server">
    
<asp:View ID="ViewHRWelcomePage" runat="server">
    <table style="width: 100%; border: medium solid #CC0066; width:100%;" valign="top">
        <tr>
            <td class="auto-style1" colspan="3">
                <asp:Label ID="LbWelcom0" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="12pt" ForeColor="#CC0066" Text=" Welcome to HR Session, Please select the Module you want to use"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:View>

    <asp:View ID="View1" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
            <tr>
                <td class="auto-style3" colspan="3">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="12pt" ForeColor="#CC0066" Text="Select and Send Employment Letter to Approved Applicants"></asp:Label>
                </td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style172">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">
                    &nbsp;</td>
                <td class="auto-style172">
                    <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="14pt" Text="Applicant"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="sendOfferAppIDList" runat="server" Width="250px" AutoPostBack="True" OnSelectedIndexChanged="sendOfferAppIDList_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
          
            <tr>
                <td class="auto-style157">&nbsp;</td>
                <td class="auto-style172">&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style157" colspan="4">
                    <asp:Panel ID="PanelSendOfferLabel" runat="server">
                        <table style="width: 100%;">
                                     
           <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style169">
                    <asp:Label ID="Label19" runat="server" Font-Bold="True" Font-Size="14pt" Text="Department"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbSendOfferDept" runat="server" Font-Bold="False" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
               <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style157">&nbsp;</td>
                <td class="auto-style169">&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style169">
                    <asp:Label ID="Label20" runat="server" Font-Bold="True" Font-Size="14pt" Text="Approved Position"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbSendOfferApprovedPosition" runat="server" Font-Bold="False" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
              
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style169">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style169">
                    <asp:Label ID="Label21" runat="server" Font-Bold="True" Font-Size="14pt" Text="Level"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbSendOfferLevel" runat="server" Font-Bold="False" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style169">&nbsp;</td>
                <td>&nbsp;&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style169">
                    <asp:Label ID="Label22" runat="server" Font-Bold="True" Font-Size="14pt" Text="Salary"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbSendOfferSalary" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                </td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style169">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style169">
                    <asp:Label ID="Label24" runat="server" Font-Bold="True" Font-Size="14pt" Text="Work Location"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbSendOfferWorkLoc" runat="server" Font-Bold="False" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style169">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style169">&nbsp;</td>
                <td>
                    <asp:Label ID="LbSendOfferResumptionDate" runat="server" Font-Bold="False" ForeColor="#CC0066" Text="Label" Visible="False"></asp:Label>
                </td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style169">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style155"></td>
                <td class="auto-style170">
                    <asp:Label ID="Label25" runat="server" Font-Bold="True" Font-Size="14pt" Text="Resumption Date"></asp:Label>
                </td>
                <td class="auto-style99">
                    <asp:DropDownList ID="DropDownList7" runat="server">
                    </asp:DropDownList>
                    &nbsp;<asp:DropDownList ID="DropDownList8" runat="server">
                        <asp:ListItem Value="00">*Month*</asp:ListItem>
                        <asp:ListItem Value="01">Jan</asp:ListItem>
                        <asp:ListItem Value="02">Feb</asp:ListItem>
                        <asp:ListItem Value="03">Mar</asp:ListItem>
                        <asp:ListItem Value="04">Apr</asp:ListItem>
                        <asp:ListItem Value="05">May</asp:ListItem>
                        <asp:ListItem Value="06">Jun</asp:ListItem>
                        <asp:ListItem Value="07">Jul</asp:ListItem>
                        <asp:ListItem Value="08">Aug</asp:ListItem>
                        <asp:ListItem Value="09">Sep</asp:ListItem>
                        <asp:ListItem Value="10">Oct</asp:ListItem>
                        <asp:ListItem Value="11">Nov</asp:ListItem>
                        <asp:ListItem Value="12">Dec</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<asp:DropDownList ID="DropDownList9" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                    <%--   <asp:RequiredFieldValidator ID="DOBReqFieldVal0" runat="server" ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="DOBRequired" SetFocusOnError="True">DOBRequired</asp:RequiredFieldValidator>
        --%>&nbsp; </td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
                           
                        </table>
                    </asp:Panel>

                </td>
            </tr>

            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style172">&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style19" colspan="4">
                    <asp:Panel ID="PanelSendOfferLetter" runat="server" Visible="False">
                        <table style="width:100%;">
                            <tr>
                                <td class="auto-style159">&nbsp;</td>
                                <td></td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                   <tr>
                       <td colspan="4">
                        <table style="width:100%;">
                                                        <tr>
                                <td class="auto-style159" >
                                    <br />
                                </td>
                                                              <td>&nbsp;</td>
                                <td class="auto-style162">&nbsp;</td>
                                <td valign="right">
                                    <asp:Label ID="Label28" runat="server" Text="Neetbeet Technologies Limited" valign="right"></asp:Label>
                                    ,<br />
                                    <asp:Label ID="Label30" runat="server" Text="13, Adekunbi Cresent, Ikeja" valign="right"></asp:Label>
                                                            </td>
                         
                            </tr>
                            <tr>
                                <td colspan="4" valign="left">
                                    <asp:Label ID="sendOfferLetterDate" runat="server" Text="Datehere"></asp:Label>, </td>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <asp:Label ID="sendOfferNames" runat="server" Text="name"></asp:Label>, <br />
                                </td>
                            </tr>
                                                        <tr>
                                                            <td colspan="4">
                                                                <asp:Label ID="sendOfferAddr" runat="server" Text="adrr"></asp:Label>
                                                                ,</td>
                                                        </tr>
                            </table>
                           </td></tr>
                            <tr>
                                <td> Dear&nbsp;
                                    <asp:Label ID="sendOfferLName" runat="server" Text="Label"></asp:Label>
                                    ,</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            
                       <tr><td>
                        <table style="width:100%;">
                           
                            <tr>
                                <td class="auto-style159" colspan="4"><center><b><u>Appointment Letter </u></b></center></td>
                                <td></td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style159">&nbsp;</td>
                                <td><p>Further to your application and subsquent interviewat Neetbeet Technogies Limited, we are please to offer you and appointment as
                                    <asp:Label ID="sendOfferLetterPosition1" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                                    &nbsp; under the department of  <asp:Label ID="sendOfferLetterDept1" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                                    . The following are your appointment detail:
                                    <br />
                                    <ul>
                                        <li>Position:&nbsp;&nbsp;
                                            <asp:Label ID="sendOfferLetterPosition2" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                                        </li>
                                        <li>Department:&nbsp;&nbsp;
                                            <asp:Label ID="sendOfferLetterDept2" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                                        </li>
                                        <li>Level:&nbsp;&nbsp;
                                            <asp:Label ID="sendOfferLetterLevel" runat="server" ForeColor="#990033" Text="Label"></asp:Label> </li>
                                            <li>Basic Salary:&nbsp;&nbsp;
                                                <asp:Label ID="sendOfferLetterSalary" runat="server" ForeColor="#990033" Text="Label"></asp:Label> </li>
                                                <li>Work Location:&nbsp;&nbsp;
                                                    <asp:Label ID="sendOfferLetterWorkLoc" runat="server" ForeColor="#990033" Text="Label"></asp:Label></li>
                                                    <li>Resumption Date:&nbsp;&nbsp;
                                                        <asp:Label ID="sendOfferLetterResumptionDate" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                                                    </li>
                                    </ul>
                                    <p>
                                   
                                </td>
                                <td></td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style159">&nbsp;</td>
                                <td><p>The first six months of your employment with us will be regarded as a propationary period, during which , either you o the company could terminate the appointment
                                    by giving one (1) month's notice in writing or paying one (1) month's basic salary in lieuof notice.
                                    </p></td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                           </td></tr>
</table>

                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style172">
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" OnClick="sendEmploymentLetterBtn_Click" Text="Send" Width="122px" />
                </td>
                <td>
                    <asp:Label ID="Label48" runat="server" ForeColor="#990033" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style172">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
</asp:View>

    <asp:View ID="OfferEmpView" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
            <tr>
                <td class="auto-style3" colspan="3">
                    <asp:Label ID="LbWelcom1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="12pt" ForeColor="#CC0066" Text="Select and Send Employment Letter to Approved Applicants"></asp:Label>
                </td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">
                    &nbsp;</td>
                <td class="auto-style157">
                    <asp:Label ID="LbAppliNameList0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Applicant"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="sendOfferApplicantList" runat="server" Width="250px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
          
            <tr>
                <td class="auto-style157">&nbsp;</td>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            
           <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style157">
                    <asp:Label ID="LbAppliNameList1" runat="server" Font-Bold="True" Font-Size="14pt" Text="Department"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="HrSendOfferDeptList" runat="server" Width="250px" AutoPostBack="True" OnSelectedIndexChanged="HrSendOfferDeptList_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
               <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style157">&nbsp;</td>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style157">
                    <asp:Label ID="LbAppliNameList" runat="server" Font-Bold="True" Font-Size="14pt" Text="Approved Position"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="approvedPositionList" runat="server" AutoPostBack="True" Height="16px" Width="250px">
                        <asp:ListItem>---Please select---</asp:ListItem>
                        <asp:ListItem>Accountant II</asp:ListItem>
                        <asp:ListItem>Administrative Officer</asp:ListItem>
                        <asp:ListItem>Assistance Registrar</asp:ListItem>
                        <asp:ListItem>Bursar</asp:ListItem>
                        <asp:ListItem>Deputy Bursar</asp:ListItem>
                        <asp:ListItem>Deputy Registrar</asp:ListItem>
                        <asp:ListItem>Registrar</asp:ListItem>
                        <asp:ListItem>Personal Secretary</asp:ListItem>
                        <asp:ListItem>Professor</asp:ListItem>
                        <asp:ListItem>Senior Accountant</asp:ListItem>
                        <asp:ListItem>Senior Lecturer</asp:ListItem>
                        <asp:ListItem>System Analyst</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
              
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style157">
                    <asp:Label ID="LbAppliNameList5" runat="server" Font-Bold="True" Font-Size="14pt" Text="Level"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="hrSendOfferLevelList" runat="server" Width="250px" AutoPostBack="True" OnSelectedIndexChanged="hrSendOfferLevelList_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
                <td>&nbsp;&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style157">
                    <asp:Label ID="LbAppliNameList8" runat="server" Font-Bold="True" Font-Size="14pt" Text="Salary"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbSalary1" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                </td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style157">
                    <asp:Label ID="LbAppliNameList6" runat="server" Font-Bold="True" Font-Size="14pt" Text="Work Location"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="hrSendOfferWorkLocList" runat="server" Width="250px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style155"></td>
                <td class="auto-style156">
                    <asp:Label ID="LbAppliNameList7" runat="server" Font-Bold="True" Font-Size="14pt" Text="Resumption Date"></asp:Label>
                </td>
                <td class="auto-style99">
                    <asp:DropDownList ID="sendOfferResumptionDayList" runat="server">
                    </asp:DropDownList>
                    &nbsp;<asp:DropDownList ID="sendOfferResumptionMonthList" runat="server">
                        <asp:ListItem Value="00">*Month*</asp:ListItem>
                        <asp:ListItem Value="01">Jan</asp:ListItem>
                        <asp:ListItem Value="02">Feb</asp:ListItem>
                        <asp:ListItem Value="03">Mar</asp:ListItem>
                        <asp:ListItem Value="04">Apr</asp:ListItem>
                        <asp:ListItem Value="05">May</asp:ListItem>
                        <asp:ListItem Value="06">Jun</asp:ListItem>
                        <asp:ListItem Value="07">Jul</asp:ListItem>
                        <asp:ListItem Value="08">Aug</asp:ListItem>
                        <asp:ListItem Value="09">Sep</asp:ListItem>
                        <asp:ListItem Value="10">Oct</asp:ListItem>
                        <asp:ListItem Value="11">Nov</asp:ListItem>
                        <asp:ListItem Value="12">Dec</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<asp:DropDownList ID="sendOfferResumptionYearList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="sendOfferResumptionYearList_SelectedIndexChanged">
                    </asp:DropDownList>
                    <%--   <asp:RequiredFieldValidator ID="DOBReqFieldVal0" runat="server" ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="DOBRequired" SetFocusOnError="True">DOBRequired</asp:RequiredFieldValidator>
        --%>&nbsp; </td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style19" colspan="4">
                    <asp:Panel ID="sendOfferPanel" runat="server" Visible="False">
                        <table style="width:100%;">
                            <tr>
                                <td class="auto-style159">&nbsp;</td>
                                <td></td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                   <tr>
                       <td colspan="4">
                        <table style="width:100%;">
                                                        <tr>
                                <td class="auto-style159" >
                                    <br />
                                </td>
                                                              <td>&nbsp;</td>
                                <td class="auto-style162">&nbsp;</td>
                                <td valign="right">
                                    <asp:Label ID="Label16" runat="server" Text="Neetbeet Technologies Limited" valign="right"></asp:Label>
                                    ,<br />
                                    <asp:Label ID="Label33" runat="server" Text="13, Adekunbi Cresent, Ikeja" valign="right"></asp:Label>
                                                            </td>
                         
                            </tr>
                            <tr>
                                <td colspan="4" valign="left">
                                    <asp:Label ID="LbSysDate" runat="server" Text="Datehere"></asp:Label>, </td>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <asp:Label ID="LbApplicantNames" runat="server" Text="name"></asp:Label>, <br />
                                </td>
                            </tr>
                                                        <tr>
                                                            <td colspan="4">
                                                                <asp:Label ID="LbHomeAddres" runat="server" Text="adrr"></asp:Label>
                                                                ,</td>
                                                        </tr>
                            </table>
                           </td></tr>
                            <tr>
                                <td> Dear&nbsp;
                                    <asp:Label ID="LbAppLName" runat="server" Text="Label"></asp:Label>
                                    ,</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            
                       <tr><td>
                        <table style="width:100%;">
                           
                            <tr>
                                <td class="auto-style159" colspan="4"><center><b><u>Appointment Letter </u></b></center></td>
                                <td></td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style159">&nbsp;</td>
                                <td><p>Further to your application and subsquent interviewat Neetbeet Technogies Limited, we are please to offer you and appointment as
                                    <asp:Label ID="LbPosition1" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                                    &nbsp; under the department of  <asp:Label ID="LbsendOfferDept1" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                                    . The following are your appointment detail:
                                    <br />
                                    <ul>
                                        <li>Position:&nbsp;&nbsp;
                                            <asp:Label ID="LbPosition" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                                        </li>
                                        <li>Department:&nbsp;&nbsp;
                                            <asp:Label ID="LbsendOfferDept2" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                                        </li>
                                        <li>Level:&nbsp;&nbsp;
                                            <asp:Label ID="LbLevel" runat="server" ForeColor="#990033" Text="Label"></asp:Label> </li>
                                            <li>Basic Salary:&nbsp;&nbsp;
                                                <asp:Label ID="LbSalary2" runat="server" ForeColor="#990033" Text="Label"></asp:Label> </li>
                                                <li>Work Loction:&nbsp;&nbsp;
                                                    <asp:Label ID="LbWorkLocation" runat="server" ForeColor="#990033" Text="Label"></asp:Label></li>
                                                    <li>Resumption Date:&nbsp;&nbsp;
                                                        <asp:Label ID="LbResumptionDate" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                                                    </li>
                                    </ul>
                                    <p>
                                   
                                </td>
                                <td></td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style159">&nbsp;</td>
                                <td><p>The first six months of your employment with us will be regarded as a propationary period, during which , either you o the company could terminate the appointment
                                    by giving one (1) month's notice in writing or paying one (1) month's basic salary in lieuof notice.
                                    </p></td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                           </td></tr>
</table>

                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style157">
                    <asp:Button ID="sendEmploymentLetterBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" OnClick="sendEmploymentLetterBtn_Click" Text="Send" Width="122px" />
                </td>
                <td>
                    <asp:Label ID="LbOffersent" runat="server" ForeColor="#990033" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style157">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
</asp:View>

    <asp:View ID="ViewEmployementAcceptance" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width: 100%;">
              <tr>
                  <td class="auto-style165" colspan="6">
                      <asp:Label ID="Label96" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Employment Acceptance"></asp:Label>
                  </td>
              </tr>
              <tr>
                  <td class="auto-style186">&nbsp;</td>
                  <td class="auto-style178">&nbsp;</td>
                  <td class="auto-style132">&nbsp;</td>
                  <td class="auto-style22">&nbsp;</td>
                  <td class="auto-style19">&nbsp;</td>
                  <td class="auto-style20">&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style186">&nbsp;</td>
                  <td class="auto-style178">
                      <asp:Label ID="LbAppliNameList4" runat="server" Font-Bold="True" Font-Size="14pt" Text="Applicant"></asp:Label>
                  </td>
                  <td class="auto-style132">
                      <asp:DropDownList ID="AcceptanceapplicantList" runat="server" Width="250px" AutoPostBack="True" OnSelectedIndexChanged="AcceptanceapplicantList_SelectedIndexChanged"></asp:DropDownList>
                      
                  </td>
                  <td class="auto-style22">&nbsp;</td>
                  <td class="auto-style19">&nbsp;</td>
                  <td class="auto-style20">&nbsp;</td>
              </tr>
              <tr>
                  
                  <td class="auto-style186">&nbsp;</td>
                  <td class="auto-style178">
                      &nbsp;</td>
                  <td class="auto-style132">
                      &nbsp;</td>
                  <td class="auto-style22">&nbsp;</td>
                  <td class="auto-style19">&nbsp;</td>
                  <td class="auto-style20">&nbsp;</td>
              </tr>

            <%-- <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style166">
                    <asp:Label ID="Label15" runat="server" Font-Bold="True" Font-Size="14pt" Text="Department"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="AcceptanceDeptList" runat="server" Width="250px" AutoPostBack="True" OnSelectedIndexChanged="AcceptanceDeptList_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                   <td class="auto-style22">&nbsp;</td>
                  <td class="auto-style19">&nbsp;</td>
                  <td class="auto-style20">&nbsp;</td>
            </tr>
            <tr>
                  <td class="auto-style22">&nbsp;</td>
                  <td class="auto-style166">&nbsp;</td>
                  <td class="auto-style20">&nbsp;</td>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style166">
                    <asp:Label ID="Label20" runat="server" Font-Bold="True" Font-Size="14pt" Text="Vacant Position"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="AccptPositionList" runat="server" Width="250px">
                    </asp:DropDownList>
                </td>
                  <td class="auto-style22">&nbsp;</td>
                  <td class="auto-style19">&nbsp;</td>
                  <td class="auto-style20">&nbsp;</td>
            </tr>
              
            <tr>
                  <td class="auto-style22">&nbsp;</td>
                  <td class="auto-style166">&nbsp;</td>
                  <td class="auto-style20">&nbsp;</td>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style166">
                    <asp:Label ID="Label23" runat="server" Font-Bold="True" Font-Size="14pt" Text="Level"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="AcceptanceLevelList" runat="server" Width="250px" AutoPostBack="True" OnSelectedIndexChanged="AcceptanceLevelList_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                  <td class="auto-style22">&nbsp;</td>
                  <td class="auto-style19">&nbsp;</td>
                  <td class="auto-style20">&nbsp;</td>
            </tr>
            <tr>
                  <td class="auto-style22">&nbsp;</td>
                  <td class="auto-style166">&nbsp;</td>
                  <td class="auto-style20">&nbsp;</td>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
                <td>&nbsp;&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style166">
                    <asp:Label ID="Label28" runat="server" Font-Bold="True" Font-Size="14pt" Text="Salary"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbAcceptanceSalary1" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                </td>
                  <td class="auto-style22">&nbsp;</td>
                  <td class="auto-style19">&nbsp;</td>
                  <td class="auto-style20">&nbsp;</td>
            </tr>
            <tr>
                  <td class="auto-style22">&nbsp;</td>
                  <td class="auto-style166">&nbsp;</td>
                  <td class="auto-style20">&nbsp;</td>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style166">
                    <asp:Label ID="Label44" runat="server" Font-Bold="True" Font-Size="14pt" Text="Work Location"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="AcceptanceWorkLocList" runat="server" Width="250px" OnSelectedIndexChanged="AcceptanceWorkLocList_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
                  <td class="auto-style22">&nbsp;</td>
                  <td class="auto-style19">&nbsp;</td>
                  <td class="auto-style20">&nbsp;</td>
            </tr>
            <tr>
                  <td class="auto-style22">&nbsp;</td>
                  <td class="auto-style166">&nbsp;</td>
                  <td class="auto-style20">&nbsp;</td>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                  <td class="auto-style22">&nbsp;</td>
                  <td class="auto-style166">&nbsp;</td>
                  <td class="auto-style20">&nbsp;</td>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>--%>
           <%--  <tr>
              <td class="auto-style142">&nbsp;</td>
              <td class="auto-style136">
                  <asp:Label ID="LbAppliNameList3" runat="server" Font-Bold="True" Font-Size="14pt" Text="Position"></asp:Label>
              </td>
              <td class="auto-style132">
                  <asp:DropDownList ID="acceptancePositionList" runat="server" AutoPostBack="True" Height="16px" Width="250px">
                  </asp:DropDownList>
              </td>
              <td class="auto-style22">&nbsp;</td>
              <td class="auto-style19">&nbsp;</td>
              <td class="auto-style20">&nbsp;</td>
             
              <tr>
                  <td class="auto-style142">&nbsp;</td>
                  <td class="auto-style136">&nbsp;</td>
                  <td class="auto-style132">&nbsp;</td>
                  <td class="auto-style22">&nbsp;</td>
                  <td class="auto-style19">&nbsp;</td>
                  <td class="auto-style20">&nbsp;</td>
              </tr>
        --%>
                 <tr>
                     <td class="auto-style142" colspan="6">
                         <asp:Panel ID="hrEmpProfilePanel" runat="server" Visible="False" Width="90%">
                             <table style="width:80%; margin-left:60px">


                                 <tr>
                                     <td>&nbsp;</td>
                                     <td>&nbsp;</td>
                                     <td class="auto-style154">&nbsp;</td>
                                     <td>&nbsp;</td>
                                     <td>&nbsp;</td>
                                     <td>&nbsp;</td>
                                 </tr>

                                     <tr>
                <td class="auto-style40" colspan="6">
                    <asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Applicant Personal Information" style="font-size: medium"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style136">&nbsp;</td>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
            </tr>


             <tr>
                <td class="auto-style56" colspan="6">
                    <asp:Image ID="AcceptanceImagePassport" runat="server" Height="180px" ImageAlign="Left" Width="190px" BorderColor="#CC0066" BorderStyle="Solid" BorderWidth="2px" />
                    </td>
            </tr>
            <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">&nbsp;</td>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">
                    <asp:Label ID="Label18" runat="server" Font-Bold="True" Text="Position" Font-Size="14pt" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style154">
                    <asp:Label ID="LbempAccpPosition" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
                <td class="auto-style19">
                    &nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">
                    <asp:Label ID="Label98" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Title"></asp:Label>
                </td>
                <td class="auto-style154">
                    <asp:Label ID="LbempAccpTitle" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">
                    <asp:Label ID="Label27" runat="server" Font-Bold="True" Text="First Name" Font-Size="14pt" style="font-size: small"></asp:Label>
                </td>
                <td class="auto-style154">
                    <asp:Label ID="LbEmpAccpFName" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="Label71" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: small" Text="Nationality"></asp:Label>
                 </td>
                <td>
                    <asp:Label ID="LbEmpAccpNationality" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                 </td>
                <td>&nbsp;</td>
            </tr>
    <tr>
        <td class="auto-style142">&nbsp;</td>
        <td class="auto-style137">
            &nbsp;</td>
        <td class="auto-style154">
            &nbsp;</td>
        <td class="auto-style22">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>

                                 <tr>
                                     <td class="auto-style142">&nbsp;</td>
                                     <td class="auto-style137">
                                         <asp:Label ID="Label29" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: small" Text="Middle Name"></asp:Label>
                                     </td>
                                     <td class="auto-style154">
                                         <asp:Label ID="LbempAccpMName" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                                     </td>
                                     <td class="auto-style22">
                                         <asp:Label ID="Label73" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: small" Text="State of Origin"></asp:Label>
                                     </td>
                                     <td>
                                         <asp:Label ID="LbEmpAccptState" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                                     </td>
                                     <td>&nbsp;</td>
                                 </tr>
                                 <tr>
                                     <td class="auto-style142">&nbsp;</td>
                                     <td class="auto-style137">&nbsp;</td>
                                     <td class="auto-style154">&nbsp;</td>
                                     <td class="auto-style22">&nbsp;</td>
                                     <td>&nbsp;</td>
                                     <td>&nbsp;</td>
                                 </tr>

            <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">
                    <asp:Label ID="Label39" runat="server" Font-Bold="True" Font-Size="14pt" Text="Last Name" style="font-size: small"></asp:Label>
                </td>
                <td class="auto-style154">
                    <asp:Label ID="LbEmpAccpLName" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="Label75" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: small" Text="LGA"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbEmpAccpLGA" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">
                    &nbsp;</td>
                <td class="auto-style154">
                    &nbsp;</td>
                <td class="auto-style22">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>

                                 <tr>
                                     <td class="auto-style142">&nbsp;</td>
                                     <td class="auto-style137">
                                         <asp:Label ID="Label67" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: small" Text="Gender"></asp:Label>
                                     </td>
                                     <td class="auto-style154">
                                         <asp:Label ID="LbEmpAccpGender" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                                     </td>
                                     <td class="auto-style22">
                                         <asp:Label ID="Label77" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: small" Text="Home Town"></asp:Label>
                                     </td>
                                     <td>
                                         <asp:Label ID="LbEmpAccpHomeTown" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                                     </td>
                                     <td>&nbsp;</td>
                                 </tr>
                                 <tr>
                                     <td class="auto-style142">&nbsp;</td>
                                     <td class="auto-style137">&nbsp;</td>
                                     <td class="auto-style154">&nbsp;</td>
                                     <td class="auto-style22">&nbsp;</td>
                                     <td>&nbsp;</td>
                                     <td>&nbsp;</td>
                                 </tr>

     <tr>
        <td class="auto-style142">
            &nbsp;</td>
        <td class="auto-style137">
            <asp:Label ID="Label43" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: small" Text="Marital Status"></asp:Label>
         </td>
        <td class="auto-style154">
            <asp:Label ID="LbempAccpMaritaStatus" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
         </td>
        <td class="auto-style22">
            <asp:Label ID="Label45" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: small" Text="Email"></asp:Label>
         </td>
        <td>
            <asp:Label ID="LbEmpAccpEmail" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
         </td>
        <td>&nbsp;</td>
    </tr>

                                 <tr>
                                     <td class="auto-style142">&nbsp;</td>
                                     <td class="auto-style137">
                                         &nbsp;</td>
                                     <td class="auto-style154">
                                         &nbsp;</td>
                                     <td class="auto-style22">
                                         &nbsp;</td>
                                     <td>
                                         &nbsp;</td>
                                     <td>&nbsp;</td>
                                 </tr>
                                 <tr>
                                     <td class="auto-style142">&nbsp;</td>
                                     <td class="auto-style137">
                                         <asp:Label ID="Label79" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: small" Text="DOB"></asp:Label>
                                     </td>
                                     <td class="auto-style154">
                                         <asp:Label ID="LbEmpAccpDoB" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                                     </td>
                                     <td class="auto-style22">
                                         <asp:Label ID="Label65" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: small" Text="PhoneNum"></asp:Label>
                                     </td>
                                     <td>
                                         <asp:Label ID="LbempAccpPhnNo" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                                     </td>
                                     <td>&nbsp;</td>
                                 </tr>
                                 <tr>
                                     <td class="auto-style142">&nbsp;</td>
                                     <td class="auto-style137">&nbsp;</td>
                                     <td class="auto-style154">&nbsp;</td>
                                     <td class="auto-style22">&nbsp;</td>
                                     <td>&nbsp;</td>
                                     <td>&nbsp;</td>
                                 </tr>
                                 <tr>
                                     <td class="auto-style142">&nbsp;</td>
                                     <td class="auto-style137">
                                         <asp:Label ID="Label81" runat="server" Font-Bold="True" Font-Size="14pt" Text="Age" style="font-size: small"></asp:Label>
                                     </td>
                                     <td class="auto-style154">
                                         <asp:Label ID="LbEmpAccptAge" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                                     </td>
                                     <td class="auto-style22">
                                         <asp:Label ID="Label69" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: small" Text="Contact Address"></asp:Label>
                                     </td>
                                     <td>
                                         <asp:Label ID="LbEmpAccpContAddr" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                                     </td>
                                     <td>&nbsp;</td>
                                 </tr>
                                 <tr>
                                     <td class="auto-style142">&nbsp;</td>
                                     <td class="auto-style137">
                                         &nbsp;</td>
                                     <td class="auto-style154">
                                         &nbsp;</td>
                                     <td class="auto-style22">&nbsp;</td>
                                     <td>&nbsp;</td>
                                     <td>&nbsp;</td>
                                 </tr>
            
                                 <tr>
                                     <td class="auto-style142">&nbsp;</td>
                                     <td class="auto-style137">
                                         <asp:Label ID="Label89" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: small" Text="Religion"></asp:Label>
                                     </td>
                                     <td class="auto-style154">
                                         <asp:Label ID="LbEmpAccptReligion" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                                     </td>
                                     <td class="auto-style22">&nbsp;</td>
                                     <td>&nbsp;</td>
                                     <td>&nbsp;</td>
                                 </tr>
            
            <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">
                    &nbsp;</td>
                <td class="auto-style154">
                    &nbsp;</td>
                <td class="auto-style22">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">
                    <asp:Label ID="Label87" runat="server" Font-Bold="True" Font-Size="14pt" Text="Department" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style154">
                    <asp:Label ID="LbEmpAccptDept" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="Label141" runat="server" style="font-weight: 700" Text="Approved Position"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbEmpAccpContAddr0" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">
                    &nbsp;</td>
                <td class="auto-style154">
                    &nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
           
            <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">
                    <asp:Label ID="Label91" runat="server" Font-Bold="True" Font-Size="14pt" Text="Level" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style154">
                    <asp:Label ID="LbEmpAccptLevel" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="Label99" runat="server" Font-Bold="True" Font-Size="14pt" Text="Salary" style="font-size: medium"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbAcceptanceSalary2" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>

             <tr>
                 <td class="auto-style142">&nbsp;</td>
                 <td class="auto-style137">
                     &nbsp;</td>
                 <td class="auto-style154">
                     &nbsp;</td>
                 <td class="auto-style22">
                     &nbsp;</td>
                 <td>
                     &nbsp;</td>
                 <td>&nbsp;</td>
            </tr>

            <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">
                    <asp:Label ID="Label83" runat="server" Font-Bold="True" Font-Size="14pt" Text="Start Date" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style154">
                    <asp:Label ID="LbEmpAccptStartDate" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="Label85" runat="server" Font-Bold="True" Font-Size="14pt" Text="Work Location" style="font-size: medium"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbEmpAccptWorkLoc" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
                                 <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">&nbsp;</td>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

                                 <tr>
                                     <td class="auto-style142">&nbsp;</td>
                                     <td class="auto-style137">&nbsp;</td>
                                     <td class="auto-style154">&nbsp;</td>
                                     <td class="auto-style22">&nbsp;</td>
                                     <td>&nbsp;</td>
                                     <td>&nbsp;</td>
                                 </tr>

                                   <tr>
                <td class="auto-style11" colspan="6">
                    <asp:Label ID="Label37" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Qualification Details" style="font-style: italic; font-size: medium"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style29" colspan="6">
                    <asp:GridView ID="GViewQualification" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="InstitutionName" HeaderText="InstitutionName" SortExpression="InstitutionName" />
                            <asp:BoundField DataField="QualificationType" HeaderText="QualificationType" SortExpression="QualificationType" />
                            <asp:BoundField DataField="Course" HeaderText="Course" SortExpression="Course" />
                            <asp:BoundField DataField="Grade" HeaderText="Grade" SortExpression="Grade" />
                            <asp:BoundField DataField="StartYear" HeaderText="StartYear" SortExpression="StartYear" />
                            <asp:BoundField DataField="EndYear" HeaderText="EndYear" SortExpression="EndYear" />

                            <asp:TemplateField>
                                <ItemTemplate>
                                   <asp:TextBox ID="txtQualifViewAppID" runat="server"  Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.ApplicantID_FK") %>'></asp:TextBox>
                                    
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
                <td class="auto-style29">&nbsp;</td>
                <td class="auto-style54">
                    &nbsp;</td>
                <td class="auto-style154">&nbsp;</td>
                <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td class="auto-style15">&nbsp;</td>
              
            </tr>
                                 </tr>
             <tr>
                 <td colspan="6">
                     <asp:Label ID="LbCertifcation" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Professional Certification"></asp:Label>
                 </td>
             </tr>
                                 <tr>
                                     <td colspan="6">&nbsp;</td>
                                 </tr>
                                 <tr>
                                     <td colspan="6">
                                         <asp:GridView ID="GViewCert" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False">
                                             <AlternatingRowStyle BackColor="White" />
                                             <Columns>
                                                 <asp:BoundField DataField="CertificationName" HeaderText="CertificationName" SortExpression="CertificationName" />
                                                 <asp:BoundField DataField="CertificateNo" HeaderText="CertificateNo" SortExpression="CertificateNo" />
                                                 <asp:BoundField DataField="Stage" HeaderText="Stage" SortExpression="Stage" />
                                                 <asp:BoundField DataField="CertYear" HeaderText="Year" SortExpression="Year" />
                                                 <asp:TemplateField>
                                                     <ItemTemplate>
                                                         <asp:TextBox ID="txtCertAppID" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.ApplicantID_FK")%>' Visible="false"></asp:TextBox>
                                                     </ItemTemplate>
                                                 </asp:TemplateField>
                                                 <%-- <asp:TemplateField ShowHeader="False">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButtonQualifSave" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" CommandArgument='<%# DataBinder.Eval(Container,"DataItem.ProfQualificationID") %>'></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>--%>
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
                                     <td class="auto-style15">&nbsp;</td>
                                     <td class="auto-style87"></td>
                                     <td class="auto-style188"></td>
                                     <td class="auto-style15"></td>
                                     <td class="auto-style88">&nbsp;</td>
                                     <td class="auto-style15">&nbsp;</td>
                                 </tr>
                                 <tr>
                                     <td colspan="6">
                                         <asp:Label ID="LbOtherDocm1" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" style="font-size: medium; font-style: italic" Text="Other Document"></asp:Label>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td colspan="6">&nbsp;</td>
                                 </tr>
                                 <tr>
                                     <td colspan="6">
                                         <asp:GridView ID="GViewDoc" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False">
                                             <AlternatingRowStyle BackColor="White" />
                                             <Columns>
                                                 <asp:BoundField DataField="DocumentType" HeaderText="Type" SortExpression="Type" />
                                                 <asp:BoundField DataField="DocumentPath" HeaderText="Path" SortExpression="Path" />
                                                 <asp:TemplateField>
                                                     <ItemTemplate>
                                                         <asp:TextBox ID="txtdocAppID" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ApplicantID_FK")%>' Visible="false"></asp:TextBox>
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
                                     <td colspan="6">&nbsp;</td>
                                 </tr>
                                 <tr>
                                     <td class="auto-style142">&nbsp;</td>
                                     <td class="auto-style137">&nbsp;</td>
                                     <td class="auto-style154">
                                         <asp:Button ID="AcceptEmploymentBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" OnClick="AcceptEmploymentBtn_Click" Text="Accept" Width="122px" />
                                     </td>
                                     <td class="auto-style22">&nbsp;</td>
                                     <td>
                                         <asp:Button ID="sendEmploymentLetterBtn1" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Finish" Width="122px" />
                                     </td>
                                     <td>&nbsp;</td>
                                 </tr>
                                 <tr>
                                     <td class="auto-style142">&nbsp;</td>
                                     <td class="auto-style137">&nbsp;</td>
                                     <td class="auto-style154">&nbsp;</td>
                                     <td class="auto-style22">&nbsp;</td>
                                     <td>&nbsp;</td>
                                     <td>&nbsp;</td>
                                 </tr>
                                 <tr>
                                     <td class="auto-style142" colspan="6">
                                         <asp:Label ID="LbEmpDetailsAdded" runat="server" style="color: #669900; font-weight: 700; font-size: small"></asp:Label>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td class="auto-style142">&nbsp;</td>
                                     <td class="auto-style137">&nbsp;</td>
                                     <td class="auto-style154">&nbsp;</td>
                                     <td class="auto-style22">&nbsp;</td>
                                     <td>&nbsp;</td>
                                     <td>&nbsp;</td>
                                 </tr>
                                 <tr>
                                     <td class="auto-style22" colspan="6">
                                         <asp:Label ID="LbEmpIDgeneratedhere" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Visible="False"></asp:Label>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>&nbsp;</td>
                                     <td>&nbsp;</td>
                                     <td class="auto-style154">&nbsp;</td>
                                     <td>&nbsp;</td>
                                     <td>&nbsp;</td>
                                     <td>&nbsp;</td>
                                 </tr>
                                 <tr>
                                     <td>&nbsp;</td>
                                     <td>&nbsp;</td>
                                     <td class="auto-style154">&nbsp;</td>
                                     <td>&nbsp;</td>
                                     <td>&nbsp;</td>
                                     <td>&nbsp;</td>
                                 </tr>
                                 </tr>
                             </table>
                         </asp:Panel>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style186">&nbsp;</td>
                     <td class="auto-style178">&nbsp;</td>
                     <td class="auto-style132">&nbsp;</td>
                     <td class="auto-style22">&nbsp;</td>
                     <td class="auto-style19">&nbsp;</td>
                     <td class="auto-style20">&nbsp;</td>
                 </tr>
        
        </table>
    </asp:View>
    
    <asp:View ID="ViewHrEmpProfile" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
                        <tr>
                <td colspan="6">
                    <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#CC99FF" OnClick="BioDataLinkBtn_Click" EnableViewState="False">Biodata</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="LinkButton2" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="qualifLinkBtn_Click">Qualification</asp:LinkButton>
                    &nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton3" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="certLinkBtn_Click">Certifications</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="LinkButton4" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="docLinkBtn_Click">Document</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="LinkButton5" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="refreeLinkBtn_Click">Refree</asp:LinkButton>
                </td>
            </tr>
             <tr>
                 <td class="auto-style167">&nbsp;</td>
                 <td class="auto-style146">&nbsp;</td>
                 <td class="auto-style19">&nbsp;</td>
                 <td class="auto-style145">&nbsp;</td>
                 <td class="auto-style19">&nbsp;</td>
                 <td class="auto-style20">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="6">
                    <asp:Label ID="Label15" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Employee Personal Information"></asp:Label>
                </td>
            </tr>
             <tr>
                 <td class="auto-style167">&nbsp;</td>
                 <td class="auto-style60">&nbsp;</td>
                 <td class="auto-style61">&nbsp;</td>
                 <td class="auto-style22">&nbsp;</td>
                 <td class="auto-style19">&nbsp;</td>
                 <td class="auto-style20">&nbsp;</td>
            </tr>
                        <tr>
                            <td class="auto-style167">&nbsp;</td>
                            <td class="auto-style60">
                                <asp:DropDownList ID="hrEmpProfileIDList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="hrEmpProfileIDList_SelectedIndexChanged" Width="250px">
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style61">&nbsp;</td>
                            <td class="auto-style22">&nbsp;</td>
                            <td class="auto-style19">&nbsp;</td>
                            <td class="auto-style20">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style167">&nbsp;</td>
                            <td class="auto-style60">&nbsp;</td>
                            <td class="auto-style61">&nbsp;</td>
                            <td class="auto-style22">&nbsp;</td>
                            <td class="auto-style19">&nbsp;</td>
                            <td class="auto-style20">&nbsp;</td>
                        </tr>
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:Panel ID="PanelEmployeeProfile" runat="server" Visible="False">
                        <table style="width:100%; margin-left:50px;">
                            
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:Image ID="EmpProfilePassport" runat="server" Height="170px" ImageAlign="Left" Width="170px" BorderColor="#CC0066" BorderStyle="Solid" BorderWidth="2px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    &nbsp;</td>
                <td class="auto-style61">
                    &nbsp;</td>
                <td class="auto-style22">
                    <asp:Label ID="LBMidName1" runat="server" Font-Bold="True" Font-Size="14pt" Text="Position"></asp:Label>
                </td>
                <td class="auto-style19">
                    <asp:Label ID="LbHrEmpPosition" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td class="auto-style20">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="LBTitle" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Title"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpTitle" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="LBfName" runat="server" Font-Bold="True" Text="First Name" Font-Size="14pt" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpFName" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
    <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style168">
            <asp:Label ID="Label40" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Middle Name"></asp:Label>
        </td>
        <td class="auto-style61">
            <asp:Label ID="LbHrEmpMidName" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
        </td>
        <td class="auto-style22">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="Label64" runat="server" Font-Bold="True" Font-Size="14pt" Text="Last Name" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpLName" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="Label78" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Gender"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpGender" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

     <tr>
        <td class="auto-style56">
            &nbsp;</td>
        <td class="auto-style168">
            <asp:Label ID="LbStatus" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Marital Status"></asp:Label>
         </td>
        <td class="auto-style61">
            <asp:Label ID="LbHrEmpMaritalStatus" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
         </td>
        <td class="auto-style22">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>

                            <tr>
                                <td class="auto-style56">&nbsp;</td>
                                <td class="auto-style168">
                                    <asp:Label ID="LbLGA0" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="DOB"></asp:Label>
                                </td>
                                <td class="auto-style61">&nbsp;</td>
                                <td class="auto-style22">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style56">&nbsp;</td>
                                <td class="auto-style168">
                                    <asp:Label ID="Label70" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Email"></asp:Label>
                                </td>
                                <td class="auto-style61">
                                    <asp:Label ID="LbHrEmpEmail" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                                </td>
                                <td class="auto-style22">
                                    <asp:Label ID="Label74" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="PhoneNum"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LbHrEmpPhnNum" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>

     <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style168">&nbsp;</td>
        <td class="auto-style61">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    &nbsp;</td>
                <td class="auto-style61">
                    &nbsp;</td>
                <td class="auto-style22">
                    <asp:Label ID="Label80" runat="server" Font-Bold="True" Font-Size="14pt" Text="Contact Address" style="font-size: medium"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpContAddr" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            

     <tr>
        <td class="auto-style56">
            &nbsp;</td>
        <td class="auto-style168">
            <asp:Label ID="Label84" runat="server" Font-Bold="True" Font-Size="14pt" Text="Nationality" style="font-size: medium"></asp:Label>
         </td>
        <td class="auto-style61">
            <asp:Label ID="LbHrEmpCountry" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
         </td>
        <td class="auto-style22">
            <asp:Label ID="LbStateOfOri" runat="server" Font-Bold="True" Font-Size="14pt" Text="State of Origin" style="font-size: medium"></asp:Label>
         </td>
        <td>
            <asp:Label ID="LbHrEmpState" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
         </td>
        <td>&nbsp;</td>
    </tr>

            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

    <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style168">
            <asp:Label ID="LbLGA" runat="server" Font-Bold="True" Font-Size="14pt" Text="LGA" style="font-size: medium"></asp:Label>
        </td>
        <td class="auto-style61">
            <asp:Label ID="LbHrEmpLGA" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
        </td>
        <td class="auto-style22">
            <asp:Label ID="Label92" runat="server" Font-Bold="True" Font-Size="14pt" Text="Home Town" style="font-size: medium"></asp:Label>
        </td>
        <td>
            <asp:Label ID="LbHrEmpHomeTown" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>

    <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style168">&nbsp;</td>
        <td class="auto-style61">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

             <tr>
                 <td class="auto-style56">&nbsp;</td>
                 <td class="auto-style168">
                     &nbsp;</td>
                 <td class="auto-style61">
                     <asp:Label ID="LbHrEmpDOB" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                 </td>
                 <td class="auto-style22">
                     <asp:Label ID="Label95" runat="server" Font-Bold="True" Font-Size="14pt" Text="Age" style="font-size: medium"></asp:Label>
                 </td>
                 <td>
                     <asp:Label ID="LbHrEmpAge" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                 </td>
                 <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="LbStartDate" runat="server" Font-Bold="True" Font-Size="14pt" Text="Start Date" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpStartDate" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="Label102" runat="server" Font-Bold="True" Font-Size="14pt" Text="Work Location" style="font-size: medium"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpWorkLoc" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    &nbsp;</td>
                <td class="auto-style61">
                    &nbsp;</td>
                <td class="auto-style22">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="Label104" runat="server" Font-Bold="True" Font-Size="14pt" Text="Department" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpDept" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="Label106" runat="server" Font-Bold="True" Font-Size="14pt" Text="Religion" style="font-size: medium"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpReligion" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    &nbsp;</td>
                <td class="auto-style61">
                    &nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
           
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="Label107" runat="server" Font-Bold="True" Font-Size="14pt" Text="Level" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpLevel" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                                  <td class="auto-style56" colspan="6">
                                      <asp:Label ID="LbSpouseInfo1" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Employee Status Infomation"></asp:Label>
                                  </td>
                              </tr>
                              <tr>
                                  <td class="auto-style56">&nbsp;</td>
                                  <td class="auto-style168">&nbsp;</td>
                                  <td class="auto-style61">&nbsp;</td>
                                  <td class="auto-style22">&nbsp;</td>
                                  <td>&nbsp;</td>
                                  <td>&nbsp;</td>
                              </tr>
                              <tr>
                                  <td class="auto-style56">&nbsp;</td>
                                  <td class="auto-style168">
                                      <asp:Label ID="LbEmpStatus" runat="server" Font-Bold="True" Font-Size="14pt" Text="Employee Status"></asp:Label>
                                  </td>
                                  <td class="auto-style61">
                                      <asp:Label ID="LbHrEmpStatus" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                                  </td>
                                  <td class="auto-style22">
                                      <asp:Label ID="LbCnfrmDate0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Confirmation Date"></asp:Label>
                                  </td>
                                  <td>
                                      <asp:Label ID="LbHrEmpConfimedDate" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                                  </td>
                                  <td>&nbsp;</td>
                              </tr>
                              <tr>
                                  <td class="auto-style56">&nbsp;</td>
                                  <td class="auto-style168">&nbsp;</td>
                                  <td class="auto-style61">&nbsp;</td>
                                  <td class="auto-style22">&nbsp;</td>
                                  <td>&nbsp;</td>
                                  <td>&nbsp;</td>
                              </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="LbConfirmBy0" runat="server" Font-Bold="True" Font-Size="14pt" Text="ConfirmedBy"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpConfirmedBy" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>

             <tr>
                 <td class="auto-style56">&nbsp;</td>
                 <td class="auto-style168">
                     &nbsp;</td>
                 <td class="auto-style61">
                     &nbsp;</td>
                 <td class="auto-style22">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
            </tr>
                              <tr>
                                  <td class="auto-style56" colspan="6">
                                      <asp:Label ID="LbSpouseInfo2" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Spouse Infomation (If Married)"></asp:Label>
                                  </td>
                              </tr>
                              <tr>
                                  <td class="auto-style56">&nbsp;</td>
                                  <td class="auto-style168">&nbsp;</td>
                                  <td class="auto-style61">&nbsp;</td>
                                  <td class="auto-style22">&nbsp;</td>
                                  <td>&nbsp;</td>
                                  <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="LbspouseFNam0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Spouse Names"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbSpouseNames" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbspouseFNam1" runat="server" Font-Bold="True" Font-Size="14pt" Text="Spouse Phone No"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpSpousePhoNo" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="LbspouseFNam2" runat="server" Font-Bold="True" Font-Size="14pt" Text="Spouse Address"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpSpouseAddress" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbspouseFNam3" runat="server" Font-Bold="True" Font-Size="14pt" Text="Spouse Email"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpSpouseEmailAddr" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="LbspouseFNam4" runat="server" Font-Bold="True" Font-Size="14pt" Text="Spouse Occupation"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpSpouseOccupation" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbspouseFNam5" runat="server" Font-Bold="True" Font-Size="14pt" Text="Spouse Employer"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpSpouseEmployer" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:Label ID="LbNxtOfKinInfo0" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Next of Kin Information"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="LbnxtOfKinFName0" runat="server" Font-Bold="True" Font-Size="14pt" Text="NOK Names"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpNextOfKinNames" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbnxtOfKinFName1" runat="server" Font-Bold="True" Font-Size="14pt" Text="Relationship"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpNextOfKinRelationship" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="LbnxtOfKinFName2" runat="server" Font-Bold="True" Font-Size="14pt" Text="Phone Num"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpNextOfKinPhnNum" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbnxtOfKinFName3" runat="server" Font-Bold="True" Font-Size="14pt" Text="Email"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpNextOfKinEmail" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="LbnxtOfKinFName4" runat="server" Font-Bold="True" Font-Size="14pt" Text="Address"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpNextOfKinAddrs" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbnxtOfKinFName5" runat="server" Font-Bold="True" Font-Size="14pt" Text="Occupation"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpNextOfKinOccupation" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:Label ID="LbBankInfo0" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Bank Information &amp; Gurrantor Info"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="LbBank" runat="server" Font-Bold="True" Font-Size="14pt" Text="Bank Name"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpBankNames" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbHrEmpAcctNames" runat="server" Font-Bold="True" Font-Size="14pt" Text="Account Name"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpAccountName" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="LbAcctNames0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Account Number"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpAcctNumber" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbAcctNames1" runat="server" Font-Bold="True" Font-Size="14pt" Text="Guarrantor's Name"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpGuarrantorName" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:Label ID="Label113" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Refree Information"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="Label114" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Names"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpReferee1Names" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="Label116" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Names"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpReferee2Names" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="Label118" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Phone No"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpReferee1PhnNum" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="Label120" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Phone No"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpReferee2PhnNum" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="Label122" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Email"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpReferee1Email" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="Label124" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Email"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpReferee2Email" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="Label126" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Occupation"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpReferee1Occupation" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="Label128" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Occupation"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpReferee2Occupation" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
                              <tr>
                                  <td class="auto-style56">&nbsp;</td>
                                  <td class="auto-style168">&nbsp;</td>
                                  <td class="auto-style61">&nbsp;</td>
                                  <td class="auto-style22">&nbsp;</td>
                                  <td>&nbsp;</td>
                                  <td>&nbsp;</td>
                              </tr>
                              <tr>
                                  <td class="auto-style72"></td>
                                  <td class="auto-style168">
                                      <asp:Label ID="Label130" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Address"></asp:Label>
                                  </td>
                                  <td class="auto-style74">
                                      <asp:Label ID="LbHrEmpReferee1Addr" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                                  </td>
                                  <td class="auto-style75">
                                      <asp:Label ID="Label131" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Address"></asp:Label>
                                  </td>
                                  <td class="auto-style72">
                                      <asp:Label ID="LbHrEmpReferee2Addr" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                                  </td>
                                  <td class="auto-style72"></td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:Label ID="LbQualifInfo0" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Qualification Details"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:GridView ID="GViewHrEmpProfileQualification" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" Visible="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="InstitutionName" HeaderText="InstitutionName" SortExpression="InstitutionName" />
                            <asp:BoundField DataField="QualificationType" HeaderText="QualificationType" SortExpression="QualificationType" />
                            <asp:BoundField DataField="Course" HeaderText="Course" SortExpression="Course" />
                            <asp:BoundField DataField="Grade" HeaderText="Grade" SortExpression="Grade" />
                            <asp:BoundField DataField="StartYear" HeaderText="StartYear" SortExpression="StartYear" />
                            <asp:BoundField DataField="EndYear" HeaderText="EndYear" SortExpression="EndYear" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:TextBox ID="txtProfileQualiAppID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.ApplicantID_FK")%>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:TextBox ID="txtProfileQualiEmpID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.EmployeeID_FK")%>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:Label ID="LbQualifInfo1" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Professional Certifications Details"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:GridView ID="GViewHrEmpProfileCert" runat="server" AutoGenerateColumns="False"  EnableModelValidation="True" Visible="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="CertificationName" HeaderText="CertificationName" SortExpression="CertificationName" />
                            <asp:BoundField DataField="CertificateNo" HeaderText="CertificateNo" SortExpression="CertificateNo" />
                            <asp:BoundField DataField="Stage" HeaderText="Stage" SortExpression="Stage" />
                            <asp:BoundField DataField="CertYear" HeaderText="Year" SortExpression="Year" />
                             <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:TextBox ID="txtProfileProfQualiAppID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.ApplicantID_FK")%>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:TextBox ID="txtProfileProfQualiEmpID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.employeeID_FK")%>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:Label ID="LbQualifInfo2" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Other Document Details"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    &nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:GridView ID="GViewHrEmpProfileDoc" runat="server" AutoGenerateColumns="False"  EnableModelValidation="True" Visible="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="DocumentType" HeaderText="Type" SortExpression="Type" />
                            <asp:BoundField DataField="DocumentPath" HeaderText="Path" SortExpression="Path" />                            
                             <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:TextBox ID="txtProfileDocAppID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.ApplicantID_FK")%>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:TextBox ID="txtProfileDocEmpID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.EmployeeID_Fk")%>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    &nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">
                    <asp:Button ID="empFinishBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" Text="Finish" />
                </td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

             <tr>
                                <td>&nbsp;</td>
                                <td class="auto-style168">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
                              <tr>
                                  <td class="auto-style167">&nbsp;</td>
                                  <td class="auto-style60">&nbsp;</td>
                                  <td class="auto-style61">
                                      &nbsp;</td>
                                  <td class="auto-style22">&nbsp;</td>
                                  <td>&nbsp;</td>
                                  <td>&nbsp;</td>
                              </tr>
                          </tr>
                      </tr>
    </tr>
                      
        </table>
 </asp:View>
         
    <asp:View ID="ViewQualification" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">

             
            <tr>
                <td colspan="4">
                    &nbsp;</td>
            </tr>
            <tr>
                                 <td class="auto-style176" colspan="4">
                                     <asp:Button ID="hrApproveQualifMenuBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" OnClick="hrApproveQualifMenuBtn_Click" Text="Qualification" Width="150px" Height="45px" />
                                     &nbsp;<asp:Button ID="hrApproveCertMenuBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" OnClick="hrApproveCertMenuBtn_Click" Text="Certification" Width="150px" Height="45px" />
                                     &nbsp;
                                     <asp:Button ID="hrApproveDocMenuBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" OnClick="hrApproveDocMenuBtn_Click" Text="Document" Width="150px" Height="45px" />
                                 </td>
                            </tr>
                            <tr>
                                <td class="auto-style176">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
            <tr>
                <td class="auto-style176" colspan="4"><center><u>
                    <asp:Label ID="Label35" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Approval Page"></asp:Label>
                    </u></center></td>
            </tr>
            <tr>
                <td class="auto-style177" colspan="4">&nbsp;</tr>
            <tr>
                <td colspan="4">
                                      <ul>
                        <li>Click on Qualification Menu button to approve employee new added qualification </li><br />
                       
                         <li>Click on Certification Menu button to approve employee new added certification </li><br />

                         <li>Click on Document Menu button to approve employee new uploaded document </li>
                    </ul>

                </td>
            </tr>

            <tr>
                <td colspan="4">
                    <asp:Panel ID="PanelApproveQualif" runat="server" Visible="False">
                        <table style="width: 100%;">
                            <tr>
                                <td colspan="4">
                                    <asp:Label ID="LbQualifInfo" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Qualification Details"></asp:Label>
                                </td>
                            </tr>
                             
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                             <tr>
                                 <td colspan="4">
                                     <ul>
                                         <li>Select the Employee</li>
                                         <li>Check the Certification you want to approve</li>
                                         <li>Click &#39;Approve&#39; button to approve the certification</li>
                                         <li>Click on &#39;Finish&#39; button to go back to main menue</li>
                                     </ul>
                                 </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                             <tr>
                <td class="auto-style173">&nbsp;</td>
                <td class="auto-style54">
                    <asp:Label ID="LbSchName0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Employee Name"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:DropDownList ID="hrUnApprovedQualifList" runat="server" AutoPostBack="True" DataTextField="EmployeeID" DataValueField="LastName" OnSelectedIndexChanged="HRQualifEmployeeList_SelectedIndexChanged" Width="250px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style173">&nbsp;</td>
                <td class="auto-style54">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style11" colspan="4">
                    
                    <asp:GridView ID="GViewHrEmpApproveQualif" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="InstitutionName" HeaderText="InstitutionName" SortExpression="InstitutionName" />
                            <asp:BoundField DataField="QualificationType" HeaderText="QualificationType" SortExpression="QualificationType" />
                            <asp:BoundField DataField="Course" HeaderText="Course" SortExpression="Course" />
                            <asp:BoundField DataField="Grade" HeaderText="Grade" SortExpression="Grade" />
                            <asp:BoundField DataField="StartYear" HeaderText="StartYear" SortExpression="StartYear" />
                            <asp:BoundField DataField="EndYear" HeaderText="EndYear" SortExpression="EndYear" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:TextBox ID="txtAppID" runat="server" visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.ApplicantID_FK")%>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:TextBox ID="txtEmpID" runat="server" visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.EmployeeID_FK")%>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:BoundField DataField="HrApproval" HeaderText="HrApproval" SortExpression="HrApproval" />
                            <asp:TemplateField HeaderText="Approve">
                                <EditItemTemplate>
                                    <asp:CheckBox ID="CheckBoxQualf" runat="server" />
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="CheckBoxQualif" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style173">&nbsp;</td>
                <td class="auto-style54">&nbsp;</td>
                <td class="auto-style7">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style173">&nbsp;</td>
                <td class="auto-style54">
                    <asp:Label ID="LbHrQaulifHrApproval" runat="server" Font-Italic="True" ForeColor="#669900" Text="Label" Visible="False"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="LbHrQaulifApproved" runat="server" Font-Italic="True" ForeColor="#669900" Text="Label" Visible="False"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style173">&nbsp;</td>
                <td class="auto-style54">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Button ID="QualifApproveBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="QualifApproveBtn_Click" Text="Approve" Visible="False" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="QualifFinishBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="QualifFinishBtn_Click" Text="Finish" Visible="False" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style173">&nbsp;</td>
                <td class="auto-style54">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style173" colspan="4">
                    <asp:LinkButton ID="BioDataLinkBtn6" runat="server" EnableViewState="False" Font-Bold="True" Font-Size="10pt" ForeColor="#0066FF" OnClick="BioDataLinkBtn_Click">Biodata</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="qualifLinkBtn6" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="qualifLinkBtn_Click">Qualification</asp:LinkButton>
                    &nbsp;&nbsp;
                    <asp:LinkButton ID="certLinkBtn6" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="certLinkBtn_Click">Certifications</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="docLinkBtn6" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="docLinkBtn_Click">Document</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="refreeLinkBtn6" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="refreeLinkBtn_Click">Refree</asp:LinkButton>
                </td>
            </tr>
                        </table>

                    </asp:Panel>

                    &nbsp;</td>
            </tr>
           
            <tr>
                <td></td>
                 <td></td>
                 <td></td>
                 <td></td>

            </tr>

        </table>
    </asp:View>

    <asp:View ID="ViewCertification" runat="server">
         <table style="width: 100%; border: medium solid #CC0066; width:100%;">
            <tr>
                <td class="auto-style20" colspan="5">
                    <asp:Button ID="hrApproveQualifMenuBtn0" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Height="45px" OnClick="hrApproveQualifMenuBtn_Click" Text="Qualification" Width="150px" />
                    &nbsp;<asp:Button ID="hrApproveCertMenuBtn0" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Height="45px" OnClick="hrApproveCertMenuBtn_Click" Text="Certification" Width="150px" />
                    &nbsp;
                    <asp:Button ID="hrApproveDocMenuBtn0" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Height="45px" OnClick="hrApproveDocMenuBtn_Click" Text="Document" Width="150px" />
                </td>

            </tr>
             <tr>
                 <td class="auto-style59">&nbsp;</td>
                 <td class="auto-style43">&nbsp;</td>
                 <td class="auto-style18">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td colspan="4">
                     <ul>
                         <li>Select the Employee</li>
                         <li>Check the Certification you want to approve</li>
                         <li>Click &#39;Approve&#39; button to approve the certification</li>
                         <li>Click on &#39;Finish&#39; button to go back to main menue</li>
                     </ul>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style20" colspan="5">
                     &nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style59">&nbsp;</td>
                 <td class="auto-style43">
                     &nbsp;</td>
                 <td class="auto-style18">
                     &nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
           
             <tr>
                 <td class="auto-style59" colspan="5">
                     <asp:Panel ID="PanelHrApproveCert" runat="server" Visible="False">
                         <table style="width: 100%;">
                             <tr>
                                 <td colspan="4">
                                     <asp:Label ID="Label23" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Professional Qualification"></asp:Label>
                                 </td>
                             </tr>
                             <tr>
                                 <td>&nbsp;</td>
                                 <td>&nbsp;</td>
                                 <td>&nbsp;</td>
                                 <td>&nbsp;</td>
                             </tr>
                             <tr>
                                 <td class="auto-style173">&nbsp;</td>
                                 <td class="auto-style54">
                                     <asp:Label ID="Label31" runat="server" Font-Bold="True" Font-Size="14pt" Text="Employee Name"></asp:Label>
                                 </td>
                                 <td class="auto-style7">
                                     <asp:DropDownList ID="hrUnApprovedCertList" runat="server" AutoPostBack="True" DataTextField="EmployeeID" DataValueField="LastName" OnSelectedIndexChanged="hrUnApprovedCertList_SelectedIndexChanged" Width="250px">
                                     </asp:DropDownList>
                                 </td>
                                 <td>&nbsp;</td>
                             </tr>
                             <tr>
                                 <td class="auto-style173">&nbsp;</td>
                                 <td class="auto-style54">&nbsp;</td>
                                 <td class="auto-style7">&nbsp;</td>
                                 <td>&nbsp;</td>
                             </tr>
                             <tr>
                                 <td class="auto-style11" colspan="4">
                                     <asp:GridView ID="GViewHrEmpApproveCert" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False">
                                         <AlternatingRowStyle BackColor="White" />
                                         <Columns>
                                             <asp:BoundField DataField="CertificationName" HeaderText="CertificationName" SortExpression="CertificationName" />
                                             <asp:BoundField DataField="CertificateNo" HeaderText="CertificateNo" SortExpression="CertificateNo" />
                                             <asp:BoundField DataField="Stage" HeaderText="Stage" SortExpression="Stage" />
                                             <asp:BoundField DataField="CertYear" HeaderText="Year" SortExpression="Year" />
                                             <asp:TemplateField>
                                                 <ItemTemplate>
                                                     <asp:TextBox ID="txtCertAppID" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.ApplicantID_FK")%>' visible="false"></asp:TextBox>
                                                 </ItemTemplate>
                                             </asp:TemplateField>
                                             <asp:TemplateField>
                                                 <ItemTemplate>
                                                     <asp:TextBox ID="txtCertEmpID" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.employeeID_FK")%>' visible="false"></asp:TextBox>
                                                 </ItemTemplate>
                                             </asp:TemplateField>
                                             <asp:BoundField DataField="HrApproval" HeaderText="HrApproval" SortExpression="HrApproval" />
                                             <asp:TemplateField HeaderText="Approve">
                                                 <EditItemTemplate>
                                                     <asp:CheckBox ID="CheckBoxCert" runat="server" />
                                                 </EditItemTemplate>
                                                 <ItemTemplate>
                                                     <asp:CheckBox ID="CheckBoxCert" runat="server" />
                                                 </ItemTemplate>
                                             </asp:TemplateField>
                                         </Columns>
                                         <EditRowStyle BackColor="#2461BF" />
                                         <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                         <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                         <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                         <RowStyle BackColor="#EFF3FB" />
                                         <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                     </asp:GridView>
                                 </td>
                             </tr>
                             <tr>
                                 <td class="auto-style173">&nbsp;</td>
                                 <td class="auto-style54">&nbsp;</td>
                                 <td class="auto-style7">&nbsp;</td>
                                 <td>&nbsp;</td>
                             </tr>
                             <tr>
                                 <td class="auto-style173">&nbsp;</td>
                                 <td class="auto-style54">&nbsp;</td>
                                 <td ><asp:Label ID="LbCertApproved" runat="server" Font-Italic="True" ForeColor="#669900" Text="Label" Visible="False"></asp:Label>
              </td>
                                 <td>&nbsp;</td>
                             </tr>
                             <tr>
                                 <td class="auto-style173">&nbsp;</td>
                                 <td class="auto-style54">&nbsp;</td>
                                 <td class="auto-style7">
                                     <asp:Button ID="hrCertApproveBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Approve" Visible="False" OnClick="hrCertApproveBtn_Click" />
                                 </td>
                                 <td>
                                     <asp:Button ID="hrCertFinishBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="QualifFinishBtn_Click" Text="Finish" Visible="False" />
                                 </td>
                             </tr>
                             <tr>
                                 <td class="auto-style173">&nbsp;</td>
                                 <td class="auto-style54">&nbsp;</td>
                                 <td class="auto-style7">&nbsp;</td>
                                 <td>&nbsp;</td>
                             </tr>
                             <tr>
                                 <td class="auto-style173">&nbsp;</td>
                                 <td class="auto-style54">&nbsp;</td>
                                 <td class="auto-style7">&nbsp;</td>
                                 <td>&nbsp;</td>
                             </tr>
                             <tr>
                                 <td>&nbsp;</td>
                                 <td>&nbsp;</td>
                                 <td>&nbsp;</td>
                             </tr>
                             <tr>
                                 <td colspan="3">
                                     <asp:LinkButton ID="LinkButton6" runat="server" EnableViewState="False" Font-Bold="True" Font-Size="10pt" ForeColor="#0066FF" OnClick="BioDataLinkBtn_Click">Biodata</asp:LinkButton>
                                     &nbsp;
                                     <asp:LinkButton ID="LinkButton7" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="qualifLinkBtn_Click">Qualification</asp:LinkButton>
                                     &nbsp;&nbsp;
                                     <asp:LinkButton ID="LinkButton8" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="certLinkBtn_Click">Certifications</asp:LinkButton>
                                     &nbsp;
                                     <asp:LinkButton ID="LinkButton9" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="docLinkBtn_Click">Document</asp:LinkButton>
                                     &nbsp;
                                     <asp:LinkButton ID="LinkButton10" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="refreeLinkBtn_Click">Refree</asp:LinkButton>
                                 </td>
                             </tr>
                         </table>
                     </asp:Panel>
                 </td>
             </tr>
        </table>
    </asp:View>

    <asp:View ID="ViewOtherDocuments" runat="server">
         <table style="width: 100%; border: medium solid #CC0066; width:100%;">
           <tr>
                <td>
                  <asp:Button ID="Button2" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" OnClick="hrApproveQualifMenuBtn_Click" Text="Qualification" Width="150px" Height="45px" />
                                     &nbsp;<asp:Button ID="Button3" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" OnClick="hrApproveCertMenuBtn_Click" Text="Certification" Width="150px" Height="45px" />
                                     &nbsp;
                                     <asp:Button ID="Button4" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" OnClick="hrApproveDocMenuBtn_Click" Text="Document" Width="150px" Height="45px" />
                                  </td>
               
            </tr>
             <tr>
                 <td>
                     &nbsp;</td>
             </tr>
         
             <tr>
                 <td>
                     <asp:Label ID="LbOtherDocm0" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Other Document"></asp:Label>
                 </td>
             </tr>
             <tr>
                 <td>&nbsp;</td>
             </tr>
            <tr>
                <td class="auto-style65">
                    <asp:Panel ID="PanelHrApproveDoc" runat="server" Visible="False">
                        <table style="width: 100%;">
                            <tr>
                                <td colspan="4">
                                    <ul>
                                        <li>Select the Employee</li>
                                        <li>Check the document you want to approve</li>
                                        <li>Click 'Approve' button to approve the document</li>
                                        <li>Click on 'Finish' button to go back to main menue</li>
                                    </ul>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style173">&nbsp;</td>
                                <td class="auto-style54">
                                    <asp:Label ID="Label34" runat="server" Font-Bold="True" Font-Size="14pt" Text="Employee Name"></asp:Label>
                                </td>
                                <td class="auto-style7">
                                    <asp:DropDownList ID="hrUnApprovedDocList" runat="server" AutoPostBack="True" DataTextField="EmployeeID" DataValueField="LastName" OnSelectedIndexChanged="hrUnApprovedDocList_SelectedIndexChanged" Width="250px">
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style173">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style7">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style11" colspan="4">
                                    <asp:GridView ID="GViewHrEmpApproveDoc" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="DocumentType" HeaderText="Type" SortExpression="Type" />
                                            <asp:BoundField DataField="DocumentPath" HeaderText="Path" SortExpression="Path" />
                                            <asp:TemplateField>
                                                <ItemTemplate>
                                                    <asp:TextBox ID="txtDocAppID" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.ApplicantID_FK")%>' visible="false"></asp:TextBox>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField>
                                                <ItemTemplate>
                                                    <asp:TextBox ID="txtDocEmpID" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.EmployeeID_FK")%>' visible="false"></asp:TextBox>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="HrApproval" HeaderText="HrApproval" SortExpression="HrApproval" />
                                            <asp:TemplateField HeaderText="Approve">
                                                <EditItemTemplate>
                                                    <asp:CheckBox ID="CheckBoxDoc" runat="server" />
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="CheckBoxDoc" runat="server" />
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                        <EditRowStyle BackColor="#2461BF" />
                                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                        <RowStyle BackColor="#EFF3FB" />
                                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style173">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style7">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style173">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td > <asp:Label ID="LbDocApproved" runat="server" Font-Italic="True" ForeColor="#669900" Text="Label" Visible="False"></asp:Label>
              </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style173">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style7">
                                    <asp:Button ID="hrDocApproveBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Approve" Visible="False" OnClick="hrDocApproveBtn_Click" />
                                </td>
                                <td>
                                    <asp:Button ID="hrDocApprovFinshBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="QualifFinishBtn_Click" Text="Finish" Visible="False" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style173">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style7">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style173">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style7">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    <asp:LinkButton ID="LinkButton11" runat="server" EnableViewState="False" Font-Bold="True" Font-Size="10pt" ForeColor="#0066FF" OnClick="BioDataLinkBtn_Click">Biodata</asp:LinkButton>
                                    &nbsp;
                                    <asp:LinkButton ID="LinkButton12" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="qualifLinkBtn_Click">Qualification</asp:LinkButton>
                                    &nbsp;&nbsp;
                                    <asp:LinkButton ID="LinkButton13" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="certLinkBtn_Click">Certifications</asp:LinkButton>
                                    &nbsp;
                                    <asp:LinkButton ID="LinkButton14" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="docLinkBtn_Click">Document</asp:LinkButton>
                                    &nbsp;
                                    <asp:LinkButton ID="LinkButton15" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="refreeLinkBtn_Click">Refree</asp:LinkButton>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
             <tr>
                 <td class="auto-style13">&nbsp;</td>
             </tr>
        </table>
    </asp:View>


<asp:View ID="ViewConfimation" runat="server">
    <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style4" colspan="4">
                <asp:Label ID="LbConfirmManagement" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Confirmation Management"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style92">&nbsp;</td>
             <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style180" colspan="4">
                <p>To confirm an employee he/she MUST reach minimum duration as stated by the management<br />
                    Please follow the instruction below to confirm an employee
                    <ul>
                        <li>Select the employee you want to confirm from the list of Unconfirmed employees</li>
                        <li>Click on 'Confirm' button to confirm</li>
                        <li>Click of 'List' to List out the list of Confirmed Employees</li>
                         <li>Click on 'Finish' button to go to the home page</li>

                    </ul>


                    <p>
                    </p>


                    <p>
                    </p>


                </p>

            </td>
        </tr>
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style92">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">
                <asp:Label ID="LbEmployeeDetails" runat="server" Font-Bold="True" Text="EmployeeID" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style92">
                <asp:DropDownList ID="confirmEmployeeList" runat="server" Width="250px" AutoPostBack="True" OnSelectedIndexChanged="confirmEmployeeList_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
             <td>&nbsp;</td>
        </tr>
         <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style92">&nbsp;</td>
             <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">
                <asp:Label ID="LbEmployeeDetails0" runat="server" Font-Bold="True" Font-Size="14pt" Text="StartDate"></asp:Label>
            </td>
            <td class="auto-style92">
                <asp:Label ID="LbConfirmStartDate" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Visible="False">Label</asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style92">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">
                <asp:Label ID="LbConfirmDate1" runat="server" Font-Bold="True" Font-Size="14pt" Text="ConfirmDate"></asp:Label>
            </td>
            <td class="auto-style92">
                <asp:Label ID="LbConfrimationDate" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Visible="False">Label</asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
         <tr>
             <td class="auto-style182">&nbsp;</td>
             <td class="auto-style8">&nbsp;</td>
             <td class="auto-style92">&nbsp;</td>
             <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">
                <asp:Label ID="LbConfirmDate2" runat="server" Font-Bold="True" Font-Size="14pt" Text="Duration"></asp:Label>
            </td>
            <td class="auto-style92">
                <asp:Label ID="LbConfrimDuration" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Visible="False">Label</asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style92">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style94" colspan="4">
                <asp:Label ID="LbConfirmDuration" runat="server" Font-Bold="True" ForeColor="#FF3300" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style92">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
         <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">
                <asp:Label ID="LbConfirmBy" runat="server" Font-Bold="True" Text="ConfirmedBy" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style92">
                <asp:Label ID="LbConfirmedBy" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Visible="False">Label</asp:Label>
            </td>
             <td>&nbsp;</td>
        </tr>
       
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style92">&nbsp;</td>
             <td>&nbsp;</td>
        </tr>

        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style92">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>

        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
            <td class="auto-style92">
                <asp:Button ID="confirmBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Confirm" OnClick="confirmBtn_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="confirmListBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="List" OnClick="confirmListBtn_Click" />
            </td>
             <td>
                 <asp:Button ID="QualifFinishBtn2" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="QualifFinishBtn_Click" Text="Finish" />
            </td>
        </tr>
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style92">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style182" colspan="4">
                <asp:Label ID="LbConfirmSuccessful" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#99CC00" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style92">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style182" colspan="4">
                <asp:GridView ID="GViewConfirmedList" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:TextBox ID="TextBox7" runat="server" Visible="false" Text='<%#DataBinder.Eval(Container, "DataItem.EmployeeID") %>'></asp:TextBox>
                               
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="EmployeeNum" HeaderText="EmpNum" />
                        <asp:BoundField DataField="Username" HeaderText="UserName" />
                        <asp:BoundField DataField="StartDate" HeaderText="StartDate" />
                        <asp:BoundField DataField="ConfirmationDate" HeaderText="ConfirmationDate" />
                        <asp:BoundField DataField="ConfirmedByName" HeaderText="ConfirmBy" />
                        <asp:BoundField DataField="Gender" HeaderText="Gender" />
                        <asp:BoundField DataField="PhoneNo" HeaderText="PhoneNo" />
                        <asp:BoundField DataField="DeptName" HeaderText="Dept" />
                        <asp:BoundField DataField="PositionName" HeaderText="Position" />
                        <asp:BoundField DataField="LevelName" HeaderText="Level" />
                        <asp:BoundField DataField="LocationName" HeaderText="Branch" />
                        <asp:BoundField DataField="LocationAddress" HeaderText="OfficeAddress" />
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style92">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style92">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:View>


    <asp:View ID="ViewTraining" runat="server">

        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style3" colspan="4">
                <asp:Label ID="Label32" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Training Management"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style11"></td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style2"></td>
            <td class="auto-style3"></td>

        </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">
                &nbsp;</td>
            <td class="auto-style4">
                <asp:Label ID="Label36" runat="server" Font-Bold="True" Text="Department"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:DropDownList ID="trainingDeptList0" runat="server" AutoPostBack="True" Width="250px">
                    <asp:ListItem>***Please select***</asp:ListItem>
                    <asp:ListItem>Account</asp:ListItem>
                    <asp:ListItem>Busery</asp:ListItem>
                    <asp:ListItem>Registry</asp:ListItem>
                    <asp:ListItem>Adminstrative</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
         <tr>
            <td class="auto-style7"></td>
            <td class="auto-style8"></td>
            <td class="auto-style9"></td>
            <td class="auto-style10"></td>
        </tr>
        <tr>
            <td class="auto-style11">
                &nbsp;</td>
            <td class="auto-style4">
                <asp:Label ID="LbTrainingType0" runat="server" Font-Bold="True" Text="Training Type"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:DropDownList ID="traininTypeList0" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                &nbsp;</td>

        </tr>
        <tr>
            <td class="auto-style11"></td>
            <td class="auto-style4"></td>
            <td class="auto-style2"></td>
            <td class="auto-style3"></td>

        </tr>
            <tr>
                <td class="auto-style1" colspan="4">
                    <asp:GridView ID="GViewTrainingEmpList" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="EmployeeID" EnableModelValidation="True" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" InsertVisible="False" ReadOnly="True" SortExpression="EmployeeID" />
                            <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                            <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                            <asp:BoundField DataField="Department_FK" HeaderText="Department_FK" SortExpression="Department_FK" />
                            <asp:BoundField DataField="PositionHeld_FK" HeaderText="PositionHeld_FK" SortExpression="PositionHeld_FK" />
                            <asp:BoundField DataField="WorkLocation_FK" HeaderText="WorkLocation_FK" SortExpression="WorkLocation_FK" />
                            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                            <asp:BoundField DataField="PhoneNo" HeaderText="PhoneNo" SortExpression="PhoneNo" />
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
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style4">
                <asp:Label ID="LbSendBy" runat="server" Font-Bold="True" Text="SentBy"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:Label ID="LbSentBy" runat="server" Font-Bold="True" ForeColor="#FF6666"></asp:Label>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style13">
                <asp:Button ID="trainingAssignBtn0" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Request" />
            </td>
            <td class="auto-style14">
                <asp:Button ID="trainingHomeBtn1" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33"  Text="Finish" />
            </td>
            <td class="auto-style15">
            </td>
        </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
    </table>

        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style3" colspan="4">
                <asp:Label ID="LbTraining" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Training Management"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style62"></td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>

        </tr>
        <tr>
            <td class="auto-style62">
                &nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="LbtrainindDept" runat="server" Font-Bold="True" Text="Department" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="trainingDeptList" runat="server" Width="250px" DataTextField="DeptID" DataValueField="DeptName">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style62">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
            <tr>
                <td class="auto-style62">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="LbEmpID" runat="server" Font-Bold="True" Text="EmployeeID" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="TrainingPositionList" runat="server" Width="250px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style62">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style62">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="LbEmpID0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Position"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="TrainingEmployeeList" runat="server" Width="250px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style62">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        <tr>
            <td class="auto-style61">
                &nbsp;</td>
            <td>
                <asp:Label ID="LbTrainingType" runat="server" Font-Bold="True" Text="Training Type" Font-Size="14pt"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="traininTypeList" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
         <tr>
            <td class="auto-style62"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
        </tr>
            <tr>
                <td class="auto-style62">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="LbTrainingLoc" runat="server" Font-Bold="True" Text="Training Location" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="trainingLocationList" runat="server" Width="250px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style62">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style62">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="Label61" runat="server" Font-Bold="True" Font-Size="14pt" Text="Start Date"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="trainingStartDayList" runat="server" Width="83px">
                    </asp:DropDownList>
                    &nbsp;<asp:DropDownList ID="trainingStartMonthList" runat="server" Width="83px">
                        <asp:ListItem Value="00">*Month*</asp:ListItem>
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
                    &nbsp;<asp:DropDownList ID="trainingStartYearList" runat="server" AutoPostBack="True" Width="83px">
                    </asp:DropDownList>
                    <%--   <asp:RequiredFieldValidator ID="DOBReqFieldVal0" runat="server" ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="DOBRequired" SetFocusOnError="True">DOBRequired</asp:RequiredFieldValidator>
        --%>&nbsp; &nbsp; </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style62">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style62">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="Label60" runat="server" Font-Bold="True" Text="End Date" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="trainingEndDayList" runat="server" Width="83px">
                    </asp:DropDownList>
                    &nbsp;<asp:DropDownList ID="trainingEndMonthList" runat="server" Width="83px">
                        <asp:ListItem Value="00">*Month*</asp:ListItem>
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
                    &nbsp;<asp:DropDownList ID="trainingEndYearList" runat="server" AutoPostBack="True" Width="83px">
                    </asp:DropDownList>
                    <%--   <asp:RequiredFieldValidator ID="DOBReqFieldVal0" runat="server" ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="DOBRequired" SetFocusOnError="True">DOBRequired</asp:RequiredFieldValidator>
        --%>&nbsp; &nbsp; &nbsp; </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style62">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style62">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="LbTrainingStartDate0" runat="server" Font-Bold="True" Text="Start Date" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label62" runat="server" Font-Bold="True" Text="End Date" Font-Size="14pt"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
            <tr><td></td></tr>
            <tr>
                <td class="auto-style62">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="LbAssignBy0" runat="server" Font-Bold="True" Text="AssignedBy" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="LbAssignedBy" runat="server" Font-Bold="True" ForeColor="#FF6666"></asp:Label>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp; &nbsp;
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="trainingAssignBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Assign" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="QualifFinishBtn3" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="QualifFinishBtn_Click" Text="Finish" />
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style61">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
    </table>
</asp:View>

    <asp:View ID="ViewTransfer" runat="server">
    <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style3" colspan="4">
                <asp:Label ID="LbTransferManagement" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Transfer Management"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style86"></td>
            <td class="auto-style88">&nbsp;</td>
            <td class="auto-style90"></td>
            <td class="auto-style3"></td>

        </tr>
        <tr>
            <td class="auto-style86" colspan="4">

                <p> This is Transfer Module, please follow the instruction below to transfer employee
                    <ul>
                        <li>Select the employee you want to transfer</li>
                        <li>Select select new location he/she will be going to </li>
                        <li>Select select the departmen</li>
                    </ul>
                    <p>
                    </p>
                </p>
            </td>
        </tr>
        <tr>
            <td class="auto-style86">&nbsp;</td>
            <td class="auto-style88">&nbsp;</td>
            <td class="auto-style90">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style86">
                &nbsp;</td>
            <td class="auto-style88">
                <asp:Label ID="LbEmployeeID0" runat="server" Font-Bold="True" Text="EmployeeID" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style90">
                <asp:DropDownList ID="transferEmployeeList" runat="server" Width="250px" AutoPostBack="True" OnSelectedIndexChanged="transferEmployeeList_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style86">&nbsp;</td>
            <td class="auto-style88">&nbsp;</td>
            <td class="auto-style90">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style86">&nbsp;</td>
            <td class="auto-style88">
                <asp:Label ID="LbPreWokLoc" runat="server" Font-Bold="True" Text="Previous Work Location" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style90">
                <asp:Label ID="LbTransferPreWorkLoc" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style86">&nbsp;</td>
            <td class="auto-style88">&nbsp;</td>
            <td class="auto-style90">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style87">
                &nbsp;</td>
            <td class="auto-style89">
                <asp:Label ID="LbNewWokLoc0" runat="server" Font-Bold="True" Text="New Work Location" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style91">
                <asp:DropDownList ID="transferNewWokLocList" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
         <tr>
            <td class="auto-style86"></td>
            <td class="auto-style88"></td>
            <td class="auto-style90"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style86">
                &nbsp;</td>
            <td class="auto-style88">
                <asp:Label ID="LbPreDept" runat="server" Font-Bold="True" Text="Previous Dept" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style90">
                <asp:Label ID="LbTransferPreDept" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
            </td>
            <td class="auto-style3">
                &nbsp;</td>

        </tr>
        <tr>
            <td class="auto-style87">&nbsp;</td>
            <td class="auto-style89">&nbsp;</td>
            <td class="auto-style91">&nbsp;</td>
            <td class="auto-style3"></td>
        </tr>

         <tr>
             <td class="auto-style87">&nbsp;</td>
             <td class="auto-style89">
                 <asp:Label ID="LbNewDept" runat="server" Font-Bold="True" Text="New Dept" Font-Size="14pt"></asp:Label>
             </td>
             <td class="auto-style91">
                 <asp:DropDownList ID="transferNewDeptList" runat="server" Width="250px">
                 </asp:DropDownList>
             </td>
             <td class="auto-style3">&nbsp;</td>
        </tr>

         <%--<tr>
            <td class="auto-style86">
                &nbsp;</td>
            <td class="auto-style88">
                <asp:Label ID="LbPrePosition" runat="server" Font-Bold="True" Text="Previous Position" Font-Size="14pt"></asp:Label>
             </td>
            <td class="auto-style90">
                <asp:DropDownList ID="prePositionList" runat="server" Width="250px">
                </asp:DropDownList>
             </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style86"></td>
            <td class="auto-style88"></td>
            <td class="auto-style90"></td>
            <td class="auto-style3"></td>

        </tr>
        <tr>
            <td class="auto-style86">&nbsp;</td>
            <td class="auto-style88">
                <asp:Label ID="LbNewPosition" runat="server" Font-Bold="True" Text="New Position" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style90">
                <asp:DropDownList ID="newPositionList" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>--%>
        <tr>
            <td class="auto-style86">&nbsp;</td>
            <td class="auto-style88">&nbsp;</td>
            <td class="auto-style90">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style86">&nbsp;</td>
            <td class="auto-style88">
                <asp:Label ID="LbDateTransfered" runat="server" Font-Bold="True" Font-Size="14pt" Text="Transfer Date"></asp:Label>
            </td>
            <td class="auto-style90">
                <asp:Label ID="LbTransferDate" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style86">&nbsp;</td>
            <td class="auto-style88">&nbsp;</td>
            <td class="auto-style90">
                &nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style86">&nbsp;</td>
            <td class="auto-style88">&nbsp;</td>
            <td class="auto-style90">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style87">
                &nbsp;</td>
            <td class="auto-style89">
                <asp:Label ID="LbTransferBy" runat="server" Font-Bold="True" Text="TransferedBy" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style91">
                <asp:Label ID="LbTransferedBy" runat="server" Font-Bold="True" ForeColor="#CC0066" Visible="False"></asp:Label>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style87">&nbsp;</td>
            <td class="auto-style89">&nbsp;</td>
            <td class="auto-style91">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style87" colspan="4">
                <asp:Label ID="LbTransferSuccessful" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#99CC00" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style87">&nbsp;</td>
            <td class="auto-style89">&nbsp;</td>
            <td class="auto-style91">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style86"></td>
            <td class="auto-style88"></td>
            <td class="auto-style90">
                <asp:Button ID="TransferBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Transfer" OnClick="TransferBtn_Click" />
                &nbsp; &nbsp;
            </td>
            <td class="auto-style3">
                <asp:Button ID="QualifFinishBtn4" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Finish" OnClick="QualifFinishBtn_Click" />
            </td>
        </tr>
    </table>
</asp:View>

<asp:View ID="ViewLeave" runat="server">
    <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style54">
                <asp:Label ID="LbLeaveManagement" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Leave Management"></asp:Label>
            </td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style80">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style80">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54" colspan="4">
                <ul>
                    <li><p>Select the Department to view all Leave application for the department</p></li>
                    <li><p>Click on view to see full details of an application</p></li>
                    <li><p>Approve or Reject leave Application</p></li>


                </ul>
            </td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style19">
                <asp:Label ID="Label144" runat="server" Text="Department"></asp:Label>
            </td>
            <td class="auto-style80">
                <asp:DropDownList ID="ddlLeaveDeptList" runat="server">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style80">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54" colspan="4">
                <asp:Panel ID="Panel4" runat="server">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" EnableModelValidation="True">
                        <Columns>
                            <asp:BoundField DataField="EmployeeNum" HeaderText="Employee Num" />
                            <asp:BoundField DataField="FirstName" HeaderText="Name" />
                            <asp:BoundField DataField="LeaveType" HeaderText="Leave Type" />
                            <asp:BoundField DataField="Duration" HeaderText="Duration" />
                            <asp:BoundField DataField="DateApplied" HeaderText="DateApplied" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton23" runat="server">View</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style80">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54" colspan="4">
                <asp:Panel ID="Panel5" runat="server">
                    <table style="width:80%; margin-left:50px;">
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label145" runat="server" style="font-weight: 700" Text="Name"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label151" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
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
                                <asp:Label ID="Label146" runat="server" style="font-weight: 700" Text="Leave Type"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label152" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
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
                                <asp:Label ID="Label147" runat="server" style="font-weight: 700" Text="Description"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label153" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
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
                                <asp:Label ID="Label148" runat="server" style="font-weight: 700" Text="Start Date"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label154" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
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
                                <asp:Label ID="Label149" runat="server" style="font-weight: 700" Text="End Date"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label155" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
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
                                <asp:Label ID="Label150" runat="server" style="font-weight: 700" Text="Duration"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label156" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>

         <tr>
             <td class="auto-style54">&nbsp;</td>
             <td class="auto-style19">&nbsp;</td>
             <td class="auto-style80">&nbsp;</td>
             <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style19">
                <asp:Label ID="LbLeaveEmployeeID" runat="server" Font-Bold="True" Font-Size="14pt" Text="EmployeeID"></asp:Label>
            </td>
            <td class="auto-style80">
                <asp:DropDownList ID="LeaveEmployeeList" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>

         <tr>
            <td class="auto-style54">&nbsp;</td>
             <td class="auto-style19">&nbsp;</td>
            <td class="auto-style80">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">
                &nbsp;</td>
            <td class="auto-style19">
                <asp:Label ID="LbLeaveType" runat="server" Font-Bold="True" Font-Size="14pt" Text="Leave Type"></asp:Label>
            </td>
            <td class="auto-style80">
                <asp:DropDownList ID="leaveTypeList" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style80">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>

         <tr>
             <td class="auto-style54">&nbsp;</td>
             <td class="auto-style19">
                 <asp:Label ID="LbLeaveDesc0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Leave Description"></asp:Label>
             </td>
             <td class="auto-style80">
                 <asp:TextBox ID="txtLeaveDesc" runat="server" Width="250px"></asp:TextBox>
             </td>
             <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style80">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style19">
                <asp:Label ID="LbLeaveStartDate1" runat="server" Font-Bold="True" Font-Size="14pt" Text="Start Date"></asp:Label>
            </td>
            <td class="auto-style80">
                <asp:DropDownList ID="leaveStartDayList" runat="server" Width="83px">
                </asp:DropDownList>
                &nbsp;<asp:DropDownList ID="leaveStartMonthList" runat="server" Width="83px">
                    <asp:ListItem Value="00">*Month*</asp:ListItem>
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
                &nbsp;<asp:DropDownList ID="leaveStartYearList" runat="server" AutoPostBack="True" Width="83px">
                </asp:DropDownList>
                <%--   <asp:RequiredFieldValidator ID="DOBReqFieldVal0" runat="server" ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="DOBRequired" SetFocusOnError="True">DOBRequired</asp:RequiredFieldValidator>
        --%>&nbsp; </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style80">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style19">
                <asp:Label ID="LbLeaveStartDate2" runat="server" Font-Bold="True" Font-Size="14pt" Text="End Date"></asp:Label>
            </td>
            <td class="auto-style80">
                <asp:DropDownList ID="LeaveEndDayList" runat="server" Width="83px">
                </asp:DropDownList>
                &nbsp;<asp:DropDownList ID="LeaveEndMonthList" runat="server" Width="83px">
                    <asp:ListItem Value="00">*Month*</asp:ListItem>
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
                &nbsp;<asp:DropDownList ID="LeaveEndYearList" runat="server" AutoPostBack="True" Width="83px">
                </asp:DropDownList>
                <%--   <asp:RequiredFieldValidator ID="DOBReqFieldVal0" runat="server" ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="DOBRequired" SetFocusOnError="True">DOBRequired</asp:RequiredFieldValidator>
        --%>&nbsp; </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style80">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style19">
                <asp:Label ID="LbLeaveStartDate0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Start Date"></asp:Label>
            </td>
            <td class="auto-style80">
                <asp:TextBox ID="txtLeaveStartDate" runat="server" Width="225px"></asp:TextBox>
                <asp:ImageButton ID="leaveStartDayCalenderImageBtn" runat="server" Height="25px" ImageUrl="~/images/calendar.png" OnClick="leaveStartDayCalenderImageBtn_Click" Width="25px" />
            </td>
            <td>&nbsp;</td>
        </tr>

         <tr>
            <td class="auto-style54">
                &nbsp;</td>
             <td class="auto-style19">&nbsp;</td>
            <td class="auto-style80">
                <asp:Calendar ID="leaveStartDateCalender" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px" Visible="False">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
             </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style80">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style19">
                <asp:Label ID="LbLeaveEndDate0" runat="server" Font-Bold="True" Font-Size="14pt" Text="End Date"></asp:Label>
            </td>
            <td class="auto-style80">
                <asp:TextBox ID="txtLeaveEndDate" runat="server" Width="225px"></asp:TextBox>
                <asp:ImageButton ID="leaveEndDayCalenderImageBtn" runat="server" Height="25px" ImageUrl="~/images/calendar.png" OnClick="leaveEndDayCalenderImageBtn_Click" Width="25px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style80">
                <asp:Calendar ID="leaveEndDateCalender" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px" Visible="False">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style80">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">
                &nbsp;</td>
            <td class="auto-style19">
                <asp:Label ID="LbLeaveDurtion" runat="server" Font-Bold="True" Font-Size="14pt" Text="Duration"></asp:Label>
            </td>
            <td class="auto-style80">
                <asp:TextBox ID="txtLeaveDuration" runat="server" Width="250px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>

         <tr>
            <td class="auto-style79">&nbsp;</td>
             <td class="auto-style75"></td>
            <td class="auto-style81"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style79">&nbsp;</td>
            <td class="auto-style75">
                <asp:Label ID="LbLeaveStatus" runat="server" Font-Bold="True" Font-Size="14pt" Text="Leave Threshold"></asp:Label>
            </td>
            <td class="auto-style81">
                <asp:TextBox ID="txtLeaveThreshold" runat="server" Width="250px"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style79">&nbsp;</td>
            <td class="auto-style75">&nbsp;</td>
            <td class="auto-style81">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">
                &nbsp;</td>
            <td class="auto-style19">
                <asp:Label ID="LbGrantBy" runat="server" Font-Bold="True" Font-Size="14pt" Text="Leave GrantedBy"></asp:Label>
            </td>
            <td class="auto-style80">
                <asp:Label ID="LbLeaveGrantedBy" runat="server" Font-Bold="True" ForeColor="#FF6666"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style80">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style80">
                <asp:Button ID="grantLeaveBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Approve" />
            </td>
            <td>
                <asp:Button ID="QualifFinishBtn5" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="QualifFinishBtn_Click" Text="Finish" />
            </td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style80">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:View>



<asp:View ID="ViewQuery" runat="server">
    <table style="border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style96" colspan="4">
                <asp:Label ID="LbQuery0" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Query Management"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style96">&nbsp;</td>
            <td class="auto-style103" colspan="2">
                <asp:LinkButton ID="LinkQuery" runat="server" OnClick="LinkQuery_Click" style="font-weight: 700">Issue Query</asp:LinkButton>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkDiscipline" runat="server" OnClick="LinkDiscipline_Click" style="font-weight: 700">Discipline Employee</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style3">
                <asp:Label ID="lblQueryIssueReport" runat="server"></asp:Label>
            </td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="4">
                <asp:Label ID="lblListQuery" runat="server" style="font-weight: 700; font-style: italic; color: #CC3300" Text="List of Query Issued" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="4">
                <asp:GridView ID="GVHRQuery" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" OnRowCommand="GVHRQuery_RowCommand">
                    <Columns>
                        <asp:BoundField DataField="EmployeeNum" HeaderText="Employee Num" />
                        <asp:BoundField DataField="QueryReceivedByName" HeaderText="Employee Name" />
                        <asp:BoundField DataField="QueryTitle" HeaderText="Query Title" />
                        <asp:BoundField DataField="IssueDate" HeaderText="Issue Date" />
                        <asp:BoundField DataField="ResponseDate" HeaderText="Response Date" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton22" runat="server"  CommandArgument='<%#DataBinder.Eval(Container,"DataItem.QueryID")%>' CommandName="View" >View</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style96" colspan="4">
                <table style="width:100%;">
                    <tr>
                        <td>
                            <asp:Panel ID="PanelQuery" runat="server" Width="80%">
                                <table style="width: 80%;  margin-left:75px; ">
                                    <tr>
                                        <td colspan="3">
                                            <asp:Label ID="LbDiscipline1" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" style="color: #CC3300; font-size: small; font-style: italic;" Text="Select the employee you want to query "></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">
                                            <asp:Label ID="Label134" runat="server" style="font-weight: 700" Text="Department"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="queryDeptList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="queryDeptList_SelectedIndexChanged" Width="250px">
                                            </asp:DropDownList>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">
                                            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="14pt" Text="EmployeeNum" style="font-size: medium"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="queryEmployeeList" runat="server" OnSelectedIndexChanged="queryEmployeeList_SelectedIndexChanged" Width="250px">
                                            </asp:DropDownList>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">
                                            <asp:Label ID="QueryTitle0" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Query Title"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtQueryTitle" runat="server" Width="250px"></asp:TextBox>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">
                                            <asp:Label ID="LbQueryDesc" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Query Description"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtQueryDesc" runat="server" Height="108px" Width="250px" TextMode="MultiLine"></asp:TextBox>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">
                                            <asp:Label ID="Label135" runat="server" style="font-weight: 700" Text="Select Query Letter"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:FileUpload ID="QueryFileUpload" runat="server" />
                                            &nbsp;&nbsp;&nbsp;
                                            <asp:LinkButton ID="LinkButton21" runat="server">Upload Letter</asp:LinkButton>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">
                                            <asp:Label ID="LbIssueDate1" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Issue Date"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="LbHrQueryIssueDate" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="False"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">
                                            <asp:Label ID="LbIssueBy0" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="IssueBy"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="LbIssuedBy" runat="server" Font-Bold="True" ForeColor="#FF6666"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">&nbsp;</td>
                                        <td>
                                            <asp:Button ID="btnSendQuery" runat="server" Text="Send Query" OnClick="btnSendQuery_Click" />
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </td>
                        
                    </tr>
                    
                </table>
            </td>
        </tr>
       <%-- <tr>
            <td class="auto-style96">&nbsp;</td>
            <td class="auto-style103">
                <asp:Label ID="LbIssueDate" runat="server" Font-Bold="True" Text="Issue Date" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style100">
                <asp:TextBox ID="txtQueryIssuedDate" runat="server" Width="225px"></asp:TextBox>
                <asp:ImageButton ID="queryIssuedDateCalenderImageBtn" runat="server" Height="25px" ImageUrl="~/images/calendar.png" Width="25px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style96">&nbsp;</td>
            <td class="auto-style103">&nbsp;</td>
            <td class="auto-style100">
                <asp:Calendar ID="IssueDateCalendar" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px" Visible="False">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
            </td>
            <td>&nbsp;</td>
        </tr>--%>

        <tr>
            <td class="auto-style96">&nbsp;</td>
            <td class="auto-style103">&nbsp;</td>
            <td class="auto-style100">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style96" colspan="4"><asp:Panel ID="PanelDiscipline" runat="server" Width="80%" Visible="False">
                                <table style="width: 80%;  margin-left:75px; ">
                                    <tr>
                                        <td colspan="3">
                                            <asp:Label ID="LbDiscipline0" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" style="color: #CC3300; font-size: small; font-style: italic;"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style183"><strong>EmployeeNum</strong></td>
                                        <td>
                                            <asp:Label ID="lblDisEmpNum" runat="server" style="color: #CC3300" Text="Label"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td><b>Query Title</b></td>
                                        <td>
                                            <asp:Label ID="lblDisQueryTitle" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td><b>Query Description</b></td>
                                        <td colspan="2">
                                            <asp:Label ID="lblDisQueryDescription" runat="server" style="color: #CC3300; font-style: italic;" Text="Label"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td><b>Issued Day</b></td>
                                        <td>
                                            <asp:Label ID="lblDisQueryIssueDay" runat="server" CssClass="auto-style183" style="color: #CC3300" Text="Label"></asp:Label>
                                        </td>
                                        <td><b></b></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td><b>Employee Response</b></td>
                                        <td colspan="2">
                                            <asp:Label ID="lblDisQueryResponse" runat="server" CssClass="auto-style183" style="color: #CC3300; font-style: italic;" Text="Label"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td><b>Date Responded</b></td>
                                        <td>
                                            <asp:Label ID="lblDisResponseDate" runat="server" CssClass="auto-style183" style="color: #CC3300" Text="Label"></asp:Label>
                                        </td>
                                        <td><b></b></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td colspan="3">
                                            <asp:Label ID="Label143" runat="server" style="font-weight: 700; font-style: italic; color: #CC3300" Text="Specify the following if there is need to discipline the employee"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="3">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td><b>Discipline Type</b></td>
                                        <td>
                                            <asp:DropDownList ID="ddlDisciplineType" runat="server" CssClass="auto-style183" Width="250px">
                                                <asp:ListItem>---Please Select----</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td><b></b></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td><b>Discipline Description</b></td>
                                        <td>
                                            <asp:TextBox ID="txtDisciplineDescription" runat="server" Height="88px" Width="241px" TextMode="MultiLine"></asp:TextBox>
                                        </td>
                                        <td><b></b></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td><b>Discipline Date</b></td>
                                        <td>
                                            <asp:Label ID="lblDisciplineDate" runat="server"></asp:Label>
                                        </td>
                                        <td><b></b></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td><b>Disciplined By:</b></td>
                                        <td><b></b>
                                            <asp:Label ID="lblDisciplineBy" runat="server"></asp:Label>
                                        </td>
                                        <td><b></b></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td><b>Discipline letter</b></td>
                                        <td>
                                            <asp:FileUpload ID="DisciplinedLetterUpload" runat="server" CssClass="auto-style183" />
                                            <b>&nbsp;
                                            <asp:Label ID="lblDisciplineLetterName" runat="server"></asp:Label>
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:LinkButton ID="LinkButton20" runat="server">Upload Letter</asp:LinkButton>
                                            </b>
                                        </td>
                                        <td><b></b></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <asp:Button ID="btnSendDisciplined" runat="server" style="font-weight: 700" Text="Send" OnClick="btnSendDisciplined_Click" />
                                            &nbsp;
                                        </td>
                                        <td>
                                            <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" style="font-weight: 700" Text="Close" />
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel></td>
        </tr>
        <tr>
            <td class="auto-style96">&nbsp;</td>
            <td class="auto-style103">&nbsp;</td>
            <td class="auto-style100">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:View>

<%--<asp:View ID="ViewDiscipline" runat="server">
    <table style="border: medium solid #CC0066; width:100%;">
        <tr>
            <td>
                <asp:Label ID="LbDiscipline" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Discipline Management"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="EmployeeID"></asp:Label>
            </td>
            <td class="auto-style11">
                <asp:DropDownList ID="disciplineEmployeeList" runat="server">
                </asp:DropDownList>
            </td>
            <td class="auto-style11">
                &nbsp;
                <asp:Label ID="LbOffenceDesc" runat="server" Font-Bold="True" Text="Offence Description"></asp:Label>
            </td>
            <td class="auto-style11">
                <asp:TextBox ID="txtDisciplineDesc" runat="server"></asp:TextBox>
            </td>
        </tr>

         <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LbDisciplineSupervisorName" runat="server" Font-Bold="True" Text="Supervisor Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDisciplineSupervisorName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="LbSanction" runat="server" Font-Bold="True" Text="Sanction(Penalty)"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSanction" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="LbDisciplineBy" runat="server" Font-Bold="True" Text="DisciplinedBy"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LbDisciplined" runat="server" Font-Bold="True" ForeColor="#FF6666"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LbsanctionDuration" runat="server" Font-Bold="True" Text="Sanction Duration"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSactionDuration" runat="server"></asp:TextBox>
                &nbsp; </td>
        </tr>

         <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LbDateCommitted" runat="server" Font-Bold="True" Text="Offence Comitted Date"></asp:Label>
            </td>
            <td>
                <asp:Calendar ID="offenceComittedDateCalender" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
            </td>
            <td>
                <asp:Label ID="LbDisciplineDate" runat="server" Font-Bold="True" Text="Discipline Date"></asp:Label>
            </td>
            <td>
                <asp:Calendar ID="disciplineDateCalender" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="disciplineBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Discipline" />
            </td>
            <td>
                <asp:Button ID="disciplineNextBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Next" OnClick="disciplineNextBtn_Click" />
                &nbsp;
                <asp:Button ID="disciplineBackBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Back" OnClick="disciplineBackBtn_Click" />
            </td>
            <td>
                <asp:Button ID="disciplineHomeBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Home" OnClick="disciplineHomeBtn_Click" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:View>--%>


<asp:View ID="ViewAppraisal" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style3" colspan="4">
                <asp:Label ID="LbAppraisal" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Performance Appraisal Management"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>

        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="EmployeeID" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="appraisalEmployeeList" runat="server">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbSelfAppraisal" runat="server" Font-Bold="True" Text="Self-Appraisal Score" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbSelfAppraisalScore" runat="server" Font-Bold="True" ForeColor="#FF6666"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="LbEvaluator" runat="server" Font-Bold="True" Text=" Evaluator Name" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtEvaluatorName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbEvaluationPeriod" runat="server" Font-Bold="True" Text="Evaluation Period" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="evaluationPeriodList" runat="server">
                </asp:DropDownList>
            </td>
        </tr>

        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>

        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="LbSupervisor" runat="server" Font-Bold="True" Text="Supervisor Name" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtSupervisorName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:Label ID="Label17" runat="server" Font-Bold="True" Text="Start Year of Service" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="DropDownList3" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="LbAppraisal0" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Competency Factor Definitions"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <ul>
                    <li><strong>QUALITY OF WORK:</strong>Work quality refers to effort that consistently achieves desired outcomes with a minimum of avoidable</li>
                    <li><strong>PRODUCTIVITY:</strong>Consider how the person uses available working time, plans and prioritizes work, sets and accomplishes</li>
                    <li><strong>KNOWLEDGE OF THE JOB:</strong>Does the employee exhibit job-related knowledge and skill needed to perform the duties and requirements of the position? Does the employee exhibit knowledge of the methods, practices and equipment needed to do the 
                        job? Consider knowledge gained through experience, education, and specialized training. Does the employee seek to maintain
                        current knowledge of changes in policies and procedures? Does the employee keep abreast of new developments and major 
                        issues in the field? At times, employee may be consulted by others for guidance.</li>
                    <li><strong>ADAPTABILITY:</strong>How does this employee adjust to changes? Does this employee initiate or recommend beneficial changes in
                        work procedures? Does this employee readily accept new assignments or temporary assignments outside the regular
                        responsibilities? Consider willingness to learn quickly, to adapt to changes in job assignments, methods, personnel, or surroundings.</li>
                    <li><strong>DEPENDABILITY:</strong>How reliable is the employee in performing work assignments and carrying out instructions? Consider the 
                        degree of supervision required and the willingness to take on responsibilities and to be accountable for them.</li>
                    <li><strong>INITIATIVE AND RESOURCEFULNESS:</strong>Does the employee see things to be done and then take appropriate action without 
                        being so directed? Consider ability to contribute, develop and/or carry out new ideas or methods. Consider ability to be a selfstarter, 
                        to be creative, to offer suggestions, to anticipate needs and to seek additional tasks and projects to complete as timepermits.</li>
                <li><strong>JUDGEMENT AND POLICY COMPLIANCE:</strong>Does employee evaluate situations and make sound decisions, and use reasoning to identify, solve, and prevent problems? Does the employee work in a safe manner, preventing accidents, injuries, andtheft?
                     Does the employee exhibit knowledge of the University’s policies and procedures applicable to his/her assignment? Does the employee exhibit willingness to comply with all reasonable requirements?</li>
                <li><strong>INTERPERSONAL RELATIONS AND CUSTOMER SERVICE:</strong>Does the employee exhibit a good level of interpersonal
skills and have a good working relationship with most of his/her peers, subordinates, supervisors, customers, and the general
public? Consider respect and courtesy the employee shows to others, how the employee’s behavior affects the work area, and the
willingness of the employee to accept supervision. Does the employee exhibit appropriate supportive behavior toward the
University and its customers? Is the employee unnecessarily involved in trivial disputes and misunderstandings? Does the
employee exhibit willingness to work as a team member?</li>
                    <li><strong>ATTENDANCE AND PUNCTUALITY:</strong>Does the employee report to work on a timely basis and stay on the job? Consider
arrival times, observance of time limits for breaks and lunches. Consider patterns of sick leave use, seeking prior approval for
vacation, and giving prompt notice to supervisor of absence due to illness or other acceptable reasons.</li>
                    <li><strong>TEAM WORK:</strong> Does the employee exhibit willingness and ability to work as a team member? Does the employee respond to
suggestions and criticism with minimal defensiveness? Consider whether the employee keeps the supervisor and others advised
of problems or practical ideas when needed. Consider adherence to the guidelines and regulations that are utilized by the work
group, and assisting others on assignments and projects contributing to their success.</li>
                    <li><strong>COMMUNICATION SKILLS: </strong>To what extent does the employee demonstrate ability to communicate effectively in both oral
and written expression with other employees and his/her supervisor? Are issues confronted and resolved constructively? Consider
ability to help others with their work problems, and ability to keep others informed of decisions and plans for their own offices as
well as policies and procedures of the University.</li>
                    <li><strong>PLANNING AND ORGANIZATION:</strong>How effective is the employee in setting effective goals, planning ahead and
establishing priorities? Consider ability to make the most effective use of time, facilities, material, equipment, skills and other
resources. Examine ability to prepare and administer budget effectively.</li>
                    <li><strong>LEADERSHIP ABILITY:</strong>Is the employee able to get other employees to do willingly and well the duties needed to be
accomplished? Consider ability to get the work done while being sensitive to the morale and satisfaction of those doing the work;
the ability to function consistently and effectively in an objective and rational manner regardless of pressures.</li>
                    <li><strong>APPRAISAL AND DEVELOPMENT OF PEOPLE:</strong>Does the supervisor demonstrate ability to select, train and provide
opportunities for development of employees by recognizing and facilitating improvement of their abilities? Consider ability to
exhibit fairness and impartiality with employees in assigning job duties and objectively appraising work performance.</li>
               
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="LbConpetency" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Competency Rating Key"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style20"></td>
                        <td class="auto-style12">
                            &nbsp;<asp:Label ID="LbPreformance" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Performance Factors"></asp:Label>
                        </td>
                        <td class="auto-style18">
                            &nbsp;<asp:Label ID="LbPreformanceRatingKey" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Performance Rating Key"></asp:Label>
                        </td>
                        <td class="auto-style19">
                            <asp:Label ID="LbPreformancePoint" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Point (Scale 2-10)"></asp:Label>
                        </td>
                         <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style18">&nbsp;</td>
                        <td class="auto-style19">&nbsp;</td>
                         <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbQuality" runat="server" Font-Bold="True" Text="Quality of Work" Font-Size="14pt"></asp:Label>
                        </td>
                        <td class="auto-style18">
                            <asp:DropDownList ID="ratingKey1" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style19">
                            <asp:TextBox ID="txtratingPoint1" runat="server"></asp:TextBox>
                        </td>
                         <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style18">&nbsp;</td>
                        <td class="auto-style19">&nbsp;</td>
                         <td class="auto-style3"></td>
                    </tr>
                    <tr>
                         
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbProductivity" runat="server" Font-Bold="True" Text="Productivity" Font-Size="14pt"></asp:Label>
                        </td>
                        <td class="auto-style18">
                            <asp:DropDownList ID="ratingKey2" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style19">
                            <asp:TextBox ID="txtratingPoint2" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style3"></td>
                    </tr>
                     <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">
                            &nbsp;</td>
                        <td class="auto-style18">&nbsp;</td>
                        <td class="auto-style19">&nbsp;</td>
                         <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbKnowledge" runat="server" Font-Bold="True" Text="Knowledge of the Job" Font-Size="14pt"></asp:Label>
                        </td>
                        <td class="auto-style18">
                            <asp:DropDownList ID="ratingKey3" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style19">
                            <asp:TextBox ID="txtratingPoint3" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style18">&nbsp;</td>
                        <td class="auto-style19">&nbsp;</td>
                        <td class="auto-style3"></td>
                    </tr>
                     <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbAdability" runat="server" Font-Bold="True" Text="Adaptability" Font-Size="14pt"></asp:Label>
                        </td>
                        <td class="auto-style18">
                            <asp:DropDownList ID="ratingKey4" runat="server">
                            </asp:DropDownList>
                         </td>
                        <td class="auto-style19">
                            <asp:TextBox ID="txtratingPoint4" runat="server"></asp:TextBox>
                         </td>
                         <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style18">&nbsp;</td>
                        <td class="auto-style19">&nbsp;</td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbDependability" runat="server" Font-Bold="True" Text="Dependability" Font-Size="14pt"></asp:Label>
                        </td>
                        <td class="auto-style18">
                            <asp:DropDownList ID="ratingKey5" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style19">
                            <asp:TextBox ID="txtratingPoint5" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style18">&nbsp;</td>
                        <td class="auto-style19">&nbsp;</td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbInitiative" runat="server" Font-Bold="True" Text="Initiative &amp; Resourcefulness" Font-Size="14pt"></asp:Label>
                        </td>
                        <td class="auto-style18">
                            <asp:DropDownList ID="ratingKey6" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style19">
                            <asp:TextBox ID="txtratingPoint6" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style3"></td>
                    </tr>
                     <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">
                            &nbsp;</td>
                        <td class="auto-style18">&nbsp;</td>
                        <td class="auto-style19">&nbsp;</td>
                         <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbPolicyCompliance" runat="server" Font-Bold="True" Text="Judgment &amp; Policy Compliance" Font-Size="14pt"></asp:Label>
                        </td>
                        <td class="auto-style18">
                            <asp:DropDownList ID="ratingKey7" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style19">
                            <asp:TextBox ID="txtratingPoint7" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style18">&nbsp;</td>
                        <td class="auto-style19">&nbsp;</td>
                        <td class="auto-style3"></td>
                    </tr>
                     <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbInterpersonal" runat="server" Font-Bold="True" Text="Interpersonal Relations &amp; Customer Service" Font-Size="14pt"></asp:Label>
                        </td>
                        <td class="auto-style18">
                            <asp:DropDownList ID="ratingKey8" runat="server">
                            </asp:DropDownList>
                         </td>
                        <td class="auto-style19">
                            <asp:TextBox ID="txtratingPoint8" runat="server"></asp:TextBox>
                         </td>
                         <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style18">&nbsp;</td>
                        <td class="auto-style19">&nbsp;</td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbAttendance" runat="server" Font-Bold="True" Text="Attendance &amp; Punctuality" Font-Size="14pt"></asp:Label>
                        </td>
                        <td class="auto-style18">
                            <asp:DropDownList ID="ratingKey9" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style19">
                            <asp:TextBox ID="txtratingPoint9" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style18">&nbsp;</td>
                        <td class="auto-style19">&nbsp;</td>
                        <td class="auto-style3"></td>
                    </tr>
                     <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbTeam" runat="server" Font-Bold="True" Text="Team Work" Font-Size="14pt"></asp:Label>
                        </td>
                        <td class="auto-style18">
                            <asp:DropDownList ID="ratingKey10" runat="server">
                            </asp:DropDownList>
                         </td>
                        <td class="auto-style19">
                            <asp:TextBox ID="txtratingPoint10" runat="server"></asp:TextBox>
                         </td>
                         <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style18">&nbsp;</td>
                        <td class="auto-style19">&nbsp;</td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbCommunication" runat="server" Font-Bold="True" Text="Communication Skills" Font-Size="14pt"></asp:Label>
                        </td>
                        <td class="auto-style18">
                            <asp:DropDownList ID="ratingKey11" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style19">
                            <asp:TextBox ID="txtratingPoint11" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style18">&nbsp;</td>
                        <td class="auto-style19">&nbsp;</td>
                        <td class="auto-style3"></td>
                    </tr>
                     <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbPlanning" runat="server" Font-Bold="True" Text="Planning &amp; Organization" Font-Size="14pt"></asp:Label>
                        </td>
                        <td class="auto-style18">
                            <asp:DropDownList ID="ratingKey12" runat="server">
                            </asp:DropDownList>
                         </td>
                        <td class="auto-style19">
                            <asp:TextBox ID="txtratingPoint12" runat="server"></asp:TextBox>
                         </td>
                         <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style18">&nbsp;</td>
                        <td class="auto-style19">&nbsp;</td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbLeadership" runat="server" Font-Bold="True" Text="Leadership Ability" Font-Size="14pt"></asp:Label>
                        </td>
                        <td class="auto-style18">
                            <asp:DropDownList ID="ratingKey13" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style19">
                            <asp:TextBox ID="txtratingPoint13" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style3"></td>
                    </tr>
                     <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style18">&nbsp;</td>
                        <td class="auto-style19">&nbsp;</td>
                         <td class="auto-style3"></td>
                    </tr>
                     <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbDevelopment" runat="server" Font-Bold="True" Text="Appraisal &amp; Development of People" Font-Size="14pt"></asp:Label>
                        </td>
                        <td class="auto-style18">
                            <asp:DropDownList ID="ratingKey14" runat="server">
                            </asp:DropDownList>
                         </td>
                        <td class="auto-style19">
                            <asp:TextBox ID="txtratingPoint14" runat="server"></asp:TextBox>
                         </td>
                         <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style18">&nbsp;</td>
                        <td class="auto-style19">&nbsp;</td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbPoint" runat="server" Font-Bold="True" Text="Overall Rating/ Total Points" Font-Size="14pt"></asp:Label>
                        </td>
                        <td class="auto-style18">
                            <asp:DropDownList ID="OverallratingKey" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style19">
                            <asp:TextBox ID="txtTotalRatingPoint" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style3"></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LbConpetency0" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Performance Goal"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">Employees should develop and suggest goals for the supervisor and employee to discuss. Both the supervisor and employee should agree on the goals. Goals may be work-related or developmental; the goal should be limited to a one-year time frame. Enter the goals in order of importance. The following questions will assist the employee and supervisor:<br /> </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">&nbsp;<ol>
                    <li>What specific tasks, projects, or activities need to be accomplished?
                        </li>
                    <li>What changes in work performance are required or desired?</li>
                    <li> What training or work experience would be helpful or developmental?</li>
                </ol>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="LbPre" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Previous Year Goal- to be Reviewed for Current Performance Appraisal  "></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style29"></td>
                        <td class="auto-style149">
                            <asp:Label ID="LbGoalDesc1" runat="server" Font-Bold="True" Text="Goal Description" Font-Size="14pt"></asp:Label>
                        </td>
                        <td class="auto-style148">
                            <textarea id="txtPreYearGoalDesc" name="S2" rows="2"></textarea></td>
                        <td class="auto-style22"></td>
                    </tr>
                    <tr>
                        <td class="auto-style29">&nbsp;</td>
                        <td class="auto-style149">&nbsp;</td>
                        <td class="auto-style148">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style29">&nbsp;</td>
                        <td class="auto-style149">
                            <asp:Label ID="LbGoalDesc2" runat="server" Font-Bold="True" Text="Objective: Describe how the Goal was achieved" Font-Size="14pt"></asp:Label>
                        </td>
                        <td class="auto-style148">
                            <textarea id="txtPreYearGoalObjective" name="S3" rows="2"></textarea></td>
                        <td>&nbsp;</td>
                    </tr>
                     <tr>
                         <td class="auto-style29">&nbsp;</td>
                         <td class="auto-style149">&nbsp;</td>
                         <td class="auto-style148">&nbsp;</td>
                         <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style29">&nbsp;</td>
                        <td class="auto-style149">
                            <asp:Label ID="LbGoalEvaluationPoint" runat="server" Font-Bold="True" Text="Evaluation Point" Font-Size="14pt"></asp:Label>
                        </td>
                        <td class="auto-style148">
                            <asp:TextBox ID="txtPreYearEvaluationPoint" runat="server" Width="261px"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                     <tr>
                        <td class="auto-style29">&nbsp;</td>
                        <td class="auto-style149">&nbsp;</td>
                        <td class="auto-style148">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style29">&nbsp;</td>
                        <td class="auto-style149">
                            <asp:Label ID="LbCompDate" runat="server" Font-Bold="True" Font-Size="14pt" Text="Completion Date"></asp:Label>
                        </td>
                        <td class="auto-style148">
                            <asp:TextBox ID="txtSupPreYearGoalDate" runat="server" Width="191px"></asp:TextBox>
                            <asp:ImageButton ID="SupPreYearGoalDateCalenderImageBtn" runat="server" Height="25px" ImageUrl="~/images/calendar.png" OnClick="SupPreYearGoalDateCalenderImageBtn_Click" Width="25px" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style29">&nbsp;</td>
                        <td class="auto-style149">&nbsp;</td>
                        <td class="auto-style148">
                            <asp:Calendar ID="preYearGoalCompletionDateCalendar" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Visible="False" Width="200px">
                                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                <NextPrevStyle VerticalAlign="Bottom" />
                                <OtherMonthDayStyle ForeColor="#808080" />
                                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                <SelectorStyle BackColor="#CCCCCC" />
                                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                <WeekendDayStyle BackColor="#FFFFCC" />
                            </asp:Calendar>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style29">&nbsp;</td>
                        <td class="auto-style149">&nbsp;</td>
                        <td class="auto-style148">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="LbPre0" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Next Year Goal- to be Reviewed at Next Year's  Performance Appraisal  "></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">&nbsp; <table style="width:100%;">
                    <tr>
                        <td class="auto-style24"></td>
                        <td class="auto-style27">
                            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Goal Description" Font-Size="14pt"></asp:Label>
                        </td>
                        <td class="auto-style26">
                            <textarea id="txtNxtYearGoalDesc" name="S2" rows="2"></textarea></td>
                        <td class="auto-style22"></td>
                    </tr>
                    <tr>
                        <td class="auto-style24">&nbsp;</td>
                        <td class="auto-style27">&nbsp;</td>
                        <td class="auto-style26">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style24">&nbsp;</td>
                        <td class="auto-style27">
                            <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Objective: Describe how the Goal was achieved" Font-Size="14pt"></asp:Label>
                        </td>
                        <td class="auto-style26">
                            <textarea id="txtNxtYearGoalObjective" name="S3" rows="2"></textarea></td>
                        <td>&nbsp;</td>
                    </tr>
                     <tr>
                        <td class="auto-style24">&nbsp;</td>
                        <td class="auto-style27">&nbsp;</td>
                        <td class="auto-style26">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style24">&nbsp;</td>
                        <td class="auto-style27">
                            <asp:Label ID="LbGoalEvaluationPoint0" runat="server" Font-Bold="True" Text="Evaluation Point" Font-Size="14pt"></asp:Label>
                        </td>
                        <td class="auto-style26">
                            <asp:TextBox ID="txtNextYearEvaluationPoint0" runat="server" Width="256px"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style24">&nbsp;</td>
                        <td class="auto-style27">&nbsp;</td>
                        <td class="auto-style26">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style24">&nbsp;</td>
                        <td class="auto-style27">
                            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="14pt" Text="Completion Date"></asp:Label>
                        </td>
                        <td class="auto-style26">
                            <asp:TextBox ID="txtSupNextYearGoalDate" runat="server" Width="225px"></asp:TextBox>
                            <asp:ImageButton ID="SupNextYearGoalDateCalenderImageBtn" runat="server" Height="25px" ImageUrl="~/images/calendar.png" OnClick="SupNextYearGoalDateCalenderImageBtn_Click" Width="25px" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style24">&nbsp;</td>
                        <td class="auto-style27">
                            &nbsp;</td>
                        <td class="auto-style26">
                            <asp:Calendar ID="nxtYearCompletionDateCalendar" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                <NextPrevStyle VerticalAlign="Bottom" />
                                <OtherMonthDayStyle ForeColor="#808080" />
                                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                <SelectorStyle BackColor="#CCCCCC" />
                                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                <WeekendDayStyle BackColor="#FFFFCC" />
                            </asp:Calendar>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style24">&nbsp;</td>
                        <td class="auto-style27">&nbsp;</td>
                        <td class="auto-style26">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table></td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LbSupervisorAppraisalMark" runat="server" Font-Bold="True" Text="Direct Supervisor Appraisal Mark" Font-Size="14pt"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDirectSupAppraisalScore" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="LbExamScore" runat="server" Font-Bold="True" Text="Employee Promotion Exam/Interview Score" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtPromoExamScore" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LbTotalAppraisalScore" runat="server" Font-Bold="True" Text="Total Appraisal Score"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTotalAppraisalScore" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LbSupervisorName" runat="server" Font-Bold="True" Text="Direct Supervisor Name" Font-Size="14pt"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDirectSupName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="LbSupervisorComment" runat="server" Font-Bold="True" Text="Direct Supervisor's Comment" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtDirectSupComment" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="LbSupervisorName0" runat="server" Font-Bold="True" Text="Reviewer: (Next level of authority above the Direct Supervisor)" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtReviewerName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbSupervisorComment0" runat="server" Font-Bold="True" Text="Reviewer's Comment" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtReviewerComment" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style21">
                <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Size="14pt" Text="Total Apprasal Score"></asp:Label>
            </td>
            <td class="auto-style21">
                <asp:TextBox ID="txtSupTotalAppraisalScore0" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style21">
                <asp:Label ID="Label26" runat="server" Font-Bold="True" Font-Size="14pt" Text="OverallPoint"></asp:Label>
            </td>
            <td class="auto-style22">
                <asp:TextBox ID="txtOverallPoint" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="appraisalBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Appraise" />
                &nbsp; &nbsp;
            </td>
            <td class="auto-style3">
                <asp:Button ID="QualifFinishBtn7" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="QualifFinishBtn_Click" Text="Finish" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
    </table>
    </asp:View>

<asp:View ID="ViewPromotion" runat="server">
    <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style79" colspan="4">
                <asp:Label ID="LbPromotion" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Promotion Management"></asp:Label>
            </td>

        </tr>
        <tr>
            <td class="auto-style79">&nbsp;</td>
            <td class="auto-style108">&nbsp;</td>
            <td class="auto-style111">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style79">
                &nbsp;</td>
            <td class="auto-style108">
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="14pt" Text="EmployeeID"></asp:Label>
            </td>
            <td class="auto-style111">
                <asp:DropDownList ID="PromoEmployeeList" runat="server">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style79">&nbsp;</td>
            <td class="auto-style108">&nbsp;</td>
            <td class="auto-style111">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style79">&nbsp;</td>
            <td class="auto-style108">
                <asp:Label ID="LbPromoAppraisalScore" runat="server" Font-Bold="True" Font-Size="14pt" Text="Appraisal Score"></asp:Label>
            </td>
            <td class="auto-style111">
                <asp:Label ID="LbAppraisalScore" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="False"></asp:Label>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style79">&nbsp;</td>
            <td class="auto-style108">&nbsp;</td>
            <td class="auto-style111">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">
                &nbsp;</td>
            <td class="auto-style109">
                <asp:Label ID="preLevel" runat="server" Font-Bold="True" Font-Size="14pt" Text="Previous Level"></asp:Label>
            </td>
            <td class="auto-style112">
                <asp:Label ID="LbPreLevel" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="False"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
         <tr>
            <td class="auto-style79">&nbsp;</td>
             <td class="auto-style108"></td>
            <td class="auto-style111"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style79">&nbsp;</td>
            <td class="auto-style108">
                <asp:Label ID="promoNewLevel" runat="server" Font-Bold="True" Font-Size="14pt" Text="New Level"></asp:Label>
            </td>
            <td class="auto-style111">
                <asp:DropDownList ID="promoNewLevelList" runat="server">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style79">&nbsp;</td>
            <td class="auto-style108">&nbsp;</td>
            <td class="auto-style111">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style79">
                &nbsp;</td>
            <td class="auto-style108">
                <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="14pt" Text="Previous Position"></asp:Label>
            </td>
            <td class="auto-style111">
                <asp:Label ID="LbPreviousPosition" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="False"></asp:Label>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>

        <tr>
            <td class="auto-style79">&nbsp;</td>
            <td class="auto-style108"></td>
            <td class="auto-style111"></td>
            <td class="auto-style3"></td>

        </tr>
        <tr>
            <td class="auto-style79">&nbsp;</td>
            <td class="auto-style108">
                <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Size="14pt" Text="New Position"></asp:Label>
            </td>
            <td class="auto-style111">
                <asp:DropDownList ID="PromoNewPositionList" runat="server">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style79">&nbsp;</td>
            <td class="auto-style108">&nbsp;</td>
            <td class="auto-style111">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style79">&nbsp;</td>
            <td class="auto-style108">
                <asp:Label ID="DataPromoted0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Date Promoted"></asp:Label>
            </td>
            <td class="auto-style111">
                <asp:DropDownList ID="promoDayList" runat="server" Width="83px">
                </asp:DropDownList>
                &nbsp;<asp:DropDownList ID="promoMonthList" runat="server" Width="83px">
                    <asp:ListItem Value="00">*Month*</asp:ListItem>
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
                &nbsp;<asp:DropDownList ID="promoYearList" runat="server" AutoPostBack="True" Width="83px">
                </asp:DropDownList>
                <%--   <asp:RequiredFieldValidator ID="DOBReqFieldVal0" runat="server" ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="DOBRequired" SetFocusOnError="True">DOBRequired</asp:RequiredFieldValidator>
        --%>&nbsp;&nbsp;&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style79">&nbsp;</td>
            <td class="auto-style108">&nbsp;</td>
            <td class="auto-style111">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style79">&nbsp;</td>
            <td class="auto-style108">
                <asp:Label ID="DataPromoted1" runat="server" Font-Bold="True" Font-Size="14pt" Text="Date Promoted"></asp:Label>
            </td>
            <td class="auto-style111">
                <asp:TextBox ID="txtPromoDate" runat="server" Width="225px"></asp:TextBox>
                <asp:ImageButton ID="promoDateCalenderImageBtn" runat="server" Height="25px" ImageUrl="~/images/calendar.png" OnClick="leaveEndDayCalenderImageBtn_Click" Width="25px" />
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style79">&nbsp;</td>
            <td class="auto-style108">&nbsp;</td>
            <td class="auto-style111">
                <asp:Calendar ID="DataePromotedCalender" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px" Visible="False">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">
                &nbsp;</td>
            <td class="auto-style109">
                <asp:Label ID="LbPromoBy" runat="server" Font-Bold="True" Font-Size="14pt" Text="PromotedBy"></asp:Label>
            </td>
            <td class="auto-style112">
                <asp:Label ID="LbPromotedBy" runat="server" Font-Bold="True" ForeColor="#FF6666"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style109">&nbsp;</td>
            <td class="auto-style112">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style109">&nbsp;</td>
            <td class="auto-style112">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style109">&nbsp;</td>
            <td class="auto-style112">
                <asp:Button ID="promoteBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Promote" />
            </td>
            <td>
               <asp:Button ID="QualifFinishBtn8" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="QualifFinishBtn_Click" Text="Finish" />
            </td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style109">&nbsp;</td>
            <td class="auto-style112">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style109">&nbsp;</td>
            <td class="auto-style112">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:View>
<%--<asp:View ID="ViewPension" runat="server">
    <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style113" colspan="4">
                <asp:Label ID="LbPension" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Pension Management"></asp:Label>
            </td>

        </tr>
        <tr>
            <td class="auto-style113">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style113">
                &nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="14pt" Text="EmployeeID"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="pensionEmployeeList" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style113">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style113">&nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="LbBankAdmin" runat="server" Font-Bold="True" Font-Size="14pt" Text="Bank Administrator"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtBankAdmin" runat="server" Width="250px"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style113">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style114">
                &nbsp;</td>
            <td>
                <asp:Label ID="LbAcctName" runat="server" Font-Bold="True" Font-Size="14pt" Text="Account Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAcctName" runat="server" Width="250px"></asp:TextBox>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
         <tr>
            <td class="auto-style113">&nbsp;</td>
             <td class="auto-style3"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style113">&nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="LbAcctNum0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Account Number"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtAcctNum" runat="server" Width="250px"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style113">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style113">
                &nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="LbEmpMonthlyContr" runat="server" Font-Bold="True" Font-Size="14pt" Text="Employee Monthly Contribution"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtEmployeeMonthContributn" runat="server" Width="250px"></asp:TextBox>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>

        <tr>
            <td class="auto-style113">&nbsp;</td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>

        </tr>
        <tr>
            <td class="auto-style113">
                &nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="LbEmployerMonthlyContr0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Employer Monthly Contribution"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtEmployerMonthContributn0" runat="server" Width="250px"></asp:TextBox>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style114">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style114">&nbsp;</td>
            <td>
                <asp:Label ID="LbEmployerMonthlyContr1" runat="server" Font-Bold="True" Font-Size="14pt" Text="Total Monthly Contribution"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTotalMonthContributn" runat="server" Width="250px"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style114">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style114">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="pensionBtn1" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Place Employee on Pension" Width="221px" />
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style114">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
    </table>
</asp:View>--%>
    <asp:View ID="ViewRetirement" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style117" colspan="4">
                <asp:Label ID="LbRetirment" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Retirement Management"></asp:Label>
            </td>

        </tr>
        <tr>
            <td class="auto-style124">
                &nbsp;</td>
            <td class="auto-style119">&nbsp;</td>
            <td class="auto-style121">
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
            <tr>
                <td class="auto-style124">&nbsp;</td>
                <td class="auto-style119">
                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="14pt" Text="EmployeeID"></asp:Label>
                </td>
                <td class="auto-style121">
                    <asp:DropDownList ID="RetirementEmployeeList" runat="server" Width="250px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        <tr>
            <td class="auto-style124">&nbsp;</td>
            <td class="auto-style119">&nbsp;</td>
            <td class="auto-style121">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
            <tr>
                <td class="auto-style124">&nbsp;</td>
                <td class="auto-style119">
                    <asp:Label ID="LbRetireLevel" runat="server" Font-Bold="True" Font-Size="14pt" Text="Level as at Retirement"></asp:Label>
                </td>
                <td class="auto-style121">
                    <asp:TextBox ID="txtRetirementSalary" runat="server" Width="250px"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style124">&nbsp;</td>
                <td class="auto-style119">&nbsp;</td>
                <td class="auto-style121">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        <tr>
            <td class="auto-style124">
                &nbsp;</td>
            <td class="auto-style119">
                <asp:Label ID="LMonthlyPension" runat="server" Font-Bold="True" Font-Size="14pt" Text=" Monthly Pension Allowance"></asp:Label>
            </td>
            <td class="auto-style121">
                <asp:TextBox ID="TextBox6" runat="server" Width="250px"></asp:TextBox>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>

        <tr>
            <td class="auto-style124">&nbsp;</td>
            <td class="auto-style119"></td>
            <td class="auto-style121"></td>
            <td class="auto-style3"></td>

        </tr>
            <tr>
                <td class="auto-style124">&nbsp;</td>
                <td class="auto-style119">
                    <asp:Label ID="LbGratuity" runat="server" Font-Bold="True" Font-Size="14pt" Text="Gratuity/Entitlement"></asp:Label>
                </td>
                <td class="auto-style121">
                    <asp:TextBox ID="txtGratuity" runat="server" Width="250px"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style124">&nbsp;</td>
                <td class="auto-style119">&nbsp;</td>
                <td class="auto-style121">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        <tr>
            <td class="auto-style124">
                &nbsp;</td>
            <td class="auto-style119">
                <asp:Label ID="LbStartYearofService" runat="server" Font-Bold="True" Font-Size="14pt" Text="Start Year of Service"></asp:Label>
            </td>
            <td class="auto-style121">
                <asp:DropDownList ID="retireStartYearofService" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style124">&nbsp;</td>
            <td class="auto-style119">&nbsp;</td>
            <td class="auto-style121">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
            <tr>
                <td class="auto-style124">&nbsp;</td>
                <td class="auto-style119">
                    <asp:Label ID="LbEndYearofService" runat="server" Font-Bold="True" Font-Size="14pt" Text="End Year of Service"></asp:Label>
                </td>
                <td class="auto-style121">
                    <asp:DropDownList ID="retireEndYearofService" runat="server" Width="250px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style124">&nbsp;</td>
                <td class="auto-style119">&nbsp;</td>
                <td class="auto-style121">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        <tr>
            <td class="auto-style123">
                &nbsp;</td>
            <td class="auto-style120">
                <asp:Label ID="LbTotalYearofService" runat="server" Font-Bold="True" Font-Size="14pt" Text="Total Year of Service"></asp:Label>
            </td>
            <td class="auto-style122">
                <asp:TextBox ID="txtTotalYearofService" runat="server" Width="250px"></asp:TextBox>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style123">&nbsp;</td>
            <td class="auto-style120">&nbsp;</td>
            <td class="auto-style122">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style123">&nbsp;</td>
            <td class="auto-style120">&nbsp;</td>
            <td class="auto-style122">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style123">
                &nbsp;</td>
            <td class="auto-style120">
                <asp:Button ID="retirementBackBtn0" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Retire" />
            </td>
            <td class="auto-style122">
                <asp:Button ID="QualifFinishBtn9" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="QualifFinishBtn_Click" Text="Finish" />
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style123">&nbsp;</td>
            <td class="auto-style120">&nbsp;</td>
            <td class="auto-style122">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style123">&nbsp;</td>
            <td class="auto-style120">&nbsp;</td>
            <td class="auto-style122">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
    </table>
</asp:View>
<asp:View ID="View2" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>
                <asp:Label ID="Label140" runat="server" Text="Query Management"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:LinkButton ID="LinkButton18" runat="server">LinkButton</asp:LinkButton>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton19" runat="server">LinkButton</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Panel ID="Panel3" runat="server">
                    <table style="width: 80%;">
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:View>

</asp:MultiView>


         </td>
        
    </tr>
    <tr>
        <td></td>
        <td valign="center">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                                          <asp:LinkButton ID="hrHomeLinkBtn" runat="server" Font-Bold="True" Font-Size="12pt" OnClick="hrHomeLinkBtn_Click">Home</asp:LinkButton>
&nbsp;<asp:LinkButton ID="hrEmploymentLinkBtn" runat="server" Font-Bold="True" Font-Size="12pt" OnClick="hrEmploymentLinkBtn_Click">Employment</asp:LinkButton>
&nbsp;
            <asp:LinkButton ID="hrAcceptanceLinkButton" runat="server" Font-Bold="True" OnClick="hrAcceptanceLinkButton_Click">Acceptance</asp:LinkButton>
&nbsp;&nbsp;<asp:LinkButton ID="hrEmployeeLinkBtn" runat="server" Font-Bold="True" Font-Size="12pt" OnClick="hrEmployeeLinkBtn_Click">Employee</asp:LinkButton>
&nbsp;<asp:LinkButton ID="hrConfirmationLinkBtn" runat="server" Font-Bold="True" Font-Size="12pt" OnClick="hrConfirmationLinkBtn_Click">Confirmation</asp:LinkButton>
&nbsp;<asp:LinkButton ID="hrTrainingLinkBtn0" runat="server" Font-Bold="True" Font-Size="12pt" OnClick="hrTrainingLinkBtn0_Click">Training</asp:LinkButton>
&nbsp;&nbsp;</td>
        
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:LinkButton ID="hrTransferLinkBtn" runat="server" Font-Bold="True" Font-Size="12pt" OnClick="hrTransferLinkBtn_Click">Transfer</asp:LinkButton>
&nbsp;
                      <asp:LinkButton ID="hrLeaveLinkBtn" runat="server" Font-Bold="True" Font-Size="12pt" OnClick="hrLeaveLinkBtn_Click">Leave</asp:LinkButton>
&nbsp;<asp:LinkButton ID="hrQueryLinkBtn" runat="server" Font-Bold="True" Font-Size="12pt" OnClick="hrQueryLinkBtn_Click">Query</asp:LinkButton>
&nbsp;<asp:LinkButton ID="hrAppraisalLinkBtn" runat="server" Font-Bold="True" Font-Size="12pt" OnClick="hrAppraisalLinkBtn_Click">Appraisal</asp:LinkButton>
&nbsp;<asp:LinkButton ID="hrPromotionLinkBtn" runat="server" Font-Bold="True" Font-Size="12pt" OnClick="hrPromotionLinkBtn_Click">Promotion</asp:LinkButton>
&nbsp;<asp:LinkButton ID="hrRetirementLinkBtn" runat="server" Font-Bold="True" Font-Size="12pt" OnClick="hrRetirementLinkBtn_Click">Retirement</asp:LinkButton>
        </td>
        
    </tr>
</table>

