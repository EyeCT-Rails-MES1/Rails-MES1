namespace TrinityRailsDemo.SideForms
{
    partial class ReserveTram
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
            this.tbTramNumber = new System.Windows.Forms.RichTextBox();
            this.tbRailNumber = new System.Windows.Forms.RichTextBox();
            this.btnBevestig = new System.Windows.Forms.Button();
            this.lblTramNumber = new System.Windows.Forms.Label();
            this.lblTrackNumber = new System.Windows.Forms.Label();
            this.cbRepair = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbTramNumber
            // 
            this.tbTramNumber.Location = new System.Drawing.Point(12, 56);
            this.tbTramNumber.Name = "tbTramNumber";
            this.tbTramNumber.Size = new System.Drawing.Size(97, 65);
            this.tbTramNumber.TabIndex = 0;
            this.tbTramNumber.Text = "";
            // 
            // tbRailNumber
            // 
            this.tbRailNumber.Location = new System.Drawing.Point(140, 56);
            this.tbRailNumber.Name = "tbRailNumber";
            this.tbRailNumber.Size = new System.Drawing.Size(100, 65);
            this.tbRailNumber.TabIndex = 1;
            this.tbRailNumber.Text = "";
            // 
            // btnBevestig
            // 
            this.btnBevestig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBevestig.Location = new System.Drawing.Point(12, 171);
            this.btnBevestig.Name = "btnBevestig";
            this.btnBevestig.Size = new System.Drawing.Size(97, 39);
            this.btnBevestig.TabIndex = 2;
            this.btnBevestig.Text = "Bevestig";
            this.btnBevestig.UseVisualStyleBackColor = true;
            this.btnBevestig.Click += new System.EventHandler(this.btnBevestig_Click);
            // 
            // lblTramNumber
            // 
            this.lblTramNumber.AutoSize = true;
            this.lblTramNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramNumber.Location = new System.Drawing.Point(6, 33);
            this.lblTramNumber.Name = "lblTramNumber";
            this.lblTramNumber.Size = new System.Drawing.Size(103, 20);
            this.lblTramNumber.TabIndex = 3;
            this.lblTramNumber.Text = "Tramnummer";
            // 
            // lblTrackNumber
            // 
            this.lblTrackNumber.AutoSize = true;
            this.lblTrackNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackNumber.Location = new System.Drawing.Point(136, 33);
            this.lblTrackNumber.Name = "lblTrackNumber";
            this.lblTrackNumber.Size = new System.Drawing.Size(110, 20);
            this.lblTrackNumber.TabIndex = 4;
            this.lblTrackNumber.Text = "Spoornummer";
            // 
            // cbRepair
            // 
            this.cbRepair.AutoSize = true;
            this.cbRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRepair.Location = new System.Drawing.Point(148, 179);
            this.cbRepair.Name = "cbRepair";
            this.cbRepair.Size = new System.Drawing.Size(98, 24);
            this.cbRepair.TabIndex = 5;
            this.cbRepair.Text = "Reparatie";
            this.cbRepair.UseVisualStyleBackColor = true;
            // 
            // ReserveTram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cbRepair);
            this.Controls.Add(this.lblTrackNumber);
            this.Controls.Add(this.lblTramNumber);
            this.Controls.Add(this.btnBevestig);
            this.Controls.Add(this.tbRailNumber);
            this.Controls.Add(this.tbTramNumber);
            this.Name = "ReserveTram";
            this.Text = "Reservering";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbTramNumber;
        private System.Windows.Forms.RichTextBox tbRailNumber;
        private System.Windows.Forms.Button btnBevestig;
        private System.Windows.Forms.Label lblTramNumber;
        private System.Windows.Forms.Label lblTrackNumber;
        private System.Windows.Forms.CheckBox cbRepair;
    }
}