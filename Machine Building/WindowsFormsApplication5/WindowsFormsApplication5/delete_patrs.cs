﻿using System;
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
    public partial class delete_patrs : Form
    {
        public delete_patrs()
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

            OleDbDataAdapter adp = new OleDbDataAdapter("select * from parts", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

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


                           OleDbCommand cmde = new OleDbCommand();
                           cmde.CommandText = "select * from sassembly where pname='" + dataGridView1.SelectedRows[0].Cells["a"].Value.ToString() + "'";
                  cmde.Connection = con;
               OleDbDataReader dim;
                  dim = cmde.ExecuteReader();
                  if (dim.HasRows)
                  {
                      MessageBox.Show("Delete Part from Sub Assembly First");
                  }

                  else
                  {



                      cd.Connection = con;
                      cd.CommandText = "delete * from parts where pno='" + dataGridView1.SelectedRows[0].Cells["b"].Value.ToString() + "'";

                      cd.ExecuteNonQuery();




                      if (this.dataGridView1.SelectedRows.Count > 0)
                      {


                          dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                      }

                      cd.Dispose();
                      con.Close();
                      MessageBox.Show("Part Deleted");

                      bind();
                  }
                }
            }
            catch
            {
                MessageBox.Show("Please select Entire Row");

            }
        }

    }
}
