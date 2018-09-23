using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Mainadmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Product_create.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Product_view.aspx");

    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Product_update.aspx");
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Product_delete.aspx");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("User_create.aspx");
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Response.Redirect("User_view.aspx");
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        Response.Redirect("User_update.aspx");
    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        Response.Redirect("User_delete.aspx");
    }
    protected void LinkButton13_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }
    protected void LinkButton9_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton9_Click1(object sender, EventArgs e)
    {
        Response.Redirect("transaction_product_create.aspx");
    }
    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        Response.Redirect("purchase_view.aspx");
    }
    protected void LinkButton14_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_requisition_view.aspx");
    }
    protected void LinkButton15_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_requisition_approved.aspx");
    }
    protected void LinkButton12_Click(object sender, EventArgs e)
    {
        Response.Redirect("purchase_delete.aspx");
    }
    protected void LinkButton16_Click(object sender, EventArgs e)
    {
        Response.Redirect("report_admin_product.aspx");
    }
    protected void LinkButton17_Click(object sender, EventArgs e)
    {
        Response.Redirect("report_admin_user.aspx");
    }
    protected void LinkButton18_Click(object sender, EventArgs e)
    {
        Response.Redirect("report_admin_detail.aspx");
    }
}