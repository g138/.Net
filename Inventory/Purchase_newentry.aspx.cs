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

public partial class Photos_Purchase_newentry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            Label8.Text = Convert.ToString(getauto());
            product_bind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "insert into purchase_info values(@tid,@prod_id,@billno,@vendor_name,@purchase_date,@qty,@price)";
        cmd.Connection = con;
        cmd.Parameters.Add("@tid", SqlDbType.Int).Value = Convert.ToInt32(Label8.Text);
        cmd.Parameters.Add("@prod_id", SqlDbType.Int).Value = Convert.ToInt32(DropDownList2.SelectedValue);
        cmd.Parameters.Add("@billno", SqlDbType.VarChar,50).Value = Convert.ToInt32(TextBox2.Text);
        cmd.Parameters.Add("@vendor_name", SqlDbType.VarChar, 50).Value = (TextBox3.Text);
        cmd.Parameters.Add("@purchase_date", SqlDbType.VarChar, 50).Value = (TextBox4.Text); ;
        
        cmd.Parameters.Add("@qty", SqlDbType.Int).Value = Convert.ToInt32(TextBox5.Text);
        cmd.Parameters.Add("@price", SqlDbType.Int).Value = Convert.ToInt32(TextBox6.Text);
        
        cmd.ExecuteNonQuery();

        cmd.Dispose();
        con.Close();
        Label8.Text = Convert.ToString(getauto());
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
    }

    private Int32 getauto()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select isnull(max(tid),100) from purchase_info";
        cmd.Connection = con;
        return Convert.ToInt32(cmd.ExecuteScalar()) + 1;

    }


    private void product_bind()
    {

        SqlDataAdapter adp = new SqlDataAdapter("select * from product_info" , ConfigurationSettings.AppSettings["cn8"]);
        DataSet ds = new DataSet();
        adp.Fill(ds);
       DropDownList2.DataSource = ds;
       DropDownList2.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mainadmin.aspx");
    }
}