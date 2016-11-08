namespace TrinityRailsDemo
{
    partial class CleanerForm
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
            this.lbSchoonmaak = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLaatLijstZien = new System.Windows.Forms.Button();
            this.datumKiezer = new System.Windows.Forms.DateTimePicker();
            this.gbDatum = new System.Windows.Forms.GroupBox();
            this.btnVeranderDatum = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVeranderNaam = new System.Windows.Forms.Button();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.btnVeranderStatus = new System.Windows.Forms.Button();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.gbDatum.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSchoonmaak
            // 
            this.lbSchoonmaak.FormattingEnabled = true;
            this.lbSchoonmaak.ItemHeight = 16;
            this.lbSchoonmaak.Location = new System.Drawing.Point(6, 23);
            this.lbSchoonmaak.Name = "lbSchoonmaak";
            this.lbSchoonmaak.Size = new System.Drawing.Size(169, 276);
            this.lbSchoonmaak.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbSchoonmaak);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 306);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schoonmaaklijst";
            // 
            // btnLaatLijstZien
            // 
            this.btnLaatLijstZien.Location = new System.Drawing.Point(19, 326);
            this.btnLaatLijstZien.Name = "btnLaatLijstZien";
            this.btnLaatLijstZien.Size = new System.Drawing.Size(169, 29);
            this.btnLaatLijstZien.TabIndex = 2;
            this.btnLaatLijstZien.Text = "Laat lijst zien";
            this.btnLaatLijstZien.UseVisualStyleBackColor = true;
            // 
            // datumKiezer
            // 
            this.datumKiezer.Location = new System.Drawing.Point(6, 23);
            this.datumKiezer.Name = "datumKiezer";
            this.datumKiezer.Size = new System.Drawing.Size(238, 22);
            this.datumKiezer.TabIndex = 6;
            // 
            // gbDatum
            // 
            this.gbDatum.Controls.Add(this.btnVeranderDatum);
            this.gbDatum.Controls.Add(this.datumKiezer);
            this.gbDatum.Location = new System.Drawing.Point(221, 13);
            this.gbDatum.Name = "gbDatum";
            this.gbDatum.Size = new System.Drawing.Size(251, 87);
            this.gbDatum.TabIndex = 7;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbNaam);
            this.groupBox3.Controls.Add(this.btnVeranderNaam);
            this.groupBox3.Location = new System.Drawing.Point(221, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 87);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Naam";
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
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.cbStatus);
            this.gbStatus.Controls.Add(this.btnVeranderStatus);
            this.gbStatus.Location = new System.Drawing.Point(221, 232);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(251, 87);
            this.gbStatus.TabIndex = 9;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
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
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(6, 22);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(238, 22);
            this.tbNaam.TabIndex = 9;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(7, 22);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(237, 24);
            this.cbStatus.TabIndex = 9;
            // 
            // CleanerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 366);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbDatum);
            this.Controls.Add(this.btnLaatLijstZien);
            this.Controls.Add(this.groupBox1);
            this.Name = "CleanerForm";
            this.Text = "CleanerForm";
            this.groupBox1.ResumeLayout(false);
            this.gbDatum.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbSchoonmaak;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLaatLijstZien;
        private System.Windows.Forms.DateTimePicker datumKiezer;
        private System.Windows.Forms.GroupBox gbDatum;
        private System.Windows.Forms.Button btnVeranderDatum;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnVeranderNaam;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.Button btnVeranderStatus;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.ComboBox cbStatus;
    }
}