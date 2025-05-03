using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestavracijaClasses;

namespace SeminarskaNalogaRestavracija
{
    public partial class FormLoginZaposleni : Form
    {   
        string connectionString = ConfigurationManager.ConnectionStrings["RestavracijaConnectionString"].ConnectionString;

        public FormLoginZaposleni()
        {
            InitializeComponent();
        }

        private void btnLoginZaposleni_Click(object sender, EventArgs e)
        {
            string user = textBoxUserZaposleni.Text;
            string pass = textBoxPassZaposleni.Text;
            string hashedPass = HashPassword(pass);
            string query = "SELECT * FROM Zaposleni WHERE username = @user AND password = @pass";

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
                                string idZaposlenega = reader["id_zaposlenega"].ToString();
                                LoggedInUser.Username = user;
                                LoggedInUser.Ime = ime;
                                LoggedInUser.IdZaposleni = idZaposlenega;
                                FormMainZaposleni fMainZap = new FormMainZaposleni();
                                fMainZap.FormClosed += (s, args) => this.Close();
                                this.Hide();
                                fMainZap.Show();
                            }
                            else
                            {
                                MessageBox.Show("Uporabniško ime ali geslo je napačno.");
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Log.logError(ex);
                    MessageBox.Show("Napaka pri povezavi z bazo podatkov: " + ex.Message);
                }
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

        private void FormLoginZaposleni_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLoginZaposleni;
        }
    }
}
