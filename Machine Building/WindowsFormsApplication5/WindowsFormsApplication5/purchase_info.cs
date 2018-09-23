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
    public partial class purchase_info : Form
    {
        public purchase_info()
        {
            InitializeComponent();
            bind3();
            textBox7.Text = DateTime.Now.ToShortDateString();
        }
        private void bind3()
        {
            string s = "E:\\ggg.mdb";
            OleDbConnection con = new OleDbConnection();
            try
            {
                string s1="supplier";
                con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";";
                string query = "select sname from supplier_info ";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.CommandText = query;
                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["sname"].ToString());
                }
                con.Close();
            }
            catch
            {
              
            }
        }
        private void bind1()
        {
            string s = "E:\\ggg.mdb";
           // string s1 = "Customer";
            OleDbDataAdapter adp = new OleDbDataAdapter("select pname,pno,rno,shell from parts where pname like '" + textBox1.Text + "%' ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        public void bind2()
        {
            string s = "E:\\ggg.mdb";
            OleDbDataAdapter adp = new OleDbDataAdapter("select pname,pno,rno,shell from parts where pno like '" + textBox2.Text + "%' ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;


        }
        public void bind7()
        {
            string s = "E:\\ggg.mdb";
            OleDbDataAdapter adp = new OleDbDataAdapter("select pname,pno,sno,rno,purchase_quantity,sname,tot_qty from purchase where pno=null ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView2.DataSource = dt;


        }
        public void abc()
        {
            try
            {
                label10.Text = dataGridView1.SelectedRows[0].Cells["b"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Select Row Not Cell");
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bind1();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bind2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox9.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text));
            this.dataGridView2.Rows.Add(dataGridView1.SelectedRows[0].Cells["a"].Value.ToString(), dataGridView1.SelectedRows[0].Cells["b"].Value.ToString(), dataGridView1.SelectedRows[0].Cells["c"].Value.ToString(), dataGridView1.SelectedRows[0].Cells["d"].Value.ToString(),textBox5.Text,comboBox1.SelectedItem.ToString(),textBox9.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
           // textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = DateTime.Now.ToShortDateString();
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void button3_Click(object sender, EventArgs e)
        {

            
                
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox9.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text));
            }
            catch
            {
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            abc();
            v1();
            v2();
            v3();
            v4();
            textBox3.Text = Convert.ToString(Convert.ToInt32(label11.Text) + Convert.ToInt32(label12.Text)-Convert.ToInt32(label13.Text)-Convert.ToInt32(label14.Text));
        }
        public void v4()
        {
            string s = "E:\\ggg.mdb";
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";";
            con.Open();
            string query = "select iif(isnull(sum(sqty)),0,sum(sqty)) as tot from sale where pno=@a";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.CommandText = query;
            cmd.Parameters.Add("@a", OleDbType.VarChar, 50).Value = label10.Text;

            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                label14.Text = dr["tot"].ToString();
            }
        }
        public void v1()
        {
            string s = "E:\\ggg.mdb";
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";";
            con.Open();
            string query = "select qty from parts where pno=@a";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.CommandText = query;
            cmd.Parameters.Add("@a", OleDbType.VarChar, 50).Value = label10.Text;

            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                label11.Text = dr["qty"].ToString();
            }
        }
        public void v2()
        {
            string s = "E:\\ggg.mdb";
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";";
            con.Open();
            string query = "select iif(isnull(sum(purchase_quantity)),0,sum(purchase_quantity)) as tot from purchase where pno=@a";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.CommandText = query;
            cmd.Parameters.Add("@a", OleDbType.VarChar, 50).Value = label10.Text;

            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                label12.Text = dr["tot"].ToString();
            }
        }
        public void v3()
        {
            string s = "E:\\ggg.mdb";
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";";
            con.Open();
            string query = "select iif(isnull(sum(iqty)),0,sum(iqty)) as tot from issue where pno=@a";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.CommandText = query;
            cmd.Parameters.Add("@a", OleDbType.VarChar, 50).Value = label10.Text;

            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                label13.Text = dr["tot"].ToString();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\ggg.mdb";
            con.Open();
            OleDbCommand cmd2 = new OleDbCommand();
            int i, n;
            n = Convert.ToInt32(dataGridView2.RowCount.ToString());
            for (i = 0; i < (n - 1); i++)
            {
                cmd2.CommandText = "insert into purchase values('"+textBox4.Text+"','"+textBox7.Text+"','" + dataGridView2.Rows[i].Cells["e"].Value.ToString() + "','" + dataGridView2.Rows[i].Cells["f"].Value.ToString() + "','" + dataGridView2.Rows[i].Cells["g"].Value.ToString() + "','" + dataGridView2.Rows[i].Cells["h"].Value.ToString() + "','" + dataGridView2.Rows[i].Cells["i"].Value.ToString() + "','" + dataGridView2.Rows[i].Cells["j"].Value.ToString() + "','" + dataGridView2.Rows[i].Cells["k"].Value.ToString() + "','"+textBox8.Text+"')";
                cmd2.Connection = con;
                cmd2.ExecuteNonQuery();
                cmd2.Dispose();
            }
            bind7();
            MessageBox.Show("Data Saved");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = DateTime.Now.ToShortDateString();
            textBox8.Text = "";
            textBox9.Text = "";
            //this.dataGridView1.Rows.Clear();
            


            
       }

        private void purchase_info_Load(object sender, EventArgs e)
        {

        }
    }
}
