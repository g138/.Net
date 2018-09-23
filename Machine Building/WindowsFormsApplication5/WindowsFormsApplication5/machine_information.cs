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
    public partial class machine_information : Form
    {
        public machine_information()
        {
            InitializeComponent();
            
        }

        public void bind1()
        {
            string s = "E:\\ggg.mdb";

            OleDbDataAdapter adp = new OleDbDataAdapter("select sub,subno from sassembly1 where sub like '" + textBox3.Text + "%' ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void bind2()
        {
            string s = "E:\\ggg.mdb";

            OleDbDataAdapter adp = new OleDbDataAdapter("select sub,subno from sassembly where subno like '" + textBox4.Text + "%' ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void bind7()
        {
            string s = "E:\\ggg.mdb";

            OleDbDataAdapter adp = new OleDbDataAdapter("select sub,subno,qty from sassembly where subno=null ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
                cmd2.CommandText = "insert into machine values('"+textBox1.Text+"','"+textBox2.Text+"','" + dataGridView2.Rows[i].Cells["e"].Value.ToString() +"','" + dataGridView2.Rows[i].Cells["d"].Value.ToString() + "','" + Convert.ToInt32(dataGridView2.Rows[i].Cells["c"].Value.ToString()) + "')";
                cmd2.Connection = con;

                cmd2.ExecuteNonQuery();
                cmd2.Dispose();
            }
            MessageBox.Show("Data Saved");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            bind7();
           
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            bind1();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            bind2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView2.Rows.Add(dataGridView1.SelectedRows[0].Cells["a"].Value.ToString(), dataGridView1.SelectedRows[0].Cells["b"].Value.ToString(), textBox5.Text);
            }
            catch
            {
                MessageBox.Show("Select Entire Row");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {


                try
                {
                    dataGridView2.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                }
                catch
                {
                    MessageBox.Show("Select Entire Row");
                }
            }
        }

        private void machine_information_Load(object sender, EventArgs e)
        {

        }
    }
}
