namespace TrinityRailsDemo.RailForms
{
    partial class BlockRailSector
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
            this.tbRailNumber = new System.Windows.Forms.RichTextBox();
            this.tbSectorNumber = new System.Windows.Forms.RichTextBox();
            this.lblRailNumber = new System.Windows.Forms.Label();
            this.btnToggle = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSectorNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbRailNumber
            // 
            this.tbRailNumber.Location = new System.Drawing.Point(39, 55);
            this.tbRailNumber.Name = "tbRailNumber";
            this.tbRailNumber.Size = new System.Drawing.Size(93, 61);
            this.tbRailNumber.TabIndex = 0;
            this.tbRailNumber.Text = "";
            // 
            // tbSectorNumber
            // 
            this.tbSectorNumber.Location = new System.Drawing.Point(175, 55);
            this.tbSectorNumber.Name = "tbSectorNumber";
            this.tbSectorNumber.Size = new System.Drawing.Size(93, 61);
            this.tbSectorNumber.TabIndex = 1;
            this.tbSectorNumber.Text = "";
            // 
            // lblRailNumber
            // 
            this.lblRailNumber.AutoSize = true;
            this.lblRailNumber.Location = new System.Drawing.Point(39, 36);
            this.lblRailNumber.Name = "lblRailNumber";
            this.lblRailNumber.Size = new System.Drawing.Size(72, 13);
            this.lblRailNumber.TabIndex = 2;
            this.lblRailNumber.Text = "Spoornummer";
            // 
            // btnToggle
            // 
            this.btnToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggle.Location = new System.Drawing.Point(39, 147);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(93, 64);
            this.btnToggle.TabIndex = 3;
            this.btnToggle.Text = "Toggle";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(175, 147);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 64);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblSectorNumber
            // 
            this.lblSectorNumber.AutoSize = true;
            this.lblSectorNumber.Location = new System.Drawing.Point(172, 39);
            this.lblSectorNumber.Name = "lblSectorNumber";
            this.lblSectorNumber.Size = new System.Drawing.Size(75, 13);
            this.lblSectorNumber.TabIndex = 5;
            this.lblSectorNumber.Text = "Sectornummer";
            // 
            // BlockRailSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 261);
            this.Controls.Add(this.lblSectorNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.lblRailNumber);
            this.Controls.Add(this.tbSectorNumber);
            this.Controls.Add(this.tbRailNumber);
            this.Name = "BlockRailSector";
            this.Text = "Toggle blokkade spoor of sector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbRailNumber;
        private System.Windows.Forms.RichTextBox tbSectorNumber;
        private System.Windows.Forms.Label lblRailNumber;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSectorNumber;
    }
}