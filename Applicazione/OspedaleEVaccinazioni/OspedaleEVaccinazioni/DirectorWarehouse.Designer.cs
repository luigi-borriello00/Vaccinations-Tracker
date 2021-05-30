
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
            this.label1 = new System.Windows.Forms.Label();
            this.stocksDelete = new System.Windows.Forms.Button();
            this.stocksInsert = new System.Windows.Forms.Button();
            this.stocksNumber = new System.Windows.Forms.TextBox();
            this.stocksId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wareHouseDelete = new System.Windows.Forms.Button();
            this.wareHouseInsert = new System.Windows.Forms.Button();
            this.wareHouseName = new System.Windows.Forms.TextBox();
            this.warehouseId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.residencePatient = new System.Windows.Forms.ComboBox();
            this.vaccineDelete = new System.Windows.Forms.Button();
            this.vaccineInsert = new System.Windows.Forms.Button();
            this.vaccineName = new System.Windows.Forms.TextBox();
            this.vaccineId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.vaccineHouse = new System.Windows.Forms.TextBox();
            this.vaccineTime = new System.Windows.Forms.TextBox();
            this.vaccinePrice = new System.Windows.Forms.TextBox();
            this.vaccineInfo = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.supplierDelete = new System.Windows.Forms.Button();
            this.supplierInsert = new System.Windows.Forms.Button();
            this.supplierName = new System.Windows.Forms.TextBox();
            this.supplierId = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.supplierCell = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.goBack = new System.Windows.Forms.Button();
            this.wareHouseCombo = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 19);
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
            this.stocksDelete.Location = new System.Drawing.Point(240, 62);
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
            this.stocksInsert.Location = new System.Drawing.Point(240, 102);
            this.stocksInsert.Name = "stocksInsert";
            this.stocksInsert.Size = new System.Drawing.Size(75, 23);
            this.stocksInsert.TabIndex = 25;
            this.stocksInsert.Text = "Inserisci";
            this.stocksInsert.UseVisualStyleBackColor = false;
            // 
            // stocksNumber
            // 
            this.stocksNumber.Location = new System.Drawing.Point(75, 104);
            this.stocksNumber.Name = "stocksNumber";
            this.stocksNumber.Size = new System.Drawing.Size(140, 20);
            this.stocksNumber.TabIndex = 24;
            // 
            // stocksId
            // 
            this.stocksId.Location = new System.Drawing.Point(75, 64);
            this.stocksId.Name = "stocksId";
            this.stocksId.Size = new System.Drawing.Size(140, 20);
            this.stocksId.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Numero";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tipologia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "IdScorte";
            // 
            // wareHouseDelete
            // 
            this.wareHouseDelete.BackColor = System.Drawing.Color.Red;
            this.wareHouseDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.wareHouseDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wareHouseDelete.Location = new System.Drawing.Point(760, 62);
            this.wareHouseDelete.Name = "wareHouseDelete";
            this.wareHouseDelete.Size = new System.Drawing.Size(75, 23);
            this.wareHouseDelete.TabIndex = 35;
            this.wareHouseDelete.Text = "Cancella";
            this.wareHouseDelete.UseVisualStyleBackColor = false;
            this.wareHouseDelete.Click += new System.EventHandler(this.wareHouseDelete_Click);
            // 
            // wareHouseInsert
            // 
            this.wareHouseInsert.BackColor = System.Drawing.Color.Lime;
            this.wareHouseInsert.Location = new System.Drawing.Point(760, 102);
            this.wareHouseInsert.Name = "wareHouseInsert";
            this.wareHouseInsert.Size = new System.Drawing.Size(75, 23);
            this.wareHouseInsert.TabIndex = 34;
            this.wareHouseInsert.Text = "Inserisci";
            this.wareHouseInsert.UseVisualStyleBackColor = false;
            // 
            // wareHouseName
            // 
            this.wareHouseName.Location = new System.Drawing.Point(595, 104);
            this.wareHouseName.Name = "wareHouseName";
            this.wareHouseName.Size = new System.Drawing.Size(140, 20);
            this.wareHouseName.TabIndex = 33;
            // 
            // warehouseId
            // 
            this.warehouseId.Location = new System.Drawing.Point(595, 64);
            this.warehouseId.Name = "warehouseId";
            this.warehouseId.Size = new System.Drawing.Size(140, 20);
            this.warehouseId.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "IdMagazzino";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(546, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Aggiungi Magazzino";
            // 
            // residencePatient
            // 
            this.residencePatient.FormattingEnabled = true;
            this.residencePatient.Location = new System.Drawing.Point(75, 143);
            this.residencePatient.Name = "residencePatient";
            this.residencePatient.Size = new System.Drawing.Size(140, 21);
            this.residencePatient.TabIndex = 36;
            // 
            // vaccineDelete
            // 
            this.vaccineDelete.BackColor = System.Drawing.Color.Red;
            this.vaccineDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.vaccineDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vaccineDelete.Location = new System.Drawing.Point(240, 268);
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
            this.vaccineInsert.Location = new System.Drawing.Point(239, 304);
            this.vaccineInsert.Name = "vaccineInsert";
            this.vaccineInsert.Size = new System.Drawing.Size(75, 23);
            this.vaccineInsert.TabIndex = 43;
            this.vaccineInsert.Text = "Inserisci";
            this.vaccineInsert.UseVisualStyleBackColor = false;
            // 
            // vaccineName
            // 
            this.vaccineName.Location = new System.Drawing.Point(93, 306);
            this.vaccineName.Name = "vaccineName";
            this.vaccineName.Size = new System.Drawing.Size(140, 20);
            this.vaccineName.TabIndex = 42;
            // 
            // vaccineId
            // 
            this.vaccineId.Location = new System.Drawing.Point(93, 270);
            this.vaccineId.Name = "vaccineId";
            this.vaccineId.Size = new System.Drawing.Size(140, 20);
            this.vaccineId.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Nome";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(9, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 27);
            this.label7.TabIndex = 39;
            this.label7.Text = "Casa Farmaceutica";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "IdVaccino";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 24);
            this.label11.TabIndex = 37;
            this.label11.Text = "Aggiungi Vaccino";
            // 
            // vaccineHouse
            // 
            this.vaccineHouse.Location = new System.Drawing.Point(93, 345);
            this.vaccineHouse.Name = "vaccineHouse";
            this.vaccineHouse.Size = new System.Drawing.Size(140, 20);
            this.vaccineHouse.TabIndex = 45;
            // 
            // vaccineTime
            // 
            this.vaccineTime.Location = new System.Drawing.Point(93, 378);
            this.vaccineTime.Name = "vaccineTime";
            this.vaccineTime.Size = new System.Drawing.Size(140, 20);
            this.vaccineTime.TabIndex = 46;
            // 
            // vaccinePrice
            // 
            this.vaccinePrice.Location = new System.Drawing.Point(93, 413);
            this.vaccinePrice.Name = "vaccinePrice";
            this.vaccinePrice.Size = new System.Drawing.Size(140, 20);
            this.vaccinePrice.TabIndex = 47;
            // 
            // vaccineInfo
            // 
            this.vaccineInfo.Location = new System.Drawing.Point(93, 447);
            this.vaccineInfo.Name = "vaccineInfo";
            this.vaccineInfo.Size = new System.Drawing.Size(140, 20);
            this.vaccineInfo.TabIndex = 48;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 481);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(9, 378);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 38);
            this.label12.TabIndex = 51;
            this.label12.Text = "Tempo Richiamo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 416);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Prezzo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 450);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "Info";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 484);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "Fornitore";
            // 
            // supplierDelete
            // 
            this.supplierDelete.BackColor = System.Drawing.Color.Red;
            this.supplierDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.supplierDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.supplierDelete.Location = new System.Drawing.Point(760, 241);
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
            this.supplierInsert.Location = new System.Drawing.Point(760, 281);
            this.supplierInsert.Name = "supplierInsert";
            this.supplierInsert.Size = new System.Drawing.Size(75, 23);
            this.supplierInsert.TabIndex = 59;
            this.supplierInsert.Text = "Inserisci";
            this.supplierInsert.UseVisualStyleBackColor = false;
            // 
            // supplierName
            // 
            this.supplierName.Location = new System.Drawing.Point(595, 283);
            this.supplierName.Name = "supplierName";
            this.supplierName.Size = new System.Drawing.Size(140, 20);
            this.supplierName.TabIndex = 58;
            // 
            // supplierId
            // 
            this.supplierId.Location = new System.Drawing.Point(595, 243);
            this.supplierId.Name = "supplierId";
            this.supplierId.Size = new System.Drawing.Size(140, 20);
            this.supplierId.TabIndex = 57;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(529, 286);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 56;
            this.label16.Text = "Nome";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(529, 246);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 55;
            this.label17.Text = "IdFornitore";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(546, 198);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(167, 24);
            this.label18.TabIndex = 54;
            this.label18.Text = "Aggiungi Fornitore";
            // 
            // supplierCell
            // 
            this.supplierCell.Location = new System.Drawing.Point(595, 319);
            this.supplierCell.Name = "supplierCell";
            this.supplierCell.Size = new System.Drawing.Size(140, 20);
            this.supplierCell.TabIndex = 62;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(529, 322);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 61;
            this.label19.Text = "Telefono";
            // 
            // goBack
            // 
            this.goBack.Location = new System.Drawing.Point(780, 470);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(61, 40);
            this.goBack.TabIndex = 63;
            this.goBack.Text = "Torna Indietro";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // wareHouseCombo
            // 
            this.wareHouseCombo.FormattingEnabled = true;
            this.wareHouseCombo.Location = new System.Drawing.Point(75, 185);
            this.wareHouseCombo.Name = "wareHouseCombo";
            this.wareHouseCombo.Size = new System.Drawing.Size(140, 21);
            this.wareHouseCombo.TabIndex = 65;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 188);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 64;
            this.label20.Text = "Magazzino";
            // 
            // DirectorWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 519);
            this.Controls.Add(this.wareHouseCombo);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.supplierCell);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.supplierDelete);
            this.Controls.Add(this.supplierInsert);
            this.Controls.Add(this.supplierName);
            this.Controls.Add(this.supplierId);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.vaccineInfo);
            this.Controls.Add(this.vaccinePrice);
            this.Controls.Add(this.vaccineTime);
            this.Controls.Add(this.vaccineHouse);
            this.Controls.Add(this.vaccineDelete);
            this.Controls.Add(this.vaccineInsert);
            this.Controls.Add(this.vaccineName);
            this.Controls.Add(this.vaccineId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.residencePatient);
            this.Controls.Add(this.wareHouseDelete);
            this.Controls.Add(this.wareHouseInsert);
            this.Controls.Add(this.wareHouseName);
            this.Controls.Add(this.warehouseId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stocksDelete);
            this.Controls.Add(this.stocksInsert);
            this.Controls.Add(this.stocksNumber);
            this.Controls.Add(this.stocksId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DirectorWarehouse";
            this.Text = "DirectorWarehouse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DirectorWarehouse_FormClosing);
            this.Load += new System.EventHandler(this.DirectorWarehouse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stocksDelete;
        private System.Windows.Forms.Button stocksInsert;
        private System.Windows.Forms.TextBox stocksNumber;
        private System.Windows.Forms.TextBox stocksId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button wareHouseDelete;
        private System.Windows.Forms.Button wareHouseInsert;
        private System.Windows.Forms.TextBox wareHouseName;
        private System.Windows.Forms.TextBox warehouseId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox residencePatient;
        private System.Windows.Forms.Button vaccineDelete;
        private System.Windows.Forms.Button vaccineInsert;
        private System.Windows.Forms.TextBox vaccineName;
        private System.Windows.Forms.TextBox vaccineId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox vaccineHouse;
        private System.Windows.Forms.TextBox vaccineTime;
        private System.Windows.Forms.TextBox vaccinePrice;
        private System.Windows.Forms.TextBox vaccineInfo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button supplierDelete;
        private System.Windows.Forms.Button supplierInsert;
        private System.Windows.Forms.TextBox supplierName;
        private System.Windows.Forms.TextBox supplierId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox supplierCell;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.ComboBox wareHouseCombo;
        private System.Windows.Forms.Label label20;
    }
}