using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Management.Instrumentation;
using System.Security.Cryptography;
using RestavracijaClasses;

namespace SeminarskaNalogaRestavracija
{
    public partial class FormLogin : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["RestavracijaConnectionString"].ConnectionString;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLoginStranka_Click(object sender, EventArgs e)
        {
            if (!TextBoxCheck(groupBoxLogin))
            {
                MessageBox.Show("Vsa polja morajo biti izpolnjena.");
                return;
            }
            else
            {


                string user = textBoxUserStranka.Text;
                string pass = textBoxPassStranka.Text;
                string hashedPass = HashPassword(pass);

                string query = "SELECT * FROM Stranke WHERE username = @user AND password = @pass";
                using (var db = new SqlConnection(connectionString))
                {
                    try
                    {
                        db.Open();
                        using (var cmd = new SqlCommand(query, db))
                        {
                            cmd.Parameters.AddWithValue("@user", user);
                            cmd.Parameters.AddWithValue("@pass", hashedPass);

                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    reader.Read();
                                    string ime = reader["ime"].ToString();
                                    string idStranke = reader["id_stranke"].ToString();
                                    LoggedInUser.Username = user;
                                    LoggedInUser.Ime = ime;
                                    LoggedInUser.IdStranke = idStranke;

                                    MessageBox.Show("Prijava uspešna!");
                                    FormMainStranka fMain = new FormMainStranka();
                                    fMain.FormClosed += (s, args) => this.Close();
                                    this.Hide();
                                    fMain.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Uporabniško ime ali geslo je napačno.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.logError(ex);
                        MessageBox.Show($"Prišlo je do napake. Prosimo poskusite kasneje.");
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            groupBoxReg.Visible = false;
            this.AcceptButton = btnLoginStranka;
        }

        private void btnPrijavaGo_Click(object sender, EventArgs e)
        {
            this.AcceptButton = btnLoginStranka;
            groupBoxLogin.Visible = true;
            groupBoxReg.Visible = false;
            foreach(Control ctrl in groupBoxLogin.Controls)
            {
                if (ctrl is TextBox) ctrl.Text = string.Empty;
            }
        }

        private void btnReg_Click_1(object sender, EventArgs e)
        {
            this.AcceptButton = btnRegConfirm;
            groupBoxReg.Visible = true;
            groupBoxLogin.Visible = false;
            foreach (Control ctrl in groupBoxReg.Controls)
            {
                if (ctrl is TextBox) ctrl.Text = string.Empty;
            }
        }
        private string HashPassword(string pass)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(pass);
                var hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
        private bool TextBoxCheck(GroupBox grpBox)
        {
            foreach (Control ctrl in grpBox.Controls)
            {
                if (ctrl is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return false;
                }
            }
            return true;
        }
        private void btnRegConfirm_Click(object sender, EventArgs e)
        {
            
            string ime = textBoxImeReg.Text;
            string priimek = textBoxPriimekReg.Text;
            string naslov = textBoxNaslovReg.Text;
            string telefon = textBoxTelReg.Text;
            string email = textBoxMailReg.Text;
            string user = textBoxUserReg.Text;
            string pass = HashPassword(textBoxGesloReg.Text);

            using (var db = new SqlConnection(connectionString))
            {
                if (!TextBoxCheck(groupBoxReg))
                {
                    MessageBox.Show("Vsa polja morajo biti izpolnjena.");
                }
                else
                {
                    try
                    {
                        db.Open();
                        string checkUserQuery = "SELECT COUNT(*) FROM Stranke WHERE username = @user";
                        string insertQuery = "INSERT INTO Stranke (ime, priimek, naslov, telefon, email, username, password) VALUES (@ime, @priimek, @naslov, @telefon, @email, @user, @pass)";

                        using (var CheckCmd = new SqlCommand(checkUserQuery, db))
                        {
                            CheckCmd.Parameters.AddWithValue("@ime", ime);
                            CheckCmd.Parameters.AddWithValue("@priimek", priimek);
                            CheckCmd.Parameters.AddWithValue("@naslov", naslov);
                            CheckCmd.Parameters.AddWithValue("@telefon", telefon);
                            CheckCmd.Parameters.AddWithValue("@email", email);
                            CheckCmd.Parameters.AddWithValue("@user", user);
                            CheckCmd.Parameters.AddWithValue("@pass", pass);

                            int userCount = (int)(CheckCmd.ExecuteScalar());

                            if (userCount > 0)
                            {
                                MessageBox.Show("Uporabniško ime že obstaja. Prosimo izberite drugega.");
                                return;
                            }
                        }
                        using (var insertCmd = new SqlCommand(insertQuery, db))
                        {
                            insertCmd.Parameters.AddWithValue("@ime", ime);
                            insertCmd.Parameters.AddWithValue("@priimek", priimek);
                            insertCmd.Parameters.AddWithValue("@naslov", naslov);
                            insertCmd.Parameters.AddWithValue("@telefon", telefon);
                            insertCmd.Parameters.AddWithValue("@email", email);
                            insertCmd.Parameters.AddWithValue("@user", user);
                            insertCmd.Parameters.AddWithValue("@pass", pass);
                            int rowsAffected = insertCmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Registracija uspešna!");
                                groupBoxReg.Visible = false;
                                groupBoxLogin.Visible = true;
                                return;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.logError(ex);
                        MessageBox.Show($"Prišlo je do napake, prosimo poskusite kasneje.");
                    }
                }
            }
        }

        private void buttonGoToZaposleni_Click(object sender, EventArgs e)
        {
            FormLoginZaposleni formLoginZaposleni = new FormLoginZaposleni();
            formLoginZaposleni.FormClosed += (s, args) => this.Close();
            this.Hide();
            formLoginZaposleni.Show();
        }
    }
}
