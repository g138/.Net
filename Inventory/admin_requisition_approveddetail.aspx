<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin_requisition_approveddetail.aspx.cs" Inherits="admin_requisition_update" %>

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
                        Width="53px" />
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
            </tr>
        </table>
        <br />
        <br />
        <br />
    
    </div>
                <asp:GridView ID="GridView1" runat="server" 
        AutoGenerateColumns="False" onrowdeleting="GridView1_RowDeleting">
                    <Columns>

                     <asp:TemplateField HeaderText="TRANSACTION ID">
                        <ItemTemplate>
                        <asp:Label ID="l5" Text=<%# Eval("trans_ID") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="PRODUCT NAME">
                        <ItemTemplate>
                        <asp:Label ID="l1" Text=<%# Eval("name") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="QUANTITY">
                        <ItemTemplate>
                        <asp:Label ID="l2" Text=<%# Eval("qty") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="PRICE">
                        <ItemTemplate>
                        <asp:Label ID="l3" Text=<%# Eval("price") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="TOTAL PRICE">
                        <ItemTemplate>
                        <asp:Label ID="l4" Text=<%# Eval("total_price") %> runat="server"></asp:Label>
                        </ItemTemplate>
                    
                        </asp:TemplateField>
                      
                        
                      
                    </Columns>
                </asp:GridView>
    </form>
</body>
</html>
