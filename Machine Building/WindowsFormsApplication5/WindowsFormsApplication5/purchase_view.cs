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
    public partial class purchase_view : Form
    {
        public purchase_view()
        {
            InitializeComponent();
            bind1();
            //textBox3.Text = DateTime.Now.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 public void bind()
 {
     string s = "E:\\ggg.mdb";

     OleDbDataAdapter adp = new OleDbDataAdapter("select pname,pno,sname,dd,tot_qty from purchase where pname like '"+textBox2.Text+"%' ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
     DataTable dt = new DataTable();
     adp.Fill(dt);
     dataGridView1.DataSource = dt;
        }
 public void binds()
 {

     string s = "E:\\ggg.mdb";

     OleDbDataAdapter adp = new OleDbDataAdapter("select pname,pno,sname,dd,tot_qty from purchase where dd like '" + textBox3.Text + "%'", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
     DataTable dt = new DataTable();
     adp.Fill(dt);
     dataGridView1.DataSource = dt;
 }
        public void bind_2()
        {


             string s = "E:\\ggg.mdb";

             OleDbDataAdapter adp = new OleDbDataAdapter("select pname,pno,sname,dd,tot_qty from purchase where sname like'" + textBox1.Text + "%'", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
     DataTable dt = new DataTable();
     adp.Fill(dt);
     dataGridView1.DataSource = dt;
            }
        public void bind1()
        {


            string s = "E:\\ggg.mdb";

            OleDbDataAdapter adp = new OleDbDataAdapter("select pname,pno,sname,dd,tot_qty from purchase ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
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
            bind_2();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bind();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            binds();
        }
        
    
    
    }
    }

