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
            this.btnChangeDate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnChangeName = new System.Windows.Forms.Button();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.cbTramStatus = new System.Windows.Forms.ComboBox();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbDatum.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCleaning
            // 
            this.lbCleaning.FormattingEnabled = true;
            this.lbCleaning.Location = new System.Drawing.Point(4, 19);
            this.lbCleaning.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbCleaning.Name = "lbCleaning";
            this.lbCleaning.Size = new System.Drawing.Size(128, 225);
            this.lbCleaning.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCleaning);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(136, 249);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schoonmaaklijst";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(4, 19);
            this.dtDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(180, 20);
            this.dtDate.TabIndex = 6;
            // 
            // gbDatum
            // 
            this.gbDatum.Controls.Add(this.btnChangeDate);
            this.gbDatum.Controls.Add(this.dtDate);
            this.gbDatum.Location = new System.Drawing.Point(166, 11);
            this.gbDatum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDatum.Name = "gbDatum";
            this.gbDatum.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDatum.Size = new System.Drawing.Size(188, 71);
            this.gbDatum.TabIndex = 7;
            this.gbDatum.TabStop = false;
            this.gbDatum.Text = "Datum";
            // 
            // btnChangeDate
            // 
            this.btnChangeDate.Location = new System.Drawing.Point(4, 41);
            this.btnChangeDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangeDate.Name = "btnChangeDate";
            this.btnChangeDate.Size = new System.Drawing.Size(178, 24);
            this.btnChangeDate.TabIndex = 8;
            this.btnChangeDate.Text = "Verander datum";
            this.btnChangeDate.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbName);
            this.groupBox3.Controls.Add(this.btnChangeName);
            this.groupBox3.Location = new System.Drawing.Point(166, 98);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(188, 71);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Naam";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(4, 18);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(180, 20);
            this.tbName.TabIndex = 9;
            // 
            // btnChangeName
            // 
            this.btnChangeName.Location = new System.Drawing.Point(4, 41);
            this.btnChangeName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(178, 24);
            this.btnChangeName.TabIndex = 8;
            this.btnChangeName.Text = "Verander naam";
            this.btnChangeName.UseVisualStyleBackColor = true;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.cbTramStatus);
            this.gbStatus.Controls.Add(this.btnChangeStatus);
            this.gbStatus.Location = new System.Drawing.Point(166, 188);
            this.gbStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbStatus.Size = new System.Drawing.Size(188, 71);
            this.gbStatus.TabIndex = 9;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // cbTramStatus
            // 
            this.cbTramStatus.FormattingEnabled = true;
            this.cbTramStatus.Location = new System.Drawing.Point(5, 18);
            this.cbTramStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTramStatus.Name = "cbTramStatus";
            this.cbTramStatus.Size = new System.Drawing.Size(179, 21);
            this.cbTramStatus.TabIndex = 9;
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Location = new System.Drawing.Point(4, 41);
            this.btnChangeStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(178, 24);
            this.btnChangeStatus.TabIndex = 8;
            this.btnChangeStatus.Text = "Verander status";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            // 
            // CleanerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 271);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbDatum);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CleanerForm";
            this.Text = "CleanerForm";
            this.Load += new System.EventHandler(this.CleanerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbDatum.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbCleaning;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.GroupBox gbDatum;
        private System.Windows.Forms.Button btnChangeDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbTramStatus;
    }
}