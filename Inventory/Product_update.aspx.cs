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


public partial class Product_update : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {

        }
    }



    protected void Button3_Click(object sender, EventArgs e)
    {
        
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "update product_info set name=@name,company_name=@company,initial_qty=@iqty,date=@date,min_qty=@min_qty,remarks=@remarks,price=@price where product_id=@p";
        cmd.Connection = con;
        cmd.Parameters.Add("@p", SqlDbType.Int).Value = Convert.ToInt32(TextBox1.Text);
        cmd.Parameters.Add("@name", SqlDbType.VarChar, 500).Value = (TextBox2.Text);
        cmd.Parameters.Add("@company", SqlDbType.VarChar, 500).Value = (TextBox3.Text);
        cmd.Parameters.Add("@iqty", SqlDbType.Int).Value = Convert.ToInt32(TextBox4.Text); ;
        cmd.Parameters.Add("@date", SqlDbType.VarChar, 500).Value = (TextBox5.Text);
        cmd.Parameters.Add("@min_qty", SqlDbType.Int).Value = Convert.ToInt32(TextBox6.Text);
        cmd.Parameters.Add("@remarks", SqlDbType.VarChar, 1000).Value = (TextBox7.Text);
        cmd.Parameters.Add("@price", SqlDbType.VarChar, 1000).Value = (TextBox8.Text);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        con.Close();
        Label10.Text = "Update successfully !!";
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select * from product_info where product_id=@p";
        cmd.Connection = con;
        cmd.Parameters.Add("@p", SqlDbType.Int).Value = Convert.ToInt32(TextBox1.Text);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            dr.Read();
            TextBox2.Text = dr["name"].ToString();
            TextBox3.Text = dr["company_name"].ToString();
            TextBox4.Text = dr["initial_qty"].ToString();
            TextBox5.Text = dr["date"].ToString();
            TextBox6.Text=dr["min_qty"].ToString();
            TextBox7.Text = dr["remarks"].ToString();
            TextBox8.Text = dr["price"].ToString();
        }
        cmd.Dispose();
        con.Close();
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mainadmin.aspx");
    }
}