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
    public partial class sale : Form
    {
        public sale()
        {
            InitializeComponent();
            //test();
            textBox8.Text = DateTime.Now.ToShortDateString();
        }
        public void view2()
        {
            try
            {

                textBox9.Text = Convert.ToString(Convert.ToInt32(textBox6.Text) - Convert.ToInt32(textBox5.Text));
            }
            catch
            {
                // MessageBox.Show("Fill Issue Quantity");
            }
        }
        //public void test()
        //{


        //    OleDbConnection con = new OleDbConnection();
        //    con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\ggg.mdb";
        //    con.Open();




        //    OleDbCommand cd = new OleDbCommand();



        //    cd.Connection = con;

        //    String sp = "";

        //    int i;

        //    String z = "";



        //    OleDbDataReader dc;

        //    string p;

        //    cd.CommandText = "select max ([req_no])  as sid from [sale] ";


        //    dc = cd.ExecuteReader();


        //    String za = "";



        //    if (dc.HasRows)
        //    {

        //        try
        //        {


        //            dc.Read();
        //            p = dc["sid"].ToString();


        //            za = za + p.Substring(1);


        //            i = Convert.ToInt32(za);

        //            i = i + 1;

        //            z = Convert.ToString(i);

        //            sp = "10" + z;

        //        }

        //        catch
        //        {



        //            sp = "101";

        //        }
        //    }



        //    textBox3.Text = sp;


        //}
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
            OleDbDataAdapter adp = new OleDbDataAdapter("select pname,pno,rno,shell from parts where pno like '" + textBox10.Text + "%' ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;


        }
        public void bind7()
        {
            string s = "E:\\ggg.mdb";
            OleDbDataAdapter adp = new OleDbDataAdapter("select pname,pno,iqty,iperson,dd from sale where pno=null ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView2.DataSource = dt;


        }
        public void abc()
        {
            try
            {
                label9.Text = dataGridView1.SelectedRows[0].Cells["b"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Select Row Not Cell");
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
            cmd.Parameters.Add("@a", OleDbType.VarChar, 50).Value = label9.Text;

            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                label13.Text = dr["tot"].ToString();
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
            cmd.Parameters.Add("@a", OleDbType.VarChar, 50).Value = label9.Text;

            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                label14.Text = dr["tot"].ToString();
            }
        }
        public void view3()
        {
            string a = label9.Text;
            string s = "E:\\ggg.mdb";
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";";
            con.Open();
            string query = "select iif(isnull(sum(iqty)),0,sum(iqty)) as tot from issue where pno='" + a + "'  ";
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
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\ggg.mdb";
            con.Open();
            OleDbCommand cmd2 = new OleDbCommand();
            int i, n;
            n = Convert.ToInt32(dataGridView2.RowCount.ToString());
            for (i = 0; i < (n - 1); i++)
            {
                //cmd2.CommandText = "insert into sale(pname,pno,pqty,sqty,sperson,left,dd,pur) values(@a,@b,@c,@d,@e,@f,@g,@h)";
                cmd2.CommandText = "insert into sale(pname,pno,pqty,sqty,sperson,left1,dd,pur) values(@a,@b,@c,@d,@e,@f,@g,@h)";
                cmd2.Connection = con;
                cmd2.Parameters.Add("@a", OleDbType.VarChar, 50).Value = dataGridView2.Rows[i].Cells["e"].Value.ToString();
                cmd2.Parameters.Add("@b", OleDbType.VarChar, 50).Value = dataGridView2.Rows[i].Cells["f"].Value.ToString();
                cmd2.Parameters.Add("@c", OleDbType.Integer).Value = Convert.ToInt32(textBox6.Text);
                cmd2.Parameters.Add("@d", OleDbType.Integer).Value = Convert.ToInt32(textBox5.Text);
                cmd2.Parameters.Add("@e", OleDbType.VarChar, 50).Value = (textBox4.Text);
                cmd2.Parameters.Add("@f", OleDbType.Integer).Value = Convert.ToInt32(textBox9.Text);
                cmd2.Parameters.Add("@g", OleDbType.VarChar, 50).Value = (textBox8.Text);
                cmd2.Parameters.Add("@h", OleDbType.VarChar, 50).Value = (textBox7.Text);
               // cmd2.Parameters.Add("@i", OleDbType.VarChar, 50).Value = (textBox3.Text);
                cmd2.ExecuteNonQuery();
                cmd2.Dispose();
            }
            
            //bind7();
            textBox1.Text = "";
            textBox10.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox8.Text = DateTime.Now.ToShortDateString();
            textBox7.Text = "";
            textBox6.Text = "";
            
            MessageBox.Show("Data Saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView2.Rows.Add(dataGridView1.SelectedRows[0].Cells["a"].Value.ToString(), dataGridView1.SelectedRows[0].Cells["b"].Value.ToString(), textBox3.Text, textBox4.Text, textBox6.Text);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bind1();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //bind2();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            abc();
            view1();
            view3();
            view4();
            textBox6.Text = Convert.ToString(Convert.ToInt32(label13.Text) - Convert.ToInt32(label10.Text) - Convert.ToInt32(label14.Text));
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            view2();
        }

        private void sale_Load(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            bind2();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
