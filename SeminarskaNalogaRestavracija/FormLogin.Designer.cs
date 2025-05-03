namespace SeminarskaNalogaRestavracija
{
    partial class FormLogin
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
            this.textBoxUserStranka = new System.Windows.Forms.TextBox();
            this.textBoxPassStranka = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblGeslo = new System.Windows.Forms.Label();
            this.btnLoginStranka = new System.Windows.Forms.Button();
            this.buttonGoToZaposleni = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.textBoxImeReg = new System.Windows.Forms.TextBox();
            this.lblImeReg = new System.Windows.Forms.Label();
            this.lblPriimekReg = new System.Windows.Forms.Label();
            this.textBoxPriimekReg = new System.Windows.Forms.TextBox();
            this.lblTelReg = new System.Windows.Forms.Label();
            this.lblMailReg = new System.Windows.Forms.Label();
            this.textBoxTelReg = new System.Windows.Forms.TextBox();
            this.textBoxMailReg = new System.Windows.Forms.TextBox();
            this.lblUserReg = new System.Windows.Forms.Label();
            this.lblGesloReg = new System.Windows.Forms.Label();
            this.textBoxUserReg = new System.Windows.Forms.TextBox();
            this.textBoxGesloReg = new System.Windows.Forms.TextBox();
            this.btnRegConfirm = new System.Windows.Forms.Button();
            this.btnPrijavaGo = new System.Windows.Forms.Button();
            this.groupBoxReg = new System.Windows.Forms.GroupBox();
            this.lblnaslov = new System.Windows.Forms.Label();
            this.textBoxNaslovReg = new System.Windows.Forms.TextBox();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.groupBoxReg.SuspendLayout();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUserStranka
            // 
            this.textBoxUserStranka.Location = new System.Drawing.Point(131, 11);
            this.textBoxUserStranka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUserStranka.Name = "textBoxUserStranka";
            this.textBoxUserStranka.Size = new System.Drawing.Size(191, 22);
            this.textBoxUserStranka.TabIndex = 0;
            // 
            // textBoxPassStranka
            // 
            this.textBoxPassStranka.Location = new System.Drawing.Point(61, 46);
            this.textBoxPassStranka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassStranka.Name = "textBoxPassStranka";
            this.textBoxPassStranka.PasswordChar = '*';
            this.textBoxPassStranka.Size = new System.Drawing.Size(191, 22);
            this.textBoxPassStranka.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(7, 20);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(113, 16);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Uporabniško ime:";
            // 
            // lblGeslo
            // 
            this.lblGeslo.AutoSize = true;
            this.lblGeslo.Location = new System.Drawing.Point(7, 49);
            this.lblGeslo.Name = "lblGeslo";
            this.lblGeslo.Size = new System.Drawing.Size(46, 16);
            this.lblGeslo.TabIndex = 3;
            this.lblGeslo.Text = "Geslo:";
            // 
            // btnLoginStranka
            // 
            this.btnLoginStranka.Location = new System.Drawing.Point(7, 79);
            this.btnLoginStranka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoginStranka.Name = "btnLoginStranka";
            this.btnLoginStranka.Size = new System.Drawing.Size(76, 38);
            this.btnLoginStranka.TabIndex = 4;
            this.btnLoginStranka.Text = "Prijava";
            this.btnLoginStranka.UseVisualStyleBackColor = true;
            this.btnLoginStranka.Click += new System.EventHandler(this.btnLoginStranka_Click);
            this.btnLoginStranka.Enter += new System.EventHandler(this.btnLoginStranka_Click);
            // 
            // buttonGoToZaposleni
            // 
            this.buttonGoToZaposleni.Location = new System.Drawing.Point(696, 12);
            this.buttonGoToZaposleni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGoToZaposleni.Name = "buttonGoToZaposleni";
            this.buttonGoToZaposleni.Size = new System.Drawing.Size(121, 42);
            this.buttonGoToZaposleni.TabIndex = 5;
            this.buttonGoToZaposleni.Text = "Prijava zaposlenega";
            this.buttonGoToZaposleni.UseVisualStyleBackColor = true;
            this.buttonGoToZaposleni.Click += new System.EventHandler(this.buttonGoToZaposleni_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(88, 79);
            this.btnReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(121, 38);
            this.btnReg.TabIndex = 6;
            this.btnReg.Text = "Registracija";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click_1);
            // 
            // textBoxImeReg
            // 
            this.textBoxImeReg.Location = new System.Drawing.Point(48, 18);
            this.textBoxImeReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxImeReg.Name = "textBoxImeReg";
            this.textBoxImeReg.Size = new System.Drawing.Size(121, 22);
            this.textBoxImeReg.TabIndex = 7;
            // 
            // lblImeReg
            // 
            this.lblImeReg.AutoSize = true;
            this.lblImeReg.Location = new System.Drawing.Point(7, 27);
            this.lblImeReg.Name = "lblImeReg";
            this.lblImeReg.Size = new System.Drawing.Size(32, 16);
            this.lblImeReg.TabIndex = 8;
            this.lblImeReg.Text = "Ime:";
            // 
            // lblPriimekReg
            // 
            this.lblPriimekReg.AutoSize = true;
            this.lblPriimekReg.Location = new System.Drawing.Point(7, 62);
            this.lblPriimekReg.Name = "lblPriimekReg";
            this.lblPriimekReg.Size = new System.Drawing.Size(55, 16);
            this.lblPriimekReg.TabIndex = 9;
            this.lblPriimekReg.Text = "Priimek:";
            // 
            // textBoxPriimekReg
            // 
            this.textBoxPriimekReg.Location = new System.Drawing.Point(71, 55);
            this.textBoxPriimekReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPriimekReg.Name = "textBoxPriimekReg";
            this.textBoxPriimekReg.Size = new System.Drawing.Size(121, 22);
            this.textBoxPriimekReg.TabIndex = 10;
            // 
            // lblTelReg
            // 
            this.lblTelReg.AutoSize = true;
            this.lblTelReg.Location = new System.Drawing.Point(7, 102);
            this.lblTelReg.Name = "lblTelReg";
            this.lblTelReg.Size = new System.Drawing.Size(56, 16);
            this.lblTelReg.TabIndex = 11;
            this.lblTelReg.Text = "Telefon:";
            // 
            // lblMailReg
            // 
            this.lblMailReg.AutoSize = true;
            this.lblMailReg.Location = new System.Drawing.Point(7, 137);
            this.lblMailReg.Name = "lblMailReg";
            this.lblMailReg.Size = new System.Drawing.Size(57, 16);
            this.lblMailReg.TabIndex = 12;
            this.lblMailReg.Text = "E-pošta:";
            // 
            // textBoxTelReg
            // 
            this.textBoxTelReg.Location = new System.Drawing.Point(73, 98);
            this.textBoxTelReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTelReg.Name = "textBoxTelReg";
            this.textBoxTelReg.Size = new System.Drawing.Size(121, 22);
            this.textBoxTelReg.TabIndex = 13;
            // 
            // textBoxMailReg
            // 
            this.textBoxMailReg.Location = new System.Drawing.Point(73, 133);
            this.textBoxMailReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMailReg.Name = "textBoxMailReg";
            this.textBoxMailReg.Size = new System.Drawing.Size(121, 22);
            this.textBoxMailReg.TabIndex = 14;
            // 
            // lblUserReg
            // 
            this.lblUserReg.AutoSize = true;
            this.lblUserReg.Location = new System.Drawing.Point(7, 202);
            this.lblUserReg.Name = "lblUserReg";
            this.lblUserReg.Size = new System.Drawing.Size(113, 16);
            this.lblUserReg.TabIndex = 15;
            this.lblUserReg.Text = "Uporabniško ime:";
            // 
            // lblGesloReg
            // 
            this.lblGesloReg.AutoSize = true;
            this.lblGesloReg.Location = new System.Drawing.Point(7, 240);
            this.lblGesloReg.Name = "lblGesloReg";
            this.lblGesloReg.Size = new System.Drawing.Size(46, 16);
            this.lblGesloReg.TabIndex = 16;
            this.lblGesloReg.Text = "Geslo:";
            // 
            // textBoxUserReg
            // 
            this.textBoxUserReg.Location = new System.Drawing.Point(131, 193);
            this.textBoxUserReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUserReg.Name = "textBoxUserReg";
            this.textBoxUserReg.Size = new System.Drawing.Size(121, 22);
            this.textBoxUserReg.TabIndex = 17;
            // 
            // textBoxGesloReg
            // 
            this.textBoxGesloReg.Location = new System.Drawing.Point(61, 231);
            this.textBoxGesloReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGesloReg.Name = "textBoxGesloReg";
            this.textBoxGesloReg.PasswordChar = '*';
            this.textBoxGesloReg.Size = new System.Drawing.Size(121, 22);
            this.textBoxGesloReg.TabIndex = 18;
            // 
            // btnRegConfirm
            // 
            this.btnRegConfirm.Location = new System.Drawing.Point(11, 302);
            this.btnRegConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegConfirm.Name = "btnRegConfirm";
            this.btnRegConfirm.Size = new System.Drawing.Size(109, 38);
            this.btnRegConfirm.TabIndex = 19;
            this.btnRegConfirm.Text = "Registracija";
            this.btnRegConfirm.UseVisualStyleBackColor = true;
            this.btnRegConfirm.Click += new System.EventHandler(this.btnRegConfirm_Click);
            this.btnRegConfirm.Enter += new System.EventHandler(this.btnRegConfirm_Click);
            // 
            // btnPrijavaGo
            // 
            this.btnPrijavaGo.Location = new System.Drawing.Point(131, 302);
            this.btnPrijavaGo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrijavaGo.Name = "btnPrijavaGo";
            this.btnPrijavaGo.Size = new System.Drawing.Size(88, 38);
            this.btnPrijavaGo.TabIndex = 20;
            this.btnPrijavaGo.Text = "Prijava";
            this.btnPrijavaGo.UseVisualStyleBackColor = true;
            this.btnPrijavaGo.Click += new System.EventHandler(this.btnPrijavaGo_Click);
            // 
            // groupBoxReg
            // 
            this.groupBoxReg.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxReg.Controls.Add(this.lblnaslov);
            this.groupBoxReg.Controls.Add(this.textBoxNaslovReg);
            this.groupBoxReg.Controls.Add(this.lblImeReg);
            this.groupBoxReg.Controls.Add(this.textBoxImeReg);
            this.groupBoxReg.Controls.Add(this.btnPrijavaGo);
            this.groupBoxReg.Controls.Add(this.lblPriimekReg);
            this.groupBoxReg.Controls.Add(this.btnRegConfirm);
            this.groupBoxReg.Controls.Add(this.textBoxGesloReg);
            this.groupBoxReg.Controls.Add(this.textBoxPriimekReg);
            this.groupBoxReg.Controls.Add(this.lblGesloReg);
            this.groupBoxReg.Controls.Add(this.textBoxUserReg);
            this.groupBoxReg.Controls.Add(this.lblTelReg);
            this.groupBoxReg.Controls.Add(this.textBoxTelReg);
            this.groupBoxReg.Controls.Add(this.lblUserReg);
            this.groupBoxReg.Controls.Add(this.lblMailReg);
            this.groupBoxReg.Controls.Add(this.textBoxMailReg);
            this.groupBoxReg.Location = new System.Drawing.Point(423, 12);
            this.groupBoxReg.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxReg.Name = "groupBoxReg";
            this.groupBoxReg.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxReg.Size = new System.Drawing.Size(267, 361);
            this.groupBoxReg.TabIndex = 21;
            this.groupBoxReg.TabStop = false;
            this.groupBoxReg.Text = "groupBox1";
            // 
            // lblnaslov
            // 
            this.lblnaslov.AutoSize = true;
            this.lblnaslov.Location = new System.Drawing.Point(7, 166);
            this.lblnaslov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnaslov.Name = "lblnaslov";
            this.lblnaslov.Size = new System.Drawing.Size(50, 16);
            this.lblnaslov.TabIndex = 22;
            this.lblnaslov.Text = "Naslov";
            // 
            // textBoxNaslovReg
            // 
            this.textBoxNaslovReg.Location = new System.Drawing.Point(73, 162);
            this.textBoxNaslovReg.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNaslovReg.Name = "textBoxNaslovReg";
            this.textBoxNaslovReg.Size = new System.Drawing.Size(132, 22);
            this.textBoxNaslovReg.TabIndex = 15;
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.lblUser);
            this.groupBoxLogin.Controls.Add(this.textBoxUserStranka);
            this.groupBoxLogin.Controls.Add(this.lblGeslo);
            this.groupBoxLogin.Controls.Add(this.textBoxPassStranka);
            this.groupBoxLogin.Controls.Add(this.btnReg);
            this.groupBoxLogin.Controls.Add(this.btnLoginStranka);
            this.groupBoxLogin.Location = new System.Drawing.Point(16, 12);
            this.groupBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxLogin.Size = new System.Drawing.Size(341, 123);
            this.groupBoxLogin.TabIndex = 22;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "groupBox2";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 437);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.groupBoxReg);
            this.Controls.Add(this.buttonGoToZaposleni);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLogin";
            this.Text = "Restavracija";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxReg.ResumeLayout(false);
            this.groupBoxReg.PerformLayout();
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserStranka;
        private System.Windows.Forms.TextBox textBoxPassStranka;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblGeslo;
        private System.Windows.Forms.Button btnLoginStranka;
        private System.Windows.Forms.Button buttonGoToZaposleni;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox textBoxImeReg;
        private System.Windows.Forms.Label lblImeReg;
        private System.Windows.Forms.Label lblPriimekReg;
        private System.Windows.Forms.TextBox textBoxPriimekReg;
        private System.Windows.Forms.Label lblTelReg;
        private System.Windows.Forms.Label lblMailReg;
        private System.Windows.Forms.TextBox textBoxTelReg;
        private System.Windows.Forms.TextBox textBoxMailReg;
        private System.Windows.Forms.Label lblUserReg;
        private System.Windows.Forms.Label lblGesloReg;
        private System.Windows.Forms.TextBox textBoxUserReg;
        private System.Windows.Forms.TextBox textBoxGesloReg;
        private System.Windows.Forms.Button btnRegConfirm;
        private System.Windows.Forms.Button btnPrijavaGo;
        private System.Windows.Forms.GroupBox groupBoxReg;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Label lblnaslov;
        private System.Windows.Forms.TextBox textBoxNaslovReg;
    }
}

