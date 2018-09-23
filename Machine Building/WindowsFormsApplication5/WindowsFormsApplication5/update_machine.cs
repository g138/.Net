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
    public partial class update_machine : Form
    {
        public update_machine()
        {
            InitializeComponent();
            binds();
        }
        private void binds()
        {
            string s = "E:\\ggg.mdb";

            OleDbDataAdapter adp = new OleDbDataAdapter("select distinct mname from machine ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            comboBox1.DataSource = dt;

        }
        private void bind()
        {
            string s = "E:\\ggg.mdb";

            OleDbDataAdapter adp = new OleDbDataAdapter("select sname,qty from machine where mname = '" + comboBox1.SelectedValue.ToString() + "'", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            textBox1.Text = comboBox1.SelectedValue.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkvalid()==true){
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

                coden.CommandText = "update  [machine] set [mname]=@qc,[qty]=@qb where  [mname] = '" + comboBox1.SelectedValue.ToString() + "' and [sname]='" + dataGridView1.Rows[you].Cells["a"].Value.ToString() + "'";

                coden.Parameters.Add("@qc", OleDbType.VarChar).Value = Convert.ToString(textBox1.Text);
                coden.Parameters.Add("@qb", OleDbType.Integer).Value = Convert.ToInt32(dataGridView1.Rows[you].Cells["b"].Value.ToString());


                coden.ExecuteNonQuery();

                coden.Dispose();
            }
            MessageBox.Show("Data Updated");
            binds();
            coden.Dispose();
            con.Close();
            bind();
        }
        }
        public Boolean checkvalid()
        {

            ep1.Dispose();
            int check = 0;

            if (textBox1.Text == "")
            {
                ep1.SetError(textBox1, "Enter Machine Name");
                check = 1;
            }


            if (check == 1)
            {
                return false;
            }
            else
            {
                return true;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\ggg.mdb";
                    con.Open();


                    OleDbCommand cd = new OleDbCommand();

                    cd.Connection = con;
                    cd.CommandText = "delete * from machine where  [mname] = '" + comboBox1.SelectedValue.ToString() + "' and [sub]='" + dataGridView1.SelectedRows[0].Cells["a"].Value.ToString() + "'";

                    cd.ExecuteNonQuery();




                    if (this.dataGridView1.SelectedRows.Count > 0)
                    {


                        dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                    }

                    cd.Dispose();
                    con.Close();
                    MessageBox.Show("'Sub Assembly Deleted'");

                    bind();

                }
            }
            catch
            {
                MessageBox.Show("Please select Entire Row");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
