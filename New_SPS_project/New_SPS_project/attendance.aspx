<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="attendance.aspx.cs" Inherits="New_SPS_project.attendance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
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
            margin-left: 0px;
            margin-right: 180px;
        }
        .auto-style7 {
            margin-left: 0px;
            width: auto;
        }
        .auto-style8 {
            margin-right: 118px;
        }
        .auto-style9 {
            text-align: left;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style3">
            
        <div class="auto-style9">
             <asp:LinkButton ID="LinkButton2"  runat="server" OnClick="LinkButton2_Click" PostBackUrl="~/facultydashboard.aspx" >Back</asp:LinkButton>
        </div>
       <br />
            <br />
           
        <div class="auto-style3">
            <em><strong><span class="auto-style4">STUDENT ATTENDANCE</span><br class="auto-style4" />
                
            <br />
            <br />
                
            </strong></em>
            </div>
            <em><strong><span class="auto-style4"> Select Course </span><br class="auto-style4" />
            <br />
            </strong></em>
                
            <asp:DropDownList ID="DropDownList2" runat="server" DataTextField="course" DataValueField="course" Height="53px" Width="399px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" CssClass="auto-style5" BackColor="#CCCCCC">
                <asp:ListItem>.Net</asp:ListItem>
                <asp:ListItem>Java</asp:ListItem>
                <asp:ListItem>Python</asp:ListItem>
            </asp:DropDownList>
                        <br />
                        <br />
                        <br />
            
               <em>
<strong>               <span></span>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           Select Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                                                                                                                                                                                                                                                                                                                                                   
    </strong>                       
    </em> <asp:TextBox ID="TextBox1" runat="server" TextMode="Date" Width="162px" OnTextChanged="TextBox1_TextChanged" AutoPostBack="True" CssClass="auto-style5"></asp:TextBox>
                    &nbsp;
                                          <asp:Label ID="Label1" runat="server" Text='<%# Eval("Date", "{0:d MMM yyyy HH:mm}") %>' BorderStyle="Inset"></asp:Label>
                            <br />
                            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="Mark Attendance" OnClick="Button1_Click" Width="345px" BackColor="#99FFCC" Height="38px" />
                                          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Check Attendance" CssClass="auto-style8" Width="321px" BackColor="#99FFCC" Height="38px" />
                            &nbsp;&nbsp;
                            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                            <br />
                            <br />
                   
           
           
        <br />
            <div>
        <asp:GridView ID="GridView1"  runat="server" AutoGenerateColumns="False" CssClass="auto-style5" Width="1090px" CellPadding="3" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellSpacing="1">
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
                <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#594B9C" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#33276A" />
            </asp:GridView>
               <br />
            <br />
            <br />
           
             <div class="auto-style7">
           <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Save Attendance" Width="475px" BackColor="#99FFCC" CssClass="auto-style5" Height="41px" />
        </div>
            </div>
            
        <br />
               

            
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" CssClass="auto-style6" Width="1102px">
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
        <br />
        </div>
        </div>
    </form>
</body>
</html>
