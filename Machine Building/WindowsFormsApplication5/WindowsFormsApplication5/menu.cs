using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        int count;

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create_customer chForm = new create_customer();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_customer chForm = new view_customer();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_customer chForm = new update_customer();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_customer chForm = new delete_customer();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void addNewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            sub_assembly_information chForm = new sub_assembly_information();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void addNewToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            machine_information chForm = new machine_information();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            create_parts chForm = new create_parts();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            view_pats chForm = new view_pats();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            update_parts chForm = new update_parts();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            delete_patrs chForm = new delete_patrs();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void viewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            view_sub_assembly chForm = new view_sub_assembly();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void updateDeletePartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_sub_assembly chForm = new update_sub_assembly();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void deleteSubAssemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_sub_assembly chForm = new delete_sub_assembly();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void viewToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            view_machine chForm = new view_machine();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            update_machine chForm = new update_machine();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            delete_machine chForm = new delete_machine();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login chForm = new login();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_password chForm = new update_password();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void addNewToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form20 chForm = new Form20();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void updateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_vendor chForm = new delete_vendor();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void viewToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            view_vendor chForm = new view_vendor();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void addNewToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            purchase_info chForm = new purchase_info();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void udateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchase_update chForm = new purchase_update();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void deleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            delete_purchase chForm = new delete_purchase();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void viewToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            purchase_view chForm = new purchase_view();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void supplierCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDDNewToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            supplier chForm = new supplier();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void viewToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            view_supplier chForm = new view_supplier();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void updateToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Update_Supplier chForm = new Update_Supplier();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void deleteToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            delete_supplier chForm = new delete_supplier();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void iSSUEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iSSUEToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            
        }

        private void sALEToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void iSSUEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            issue chForm = new issue();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void vIEWToolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            view_issue chForm = new view_issue();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;
        }

        private void aDDNEWToolStripMenuItem4_Click_1(object sender, EventArgs e)
        {

            sale chForm = new sale();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;

        }

        private void vIEWToolStripMenuItem7_Click(object sender, EventArgs e)
        {

            view_sale chForm = new view_sale();
            //set parent form for the child window
            chForm.MdiParent = this;

            //increment the child form count
            count++;
            //set the title of the child window.
            chForm.Text = "Add/New Category Information";

            // chForm.fileloc = oFileDlg.FileName;

            //display the child window
            chForm.Show();
            chForm.WindowState = FormWindowState.Maximized;

        }
    }
}
