using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication5
{
    public partial class supplier : Form
    {
        public supplier()
        {
            InitializeComponent();
           // getauto();
        }

        private void supplier_Load(object sender, EventArgs e)
        {

        }
        //private void getauto()
        //{
        //    string s = "E:\\ggg.mdb";
        //    string constr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";";

        //    OleDbConnection con = new OleDbConnection();
        //    con.ConnectionString = (constr);
        //    con.Open();
        //    OleDbCommand cmd = new OleDbCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "Select * from supplier_info";

        //    OleDbDataReader dr;
        //    dr = cmd.ExecuteReader();
        //    if (dr.HasRows)
        //    {

        //        string s1 = "E:\\project1.mdb";
        //        string constr1 = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s1 + ";";

        //        OleDbConnection con1 = new OleDbConnection();
        //        con1.ConnectionString = (constr);
        //        con1.Open();
        //        OleDbCommand cmd1 = new OleDbCommand();
        //        cmd1.Connection = con1;
        //        cmd1.CommandText = "SELECT max(sid) AS ida FROM supplier_info";

        //        OleDbDataReader dr1;
        //        dr1 = cmd1.ExecuteReader();
        //        if (dr1.HasRows)
        //        {
        //            dr1.Read();
        //            this.Hide();
        //            textBox1.Text = dr1["ida"].ToString();
        //            textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + 1);
        //        }



        //    }
        //    else
        //    {
        //        textBox1.Text = "101";
        //    }

        //}
        public Boolean checkvalid()
        {

            ep1.Dispose();
            int check = 0;
            if (textBox2.Text == "")
            {
                ep1.SetError(textBox2, "Enter Name");
                check = 1;
            }
            
            //if (comboBox1.SelectedItem == null)
            //{
            //    ep1.SetError(comboBox1, "Select Type");
            //    check = 1;
            //}
            //if (comboBox1.Text == "")
            //{
            //    ep1.SetError(comboBox1, "Select Type");
            //    check = 1;
            //}

            if (check == 1)
            {
                return false;
            }
            else
            {
                return true;
            }


        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkvalid() == true)
            {
                //string s = "Supplier";
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\ggg.mdb";
                con.Open();
                OleDbCommand cmd2 = new OleDbCommand();
                cmd2.CommandText = "insert into supplier_info(sname,company_name,address,cno,eid,reffer,din,gstno,tino) values('"+ textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','"+textBox9.Text+"','"+textBox10.Text+"')";
                cmd2.Connection = con;

                cmd2.ExecuteNonQuery();
                cmd2.Dispose();

                //textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                MessageBox.Show("Data saved");
                //getauto();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
