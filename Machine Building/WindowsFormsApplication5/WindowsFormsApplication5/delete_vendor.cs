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
    public partial class delete_vendor : Form
    {
        public delete_vendor()
        {
            InitializeComponent();
            binds();
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

                coden.CommandText = "update  [pext] set [pr]=@qb where  [pname] = '" + comboBox1.SelectedValue.ToString() + "' and [sname]='" + dataGridView1.Rows[you].Cells["a"].Value.ToString() + "'";

                
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
        private void bind()
        {

            string s = "E:\\ggg.mdb";
            string constr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";";
            OleDbDataAdapter adp = new OleDbDataAdapter("select sname,pr from pext where pname='"+comboBox1.SelectedValue.ToString()+"'", (constr));
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            //checkedListBox1.DataSource = dt;

        


        }
        private void binds()
        {
            string s = "E:\\ggg.mdb";

            OleDbDataAdapter adp = new OleDbDataAdapter("select pname  from parts ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            comboBox1.DataSource = dt;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bind();
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
                    cd.CommandText = "delete * from pext where  [pname] = '" + comboBox1.SelectedValue.ToString() + "' and [sname]='" + dataGridView1.SelectedRows[0].Cells["a"].Value.ToString() + "'";

                    cd.ExecuteNonQuery();




                    if (this.dataGridView1.SelectedRows.Count > 0)
                    {


                        dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                    }

                    cd.Dispose();
                    con.Close();
                    MessageBox.Show("Supplier Deleted");

                    bind();

                }
            }
            catch
            {
                MessageBox.Show("Please select Entire Row");

            }
        }
    }
}
