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
    public partial class update_customer : Form
    {
        public update_customer()
        {
            InitializeComponent();
            bind();
        }
        private void bind()
        {
            string s = "E:\\ggg.mdb";
            //string s1 = "Customer";
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from customer_info", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sew = Convert.ToInt32(dataGridView1.RowCount);
            int you;
            // change here

            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\ggg.mdb";
            con.Open();

    

            OleDbCommand coden = new OleDbCommand();
            coden.Connection = con;
     
            for (you = 0; you < (sew - 1); you++)
            {


                coden.Connection = con;

                coden.CommandText = "update  [customer_info] set [cname] = @qb,[company_name] = @qd,[address] = @qe,[cno] = @qf,[eid] = @qg,[reffer] = @qh,[din] = @qi,[gstno]=@qj,[tino]=@qk where  [cid] = " + Convert.ToInt32(dataGridView1.Rows[you].Cells["a"].Value.ToString());
                coden.Parameters.Add("@qb", OleDbType.VarChar).Value = dataGridView1.Rows[you].Cells["b"].Value.ToString();
                //coden.Parameters.Add("@qc", OleDbType.VarChar).Value = dataGridView1.Rows[you].Cells["c"].Value.ToString();
                coden.Parameters.Add("@qd", OleDbType.VarChar).Value = dataGridView1.Rows[you].Cells["d"].Value.ToString();
                coden.Parameters.Add("@qe", OleDbType.VarChar).Value = dataGridView1.Rows[you].Cells["e"].Value.ToString();
                coden.Parameters.Add("@qf", OleDbType.VarChar).Value = dataGridView1.Rows[you].Cells["f"].Value.ToString();
                coden.Parameters.Add("@qg", OleDbType.VarChar).Value = dataGridView1.Rows[you].Cells["g"].Value.ToString();
                coden.Parameters.Add("@qh", OleDbType.VarChar).Value = dataGridView1.Rows[you].Cells["h"].Value.ToString();
                coden.Parameters.Add("@qi", OleDbType.VarChar).Value = dataGridView1.Rows[you].Cells["i"].Value.ToString();

                coden.Parameters.Add("@qj", OleDbType.VarChar).Value = dataGridView1.Rows[you].Cells["j"].Value.ToString();
                coden.Parameters.Add("@qk", OleDbType.VarChar).Value = dataGridView1.Rows[you].Cells["k"].Value.ToString();


                coden.ExecuteNonQuery();

                coden.Dispose();
            }
            MessageBox.Show("Data Updated");
            coden.Dispose();
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void update_customer_Load(object sender, EventArgs e)
        {

        }
    }
}
