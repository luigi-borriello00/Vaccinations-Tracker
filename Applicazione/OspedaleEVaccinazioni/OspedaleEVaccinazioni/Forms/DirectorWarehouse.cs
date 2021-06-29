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
    public partial class DirectorWarehouse : Form
    {
        DataClassesDataContext db = new DataClassesDataContext();

        public DirectorWarehouse()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DirectorWarehouse_Load(object sender, EventArgs e)
        {

        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            DirectorForm form = new DirectorForm();
            form.Show();
        }

        private void stocksDelete_Click(object sender, EventArgs e)
        {
            this.stocksNumber.Text = "";
            this.stocksType.Text = "";
        }

        private void vaccineDelete_Click(object sender, EventArgs e)
        {
            this.vaccineInfo.Text = "";
            this.vaccineName.Text = "";
            this.vaccinePrice.Text = "";
            this.vaccineTime.Text = "";
            this.vaccineHouse.Text = "";
        }

        private void wareHouseDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void supplierDelete_Click(object sender, EventArgs e)
        {
            this.supplierCell.Text = "";
            this.supplierName.Text = "";
            this.supplierVaccine.Text = "";
        }

        private void DirectorWarehouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void vaccineInsert_Click(object sender, EventArgs e)
        {
            if (this.vaccineInfo.Text == "" || this.vaccineName.Text == "" || this.vaccinePrice.Text == "" || this.vaccineTime.Text == "" || this.vaccineHouse.Text == "")
            {
                string message = "Inserisci tutti i campi";
                MessageBoxButtons box = MessageBoxButtons.OK;
                MessageBox.Show(message, "Error", box);
            }
        }

        private void supplierInsert_Click(object sender, EventArgs e)
        {
            if (this.supplierVaccine.Text == "" || this.supplierName.Text == "" || this.supplierCell.Text == "")
            {
                string message = "Inserisci tutti i campi";
                MessageBoxButtons box = MessageBoxButtons.OK;
                MessageBox.Show(message, "Error", box);
            }
        }

        private void stocksInsert_Click(object sender, EventArgs e)
        {
            if (this.stocksType.Text == "" || this.stocksNumber.Text == "")
            {
                string message = "Inserisci tutti i campi";
                MessageBoxButtons box = MessageBoxButtons.OK;
                MessageBox.Show(message, "Error", box);
            }
        }
    }
}
