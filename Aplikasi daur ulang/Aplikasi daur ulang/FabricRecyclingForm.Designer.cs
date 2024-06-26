
using Aplikasi_daur_ulang;

namespace Aplikasi_daur_ulang
{
    partial class FabricRecyclingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FabricRecyclingForm));
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
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
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(15, 346);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(352, 86);
            textBox1.TabIndex = 0;
            textBox1.Text = "1.Pengumpulan: \r\nKain bekas dikumpulkan dari rumah tangga dan industri.";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(15, 70);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 268);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(431, 70);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(352, 268);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(851, 70);
            pictureBox3.Margin = new Padding(4, 4, 4, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(352, 269);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(386, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(407, 33);
            label1.TabIndex = 4;
            label1.Text = "SIMULASI DAUR ULANG KAIN";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.YellowGreen;
            textBox2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(431, 344);
            textBox2.Margin = new Padding(4, 4, 4, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(352, 89);
            textBox2.TabIndex = 5;
            textBox2.Text = "2.Penyortiran: \r\nKain dipisahkan berdasarkan jenis serat dan warna.";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Info;
            textBox3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(851, 341);
            textBox3.Margin = new Padding(4, 4, 4, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(352, 113);
            textBox3.TabIndex = 6;
            textBox3.Text = "3.Pembersihan: \r\nKain yang telah di sortir berdasarkan jenis serat dan warna dicuci untuk menghilangkan noda dan kotoran.";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(15, 462);
            pictureBox4.Margin = new Padding(4, 4, 4, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(352, 269);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(431, 462);
            pictureBox5.Margin = new Padding(4, 4, 4, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(352, 269);
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.Location = new Point(851, 462);
            pictureBox6.Margin = new Padding(4, 4, 4, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(352, 269);
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.InactiveCaption;
            textBox4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(15, 741);
            textBox4.Margin = new Padding(4, 4, 4, 4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(352, 54);
            textBox4.TabIndex = 10;
            textBox4.Text = "4.Penghancuran: \r\nKain dihancurkan menjadi serat.";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.PeachPuff;
            textBox5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(431, 741);
            textBox5.Margin = new Padding(4, 4, 4, 4);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(352, 69);
            textBox5.TabIndex = 11;
            textBox5.Text = "5.Pemintalan: \r\nSerat dipintal menjadi benang.";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.SandyBrown;
            textBox6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(856, 741);
            textBox6.Margin = new Padding(4, 4, 4, 4);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(346, 98);
            textBox6.TabIndex = 12;
            textBox6.Text = "6.Pembuatan Kain Baru:\r\n Benang digunakan untuk membuat kain baru yang dapat dijahit menjadi pakaian atau produk tekstil lainnya.";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(15, 859);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(312, 156);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.MistyRose;
            btnBack.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(1004, 886);
            btnBack.Margin = new Padding(4, 4, 4, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(199, 48);
            btnBack.TabIndex = 14;
            btnBack.Text = "Kembali ke Home";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // FabricRecyclingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1214, 1069);
            Controls.Add(btnBack);
            Controls.Add(groupBox1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FabricRecyclingForm";
            Text = "FabricRecyclingForm";
            TopMost = true;
            Load += FabricRecyclingForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var homeForm = new HomeForm();
            homeForm.Show();
            this.Close(); // Close the current form
        }

        #endregion

        private TextBox textBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private GroupBox groupBox1;
        private Button btnBack;

        
    }
}