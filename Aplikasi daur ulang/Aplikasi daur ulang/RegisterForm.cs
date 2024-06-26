using Aplikasi_daur_ulang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_daur_ulang
{
    public partial class RegisterForm : Form
    {
        private object loginForm;

        public RegisterForm()
        {
            loginForm = new LoginForm(); // Example initialization
                                         // Other constructor logic
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // Your code here
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Handle registration logic here
            MessageBox.Show("Registered successfully!");
            // Assume registration logic here. If successful, open LoginForm or HomeForm.
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide(); // Hide the RegisterForm or use this.Close() to close it.
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close(); // Close the current form
        }
    }
}