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
    public partial class NurseForm : Form
    {
        public NurseForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NurseForm_Load(object sender, EventArgs e)
        {
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.Show();
        }

        private void NurseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DeletePatient_Click(object sender, EventArgs e)
        {
            this.namePatient.Text = "";
            this.surnamePatient.Text = "";
            this.codPatient.Text = "";
            this.cellPatient.Text = "";
            this.mailPatient.Text = "";
            this.residencePatient.Text = "";
        }

        private void InsertPatient_Click(object sender, EventArgs e)
        {

        }

        private void DeleteResidence_Click(object sender, EventArgs e)
        {
            this.city.Text = "";
            this.province.Text = "";
            this.cap.Text = "";
        }

        private void InsertResidence_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void deletePathology_Click(object sender, EventArgs e)
        {
            this.namePathology.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Vaccination_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void idNurseText_MouseClick(object sender, MouseEventArgs e)
        {
            this.idNurseText.Text = "";
        }
    }
}
