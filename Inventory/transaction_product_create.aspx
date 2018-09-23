<%@ Page Language="C#" AutoEventWireup="true" CodeFile="transaction_product_create.aspx.cs" Inherits="transaction_product_create" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 23px;
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
                <asp:Label ID="Label13" runat="server" Text="Purchase Id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
            &nbsp;
                <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
                </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Product Name"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                    DataTextField="name" DataValueField="product_id" Height="16px" 
                    onselectedindexchanged="DropDownList2_SelectedIndexChanged" Width="160px">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Transaction Id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label22" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Bill No."></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                </td>
            <td class="style2">
                <asp:Label ID="Label9" runat="server" Text="Vendor Name"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td class="style2">
                </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Purchase Date"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Label11" runat="server" Text="Quantity"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Label12" runat="server" Text="Price"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label23" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Label18" runat="server" Text="Old Quantity"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label19" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                </td>
            <td class="style2">
                <asp:Label ID="Label20" runat="server" Text="New Quantity"></asp:Label>
            </td>
            <td class="style2">
                <asp:Label ID="Label21" runat="server"></asp:Label>
            </td>
            <td class="style2">
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
                <table class="style1">
                    <tr>
                        <td>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Save" />
                        </td>
                        <td>
                            <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Exit" 
                                Width="54px" />
                        </td>
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
            <td>
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                    Text="Submit For Final Order" style="height: 26px" />
            </td>
            <td>
                <asp:Label ID="Label24" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
                <asp:GridView ID="GridView1" runat="server" 
        AutoGenerateColumns="False" onrowdeleting="GridView1_RowDeleting">
                    <Columns>
                        
                        <asp:TemplateField HeaderText="TRANSACTION ID">
                        <ItemTemplate>
                        <asp:Label ID="l2" Text=<%# Eval("tid") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="PRODUCT NAME">
                        <ItemTemplate>
                        <asp:Label ID="l3" Text=<%# Eval("product_NAME") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="BILL NO.">
                        <ItemTemplate>
                        <asp:Label ID="l4" Text=<%# Eval("bill_no") %> runat="server"></asp:Label>
                        </ItemTemplate>
                    
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="VENDOR NAME">
                        <ItemTemplate>
                        <asp:Label ID="l5" Text=<%# Eval("vendor_name") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        
                        <asp:TemplateField HeaderText="QUANTITY">
                        <ItemTemplate>
                        <asp:Label ID="l7" Text=<%# Eval("qty") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                         </asp:TemplateField>
                        <asp:TemplateField HeaderText="PRICE">
                        <ItemTemplate>
                        <asp:Label ID="l9" Text=<%# Eval("price") %> runat="server"></asp:Label>
                        </ItemTemplate>
                         </asp:TemplateField>
                         <asp:TemplateField HeaderText="TOTAL PRICE">
                        <ItemTemplate>

                        <asp:Label ID="l10" Text=<%# Eval("total_price") %> runat="server"></asp:Label>
                        </ItemTemplate>
                         </asp:TemplateField>
                        <asp:TemplateField HeaderText="STATUS">
                        <ItemTemplate>
                        <asp:Label ID="l11" Text=<%# Eval("status") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
                    </Columns>
                </asp:GridView>
    </form>
</body>
</html>
