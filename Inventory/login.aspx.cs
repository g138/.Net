using System;
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

public partial class _Default : System.Web.UI.Page
{
    String des = "";
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {   string d = "";

        long a = Convert.ToInt64(TextBox1.Text);

        if (a == 1001)
        {

            SqlConnection con7 = new SqlConnection();
            con7.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
            con7.Open();
            SqlCommand cmd7 = new SqlCommand();
            cmd7.CommandText = "select * from adminlogin where username=@u and password=@pd";
            cmd7.Parameters.Add("@u", SqlDbType.Int).Value = Convert.ToInt32(TextBox1.Text);
            cmd7.Parameters.Add("@pd", SqlDbType.VarChar, 50).Value = (TextBox2.Text);

            cmd7.Connection = con7;
            SqlDataReader dr7;
            dr7 = cmd7.ExecuteReader();
            if (dr7.HasRows)
            {


                Response.Cookies["c1"].Value = TextBox1.Text;
                Response.Cookies["c1"].Expires = DateTime.Now.AddMinutes(15);

                // Response.Redirect("cookiesmain.aspx");
                Response.Redirect("mainadmin.aspx");
                cmd7.Dispose();
                con7.Close();
            }
            else
            {
                Label6.Text = "Enter Valid Username and Password";
            }

        }
        else
        {

            SqlConnection con2 = new SqlConnection();
            con2.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
            con2.Open();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandText = "select * from user_info where uid=@id and pwd=@pwd";
            cmd2.Connection = con2;
            cmd2.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(TextBox1.Text);
            cmd2.Parameters.Add("@pwd", SqlDbType.VarChar, 50).Value = (TextBox2.Text);

            SqlDataReader dr4;
            dr4 = cmd2.ExecuteReader();
            if (dr4.HasRows)
            {
                
                    Response.Cookies["c3"].Value = TextBox1.Text;
                    Response.Cookies["c3"].Expires = DateTime.Now.AddMinutes(30);
                    Response.Redirect("Mainuser.aspx");


            }
            else
            {
                Label6.Text = "Enter Valid Username and Password";
            }

            cmd2.Dispose();
            con2.Close();

        }
    }
    protected void LinkButton1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("signup.aspx");
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}
