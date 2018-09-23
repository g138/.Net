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
            bind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mainadmin.aspx");
    }
    private void bind()
    {
        SqlDataAdapter adp = new SqlDataAdapter("SELECT * from purchase_summary", ConfigurationSettings.AppSettings["cn8"]);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int u = Convert.ToInt32(((Label)(GridView1.Rows[e.RowIndex].FindControl("l1"))).Text);
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "delete from purchase_summary where purchase_id=@id";
        cmd.Connection = con;
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = u;

        cmd.ExecuteNonQuery();

        cmd.Dispose();
        con.Close();


        SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con1.Open();
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandText = "delete from purchase_info where purchase_id=@id";
        cmd1.Connection = con1;
        cmd1.Parameters.Add("@id", SqlDbType.Int).Value = u;

        cmd1.ExecuteNonQuery();

        cmd1.Dispose();
        con1.Close();

        bind();
    }
}