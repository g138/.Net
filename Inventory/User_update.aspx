<%@ Page Language="C#" AutoEventWireup="true" CodeFile="User_update.aspx.cs" Inherits="User_update" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style1
        {
            width: 100%;
        }
        .style6
        {
            width: 22px;
        }
        .style2
        {
            width: 194px;
        }
        .style7
        {
            height: 23px;
            width: 22px;
        }
        .style5
        {
            width: 194px;
            height: 23px;
        }
        .style4
        {
            height: 23px;
        }
        .style3
        {
            width: 55px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <table class="style1">
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style2">
                <asp:Label ID="Label1" runat="server" 
                    style="font-weight: 700; text-decoration: underline" 
                    Text="Create New User"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style2">
                <asp:Label ID="Label2" runat="server" Text="User Type"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                    <asp:ListItem>Management</asp:ListItem>
                    <asp:ListItem>Admission</asp:ListItem>
                    <asp:ListItem>Academissions</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style2">
                <asp:Label ID="Label3" runat="server" Text="User ID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="270px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style2">
                <asp:Label ID="Label4" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Width="270px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style2">
                <asp:Label ID="Label5" runat="server" Text="Department"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" Width="270px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style2">
                <asp:Label ID="Label6" runat="server" Text="Designation"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" Width="270px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style2">
                <asp:Label ID="Label7" runat="server" Text="Contact No,"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server" Width="270px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style2">
                <asp:Label ID="Label8" runat="server" Text="Email ID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server" Width="270px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                </td>
            <td class="style5">
                <asp:Label ID="Label9" runat="server" Text="Passward"></asp:Label>
            </td>
            <td class="style4">
                <asp:TextBox ID="TextBox8" runat="server" Width="270px" 
                    ontextchanged="Page_Load"></asp:TextBox>
            </td>
            <td class="style4">
                </td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style2">
                <table class="style1">
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="View" />
                        </td>
                        <td>
                            <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Update" />
                        </td>
                        <td class="style3">
                            <asp:Button ID="Button2" runat="server" Text="Exit" onclick="Button2_Click" 
                                Width="55px" Height="20px" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td class="style3">
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
            <td>
                <asp:Label ID="Label10" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    
    </div>
    </form>
</body>
</html>
