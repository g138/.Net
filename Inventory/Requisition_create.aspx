<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Requisition_create.aspx.cs" Inherits="Product_create" %>

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
            width: 194px;
        }
        .style3
        {
            width: 55px;
        }
        .style4
        {
            height: 23px;
        }
        .style5
        {
            width: 194px;
            height: 23px;
        }
        .style6
        {
            height: 26px;
        }
        .style7
        {
            width: 194px;
            height: 26px;
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
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Label9" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style2">
                <asp:Label ID="Label1" runat="server" 
                    style="font-weight: 700; text-decoration: underline" 
                    Text="Create New User"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Label10" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style2">
                <asp:Label ID="Label19" runat="server" Text="Session"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" 
                    Height="22px"  Width="157px">
                    <asp:ListItem>2016-2017</asp:ListItem>
                    <asp:ListItem>2017-2018</asp:ListItem>
                    <asp:ListItem>2018-2019</asp:ListItem>
                    <asp:ListItem>2019-2020</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style2">
                <asp:Label ID="Label2" runat="server" Text="Order Category"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                    <asp:ListItem>General</asp:ListItem>
                    <asp:ListItem>Admission</asp:ListItem>
                    <asp:ListItem>College Function</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style2">
                <asp:Label ID="Label3" runat="server" Text="Reqisition ID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="270px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                </td>
            <td class="style7">
                <asp:Label ID="Label4" runat="server" Text="Purpose"></asp:Label>
            </td>
            <td class="style6">
                <asp:TextBox ID="TextBox3" runat="server" Width="270px"></asp:TextBox>
            </td>
            <td class="style6">
                </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style2">
                <asp:Label ID="Label5" runat="server" Text="Date"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" Width="270px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                </td>
            <td class="style7">
                <asp:Label ID="Label6" runat="server" Text="Product Name"></asp:Label>
            </td>
            <td class="style6">
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                    DataTextField="name" DataValueField="product_id" Height="16px" 
                    onselectedindexchanged="DropDownList2_SelectedIndexChanged" Width="160px">
                </asp:DropDownList>
            </td>
            <td class="style6">
                <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
                </td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style7">
                <asp:Label ID="Label11" runat="server" Text="Qty Available"></asp:Label>
            </td>
            <td class="style6">
                <asp:TextBox ID="TextBox8" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="style6">
                <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style2">
                <asp:Label ID="Label7" runat="server" Text="Quantity Required"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server" Width="270px"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style2">
                <asp:Label ID="Label8" runat="server" Text="Price"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server" Width="270px" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                </td>
            <td class="style5">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td class="style4">
                </td>
        </tr>
        <tr>
            <td>
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
                            <asp:Button ID="Button2" runat="server" Text="Exit" onclick="Button2_Click" />
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
            <td>
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style2">
                <table class="style1">
                    <tr>
                        <td>
                <asp:Label ID="Label12" runat="server" Text="Total Price" style="font-weight: 700" 
                                Width="99px"></asp:Label>
                        </td>
                        <td>
                <asp:Label ID="Label13" runat="server" Width="120px"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                            <asp:Button ID="Button3" runat="server" Text="Submit Final Order" 
                    onclick="Button3_Click" />
                            <br />
                        </td>
            <td>
                <asp:Label ID="Label18" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
                <asp:GridView ID="GridView1" runat="server" 
        AutoGenerateColumns="False" onrowdeleting="GridView1_RowDeleting">
                    <Columns>
                        <asp:TemplateField HeaderText="TRANSACTION ID">
                        <ItemTemplate>
                        <asp:Label ID="l1" Text=<%# Eval("trans_id") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        </asp:TemplateField>

                       
                        
                      
                        <asp:TemplateField HeaderText="PRODUCT NAME">
                        <ItemTemplate>
                        <asp:Label ID="l3" Text=<%# Eval("name") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="QUANTITY">
                        <ItemTemplate>
                        <asp:Label ID="l4" Text=<%# Eval("qty") %> runat="server"></asp:Label>
                        </ItemTemplate>
                    
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="PRICE">
                        <ItemTemplate>
                        <asp:Label ID="l5" Text=<%# Eval("price") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="TOTAL PRICE">
                        <ItemTemplate>
                        <asp:Label ID="l6" Text=<%# Eval("total_price") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                       
                        <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
                       
                    </Columns>
                </asp:GridView>
    </form>
</body>
</html>
