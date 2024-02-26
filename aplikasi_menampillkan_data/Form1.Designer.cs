namespace aplikasi_menampillkan_data
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.makanan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.warna = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kesimpulan = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleName = "label";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukan nama anda";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(196, 26);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(270, 20);
            this.nama.TabIndex = 1;
            this.nama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.warna);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.makanan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nama);
            this.groupBox1.Location = new System.Drawing.Point(36, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 147);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AccessibleName = "label";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Masukan makanan favorite";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // makanan
            // 
            this.makanan.Location = new System.Drawing.Point(196, 61);
            this.makanan.Name = "makanan";
            this.makanan.Size = new System.Drawing.Size(270, 20);
            this.makanan.TabIndex = 3;
            this.makanan.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AccessibleName = "label";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Masukan warna favorite";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // warna
            // 
            this.warna.Location = new System.Drawing.Point(196, 97);
            this.warna.Name = "warna";
            this.warna.Size = new System.Drawing.Size(270, 20);
            this.warna.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 91);
            this.button1.TabIndex = 6;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kesimpulan);
            this.groupBox2.Location = new System.Drawing.Point(36, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(604, 155);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // kesimpulan
            // 
            this.kesimpulan.AccessibleName = "kesimpulan";
            this.kesimpulan.AutoSize = true;
            this.kesimpulan.Location = new System.Drawing.Point(19, 20);
            this.kesimpulan.Name = "kesimpulan";
            this.kesimpulan.Size = new System.Drawing.Size(61, 13);
            this.kesimpulan.TabIndex = 0;
            this.kesimpulan.Text = "Kesimpulan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox makanan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox warna;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label kesimpulan;
    }
}

