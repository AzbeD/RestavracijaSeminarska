namespace SeminarskaNalogaRestavracija
{
    partial class FormMainZaposleni
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
            this.listBoxNarocila = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewPodrobnostiNarocila = new System.Windows.Forms.ListView();
            this.lblNaslovDostava = new System.Windows.Forms.Label();
            this.buttonZakljuci = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtImeZap = new System.Windows.Forms.TextBox();
            this.grpBoxDodajZaposlenega = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dropDownFunkcija = new System.Windows.Forms.ComboBox();
            this.txtGeslo = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPriimekZap = new System.Windows.Forms.TextBox();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.grpBoxDodajZaposlenega.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxNarocila
            // 
            this.listBoxNarocila.FormattingEnabled = true;
            this.listBoxNarocila.ItemHeight = 16;
            this.listBoxNarocila.Location = new System.Drawing.Point(12, 32);
            this.listBoxNarocila.Name = "listBoxNarocila";
            this.listBoxNarocila.Size = new System.Drawing.Size(382, 84);
            this.listBoxNarocila.TabIndex = 0;
            this.listBoxNarocila.SelectedIndexChanged += new System.EventHandler(this.listBoxNarocila_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aktivna naročila";
            // 
            // listViewPodrobnostiNarocila
            // 
            this.listViewPodrobnostiNarocila.HideSelection = false;
            this.listViewPodrobnostiNarocila.Location = new System.Drawing.Point(12, 149);
            this.listViewPodrobnostiNarocila.Name = "listViewPodrobnostiNarocila";
            this.listViewPodrobnostiNarocila.Size = new System.Drawing.Size(225, 97);
            this.listViewPodrobnostiNarocila.TabIndex = 2;
            this.listViewPodrobnostiNarocila.UseCompatibleStateImageBehavior = false;
            // 
            // lblNaslovDostava
            // 
            this.lblNaslovDostava.AutoSize = true;
            this.lblNaslovDostava.Location = new System.Drawing.Point(9, 267);
            this.lblNaslovDostava.Name = "lblNaslovDostava";
            this.lblNaslovDostava.Size = new System.Drawing.Size(44, 16);
            this.lblNaslovDostava.TabIndex = 3;
            this.lblNaslovDostava.Text = "label2";
            this.lblNaslovDostava.Visible = false;
            // 
            // buttonZakljuci
            // 
            this.buttonZakljuci.Location = new System.Drawing.Point(12, 307);
            this.buttonZakljuci.Name = "buttonZakljuci";
            this.buttonZakljuci.Size = new System.Drawing.Size(120, 33);
            this.buttonZakljuci.TabIndex = 4;
            this.buttonZakljuci.Text = "Zaključi naročilo";
            this.buttonZakljuci.UseVisualStyleBackColor = true;
            this.buttonZakljuci.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(610, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Dodaj zaposlenega";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Priimek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Funkcija";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Uporabniško ime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Geslo";
            // 
            // txtImeZap
            // 
            this.txtImeZap.Location = new System.Drawing.Point(41, 23);
            this.txtImeZap.Name = "txtImeZap";
            this.txtImeZap.Size = new System.Drawing.Size(100, 22);
            this.txtImeZap.TabIndex = 11;
            // 
            // grpBoxDodajZaposlenega
            // 
            this.grpBoxDodajZaposlenega.Controls.Add(this.button3);
            this.grpBoxDodajZaposlenega.Controls.Add(this.dropDownFunkcija);
            this.grpBoxDodajZaposlenega.Controls.Add(this.txtGeslo);
            this.grpBoxDodajZaposlenega.Controls.Add(this.txtUsername);
            this.grpBoxDodajZaposlenega.Controls.Add(this.txtPriimekZap);
            this.grpBoxDodajZaposlenega.Controls.Add(this.label2);
            this.grpBoxDodajZaposlenega.Controls.Add(this.txtImeZap);
            this.grpBoxDodajZaposlenega.Controls.Add(this.label3);
            this.grpBoxDodajZaposlenega.Controls.Add(this.label6);
            this.grpBoxDodajZaposlenega.Controls.Add(this.label4);
            this.grpBoxDodajZaposlenega.Controls.Add(this.label5);
            this.grpBoxDodajZaposlenega.Location = new System.Drawing.Point(540, 64);
            this.grpBoxDodajZaposlenega.Name = "grpBoxDodajZaposlenega";
            this.grpBoxDodajZaposlenega.Size = new System.Drawing.Size(237, 276);
            this.grpBoxDodajZaposlenega.TabIndex = 12;
            this.grpBoxDodajZaposlenega.TabStop = false;
            this.grpBoxDodajZaposlenega.Text = "groupBox1";
            this.grpBoxDodajZaposlenega.Visible = false;
            this.grpBoxDodajZaposlenega.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 31);
            this.button3.TabIndex = 13;
            this.button3.Text = "Potrdi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dropDownFunkcija
            // 
            this.dropDownFunkcija.FormattingEnabled = true;
            this.dropDownFunkcija.Items.AddRange(new object[] {
            "Kuhar",
            "Natakar",
            "Dostavljalec",
            "Študent"});
            this.dropDownFunkcija.Location = new System.Drawing.Point(70, 102);
            this.dropDownFunkcija.Name = "dropDownFunkcija";
            this.dropDownFunkcija.Size = new System.Drawing.Size(121, 24);
            this.dropDownFunkcija.TabIndex = 13;
            // 
            // txtGeslo
            // 
            this.txtGeslo.Location = new System.Drawing.Point(60, 182);
            this.txtGeslo.Name = "txtGeslo";
            this.txtGeslo.PasswordChar = '*';
            this.txtGeslo.Size = new System.Drawing.Size(110, 22);
            this.txtGeslo.TabIndex = 15;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(119, 144);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(112, 22);
            this.txtUsername.TabIndex = 14;
            // 
            // txtPriimekZap
            // 
            this.txtPriimekZap.Location = new System.Drawing.Point(60, 63);
            this.txtPriimekZap.Name = "txtPriimekZap";
            this.txtPriimekZap.Size = new System.Drawing.Size(100, 22);
            this.txtPriimekZap.TabIndex = 12;
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(703, 410);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(85, 28);
            this.btnOdjava.TabIndex = 13;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(666, 2);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(65, 16);
            this.lblWelcome.TabIndex = 14;
            this.lblWelcome.Text = "Welcome";
            // 
            // FormMainZaposleni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.grpBoxDodajZaposlenega);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonZakljuci);
            this.Controls.Add(this.lblNaslovDostava);
            this.Controls.Add(this.listViewPodrobnostiNarocila);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxNarocila);
            this.Name = "FormMainZaposleni";
            this.Text = "FormMainZaposleni";
            this.Load += new System.EventHandler(this.FormMainZaposleni_Load);
            this.grpBoxDodajZaposlenega.ResumeLayout(false);
            this.grpBoxDodajZaposlenega.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNarocila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewPodrobnostiNarocila;
        private System.Windows.Forms.Label lblNaslovDostava;
        private System.Windows.Forms.Button buttonZakljuci;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtImeZap;
        private System.Windows.Forms.GroupBox grpBoxDodajZaposlenega;
        private System.Windows.Forms.TextBox txtGeslo;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPriimekZap;
        private System.Windows.Forms.ComboBox dropDownFunkcija;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Label lblWelcome;
    }
}