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
    public partial class view_supplier : Form
    {
        public view_supplier()
        {
            InitializeComponent();
            bind();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void view_supplier_Load(object sender, EventArgs e)
        {

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
        private void bind1()
        {
            string s = "E:\\ggg.mdb";
           //string s1 = "Supplier";
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from supplier_info where sname like '"+textBox1.Text+"%' ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void binds()
        {
            string s = "E:\\ggg.mdb";
            //string s1 = "Supplier";
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from supplier_info where  company_name like '" + textBox2.Text + "%' ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void button1_Click_1(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bind1();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            binds();
        }
    }
}
