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
            this.btnFinishCleaning = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            // btnFinishCleaning
            // 
            this.btnFinishCleaning.Location = new System.Drawing.Point(166, 94);
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
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CleanerForm";
            this.Text = "CleanerForm";
            this.Load += new System.EventHandler(this.CleanerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbCleaning;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFinishCleaning;
    }
}