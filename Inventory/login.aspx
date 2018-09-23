<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 98%;
            height: 60px;
        }
        .style2
        {
            text-align: center;
        }
        .style4
        {
            width: 249px;
        }
        .style5
        {
        }
        .style10
        {
            width: 148px;
            text-align: center;
        }
        .style11
        {
            width: 117px;
        }
        .style12
        {
            width: 100%;
        }
    </style>
</head>


<body background="Images/bg2.jpg" style="font-weight: 700 ">

    <form id="form1" runat="server">
    <div>
    
    </div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    
    <table class="style1">
        <tr>
            <td>
    <table class="style1">
        <tr>
            <td class="style2" colspan="3">
                <asp:Label ID="Label5" runat="server" ForeColor="Black" Text="Login Form" 
                    style="font-size: xx-large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style10">
                &nbsp;</td>
            <td class="style11">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style10">
                &nbsp;</td>
            <td class="style11">
                <asp:Label ID="Label1" runat="server" Text="Username" ForeColor="Black" 
                    style="font-family: Arial, Helvetica, sans-serif"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="Enter Username">*</asp:RequiredFieldValidator>
            </td>
            <td class="style4">
                <asp:TextBox ID="TextBox1" runat="server" Width="137px" 
                    ontextchanged="TextBox1_TextChanged"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td class="style10">
                &nbsp;</td>
            <td class="style11">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style10">
                &nbsp;</td>
            <td class="style11">
                <asp:Label ID="Label2" runat="server" Text="Password" ForeColor="Black" 
                    style="font-family: Arial, Helvetica, sans-serif"></asp:Label>
            </td>
            <td class="style4">
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="137px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style10">
    <asp:Label ID="Label4" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
            <td class="style5" colspan="2">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="style2" colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" colspan="3">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Text="Login" onclick="Button1_Click" 
                    Font-Bold="True" Height="34px" 
                    style="text-align: center; font-family: Arial, Helvetica, sans-serif" 
                    Width="75px" />
            </td>
        </tr>
        <tr>
            <td class="style2" colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" colspan="3">
                <table class="style12">
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:Label ID="Label7" runat="server"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="Label6" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
            </td>
        </tr>
        </table>
            </td>
            <td>
                <img alt="" src="Photos/login.jpg" style="width: 331px; height: 197px" /></td>
        </tr>
    </table>
    <p>
        <table class="style1">
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
      
        </p>
    </form>
    
    
</body>
</html>
