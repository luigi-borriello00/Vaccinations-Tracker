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
        DataClassesDataContext db = new DataClassesDataContext();

        public NurseForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NurseForm_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'covid19TrackerDataSet5.paziente'. È possibile spostarla o rimuoverla se necessario.
            this.pazienteTableAdapter.Fill(this.covid19TrackerDataSet5.paziente);
            // TODO: questa riga di codice carica i dati nella tabella 'covid19TrackerDataSet4.infermiere'. È possibile spostarla o rimuoverla se necessario.
            this.infermiereTableAdapter.Fill(this.covid19TrackerDataSet4.infermiere);
            // TODO: questa riga di codice carica i dati nella tabella 'covid19TrackerDataSet3.patologia'. È possibile spostarla o rimuoverla se necessario.
            this.patologiaTableAdapter.Fill(this.covid19TrackerDataSet3.patologia);
            // TODO: questa riga di codice carica i dati nella tabella 'covid19TrackerDataSet2.residenza'. È possibile spostarla o rimuoverla se necessario.
            this.residenzaTableAdapter.Fill(this.covid19TrackerDataSet2.residenza);
            // TODO: questa riga di codice carica i dati nella tabella 'covid19TrackerDataSet1.vaccino'. È possibile spostarla o rimuoverla se necessario.
            this.vaccinoTableAdapter1.Fill(this.covid19TrackerDataSet1.vaccino);
            // TODO: questa riga di codice carica i dati nella tabella 'covid19TrackerDataSet.vaccino'. È possibile spostarla o rimuoverla se necessario.
            this.vaccinoTableAdapter.Fill(this.covid19TrackerDataSet.vaccino);
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
        }

        private void InsertPatient_Click(object sender, EventArgs e)
        {
            if (this.namePatient.Text == "" || this.surnamePatient.Text == "" || this.codPatient.Text == "" || this.cellPatient.Text == "" || this.mailPatient.Text == "" || this.residencePatient.Text == "" || this.genderPatient.Text == "" || this.vaccineBox.Text == "" || this.nurseCombo.Text == "")
            {
                string message = "Inserisci tutti i campi";
                MessageBoxButtons box = MessageBoxButtons.OK;
                MessageBox.Show(message, "Error", box);
            }
            else
            {
                paziente paz;
                if(this.pathologyBox.Text == "")
                {
                    paz = new paziente
                    {
                        Nome = this.namePatient.Text,
                        Cognome = this.surnamePatient.Text,
                        CodFiscale = this.codPatient.Text,
                        DataNascita = this.datePatient.Value,
                        IdOspedale = 1,
                        IdResidenza = (int)this.residencePatient.SelectedValue,
                        IdVaccino = (int)this.vaccineBox.SelectedValue,
                        Mail = this.mailPatient.Text,
                        Telefono = this.cellPatient.Text,
                        Sesso = Convert.ToChar(this.genderPatient.Text[0]),

                    };
                }
                else
                {
                    paz = new paziente
                    {
                        Nome = this.namePatient.Text,
                        Cognome = this.surnamePatient.Text,
                        CodFiscale = this.codPatient.Text,
                        DataNascita = this.datePatient.Value,
                        IdOspedale = 1,
                        IdPatologia = (int)this.pathologyBox.SelectedValue,
                        IdResidenza = (int)this.residencePatient.SelectedValue,
                        IdVaccino = (int)this.vaccineBox.SelectedValue,
                        Mail = this.mailPatient.Text,
                        Telefono = this.cellPatient.Text,
                        Sesso = Convert.ToChar(this.genderPatient.Text[0]),
                    };
                }
                
                db.paziente.InsertOnSubmit(paz);

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
                var selectedVaxRecNum = from v in db.vaccino
                                                        where v.IdVaccino == (int) vaccineBox.SelectedValue
                                                        select v.Richiamo;
                vaccinazione vaz = new vaccinazione
                {
                    IdInfermiere = (int)this.nurseCombo.SelectedValue,
                    DataEffettuazione = this.vaccinationDate.Value,
                    IdPaziente = paz.IdPaziente,
                    nRichiamo = 1,
                    DataRichiamo = this.vaccinationDate.Value.AddDays(Convert.ToDouble(selectedVaxRecNum.Single())),

                };
                db.vaccinazione.InsertOnSubmit(vaz);

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

                var querydosi = from dosi in db.dosi
                                where dosi.IdVaccino == (int)this.vaccineBox.SelectedValue
                                select dosi;
                foreach (var dosi in querydosi)
                {
                    dosi.TotDosi = (int)(dosi.TotDosi - 1);
                }
                db.SubmitChanges();

                // Update totVaccinati in Residenza

                var queryresidenza = from residenza in db.residenza
                                     where residenza.IdResidenza == paz.IdResidenza
                                     select residenza;
                foreach (var residenza in queryresidenza)
                {
                    residenza.TotaleVaccinati = (residenza.TotaleVaccinati + 1);
                }
                db.SubmitChanges();

            }
        }

        private void DeleteResidence_Click(object sender, EventArgs e)
        {
            this.city.Text = "";
            this.province.Text = "";
            this.cap.Text = "";
        }

        private void InsertResidence_Click(object sender, EventArgs e)
        {
            if (this.city.Text == "" || this.province.Text == "" || this.cap.Text == "")
            {
                string message = "Inserisci tutti i campi";
                MessageBoxButtons box = MessageBoxButtons.OK;
                MessageBox.Show(message, "Error", box);
            }
            else
            {
                residenza ord = new residenza
                {
                    CAP = Convert.ToInt32(cap.Text),
                    Citta = this.city.Text,
                    Provincia = this.province.Text,
                   
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
                    MessageBox.Show("Impossibile inserire il valore", "Error", box);
                    // Make some adjustments.
                }
            }
            nurseGridView.DataSource = from r in db.residenza
                                       select r;
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void deletePathology_Click(object sender, EventArgs e)
        {
            this.namePathology.Text = "";
            this.patologyDesc.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Vaccination_Click(object sender, EventArgs e)
        {
            // Vaccination by the Patient
            if (nurseViewCombo.SelectedIndex == 0)
            {
                var query = from V in db.vaccinazione
                            join P in db.paziente on V.IdPaziente equals P.IdPaziente
                            join R in db.residenza on P.IdResidenza equals R.IdResidenza
                            join Va in db.vaccino on P.IdVaccino equals Va.IdVaccino
                            join Pa in db.patologia on new { IdPatologia = Convert.ToInt32(P.IdPatologia) } equals new { IdPatologia = Pa.IdPatologia } into Pa_join
                            from Pa in Pa_join.DefaultIfEmpty()
                            where
                              P.IdPaziente == Convert.ToInt32(this.idNurseText.Text)
                            select new
                            {
                                V.DataEffettuazione,
                                V.nRichiamo,
                                V.DataRichiamo,
                                P.Nome,
                                P.Cognome,
                                P.DataNascita,
                                P.Sesso,
                                P.CodFiscale,
                                P.Telefono,
                                P.Mail,
                                R.Citta,
                                Patologia = Pa.NomePatologia,
                                Vaccino = Va.Nome
                            };
                nurseGridView.DataSource = query;
            }

            // All Vaccination by the nurse
            if (this.nurseViewCombo.SelectedIndex == 1)
            {
                var query = from V in db.vaccinazione
                            join P in db.paziente on V.IdPaziente equals P.IdPaziente
                            join R in db.residenza on P.IdResidenza equals R.IdResidenza
                            join Va in db.vaccino on P.IdVaccino equals Va.IdVaccino
                            join Pa in db.patologia on new { IdPatologia = Convert.ToInt32(P.IdPatologia) } equals new { IdPatologia = Pa.IdPatologia } into Pa_join
                            from Pa in Pa_join.DefaultIfEmpty()
                            where
                              V.IdInfermiere == Convert.ToInt32(this.idNurseText.Text)
                            select new
                            {
                                V.DataEffettuazione,
                                V.nRichiamo,
                                V.DataRichiamo,
                                P.Nome,
                                P.Cognome,
                                P.DataNascita,
                                P.Sesso,
                                P.CodFiscale,
                                P.Telefono,
                                P.Mail,
                                R.Citta,
                                Patologia = Pa.NomePatologia,
                                Vaccino = Va.Nome
                            };
                nurseGridView.DataSource = query;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void idNurseText_MouseClick(object sender, MouseEventArgs e)
        {
            this.idNurseText.Text = "";
        }

        private void insertPathology_Click(object sender, EventArgs e)
        {
            if (this.patologyDesc.Text == "" || this.namePathology.Text == "")
            {
                string message = "Inserisci tutti i campi";
                MessageBoxButtons box = MessageBoxButtons.OK;
                MessageBox.Show(message, "Error", box);
            }
            else
            {
                patologia pat = new patologia
                {
                    Descrizione = patologyDesc.Text,
                    NomePatologia = namePathology.Text,

                };

                db.patologia.InsertOnSubmit(pat);

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

        private void recallDelete_Click(object sender, EventArgs e)
        {
            this.recallNumber.Text = "";
            this.comboNurse.Text = "";
            this.patientCombo.Text = "";
        }

        private void recallInsert_Click(object sender, EventArgs e)
        {
            if (this.recallNumber.Text == "" || this.patientCombo.Text == "" || this.comboNurse.Text == "")
            {
                string message = "Inserisci tutti i campi";
                MessageBoxButtons box = MessageBoxButtons.OK;
                MessageBox.Show(message, "Error", box);
            }
            else
            {
                var selectedVaxRecNum = from v in db.vaccino
                                        join p in db.paziente on v.IdVaccino equals p.IdVaccino
                                        where p.IdPaziente == (int) this.patientCombo.SelectedValue
                                        select v.Richiamo;
                vaccinazione vac = new vaccinazione
                {
                    DataEffettuazione = recallDate.Value,
                    IdInfermiere = (int)comboNurse.SelectedValue,
                    IdPaziente = (int)patientCombo.SelectedValue,
                    nRichiamo = Convert.ToInt32(recallNumber.Text),
                    DataRichiamo = recallDate.Value.AddDays(Convert.ToDouble(selectedVaxRecNum.Single())),
                };

                db.vaccinazione.InsertOnSubmit(vac);

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

                // Update Dosi in Magazzino

                var querydosi = from dosi in db.dosi
                                where dosi.IdVaccino == (int)this.vaccineBox.SelectedValue
                                select dosi;
                foreach (var dosi in querydosi)
                {
                    dosi.TotDosi = (int)(dosi.TotDosi - 1);
                }
                db.SubmitChanges();

                // Update totVaccinati in Residenza

                var paz = from pe in db.paziente
                               where pe.IdPaziente == vac.IdPaziente
                               select pe;

                var queryresidenza = from residenza in db.residenza
                                       where residenza.IdResidenza == paz.Single().IdResidenza
                                        select residenza;
                foreach (var residenza in queryresidenza)
                {
                    residenza.TotaleVaccinati = (residenza.TotaleVaccinati + 1);
                }
                db.SubmitChanges();

            }
        }
    }
}
