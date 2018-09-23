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
    public partial class create_parts : Form
    {
        public create_parts()
        {
            InitializeComponent();
            //fnx();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Boolean checkvalid()
        {

            ep1.Dispose();
            int check = 0;
            if (textBox1.Text == "")
            {
                ep1.SetError(textBox1, "Enter Part Name");
                check = 1;
            }
            if (textBox2.Text == "")
            {
                ep1.SetError(textBox2, "Enter Part Id");
                check = 1;
            }
            

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
            if(checkvalid()==true){
            string s = "E:\\ggg.mdb";
            string constr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";";
            //getauto();
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = (constr);
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "insert into parts values(@pname,@pno,@prate,@srate,@rno,@ob,@min,@max,@qty,@remark,@shell,@v1,@p1,@v2,@p2,@v3,@p3)";
            cmd.Connection = con;
            cmd.Parameters.Add("@pname", OleDbType.VarChar, 50).Value = textBox1.Text;
            cmd.Parameters.Add("@pno", OleDbType.VarChar, 50).Value = textBox2.Text;
            cmd.Parameters.Add("@prate", OleDbType.VarChar, 50).Value = textBox3.Text;
            cmd.Parameters.Add("@srate", OleDbType.VarChar, 50).Value = textBox4.Text;
            cmd.Parameters.Add("@rno", OleDbType.VarChar, 50).Value = textBox5.Text;
            cmd.Parameters.Add("@ob", OleDbType.VarChar, 50).Value = textBox7.Text;
            cmd.Parameters.Add("@min", OleDbType.VarChar, 50).Value = textBox8.Text;
            cmd.Parameters.Add("@max", OleDbType.VarChar, 50).Value = textBox9.Text;
            cmd.Parameters.Add("@qty", OleDbType.Integer).Value = Convert.ToInt32(textBox10.Text);
            cmd.Parameters.Add("@remark", OleDbType.VarChar, 50).Value = textBox11.Text;
            cmd.Parameters.Add("@shell", OleDbType.VarChar, 50).Value = textBox6.Text;
            cmd.Parameters.Add("@v1", OleDbType.VarChar, 50).Value = textBox12.Text;
            cmd.Parameters.Add("@p1", OleDbType.VarChar, 50).Value = textBox13.Text;
            cmd.Parameters.Add("@v2", OleDbType.VarChar, 50).Value = textBox14.Text;
            cmd.Parameters.Add("@p2", OleDbType.VarChar, 50).Value = textBox15.Text;
            cmd.Parameters.Add("@v3", OleDbType.VarChar, 50).Value = textBox16.Text;
            cmd.Parameters.Add("@p3", OleDbType.VarChar, 50).Value = textBox17.Text;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "0";
            textBox14.Text = "";
            textBox15.Text = "0";
            textBox16.Text = "";
            textBox17.Text = "0";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            MessageBox.Show("saved successfully");
            
        }
        }

        private void create_parts_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox12.ReadOnly = false;
                textBox13.ReadOnly = false;
            }
            else if (checkBox1.Checked == false)
            {

                textBox12.ReadOnly = true;
                textBox13.ReadOnly = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox14.ReadOnly = false;
                textBox15.ReadOnly = false;
            }
            else if (checkBox2.Checked == false)
            {

                textBox14.ReadOnly = true;
                textBox15.ReadOnly = true;
            }
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox16.ReadOnly = false;
                textBox17.ReadOnly = false;
            }
            else if (checkBox3.Checked == false)
            {

                textBox16.ReadOnly = true;
                textBox17.ReadOnly = true;
            }
        }

    }
}
