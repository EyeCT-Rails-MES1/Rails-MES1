﻿namespace TrinityRailsDemo
{
    partial class DriverForm
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
            this.tbGoTo = new System.Windows.Forms.RichTextBox();
            this.tbHistory = new System.Windows.Forms.RichTextBox();
            this.tbRemarks = new System.Windows.Forms.RichTextBox();
            this.gbTechnicalhelp = new System.Windows.Forms.GroupBox();
            this.lblNeedTechHelp = new System.Windows.Forms.Label();
            this.tbTramNumber = new System.Windows.Forms.RichTextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnRecover = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblGoTo = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblHistory = new System.Windows.Forms.Label();
            this.lblTramNumber = new System.Windows.Forms.Label();
            this.rbCleaning = new System.Windows.Forms.RadioButton();
            this.rbRepair = new System.Windows.Forms.RadioButton();
            this.gbTechnicalhelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbGoTo
            // 
            this.tbGoTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGoTo.Location = new System.Drawing.Point(38, 43);
            this.tbGoTo.Name = "tbGoTo";
            this.tbGoTo.Size = new System.Drawing.Size(100, 52);
            this.tbGoTo.TabIndex = 1;
            this.tbGoTo.Text = "";
            // 
            // tbHistory
            // 
            this.tbHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHistory.Location = new System.Drawing.Point(641, 43);
            this.tbHistory.Name = "tbHistory";
            this.tbHistory.Size = new System.Drawing.Size(100, 93);
            this.tbHistory.TabIndex = 2;
            this.tbHistory.Text = "";
            // 
            // tbRemarks
            // 
            this.tbRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRemarks.Location = new System.Drawing.Point(22, 135);
            this.tbRemarks.Name = "tbRemarks";
            this.tbRemarks.Size = new System.Drawing.Size(173, 59);
            this.tbRemarks.TabIndex = 3;
            this.tbRemarks.Text = "";
            // 
            // gbTechnicalhelp
            // 
            this.gbTechnicalhelp.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbTechnicalhelp.Controls.Add(this.rbRepair);
            this.gbTechnicalhelp.Controls.Add(this.rbCleaning);
            this.gbTechnicalhelp.Controls.Add(this.lblNeedTechHelp);
            this.gbTechnicalhelp.Location = new System.Drawing.Point(22, 295);
            this.gbTechnicalhelp.Name = "gbTechnicalhelp";
            this.gbTechnicalhelp.Size = new System.Drawing.Size(241, 100);
            this.gbTechnicalhelp.TabIndex = 5;
            this.gbTechnicalhelp.TabStop = false;
            this.gbTechnicalhelp.Text = "groupBox1";
            // 
            // lblNeedTechHelp
            // 
            this.lblNeedTechHelp.AutoSize = true;
            this.lblNeedTechHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeedTechHelp.Location = new System.Drawing.Point(6, 17);
            this.lblNeedTechHelp.Name = "lblNeedTechHelp";
            this.lblNeedTechHelp.Size = new System.Drawing.Size(139, 20);
            this.lblNeedTechHelp.TabIndex = 20;
            this.lblNeedTechHelp.Text = "Assistentie nodig?";
            // 
            // tbTramNumber
            // 
            this.tbTramNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTramNumber.Location = new System.Drawing.Point(397, 43);
            this.tbTramNumber.Name = "tbTramNumber";
            this.tbTramNumber.Size = new System.Drawing.Size(100, 66);
            this.tbTramNumber.TabIndex = 6;
            this.tbTramNumber.Text = "";
            this.tbTramNumber.TextChanged += new System.EventHandler(this.tbTramNumber_TextChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(329, 161);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 50);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(410, 161);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 50);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(491, 161);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 50);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(329, 222);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 50);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(410, 222);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 50);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(491, 222);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 50);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(329, 278);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 50);
            this.btn7.TabIndex = 13;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(410, 278);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 50);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(491, 278);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 50);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnRecover
            // 
            this.btnRecover.Location = new System.Drawing.Point(329, 334);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(75, 50);
            this.btnRecover.TabIndex = 16;
            this.btnRecover.Text = "Hertel";
            this.btnRecover.UseVisualStyleBackColor = true;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(410, 334);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 50);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(491, 334);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 50);
            this.btnConfirm.TabIndex = 18;
            this.btnConfirm.Text = "Bevestig";
            this.btnConfirm.UseCompatibleTextRendering = true;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblGoTo
            // 
            this.lblGoTo.AutoSize = true;
            this.lblGoTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoTo.Location = new System.Drawing.Point(35, 23);
            this.lblGoTo.Name = "lblGoTo";
            this.lblGoTo.Size = new System.Drawing.Size(60, 17);
            this.lblGoTo.TabIndex = 19;
            this.lblGoTo.Text = "Ga naar";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.Location = new System.Drawing.Point(19, 115);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(93, 17);
            this.lblRemarks.TabIndex = 21;
            this.lblRemarks.Text = "Opmerkingen";
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.Location = new System.Drawing.Point(638, 23);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(56, 17);
            this.lblHistory.TabIndex = 22;
            this.lblHistory.Text = "Historie";
            // 
            // lblTramNumber
            // 
            this.lblTramNumber.AutoSize = true;
            this.lblTramNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramNumber.Location = new System.Drawing.Point(394, 112);
            this.lblTramNumber.Name = "lblTramNumber";
            this.lblTramNumber.Size = new System.Drawing.Size(92, 17);
            this.lblTramNumber.TabIndex = 23;
            this.lblTramNumber.Text = "Tramnummer";
            // 
            // rbCleaning
            // 
            this.rbCleaning.AutoSize = true;
            this.rbCleaning.Location = new System.Drawing.Point(10, 56);
            this.rbCleaning.Name = "rbCleaning";
            this.rbCleaning.Size = new System.Drawing.Size(88, 17);
            this.rbCleaning.TabIndex = 24;
            this.rbCleaning.TabStop = true;
            this.rbCleaning.Text = "Schoonmaak";
            this.rbCleaning.UseVisualStyleBackColor = true;
            // 
            // rbRepair
            // 
            this.rbRepair.AutoSize = true;
            this.rbRepair.Location = new System.Drawing.Point(10, 77);
            this.rbRepair.Name = "rbRepair";
            this.rbRepair.Size = new System.Drawing.Size(71, 17);
            this.rbRepair.TabIndex = 25;
            this.rbRepair.TabStop = true;
            this.rbRepair.Text = "Reparatie";
            this.rbRepair.UseVisualStyleBackColor = true;
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblTramNumber);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblGoTo);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnRecover);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.tbTramNumber);
            this.Controls.Add(this.gbTechnicalhelp);
            this.Controls.Add(this.tbRemarks);
            this.Controls.Add(this.tbHistory);
            this.Controls.Add(this.tbGoTo);
            this.Name = "DriverForm";
            this.Text = "BestuurdersForm";
            this.gbTechnicalhelp.ResumeLayout(false);
            this.gbTechnicalhelp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbGoTo;
        private System.Windows.Forms.RichTextBox tbHistory;
        private System.Windows.Forms.RichTextBox tbRemarks;
        private System.Windows.Forms.GroupBox gbTechnicalhelp;
        private System.Windows.Forms.Label lblNeedTechHelp;
        private System.Windows.Forms.RichTextBox tbTramNumber;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblGoTo;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Label lblTramNumber;
        private System.Windows.Forms.RadioButton rbRepair;
        private System.Windows.Forms.RadioButton rbCleaning;
    }
}