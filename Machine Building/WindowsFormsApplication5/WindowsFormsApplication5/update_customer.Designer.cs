﻿namespace WindowsFormsApplication5
{
    partial class update_customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.j = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.b,
            this.d,
            this.e,
            this.f,
            this.g,
            this.h,
            this.i,
            this.j,
            this.K});
            this.dataGridView1.Location = new System.Drawing.Point(14, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 330);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(145, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // a
            // 
            this.a.DataPropertyName = "cid";
            this.a.HeaderText = "Id";
            this.a.Name = "a";
            this.a.ReadOnly = true;
            // 
            // b
            // 
            this.b.DataPropertyName = "cname";
            this.b.HeaderText = "Name";
            this.b.Name = "b";
            // 
            // d
            // 
            this.d.DataPropertyName = "company_name";
            this.d.HeaderText = "Company Name";
            this.d.Name = "d";
            // 
            // e
            // 
            this.e.DataPropertyName = "address";
            this.e.HeaderText = "Address";
            this.e.Name = "e";
            // 
            // f
            // 
            this.f.DataPropertyName = "cno";
            this.f.HeaderText = "Contact No";
            this.f.Name = "f";
            // 
            // g
            // 
            this.g.DataPropertyName = "eid";
            this.g.HeaderText = "Email Id";
            this.g.Name = "g";
            // 
            // h
            // 
            this.h.DataPropertyName = "reffer";
            this.h.HeaderText = "Reffered By";
            this.h.Name = "h";
            // 
            // i
            // 
            this.i.DataPropertyName = "din";
            this.i.HeaderText = "Deals In";
            this.i.Name = "i";
            // 
            // j
            // 
            this.j.DataPropertyName = "gstno";
            this.j.HeaderText = "GST NO.";
            this.j.Name = "j";
            // 
            // K
            // 
            this.K.DataPropertyName = "tino";
            this.K.HeaderText = "TIN NO.";
            this.K.Name = "K";
            // 
            // update_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 647);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "update_customer";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.update_customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn d;
        private System.Windows.Forms.DataGridViewTextBoxColumn e;
        private System.Windows.Forms.DataGridViewTextBoxColumn f;
        private System.Windows.Forms.DataGridViewTextBoxColumn g;
        private System.Windows.Forms.DataGridViewTextBoxColumn h;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn j;
        private System.Windows.Forms.DataGridViewTextBoxColumn K;
    }
}