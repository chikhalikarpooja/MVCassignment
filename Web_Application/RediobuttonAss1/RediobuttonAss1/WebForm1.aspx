<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RediobuttonAss1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 34%;
            background-color: #FF5050;
        }
        .auto-style2 {
            height: 44px;
            background-color: #CCCCCC;
        }
        .auto-style3 {
            text-align: center;
            font-size: xx-large;
        }
        .auto-style4 {
            font-size: small;
        }
        .auto-style5 {
            height: 25px;
            background-color: #CCCCCC;
        }
        .auto-style6 {
            height: 49px;
            background-color: #CCCCCC;
        }
        .auto-style7 {
            height: 26px;
            background-color: #CCCCCC;
        }
        .auto-style8 {
            background-color: #CCCCCC;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style3">
            <strong>Kaun Banega Hajarpati</strong></div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style6"><span>&nbsp;Who is the prime minister of India ?</span><br class="auto-style4" />
                    &nbsp;<asp:RadioButton ID="RadioButton1" runat="server" Text="Narendra Modi" GroupName="r1" />
&nbsp;<asp:RadioButton ID="RadioButton2" runat="server" Text="Rahul Gandhi" GroupName="r1" />
                    <span class="auto-style4">&nbsp;</span></td>
            </tr>
            <tr>
                <td class="auto-style2">What is capital of India ?<br />
                    <asp:RadioButton ID="RadioButton3" runat="server" Text="Mumbai" GroupName="r2" />
&nbsp;&nbsp;
                    <asp:RadioButton ID="RadioButton4" runat="server" Text="Delhi" GroupName="r2" />
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Who is the founder of Microsoft ?</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:RadioButton ID="RadioButton5" runat="server" Text="Bill Gates" GroupName="r3" />
&nbsp;
                    <asp:RadioButton ID="RadioButton6" runat="server" Text="Mark_Zukerberg" GroupName="r3" />
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Which country introduce corona_virus (covid-19) ?</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:RadioButton ID="RadioButton7" runat="server" Text="China" GroupName="r4" />
&nbsp;&nbsp;
                    <asp:RadioButton ID="RadioButton8" runat="server" Text="Italy" GroupName="r4" />
                </td>
            </tr>
        </table>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        <asp:Label ID="Label1" runat="server" Text="Total Marks"></asp:Label>
    </form>
</body>
</html>
