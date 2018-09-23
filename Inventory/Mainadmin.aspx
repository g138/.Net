<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Mainadmin.aspx.cs" Inherits="Mainadmin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 85%;
            height: 60px;
        }
        .style2
        {
            width: 143px;
            height: 92px;
        }
        .style3
        {
            width: 179px;
            height: 88px;
        }
        .style4
        {
            width: 215px;
            height: 114px;
        }
        .style5
        {
            width: 116px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="style1">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <table class="style1">
                    <tr>
                        <td style="text-align: center">
                            <img alt="" class="style2" 
                                src="Photos/products.jpg" /></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Products"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td style="text-align: left">
                            <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Create Products</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: left">
                            <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">View Products</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: left">
                            <asp:LinkButton ID="LinkButton3" runat="server" onclick="LinkButton3_Click">Update Products</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: left">
                            <asp:LinkButton ID="LinkButton4" runat="server" onclick="LinkButton4_Click">Delete Products</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </td>
            <td class="style5">
                &nbsp;</td>
            <td>
                <table class="style1">
                    <tr>
                        <td>
                            <img alt="" class="style3" src="Photos/users.jpg" /></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Users"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:LinkButton ID="LinkButton5" runat="server" onclick="LinkButton5_Click">Create Users</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:LinkButton ID="LinkButton6" runat="server" onclick="LinkButton6_Click">View Users</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:LinkButton ID="LinkButton7" runat="server" onclick="LinkButton7_Click">Update Usrs</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:LinkButton ID="LinkButton8" runat="server" onclick="LinkButton8_Click">Delete Users</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;</td>
            <td>
                <table class="style1">
                    <tr>
                        <td>
                            <img alt="" class="style4" src="Photos/purchase.jpg" /></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Entry in Stock(Purchased)"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:LinkButton ID="LinkButton9" runat="server" onclick="LinkButton9_Click1">New Transaction</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:LinkButton ID="LinkButton10" runat="server" onclick="LinkButton10_Click">View Transaction</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:LinkButton ID="LinkButton11" runat="server">Update Transaction</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:LinkButton ID="LinkButton12" runat="server" onclick="LinkButton12_Click">Delete Transaction</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Image ID="Image1" runat="server" Height="93px" 
                    ImageUrl="Photos/accept.jpg" Width="151px" />
            </td>
            <td class="style5">
                &nbsp;</td>
            <td>
                <asp:Image ID="Image2" runat="server" Height="93px" 
                    ImageUrl="Photos/reports.jpg" Width="151px" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                            <asp:LinkButton ID="LinkButton14" runat="server" 
                    onclick="LinkButton14_Click">Detail/Acceptance</asp:LinkButton>
                        </td>
            <td class="style5">
                &nbsp;</td>
            <td>
                <asp:LinkButton ID="LinkButton16" runat="server" onclick="LinkButton16_Click">By Products</asp:LinkButton>
            </td>
            <td>
                &nbsp;</td>
            <td>
                <asp:LinkButton ID="LinkButton13" runat="server" onclick="LinkButton13_Click">Log Out</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                            <asp:LinkButton ID="LinkButton15" runat="server" 
                    onclick="LinkButton15_Click">Approved Requisitions</asp:LinkButton>
                        </td>
            <td class="style5">
                &nbsp;</td>
            <td>
                <asp:LinkButton ID="LinkButton17" runat="server" onclick="LinkButton17_Click">By User</asp:LinkButton>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                            &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
            <td>
                <asp:LinkButton ID="LinkButton18" runat="server" onclick="LinkButton18_Click">Detail Report</asp:LinkButton>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <div>
    
    </div>
    </form>
</body>
</html>
