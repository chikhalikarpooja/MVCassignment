<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student_dashboard.aspx.cs" Inherits="Student_registration_assignment.student_dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            hi i am student here&nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Logout</asp:LinkButton>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        <br />
        <br />
        <br />
        <br />
        <div>
        <p>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Student Details</asp:LinkButton>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" PostBackUrl="~/Student_Profile.aspx">My Profile</asp:LinkButton>
        </p>
            </div>
    </form>
</body>
</html>
