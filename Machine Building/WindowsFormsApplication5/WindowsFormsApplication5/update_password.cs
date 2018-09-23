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
    public partial class update_password : Form
    {
        public update_password()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Boolean checkvalid()
        {

            ep1.Dispose();
            int check = 0;
            if (textBox2.Text == "")
            {
                ep1.SetError(textBox2, "Enter Password");
                check = 1;
            }
            if (textBox1.Text == "")
            {
                ep1.SetError(textBox1, "Enter Old Password");
                check = 1;
            }
            if (textBox3.Text == "")
            {
                ep1.SetError(textBox3, "Enter Confirm Password");
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
                string s1 = "E:\\ggg.mdb";
            string constr1 = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s1 + ";";


            OleDbConnection con1 = new OleDbConnection();
            con1.ConnectionString = (constr1);
            con1.Open();
            OleDbCommand cmd1 = new OleDbCommand();
            cmd1.CommandText = "select * from adminlogin where  pwd ='" + textBox1.Text + "'";
            cmd1.Connection = con1;

            OleDbDataReader dr1;
            dr1 = cmd1.ExecuteReader();
            
            if (dr1.HasRows)
            {
                string s = "E:\\ggg.mdb";
                string constr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";";

                if (textBox2.Text == textBox3.Text)
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = (constr);
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "UPDATE adminlogin SET [pwd] ='" + textBox2.Text + "'";
                    cmd.Connection = con;

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    MessageBox.Show("Password Updated");
                }
                else
                {
                    MessageBox.Show("Password/Confirm Password not match");
                }

            }
            else
            {
                MessageBox.Show("Invalid old password");
            }

            cmd1.Dispose();
            con1.Close();

        }
        }
    }
}
