namespace SeminarskaNalogaRestavracija
{
    partial class FormLoginZaposleni
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
            this.groupBoxLoginZaposleni = new System.Windows.Forms.GroupBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.textBoxUserZaposleni = new System.Windows.Forms.TextBox();
            this.lblGeslo = new System.Windows.Forms.Label();
            this.textBoxPassZaposleni = new System.Windows.Forms.TextBox();
            this.btnLoginZaposleni = new System.Windows.Forms.Button();
            this.groupBoxLoginZaposleni.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLoginZaposleni
            // 
            this.groupBoxLoginZaposleni.Controls.Add(this.lblUser);
            this.groupBoxLoginZaposleni.Controls.Add(this.textBoxUserZaposleni);
            this.groupBoxLoginZaposleni.Controls.Add(this.lblGeslo);
            this.groupBoxLoginZaposleni.Controls.Add(this.textBoxPassZaposleni);
            this.groupBoxLoginZaposleni.Controls.Add(this.btnLoginZaposleni);
            this.groupBoxLoginZaposleni.Location = new System.Drawing.Point(13, 13);
            this.groupBoxLoginZaposleni.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxLoginZaposleni.Name = "groupBoxLoginZaposleni";
            this.groupBoxLoginZaposleni.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxLoginZaposleni.Size = new System.Drawing.Size(341, 123);
            this.groupBoxLoginZaposleni.TabIndex = 23;
            this.groupBoxLoginZaposleni.TabStop = false;
            this.groupBoxLoginZaposleni.Text = "groupBox2";
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
            // textBoxUserZaposleni
            // 
            this.textBoxUserZaposleni.Location = new System.Drawing.Point(131, 11);
            this.textBoxUserZaposleni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUserZaposleni.Name = "textBoxUserZaposleni";
            this.textBoxUserZaposleni.Size = new System.Drawing.Size(191, 22);
            this.textBoxUserZaposleni.TabIndex = 0;
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
            // textBoxPassZaposleni
            // 
            this.textBoxPassZaposleni.Location = new System.Drawing.Point(61, 46);
            this.textBoxPassZaposleni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassZaposleni.Name = "textBoxPassZaposleni";
            this.textBoxPassZaposleni.PasswordChar = '*';
            this.textBoxPassZaposleni.Size = new System.Drawing.Size(191, 22);
            this.textBoxPassZaposleni.TabIndex = 1;
            // 
            // btnLoginZaposleni
            // 
            this.btnLoginZaposleni.Location = new System.Drawing.Point(7, 79);
            this.btnLoginZaposleni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoginZaposleni.Name = "btnLoginZaposleni";
            this.btnLoginZaposleni.Size = new System.Drawing.Size(76, 38);
            this.btnLoginZaposleni.TabIndex = 4;
            this.btnLoginZaposleni.Text = "Prijava";
            this.btnLoginZaposleni.UseVisualStyleBackColor = true;
            this.btnLoginZaposleni.Click += new System.EventHandler(this.btnLoginZaposleni_Click);
            // 
            // FormLoginZaposleni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxLoginZaposleni);
            this.Name = "FormLoginZaposleni";
            this.Text = "FormLoginZaposleni";
            this.Load += new System.EventHandler(this.FormLoginZaposleni_Load);
            this.groupBoxLoginZaposleni.ResumeLayout(false);
            this.groupBoxLoginZaposleni.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLoginZaposleni;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox textBoxUserZaposleni;
        private System.Windows.Forms.Label lblGeslo;
        private System.Windows.Forms.TextBox textBoxPassZaposleni;
        private System.Windows.Forms.Button btnLoginZaposleni;
    }
}