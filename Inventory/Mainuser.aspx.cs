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


public partial class Mainuser : System.Web.UI.Page
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
                Label3.Text = Server.HtmlEncode(hc.Value);
            }
            view();
        }
    }

    private void view()
    {
         SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
            con1.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = "select * from user_info  where uid=@uid ";
            cmd1.Connection = con1;
        
            cmd1.Parameters.Add("@uid", SqlDbType.Int).Value = Convert.ToInt32(Label3.Text);

            SqlDataReader dr;
            dr = cmd1.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                Label5.Text = dr["name"].ToString();
            }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Cookies["c3"].Value = Label3.Text;
        Response.Cookies["c3"].Expires = DateTime.Now.AddMinutes(30);
        Response.Redirect("Requisition_create.aspx");

    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Cookies["c3"].Value = Label3.Text;
        Response.Cookies["c3"].Expires = DateTime.Now.AddMinutes(30);
        Response.Redirect("Requisition_view.aspx");

    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Requisition_delete.aspx");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Response.Redirect("change_password.aspx");
    }
}