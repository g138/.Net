<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Requisition_print.aspx.cs" Inherits="Requisition_print" %>

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
            width: 151px;
            height: 99px;
        }
        .style3
        {
            width: 174px;
        }
        .style4
        {
            width: 179px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:Panel id="pnlContents" runat = "server">
    <table class="style1">
        <tr>
            <td class="style3">
                <img alt="" class="style2" src="Photos/svi-logo.jpg" /></td>
            <td style="text-align: center">
                <asp:Label ID="Label1" runat="server" style="font-weight: 700" 
                    Text="Requisition Form" Font-Size="X-Large"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <table class="style1">
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                <asp:Label ID="Label2" runat="server" Text="Order Placed By" 
                    style="font-weight: 700"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label13" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                <asp:Label ID="Label4" runat="server" Text="Date" style="font-weight: 700"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label5" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                <asp:Label ID="Label6" runat="server" Text="Requistion No," 
                    style="font-weight: 700"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label7" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                <asp:Label ID="Label8" runat="server" Text="Total Amount" 
                    style="font-weight: 700"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label9" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <asp:DataList ID="DataList1" runat="server">
    <ItemTemplate>
    <table>
    <tr>
    <td>

    </td>
    <td>

    </td>
    
    </tr>
    
    </table>
    </ItemTemplate>
    </asp:DataList>
                <asp:GridView ID="GridView1" runat="server" 
        AutoGenerateColumns="False" 
        >
                    <Columns>
                     
                    

                        <asp:TemplateField HeaderText="PRODUCT NAME">
                        <ItemTemplate>
                        <asp:Label ID="l2" Text=<%# Eval("name") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="PRICE">
                        <ItemTemplate>
                        <asp:Label ID="l3" Text=<%# Eval("price") %> runat="server"></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="TOTAL QUANTITY">
                        <ItemTemplate>
                        <asp:Label ID="l4" Text=<%# Eval("qty") %> runat="server"></asp:Label>
                        </ItemTemplate>
                    
                     </asp:TemplateField>
                      
                        <asp:TemplateField HeaderText="TOTAL PRICE">
                        <ItemTemplate>
                        <asp:Label ID="l6" Text=<%# Eval("totAL_price") %> runat="server"></asp:Label>
                        </ItemTemplate>
                    
                     </asp:TemplateField>
                      
                      
                    </Columns>
                </asp:GridView>
    <table class="style1">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Status" style="font-weight: 700"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label11" runat="server" Text="Approved" style="font-weight: 700"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Label12" runat="server" 
                    Text=" NOTE: This is a Computer generated Report.No signature is required. " 
                    style="font-weight: 700"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
     </asp:Panel>
    <asp:LinkButton ID="LinkButton1" runat="server" OnClientClick = "return PrintPanel();">Print</asp:LinkButton>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Exit" />
    </form>
     <script type = "text/javascript">
         function PrintPanel() {
             var panel = document.getElementById("<%=pnlContents.ClientID %>");
             var printWindow = window.open('', '', 'height=400,width=800');
             printWindow.document.write('<html><head><title>DIV Contents</title>');
             printWindow.document.write('</head><body >');
             printWindow.document.write(panel.innerHTML);
             printWindow.document.write('</body></html>');
             printWindow.document.close();
             setTimeout(function () {
                 printWindow.print();
             }, 500);
             return false;
         }
    </script>
    
</body>
</html>
