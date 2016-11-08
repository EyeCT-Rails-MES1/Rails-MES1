namespace TrinityRailsDemo.SideForms
{
    partial class TramStatus
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
            this.cbTramStatus = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbTramNumber = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTramNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTramStatus
            // 
            this.cbTramStatus.FormattingEnabled = true;
            this.cbTramStatus.Location = new System.Drawing.Point(22, 27);
            this.cbTramStatus.Name = "cbTramStatus";
            this.cbTramStatus.Size = new System.Drawing.Size(216, 21);
            this.cbTramStatus.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(183, 90);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 50);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok!";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // tbTramNumber
            // 
            this.tbTramNumber.Location = new System.Drawing.Point(55, 90);
            this.tbTramNumber.Name = "tbTramNumber";
            this.tbTramNumber.Size = new System.Drawing.Size(94, 55);
            this.tbTramNumber.TabIndex = 2;
            this.tbTramNumber.Text = "";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(183, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblTramNumber
            // 
            this.lblTramNumber.AutoSize = true;
            this.lblTramNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramNumber.Location = new System.Drawing.Point(52, 148);
            this.lblTramNumber.Name = "lblTramNumber";
            this.lblTramNumber.Size = new System.Drawing.Size(92, 17);
            this.lblTramNumber.TabIndex = 4;
            this.lblTramNumber.Text = "Tramnummer";
            // 
            // TramStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblTramNumber);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbTramNumber);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbTramStatus);
            this.Name = "TramStatus";
            this.Text = "TramStatus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTramStatus;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RichTextBox tbTramNumber;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblTramNumber;
    }
}