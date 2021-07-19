
namespace OspedaleEVaccinazioni
{
    partial class LoginForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.NurseOption = new System.Windows.Forms.Button();
            this.DirectorOption = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NurseOption
            // 
            this.NurseOption.Location = new System.Drawing.Point(227, 209);
            this.NurseOption.Name = "NurseOption";
            this.NurseOption.Size = new System.Drawing.Size(111, 55);
            this.NurseOption.TabIndex = 0;
            this.NurseOption.Text = "Infermiere";
            this.NurseOption.UseVisualStyleBackColor = true;
            this.NurseOption.Click += new System.EventHandler(this.NurseOption_Click);
            // 
            // DirectorOption
            // 
            this.DirectorOption.Location = new System.Drawing.Point(227, 316);
            this.DirectorOption.Name = "DirectorOption";
            this.DirectorOption.Size = new System.Drawing.Size(111, 55);
            this.DirectorOption.TabIndex = 1;
            this.DirectorOption.Text = "Direttore";
            this.DirectorOption.UseVisualStyleBackColor = true;
            this.DirectorOption.Click += new System.EventHandler(this.DirectorOption_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(155, 107);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(254, 25);
            this.Title.TabIndex = 2;
            this.Title.Text = "Chi userà l\'Applicazione?";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.DirectorOption);
            this.Controls.Add(this.NurseOption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NurseOption;
        private System.Windows.Forms.Button DirectorOption;
        private System.Windows.Forms.Label Title;
    }
}

