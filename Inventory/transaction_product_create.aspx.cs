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

public partial class transaction_product_create : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            TextBox5.Text = DateTime.Now.ToShortDateString();
            itemname_bind();
            view_price();
            initial_qty();
            total_quantity_stocked();
            total_quantity_used();
            TextBox1.Text = Convert.ToString(getauto());
            TextBox2.Text = Convert.ToString(getauto1());
            view();
            Label19.Text = Convert.ToString(Convert.ToInt32(Label16.Text) - Convert.ToInt32(Label17.Text));
            Label21.Text = "";
            gross_price();
        }
    }
    private void itemname_bind()
    {

        SqlDataAdapter adp = new SqlDataAdapter("select * from product_info", ConfigurationSettings.AppSettings["cn8"]);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DropDownList2.DataSource = ds;
        DropDownList2.DataBind();
    }

    private Int32 getauto()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select isnull(max(purchase_id),0) from purchase_info where status ='Approved'";
        cmd.Connection = con;
        return Convert.ToInt32(cmd.ExecuteScalar()) + 1;

    }


    private Int32 getauto1()
    {
       
        int totid = Convert.ToInt32(TextBox1.Text) * 100;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select isnull(max(tid)," + totid + ") from purchase_info where purchase_id ="+TextBox1.Text;
        cmd.Connection = con;
        return Convert.ToInt32(cmd.ExecuteScalar()) + 1;

    }
    private void view()
    {
        int a = Convert.ToInt32(TextBox1.Text);
        SqlDataAdapter adp = new SqlDataAdapter("select pu.*, pr.name as product_name from purchase_info pu,product_info pr where pr.product_id=pu.product_id and purchase_id=" + a + " and status='Pending' ORDER BY tID", ConfigurationSettings.AppSettings["cn8"]);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int tid = Convert.ToInt32(TextBox1.Text) * 100;

        Label23.Text = Convert.ToString(Convert.ToInt32(TextBox6.Text) * Convert.ToInt32(TextBox7.Text));

        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "insert into purchase_info values(@purchase_id,@tid,@prod_id,@billno,@vendor,@purchase_date,@qty,@price,@status,@totprice)";
        cmd.Connection = con;
        cmd.Parameters.Add("@purchase_id", SqlDbType.Int).Value = Convert.ToInt32(TextBox1.Text);
        cmd.Parameters.Add("@tid", SqlDbType.Int).Value = Convert.ToInt32(TextBox2.Text);
        cmd.Parameters.Add("@prod_id", SqlDbType.Int).Value = Convert.ToInt32(DropDownList2.SelectedValue);
        cmd.Parameters.Add("@billno", SqlDbType.VarChar, 50).Value = (TextBox3.Text); ;
        cmd.Parameters.Add("@vendor", SqlDbType.VarChar, 500).Value = (TextBox4.Text);
        cmd.Parameters.Add("@purchase_date", SqlDbType.VarChar, 50).Value = (TextBox5.Text);
        cmd.Parameters.Add("@qty", SqlDbType.Int).Value = Convert.ToInt32(TextBox6.Text);
        cmd.Parameters.Add("@price", SqlDbType.Int).Value = Convert.ToInt32(TextBox7.Text);
        cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = "Pending";
        cmd.Parameters.Add("@totprice", SqlDbType.VarChar).Value = Convert.ToInt32(Label23.Text);
        cmd.ExecuteNonQuery();

        cmd.Dispose();
        con.Close();

        TextBox2.Text = Convert.ToString(getauto1());
        Label21.Text = Convert.ToString(Convert.ToInt32(TextBox6.Text) + Convert.ToInt32(Label19.Text));
        
        TextBox6.Text = "";

        view();


        
            initial_qty();
            total_quantity_stocked();
            total_quantity_used();
            gross_price();

            Label19.Text = Convert.ToString(Convert.ToInt32(Label16.Text) - Convert.ToInt32(Label17.Text));
    
    }

    private void view_price()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select * from product_info where product_id=@id";
        cmd.Connection = con;
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(DropDownList2.SelectedValue);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            dr.Read();
            TextBox7.Text = dr["price"].ToString();
            Label22.Text = dr["initial_qty"].ToString();
        }


    }

    private void total_price()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select sum(total_price) as tot from requisition_info where req_id=@id";
        cmd.Connection = con;
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(TextBox2.Text);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            dr.Read();
            Label13.Text = dr["tot"].ToString();

        }


    }



    private void initial_qty()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select isnull(initial_qty,0) as qty from product_info where product_id=@id";
        cmd.Connection = con;
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(DropDownList2.SelectedValue);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            dr.Read();
            Label15.Text = dr["qty"].ToString();

        }


    }




    private void total_quantity_stocked()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select isnull(sum(qty),0) as qty from purchase_info where product_id=@id";
        cmd.Connection = con;
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(DropDownList2.SelectedValue);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            dr.Read();
            Label16.Text = dr["qty"].ToString();

        }
        Label16.Text = Convert.ToString(Convert.ToInt32(Label15.Text) + Convert.ToInt32(Label16.Text));

    }





    private void total_quantity_used()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select isnull(sum(qty),0) as qty from requisition_info where product_id=@id";
        cmd.Connection = con;
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(DropDownList2.SelectedValue);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            dr.Read();
            Label17.Text = dr["qty"].ToString();

        }


    }

   


    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        view_price();
        initial_qty();
        total_quantity_stocked();
        total_quantity_used();
        Label19.Text = Convert.ToString(Convert.ToInt32(Label16.Text) - Convert.ToInt32(Label17.Text));
        Label21.Text = "";
    }

    private void gross_price()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select isnull(sum(total_price),0) as price from purchase_info where purchase_id=@id";
        cmd.Connection = con;
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(TextBox1.Text);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            dr.Read();
            Label24.Text = dr["price"].ToString();

        }


    }



    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "insert into purchase_summary values(@purchase_id,@pur_date,@total_price,@Vendor_name,@bill_no)";
        cmd.Connection = con;
        cmd.Parameters.Add("@purchase_id", SqlDbType.Int).Value = Convert.ToInt32(TextBox1.Text);
        cmd.Parameters.Add("@pur_date", SqlDbType.VarChar,50).Value =(TextBox5.Text);
        cmd.Parameters.Add("@total_price", SqlDbType.Int).Value = Convert.ToInt32(Label24.Text);
        cmd.Parameters.Add("@Vendor_name", SqlDbType.VarChar, 50).Value = (TextBox4.Text); ;
        cmd.Parameters.Add("@bill_no", SqlDbType.VarChar, 50).Value = (TextBox3.Text);
      
        cmd.ExecuteNonQuery();

        cmd.Dispose();
        con.Close();



        SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con1.Open();
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandText = "update purchase_info set status='Approved' where purchase_id=@id";
        cmd1.Connection = con1;
        cmd1.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(TextBox1.Text);
      
        cmd1.ExecuteNonQuery();

        cmd1.Dispose();
        con1.Close();



        view();


        TextBox1.Text = Convert.ToString(getauto());
        TextBox2.Text = Convert.ToString(getauto1());
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int a = Convert.ToInt32(((Label)(GridView1.Rows[e.RowIndex].FindControl("l2"))).Text);
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "delete from purchase_info where tid=@id";
        cmd.Connection = con;
        cmd.Parameters.Add("@id", SqlDbType.Int).Value =a;
      
        cmd.ExecuteNonQuery();

        cmd.Dispose();
        con.Close();
        view();
        gross_price();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mainadmin.aspx");
    }
}