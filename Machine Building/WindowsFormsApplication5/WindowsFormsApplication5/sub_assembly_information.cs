using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.OleDb;
namespace WindowsFormsApplication5
{
    public partial class sub_assembly_information : Form
    {
        public sub_assembly_information()
        {
            InitializeComponent();
                bind1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Close();
        }
        //public Boolean checkvalid()
        //{

        //    ep1.Dispose();
        //    int check = 0;

        //    if (textBox1.Text == "")
        //    {
        //        ep1.SetError(textBox1, "Enter Sub Assembly Name");
        //        check = 1;
        //    }


        //    if (check == 1)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }


        //}
        //private void bind()
        //{

        //    string s = "E:\\ggg.mdb";
        //    string constr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";";
        //    OleDbDataAdapter adp = new OleDbDataAdapter("select pname,pno from parts ", (constr));
        //    DataTable dt = new DataTable();
        //    adp.Fill(dt);
        //    //checkedListBox1.DataSource = dt;

        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        checkedListBox1.Items.Add(dt.Rows[i]["pname"].ToString());
             
        //    }



        //}

        private void button1_Click(object sender, EventArgs e)
        {
        //    if (checkvalid() == true)
        //    {
        //     string s = "E:\\ggg.mdb";
        //    string constr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";";
        //    OleDbConnection con = new OleDbConnection();
        //    con.ConnectionString = constr;
        //    con.Open();
        //    string sl;
        //    int k = 1;
        //    int flag = 0;
        //    OleDbCommand cmd = new OleDbCommand();
        //             OleDbCommand cmde = new OleDbCommand();
        //          cmde.CommandText = "select * from sassembly where sub='"+textBox1.Text+"'";
        //          cmde.Connection = con;
        //       OleDbDataReader dim;
        //          dim = cmde.ExecuteReader();
        //       if(dim.HasRows){
        //      MessageBox.Show("Sub Assembly Name Already Exists");
        //       }
               
        //       else{
        //    for (int i = 0; i < checkedListBox1.Items.Count; i++){
        //        if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
        //        {
        //            sl = checkedListBox1.Items[i].ToString() ;
        //            cmd.CommandText = "insert into sassembly values('"+textBox1.Text+"','"+sl+"','"+k+"')";
        //            cmd.Connection = con;
        //            cmd.ExecuteNonQuery();
        //            cmd.Dispose();
        //            flag = 1;
        //        }
           
        //}
        //    }
        //if(flag==1){
        //    MessageBox.Show("Data saved");
        //}
        //}
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }
        public void bind()
        {
            string s = "E:\\ggg.mdb";

            OleDbDataAdapter adp = new OleDbDataAdapter("select pname,pno,shell,rno from parts where pname like '" + textBox3.Text + "%' ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void binds()
        {

            string s = "E:\\ggg.mdb";

            OleDbDataAdapter adp = new OleDbDataAdapter("select pname,pno,shell,rno from parts where pno like '" + textBox5.Text + "%'  ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void bind7()
        {

            string s = "E:\\ggg.mdb";

            OleDbDataAdapter adp = new OleDbDataAdapter("select pname,pno,qty,shell,rno from parts where pno=null  ", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        public void bind1()
        {

            string s = "E:\\ggg.mdb";

            OleDbDataAdapter adp = new OleDbDataAdapter("select pname,pno,qty,shell,rno from parts", "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + s + ";");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView2.Rows.Add(dataGridView1.SelectedRows[0].Cells["a"].Value.ToString(), dataGridView1.SelectedRows[0].Cells["b"].Value.ToString(), textBox4.Text, dataGridView1.SelectedRows[0].Cells["c"].Value.ToString(), dataGridView1.SelectedRows[0].Cells["d"].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Select Entire Row");
            }
            }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {


                try
                {
                    dataGridView2.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                }
                catch
                {
                    MessageBox.Show("Select Entire Row");
                }
               }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\ggg.mdb";
            con.Open();
            OleDbCommand cmd2 = new OleDbCommand();
            int you, sew;
            sew = Convert.ToInt32(dataGridView2.RowCount.ToString());
            for (you = 0; you < (sew - 1); you++)
            {
                cmd2.CommandText = "insert into [sassembly] values('" + textBox1.Text + "','" + dataGridView2.Rows[you].Cells["p"].Value.ToString() + "','" + dataGridView2.Rows[you].Cells["i"].Value.ToString() + "','" + dataGridView2.Rows[you].Cells["u"].Value.ToString() + "','" + dataGridView2.Rows[you].Cells["y"].Value.ToString() + "','" + textBox2.Text + "','" + dataGridView2.Rows[you].Cells["o"].Value.ToString() + "')";
                cmd2.Connection = con;

                cmd2.ExecuteNonQuery();
                cmd2.Dispose();
            }

            OleDbConnection con1 = new OleDbConnection();
            con1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\ggg.mdb";
            con1.Open();
            OleDbCommand cmd1 = new OleDbCommand();
            
            
                cmd1.CommandText = "insert into [sassembly1] values('" + textBox1.Text + "','"+textBox2.Text+"')";
                cmd1.Connection = con;

                cmd1.ExecuteNonQuery();
                cmd1.Dispose();
            
            bind7();
            MessageBox.Show("Data Saved");
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            bind();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            binds();
        }

        private void dataGridView1_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }

        }
    }

