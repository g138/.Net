<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Purchase_newentry.aspx.cs" Inherits="Photos_Purchase_newentry" %>

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
    
    </div>
    <table class="style1">
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style2">
                <asp:Label ID="Label1" runat="server" 
                    style="font-weight: 700; text-decoration: underline" 
                    Text="Add New Stock"></asp:Label>
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
                <asp:Label ID="Label2" runat="server" Text="Product Name"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                    DataTextField="name" DataValueField="product_id" Height="16px" 
                     Width="160px">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style2">
                <asp:Label ID="Label3" runat="server" Text="Bill No."></asp:Label>
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
                <asp:Label ID="Label4" runat="server" Text="Vendor Name"></asp:Label>
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
                <asp:Label ID="Label5" runat="server" Text="Purchase Date"></asp:Label>
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
                <asp:Label ID="Label6" runat="server" Text="Quantity"></asp:Label>
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
                <asp:Label ID="Label7" runat="server" Text="Price"></asp:Label>
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
                <table class="style1">
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Save" />
                        </td>
                        <td>
                            &nbsp;</td>
                        <td class="style3">
                            <asp:Button ID="Button2" runat="server" Text="Exit" onclick="Button2_Click" 
                                Width="55px" />
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
    </table>
    </form>
</body>
</html>
