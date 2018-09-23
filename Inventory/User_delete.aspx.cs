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


public partial class User_delete : System.Web.UI.Page
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
        SqlDataAdapter adp = new SqlDataAdapter("select * from user_info", ConfigurationSettings.AppSettings["cn8"]);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int u = Convert.ToInt32(((Label)(GridView1.Rows[e.RowIndex].FindControl("l2"))).Text);

        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "delete from user_info where uid=@u";
        cmd.Connection = con;
        cmd.Parameters.Add("@u", SqlDbType.Int).Value = u;
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        con.Close();
        bind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mainadmin.aspx");
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    
    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        
    }
    
}