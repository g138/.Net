<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Mainuser.aspx.cs" Inherits="Mainuser" %>

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
        .style5
        {
            width: 116px;
        }
        .style2
        {
            width: 214px;
            height: 92px;
        }
        .style3
        {
            width: 179px;
            height: 88px;
        }
        .style6
        {
            width: 100%;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
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
                <table class="style6">
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="Welcome"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
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
                                src="Photos/place_order.jpg" /></td>
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
                            <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Requisition Form</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: left">
                            <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">View Requisition</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: left">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td style="text-align: left">
                            <asp:LinkButton ID="LinkButton4" runat="server" onclick="LinkButton4_Click">Delete Requisition</asp:LinkButton>
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
                            <img alt="" class="style3" src="Photos/reports.jpg" /></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Reports"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
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
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
            <td>
                <asp:LinkButton ID="LinkButton6" runat="server" onclick="LinkButton6_Click">Change Password</asp:LinkButton>
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
                            <asp:LinkButton ID="LinkButton5" runat="server" 
                    onclick="LinkButton5_Click">Log Out</asp:LinkButton>
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
                &nbsp;</td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
