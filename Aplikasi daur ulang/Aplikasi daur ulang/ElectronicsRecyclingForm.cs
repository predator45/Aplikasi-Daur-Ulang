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
    public partial class ElectronicsRecyclingForm : Form
    {
        public ElectronicsRecyclingForm()
        {
            InitializeComponent();
        }

        private void ElectronicsRecyclingForm_Load(object sender, EventArgs e)
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
