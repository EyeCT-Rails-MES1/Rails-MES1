namespace TrinityRailsDemo
{
    partial class UserForm
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
            this.userList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbWachtwoord = new System.Windows.Forms.TextBox();
            this.tbFunctie = new System.Windows.Forms.TextBox();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnVeranderWachtwoord = new System.Windows.Forms.Button();
            this.btnVeranderNaam = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // userList
            // 
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 16;
            this.userList.Location = new System.Drawing.Point(6, 30);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(183, 260);
            this.userList.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 301);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gebruikerlijst";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbFunctie);
            this.groupBox2.Controls.Add(this.tbWachtwoord);
            this.groupBox2.Controls.Add(this.tbNaam);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(240, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 136);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gebruikergegevens";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wachtwoord:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Functie:";
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(116, 31);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(379, 22);
            this.tbNaam.TabIndex = 3;
            // 
            // tbWachtwoord
            // 
            this.tbWachtwoord.Location = new System.Drawing.Point(116, 64);
            this.tbWachtwoord.Name = "tbWachtwoord";
            this.tbWachtwoord.Size = new System.Drawing.Size(379, 22);
            this.tbWachtwoord.TabIndex = 4;
            // 
            // tbFunctie
            // 
            this.tbFunctie.Location = new System.Drawing.Point(116, 97);
            this.tbFunctie.Name = "tbFunctie";
            this.tbFunctie.Size = new System.Drawing.Size(379, 22);
            this.tbFunctie.TabIndex = 5;
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(10, 21);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(111, 51);
            this.btnVoegToe.TabIndex = 3;
            this.btnVoegToe.Text = "Nieuwe gebruiker";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(127, 21);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(111, 51);
            this.btnVerwijder.TabIndex = 4;
            this.btnVerwijder.Text = "Verwijder gebruiker";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            // 
            // btnVeranderWachtwoord
            // 
            this.btnVeranderWachtwoord.Location = new System.Drawing.Point(127, 87);
            this.btnVeranderWachtwoord.Name = "btnVeranderWachtwoord";
            this.btnVeranderWachtwoord.Size = new System.Drawing.Size(111, 51);
            this.btnVeranderWachtwoord.TabIndex = 6;
            this.btnVeranderWachtwoord.Text = "Verander wachtwoord";
            this.btnVeranderWachtwoord.UseVisualStyleBackColor = true;
            // 
            // btnVeranderNaam
            // 
            this.btnVeranderNaam.Location = new System.Drawing.Point(10, 87);
            this.btnVeranderNaam.Name = "btnVeranderNaam";
            this.btnVeranderNaam.Size = new System.Drawing.Size(111, 51);
            this.btnVeranderNaam.TabIndex = 5;
            this.btnVeranderNaam.Text = "Verander naam";
            this.btnVeranderNaam.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVoegToe);
            this.groupBox3.Controls.Add(this.btnVeranderWachtwoord);
            this.groupBox3.Controls.Add(this.btnVerwijder);
            this.groupBox3.Controls.Add(this.btnVeranderNaam);
            this.groupBox3.Location = new System.Drawing.Point(240, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 149);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opties";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 326);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbFunctie;
        private System.Windows.Forms.TextBox tbWachtwoord;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Button btnVeranderWachtwoord;
        private System.Windows.Forms.Button btnVeranderNaam;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}