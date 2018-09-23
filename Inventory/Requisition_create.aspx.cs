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
            HttpCookie hc = Request.Cookies["c3"];
            if (hc == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                Label14.Text = Server.HtmlEncode(hc.Value);
            }


            TextBox2.Text = Convert.ToString(getauto());
            Label10.Text = Convert.ToString(getauto_trans());
            itemname_bind();
            TextBox4.Text = DateTime.Now.ToShortDateString();
            view_price();
            initial_qty();
            total_quantity_stocked();
            total_quantity_used();
            TextBox8.Text = Convert.ToString(Convert.ToInt32(Label16.Text) - Convert.ToInt32(Label17.Text));
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {

        if (Convert.ToInt32(TextBox8.Text) < 0)
        {
            Response.Write("Invalid Quantity");
        }
        else
        {
            Label10.Text = Convert.ToString(getauto_trans());
            Label9.Text = Convert.ToString(Convert.ToInt32(TextBox6.Text) * Convert.ToInt32(TextBox7.Text));
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into requisition_info values(@order_cat,@req_id,@purpose,@date,@proid,@qty,@price,@tot_price,@trns_id,@username,@status,@session)";
            cmd.Connection = con;
            cmd.Parameters.Add("@order_cat", SqlDbType.VarChar, 50).Value = DropDownList1.SelectedItem.Text;
            cmd.Parameters.Add("@req_id", SqlDbType.Int).Value = Convert.ToInt32(TextBox2.Text);
            cmd.Parameters.Add("@purpose", SqlDbType.VarChar, 50).Value = (TextBox3.Text);
            cmd.Parameters.Add("@date", SqlDbType.VarChar, 50).Value = (TextBox4.Text); ;
            cmd.Parameters.Add("@proid", SqlDbType.VarChar, 500).Value = Convert.ToInt32(DropDownList2.SelectedValue);
            cmd.Parameters.Add("@qty", SqlDbType.Int).Value = Convert.ToInt32(TextBox6.Text);
            cmd.Parameters.Add("@price", SqlDbType.VarChar, 50).Value = (TextBox7.Text);
            cmd.Parameters.Add("@tot_price", SqlDbType.Int).Value = Convert.ToInt32(Label9.Text);
            cmd.Parameters.Add("@trns_id", SqlDbType.Int).Value = Convert.ToInt32(Label10.Text);
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = (Label14.Text);
            cmd.Parameters.Add("@status", SqlDbType.VarChar, 50).Value = "Pending";
            cmd.Parameters.Add("@session", SqlDbType.VarChar, 50).Value = DropDownList3.SelectedItem.Text;
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

            Label10.Text = Convert.ToString(getauto_trans());

            total_price();

            TextBox6.Text = "";

            view_grid();

            initial_qty();
            total_quantity_stocked();
            total_quantity_used();
            TextBox8.Text = Convert.ToString(Convert.ToInt32(Label16.Text) - Convert.ToInt32(Label17.Text));
        }

       

    }

    private Int32 getauto()
    {
        int c=(Convert.ToInt32(Label14.Text)*100);
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select isnull(max(req_id)," + c + ") from requisition_info where (status='Approved' or status='Submitted') AND user_name='" + Label14.Text + "'";
        cmd.Connection = con;
        return Convert.ToInt32(cmd.ExecuteScalar()) + 1;
        
    }


    private Int32 getauto_trans()
    {
        int tid = Convert.ToInt32(TextBox2.Text) * 100;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select isnull(max(trans_id)," + tid + ") from requisition_info where req_id="+TextBox2.Text;
        cmd.Connection = con;
        return Convert.ToInt32(cmd.ExecuteScalar()) + 1;

    }


   

    private void itemname_bind()
    {

        SqlDataAdapter adp = new SqlDataAdapter("select * from product_info", ConfigurationSettings.AppSettings["cn8"]);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DropDownList2.DataSource = ds;
        DropDownList2.DataBind();
    }


    private void view_grid()
    {

        SqlDataAdapter adp = new SqlDataAdapter("select r.trans_id,p.name,r.qty,p.price,r.total_price from product_info p,requisition_info r where p.product_id=r.product_id and req_id="+TextBox2.Text, ConfigurationSettings.AppSettings["cn8"]);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }

    private void view_grid_blank()
    {

        SqlDataAdapter adp = new SqlDataAdapter("select r.trans_id,p.name,r.qty,p.price,r.total_price from product_info p,requisition_info r where p.product_id=r.product_id and req_id=000", ConfigurationSettings.AppSettings["cn8"]);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Cookies["c3"].Value = Label14.Text;
        Response.Cookies["c3"].Expires = DateTime.Now.AddMinutes(30);
        Response.Redirect("Mainuser.aspx");
    }
    protected void TextBox8_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {


        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select * from total_order where req_id=@req_id";
        cmd.Connection = con;
      
        cmd.Parameters.Add("@req_id", SqlDbType.Int).Value = Convert.ToInt32(TextBox2.Text);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            Label18.Text = "Requistion already Saved, Check from Delete Requistion link";
        }

        else
        {


            SqlConnection con2 = new SqlConnection();
            con2.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
            con2.Open();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandText = "update requisition_info set status='Submitted' where req_id=@req_id";
            cmd2.Connection = con2;
           
            cmd2.Parameters.Add("@req_id", SqlDbType.Int).Value = Convert.ToInt32(TextBox2.Text);
           
            cmd2.ExecuteNonQuery();

            cmd2.Dispose();
            con2.Close();



            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
            con1.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = "insert into total_order values(@order_cat,@req_id,@date,@tot_price,@username,@status,@session)";
            cmd1.Connection = con1;
            cmd1.Parameters.Add("@order_cat", SqlDbType.VarChar, 50).Value = DropDownList1.SelectedItem.Text;
            cmd1.Parameters.Add("@req_id", SqlDbType.Int).Value = Convert.ToInt32(TextBox2.Text);
            cmd1.Parameters.Add("@date", SqlDbType.VarChar, 50).Value = (TextBox4.Text); ;
            cmd1.Parameters.Add("@tot_price", SqlDbType.Int).Value = Convert.ToInt32(Label13.Text);
            cmd1.Parameters.Add("@username", SqlDbType.Int).Value = Convert.ToInt32(Label14.Text);
            cmd1.Parameters.Add("@status", SqlDbType.VarChar, 50).Value = "Pending";
            cmd1.Parameters.Add("@session", SqlDbType.VarChar, 50).Value = DropDownList3.SelectedItem.Text;
           
            cmd1.ExecuteNonQuery();

            cmd1.Dispose();
            con1.Close();
            TextBox2.Text = Convert.ToString(getauto());
            Label10.Text = Convert.ToString(getauto_trans());
            Label18.Text = "Order Submitted Successfully Check from Delete Requistion link";
            view_grid_blank();
            Label13.Text = "";
        }



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
            TextBox8.Text = dr["initial_qty"].ToString();
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
        TextBox8.Text = Convert.ToString(Convert.ToInt32(Label16.Text) - Convert.ToInt32(Label17.Text));
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int vi = Convert.ToInt32(((Label)(GridView1.Rows[e.RowIndex].FindControl("l1"))).Text);
        int qty = Convert.ToInt32(((Label)(GridView1.Rows[e.RowIndex].FindControl("l4"))).Text);
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "delete from requisition_info where trans_id=@id";
        cmd.Connection = con;

        cmd.Parameters.Add("@id", SqlDbType.Int).Value =vi;

        cmd.ExecuteNonQuery();

        cmd.Dispose();
        con.Close();
        view_grid();
        total_price();
        initial_qty();
        total_quantity_stocked();
        total_quantity_used();
        TextBox8.Text = Convert.ToString(Convert.ToInt32(Label16.Text) - Convert.ToInt32(Label17.Text));
    }
}