<%@ Page Language="C#" AutoEventWireup="true" CodeFile="purchase_delete.aspx.cs" Inherits="User_view" %>

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
                    &nbsp;</td>
            </tr>
        </table>
        <br />
    
    </div>
                <asp:GridView ID="GridView1" runat="server" 
        AutoGenerateColumns="False" onrowdeleting="GridView1_RowDeleting">
                    <Columns>
                        <asp:TemplateField HeaderText="PURCHASE ID">
                        <ItemTemplate>
                        <asp:Label ID="l1" Text=<%# Eval("purchase_id") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="PURCHASE DATE">
                        <ItemTemplate>
                        <asp:Label ID="l2" Text=<%# Eval("purchase_date") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="TOTAL PRICE">
                        <ItemTemplate>
                        <asp:Label ID="l3" Text=<%# Eval("total_price") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="VENDOR NAME">
                        <ItemTemplate>
                        <asp:Label ID="l4" Text=<%# Eval("vendor_name") %> runat="server"></asp:Label>
                        </ItemTemplate>
                    
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="BILL No.">
                        <ItemTemplate>
                        <asp:Label ID="l5" Text=<%# Eval("bill_no") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        
                     
                        <asp:CommandField DeleteText="Delete" HeaderText="Delete" 
                            ShowDeleteButton="True" />
                        
                     
                    </Columns>
                </asp:GridView>
    </form>
</body>
</html>
