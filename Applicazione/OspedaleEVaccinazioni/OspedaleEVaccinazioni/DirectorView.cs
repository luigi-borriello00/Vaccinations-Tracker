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
    public partial class DirectorView : Form
    {
        public DirectorView()
        {
            InitializeComponent();
        }

        private void DirectorView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            DirectorForm form = new DirectorForm();
            form.Show();
        }
    }
}
