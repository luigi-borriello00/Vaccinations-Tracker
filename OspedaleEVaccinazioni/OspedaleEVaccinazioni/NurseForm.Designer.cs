
namespace OspedaleEVaccinazioni
{
    partial class NurseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.idPatient = new System.Windows.Forms.TextBox();
            this.cellPatient = new System.Windows.Forms.TextBox();
            this.codPatient = new System.Windows.Forms.TextBox();
            this.bdPatient = new System.Windows.Forms.TextBox();
            this.surnamePatient = new System.Windows.Forms.TextBox();
            this.namePatient = new System.Windows.Forms.TextBox();
            this.mailPatient = new System.Windows.Forms.TextBox();
            this.InsertPatient = new System.Windows.Forms.Button();
            this.DeletePatient = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.residencePatient = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.idResidence = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.province = new System.Windows.Forms.TextBox();
            this.cap = new System.Windows.Forms.TextBox();
            this.people = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.genderPatient = new System.Windows.Forms.ComboBox();
            this.DeleteResidence = new System.Windows.Forms.Button();
            this.InsertResidence = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Vaccination = new System.Windows.Forms.Button();
            this.goBack = new System.Windows.Forms.Button();
            this.pathologyBox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.deletePathology = new System.Windows.Forms.Button();
            this.insertPathology = new System.Windows.Forms.Button();
            this.idPathology = new System.Windows.Forms.TextBox();
            this.namePathology = new System.Windows.Forms.TextBox();
            this.descPathology = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.vaccineBox = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.recallNumber = new System.Windows.Forms.TextBox();
            this.vaccinationDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserisci Vaccinazione";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IdPersona";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CodFiscale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sesso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "DataNascita";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cognome";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nome";
            // 
            // idPatient
            // 
            this.idPatient.Location = new System.Drawing.Point(93, 52);
            this.idPatient.Name = "idPatient";
            this.idPatient.Size = new System.Drawing.Size(140, 20);
            this.idPatient.TabIndex = 9;
            // 
            // cellPatient
            // 
            this.cellPatient.Location = new System.Drawing.Point(93, 278);
            this.cellPatient.Name = "cellPatient";
            this.cellPatient.Size = new System.Drawing.Size(140, 20);
            this.cellPatient.TabIndex = 10;
            // 
            // codPatient
            // 
            this.codPatient.Location = new System.Drawing.Point(93, 242);
            this.codPatient.Name = "codPatient";
            this.codPatient.Size = new System.Drawing.Size(140, 20);
            this.codPatient.TabIndex = 11;
            // 
            // bdPatient
            // 
            this.bdPatient.Location = new System.Drawing.Point(93, 170);
            this.bdPatient.Name = "bdPatient";
            this.bdPatient.Size = new System.Drawing.Size(140, 20);
            this.bdPatient.TabIndex = 13;
            // 
            // surnamePatient
            // 
            this.surnamePatient.Location = new System.Drawing.Point(93, 131);
            this.surnamePatient.Name = "surnamePatient";
            this.surnamePatient.Size = new System.Drawing.Size(140, 20);
            this.surnamePatient.TabIndex = 14;
            // 
            // namePatient
            // 
            this.namePatient.Location = new System.Drawing.Point(93, 92);
            this.namePatient.Name = "namePatient";
            this.namePatient.Size = new System.Drawing.Size(140, 20);
            this.namePatient.TabIndex = 15;
            // 
            // mailPatient
            // 
            this.mailPatient.Location = new System.Drawing.Point(93, 315);
            this.mailPatient.Name = "mailPatient";
            this.mailPatient.Size = new System.Drawing.Size(140, 20);
            this.mailPatient.TabIndex = 16;
            // 
            // InsertPatient
            // 
            this.InsertPatient.BackColor = System.Drawing.Color.Lime;
            this.InsertPatient.Location = new System.Drawing.Point(258, 90);
            this.InsertPatient.Name = "InsertPatient";
            this.InsertPatient.Size = new System.Drawing.Size(75, 23);
            this.InsertPatient.TabIndex = 17;
            this.InsertPatient.Text = "Inserisci";
            this.InsertPatient.UseVisualStyleBackColor = false;
            this.InsertPatient.Click += new System.EventHandler(this.InsertPatient_Click);
            // 
            // DeletePatient
            // 
            this.DeletePatient.BackColor = System.Drawing.Color.Red;
            this.DeletePatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeletePatient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeletePatient.Location = new System.Drawing.Point(258, 50);
            this.DeletePatient.Name = "DeletePatient";
            this.DeletePatient.Size = new System.Drawing.Size(75, 23);
            this.DeletePatient.TabIndex = 18;
            this.DeletePatient.Text = "Cancella";
            this.DeletePatient.UseVisualStyleBackColor = false;
            this.DeletePatient.Click += new System.EventHandler(this.DeletePatient_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Residenza";
            // 
            // residencePatient
            // 
            this.residencePatient.FormattingEnabled = true;
            this.residencePatient.Location = new System.Drawing.Point(93, 350);
            this.residencePatient.Name = "residencePatient";
            this.residencePatient.Size = new System.Drawing.Size(140, 21);
            this.residencePatient.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(549, 518);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 24);
            this.label11.TabIndex = 21;
            this.label11.Text = "Inserisci Residenza";
            // 
            // idResidence
            // 
            this.idResidence.Location = new System.Drawing.Point(606, 554);
            this.idResidence.Name = "idResidence";
            this.idResidence.Size = new System.Drawing.Size(140, 20);
            this.idResidence.TabIndex = 31;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(606, 593);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(140, 20);
            this.city.TabIndex = 30;
            // 
            // province
            // 
            this.province.Location = new System.Drawing.Point(606, 632);
            this.province.Name = "province";
            this.province.Size = new System.Drawing.Size(140, 20);
            this.province.TabIndex = 29;
            // 
            // cap
            // 
            this.cap.Location = new System.Drawing.Point(606, 668);
            this.cap.Name = "cap";
            this.cap.Size = new System.Drawing.Size(140, 20);
            this.cap.TabIndex = 28;
            // 
            // people
            // 
            this.people.Location = new System.Drawing.Point(606, 704);
            this.people.Name = "people";
            this.people.Size = new System.Drawing.Size(140, 20);
            this.people.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(540, 557);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "IdResidenza";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(540, 596);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Città";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(540, 635);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Provincia";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(540, 671);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "CAP";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(540, 707);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "n° Abitanti";
            // 
            // genderPatient
            // 
            this.genderPatient.FormattingEnabled = true;
            this.genderPatient.Items.AddRange(new object[] {
            "Maschio",
            "Femmina"});
            this.genderPatient.Location = new System.Drawing.Point(93, 206);
            this.genderPatient.Name = "genderPatient";
            this.genderPatient.Size = new System.Drawing.Size(140, 21);
            this.genderPatient.TabIndex = 32;
            // 
            // DeleteResidence
            // 
            this.DeleteResidence.BackColor = System.Drawing.Color.Red;
            this.DeleteResidence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteResidence.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteResidence.Location = new System.Drawing.Point(771, 552);
            this.DeleteResidence.Name = "DeleteResidence";
            this.DeleteResidence.Size = new System.Drawing.Size(75, 23);
            this.DeleteResidence.TabIndex = 34;
            this.DeleteResidence.Text = "Cancella";
            this.DeleteResidence.UseVisualStyleBackColor = false;
            this.DeleteResidence.Click += new System.EventHandler(this.DeleteResidence_Click);
            // 
            // InsertResidence
            // 
            this.InsertResidence.BackColor = System.Drawing.Color.Lime;
            this.InsertResidence.Location = new System.Drawing.Point(771, 592);
            this.InsertResidence.Name = "InsertResidence";
            this.InsertResidence.Size = new System.Drawing.Size(75, 23);
            this.InsertResidence.TabIndex = 33;
            this.InsertResidence.Text = "Inserisci";
            this.InsertResidence.UseVisualStyleBackColor = false;
            this.InsertResidence.Click += new System.EventHandler(this.InsertResidence_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(510, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(350, 24);
            this.label17.TabIndex = 35;
            this.label17.Text = "Visualizza le Vaccinazioni da te effettuate";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(438, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(496, 402);
            this.dataGridView1.TabIndex = 36;
            // 
            // Vaccination
            // 
            this.Vaccination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Vaccination.Location = new System.Drawing.Point(622, 40);
            this.Vaccination.Name = "Vaccination";
            this.Vaccination.Size = new System.Drawing.Size(115, 42);
            this.Vaccination.TabIndex = 37;
            this.Vaccination.Text = "Visualizza";
            this.Vaccination.UseVisualStyleBackColor = false;
            // 
            // goBack
            // 
            this.goBack.Location = new System.Drawing.Point(917, 683);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(61, 40);
            this.goBack.TabIndex = 38;
            this.goBack.Text = "Torna Indietro";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // pathologyBox
            // 
            this.pathologyBox.FormattingEnabled = true;
            this.pathologyBox.Location = new System.Drawing.Point(93, 387);
            this.pathologyBox.Name = "pathologyBox";
            this.pathologyBox.Size = new System.Drawing.Size(140, 21);
            this.pathologyBox.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(27, 390);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 39;
            this.label18.Text = "Patologia";
            // 
            // deletePathology
            // 
            this.deletePathology.BackColor = System.Drawing.Color.Red;
            this.deletePathology.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deletePathology.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deletePathology.Location = new System.Drawing.Point(258, 591);
            this.deletePathology.Name = "deletePathology";
            this.deletePathology.Size = new System.Drawing.Size(75, 23);
            this.deletePathology.TabIndex = 49;
            this.deletePathology.Text = "Cancella";
            this.deletePathology.UseVisualStyleBackColor = false;
            this.deletePathology.Click += new System.EventHandler(this.deletePathology_Click);
            // 
            // insertPathology
            // 
            this.insertPathology.BackColor = System.Drawing.Color.Lime;
            this.insertPathology.Location = new System.Drawing.Point(258, 631);
            this.insertPathology.Name = "insertPathology";
            this.insertPathology.Size = new System.Drawing.Size(75, 23);
            this.insertPathology.TabIndex = 48;
            this.insertPathology.Text = "Inserisci";
            this.insertPathology.UseVisualStyleBackColor = false;
            // 
            // idPathology
            // 
            this.idPathology.Location = new System.Drawing.Point(93, 593);
            this.idPathology.Name = "idPathology";
            this.idPathology.Size = new System.Drawing.Size(140, 20);
            this.idPathology.TabIndex = 47;
            // 
            // namePathology
            // 
            this.namePathology.Location = new System.Drawing.Point(93, 632);
            this.namePathology.Name = "namePathology";
            this.namePathology.Size = new System.Drawing.Size(140, 20);
            this.namePathology.TabIndex = 46;
            // 
            // descPathology
            // 
            this.descPathology.Location = new System.Drawing.Point(93, 671);
            this.descPathology.Name = "descPathology";
            this.descPathology.Size = new System.Drawing.Size(293, 20);
            this.descPathology.TabIndex = 45;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(27, 596);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 13);
            this.label19.TabIndex = 44;
            this.label19.Text = "IdPatologia";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 635);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 13);
            this.label20.TabIndex = 43;
            this.label20.Text = "Nome Patologia";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(27, 674);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 13);
            this.label21.TabIndex = 42;
            this.label21.Text = "Descrizione";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(36, 557);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(160, 24);
            this.label22.TabIndex = 41;
            this.label22.Text = "Inserisci Patologia";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(27, 498);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(51, 13);
            this.label23.TabIndex = 54;
            this.label23.Text = "Richiamo";
            // 
            // vaccineBox
            // 
            this.vaccineBox.FormattingEnabled = true;
            this.vaccineBox.Location = new System.Drawing.Point(93, 458);
            this.vaccineBox.Name = "vaccineBox";
            this.vaccineBox.Size = new System.Drawing.Size(140, 21);
            this.vaccineBox.TabIndex = 53;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(27, 461);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(46, 13);
            this.label24.TabIndex = 52;
            this.label24.Text = "Vaccino";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(1, 426);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(92, 13);
            this.label25.TabIndex = 50;
            this.label25.Text = "DataEffettuazione";
            // 
            // recallNumber
            // 
            this.recallNumber.Location = new System.Drawing.Point(93, 495);
            this.recallNumber.Name = "recallNumber";
            this.recallNumber.Size = new System.Drawing.Size(140, 20);
            this.recallNumber.TabIndex = 55;
            this.recallNumber.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // vaccinationDate
            // 
            this.vaccinationDate.Location = new System.Drawing.Point(93, 426);
            this.vaccinationDate.Name = "vaccinationDate";
            this.vaccinationDate.Size = new System.Drawing.Size(168, 20);
            this.vaccinationDate.TabIndex = 56;
            // 
            // NurseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 734);
            this.Controls.Add(this.vaccinationDate);
            this.Controls.Add(this.recallNumber);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.vaccineBox);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.deletePathology);
            this.Controls.Add(this.insertPathology);
            this.Controls.Add(this.idPathology);
            this.Controls.Add(this.namePathology);
            this.Controls.Add(this.descPathology);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.pathologyBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.Vaccination);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.DeleteResidence);
            this.Controls.Add(this.InsertResidence);
            this.Controls.Add(this.genderPatient);
            this.Controls.Add(this.idResidence);
            this.Controls.Add(this.city);
            this.Controls.Add(this.province);
            this.Controls.Add(this.cap);
            this.Controls.Add(this.people);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.residencePatient);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DeletePatient);
            this.Controls.Add(this.InsertPatient);
            this.Controls.Add(this.mailPatient);
            this.Controls.Add(this.namePatient);
            this.Controls.Add(this.surnamePatient);
            this.Controls.Add(this.bdPatient);
            this.Controls.Add(this.codPatient);
            this.Controls.Add(this.cellPatient);
            this.Controls.Add(this.idPatient);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NurseForm";
            this.Text = "NurseForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NurseForm_FormClosing);
            this.Load += new System.EventHandler(this.NurseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox idPatient;
        private System.Windows.Forms.TextBox cellPatient;
        private System.Windows.Forms.TextBox codPatient;
        private System.Windows.Forms.TextBox bdPatient;
        private System.Windows.Forms.TextBox surnamePatient;
        private System.Windows.Forms.TextBox namePatient;
        private System.Windows.Forms.TextBox mailPatient;
        private System.Windows.Forms.Button InsertPatient;
        private System.Windows.Forms.Button DeletePatient;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox residencePatient;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox idResidence;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox province;
        private System.Windows.Forms.TextBox cap;
        private System.Windows.Forms.TextBox people;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox genderPatient;
        private System.Windows.Forms.Button DeleteResidence;
        private System.Windows.Forms.Button InsertResidence;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Vaccination;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.ComboBox pathologyBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button deletePathology;
        private System.Windows.Forms.Button insertPathology;
        private System.Windows.Forms.TextBox idPathology;
        private System.Windows.Forms.TextBox namePathology;
        private System.Windows.Forms.TextBox descPathology;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox vaccineBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox recallNumber;
        private System.Windows.Forms.DateTimePicker vaccinationDate;
    }
}