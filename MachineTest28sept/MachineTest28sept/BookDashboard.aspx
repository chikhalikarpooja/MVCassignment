<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookDashboard.aspx.cs" Inherits="MachineTest28sept.BookDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            </div>
            <div class="auto-style2">
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Logout</asp:LinkButton>
        </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/AddBook.aspx">Add Book</asp:LinkButton>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/ListOfbooks.aspx">List Of Books</asp:LinkButton>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" ImageUrl="~/book2.jpg" Width="900px"/>    </form>
</body>
</html>
