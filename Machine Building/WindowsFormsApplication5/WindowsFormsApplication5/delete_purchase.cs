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
    public partial class delete_purchase : Form
    {
        public delete_purchase()
        {
            InitializeComponent();
            bind();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bind()
        {
            string s = "E:\\ggg.mdb";

            OleDbDataAdapter adp = new OleDbDataAdapter("select pname,pno,sname,dd,tot_qty,billno,remark from purchase ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  try
            //{

                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\ggg.mdb";
                    con.Open();


                    OleDbCommand cd = new OleDbCommand();






                    cd.Connection = con;
                    cd.CommandText = "delete * from purchase where billno='" + dataGridView1.SelectedRows[0].Cells["f"].Value.ToString() + "' and dd='" + dataGridView1.SelectedRows[0].Cells["d"].Value.ToString() + "' and pno='" + dataGridView1.SelectedRows[0].Cells["b"].Value.ToString() + "' and remark='" + dataGridView1.SelectedRows[0].Cells["g"].Value.ToString() + "'";

                    cd.ExecuteNonQuery();




                    if (this.dataGridView1.SelectedRows.Count > 0)
                    {


                        dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                    }

                    cd.Dispose();
                    con.Close();
                    MessageBox.Show("Transaction Deleted");

                    bind();

                }
      //      }
    //        catch
  //          {
//                MessageBox.Show("Please select Entire Row");

          //  }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
