using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OspedaleEVaccinazioni
{
    public partial class NurseViewVaccination : Form
    {
        public NurseViewVaccination()
        {
            InitializeComponent();
        }

        private void NurseViewVaccination_FormClosing(object sender, FormClosingEventArgs e)
        {
            NurseForm form = new NurseForm();
            form.Show();
            this.Hide();
        }

        private void idNurseText_MouseClick(object sender, MouseEventArgs e)
        {
            this.idNurseText.Text = "";
        }
    }
}
