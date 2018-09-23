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
    public partial class testing1 : Form
    {
        public testing1()
        {
            InitializeComponent();
        }
        private void binds()
        {
            string s = "E:\\ggg.mdb";
            //string s1 = "Supplier";
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from supplier_info", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void testing1_Load(object sender, EventArgs e)
        {
            binds();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
          
            
          
                for (int rows = 0; rows < dataGridView1.Rows.Count - 1; rows++)
                {
                    String s1 = "";
                    String s2 = "";
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\ggg.mdb";
                    con.Open();
                    OleDbCommand cmd2 = new OleDbCommand();
                    cmd2.Connection = con;
                    s1 = dataGridView1.Rows[rows].Cells[0].Value.ToString();
                    s2 = dataGridView1.Rows[rows].Cells[1].Value.ToString();
                    cmd2.CommandText = "insert into temp values(@a,@b)";
                    cmd2.Parameters.Add("@a", OleDbType.VarChar, 50).Value = s1;
                    cmd2.Parameters.Add("@b", OleDbType.VarChar, 50).Value = s2;
                    cmd2.ExecuteNonQuery();
                    cmd2.Dispose();
                    con.Close();
   
                }

                
                

         
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
           
        

     
    }
}
