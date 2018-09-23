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
    public partial class delete_supplier : Form
    {
        public delete_supplier()
        {
            InitializeComponent();
            bind();
        }
        private void bind()
        {
            string s = "E:\\ggg.mdb";
           // string s1 = "Supplier";
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from supplier_info ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                    cd.CommandText = "delete * from supplier_info where sid=" + dataGridView1.SelectedRows[0].Cells["a"].Value.ToString() + "";

                    cd.ExecuteNonQuery();




                    if (this.dataGridView1.SelectedRows.Count > 0)
                    {


                        dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                    }

                    cd.Dispose();
                    con.Close();
                    MessageBox.Show("User Deleted");

                    bind();

                }
            }
            catch
            {
                MessageBox.Show("Please select Entire Row");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
