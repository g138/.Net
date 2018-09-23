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
              
           TextBox1.Text= Convert.ToString(getauto());
           TextBox5.Text = DateTime.Now.ToShortDateString();
           
        }
       
    }
    private Int32 getauto()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select isnull(max(product_id),1000) as trans_id from product_info";
        cmd.Connection = con;
        return Convert.ToInt32(cmd.ExecuteScalar()) + 1;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "insert into product_info values(@id,@name,@company,@iqty,@date,@min_qty,@remarks,@price)";
        cmd.Connection = con;
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(TextBox1.Text);
        cmd.Parameters.Add("@name", SqlDbType.VarChar,500).Value = (TextBox2.Text);
        cmd.Parameters.Add("@company", SqlDbType.VarChar,500).Value = (TextBox3.Text);
        cmd.Parameters.Add("@iqty", SqlDbType.Int).Value = Convert.ToInt32(TextBox4.Text); ;
        cmd.Parameters.Add("@date", SqlDbType.VarChar, 500).Value = (TextBox5.Text);
        cmd.Parameters.Add("@min_qty", SqlDbType.Int).Value = Convert.ToInt32(TextBox6.Text);
        cmd.Parameters.Add("@remarks", SqlDbType.VarChar,1000).Value = (TextBox7.Text);
        cmd.Parameters.Add("@price", SqlDbType.VarChar, 1000).Value = (TextBox8.Text);

        cmd.ExecuteNonQuery();
       
        cmd.Dispose();
        con.Close();
        TextBox1.Text = Convert.ToString(getauto());
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "0";
        TextBox6.Text = "0";
        TextBox7.Text = "";
        TextBox8.Text = "";

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mainadmin.aspx");
    }
}