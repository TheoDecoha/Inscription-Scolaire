namespace WindowsFormsApplication1
{
    partial class Modification
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
            this.cbliste = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tbcp1 = new System.Windows.Forms.TextBox();
            this.CP = new System.Windows.Forms.Label();
            this.tbclasse = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.tbcp2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbville2 = new System.Windows.Forms.TextBox();
            this.tbadresse2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbtel = new System.Windows.Forms.TextBox();
            this.tbprenom = new System.Windows.Forms.TextBox();
            this.tbadresse1 = new System.Windows.Forms.TextBox();
            this.tbville1 = new System.Windows.Forms.TextBox();
            this.tbnom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbliste
            // 
            this.cbliste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbliste.FormattingEnabled = true;
            this.cbliste.Location = new System.Drawing.Point(120, 16);
            this.cbliste.Name = "cbliste";
            this.cbliste.Size = new System.Drawing.Size(302, 21);
            this.cbliste.TabIndex = 38;
            this.cbliste.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Eleve à modifier :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 29);
            this.button2.TabIndex = 79;
            this.button2.Text = "Quitter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // tbcp1
            // 
            this.tbcp1.Location = new System.Drawing.Point(373, 155);
            this.tbcp1.Name = "tbcp1";
            this.tbcp1.Size = new System.Drawing.Size(100, 20);
            this.tbcp1.TabIndex = 78;
            // 
            // CP
            // 
            this.CP.AutoSize = true;
            this.CP.Location = new System.Drawing.Point(297, 158);
            this.CP.Name = "CP";
            this.CP.Size = new System.Drawing.Size(70, 13);
            this.CP.TabIndex = 77;
            this.CP.Text = "Code Postal :";
            // 
            // tbclasse
            // 
            this.tbclasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbclasse.FormattingEnabled = true;
            this.tbclasse.Items.AddRange(new object[] {
            "Petite section",
            "Moyenne section",
            "Grande section",
            "CP",
            "CE1",
            "CE2",
            "CM1",
            "CM2"});
            this.tbclasse.Location = new System.Drawing.Point(120, 233);
            this.tbclasse.Name = "tbclasse";
            this.tbclasse.Size = new System.Drawing.Size(162, 21);
            this.tbclasse.TabIndex = 76;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(67, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 75;
            this.label13.Text = "Classe :";
            // 
            // tbnum
            // 
            this.tbnum.Enabled = false;
            this.tbnum.Location = new System.Drawing.Point(120, 59);
            this.tbnum.Name = "tbnum";
            this.tbnum.Size = new System.Drawing.Size(162, 20);
            this.tbnum.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Numéro :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 125);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker1.TabIndex = 72;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(194, 499);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 29);
            this.button3.TabIndex = 71;
            this.button3.Text = "Annuler";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tbcp2
            // 
            this.tbcp2.Location = new System.Drawing.Point(120, 406);
            this.tbcp2.Name = "tbcp2";
            this.tbcp2.Size = new System.Drawing.Size(100, 20);
            this.tbcp2.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(67, 409);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "CP :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Adresse :";
            // 
            // tbville2
            // 
            this.tbville2.Location = new System.Drawing.Point(356, 406);
            this.tbville2.Name = "tbville2";
            this.tbville2.Size = new System.Drawing.Size(100, 20);
            this.tbville2.TabIndex = 21;
            // 
            // tbadresse2
            // 
            this.tbadresse2.Location = new System.Drawing.Point(120, 367);
            this.tbadresse2.Name = "tbadresse2";
            this.tbadresse2.Size = new System.Drawing.Size(162, 20);
            this.tbadresse2.TabIndex = 22;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(50, 318);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 17);
            this.checkBox1.TabIndex = 69;
            this.checkBox1.Text = "Deuxième adresse";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 29);
            this.button1.TabIndex = 68;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Modification_Load);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(297, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "Prénom :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Date de naissance :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Adresse :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Ville :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Téléphone :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(75, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 61;
            this.label12.Text = "Nom :";
            // 
            // tbtel
            // 
            this.tbtel.Location = new System.Drawing.Point(123, 190);
            this.tbtel.Name = "tbtel";
            this.tbtel.Size = new System.Drawing.Size(100, 20);
            this.tbtel.TabIndex = 60;
            // 
            // tbprenom
            // 
            this.tbprenom.Location = new System.Drawing.Point(373, 92);
            this.tbprenom.Name = "tbprenom";
            this.tbprenom.Size = new System.Drawing.Size(100, 20);
            this.tbprenom.TabIndex = 59;
            // 
            // tbadresse1
            // 
            this.tbadresse1.Location = new System.Drawing.Point(120, 155);
            this.tbadresse1.Name = "tbadresse1";
            this.tbadresse1.Size = new System.Drawing.Size(162, 20);
            this.tbadresse1.TabIndex = 58;
            // 
            // tbville1
            // 
            this.tbville1.Location = new System.Drawing.Point(373, 186);
            this.tbville1.Name = "tbville1";
            this.tbville1.Size = new System.Drawing.Size(100, 20);
            this.tbville1.TabIndex = 57;
            // 
            // tbnom
            // 
            this.tbnom.Location = new System.Drawing.Point(120, 92);
            this.tbnom.Name = "tbnom";
            this.tbnom.Size = new System.Drawing.Size(162, 20);
            this.tbnom.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Ville :";
            // 
            // Modification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 588);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbcp2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbcp1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CP);
            this.Controls.Add(this.tbclasse);
            this.Controls.Add(this.tbville2);
            this.Controls.Add(this.tbadresse2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbtel);
            this.Controls.Add(this.tbprenom);
            this.Controls.Add(this.tbadresse1);
            this.Controls.Add(this.tbville1);
            this.Controls.Add(this.tbnom);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbliste);
            this.Name = "Modification";
            this.Text = "Modification";
            this.Load += new System.EventHandler(this.Modification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbliste;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbcp1;
        private System.Windows.Forms.Label CP;
        private System.Windows.Forms.ComboBox tbclasse;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbcp2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbville2;
        private System.Windows.Forms.TextBox tbadresse2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbtel;
        private System.Windows.Forms.TextBox tbprenom;
        private System.Windows.Forms.TextBox tbadresse1;
        private System.Windows.Forms.TextBox tbville1;
        private System.Windows.Forms.TextBox tbnom;
        private System.Windows.Forms.Label label2;
    }
}