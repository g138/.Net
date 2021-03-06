﻿using System;
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
            bind();
            view_price();
        }
    }
    private void view_price()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationSettings.AppSettings["cn8"];
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select sum(qty) as sqty,sum(total_price) as sprice from requisition_info where product_id="+Convert.ToInt32(DropDownList2.SelectedValue);
        cmd.Connection = con;
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(DropDownList2.SelectedValue);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            dr.Read();
            Label3.Text = dr["sqty"].ToString();
            Label5.Text = dr["sprice"].ToString();
        }


    }

    private void product_bind()
    {
      
        SqlDataAdapter adp = new SqlDataAdapter("select * from product_info", ConfigurationSettings.AppSettings["cn8"]);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DropDownList2.DataSource = ds;
        DropDownList2.DataBind();

    }
    private void bind()
    {
        int pid = Convert.ToInt32(DropDownList2.SelectedValue);
        SqlDataAdapter adp = new SqlDataAdapter(" select sum(r.qty) as qty,min(r.price)as price,sum(r.total_price) as totp, r.product_id ,u.name from requisition_info r,user_info u  where u.uid=r.user_name group by r.product_id, u.name  having r.product_id="+pid+" order by name", ConfigurationSettings.AppSettings["cn8"]);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();

    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        bind();
        view_price();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mainadmin.aspx");
    }
}