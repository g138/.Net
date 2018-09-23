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
        SqlDataAdapter adp = new SqlDataAdapter("select t.*,u.name from total_order t, user_info u where t.username=u.uid and t.status='Pending'", ConfigurationSettings.AppSettings["cn8"]);
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
        Response.Redirect("admin_requisition_update.aspx");
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int p = Convert.ToInt32(((Label)(GridView1.SelectedRow.FindControl("l1"))).Text);
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = " update requisition_info set status ='Approved' where req_id=@id";
        cmd.Connection = con;
        cmd.Parameters.Add("@id", SqlDbType.Int).Value =p;
       

        cmd.ExecuteNonQuery();
        cmd.Dispose();
        con.Close();


        SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con1.Open();
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandText = " update total_order set status ='Approved' where req_id=@id";
        cmd1.Connection = con1;
        cmd1.Parameters.Add("@id", SqlDbType.Int).Value = p;


        cmd1.ExecuteNonQuery();
        cmd1.Dispose();
        con1.Close();
        bind();

    }
}