<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_Profile.aspx.cs" Inherits="Student_registration_assignment.Student_Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 800px;
              height:80px;
            
        }
        
        .auto-style2 {
            width: 135px;
        }
        .auto-style3 {
            width: 137px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Edit Profile" />
            <br />
            <br />
            <center>
           <table border="5" style="border-collapse: collapse" cellspacing="8"  class="auto-style1">

    <tr >

      <td height="16" align="left" class="auto-style2" ><b><font size="2" color="red">Name:</font></b></td>

      <td height="16" align="left" class="auto-style3" ><b><font size="2">&nbsp;<asp:Label

              ID="label2" runat="server" Font-Bold="True"></asp:Label><br /></font></b></td>

    </tr>

    <tr>

      <td height="16" align="left" class="auto-style2" ><b><font size="2" color="red">Middle Name:</font></b></td>

      <td height="16" align="left" class="auto-style3" ><b><font size="2">&nbsp;<asp:Label

              ID="middlelabel" runat="server" Font-Bold="True"></asp:Label><br /></font></b></td>

    </tr>
                <tr>

      <td height="16" align="left" class="auto-style2" ><b><font size="2" color="red">Last Name:</font></b></td>

      <td height="16" align="left" class="auto-style3" ><b><font size="2">&nbsp;<asp:Label

              ID="lastlabel" runat="server" Font-Bold="True"></asp:Label><br /></font></b></td>

    </tr>
                <tr>

      <td height="16" align="left" class="auto-style2" ><b><font size="2" color="red">Gender</font></b></td>

      <td height="16" align="left" class="auto-style3" ><b><font size="2">&nbsp;<asp:Label

              ID="genderlabel" runat="server" Font-Bold="True"></asp:Label><br /></font></b></td>

    </tr>
                <tr>

      <td height="16" align="left" class="auto-style2" ><b><font size="2" color="red">DOB:</font></b></td>

      <td height="16" align="left" class="auto-style3" ><b><font size="2">&nbsp;<asp:Label

              ID="doblabel" runat="server" Font-Bold="True"></asp:Label><br /></font></b></td>

    </tr>
               
                <tr>

      <td height="16" align="left" class="auto-style2" ><b><font size="2" color="red">Phone Number:</font></b></td>

      <td height="16" align="left" class="auto-style3" ><b><font size="2">&nbsp;<asp:Label

              ID="phonelabel" runat="server" Font-Bold="True"></asp:Label><br /></font></b></td>

    </tr>
               
                <tr>

      <td height="16" align="left" class="auto-style2" ><b><font size="2" color="red">Correspond&nbsp; Address:</font></b></td>

      <td height="16" align="left" class="auto-style3" ><b><font size="2">&nbsp;<asp:Label

              ID="c_addresslabel" runat="server" Font-Bold="True"></asp:Label><br /></font></b></td>

    </tr>
                <tr>

      <td height="16" align="left" class="auto-style2" ><b><font size="2" color="red">Permananat&nbsp; Address:</font></b></td>

      <td height="16" align="left" class="auto-style3" ><b><font size="2">&nbsp;<asp:Label

              ID="p_addresslabel" runat="server" Font-Bold="True"></asp:Label><br /></font></b></td>

    </tr>
                <tr>

      <td height="16" align="left" class="auto-style2" ><b><font size="2" color="red">Pincode:</font></b></td>

      <td height="16" align="left" class="auto-style3" ><b><font size="2">&nbsp;<asp:Label

              ID="pincodelabel" runat="server" Font-Bold="True"></asp:Label><br /></font></b></td>

    </tr>
                <tr>

      <td height="16" align="left" class="auto-style2" ><b><font size="2" color="red">Xth Marks:</font></b></td>

      <td height="16" align="left" class="auto-style3" ><b><font size="2">&nbsp;<asp:Label

              ID="xlabel" runat="server" Font-Bold="True"></asp:Label><br /></font></b></td>

    </tr>
                  <tr>

      <td height="16" align="left" class="auto-style2" ><b><font size="2" color="red">XIIth Marks:</font></b></td>

      <td height="16" align="left" class="auto-style3" ><b><font size="2">&nbsp;<asp:Label

              ID="xiilabel" runat="server" Font-Bold="True"></asp:Label><br /></font></b></td>

    </tr>
                  <tr>

      <td height="16" align="left" class="auto-style2" ><b><font size="2" color="red">Category:</font></b></td>

      <td height="16" align="left" class="auto-style3" ><b><font size="2">&nbsp;<asp:Label

              ID="catlabel" runat="server" Font-Bold="True"></asp:Label><br /></font></b></td>

    </tr>
                  <tr>

      <td height="16" align="left" class="auto-style2" ><b><font size="2" color="red">Stream:</font></b></td>

      <td height="16" align="left" class="auto-style3" ><b><font size="2">&nbsp;<asp:Label

              ID="streamlael" runat="server" Font-Bold="True"></asp:Label><br /></font></b></td>

    </tr>
                  <tr>

      <td height="16" align="left" class="auto-style2" ><b><font size="2" color="red">Course:</font></b></td>

      <td height="16" align="left" class="auto-style3" ><b><font size="2">&nbsp;<asp:Label

              ID="courselabel" runat="server" Font-Bold="True"></asp:Label><br /></font></b></td>

    </tr>
                  <tr>

      <td height="16" align="left" class="auto-style2" ><b><font size="2" color="red">Email:</font></b></td>

      <td height="16" align="left" class="auto-style3" ><b><font size="2">&nbsp;<asp:Label

              ID="emaillabel" runat="server" Font-Bold="True"></asp:Label><br /></font></b></td>

    </tr>
               </table>
                </center>
        </div>
    </form>
</body>
</html>
