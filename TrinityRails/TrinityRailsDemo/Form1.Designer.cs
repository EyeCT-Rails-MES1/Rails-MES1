namespace TrinityRailsDemo
{
    partial class Form1
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
            this.gbxInlog = new System.Windows.Forms.GroupBox();
            this.btnInloggen = new System.Windows.Forms.Button();
            this.txtWachtwoord = new System.Windows.Forms.TextBox();
            this.txtGebruikersnaam = new System.Windows.Forms.TextBox();
            this.btnRFIDInloggen = new System.Windows.Forms.Button();
            this.gbxInlog.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInlog
            // 
            this.gbxInlog.Controls.Add(this.btnInloggen);
            this.gbxInlog.Controls.Add(this.txtWachtwoord);
            this.gbxInlog.Controls.Add(this.txtGebruikersnaam);
            this.gbxInlog.Location = new System.Drawing.Point(312, 50);
            this.gbxInlog.Name = "gbxInlog";
            this.gbxInlog.Size = new System.Drawing.Size(400, 400);
            this.gbxInlog.TabIndex = 0;
            this.gbxInlog.TabStop = false;
            // 
            // btnInloggen
            // 
            this.btnInloggen.Location = new System.Drawing.Point(100, 213);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(200, 50);
            this.btnInloggen.TabIndex = 2;
            this.btnInloggen.Text = "Inloggen";
            this.btnInloggen.UseVisualStyleBackColor = true;
            this.btnInloggen.Click += new System.EventHandler(this.btnInloggen_Click);
            // 
            // txtWachtwoord
            // 
            this.txtWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWachtwoord.Location = new System.Drawing.Point(100, 150);
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.Size = new System.Drawing.Size(200, 30);
            this.txtWachtwoord.TabIndex = 1;
            // 
            // txtGebruikersnaam
            // 
            this.txtGebruikersnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGebruikersnaam.Location = new System.Drawing.Point(100, 50);
            this.txtGebruikersnaam.Name = "txtGebruikersnaam";
            this.txtGebruikersnaam.Size = new System.Drawing.Size(200, 30);
            this.txtGebruikersnaam.TabIndex = 0;
            // 
            // btnRFIDInloggen
            // 
            this.btnRFIDInloggen.Location = new System.Drawing.Point(796, 22);
            this.btnRFIDInloggen.Name = "btnRFIDInloggen";
            this.btnRFIDInloggen.Size = new System.Drawing.Size(200, 50);
            this.btnRFIDInloggen.TabIndex = 3;
            this.btnRFIDInloggen.Text = "Inloggen met RFID";
            this.btnRFIDInloggen.UseVisualStyleBackColor = true;
            this.btnRFIDInloggen.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnRFIDInloggen);
            this.Controls.Add(this.gbxInlog);
            this.Name = "Form1";
            this.Text = "Inloggen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gbxInlog.ResumeLayout(false);
            this.gbxInlog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInlog;
        private System.Windows.Forms.Button btnInloggen;
        private System.Windows.Forms.TextBox txtWachtwoord;
        private System.Windows.Forms.TextBox txtGebruikersnaam;
        private System.Windows.Forms.Button btnRFIDInloggen;
    }
}

