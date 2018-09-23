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
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mainuser.aspx");
    }
    private void bind()
    {
        String u = Label1.Text;
        SqlDataAdapter adp = new SqlDataAdapter("select * from total_order where username='"+u+"' and status='Pending'", ConfigurationSettings.AppSettings["cn8"]);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int p = Convert.ToInt32(((Label)(GridView1.Rows[e.RowIndex].FindControl("l1"))).Text);
        Session["a1"] = p.ToString();

        Response.Redirect("user_requisition_view.aspx");
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
      int a = Convert.ToInt32(((Label)(GridView1.SelectedRow.FindControl("l1"))).Text);
      SqlConnection con = new SqlConnection();
      con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
      con.Open();
      SqlCommand cmd = new SqlCommand();
      cmd.CommandText = "delete from requisition_info where req_id=@id";
      cmd.Connection = con;
      cmd.Parameters.Add("@id", SqlDbType.Int).Value =a;
    
      cmd.ExecuteNonQuery();

      cmd.Dispose();
      con.Close();


      SqlConnection con1 = new SqlConnection();
      con1.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
      con1.Open();
      SqlCommand cmd1 = new SqlCommand();
      cmd1.CommandText = "delete from total_order where req_id=@id";
      cmd1.Connection = con1;
      cmd1.Parameters.Add("@id", SqlDbType.Int).Value = a;

      cmd1.ExecuteNonQuery();

      cmd1.Dispose();
      con1.Close();

      bind();
    }
}