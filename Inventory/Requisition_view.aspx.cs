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

public partial class User_view : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            HttpCookie hc = Request.Cookies["c3"];
            if (hc == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                Label1.Text = Server.HtmlEncode(hc.Value);
            }
            bind();
            view();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mainuser.aspx");
    }
    private void bind()
    {
        String u = Label1.Text;
        SqlDataAdapter adp = new SqlDataAdapter("select * from total_order where username='"+u+"' and status='Approved'", ConfigurationSettings.AppSettings["cn8"]);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();

    }
    private void view()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select isnull(sum(total_price),0)as tot_price from total_order where username=" + Convert.ToInt32(Label1.Text);
        cmd.Connection = con;

    
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            dr.Read();
            Label3.Text = dr["tot_price"].ToString();

        }
        cmd.Dispose();
        con.Close();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int p = Convert.ToInt32(((Label)(GridView1.Rows[e.RowIndex].FindControl("l1"))).Text);
        Session["a1"] = p.ToString();

        Response.Redirect("user_requisition_view.aspx");
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string a = ((Label)(GridView1.SelectedRow.FindControl("l1"))).Text;
        Session["val1"] = a.ToString();
        Response.Redirect("Requisition_print.aspx");
    }
}