using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.IO;


public partial class admin_requisition_update : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            bind();
        }
    }
    private void bind()
    {
        String u = Label1.Text;
        SqlDataAdapter adp = new SqlDataAdapter("select t.*,u.name from total_order t, user_info u where t.username=u.uid and t.status='Approved' ORDER BY req_id", ConfigurationSettings.AppSettings["cn8"]);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mainadmin.aspx");
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

        int p = Convert.ToInt32(((Label)(GridView1.Rows[e.RowIndex].FindControl("l1"))).Text);
        Session["a1"] = p.ToString();
        Response.Redirect("admin_requisition_approveddetail.aspx");
    }
   
}