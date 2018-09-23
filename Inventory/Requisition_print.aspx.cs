using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Configuration;

public partial class Requisition_print : System.Web.UI.Page
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
                Label13.Text = Server.HtmlEncode(hc.Value);
            }
            Label7.Text = Session["val1"].ToString();
           
            view_price();
            bind1();
        }
    }
    private void bind1()
    {

        SqlDataAdapter adp = new SqlDataAdapter("select r.qty,r.price,r.total_price,p.name from requisition_info r,product_info p where r.product_id=p.product_id and  r.req_id=" + (Label7.Text), ConfigurationSettings.AppSettings["cn8"]);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();

    }
    private void view_price()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select r.req_id,r.date,r.total_price,u.name from total_order r, user_info u  where r.username=u.uid and r.req_id=@id";
        cmd.Connection = con;
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(Label7.Text);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            dr.Read();

            Label3.Text = dr["name"].ToString();
            Label5.Text = dr["date"].ToString();
            Label9.Text = dr["total_price"].ToString();
        }


    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Requisition_view.aspx");
    }
}