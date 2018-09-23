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

public partial class User_update : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {

        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label10.Text = "";
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select * from user_info where uid=@u";
        cmd.Connection = con;
        cmd.Parameters.Add("@u", SqlDbType.Int).Value = Convert.ToInt32(TextBox2.Text);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            dr.Read();
            DropDownList1.Text = dr["user_type"].ToString();
            TextBox3.Text = dr["name"].ToString();
            TextBox4.Text = dr["department"].ToString();
            TextBox5.Text = dr["designation"].ToString();
            TextBox6.Text = dr["contact_no"].ToString();
            TextBox7.Text = dr["email_id"].ToString();
            TextBox8.Text = dr["pwd"].ToString();
            

        }
        cmd.Dispose();
        con.Close();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Label10.Text = "Update successfully !!";
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "update user_info set user_type=@user_type,name=@name,department=@department,designation=@desig,contact_no=@cno,email_id=@eid,pwd=@pwd where uid=@u";
        cmd.Connection = con;
        cmd.Parameters.Add("@user_type", SqlDbType.VarChar,50).Value = DropDownList1.Text;
        cmd.Parameters.Add("@u", SqlDbType.Int).Value = Convert.ToInt32(TextBox2.Text);
        cmd.Parameters.Add("@name", SqlDbType.VarChar,50).Value = (TextBox3.Text);
        cmd.Parameters.Add("@department", SqlDbType.VarChar,50).Value = (TextBox4.Text); ;
        cmd.Parameters.Add("@desig", SqlDbType.VarChar, 500).Value = (TextBox5.Text);
        cmd.Parameters.Add("@cno", SqlDbType.Int).Value = Convert.ToInt32(TextBox6.Text);
        cmd.Parameters.Add("@eid", SqlDbType.VarChar,50).Value = (TextBox7.Text);
        cmd.Parameters.Add("pwd", SqlDbType.VarChar, 50).Value = (TextBox8.Text);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        con.Close();
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mainadmin.aspx");
    }
}