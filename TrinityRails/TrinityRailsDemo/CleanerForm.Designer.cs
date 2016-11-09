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
            this.lbCleaning = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.gbDatum = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnFinishCleaning = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbDatum.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCleaning
            // 
            this.lbCleaning.FormattingEnabled = true;
            this.lbCleaning.Location = new System.Drawing.Point(4, 19);
            this.lbCleaning.Margin = new System.Windows.Forms.Padding(2);
            this.lbCleaning.Name = "lbCleaning";
            this.lbCleaning.Size = new System.Drawing.Size(128, 225);
            this.lbCleaning.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCleaning);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(136, 249);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schoonmaaklijst";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(4, 19);
            this.dtDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(180, 20);
            this.dtDate.TabIndex = 6;
            // 
            // gbDatum
            // 
            this.gbDatum.Controls.Add(this.dtDate);
            this.gbDatum.Location = new System.Drawing.Point(166, 11);
            this.gbDatum.Margin = new System.Windows.Forms.Padding(2);
            this.gbDatum.Name = "gbDatum";
            this.gbDatum.Padding = new System.Windows.Forms.Padding(2);
            this.gbDatum.Size = new System.Drawing.Size(188, 47);
            this.gbDatum.TabIndex = 7;
            this.gbDatum.TabStop = false;
            this.gbDatum.Text = "Datum";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbName);
            this.groupBox3.Location = new System.Drawing.Point(166, 72);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(188, 46);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Naam";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(4, 18);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(180, 20);
            this.tbName.TabIndex = 9;
            // 
            // btnFinishCleaning
            // 
            this.btnFinishCleaning.Location = new System.Drawing.Point(170, 190);
            this.btnFinishCleaning.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinishCleaning.Name = "btnFinishCleaning";
            this.btnFinishCleaning.Size = new System.Drawing.Size(178, 65);
            this.btnFinishCleaning.TabIndex = 8;
            this.btnFinishCleaning.Text = "Schoonmaak afgerond";
            this.btnFinishCleaning.UseVisualStyleBackColor = true;
            this.btnFinishCleaning.Click += new System.EventHandler(this.btnFinishCleaning_Click);
            // 
            // CleanerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 271);
            this.Controls.Add(this.btnFinishCleaning);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbDatum);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CleanerForm";
            this.Text = "CleanerForm";
            this.Load += new System.EventHandler(this.CleanerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbDatum.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbCleaning;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.GroupBox gbDatum;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFinishCleaning;
        private System.Windows.Forms.TextBox tbName;
    }
}