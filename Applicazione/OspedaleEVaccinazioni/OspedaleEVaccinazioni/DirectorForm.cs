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
    public partial class DirectorForm : Form
    {
        public DirectorForm()
        {
            InitializeComponent();
        }

        private void DirectorForm_Load(object sender, EventArgs e)
        {

        }

        private void DirectorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.Show();
        }

        private void goToWareHouse_Click(object sender, EventArgs e)
        {
            this.Hide();
            DirectorWarehouse form = new DirectorWarehouse();
            form.Show();
        }

        private void DeletePatient_Click(object sender, EventArgs e)
        {
            this.idInfermiere.Text = "";
            this.nameNurse.Text = "";
            this.surnameNurse.Text = "";
            this.codNurse.Text = "";
            this.cellNurse.Text = "";
            this.mailNurse.Text = "";
        }

        private void residenceDelete_Click(object sender, EventArgs e)
        {
            this.residenceId.Text = "";
            this.residenceName.Text = "";
            this.residenceProv.Text = "";
        }

        private void goToView_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
