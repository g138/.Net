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

public partial class Product_delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Page.IsPostBack==false)
        {
            bind();
        }
    }

    private void bind()
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from product_info", ConfigurationSettings.AppSettings["cn8"]);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();

    }



    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int p = Convert.ToInt32(((Label)(GridView1.Rows[e.RowIndex].FindControl("l1"))).Text);

        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "delete from product_info where product_id=@p";
        cmd.Connection = con;
        cmd.Parameters.Add("@p",SqlDbType.Int).Value = p;
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        con.Close();
        bind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mainadmin.aspx");
    }
}