<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Rediobutton.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            margin-top: 18px;
        }
        .auto-style2 {
            text-align: center;
            color: #FF0066;
            text-decoration: underline;
            font-size: x-large;
        }
        .auto-style3 {
            width: 224px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style7 {
            height: 10px;
        }
        .auto-style8 {
            width: 224px;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <div class="auto-style2">
                <strong>Welcome to Nagpur Bank</strong></div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">Account Number</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Amount</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="Deposit" runat="server" GroupName="red" OnCheckedChanged="RadioButton1_CheckedChanged" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="Withdraw" runat="server" GroupName="red" OnCheckedChanged="Withdraw_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" Text="OK" Width="122px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Text="Total Balance "></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8"></td>
                    <td class="auto-style5"></td>
                </tr>
            </table>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
