using System;

namespace Aplikasi_daur_ulang
{
    partial class PlasticRecyclingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlasticRecyclingForm));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(416, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 194);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(14, 349);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(317, 194);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(826, 57);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(317, 194);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(14, 57);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(317, 194);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(416, 349);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(317, 194);
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(826, 349);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(317, 194);
            pictureBox6.TabIndex = 11;
            pictureBox6.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkGray;
            textBox1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(14, 257);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(317, 86);
            textBox1.TabIndex = 12;
            textBox1.Text = "1.Pengumpulan: \r\nPlastik bekas dikumpulkan dari berbagai sumber seperti rumah tangga, industri, dan tempat pembuangan sampah.";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkGray;
            textBox2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(416, 257);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(317, 86);
            textBox2.TabIndex = 13;
            textBox2.Text = "2. Penyortiran:\r\n Plastik dipisahkan berdasarkan jenis dan warna.";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DarkGray;
            textBox3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(14, 549);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(317, 66);
            textBox3.TabIndex = 14;
            textBox3.Text = "4.Penghancuran:\r\n Plastik dihancurkan menjadi serpihan kecil.";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DarkGray;
            textBox4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(826, 257);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(317, 86);
            textBox4.TabIndex = 15;
            textBox4.Text = " 3.Pencucian: \r\nPlastik dicuci untuk menghilangkan kotoran, residu, dan kontaminan.";
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.DarkGray;
            textBox5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(416, 549);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(317, 66);
            textBox5.TabIndex = 16;
            textBox5.Text = "5.Pemrosesan:\r\n Serpihan plastik dilelehkan dan dibentuk menjadi pelet plastik.";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.DarkGray;
            textBox6.Location = new Point(826, 549);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(317, 79);
            textBox6.TabIndex = 17;
            textBox6.Text = "6.Produksi Ulang:\r\n Pelet digunakan untuk membuat produk plastik baru seperti botol, wadah, dan lain-lain.";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGray;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(383, 9);
            label1.Name = "label1";
            label1.Size = new Size(454, 33);
            label1.TabIndex = 18;
            label1.Text = "SIMULASI DAUR ULANG PLASTIK";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Location = new Point(24, 646);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kesimpulan";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.MistyRose;
            btnBack.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(873, 646);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(270, 38);
            btnBack.TabIndex = 20;
            btnBack.Text = "Kembali ke Home";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // PlasticRecyclingForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1115, 813);
            Controls.Add(btnBack);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "PlasticRecyclingForm";
            Text = "PlasticRecyclingForm";
            Load += PlasticRecyclingForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnBack;
    }
}