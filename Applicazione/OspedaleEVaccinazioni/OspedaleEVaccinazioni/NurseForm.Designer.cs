
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
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.genderPatient = new System.Windows.Forms.ComboBox();
            this.DeleteResidence = new System.Windows.Forms.Button();
            this.InsertResidence = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.vaccinationViewButton = new System.Windows.Forms.Button();
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
            this.vaccineBox = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.vaccinationDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nurseCombo = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idNurseText = new System.Windows.Forms.TextBox();
            this.NurseViewCombo = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserisci Vaccinazione";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IdPersona";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CodFiscale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sesso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "DataNascita";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cognome";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nome";
            // 
            // idPatient
            // 
            this.idPatient.Location = new System.Drawing.Point(97, 88);
            this.idPatient.Name = "idPatient";
            this.idPatient.Size = new System.Drawing.Size(140, 20);
            this.idPatient.TabIndex = 9;
            // 
            // cellPatient
            // 
            this.cellPatient.Location = new System.Drawing.Point(97, 314);
            this.cellPatient.Name = "cellPatient";
            this.cellPatient.Size = new System.Drawing.Size(140, 20);
            this.cellPatient.TabIndex = 10;
            // 
            // codPatient
            // 
            this.codPatient.Location = new System.Drawing.Point(97, 278);
            this.codPatient.Name = "codPatient";
            this.codPatient.Size = new System.Drawing.Size(140, 20);
            this.codPatient.TabIndex = 11;
            // 
            // surnamePatient
            // 
            this.surnamePatient.Location = new System.Drawing.Point(97, 167);
            this.surnamePatient.Name = "surnamePatient";
            this.surnamePatient.Size = new System.Drawing.Size(140, 20);
            this.surnamePatient.TabIndex = 14;
            // 
            // namePatient
            // 
            this.namePatient.Location = new System.Drawing.Point(97, 128);
            this.namePatient.Name = "namePatient";
            this.namePatient.Size = new System.Drawing.Size(140, 20);
            this.namePatient.TabIndex = 15;
            // 
            // mailPatient
            // 
            this.mailPatient.Location = new System.Drawing.Point(97, 351);
            this.mailPatient.Name = "mailPatient";
            this.mailPatient.Size = new System.Drawing.Size(140, 20);
            this.mailPatient.TabIndex = 16;
            // 
            // InsertPatient
            // 
            this.InsertPatient.BackColor = System.Drawing.Color.Lime;
            this.InsertPatient.Location = new System.Drawing.Point(262, 126);
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
            this.DeletePatient.Location = new System.Drawing.Point(262, 86);
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
            this.label10.Location = new System.Drawing.Point(31, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Residenza";
            // 
            // residencePatient
            // 
            this.residencePatient.FormattingEnabled = true;
            this.residencePatient.Location = new System.Drawing.Point(97, 386);
            this.residencePatient.Name = "residencePatient";
            this.residencePatient.Size = new System.Drawing.Size(140, 21);
            this.residencePatient.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(865, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 24);
            this.label11.TabIndex = 21;
            this.label11.Text = "Inserisci Residenza";
            // 
            // idResidence
            // 
            this.idResidence.Location = new System.Drawing.Point(922, 45);
            this.idResidence.Name = "idResidence";
            this.idResidence.Size = new System.Drawing.Size(140, 20);
            this.idResidence.TabIndex = 31;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(922, 84);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(140, 20);
            this.city.TabIndex = 30;
            // 
            // province
            // 
            this.province.Location = new System.Drawing.Point(922, 123);
            this.province.Name = "province";
            this.province.Size = new System.Drawing.Size(140, 20);
            this.province.TabIndex = 29;
            // 
            // cap
            // 
            this.cap.Location = new System.Drawing.Point(922, 159);
            this.cap.Name = "cap";
            this.cap.Size = new System.Drawing.Size(140, 20);
            this.cap.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(856, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "IdResidenza";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(856, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Città";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(856, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Provincia";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(856, 162);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "CAP";
            // 
            // genderPatient
            // 
            this.genderPatient.FormattingEnabled = true;
            this.genderPatient.Items.AddRange(new object[] {
            "Maschio",
            "Femmina"});
            this.genderPatient.Location = new System.Drawing.Point(97, 242);
            this.genderPatient.Name = "genderPatient";
            this.genderPatient.Size = new System.Drawing.Size(140, 21);
            this.genderPatient.TabIndex = 32;
            // 
            // DeleteResidence
            // 
            this.DeleteResidence.BackColor = System.Drawing.Color.Red;
            this.DeleteResidence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteResidence.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteResidence.Location = new System.Drawing.Point(1087, 43);
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
            this.InsertResidence.Location = new System.Drawing.Point(1087, 83);
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
            this.label17.Location = new System.Drawing.Point(532, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 24);
            this.label17.TabIndex = 35;
            this.label17.Text = "Visualizza";
            // 
            // vaccinationViewButton
            // 
            this.vaccinationViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vaccinationViewButton.Location = new System.Drawing.Point(583, 67);
            this.vaccinationViewButton.Name = "vaccinationViewButton";
            this.vaccinationViewButton.Size = new System.Drawing.Size(226, 47);
            this.vaccinationViewButton.TabIndex = 37;
            this.vaccinationViewButton.Text = "Visualizza";
            this.vaccinationViewButton.UseVisualStyleBackColor = false;
            this.vaccinationViewButton.Click += new System.EventHandler(this.Vaccination_Click);
            // 
            // goBack
            // 
            this.goBack.Location = new System.Drawing.Point(1200, 9);
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
            this.pathologyBox.Location = new System.Drawing.Point(97, 423);
            this.pathologyBox.Name = "pathologyBox";
            this.pathologyBox.Size = new System.Drawing.Size(140, 21);
            this.pathologyBox.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(31, 426);
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
            this.deletePathology.Location = new System.Drawing.Point(1087, 235);
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
            this.insertPathology.Location = new System.Drawing.Point(1087, 275);
            this.insertPathology.Name = "insertPathology";
            this.insertPathology.Size = new System.Drawing.Size(75, 23);
            this.insertPathology.TabIndex = 48;
            this.insertPathology.Text = "Inserisci";
            this.insertPathology.UseVisualStyleBackColor = false;
            // 
            // idPathology
            // 
            this.idPathology.Location = new System.Drawing.Point(922, 237);
            this.idPathology.Name = "idPathology";
            this.idPathology.Size = new System.Drawing.Size(140, 20);
            this.idPathology.TabIndex = 47;
            // 
            // namePathology
            // 
            this.namePathology.Location = new System.Drawing.Point(922, 276);
            this.namePathology.Name = "namePathology";
            this.namePathology.Size = new System.Drawing.Size(140, 20);
            this.namePathology.TabIndex = 46;
            // 
            // descPathology
            // 
            this.descPathology.Location = new System.Drawing.Point(922, 315);
            this.descPathology.Name = "descPathology";
            this.descPathology.Size = new System.Drawing.Size(293, 20);
            this.descPathology.TabIndex = 45;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(856, 240);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 13);
            this.label19.TabIndex = 44;
            this.label19.Text = "IdPatologia";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(834, 279);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 13);
            this.label20.TabIndex = 43;
            this.label20.Text = "Nome Patologia";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(856, 318);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 13);
            this.label21.TabIndex = 42;
            this.label21.Text = "Descrizione";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(865, 201);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(160, 24);
            this.label22.TabIndex = 41;
            this.label22.Text = "Inserisci Patologia";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // vaccineBox
            // 
            this.vaccineBox.FormattingEnabled = true;
            this.vaccineBox.Location = new System.Drawing.Point(97, 494);
            this.vaccineBox.Name = "vaccineBox";
            this.vaccineBox.Size = new System.Drawing.Size(140, 21);
            this.vaccineBox.TabIndex = 53;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(31, 497);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(46, 13);
            this.label24.TabIndex = 52;
            this.label24.Text = "Vaccino";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(5, 462);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(92, 13);
            this.label25.TabIndex = 50;
            this.label25.Text = "DataEffettuazione";
            // 
            // vaccinationDate
            // 
            this.vaccinationDate.Location = new System.Drawing.Point(97, 462);
            this.vaccinationDate.Name = "vaccinationDate";
            this.vaccinationDate.Size = new System.Drawing.Size(140, 20);
            this.vaccinationDate.TabIndex = 56;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 203);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker1.TabIndex = 57;
            // 
            // nurseCombo
            // 
            this.nurseCombo.FormattingEnabled = true;
            this.nurseCombo.Location = new System.Drawing.Point(97, 529);
            this.nurseCombo.Name = "nurseCombo";
            this.nurseCombo.Size = new System.Drawing.Size(140, 21);
            this.nurseCombo.TabIndex = 59;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(31, 532);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(62, 13);
            this.label26.TabIndex = 58;
            this.label26.Text = "IdInfermiere";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(1087, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 70;
            this.button1.Text = "Cancella";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(1087, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 69;
            this.button2.Text = "Inserisci";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(856, 392);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 64;
            this.label16.Text = "IdPaziente";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(865, 353);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(170, 24);
            this.label30.TabIndex = 60;
            this.label30.Text = "Aggiungi Richiamo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(919, 386);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 21);
            this.comboBox1.TabIndex = 71;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(919, 419);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(143, 21);
            this.comboBox2.TabIndex = 73;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(856, 424);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(62, 13);
            this.label27.TabIndex = 72;
            this.label27.Text = "IdInfermiere";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(919, 454);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker2.TabIndex = 79;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(919, 526);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 78;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(853, 533);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(51, 13);
            this.label28.TabIndex = 77;
            this.label28.Text = "Richiamo";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(919, 488);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(143, 21);
            this.comboBox3.TabIndex = 76;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(853, 496);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(46, 13);
            this.label29.TabIndex = 75;
            this.label29.Text = "Vaccino";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(826, 460);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(92, 13);
            this.label31.TabIndex = 74;
            this.label31.Text = "DataEffettuazione";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(362, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 427);
            this.dataGridView1.TabIndex = 80;
            // 
            // idNurseText
            // 
            this.idNurseText.Location = new System.Drawing.Point(383, 94);
            this.idNurseText.Name = "idNurseText";
            this.idNurseText.Size = new System.Drawing.Size(194, 20);
            this.idNurseText.TabIndex = 81;
            this.idNurseText.Text = "Inserisci id";
            this.idNurseText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.idNurseText_MouseClick);
            // 
            // NurseViewCombo
            // 
            this.NurseViewCombo.FormattingEnabled = true;
            this.NurseViewCombo.Items.AddRange(new object[] {
            "Vaccinazioni ricevute dal paziente (Specificato con Id)",
            "Vaccinazioni effettuate dall\'Infermiere (Specificato con Id)"});
            this.NurseViewCombo.Location = new System.Drawing.Point(362, 67);
            this.NurseViewCombo.Name = "NurseViewCombo";
            this.NurseViewCombo.Size = new System.Drawing.Size(215, 21);
            this.NurseViewCombo.TabIndex = 82;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(359, 97);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(18, 13);
            this.label23.TabIndex = 83;
            this.label23.Text = "ID";
            // 
            // NurseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 566);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.NurseViewCombo);
            this.Controls.Add(this.idNurseText);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.nurseCombo);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.vaccinationDate);
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
            this.Controls.Add(this.vaccinationViewButton);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.DeleteResidence);
            this.Controls.Add(this.InsertResidence);
            this.Controls.Add(this.genderPatient);
            this.Controls.Add(this.idResidence);
            this.Controls.Add(this.city);
            this.Controls.Add(this.province);
            this.Controls.Add(this.cap);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.residencePatient);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DeletePatient);
            this.Controls.Add(this.InsertPatient);
            this.Controls.Add(this.mailPatient);
            this.Controls.Add(this.namePatient);
            this.Controls.Add(this.surnamePatient);
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox genderPatient;
        private System.Windows.Forms.Button DeleteResidence;
        private System.Windows.Forms.Button InsertResidence;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button vaccinationViewButton;
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
        private System.Windows.Forms.ComboBox vaccineBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DateTimePicker vaccinationDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox nurseCombo;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox idNurseText;
        private System.Windows.Forms.ComboBox NurseViewCombo;
        private System.Windows.Forms.Label label23;
    }
}