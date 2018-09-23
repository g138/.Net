<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Product_delete.aspx.cs" Inherits="Product_delete" %>

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
    <form id="form2" runat="server">
    <div>
    
        <br />
        <table class="style1">
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Exit" 
                        Width="55px" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
    
    </div>
    <table class="style1">
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    onrowdeleting="GridView1_RowDeleting" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:TemplateField HeaderText="PRODUCT ID">
                        <ItemTemplate>
                        <asp:Label ID="l1" Text=<%# Eval("product_id") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="NAME">
                        <ItemTemplate>
                        <asp:Label ID="l2" Text=<%# Eval("name") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="COMPANY NAME">
                        <ItemTemplate>
                        <asp:Label ID="l3" Text=<%# Eval("company_name") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="INITIAL QUANTITY">
                        <ItemTemplate>
                        <asp:Label ID="l4" Text=<%# Eval("initial_qty") %> runat="server"></asp:Label>
                        </ItemTemplate>
                    
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="DATE">
                        <ItemTemplate>
                        <asp:Label ID="l5" Text=<%# Eval("date") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="MINIMUM QUANTITY">
                        <ItemTemplate>
                        <asp:Label ID="l6" Text=<%# Eval("min_qty") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="REMARKS">
                        <ItemTemplate>
                        <asp:Label ID="l7" Text=<%# Eval("remarks") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>

                         <asp:TemplateField HeaderText="PRICE">
                        <ItemTemplate>
                        <asp:Label ID="l8" Text=<%# Eval("price") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        <asp:CommandField ButtonType="Button" HeaderText="DELETE" 
                            ShowDeleteButton="True" />
                    </Columns>
                </asp:GridView>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </form>
   
</body>
</html>
