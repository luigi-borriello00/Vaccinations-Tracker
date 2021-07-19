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
            // TODO: questa riga di codice carica i dati nella tabella 'covid19TrackerDataSet8.fornitore'. È possibile spostarla o rimuoverla se necessario.
            this.fornitoreTableAdapter.Fill(this.covid19TrackerDataSet8.fornitore);
            // TODO: questa riga di codice carica i dati nella tabella 'covid19TrackerDataSet7.vaccino'. È possibile spostarla o rimuoverla se necessario.
            this.vaccinoTableAdapter.Fill(this.covid19TrackerDataSet7.vaccino);
            // TODO: questa riga di codice carica i dati nella tabella 'covid19TrackerDataSet6.dosi'. È possibile spostarla o rimuoverla se necessario.
            this.dosiTableAdapter.Fill(this.covid19TrackerDataSet6.dosi);

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

            else
            {
                vaccino vac = new vaccino
                {
                    CasaFarmaceutica = this.vaccineHouse.Text,
                    Nome = this.vaccineName.Text,
                    Info = this.vaccineInfo.Text,
                    PrezzoUnitario = Convert.ToInt32(this.vaccinePrice.Text),
                    Richiamo = Convert.ToInt32(this.vaccineTime.Text),
                };

                db.vaccino.InsertOnSubmit(vac);
                // Submit the change to the database.
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc);
                    MessageBoxButtons box = MessageBoxButtons.OK;
                    MessageBox.Show(exc.Message, "Error", box);
                    // Make some adjustments.
                }
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
            else
            {
                fornitore forn = new fornitore
                {
                    NomeFornitore = this.supplierName.Text,
                    IdVaccino = (int) this.supplierVaccine.SelectedValue,
                    Telefono = this.supplierCell.Text,
                };

                db.fornitore.InsertOnSubmit(forn);

                // Submit the change to the database.
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc);
                    MessageBoxButtons box = MessageBoxButtons.OK;
                    MessageBox.Show(exc.Message, "Error", box);
                    // Make some adjustments.
                }
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
            else
            {
                var querydosi = from dosi in db.dosi
                                where
                                dosi.IdVaccino == (int) this.stocksType.SelectedValue
                                select dosi;
                foreach (var dosi in querydosi)
                {
                    dosi.TotDosi = (dosi.TotDosi + Convert.ToInt32(this.stocksNumber.Text));
                }
                db.SubmitChanges();
            }
        }

        private void wareViewButt_Click(object sender, EventArgs e)
        {
            if(this.warechoice.SelectedIndex == 0)
            {
                var query = from D in db.dosi
                            join V in db.vaccino on D.IdVaccino equals V.IdVaccino
                            select new
                            {
                                D.TotDosi,
                                IdVaccino = V.IdVaccino,
                                Nome = V.Nome,
                                CasaFarmaceutica = V.CasaFarmaceutica,
                                Richiamo = V.Richiamo,
                                Info = V.Info,
                                PrezzoUnitario = V.PrezzoUnitario
                            };
                this.gridWare.DataSource = query;
            }
            if (this.warechoice.SelectedIndex == 1)
            {
                var query = from F in db.fornitore
                            join V in db.vaccino on F.IdVaccino equals V.IdVaccino
                            orderby
                              V.Nome
                            select new
                            {
                                IdFornitore = F.IdFornitore,
                                NomeFornitore = F.NomeFornitore,
                                Telefono = F.Telefono,
                                IdVaccino = F.IdVaccino,
                                NomeVaccino = V.Nome
                            };
                this.gridWare.DataSource = query;
            }
        }
    }
}
