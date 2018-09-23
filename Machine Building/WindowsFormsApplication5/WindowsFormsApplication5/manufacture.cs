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
    public partial class manufacture : Form
    {
        public manufacture()
        {
            InitializeComponent();
            bind1();
            v4();
        }
        public void bind1()
        {
            string s = "E:\\ggg.mdb";

            OleDbDataAdapter adp = new OleDbDataAdapter("select distinct(sub) from sassembly   ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            comboBox1.DataSource = dt;

        }
        public void v4()
        {
            string s = "E:\\ggg.mdb";
            string s1 = comboBox1.SelectedValue.ToString();
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";";
            con.Open();
            string query = "select * from sassembly where sub=@a";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.CommandText = query;
            cmd.Parameters.Add("@a", OleDbType.VarChar, 50).Value = s1;

            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                textBox1.Text = dr["subno"].ToString();
            }
        }
        public void v2()
        {
            string s = "E:\\ggg.mdb";
            string s1 = comboBox1.SelectedValue.ToString();

            OleDbConnection con2 = new OleDbConnection();
            con2.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";";
            con2.Open();
            string query2 = "select count(*) as ct from sassembly where sub=@a";
            OleDbCommand cmd2 = new OleDbCommand(query2, con2);
            cmd2.CommandText = query2;
            cmd2.Parameters.Add("@a", OleDbType.VarChar, 50).Value = s1;
            cmd2.ExecuteNonQuery();
            OleDbDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.HasRows)
            {
                dr2.Read();
                label6.Text = dr2["ct"].ToString();
            }
            cmd2.Dispose();
            con2.Close();


            int n = Convert.ToInt32(label6.Text);
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";";
            con.Open();
            for (int i = 1; i < (n+1); i++)
            {
                string query = "select rn,pname from (select  pname from sassembly)where rn="+i+"";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.CommandText = query;
               
                cmd.Parameters.Add("@a", OleDbType.VarChar, 50).Value = s1;
               cmd.ExecuteNonQuery();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    label5.Text = dr["pname"].ToString();
                    OleDbConnection con1 = new OleDbConnection();
                    con1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";";
                    con1.Open();
                    string query1 = "insert into temp values(@b) ";
                    OleDbCommand cmd1 = new OleDbCommand(query1, con1);
                    cmd1.CommandText = query1;
                    cmd1.Parameters.Add("@b", OleDbType.VarChar, 50).Value = label5.Text;
                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();
                    con1.Close();

                }
               
            }

        }
        public void v1()
        {
            string s = "E:\\ggg.mdb";

            OleDbDataAdapter adp = new OleDbDataAdapter("select pname,qty from sassembly where subno='"+textBox1.Text+"'   ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            v2();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            v4();
        }
    }
}
