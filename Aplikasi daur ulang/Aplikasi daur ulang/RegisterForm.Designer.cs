using System;
using System.Windows.Forms;

namespace Aplikasi_daur_ulang
{
    partial class RegisterForm
    {
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            emailLabel = new Label();
            emailTextBox = new TextBox();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            registerButton = new Button();
            panel1 = new Panel();
            btnBack = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(47, 103);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(207, 23);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Masukan Email Anda:";
            emailLabel.Click += emailLabel_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(39, 129);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(265, 27);
            emailTextBox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            passwordLabel.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(39, 159);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(251, 23);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Masukan Password Anda:";
            passwordLabel.Click += passwordLabel_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(39, 185);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(265, 27);
            passwordTextBox.TabIndex = 3;
            // 
            // registerButton
            // 
            registerButton.BackColor = SystemColors.Highlight;
            registerButton.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerButton.Location = new Point(39, 218);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(100, 50);
            registerButton.TabIndex = 4;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += RegisterButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(registerButton);
            panel1.Controls.Add(emailLabel);
            panel1.Controls.Add(emailTextBox);
            panel1.Controls.Add(passwordLabel);
            panel1.Location = new Point(255, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 316);
            panel1.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.IndianRed;
            btnBack.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(145, 218);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(159, 50);
            btnBack.TabIndex = 21;
            btnBack.Text = "Kembali ke Halaman Login";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(86, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 97);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 584);
            Controls.Add(panel1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label emailLabel;
        private TextBox emailTextBox;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Button registerButton;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnBack;
    }
}