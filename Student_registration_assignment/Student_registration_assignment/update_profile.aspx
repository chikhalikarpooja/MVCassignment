<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="update_profile.aspx.cs" Inherits="Student_registration_assignment.update_profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
<center>
        <div style="background-color:gainsboro" >
            <asp:TextBox ID="first_nametxt" runat="server" Width="250"></asp:TextBox>
            <br />
            <asp:TextBox ID="middle_nametxt" runat="server" Width="250"></asp:TextBox>
            <br />
            <asp:TextBox ID="last_nametxt" runat="server" OnTextChanged="last_nametxt_TextChanged" Width="250"></asp:TextBox>
            <br />
            <asp:TextBox ID="gender_txt" runat="server" Width="250"></asp:TextBox>
            <br />
            <asp:TextBox ID="dob_txt" runat="server" Width="250"></asp:TextBox>
            <br />
            <asp:TextBox ID="phonenumber_txt" runat="server" Width="250"></asp:TextBox>
            <br />
            <asp:TextBox ID="caddresstxt" runat="server" Width="250"></asp:TextBox>
            <br />
            <asp:TextBox ID="paddresstxt" runat="server" Width="250"></asp:TextBox>
            <br />
            <asp:TextBox ID="pincodetxt" runat="server" Width="250"></asp:TextBox>
            <br />
            <asp:TextBox ID="xthmarkstxt" runat="server" Width="250"></asp:TextBox>
            <br />
            <asp:TextBox ID="xiithmarkstxt" runat="server" Width="250"></asp:TextBox>
            <br />
            <asp:TextBox ID="category_txt" runat="server" Width="250"></asp:TextBox>
            <br />
            <asp:TextBox ID="stream_txt" runat="server" Width="250"></asp:TextBox>
            <br />
            <asp:TextBox ID="course_txt" runat="server" Width="250"></asp:TextBox>
            <br />
            <asp:TextBox ID="email_txt" runat="server" Width="250"></asp:TextBox>
            <br />
            <asp:TextBox ID="password_txt" runat="server" Width="250"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />
        </div>
    </center>
    </form>
</body>
</html>
