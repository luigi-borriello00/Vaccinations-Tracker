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
            this.stocksId.Text = "";
            this.stocksNumber.Text = "";
        }

        private void vaccineDelete_Click(object sender, EventArgs e)
        {
            this.vaccineId.Text = "";
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
            this.supplierId.Text = "";
            this.supplierName.Text = "";
        }

        private void DirectorWarehouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
