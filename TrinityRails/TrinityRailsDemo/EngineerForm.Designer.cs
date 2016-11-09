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
            this.btnFinishRepair = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.gbDatum = new System.Windows.Forms.GroupBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbRepair = new System.Windows.Forms.ListBox();
            this.btnRepair = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.gbDatum.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFinishRepair
            // 
            this.btnFinishRepair.Location = new System.Drawing.Point(165, 200);
            this.btnFinishRepair.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinishRepair.Name = "btnFinishRepair";
            this.btnFinishRepair.Size = new System.Drawing.Size(188, 56);
            this.btnFinishRepair.TabIndex = 8;
            this.btnFinishRepair.Text = "Reparatie afgerond";
            this.btnFinishRepair.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbName);
            this.groupBox3.Location = new System.Drawing.Point(165, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(188, 44);
            this.groupBox3.TabIndex = 13;
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
            // gbDatum
            // 
            this.gbDatum.Controls.Add(this.dtDate);
            this.gbDatum.Location = new System.Drawing.Point(165, 140);
            this.gbDatum.Margin = new System.Windows.Forms.Padding(2);
            this.gbDatum.Name = "gbDatum";
            this.gbDatum.Padding = new System.Windows.Forms.Padding(2);
            this.gbDatum.Size = new System.Drawing.Size(188, 47);
            this.gbDatum.TabIndex = 12;
            this.gbDatum.TabStop = false;
            this.gbDatum.Text = "Datum";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(4, 19);
            this.dtDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(180, 20);
            this.dtDate.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbRepair);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(136, 249);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reparatielijst";
            // 
            // lbRepair
            // 
            this.lbRepair.FormattingEnabled = true;
            this.lbRepair.Location = new System.Drawing.Point(4, 20);
            this.lbRepair.Margin = new System.Windows.Forms.Padding(2);
            this.lbRepair.Name = "lbRepair";
            this.lbRepair.Size = new System.Drawing.Size(128, 225);
            this.lbRepair.TabIndex = 0;
            this.lbRepair.SelectedIndexChanged += new System.EventHandler(this.lbRepair_SelectedIndexChanged);
            // 
            // btnRepair
            // 
            this.btnRepair.Location = new System.Drawing.Point(165, 64);
            this.btnRepair.Margin = new System.Windows.Forms.Padding(2);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(188, 62);
            this.btnRepair.TabIndex = 16;
            this.btnRepair.Text = "Repareren";
            this.btnRepair.UseVisualStyleBackColor = true;
            this.btnRepair.Click += new System.EventHandler(this.button1_Click);
            // 
            // EngineerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 272);
            this.Controls.Add(this.btnRepair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFinishRepair);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbDatum);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EngineerForm";
            this.Text = "w";
            this.Load += new System.EventHandler(this.EngineerForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbDatum.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFinishRepair;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox gbDatum;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbRepair;
        private System.Windows.Forms.Button btnRepair;
    }
}