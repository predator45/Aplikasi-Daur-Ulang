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
    public partial class FabricRecyclingForm : Form
    {
        public FabricRecyclingForm()
        {
            InitializeComponent();
        }

        private void FabricRecyclingForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var homeForm = new HomeForm();
            homeForm.Show();
            this.Close(); // Close the current form
        }

       
    }
}
