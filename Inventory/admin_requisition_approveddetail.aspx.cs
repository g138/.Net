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
            Label1.Text = Session["a1"].ToString();
            bind();
            total_price();
        }
    }


    private void total_price()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select sum(total_price) as tot from requisition_info where req_id=@id";
        cmd.Connection = con;
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(Label1.Text);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            dr.Read();
            Label3.Text = dr["tot"].ToString();

        }


    }
    private void bind()
    {
        int reqid = Convert.ToInt32(Label1.Text);
        SqlDataAdapter adp = new SqlDataAdapter("select t.*,u.name from requisition_info t, product_info u where t.product_id=u.product_id and t. req_id=" + reqid, ConfigurationSettings.AppSettings["cn8"]);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_requisition_approved.aspx");
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int p = Convert.ToInt32(((Label)(GridView1.Rows[e.RowIndex].FindControl("l5"))).Text);
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "delete from requisition_info where trans_id=@id";
            cmd.Parameters.Add("@id",SqlDbType.Int).Value=p;
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        con.Close();
        bind();
        total_price();



        SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con1.Open();
        SqlCommand cmd1 = new SqlCommand();
        cmd1.Connection = con1;
        cmd1.CommandText = "update total_order set total_price=@tot where req_id=@id";
        cmd1.Parameters.Add("@id", SqlDbType.Int).Value = Label1.Text;
        cmd1.Parameters.Add("@tot", SqlDbType.Int).Value = Label3.Text;
        cmd1.ExecuteNonQuery();
        cmd1.Dispose();
        con1.Close();





       
    }
}