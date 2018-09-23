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
    public partial class update_parts : Form
    {
        public update_parts()
        {
            InitializeComponent();
            bind();
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

                coden.CommandText = "update  [parts] set [pname] = @qa,[pno] = @qb,[prate] = @qc,[srate] = @qd,[rno] = @qe,[shell] = @qf,[ob] = @qg,[min] = @qh,[max] = @qi,[qty] = @qj,[remark] = @qk where  [pno] = '" + dataGridView1.Rows[you].Cells["b"].Value.ToString()+"'";
                coden.Parameters.Add("@qa", OleDbType.VarChar).Value = dataGridView1.Rows[you].Cells["a"].Value.ToString();
                coden.Parameters.Add("@qb", OleDbType.VarChar).Value = dataGridView1.Rows[you].Cells["b"].Value.ToString();
                coden.Parameters.Add("@qc", OleDbType.VarChar).Value = dataGridView1.Rows[you].Cells["c"].Value.ToString();
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
        private void bind()
        {
            string s = "E:\\ggg.mdb";

            OleDbDataAdapter adp = new OleDbDataAdapter("select * from parts", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
