<%@ Page Language="C#" AutoEventWireup="true" CodeFile="User_delete.aspx.cs" Inherits="User_delete" %>

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
    <br />
    <table class="style1">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Exit" 
                    Width="50px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <br />
    <br />
                <asp:GridView ID="GridView1" runat="server" 
        AutoGenerateColumns="False" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" 
        onrowdeleted="GridView1_RowDeleted" onrowdeleting="GridView1_RowDeleting">
                    <Columns>
                        <asp:TemplateField HeaderText="USER TYPE">
                        <ItemTemplate>
                        <asp:Label ID="l1" Text=<%# Eval("user_type") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="USER ID">
                        <ItemTemplate>
                        <asp:Label ID="l2" Text=<%# Eval("uid") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="NAME">
                        <ItemTemplate>
                        <asp:Label ID="l3" Text=<%# Eval("name") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="DEPARTMENT">
                        <ItemTemplate>
                        <asp:Label ID="l4" Text=<%# Eval("department") %> runat="server"></asp:Label>
                        </ItemTemplate>
                    
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="DESIGNATION">
                        <ItemTemplate>
                        <asp:Label ID="l5" Text=<%# Eval("designation") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="CONTACT NO">
                        <ItemTemplate>
                        <asp:Label ID="l6" Text=<%# Eval("contact_no") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="EMAIL ID">
                        <ItemTemplate>
                        <asp:Label ID="l7" Text=<%# Eval("email_id") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                         </asp:TemplateField>
                        <asp:TemplateField HeaderText="PASSWORD">
                        <ItemTemplate>
                        <asp:Label ID="l8" Text=<%# Eval("pwd") %> runat="server"></asp:Label>
                        </ItemTemplate>


                        </asp:TemplateField>
                        <asp:CommandField ButtonType="Button" HeaderText="DELETE" 
                            ShowDeleteButton="True" ShowHeader="True" />
                    </Columns>
                </asp:GridView>
    </form>
</body>
</html>
