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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
            binds();
            bind();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bind()
        {

            string s = "E:\\ggg.mdb";
            string constr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";";
            OleDbDataAdapter adp = new OleDbDataAdapter("select sname from supplier_info ", (constr));
            DataTable dt = new DataTable();
            adp.Fill(dt);
            //checkedListBox1.DataSource = dt;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                checkedListBox1.Items.Add(dt.Rows[i]["sname"].ToString());

            }



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
            string s = "E:\\ggg.mdb";
            string constr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";";
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = constr;
            con.Open();
            string sl;
            int k = 1;
            int flag = 0;
            OleDbCommand cmd = new OleDbCommand();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
                {
                    sl = checkedListBox1.Items[i].ToString();
                    cmd.CommandText = "insert into pext values('" + sl + "','" + comboBox1.SelectedValue.ToString() + "'," + k + ")";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    flag = 1;
                }

            }
            if (flag == 1)
            {
                MessageBox.Show("Data saved");
            }
        }
    }
}
