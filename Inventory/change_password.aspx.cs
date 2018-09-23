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


public partial class change_password : System.Web.UI.Page
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
                Label4.Text = Server.HtmlEncode(hc.Value);
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mainuser.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        if (TextBox2.Text == TextBox3.Text)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
            con1.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = "select * from user_info  where uid=@uid and pwd=@pwd";
            cmd1.Connection = con1;
            cmd1.Parameters.Add("@pwd", SqlDbType.VarChar, 50).Value = TextBox1.Text;
            cmd1.Parameters.Add("@uid", SqlDbType.Int).Value = Convert.ToInt32(Label4.Text);

            SqlDataReader dr;
            dr = cmd1.ExecuteReader();
            if (dr.HasRows)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "update user_info set pwd=@pwd where uid=@uid";
                cmd.Connection = con;
                cmd.Parameters.Add("@pwd", SqlDbType.VarChar, 50).Value = TextBox2.Text;
                cmd.Parameters.Add("@uid", SqlDbType.Int).Value = Convert.ToInt32(Label4.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                Label6.Text = "Password Updated";
            }
            cmd1.Dispose();
            con1.Close();
        }
        else
        {
            Label6.Text = "New Password/Confirm Password Not Match";
        }
    }
}