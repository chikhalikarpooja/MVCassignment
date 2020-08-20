<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Student_registration_assignment.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 104%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
            width: 308px;
        }
        .auto-style4 {
            width: 308px;
        }
        .auto-style5 {
            height: 21px;
            width: 308px;
        }
        .auto-style6 {
            height: 21px;
        }
        .auto-style7 {
            height: 23px;
            text-align: center;
        }
        .txtbox
        {
            border-top-left-radius: 20px;
            border-top-right-radius: 20px;
            border-bottom-left-radius: 20px;
            border-bottom-right-radius: 20px;
        }
        .auto-style8 {
            width: 308px;
            height: 34px;
        }
        .auto-style9 {
            height: 34px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1" style="background-color:darkgray">
                <tr>
                    <td colspan="2">Register Yourself&nbsp; First..!!</td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label1" runat="server" Text="First_Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Width="210px" Height="20px" CssClass="txtbox" BorderColor="#CC99FF"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Required Name" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label2" runat="server" Text="Middle Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Width="210px" Height="20px" CssClass="txtbox" BorderColor="#CC99FF"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label3" runat="server" Text="Last name" ></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" Width="210px" Height="20px" CssClass="txtbox" BorderColor="#CC99FF"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required Last Name" Font-Italic="True" ForeColor="Red" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label>
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="r1" Text="Male" />
                        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="r1" Text="Female" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label5" runat="server" Text="DOB"></asp:Label>
                    </td>
                    <td><asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged" CssClass="txtbox" TextMode="Date" Width="210px" Height="20px" AutoPostBack="True" BorderColor="#CC99FF"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
                        Age in Number&nbsp;
                        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label7" runat="server" Text="Phone Number"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox5" runat="server" Width="210px" Height="20px" CssClass="txtbox" BorderColor="#CC99FF"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please Enter Correct Phone Number" Font-Italic="True" ForeColor="Red" ValidationExpression="[0-9]{10}" ControlToValidate="TextBox5"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label8" runat="server" Text="Corespond Address"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox6" runat="server" Width="210px" Height="20px" CssClass="txtbox" TextMode="MultiLine" OnTextChanged="TextBox6_TextChanged" BorderColor="#CC99FF"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox6" ErrorMessage="Address Required" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label9" runat="server" Text="Permanat Address"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server" CssClass="txtbox" OnTextChanged="TextBox7_TextChanged" Width="210px" Height="20px" TextMode="MultiLine" BorderColor="#CC99FF"></asp:TextBox>
                    &nbsp;
                        <asp:Label ID="Label14" runat="server" Text="Pin code"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox11" runat="server" Width="210px" Height="20px" OnTextChanged="TextBox11_TextChanged" CssClass="txtbox" BorderColor="#CC99FF"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label15" runat="server" Text="Xth Marks"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox12" runat="server" CssClass="txtbox" Width="210px" Height="20px" OnTextChanged="TextBox12_TextChanged" BorderColor="#CC99FF"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox12" ErrorMessage="Required Xth Marks" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label16" runat="server" Text="XII th Marks"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox13" runat="server" Width="210px" Height="20px" CssClass="txtbox" OnTextChanged="TextBox13_TextChanged" BorderColor="#CC99FF"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox13" ErrorMessage="Required XIIth Marks" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label17" runat="server" Text="Category"></asp:Label>
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton7" runat="server" GroupName="r3" Text="Open" />
                        <asp:RadioButton ID="RadioButton8" runat="server" GroupName="r3" Text="OBC" />
                        <asp:RadioButton ID="RadioButton9" runat="server" GroupName="r3" Text="Sc" />
                        <asp:RadioButton ID="RadioButton10" runat="server" GroupName="r3" Text="Other" AutoPostBack="True" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label10" runat="server" Text="Stream "></asp:Label>
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="r2" Text="Computer/IT" OnCheckedChanged="RadioButton3_CheckedChanged" />
                        <asp:RadioButton ID="RadioButton4" runat="server" GroupName="r2" OnCheckedChanged="RadioButton4_CheckedChanged" Text="Electronics" />
                        <asp:RadioButton ID="RadioButton5" runat="server" GroupName="r2" OnCheckedChanged="RadioButton5_CheckedChanged" Text="Civil" />
                        <asp:RadioButton ID="RadioButton6" runat="server" GroupName="r2" Text="Mechanical" OnCheckedChanged="RadioButton6_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Select Course</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1"  runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                           
                            <asp:ListItem>Select Course</asp:ListItem>
                            <asp:ListItem>.Net</asp:ListItem>
                            <asp:ListItem>Android</asp:ListItem>
                            <asp:ListItem>Java</asp:ListItem>
                            <asp:ListItem>Python</asp:ListItem>
                            <asp:ListItem>Php</asp:ListItem>
                        </asp:DropDownList>
                        
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label11" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBox8" runat="server" Width="210px" Height="20px" CssClass="txtbox" BorderColor="#CC99FF"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox8" ErrorMessage="Please Enter Valid Email id" Font-Italic="True" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label12" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:TextBox ID="TextBox9" runat="server" TextMode="Password" Width="210px" Height="20px" CssClass="txtbox" BorderColor="#CC99FF"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox9" ErrorMessage="Password Required" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label13" runat="server" Text="Confirm Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox10" runat="server" Width="210px" Height="20px" OnTextChanged="TextBox10_TextChanged" CssClass="txtbox" BorderColor="#CC99FF"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox9" ControlToValidate="TextBox10" ErrorMessage="Password Does Not Match" Font-Italic="True" ForeColor="Red"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style7" colspan="2">
                        <asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Log in" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
