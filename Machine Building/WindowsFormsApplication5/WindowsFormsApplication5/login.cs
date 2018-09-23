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
    public partial class login : Form
    {
        public login()
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
                ep1.SetError(textBox1, "Enter User Name");
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
            cmd1.CommandText = "select * from adminlogin where  pwd ='" + textBox2.Text + "' and uid='" + textBox1.Text + "'";
            cmd1.Connection = con1;

            OleDbDataReader dr1;
            dr1 = cmd1.ExecuteReader();

            if (dr1.HasRows)
            {
                this.Hide();
                menu m = new menu();
                m.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or Password");

            }
        }
        }
    }
}
