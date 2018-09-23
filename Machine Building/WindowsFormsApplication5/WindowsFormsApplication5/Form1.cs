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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\ggg.mdb";
            con.Open();
            OleDbCommand cmd2 = new OleDbCommand();
            cmd2.CommandText = "insert into cinfo(nane) values('"+textBox1.Text+"')";
            cmd2.Connection = con;

            cmd2.ExecuteNonQuery();
            cmd2.Dispose();
            con.Close();


        }
    }
}
