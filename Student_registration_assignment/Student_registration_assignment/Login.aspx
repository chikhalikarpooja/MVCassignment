<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Student_registration_assignment.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 404px;
        }
        .auto-style3 {
            width: 404px;
            height: 17px;
            text-align: center;
        }
        .auto-style4 {
            height: 17px;
            text-align: left;
        }
        .auto-style5 {
            text-align: center;
        }
        .auto-style6 {
            width: 404px;
            text-align: center;
        }
        .auto-style7 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style5">
            <div class="auto-style5">
            <br />
                Login Yourself First..!!
            <br />

            </div>
            <br />
           <br />
            <div class="auto-style7">
            </div>

        </div>

            <table class="auto-style1">
                <tr><br />
                        <br />
                        <br />
                    <td class="auto-style6">
                        
                        <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBox1" runat="server" Width="221px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox2" runat="server" Width="215px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5" colspan="2">
                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" style="height: 26px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
    </form>
</body>
</html>
