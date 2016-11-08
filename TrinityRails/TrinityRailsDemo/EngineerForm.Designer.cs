namespace TrinityRailsDemo
{
    partial class EngineerForm
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
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnVeranderStatus = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.btnVeranderNaam = new System.Windows.Forms.Button();
            this.gbDatum = new System.Windows.Forms.GroupBox();
            this.btnVeranderDatum = new System.Windows.Forms.Button();
            this.datumKiezer = new System.Windows.Forms.DateTimePicker();
            this.btnMaakAan = new System.Windows.Forms.Button();
            this.gbStatus.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbDatum.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.cbStatus);
            this.gbStatus.Controls.Add(this.btnVeranderStatus);
            this.gbStatus.Location = new System.Drawing.Point(12, 231);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(251, 87);
            this.gbStatus.TabIndex = 14;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(7, 22);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(237, 24);
            this.cbStatus.TabIndex = 9;
            // 
            // btnVeranderStatus
            // 
            this.btnVeranderStatus.Location = new System.Drawing.Point(6, 51);
            this.btnVeranderStatus.Name = "btnVeranderStatus";
            this.btnVeranderStatus.Size = new System.Drawing.Size(238, 29);
            this.btnVeranderStatus.TabIndex = 8;
            this.btnVeranderStatus.Text = "Verander status";
            this.btnVeranderStatus.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbNaam);
            this.groupBox3.Controls.Add(this.btnVeranderNaam);
            this.groupBox3.Location = new System.Drawing.Point(12, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 87);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Naam";
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(6, 22);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(238, 22);
            this.tbNaam.TabIndex = 9;
            // 
            // btnVeranderNaam
            // 
            this.btnVeranderNaam.Location = new System.Drawing.Point(6, 51);
            this.btnVeranderNaam.Name = "btnVeranderNaam";
            this.btnVeranderNaam.Size = new System.Drawing.Size(238, 29);
            this.btnVeranderNaam.TabIndex = 8;
            this.btnVeranderNaam.Text = "Verander naam";
            this.btnVeranderNaam.UseVisualStyleBackColor = true;
            // 
            // gbDatum
            // 
            this.gbDatum.Controls.Add(this.btnVeranderDatum);
            this.gbDatum.Controls.Add(this.datumKiezer);
            this.gbDatum.Location = new System.Drawing.Point(12, 12);
            this.gbDatum.Name = "gbDatum";
            this.gbDatum.Size = new System.Drawing.Size(251, 87);
            this.gbDatum.TabIndex = 12;
            this.gbDatum.TabStop = false;
            this.gbDatum.Text = "Datum";
            // 
            // btnVeranderDatum
            // 
            this.btnVeranderDatum.Location = new System.Drawing.Point(6, 51);
            this.btnVeranderDatum.Name = "btnVeranderDatum";
            this.btnVeranderDatum.Size = new System.Drawing.Size(238, 29);
            this.btnVeranderDatum.TabIndex = 8;
            this.btnVeranderDatum.Text = "Verander datum";
            this.btnVeranderDatum.UseVisualStyleBackColor = true;
            // 
            // datumKiezer
            // 
            this.datumKiezer.Location = new System.Drawing.Point(6, 23);
            this.datumKiezer.Name = "datumKiezer";
            this.datumKiezer.Size = new System.Drawing.Size(238, 22);
            this.datumKiezer.TabIndex = 6;
            // 
            // btnMaakAan
            // 
            this.btnMaakAan.Location = new System.Drawing.Point(18, 352);
            this.btnMaakAan.Name = "btnMaakAan";
            this.btnMaakAan.Size = new System.Drawing.Size(238, 29);
            this.btnMaakAan.TabIndex = 15;
            this.btnMaakAan.Text = "Maak aan";
            this.btnMaakAan.UseVisualStyleBackColor = true;
            // 
            // EngineerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 393);
            this.Controls.Add(this.btnMaakAan);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbDatum);
            this.Name = "EngineerForm";
            this.Text = "EngineerForm";
            this.gbStatus.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbDatum.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnVeranderStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Button btnVeranderNaam;
        private System.Windows.Forms.GroupBox gbDatum;
        private System.Windows.Forms.Button btnVeranderDatum;
        private System.Windows.Forms.DateTimePicker datumKiezer;
        private System.Windows.Forms.Button btnMaakAan;
    }
}