<%@ Page Language="C#" AutoEventWireup="true" CodeFile="report_admin_detail.aspx.cs" Inherits="report_admin_product" %>

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
    
    </div>
    <table class="style1">
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
                <asp:Label ID="Label1" runat="server" Text=" Name"></asp:Label>
            </td>
            <td>
                <table class="style1">
                    <tr>
                        <td>
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                    DataTextField="name" DataValueField="uid" Height="16px" 
                    onselectedindexchanged="DropDownList2_SelectedIndexChanged" Width="160px">
                </asp:DropDownList>
                        </td>
                        <td>
                            <table class="style1">
                                <tr>
                                    <td>
                <asp:Label ID="Label6" runat="server" Text="View all Users"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" 
                                            oncheckedchanged="CheckBox1_CheckedChanged" />
                                    </td>
                                </tr>
                            </table>
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
                <asp:Label ID="Label7" runat="server" Text="Session" style="font-weight: 700"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" 
                    Height="22px" onselectedindexchanged="DropDownList3_SelectedIndexChanged" 
                    Width="157px">
                    <asp:ListItem>2016-2017</asp:ListItem>
                    <asp:ListItem>2017-2018</asp:ListItem>
                    <asp:ListItem>2018-2019</asp:ListItem>
                    <asp:ListItem>2019-2020</asp:ListItem>
                </asp:DropDownList>
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
                            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Exit" />
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
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:Label ID="Label4" runat="server" style="font-weight: 700" Text="Total Price"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
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
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
                <asp:GridView ID="GridView1" runat="server" 
        AutoGenerateColumns="False" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" >
                    <Columns>
                     
                     <asp:TemplateField HeaderText="PRODUCT ISSUED TO">
                        <ItemTemplate>
                        <asp:Label ID="l5" Text=<%# Eval("name") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="PRODUCT NAME">
                        <ItemTemplate>
                        <asp:Label ID="l2" Text=<%# Eval("pname") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="PRICE">
                        <ItemTemplate>
                        <asp:Label ID="l3" Text=<%# Eval("price") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="TOTAL QUANTITY">
                        <ItemTemplate>
                        <asp:Label ID="l4" Text=<%# Eval("totqty") %> runat="server"></asp:Label>
                        </ItemTemplate>
                    
                     </asp:TemplateField>
                      
                        <asp:TemplateField HeaderText="TOTAL PRICE">
                        <ItemTemplate>
                        <asp:Label ID="l4" Text=<%# Eval("totprice") %> runat="server"></asp:Label>
                        </ItemTemplate>
                    
                     </asp:TemplateField>
                      
                      
                    </Columns>
                </asp:GridView>
    </form>
</body>
</html>
