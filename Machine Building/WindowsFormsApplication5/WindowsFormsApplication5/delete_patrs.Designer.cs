namespace WindowsFormsApplication5
{
    partial class delete_patrs
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.j = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.b,
            this.c,
            this.d,
            this.e,
            this.f,
            this.g,
            this.h,
            this.i,
            this.j,
            this.k});
            this.dataGridView1.Location = new System.Drawing.Point(14, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1183, 337);
            this.dataGridView1.TabIndex = 3;
            // 
            // a
            // 
            this.a.DataPropertyName = "pname";
            this.a.HeaderText = "Part Name";
            this.a.Name = "a";
            // 
            // b
            // 
            this.b.DataPropertyName = "pno";
            this.b.HeaderText = "Part Number";
            this.b.Name = "b";
            // 
            // c
            // 
            this.c.DataPropertyName = "prate";
            this.c.HeaderText = "Purchase Rate";
            this.c.Name = "c";
            // 
            // d
            // 
            this.d.DataPropertyName = "srate";
            this.d.HeaderText = "Sale Price";
            this.d.Name = "d";
            // 
            // e
            // 
            this.e.DataPropertyName = "rno";
            this.e.HeaderText = "Rack Number";
            this.e.Name = "e";
            // 
            // f
            // 
            this.f.DataPropertyName = "shell";
            this.f.HeaderText = "Shelf Number";
            this.f.Name = "f";
            // 
            // g
            // 
            this.g.DataPropertyName = "ob";
            this.g.HeaderText = "OB";
            this.g.Name = "g";
            // 
            // h
            // 
            this.h.DataPropertyName = "min";
            this.h.HeaderText = "Minimum Value";
            this.h.Name = "h";
            // 
            // i
            // 
            this.i.DataPropertyName = "max";
            this.i.HeaderText = "Maximum Value";
            this.i.Name = "i";
            // 
            // j
            // 
            this.j.DataPropertyName = "qty";
            this.j.HeaderText = "Order Quantity";
            this.j.Name = "j";
            // 
            // k
            // 
            this.k.DataPropertyName = "remark";
            this.k.HeaderText = "Remarks";
            this.k.Name = "k";
            // 
            // delete_patrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 514);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "delete_patrs";
            this.Text = "Form11";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn d;
        private System.Windows.Forms.DataGridViewTextBoxColumn e;
        private System.Windows.Forms.DataGridViewTextBoxColumn f;
        private System.Windows.Forms.DataGridViewTextBoxColumn g;
        private System.Windows.Forms.DataGridViewTextBoxColumn h;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn j;
        private System.Windows.Forms.DataGridViewTextBoxColumn k;
    }
}