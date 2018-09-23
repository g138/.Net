using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Configuration;

public partial class report_admin_product : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            product_bind();
            bind1();
            view_price1();
        }
    }
    private void view_price()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select sum(total_price) as sprice from requisition_info  where session='"+DropDownList3.SelectedItem.Text+"'";
        cmd.Connection = con;
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(DropDownList2.SelectedValue);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            dr.Read();

            Label5.Text = dr["sprice"].ToString();
        }


    }
    private void view_price1()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select sum(total_price) as sprice from requisition_info where user_name="+Convert.ToInt32(DropDownList2.SelectedValue)+" and session='"+DropDownList3.SelectedItem.Text+"'";
        cmd.Connection = con;
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(DropDownList2.SelectedValue);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            dr.Read();
           
            Label5.Text = dr["sprice"].ToString();
        }


    }

    private void product_bind()
    {
      
        SqlDataAdapter adp = new SqlDataAdapter("select * from user_info", ConfigurationSettings.AppSettings["cn8"]);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DropDownList2.DataSource = ds;
        DropDownList2.DataBind();

    }
    private void bind1()
    {
        int pid = Convert.ToInt32(DropDownList2.SelectedValue);
        SqlDataAdapter adp = new SqlDataAdapter("select sum(r.qty) as totqty,min(r.price) as price,sum(r.total_price)as totprice,u.name,p.name as pname from product_info p, requisition_info r, user_info u where r.user_name=u.uid  and r.product_id=p.product_id and u.uid="+pid+" and r.session='"+DropDownList3.SelectedItem.Text+"'  group by p.name,u.name order by u.name", ConfigurationSettings.AppSettings["cn8"]);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();

    }
    private void bind()
    {
        int pid = Convert.ToInt32(DropDownList2.SelectedValue);
        SqlDataAdapter adp = new SqlDataAdapter(" select sum(r.qty) as totqty,min(r.price) as price,sum(r.total_price)as totprice,u.name,p.name as pname from product_info p, requisition_info r, user_info u where r.user_name=u.uid  and r.product_id=p.product_id and r.session='" + DropDownList3.SelectedItem.Text + "' group by p.name,u.name order by u.name", ConfigurationSettings.AppSettings["cn8"]);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();

    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        bind1();
        view_price1();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mainadmin.aspx");
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == true)
        {
            bind();
            DropDownList2.Enabled = false;
            view_price();
        }
        else
        {
            DropDownList2.Enabled = true;
            bind1();
            view_price1();
        }
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == true)
        {
            bind();
            DropDownList2.Enabled = false;
            view_price();
        }
        else
        {
            DropDownList2.Enabled = true;
            bind1();
            view_price1();
        }
    }
}