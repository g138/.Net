<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Requisition_view.aspx.cs" Inherits="User_view" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <table class="style1">
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Exit" 
                        Width="54px" />
                </td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
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
                <td>
                    <table class="style1">
                        <tr>
                            <td>
                    <asp:Label ID="Label2" runat="server" Text="Total Price"></asp:Label>
                            </td>
                            <td>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <br />
    
    </div>
                <asp:GridView ID="GridView1" runat="server" 
        AutoGenerateColumns="False" onrowdeleting="GridView1_RowDeleting" 
        onselectedindexchanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:TemplateField HeaderText="REQUISITION ID">
                        <ItemTemplate>
                        <asp:Label ID="l1" Text=<%# Eval("REQ_ID") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="DATE">
                        <ItemTemplate>
                        <asp:Label ID="l2" Text=<%# Eval("DATE") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="TOTAL PRICE">
                        <ItemTemplate>
                        <asp:Label ID="l3" Text=<%# Eval("total_price") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="STATUS">
                        <ItemTemplate>
                        <asp:Label ID="l4" Text=<%# Eval("status") %> runat="server"></asp:Label>
                        </ItemTemplate>
                    
                        </asp:TemplateField>
                        
                        <asp:CommandField DeleteText="Detail" HeaderText="Detail" 
                            ShowDeleteButton="True" />
                      <asp:CommandField  SelectText="Print" HeaderText="Print" 
                            ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
    </form>
</body>
</html>
