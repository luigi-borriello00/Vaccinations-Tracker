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
        DataClassesDataContext db = new DataClassesDataContext();

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
            this.nameNurse.Text = "";
            this.surnameNurse.Text = "";
            this.codNurse.Text = "";
            this.cellNurse.Text = "";
            this.mailNurse.Text = "";
        }

        private void residenceDelete_Click(object sender, EventArgs e)
        {
            this.residenceName.Text = "";
            this.residenceProv.Text = "";
            this.residenceCap.Text = "";
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

        private void InsertNurse_Click(object sender, EventArgs e)
        {
            if (this.nameNurse.Text == "" || this.surnameNurse.Text == "" || this.codNurse.Text == "" || this.cellNurse.Text == "" || this.mailNurse.Text == "" || this.residenceNurse.Text == "" || this.genderNurse.Text == "")
            {
                string message = "Inserisci tutti i campi";
                MessageBoxButtons box = MessageBoxButtons.OK;
                MessageBox.Show(message, "Error", box);
            }
            else
            {
                infermiere inf = new infermiere
                {   Nome = this.nameNurse.Text,
                    Cognome = this.surnameNurse.Text,
                    CodFiscale = this.codNurse.Text,
                    DataNascita = this.bdDate.Value,
                    IdOspedale = 1,
                    Mail = this.mailNurse.Text,
                    Telefono = this.cellNurse.Text,
                    Sesso = Convert.ToChar(this.genderNurse.Text[0]),
                    DataAssunzione = this.dateStartWork.Value,
                };
                db.infermiere.InsertOnSubmit(inf);

                // Submit the change to the database.
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc);
                    MessageBoxButtons box = MessageBoxButtons.OK;
                    MessageBox.Show("Impossibile inserire il valore", "Error", box);
                    // Make some adjustments.
                } 
            }
        }

        private void residenceInsert_Click(object sender, EventArgs e)
        {
            if (this.residenceName.Text == "" || this.residenceProv.Text == "" || this.residenceCap.Text == "")
            {
                string message = "Inserisci tutti i campi";
                MessageBoxButtons box = MessageBoxButtons.OK;
                MessageBox.Show(message, "Error", box);
            }
            else
            {
                residenza ord = new residenza
                {
                    CAP = Convert.ToInt32(this.residenceCap.Text),
                    Citta = this.residenceName.Text,
                    Provincia = this.residenceProv.Text,

                };

                db.residenza.InsertOnSubmit(ord);

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

        private void dirButton_Click(object sender, EventArgs e)
        {
            /*Vaccinazioni effettuate in un determinato giorno (specificare la data).
                
            Infermiere che ha effettuato più vaccinazioni.
            Infermieri che hanno eseguito più di TOT vaccinazioni (specificare il n°).
            Totale Pfizer/Moderna/Astrazeneca fatti in un mese.
             * 
             * 
             * 
             * */
            // Vaccinazioni effettuate in un determinato giorno (specificare la data).
            if (this.choiceDirector.SelectedIndex == 0)
            {
                var query = from V in db.vaccinazione
                            join P in db.paziente on V.IdPaziente equals P.IdPaziente
                            join I in db.infermiere on V.IdInfermiere equals I.IdInfermiere
                            where
                              V.DataEffettuazione == this.dateDir.Value
                            select new
                            {
                                DataEffettuazione = V.DataEffettuazione,
                                nRichiamo = V.nRichiamo,
                                DataRichiamo = V.DataRichiamo,
                                IdPaziente = V.IdPaziente,
                                IdInfermiere = V.IdInfermiere,
                                Nome_Paziente = P.Nome,
                                Cognome_Paziente = P.Cognome,
                                Nome_Infermiere = I.Nome,
                                Cognome_Infermiere = I.Cognome
                            };
                this.dataGridDir.DataSource = query;
            }

            // Numero di vaccinati per ogni città registrata.
            if (this.choiceDirector.SelectedIndex == 1)
            {
                var query = from residenza in db.residenza
                            select new
                            {
                                IdResidenza = residenza.IdResidenza,
                                Citta = residenza.Citta,
                                Provincia = residenza.Provincia,
                                CAP = residenza.CAP,
                                TotaleVaccinati = residenza.TotaleVaccinati
                            };
                this.dataGridDir.DataSource = query;
            }

            // Infermiere con più vaccinazioni
            if (this.choiceDirector.SelectedIndex == 2)
            {
                var query = from I in db.infermiere
                            join V in db.vaccinazione on I.IdInfermiere equals V.IdInfermiere
                            where
                              I.IdOspedale == 1
                            group I by new
                            {
                                I.IdInfermiere,
                                I.Nome,
                                I.Cognome,
                                I.CodFiscale,
                                I.DataNascita,
                                I.DataAssunzione,
                                I.Mail,
                                I.Telefono,
                                I.Sesso
                            } into g
                            orderby
                              g.Count() descending
                            select new
                            {
                                g.Key.IdInfermiere,
                                g.Key.Nome,
                                g.Key.Cognome,
                                g.Key.CodFiscale,
                                g.Key.DataNascita,
                                g.Key.DataAssunzione,
                                g.Key.Mail,
                                g.Key.Telefono,
                                g.Key.Sesso,
                                Numero_vaccinazioni_effettuate = g.Count()
                            };
                this.dataGridDir.DataSource = query.Take(1);
            }

            // Infermiere con più vaccinazioni in un mese

            if (this.choiceDirector.SelectedIndex == 3)
            {
                var query = from I in db.infermiere
                            join V in db.vaccinazione on I.IdInfermiere equals V.IdInfermiere
                            where
                              V.DataEffettuazione.Date.Month == this.dateDir.Value.Month
                            group I by new
                            {
                                I.Nome,
                                I.Cognome,
                                I.CodFiscale,
                                I.DataNascita,
                                I.DataAssunzione,
                                I.Telefono,
                                I.Mail,
                                I.Sesso
                            } into g
                            orderby
                              g.Count() descending,
                              g.Key.Cognome
                            select new
                            {
                                Vaccinazioni_effettuate = g.Count(),
                                g.Key.Nome,
                                g.Key.Cognome,
                                g.Key.CodFiscale,
                                g.Key.DataNascita,
                                g.Key.DataAssunzione,
                                g.Key.Telefono,
                                g.Key.Mail,
                                g.Key.Sesso
                            };
                this.dataGridDir.DataSource = query;
            }

                // Infermieri con più di tot Vaccinazioni
            if (this.choiceDirector.SelectedIndex == 4)
            {
                var query = from I in db.infermiere
                            join V in db.vaccinazione on I.IdInfermiere equals V.IdInfermiere
                            group I by new
                            {
                                I.IdInfermiere,
                                I.Nome,
                                I.Cognome,
                                I.CodFiscale,
                                I.DataNascita,
                                I.DataAssunzione,
                                I.Mail,
                                I.Telefono,
                                I.Sesso
                            } into g
                            where g.Count() > Convert.ToInt32(this.idDirText.Text)
                            select new
                            {
                                g.Key.IdInfermiere,
                                g.Key.Nome,
                                g.Key.Cognome,
                                g.Key.CodFiscale,
                                g.Key.DataNascita,
                                g.Key.DataAssunzione,
                                g.Key.Mail,
                                g.Key.Telefono,
                                g.Key.Sesso,
                                Vaccinazioni_effettuate = g.Count(),
                            };
                this.dataGridDir.DataSource = query;
            }

            // Tot vaccini mese per mese
            if (this.choiceDirector.SelectedIndex == 5)
            {
                var query = from V in db.vaccinazione
                            join P in db.paziente on V.IdPaziente equals P.IdPaziente
                            join VC in db.vaccino on P.IdVaccino equals VC.IdVaccino
                            group new { V, VC } by new
                            {
                                Mese = V.DataEffettuazione.Date.Month,
                                Vaccino = VC.Nome
                            } into g
                            orderby
                              g.Key.Mese,
                              g.Key.Vaccino
                            select new
                            {
                                Mese = g.Key.Mese,
                                N_vaccini_effettuati = g.Count(),
                                Vaccino = g.Key.Vaccino
                            };
                this.dataGridDir.DataSource = query;
            }
        }

        private void dataGridDir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
