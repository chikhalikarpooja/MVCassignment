﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="attendance.aspx.cs" Inherits="New_SPS_project.attendance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 45%;
        }
        .auto-style3 {
            text-align: center;
        }
        .auto-style4 {
            text-decoration: underline;
        }
        .auto-style5 {
            margin-left: 0px;
        }
        .auto-style6 {
            margin-left: 225px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style3">
        <div class="auto-style3">
            <em><strong><span class="auto-style4">STUDENT ATTENDANCE</span><br class="auto-style4" />
            </strong></em>
            <br />
            <span class="auto-style4"><strong>SELECT COURSE</strong></span><br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource1" DataTextField="course" DataValueField="course" Height="19px" Width="169px">
                <asp:ListItem>.Net</asp:ListItem>
                <asp:ListItem>Java</asp:ListItem>
                <asp:ListItem>Python</asp:ListItem>
            </asp:DropDownList>
            <hr />
            <br />
            <center>  
            <table class="auto-style1">
               
                <tr>
                                      <td class="auto-style3">
                                          Select Date<br />
                                          <br />
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox1" runat="server" TextMode="Date" Width="157px" OnTextChanged="TextBox1_TextChanged" AutoPostBack="True" CssClass="auto-style5"></asp:TextBox>
                    &nbsp;
                                          <br />
                                          <br />
        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Date", "{0:d MMM yyyy HH:mm}") %>' BorderStyle="Inset"></asp:Label>
                                          <br />
                                          <br />
&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" Text="Mark Attendance" OnClick="Button1_Click" />
                                          &nbsp;<br />
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:student_databaseConnectionString4 %>" SelectCommand="SELECT DISTINCT [course] FROM [Register_db]"></asp:SqlDataSource>
                                          <br />
                                          <br />
                    </td>
                      

                </tr>
            </table>
                </center>
        </div>
        <br />

        <br />
            <div class="auto-style3">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="auto-style6" Width="399px" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="first_name" HeaderText="First_Name" />
                    <asp:BoundField DataField="last_name" HeaderText="Last_Name" />
                    <asp:BoundField DataField="course" HeaderText="Course" />
                    <asp:TemplateField HeaderText="Attendance">
                        <ItemTemplate>
                            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="r1" Text="Absent" />
                            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="r1" Text="Present" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
                <br />
                <br />
            </div>
            <div>

            </div>
            &nbsp;<asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Save Attendance" Width="123px" />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="first_name" HeaderText="First_Name" />
                    <asp:BoundField DataField="last_name" HeaderText="Last_Name" />
                    <asp:BoundField DataField="course" HeaderText="Course" />
                    <asp:BoundField DataField="attendance" HeaderText="Attendance" />
                    <asp:BoundField DataField="date" HeaderText="Date" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="Gray" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
