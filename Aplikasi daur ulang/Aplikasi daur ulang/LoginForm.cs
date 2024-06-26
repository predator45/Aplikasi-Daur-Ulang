
using Aplikasi_daur_ulang;
using System;
using System.Windows.Forms;

namespace Aplikasi_daur_ulang
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            // Assume login logic here. If successful, open HomeForm.
            var homeForm = new HomeForm();
            homeForm.Show();
            this.Hide(); // Hide the LoginForm or use this.Close() to close it.

            // Implement login verification logic here
            if (username == "user123" && password == "password123")
            {
                OpenHome();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide(); // Hide the LoginForm or use this.Close() to close it.
            _ = new RegisterForm();
            registerForm.Show();
        }

        private void OpenHome()
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }
    }
}
