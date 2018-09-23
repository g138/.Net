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
    public partial class view_vendor : Form
    {
        public view_vendor()
        {
            InitializeComponent();
            binds();
        }
        private void bind()
        {

            string s = "E:\\ggg.mdb";
            string constr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";";
            OleDbDataAdapter adp = new OleDbDataAdapter("select sname,pr from pext ", (constr));
            DataTable dt = new DataTable();
            adp.Fill(dt);
            //checkedListBox1.DataSource = dt;

            dataGridView1.DataSource = dt;



        }
        private void binds()
        {
            string s = "E:\\ggg.mdb";

            OleDbDataAdapter adp = new OleDbDataAdapter("select pname  from parts ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            comboBox1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bind();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
