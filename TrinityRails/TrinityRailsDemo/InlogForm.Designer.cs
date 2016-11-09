namespace TrinityRailsDemo
{
    partial class InlogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InlogForm));
            this.gbxInlog = new System.Windows.Forms.GroupBox();
            this.btnInloggen = new System.Windows.Forms.Button();
            this.txtWachtwoord = new System.Windows.Forms.TextBox();
            this.txtGebruikersnaam = new System.Windows.Forms.TextBox();
            this.btnScanRFID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxInlog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxInlog
            // 
            this.gbxInlog.Controls.Add(this.pictureBox1);
            this.gbxInlog.Controls.Add(this.btnScanRFID);
            this.gbxInlog.Controls.Add(this.btnInloggen);
            this.gbxInlog.Controls.Add(this.label2);
            this.gbxInlog.Controls.Add(this.label1);
            this.gbxInlog.Controls.Add(this.txtWachtwoord);
            this.gbxInlog.Controls.Add(this.txtGebruikersnaam);
            this.gbxInlog.Location = new System.Drawing.Point(13, 13);
            this.gbxInlog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxInlog.Name = "gbxInlog";
            this.gbxInlog.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxInlog.Size = new System.Drawing.Size(438, 432);
            this.gbxInlog.TabIndex = 0;
            this.gbxInlog.TabStop = false;
            // 
            // btnInloggen
            // 
            this.btnInloggen.Location = new System.Drawing.Point(89, 123);
            this.btnInloggen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(265, 50);
            this.btnInloggen.TabIndex = 2;
            this.btnInloggen.Text = "Inloggen";
            this.btnInloggen.UseVisualStyleBackColor = true;
            this.btnInloggen.Click += new System.EventHandler(this.btnInloggen_Click);
            // 
            // txtWachtwoord
            // 
            this.txtWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWachtwoord.Location = new System.Drawing.Point(165, 71);
            this.txtWachtwoord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWachtwoord.Multiline = true;
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.Size = new System.Drawing.Size(265, 29);
            this.txtWachtwoord.TabIndex = 1;
            // 
            // txtGebruikersnaam
            // 
            this.txtGebruikersnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGebruikersnaam.Location = new System.Drawing.Point(166, 23);
            this.txtGebruikersnaam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGebruikersnaam.Multiline = true;
            this.txtGebruikersnaam.Name = "txtGebruikersnaam";
            this.txtGebruikersnaam.Size = new System.Drawing.Size(265, 29);
            this.txtGebruikersnaam.TabIndex = 0;
            // 
            // btnScanRFID
            // 
            this.btnScanRFID.Location = new System.Drawing.Point(89, 181);
            this.btnScanRFID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnScanRFID.Name = "btnScanRFID";
            this.btnScanRFID.Size = new System.Drawing.Size(265, 50);
            this.btnScanRFID.TabIndex = 21;
            this.btnScanRFID.Text = "Scan RFID";
            this.btnScanRFID.UseVisualStyleBackColor = true;
            this.btnScanRFID.Click += new System.EventHandler(this.btnScanRFID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gebruikersnaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wachtwoord:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // InlogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 449);
            this.Controls.Add(this.gbxInlog);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InlogForm";
            this.Text = "Inloggen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gbxInlog.ResumeLayout(false);
            this.gbxInlog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInlog;
        private System.Windows.Forms.Button btnInloggen;
        private System.Windows.Forms.TextBox txtWachtwoord;
        private System.Windows.Forms.TextBox txtGebruikersnaam;
        private System.Windows.Forms.Button btnScanRFID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

