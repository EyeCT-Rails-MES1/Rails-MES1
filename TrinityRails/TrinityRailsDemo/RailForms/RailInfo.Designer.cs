namespace TrinityRailsDemo.RailForms
{
    partial class InfoSpoor
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
            this.tbRailInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbRailNumber
            // 
            this.tbRailNumber.Location = new System.Drawing.Point(88, 23);
            this.tbRailNumber.Name = "tbRailNumber";
            this.tbRailNumber.Size = new System.Drawing.Size(100, 42);
            this.tbRailNumber.TabIndex = 0;
            this.tbRailNumber.Text = "";
            // 
            // tbRailInfo
            // 
            this.tbRailInfo.Location = new System.Drawing.Point(12, 81);
            this.tbRailInfo.Name = "tbRailInfo";
            this.tbRailInfo.Size = new System.Drawing.Size(260, 168);
            this.tbRailInfo.TabIndex = 1;
            this.tbRailInfo.Text = "";
            // 
            // InfoSpoor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbRailInfo);
            this.Controls.Add(this.tbRailNumber);
            this.Name = "InfoSpoor";
            this.Text = "RailInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbRailNumber;
        private System.Windows.Forms.RichTextBox tbRailInfo;
    }
}