<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SupervisorPage.ascx.cs" Inherits="Bilikis.HRManagementSystem.SupervisorPage" %>
<style type="text/css">
    .auto-style3 {
        width: 455px;
    }
    .auto-style7 {
        width: 264px;
    }
    .auto-style8 {
        width: 552px;
    }
    .auto-style9 {
        width: 257px;
    }
    .auto-style10 {
        width: 429px;
    }
    .auto-style12 {
        width: 529px;
    }
    .auto-style13 {
        width: 174px;
        height: 26px;
    }
    .auto-style14 {
        height: 23px;
    }
</style>


<table style="width:100%;">
    <tr>
        <td style="width:150px; valign:top;" >
            <table style="width:100%; valign:top;">
                <tr>
                    <td>
                <asp:Button ID="supervisorAppraisalBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" Text="Appraisal " Width="150px"  Height="36px" style="font-size: medium; color: #CC3300" OnClick="supervisorAppraisalBtn_Click" />
                    </td>
                    
                </tr>
                <tr>
                    <td>
                <asp:Button ID="supervisorQueryBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" Text="Query" Width="150px" Height="35px" style="color: #CC3300; font-size: medium" OnClick="supervisorQueryBtn_Click" />
                    </td>
                    
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    
                </tr>
            </table>
        </td>
        <td valign="top"><asp:MultiView ID="MViewSupervisor" runat="server">
    <asp:View ID="View" runat="server">
        <table style="width: 100%; border: medium solid #CC3300; width:100%;">
        <tr>
            <td class="auto-style7">
                &nbsp;</td>
            <td class="auto-style8">
                <asp:Label ID="LbWelcom0" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="12pt" ForeColor="#CC0066" Text="Hey Supervisor! Please select the Module you want to use"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    </asp:View>
    <asp:View ID="ViewQueryPage" runat="server">
        <table style="border: medium solid #CC3300; width:100%;">
        <tr>
            <td colspan="4">
                <asp:Label ID="LbQuery" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" style="color: #CC3300" Text="Query Management"></asp:Label>
            </td>
        </tr>
            <tr>
                <td>
                    <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" style="font-weight: 700" Text="Click to Send Query" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14"></td>
                <td colspan="2" class="auto-style14">
                    <asp:Label ID="lblQueryIssueReport" runat="server"></asp:Label>
                </td>
                <td class="auto-style14"></td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="Label145" runat="server" style="font-weight: 700; color: #CC3300" Text="List of Issued Query"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:Panel ID="Panel2" runat="server">
                        <asp:GridView ID="GVSupervisorQuery" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" OnRowCommand="GVSupervisorQuery_RowCommand">
                            <Columns>
                                <asp:BoundField DataField="EmployeeNum" HeaderText="Employee Num" />
                                <asp:BoundField DataField="QueryReceivedByName" HeaderText="Employee Name" />
                                <asp:BoundField DataField="QueryTitle" HeaderText="Query Title" />
                                <asp:BoundField DataField="IssueDate" HeaderText="Issue Date" />
                                <asp:BoundField DataField="ResponseDate" HeaderText="Response Date" />
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="LinkButton22" runat="server" CommandArgument='<%#DataBinder.Eval(Container,"DataItem.QueryID")%>' CommandName="View">View</asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:Panel ID="PanelDiscipline" runat="server" Visible="False" Width="80%">
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
                                <td>&nbsp;</td>
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
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style14"><b>Issued Day</b></td>
                                <td class="auto-style14">
                                    <asp:Label ID="lblDisQueryIssueDay" runat="server" CssClass="auto-style183" style="color: #CC3300" Text="Label"></asp:Label>
                                </td>
                                <td class="auto-style14"><b></b></td>
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
                                <td>&nbsp;</td>
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
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td><b>Discipline Description</b></td>
                                <td>
                                    <asp:TextBox ID="txtDisciplineDescription" runat="server" Height="88px" TextMode="MultiLine" Width="241px"></asp:TextBox>
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
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</b></td>
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
                                    <asp:Button ID="btnSendDisciplined" runat="server" OnClick="btnSendDisciplined_Click" style="font-weight: 700" Text="Send" />
                                    &nbsp; </td>
                                <td>
                                    <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" style="font-weight: 700" Text="Close" />
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        <tr>
            <td colspan="4">
                <asp:Panel ID="PanelQuery" runat="server" Visible="False">
                    <table style="width:90%; margin-left:50px;">
                        <tr>
                            <td>&nbsp;</td>
                            <td colspan="2">
                                <asp:Label ID="Label144" runat="server" style="font-weight: 700; font-style: italic; color: #CC3300" Text="Please select the staff you want to query."></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="LbSupEmpID" runat="server" Font-Bold="True" Text="EmployeeNum"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="queryEmployeeList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="queryEmployeeList_SelectedIndexChanged" Width="250px">
                                    <asp:ListItem>---Please Select---</asp:ListItem>
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
                                <asp:Label ID="LbSupEmpID0" runat="server" Font-Bold="True" Text="Employee Name:"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblEmpName" runat="server" style="font-weight: 700"></asp:Label>
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
                                <asp:Label ID="LbSupEmpID1" runat="server" Font-Bold="True" Text="Department"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblEmpDept" runat="server" style="font-weight: 700"></asp:Label>
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
                                <asp:Label ID="Label29" runat="server" style="font-weight: 700" Text="Position"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblEmpPosition" runat="server" style="font-weight: 700"></asp:Label>
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
                                <asp:Label ID="LbSupEmpID2" runat="server" Font-Bold="True" Text="Level"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblEmpLevel" runat="server" style="font-weight: 700"></asp:Label>
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
                                <asp:Label ID="LbReason" runat="server" Font-Bold="True" Text="Query Title"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtQueryTitle" runat="server" OnTextChanged="txtQueryReason_TextChanged" Width="250px"></asp:TextBox>
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
                                <asp:Label ID="LbQueryDesc" runat="server" Font-Bold="True" Text="Query Description"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtQueryDesc" runat="server" Height="73px" TextMode="MultiLine" Width="250px"></asp:TextBox>
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
                                <asp:Label ID="Label28" runat="server" style="font-weight: 700" Text="Query Letter"></asp:Label>
                            </td>
                            <td>
                                <asp:FileUpload ID="QueryFileUpload" runat="server" />
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
                                <asp:Label ID="LbIssueDate" runat="server" Font-Bold="True" Text="Issue Date"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblQueryIssueDate" runat="server"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14"></td>
                            <td class="auto-style14"></td>
                            <td class="auto-style14"></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="LbIssueBy" runat="server" Font-Bold="True" Text="IssueBy"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblQueryIssuedBy" runat="server" Font-Bold="True" ForeColor="#FF6666"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>
                                <asp:Button ID="issueQueryBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="issueQueryBtn_Click" style="color: #CC3300" Text="Issue Query" />
                            </td>
                            <td>
                                <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="Close" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>

        <tr>
            <td class="auto-style13">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
        </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
    </table>
    </asp:View>
    <asp:View ID="ViewAppraisal" runat="server">
        <table style="width: 100%; border: medium solid #CC3300; width:100%;">
        <tr>
            <td class="auto-style3" colspan="4">
                <asp:Label ID="LbAppraisal" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Performance Appraisal Management" style="color: #CC3300"></asp:Label>
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
                <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="EmployeeID"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="appraisalEmployeeList" runat="server">
                    <asp:ListItem>---Please Select--</asp:ListItem>
                    <asp:ListItem>1 Afolabi Olamiposi</asp:ListItem>
                    <asp:ListItem>2 John Favour</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbSelfAppraisal" runat="server" Font-Bold="True" Text="Employee Self-Appraisal Score"></asp:Label>
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
                <asp:Label ID="LbEvaluator" runat="server" Font-Bold="True" Text=" Evaluator Name"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtEvaluatorName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbEvaluationPeriod" runat="server" Font-Bold="True" Text="Evaluation Period"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="evaluationPeriodList" runat="server">
                    <asp:ListItem>---Please Select---</asp:ListItem>
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
                <asp:Label ID="LbSupervisor" runat="server" Font-Bold="True" Text="Supervisor Name"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtSupervisorName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:Label ID="Label17" runat="server" Font-Bold="True" Text="Start Year of Service"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="DropDownList3" runat="server">
                    <asp:ListItem>---Please Select---</asp:ListItem>
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
                <asp:Label ID="LbAppraisal0" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Competency Factor Definitions" style="color: #CC3300"></asp:Label>
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
            <td>
                <asp:Label ID="LbConpetency" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Competency Rating Key"></asp:Label>
            </td>
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
            <td colspan="4">
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style33"></td>
                        <td class="auto-style12">
                            &nbsp;<asp:Label ID="LbPreformance" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Performance Factors"></asp:Label>
                        </td>
                        <td class="auto-style10">
                            &nbsp;<asp:Label ID="LbPreformanceRatingKey" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Performance Rating Key"></asp:Label>
                        </td>
                        <td class="auto-style9">
                            <asp:Label ID="LbPreformancePoint" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Point"></asp:Label>
                        </td>
                         <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style10">&nbsp;</td>
                        <td class="auto-style9">&nbsp;</td>
                         <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbQuality" runat="server" Font-Bold="True" Text="Quality of Work"></asp:Label>
                        </td>
                        <td class="auto-style10">
                            <asp:DropDownList ID="ratingKey1" runat="server">
                                <asp:ListItem>---Please Select---</asp:ListItem>
                                <asp:ListItem>Very Satisfactory</asp:ListItem>
                                <asp:ListItem>Satisfactory</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style9">
                            <asp:TextBox ID="txtratingPoint1" runat="server"></asp:TextBox>
                        </td>
                         <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style10">&nbsp;</td>
                        <td class="auto-style9">&nbsp;</td>
                         <td class="auto-style3"></td>
                    </tr>
                    <tr>
                         
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbProductivity" runat="server" Font-Bold="True" Text="Productivity"></asp:Label>
                        </td>
                        <td class="auto-style10">
                            <asp:DropDownList ID="ratingKey2" runat="server">
                                <asp:ListItem>---Please Select---</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style9">
                            <asp:TextBox ID="txtratingPoint2" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style3"></td>
                    </tr>
                     <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">
                            &nbsp;</td>
                        <td class="auto-style10">&nbsp;</td>
                        <td class="auto-style9">&nbsp;</td>
                         <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbKnowledge" runat="server" Font-Bold="True" Text="Knowledge of the Job"></asp:Label>
                        </td>
                        <td class="auto-style10">
                            <asp:DropDownList ID="ratingKey3" runat="server">
                                <asp:ListItem>---Please Select---</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style9">
                            <asp:TextBox ID="txtratingPoint3" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style10">&nbsp;</td>
                        <td class="auto-style9">&nbsp;</td>
                        <td class="auto-style3"></td>
                    </tr>
                     <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbAdability" runat="server" Font-Bold="True" Text="Adaptability"></asp:Label>
                        </td>
                        <td class="auto-style10">
                            <asp:DropDownList ID="ratingKey4" runat="server">
                                <asp:ListItem>---Please Select---</asp:ListItem>
                            </asp:DropDownList>
                         </td>
                        <td class="auto-style9">
                            <asp:TextBox ID="txtratingPoint4" runat="server"></asp:TextBox>
                         </td>
                         <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style10">&nbsp;</td>
                        <td class="auto-style9">&nbsp;</td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbDependability" runat="server" Font-Bold="True" Text="Dependability"></asp:Label>
                        </td>
                        <td class="auto-style10">
                            <asp:DropDownList ID="ratingKey5" runat="server">
                                <asp:ListItem>---Please Select---</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style9">
                            <asp:TextBox ID="txtratingPoint5" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style10">&nbsp;</td>
                        <td class="auto-style9">&nbsp;</td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbInitiative" runat="server" Font-Bold="True" Text="Initiative &amp; Resourcefulness"></asp:Label>
                        </td>
                        <td class="auto-style10">
                            <asp:DropDownList ID="ratingKey6" runat="server">
                                <asp:ListItem>---Please Select---</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style9">
                            <asp:TextBox ID="txtratingPoint6" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style3"></td>
                    </tr>
                     <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">
                            &nbsp;</td>
                        <td class="auto-style10">&nbsp;</td>
                        <td class="auto-style9">&nbsp;</td>
                         <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbPolicyCompliance" runat="server" Font-Bold="True" Text="Judgment &amp; Policy Compliance"></asp:Label>
                        </td>
                        <td class="auto-style10">
                            <asp:DropDownList ID="ratingKey7" runat="server">
                                <asp:ListItem>---Please Select---</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style9">
                            <asp:TextBox ID="txtratingPoint7" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style10">&nbsp;</td>
                        <td class="auto-style9">&nbsp;</td>
                        <td class="auto-style3"></td>
                    </tr>
                     <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbInterpersonal" runat="server" Font-Bold="True" Text="Interpersonal Relations &amp; Customer Service"></asp:Label>
                        </td>
                        <td class="auto-style10">
                            <asp:DropDownList ID="ratingKey8" runat="server">
                                <asp:ListItem>---Please Select---</asp:ListItem>
                            </asp:DropDownList>
                         </td>
                        <td class="auto-style9">
                            <asp:TextBox ID="txtratingPoint8" runat="server"></asp:TextBox>
                         </td>
                         <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style10">&nbsp;</td>
                        <td class="auto-style9">&nbsp;</td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbAttendance" runat="server" Font-Bold="True" Text="Attendance &amp; Punctuality"></asp:Label>
                        </td>
                        <td class="auto-style10">
                            <asp:DropDownList ID="ratingKey9" runat="server">
                                <asp:ListItem>---Please Select---</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style9">
                            <asp:TextBox ID="txtratingPoint9" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style10">&nbsp;</td>
                        <td class="auto-style9">&nbsp;</td>
                        <td class="auto-style3"></td>
                    </tr>
                     <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbTeam" runat="server" Font-Bold="True" Text="Team Work"></asp:Label>
                        </td>
                        <td class="auto-style10">
                            <asp:DropDownList ID="ratingKey10" runat="server">
                                <asp:ListItem>---Please Select---</asp:ListItem>
                            </asp:DropDownList>
                         </td>
                        <td class="auto-style9">
                            <asp:TextBox ID="txtratingPoint10" runat="server"></asp:TextBox>
                         </td>
                         <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style10">&nbsp;</td>
                        <td class="auto-style9">&nbsp;</td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbCommunication" runat="server" Font-Bold="True" Text="Communication Skills"></asp:Label>
                        </td>
                        <td class="auto-style10">
                            <asp:DropDownList ID="ratingKey11" runat="server">
                                <asp:ListItem>---Please Select---</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style9">
                            <asp:TextBox ID="txtratingPoint11" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style10">&nbsp;</td>
                        <td class="auto-style9">&nbsp;</td>
                        <td class="auto-style3"></td>
                    </tr>
                     <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbPlanning" runat="server" Font-Bold="True" Text="Planning &amp; Organization"></asp:Label>
                        </td>
                        <td class="auto-style10">
                            <asp:DropDownList ID="ratingKey12" runat="server">
                                <asp:ListItem>---Please Select---</asp:ListItem>
                            </asp:DropDownList>
                         </td>
                        <td class="auto-style9">
                            <asp:TextBox ID="txtratingPoint12" runat="server"></asp:TextBox>
                         </td>
                         <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style10">&nbsp;</td>
                        <td class="auto-style9">&nbsp;</td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbLeadership" runat="server" Font-Bold="True" Text="Leadership Ability"></asp:Label>
                        </td>
                        <td class="auto-style10">
                            <asp:DropDownList ID="ratingKey13" runat="server">
                                <asp:ListItem>---Please Select---</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style9">
                            <asp:TextBox ID="txtratingPoint13" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style3"></td>
                    </tr>
                     <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style10">&nbsp;</td>
                        <td class="auto-style9">&nbsp;</td>
                         <td class="auto-style3"></td>
                    </tr>
                     <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbDevelopment" runat="server" Font-Bold="True" Text="Appraisal &amp; Development of People"></asp:Label>
                        </td>
                        <td class="auto-style10">
                            <asp:DropDownList ID="ratingKey14" runat="server">
                                <asp:ListItem>---Please Select---</asp:ListItem>
                            </asp:DropDownList>
                         </td>
                        <td class="auto-style9">
                            <asp:TextBox ID="txtratingPoint14" runat="server"></asp:TextBox>
                         </td>
                         <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td class="auto-style10">&nbsp;</td>
                        <td class="auto-style9">&nbsp;</td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Label ID="LbPoint" runat="server" Font-Bold="True" Text="Overall Rating/ Total Points"></asp:Label>
                        </td>
                        <td class="auto-style10">
                            <asp:TextBox ID="txtOverallRating" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style9">
                            <asp:TextBox ID="txtratingPoint15" runat="server"></asp:TextBox>
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
                        <td class="auto-style23"></td>
                        <td class="auto-style25">
                            <asp:Label ID="LbGoalDesc1" runat="server" Font-Bold="True" Text="Goal Description"></asp:Label>
                        </td>
                        <td class="auto-style29">
                            <textarea id="txtPreYearGoalDesc" cols="20" name="S2" rows="2"></textarea></td>
                        <td class="auto-style22"></td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style32">&nbsp;</td>
                        <td class="auto-style30">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style32">
                            <asp:Label ID="LbGoalDesc2" runat="server" Font-Bold="True" Text="Objective: Describe how the Goal was achieved"></asp:Label>
                        </td>
                        <td class="auto-style30">
                            <textarea id="txtPreYearGoalObjective" cols="20" name="S3" rows="2"></textarea></td>
                        <td>&nbsp;</td>
                    </tr>
                     <tr>
                         <td class="auto-style31">&nbsp;</td>
                         <td class="auto-style32">&nbsp;</td>
                         <td class="auto-style30">&nbsp;</td>
                         <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style32">
                            <asp:Label ID="LbGoalEvaluationPoint" runat="server" Font-Bold="True" Text="Evaluation Point"></asp:Label>
                        </td>
                        <td class="auto-style30">
                            <asp:TextBox ID="txtPreYearEvaluationPoint" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                     <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style32">&nbsp;</td>
                        <td class="auto-style30">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style32">
                            <asp:Label ID="LbCompDate" runat="server" Font-Bold="True" Text="Completion Date"></asp:Label>
                        </td>
                        <td class="auto-style30">
                            <asp:Calendar ID="preYearGoalCompletionDateCalendar" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
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
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style32">&nbsp;</td>
                        <td class="auto-style30">&nbsp;</td>
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
                        <td class="auto-style23"></td>
                        <td class="auto-style25">
                            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Goal Description"></asp:Label>
                        </td>
                        <td class="auto-style29">
                            <textarea id="txtNxtYearGoalDesc" cols="20" name="S2" rows="2"></textarea></td>
                        <td class="auto-style22"></td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style32">&nbsp;</td>
                        <td class="auto-style30">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style32">
                            <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Objective: Describe how the Goal was achieved"></asp:Label>
                        </td>
                        <td class="auto-style30">
                            <textarea id="txtNxtYearGoalObjective" cols="20" name="S3" rows="2"></textarea></td>
                        <td>&nbsp;</td>
                    </tr>
                     <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style32">&nbsp;</td>
                        <td class="auto-style30">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style32">
                            <asp:Label ID="LbGoalEvaluationPoint0" runat="server" Font-Bold="True" Text="Evaluation Point"></asp:Label>
                        </td>
                        <td class="auto-style30">
                            <asp:TextBox ID="txtNextYearEvaluationPoint0" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style32">&nbsp;</td>
                        <td class="auto-style30">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style32">
                            <asp:Label ID="Label11" runat="server" Font-Bold="True" Text="Completion Date"></asp:Label>
                        </td>
                        <td class="auto-style30">
                            <asp:Calendar ID="nxtYearCompletionDateCalendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
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
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style32">&nbsp;</td>
                        <td class="auto-style30">&nbsp;</td>
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
                <asp:Label ID="LbSupervisorAppraisalMark" runat="server" Font-Bold="True" Text="Direct Supervisor Appraisal Mark"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDirectSupAppraisalScore" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="LbExamScore" runat="server" Font-Bold="True" Text="Employee Promotion Exam/Interview Score"></asp:Label>
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
                <asp:Label ID="LbSupervisorName" runat="server" Font-Bold="True" Text="Direct Supervisor Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDirectSupName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="LbSupervisorComment" runat="server" Font-Bold="True" Text="Direct Supervisor's Comment"></asp:Label>
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
                <asp:Label ID="LbSupervisorName0" runat="server" Font-Bold="True" Text="Reviewer: (Next level of authority above the Direct Supervisor)"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtReviewerName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbSupervisorComment0" runat="server" Font-Bold="True" Text="Reviewer's Comment"></asp:Label>
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
            <td>
                <asp:Label ID="Label23" runat="server" Font-Bold="True" Text="Completion Date"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="Label20" runat="server" Font-Bold="True" Text="Completion Date"></asp:Label>
            </td>
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
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="appraisalBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Appraise" />
                &nbsp;
                <asp:Button ID="appraisalNextBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Next" />
                &nbsp;
                <asp:Button ID="appraisalBackBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="queryBtn_Click" Text="Back" />
            </td>
            <td class="auto-style3">
                <asp:Button ID="appraisalHomeBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="appraisalHomeBtn_Click" Text="Home" />
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
    <asp:View ID="View3" runat="server">
    </asp:View>
    <asp:View ID="View4" runat="server">
    </asp:View>
    <asp:View ID="View5" runat="server">
    </asp:View>
</asp:MultiView></td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>



