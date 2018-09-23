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

public partial class Product_create : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            TextBox2.Text = Convert.ToString(getauto());
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "insert into user_info values(@user_type,@uid,@name,@department,@description,@contact,@email_id,@pwd)";
        cmd.Connection = con;
        cmd.Parameters.Add("@user_type", SqlDbType.VarChar,50).Value = DropDownList1.Text;
        cmd.Parameters.Add("@uid", SqlDbType.Int).Value = Convert.ToInt32(TextBox2.Text);
        cmd.Parameters.Add("@name", SqlDbType.VarChar,50).Value = (TextBox3.Text);
        cmd.Parameters.Add("@department", SqlDbType.VarChar,50).Value = (TextBox4.Text); ;
        cmd.Parameters.Add("@description", SqlDbType.VarChar, 500).Value = (TextBox5.Text);
        cmd.Parameters.Add("@contact", SqlDbType.VarChar,50).Value =(TextBox6.Text);
        cmd.Parameters.Add("@email_id", SqlDbType.VarChar,50).Value = (TextBox7.Text);
        cmd.Parameters.Add("pwd", SqlDbType.VarChar, 50).Value = (TextBox8.Text);
        

        cmd.ExecuteNonQuery();
       
        cmd.Dispose();
        con.Close();

        TextBox2.Text = Convert.ToString(getauto());
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
    


    }

    private Int32 getauto()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select isnull(max(uid),100) from user_info";
        cmd.Connection = con;
        return Convert.ToInt32(cmd.ExecuteScalar()) + 1;
        
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mainadmin.aspx");
    }
    protected void TextBox8_TextChanged(object sender, EventArgs e)
    {

    }
}