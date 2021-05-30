
namespace OspedaleEVaccinazioni
{
    partial class NurseViewVaccination
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idNurseText = new System.Windows.Forms.TextBox();
            this.executeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(496, 402);
            this.dataGridView1.TabIndex = 38;
            // 
            // idNurseText
            // 
            this.idNurseText.Location = new System.Drawing.Point(180, 12);
            this.idNurseText.Name = "idNurseText";
            this.idNurseText.Size = new System.Drawing.Size(152, 20);
            this.idNurseText.TabIndex = 39;
            this.idNurseText.Text = "Inserisci il tuo id";
            this.idNurseText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.idNurseText_MouseClick);
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(180, 38);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(152, 23);
            this.executeButton.TabIndex = 40;
            this.executeButton.Text = "Visualizza";
            this.executeButton.UseVisualStyleBackColor = true;
            // 
            // NurseViewVaccination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 513);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.idNurseText);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NurseViewVaccination";
            this.Text = "NurseViewVaccination";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NurseViewVaccination_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox idNurseText;
        private System.Windows.Forms.Button executeButton;
    }
}