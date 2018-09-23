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
    public partial class Update_Supplier : Form
    {
        public Update_Supplier()
        {
            InitializeComponent();
            bind();
        }
        private void bind()
        {
            string s = "E:\\ggg.mdb";
            //string s1 = "Suppplier";
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from supplier_info ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i, n;
            n = dataGridView1.RowCount;
            string s = "E:\\ggg.mdb";
            string s1 = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";";
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = s1;
            con.Open();
            OleDbCommand coden = new OleDbCommand();
            coden.Connection = con;
            for (i = 0; i < n - 1; i++)
            {
                coden.Connection = con;

                coden.CommandText = "update  [supplier_info] set [sname] = @qb,[company_name] = @qd,[address] = @qe,[cno] = @qf,[eid] = @qg,[reffer] = @qh,[din] = @qi,[gstno]=@qj,[tino]=@qk where  [sid] = " + Convert.ToInt32(dataGridView1.Rows[i].Cells["a"].Value.ToString());
                coden.Parameters.Add("@qb", OleDbType.VarChar).Value = dataGridView1.Rows[i].Cells["b"].Value.ToString();
               // coden.Parameters.Add("@qc", OleDbType.VarChar).Value = dataGridView1.Rows[i].Cells["c"].Value.ToString();
                coden.Parameters.Add("@qd", OleDbType.VarChar).Value = dataGridView1.Rows[i].Cells["d"].Value.ToString();
                coden.Parameters.Add("@qe", OleDbType.VarChar).Value = dataGridView1.Rows[i].Cells["e"].Value.ToString();
                coden.Parameters.Add("@qf", OleDbType.VarChar).Value = dataGridView1.Rows[i].Cells["f"].Value.ToString();
                coden.Parameters.Add("@qg", OleDbType.VarChar).Value = dataGridView1.Rows[i].Cells["g"].Value.ToString();
                coden.Parameters.Add("@qh", OleDbType.VarChar).Value = dataGridView1.Rows[i].Cells["h"].Value.ToString();
                coden.Parameters.Add("@qi", OleDbType.VarChar).Value = dataGridView1.Rows[i].Cells["i"].Value.ToString();

                coden.Parameters.Add("@qj", OleDbType.VarChar).Value = dataGridView1.Rows[i].Cells["j"].Value.ToString();
                coden.Parameters.Add("@qk", OleDbType.VarChar).Value = dataGridView1.Rows[i].Cells["k"].Value.ToString();


                coden.ExecuteNonQuery();

                coden.Dispose();
            }
            MessageBox.Show("Data Updated");
            coden.Dispose();
            con.Close();

     

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Supplier_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bind();
        }
    }
}
