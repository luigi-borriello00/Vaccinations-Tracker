
namespace OspedaleEVaccinazioni
{
    partial class DirectorWarehouse
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.stocksDelete = new System.Windows.Forms.Button();
            this.stocksInsert = new System.Windows.Forms.Button();
            this.stocksNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.stocksType = new System.Windows.Forms.ComboBox();
            this.vaccineDelete = new System.Windows.Forms.Button();
            this.vaccineInsert = new System.Windows.Forms.Button();
            this.vaccineName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.vaccineHouse = new System.Windows.Forms.TextBox();
            this.vaccineTime = new System.Windows.Forms.TextBox();
            this.vaccinePrice = new System.Windows.Forms.TextBox();
            this.vaccineInfo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.supplierDelete = new System.Windows.Forms.Button();
            this.supplierInsert = new System.Windows.Forms.Button();
            this.supplierName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.supplierCell = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.goBack = new System.Windows.Forms.Button();
            this.supplierVaccine = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gridWare = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.wareViewButt = new System.Windows.Forms.Button();
            this.warechoice = new System.Windows.Forms.ComboBox();
            this.covid19TrackerDataSet6 = new OspedaleEVaccinazioni.Covid19TrackerDataSet6();
            this.dosiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dosiTableAdapter = new OspedaleEVaccinazioni.Covid19TrackerDataSet6TableAdapters.dosiTableAdapter();
            this.covid19TrackerDataSet7 = new OspedaleEVaccinazioni.Covid19TrackerDataSet7();
            this.vaccinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vaccinoTableAdapter = new OspedaleEVaccinazioni.Covid19TrackerDataSet7TableAdapters.vaccinoTableAdapter();
            this.covid19TrackerDataSet8 = new OspedaleEVaccinazioni.Covid19TrackerDataSet8();
            this.fornitoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornitoreTableAdapter = new OspedaleEVaccinazioni.Covid19TrackerDataSet8TableAdapters.fornitoreTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridWare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covid19TrackerDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covid19TrackerDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccinoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covid19TrackerDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornitoreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aggiungi Scorte";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // stocksDelete
            // 
            this.stocksDelete.BackColor = System.Drawing.Color.Red;
            this.stocksDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.stocksDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stocksDelete.Location = new System.Drawing.Point(680, 361);
            this.stocksDelete.Name = "stocksDelete";
            this.stocksDelete.Size = new System.Drawing.Size(75, 23);
            this.stocksDelete.TabIndex = 26;
            this.stocksDelete.Text = "Cancella";
            this.stocksDelete.UseVisualStyleBackColor = false;
            this.stocksDelete.Click += new System.EventHandler(this.stocksDelete_Click);
            // 
            // stocksInsert
            // 
            this.stocksInsert.BackColor = System.Drawing.Color.Lime;
            this.stocksInsert.Location = new System.Drawing.Point(680, 401);
            this.stocksInsert.Name = "stocksInsert";
            this.stocksInsert.Size = new System.Drawing.Size(75, 23);
            this.stocksInsert.TabIndex = 25;
            this.stocksInsert.Text = "Inserisci";
            this.stocksInsert.UseVisualStyleBackColor = false;
            this.stocksInsert.Click += new System.EventHandler(this.stocksInsert_Click);
            // 
            // stocksNumber
            // 
            this.stocksNumber.Location = new System.Drawing.Point(533, 363);
            this.stocksNumber.Name = "stocksNumber";
            this.stocksNumber.Size = new System.Drawing.Size(140, 20);
            this.stocksNumber.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(467, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Numero";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tipologia";
            // 
            // stocksType
            // 
            this.stocksType.DataSource = this.vaccinoBindingSource;
            this.stocksType.DisplayMember = "Nome";
            this.stocksType.FormattingEnabled = true;
            this.stocksType.Location = new System.Drawing.Point(533, 402);
            this.stocksType.Name = "stocksType";
            this.stocksType.Size = new System.Drawing.Size(140, 21);
            this.stocksType.TabIndex = 36;
            this.stocksType.ValueMember = "IdVaccino";
            // 
            // vaccineDelete
            // 
            this.vaccineDelete.BackColor = System.Drawing.Color.Red;
            this.vaccineDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.vaccineDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vaccineDelete.Location = new System.Drawing.Point(250, 61);
            this.vaccineDelete.Name = "vaccineDelete";
            this.vaccineDelete.Size = new System.Drawing.Size(75, 23);
            this.vaccineDelete.TabIndex = 44;
            this.vaccineDelete.Text = "Cancella";
            this.vaccineDelete.UseVisualStyleBackColor = false;
            this.vaccineDelete.Click += new System.EventHandler(this.vaccineDelete_Click);
            // 
            // vaccineInsert
            // 
            this.vaccineInsert.BackColor = System.Drawing.Color.Lime;
            this.vaccineInsert.Location = new System.Drawing.Point(249, 97);
            this.vaccineInsert.Name = "vaccineInsert";
            this.vaccineInsert.Size = new System.Drawing.Size(75, 23);
            this.vaccineInsert.TabIndex = 43;
            this.vaccineInsert.Text = "Inserisci";
            this.vaccineInsert.UseVisualStyleBackColor = false;
            this.vaccineInsert.Click += new System.EventHandler(this.vaccineInsert_Click);
            // 
            // vaccineName
            // 
            this.vaccineName.Location = new System.Drawing.Point(92, 63);
            this.vaccineName.Name = "vaccineName";
            this.vaccineName.Size = new System.Drawing.Size(140, 20);
            this.vaccineName.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Nome";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 27);
            this.label7.TabIndex = 39;
            this.label7.Text = "Casa Farmaceutica";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 24);
            this.label11.TabIndex = 37;
            this.label11.Text = "Aggiungi Vaccino";
            // 
            // vaccineHouse
            // 
            this.vaccineHouse.Location = new System.Drawing.Point(92, 102);
            this.vaccineHouse.Name = "vaccineHouse";
            this.vaccineHouse.Size = new System.Drawing.Size(140, 20);
            this.vaccineHouse.TabIndex = 45;
            // 
            // vaccineTime
            // 
            this.vaccineTime.Location = new System.Drawing.Point(92, 135);
            this.vaccineTime.Name = "vaccineTime";
            this.vaccineTime.Size = new System.Drawing.Size(140, 20);
            this.vaccineTime.TabIndex = 46;
            // 
            // vaccinePrice
            // 
            this.vaccinePrice.Location = new System.Drawing.Point(92, 170);
            this.vaccinePrice.Name = "vaccinePrice";
            this.vaccinePrice.Size = new System.Drawing.Size(140, 20);
            this.vaccinePrice.TabIndex = 47;
            // 
            // vaccineInfo
            // 
            this.vaccineInfo.Location = new System.Drawing.Point(92, 204);
            this.vaccineInfo.Name = "vaccineInfo";
            this.vaccineInfo.Size = new System.Drawing.Size(140, 20);
            this.vaccineInfo.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(8, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 38);
            this.label12.TabIndex = 51;
            this.label12.Text = "Tempo Richiamo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Prezzo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 207);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "Info";
            // 
            // supplierDelete
            // 
            this.supplierDelete.BackColor = System.Drawing.Color.Red;
            this.supplierDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.supplierDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.supplierDelete.Location = new System.Drawing.Point(252, 361);
            this.supplierDelete.Name = "supplierDelete";
            this.supplierDelete.Size = new System.Drawing.Size(75, 23);
            this.supplierDelete.TabIndex = 60;
            this.supplierDelete.Text = "Cancella";
            this.supplierDelete.UseVisualStyleBackColor = false;
            this.supplierDelete.Click += new System.EventHandler(this.supplierDelete_Click);
            // 
            // supplierInsert
            // 
            this.supplierInsert.BackColor = System.Drawing.Color.Lime;
            this.supplierInsert.Location = new System.Drawing.Point(252, 401);
            this.supplierInsert.Name = "supplierInsert";
            this.supplierInsert.Size = new System.Drawing.Size(75, 23);
            this.supplierInsert.TabIndex = 59;
            this.supplierInsert.Text = "Inserisci";
            this.supplierInsert.UseVisualStyleBackColor = false;
            this.supplierInsert.Click += new System.EventHandler(this.supplierInsert_Click);
            // 
            // supplierName
            // 
            this.supplierName.Location = new System.Drawing.Point(92, 363);
            this.supplierName.Name = "supplierName";
            this.supplierName.Size = new System.Drawing.Size(140, 20);
            this.supplierName.TabIndex = 58;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 366);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 56;
            this.label16.Text = "Nome";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(22, 317);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(167, 24);
            this.label18.TabIndex = 54;
            this.label18.Text = "Aggiungi Fornitore";
            // 
            // supplierCell
            // 
            this.supplierCell.Location = new System.Drawing.Point(92, 399);
            this.supplierCell.Name = "supplierCell";
            this.supplierCell.Size = new System.Drawing.Size(140, 20);
            this.supplierCell.TabIndex = 62;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(26, 402);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 61;
            this.label19.Text = "Telefono";
            // 
            // goBack
            // 
            this.goBack.Location = new System.Drawing.Point(788, 18);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(53, 40);
            this.goBack.TabIndex = 63;
            this.goBack.Text = "Torna Indietro";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // supplierVaccine
            // 
            this.supplierVaccine.DataSource = this.vaccinoBindingSource;
            this.supplierVaccine.DisplayMember = "Nome";
            this.supplierVaccine.FormattingEnabled = true;
            this.supplierVaccine.Location = new System.Drawing.Point(92, 435);
            this.supplierVaccine.Name = "supplierVaccine";
            this.supplierVaccine.Size = new System.Drawing.Size(140, 21);
            this.supplierVaccine.TabIndex = 67;
            this.supplierVaccine.ValueMember = "IdVaccino";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 438);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 66;
            this.label15.Text = "Vaccino";
            // 
            // gridWare
            // 
            this.gridWare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridWare.Location = new System.Drawing.Point(353, 78);
            this.gridWare.Name = "gridWare";
            this.gridWare.Size = new System.Drawing.Size(487, 227);
            this.gridWare.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(529, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 69;
            this.label3.Text = "Visualizza Info";
            // 
            // wareViewButt
            // 
            this.wareViewButt.Location = new System.Drawing.Point(587, 45);
            this.wareViewButt.Name = "wareViewButt";
            this.wareViewButt.Size = new System.Drawing.Size(139, 21);
            this.wareViewButt.TabIndex = 71;
            this.wareViewButt.Text = "Visualizza";
            this.wareViewButt.UseVisualStyleBackColor = true;
            this.wareViewButt.Click += new System.EventHandler(this.wareViewButt_Click);
            // 
            // warechoice
            // 
            this.warechoice.FormattingEnabled = true;
            this.warechoice.Items.AddRange(new object[] {
            "Scorte",
            "Fornitori"});
            this.warechoice.Location = new System.Drawing.Point(442, 46);
            this.warechoice.Name = "warechoice";
            this.warechoice.Size = new System.Drawing.Size(139, 21);
            this.warechoice.TabIndex = 72;
            // 
            // covid19TrackerDataSet6
            // 
            this.covid19TrackerDataSet6.DataSetName = "Covid19TrackerDataSet6";
            this.covid19TrackerDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dosiBindingSource
            // 
            this.dosiBindingSource.DataMember = "dosi";
            this.dosiBindingSource.DataSource = this.covid19TrackerDataSet6;
            // 
            // dosiTableAdapter
            // 
            this.dosiTableAdapter.ClearBeforeFill = true;
            // 
            // covid19TrackerDataSet7
            // 
            this.covid19TrackerDataSet7.DataSetName = "Covid19TrackerDataSet7";
            this.covid19TrackerDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vaccinoBindingSource
            // 
            this.vaccinoBindingSource.DataMember = "vaccino";
            this.vaccinoBindingSource.DataSource = this.covid19TrackerDataSet7;
            // 
            // vaccinoTableAdapter
            // 
            this.vaccinoTableAdapter.ClearBeforeFill = true;
            // 
            // covid19TrackerDataSet8
            // 
            this.covid19TrackerDataSet8.DataSetName = "Covid19TrackerDataSet8";
            this.covid19TrackerDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornitoreBindingSource
            // 
            this.fornitoreBindingSource.DataMember = "fornitore";
            this.fornitoreBindingSource.DataSource = this.covid19TrackerDataSet8;
            // 
            // fornitoreTableAdapter
            // 
            this.fornitoreTableAdapter.ClearBeforeFill = true;
            // 
            // DirectorWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 469);
            this.Controls.Add(this.warechoice);
            this.Controls.Add(this.wareViewButt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridWare);
            this.Controls.Add(this.supplierVaccine);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.supplierCell);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.supplierDelete);
            this.Controls.Add(this.supplierInsert);
            this.Controls.Add(this.supplierName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.vaccineInfo);
            this.Controls.Add(this.vaccinePrice);
            this.Controls.Add(this.vaccineTime);
            this.Controls.Add(this.vaccineHouse);
            this.Controls.Add(this.vaccineDelete);
            this.Controls.Add(this.vaccineInsert);
            this.Controls.Add(this.vaccineName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.stocksType);
            this.Controls.Add(this.stocksDelete);
            this.Controls.Add(this.stocksInsert);
            this.Controls.Add(this.stocksNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DirectorWarehouse";
            this.Text = "DirectorWarehouse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DirectorWarehouse_FormClosing);
            this.Load += new System.EventHandler(this.DirectorWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridWare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covid19TrackerDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covid19TrackerDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccinoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covid19TrackerDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornitoreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stocksDelete;
        private System.Windows.Forms.Button stocksInsert;
        private System.Windows.Forms.TextBox stocksNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox stocksType;
        private System.Windows.Forms.Button vaccineDelete;
        private System.Windows.Forms.Button vaccineInsert;
        private System.Windows.Forms.TextBox vaccineName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox vaccineHouse;
        private System.Windows.Forms.TextBox vaccineTime;
        private System.Windows.Forms.TextBox vaccinePrice;
        private System.Windows.Forms.TextBox vaccineInfo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button supplierDelete;
        private System.Windows.Forms.Button supplierInsert;
        private System.Windows.Forms.TextBox supplierName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox supplierCell;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.ComboBox supplierVaccine;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView gridWare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button wareViewButt;
        private System.Windows.Forms.ComboBox warechoice;
        private Covid19TrackerDataSet6 covid19TrackerDataSet6;
        private System.Windows.Forms.BindingSource dosiBindingSource;
        private Covid19TrackerDataSet6TableAdapters.dosiTableAdapter dosiTableAdapter;
        private Covid19TrackerDataSet7 covid19TrackerDataSet7;
        private System.Windows.Forms.BindingSource vaccinoBindingSource;
        private Covid19TrackerDataSet7TableAdapters.vaccinoTableAdapter vaccinoTableAdapter;
        private Covid19TrackerDataSet8 covid19TrackerDataSet8;
        private System.Windows.Forms.BindingSource fornitoreBindingSource;
        private Covid19TrackerDataSet8TableAdapters.fornitoreTableAdapter fornitoreTableAdapter;
    }
}