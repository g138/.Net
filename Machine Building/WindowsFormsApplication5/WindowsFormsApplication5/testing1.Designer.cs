namespace WindowsFormsApplication5
{
    partial class testing1
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
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.j = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
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
            this.k});
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1011, 253);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // a
            // 
            this.a.DataPropertyName = "sid";
            this.a.HeaderText = "Id";
            this.a.Name = "a";
            this.a.ReadOnly = true;
            // 
            // b
            // 
            this.b.DataPropertyName = "sname";
            this.b.HeaderText = "Name";
            this.b.Name = "b";
            this.b.ReadOnly = true;
            // 
            // d
            // 
            this.d.DataPropertyName = "company_name";
            this.d.HeaderText = "Company Name";
            this.d.Name = "d";
            this.d.ReadOnly = true;
            // 
            // e
            // 
            this.e.DataPropertyName = "address";
            this.e.HeaderText = "Address";
            this.e.Name = "e";
            this.e.ReadOnly = true;
            // 
            // f
            // 
            this.f.DataPropertyName = "cno";
            this.f.HeaderText = "Contact No";
            this.f.Name = "f";
            this.f.ReadOnly = true;
            // 
            // g
            // 
            this.g.DataPropertyName = "eid";
            this.g.HeaderText = "Email Id";
            this.g.Name = "g";
            this.g.ReadOnly = true;
            // 
            // h
            // 
            this.h.DataPropertyName = "reffer";
            this.h.HeaderText = "Reffered By";
            this.h.Name = "h";
            this.h.ReadOnly = true;
            // 
            // i
            // 
            this.i.DataPropertyName = "din";
            this.i.HeaderText = "Deals In";
            this.i.Name = "i";
            this.i.ReadOnly = true;
            // 
            // j
            // 
            this.j.DataPropertyName = "gstno";
            this.j.HeaderText = "GST NO.";
            this.j.Name = "j";
            // 
            // k
            // 
            this.k.DataPropertyName = "tino";
            this.k.HeaderText = "TIN NO.";
            this.k.Name = "k";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // testing1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 414);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "testing1";
            this.Text = "testing1";
            this.Load += new System.EventHandler(this.testing1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn d;
        private System.Windows.Forms.DataGridViewTextBoxColumn e;
        private System.Windows.Forms.DataGridViewTextBoxColumn f;
        private System.Windows.Forms.DataGridViewTextBoxColumn g;
        private System.Windows.Forms.DataGridViewTextBoxColumn h;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn j;
        private System.Windows.Forms.DataGridViewTextBoxColumn k;
        private System.Windows.Forms.Button button1;
    }
}