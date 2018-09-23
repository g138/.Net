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
    public partial class issue : Form
    {
        public issue()
        {
            InitializeComponent();
           // bind3();
            view2();
            textBox6.Text = DateTime.Now.ToShortDateString();
           // getauto();
           


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
        //    cmd.CommandText = "Select * from issue";

        //    OleDbDataReader dr;
        //    dr = cmd.ExecuteReader();
        //    if (dr.HasRows)
        //    {

        //        // string s1 = "E:\\project1.mdb";
        //        //string constr1 = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s1 + ";";

        //        OleDbConnection con1 = new OleDbConnection();
        //        con1.ConnectionString = (constr);
        //        con1.Open();
        //        OleDbCommand cmd1 = new OleDbCommand();
        //        cmd1.Connection = con1;
        //        cmd1.CommandText = "SELECT max(req_no) AS ida FROM issue";

        //        OleDbDataReader dr1;
        //        dr1 = cmd1.ExecuteReader();
        //        if (dr1.HasRows)
        //        {
        //            dr1.Read();
        //            // this.Hide();
        //            textBox9.Text = dr1["ida"].ToString();
        //            textBox9.Text = Convert.ToString(Convert.ToInt32(textBox9.Text) + 1);
        //        }



        //    }
        //    else
        //    {
        //        textBox9.Text = "101";
        //    }

        //}
   

        private void bind1()
        {
            string s = "E:\\ggg.mdb";
            // string s1 = "Customer";
            OleDbDataAdapter adp = new OleDbDataAdapter("select pname,pno,rno,shell from parts where pname like '" + textBox8.Text + "%' ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        public void bind2()
        {
            string s = "E:\\ggg.mdb";
            OleDbDataAdapter adp = new OleDbDataAdapter("select pname,pno,rno,shell from parts where pno like '" + textBox10.Text + "%' ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;


        }
        public void bind7()
        {
            string s = "E:\\ggg.mdb";
            OleDbDataAdapter adp = new OleDbDataAdapter("select pname,pno,iqty,iperson,dd from issue where pno=null ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView2.DataSource = dt;


        }
        public void abc()
        {
            try
            {
                label13.Text = dataGridView1.SelectedRows[0].Cells["b"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Select Row Not Cell");
            }

        }

        public void view2()
        {
            try
            {

                textBox5.Text = Convert.ToString(Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox3.Text));
            }
            catch
            {
               // MessageBox.Show("Fill Issue Quantity");
            }
        }
        public void view1()
        {
            string s = "E:\\ggg.mdb";
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";";
            con.Open();
            string query = "select iif(isnull(sum(purchase_quantity)),0,sum(purchase_quantity)) as tot  from purchase where pno=@a";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.CommandText = query;
            cmd.Parameters.Add("@a", OleDbType.VarChar, 50).Value = label13.Text;

            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                label9.Text = dr["tot"].ToString();
            }
        }
        public void view4()
        {
            string s = "E:\\ggg.mdb";
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";";
            con.Open();
            string query = "select iif(isnull(sum(sqty)),0,sum(sqty)) as tot  from sale where pno=@a";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.CommandText = query;
            cmd.Parameters.Add("@a", OleDbType.VarChar, 50).Value = label13.Text;

            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                label14.Text = dr["tot"].ToString();
            }
        }
        public void view3()
        {
            string a = label13.Text;
            string s = "E:\\ggg.mdb";
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";";
            con.Open();
            string query = "select iif(isnull(sum(iqty)),0,sum(iqty)) as tot from issue where pno='"+a+"'  ";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.CommandText = query;
            //cmd.Parameters.Add("@a", OleDbType.VarChar, 50).Value = textBox1.Text;

            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                label10.Text = dr["tot"].ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(Convert.ToInt32(label9.Text) - Convert.ToInt32(label10.Text));
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\ggg.mdb";
            con.Open();
            OleDbCommand cmd2 = new OleDbCommand();
            int i, n;
            n = Convert.ToInt32(dataGridView2.RowCount.ToString());
            for (i = 0; i < (n - 1); i++)
            {
                cmd2.CommandText = "insert into issue(pname,pno,pqty,iqty,iperson,left_qty,dd,purpose) values(@a,@b,@c,@d,@e,@f,@g,@h)";
                cmd2.Connection = con;
                cmd2.Parameters.Add("@a", OleDbType.VarChar, 50).Value = dataGridView2.Rows[i].Cells["e"].Value.ToString();
                cmd2.Parameters.Add("@b", OleDbType.VarChar, 50).Value = dataGridView2.Rows[i].Cells["f"].Value.ToString();
                cmd2.Parameters.Add("@c", OleDbType.Integer).Value = Convert.ToInt32(textBox2.Text);
                cmd2.Parameters.Add("@d", OleDbType.Integer).Value = Convert.ToInt32(textBox3.Text);
                cmd2.Parameters.Add("@e", OleDbType.VarChar, 50).Value = (textBox4.Text);
                cmd2.Parameters.Add("@f", OleDbType.Integer).Value = Convert.ToInt32(textBox5.Text);
                cmd2.Parameters.Add("@g", OleDbType.VarChar, 50).Value = (textBox6.Text);
                cmd2.Parameters.Add("@h", OleDbType.VarChar, 50).Value = (textBox7.Text);
               // cmd2.Parameters.Add("@i", OleDbType.Integer).Value = Convert.ToInt32(textBox9.Text);
            }
            cmd2.ExecuteNonQuery();
            cmd2.Dispose();
            bind7();
            textBox9.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = DateTime.Now.ToShortDateString();
            textBox7.Text = "";
            textBox8.Text = "";
            //getauto();
            MessageBox.Show("Data Saved");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //view();
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            view2();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            bind1();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //bind2();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            abc();
            view1();
            view3();
            view4();
            textBox2.Text = Convert.ToString(Convert.ToInt32(label9.Text) - Convert.ToInt32(label10.Text)-Convert.ToInt32(label14.Text));
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView2.Rows.Add(dataGridView1.SelectedRows[0].Cells["a"].Value.ToString(), dataGridView1.SelectedRows[0].Cells["b"].Value.ToString(),  textBox3.Text, textBox4.Text,textBox6.Text);
            
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            bind2();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
