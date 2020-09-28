<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MachineTest28sept.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-decoration: underline;
            color: #0066FF;
            font-size: medium;
            text-align: center;
        }
        .auto-style3 {
            width: 400px;
        }
        .auto-style4 {
            text-align: center;
        }
        .auto-style5 {
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1" style="background-color:darkgrey ; border:solid">            <tr>
                <td class="auto-style2" colspan="2"><strong><em>User Login</em></strong></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4" colspan="2">
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    <strong>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" CssClass="auto-style5" />
                    </strong>
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
