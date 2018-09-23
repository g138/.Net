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
    public partial class view_sub_assembly : Form
    {
        public view_sub_assembly()
        {
            InitializeComponent();
            binds();
        }
        private void bind1()
        {
            string s = "E:\\ggg.mdb";
            string s1 = comboBox1.SelectedValue.ToString();
           
            OleDbDataAdapter adp = new OleDbDataAdapter("select pname,qty from sassembly where sub='"+s1+"'", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void binds()
        {
            string s = "E:\\ggg.mdb";
            OleDbDataAdapter adp = new OleDbDataAdapter("select distinct sub from sassembly ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            comboBox1.DataSource = dt;

        }
        public void bind2()
        {
            string s = "E:\\ggg.mdb";
            string constr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";";

            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = (constr);
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from sassembly where sub='"+comboBox1.SelectedValue.ToString()+"'";

            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();

                textBox2.Text = dr["subno"].ToString();

            }
            con.Close();
            cmd.Dispose();
        }
 
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.ApplicationClass XcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                XcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    XcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        XcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();

                    }
                    XcelApp.Columns.AutoFit();
                    XcelApp.Visible = true;
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //bind1();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //bind12();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bind1();
            bind2();
        }

    }
}
