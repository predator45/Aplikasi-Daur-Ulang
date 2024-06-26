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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
            this.Hide();
        }

        private void plastikButton_Click(object sender, EventArgs e)
        {
            PlasticRecyclingForm plasticForm = new PlasticRecyclingForm();
            plasticForm.Show();
            this.Hide();
        }

        private void kacaButton_Click(object sender, EventArgs e)
        {
            GlassRecyclingForm glassForm = new GlassRecyclingForm();
            glassForm.Show();
            this.Hide();
        }

        private void kainButton_Click(object sender, EventArgs e)
        {
            FabricRecyclingForm fabricForm = new FabricRecyclingForm();
            fabricForm.Show();
            this.Hide();
        }

        private void kertasButton_Click(object sender, EventArgs e)
        {
            PaperRecyclingForm paperForm = new PaperRecyclingForm();
            paperForm.Show();
            this.Hide();
        }

        private void elektronikButton_Click(object sender, EventArgs e)
        {
            ElectronicsRecyclingForm electronicsForm = new ElectronicsRecyclingForm();
            electronicsForm.Show();
            this.Hide();
        }

        private void minyakButton_Click(object sender, EventArgs e)
        {
            OilRecyclingForm oilForm = new OilRecyclingForm();
            oilForm.Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form (HomeForm) to return to LoginForm
        }
    }
}
