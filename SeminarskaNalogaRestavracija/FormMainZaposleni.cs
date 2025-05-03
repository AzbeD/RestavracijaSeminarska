using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestavracijaClasses;

namespace SeminarskaNalogaRestavracija
{
    public partial class FormMainZaposleni : Form
    {
        public FormMainZaposleni()
        {
            InitializeComponent();
        }
        string connectionString = ConfigurationManager.ConnectionStrings["RestavracijaConnectionString"].ConnectionString;
        private Dictionary<int, string> ordersView = new Dictionary<int, string>();
        private void FormMainZaposleni_Load(object sender, EventArgs e)
        {
            string ime = LoggedInUser.Ime;
            if (ime != "admin")
            {
                lblWelcome.Text = $"Pozdravljen {ime}!";
            }
            else lblWelcome.Visible = false;
            if (listBoxNarocila.Items.Count < 1)
            {
                buttonZakljuci.Enabled = false;
            }
            string loggedInUser = LoggedInUser.Username;
            using (var db = new SqlConnection(connectionString))
            {
                try
                {
                    db.Open();
                    string query = "SELECT * FROM Narocila WHERE status = 'Aktivno'";
                    using (var cmd = new SqlCommand(query, db))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idNarocila = (int)reader["id_narocila"];
                                string nacinDostave = reader["nacin_dostave"].ToString();
                                string datum_ura = reader["datum_ura"].ToString();

                                string listItem = $"Naročilo {idNarocila}: {nacinDostave}, {datum_ura}";
                                listBoxNarocila.Items.Add(listItem);
                                ordersView[listBoxNarocila.Items.Count - 1] = idNarocila.ToString();
                            }
                        }
                    }
                }
                catch(Exception ex)
                { 
                    MessageBox.Show("Napaka pri povezavi z bazo podatkov.");
                    Log.logError(ex);
                }
            }   
            if(LoggedInUser.Username == "admin")
            {
                button2.Visible = true;
            }
        }

        private void listBoxNarocila_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonZakljuci.Enabled = true;
            int selectedIndex = listBoxNarocila.SelectedIndex;
            if (!ordersView.TryGetValue(selectedIndex, out string idNarocila)) return;

            using (var db = new SqlConnection(connectionString)) 
            {
                try
                {
                    db.Open();
                    string query = "SELECT j.ime, nj.kolicina, nj.skupna_cena, s.naslov, n.nacin_dostave " +
                                    "FROM Narocila_jedi nj JOIN Jedi j ON nj.id_jedi = j.id_jedi "+
                                    "JOIN Narocila n ON nj.id_narocila = n.id_narocila "+
                                    "JOIN Stranke s ON n.id_stranke = s.id_stranke "+
                                    "WHERE nj.id_narocila = @id_narocila";
                    using(var cmd = new SqlCommand(query, db))
                    {
                        cmd.Parameters.AddWithValue("@id_narocila", idNarocila);
                        using (var reader = cmd.ExecuteReader())
                        {
                            listViewPodrobnostiNarocila.Items.Clear();
                            while (reader.Read())
                            {
                                string imeJedi = reader["ime"].ToString();
                                string kolicina = reader["kolicina"].ToString();
                                decimal cena = (decimal)reader["skupna_cena"];
                                string naslov = reader["naslov"].ToString();
                                string nacinDostave = reader["nacin_dostave"].ToString();
                                listViewPodrobnostiNarocila.Items.Add(imeJedi);
                                listViewPodrobnostiNarocila.Items.Add(kolicina);
                                listViewPodrobnostiNarocila.Items.Add($"{cena} €");
                                if (nacinDostave == "Dostava")
                                {
                                    lblNaslovDostava.Visible = true;
                                    lblNaslovDostava.Text = $"Naslov dostave: {naslov}";
                                }
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    Log.logError(ex);
                    MessageBox.Show("Napaka pri pridobivanju podrobnosti naročila.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Želite zaključiti naročilo?", "Zaključi naročilo", MessageBoxButtons.YesNo);

            if(confirmResult == DialogResult.Yes)
            {
                int selectedIndex = listBoxNarocila.SelectedIndex;
                if (!ordersView.TryGetValue(selectedIndex, out string idNarocila)) return;

                using (var db = new SqlConnection(connectionString))
                {
                    try
                    {
                        db.Open();
                        string query = "UPDATE Narocila SET status = 'Obdelano' WHERE id_narocila = @id_narocila";
                        using (var cmd = new SqlCommand(query, db))
                        {
                            cmd.Parameters.AddWithValue("@id_narocila", idNarocila);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if(rowsAffected > 0)
                            {
                                MessageBox.Show("Naročilo je bilo uspešno zaključeno");
                                listBoxNarocila.Items.RemoveAt(selectedIndex);
                                listViewPodrobnostiNarocila.Items.Clear();
                                lblNaslovDostava.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("Napaka pri zaključevanju naročila.");
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        Log.logError(ex);
                        MessageBox.Show($"Napaka pri zaključevanju naročila.");
                    }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            grpBoxDodajZaposlenega.Visible = true;

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ime = txtImeZap.Text;
            string priimek = txtPriimekZap.Text;
            string funkcija = dropDownFunkcija.Text;
            string username = txtUsername.Text;
            string password = txtGeslo.Text;
            string passwordHash = HashPassword(password);

            string checkUserQuery = "SELECT COUNT(*) FROM Zaposleni WHERE username = @user";
            string insertQuery = "INSERT INTO Zaposleni (ime, priimek, funkcija, username, password)" +
                                 "VALUES(@ime, @priimek, @funkcija, @username, @password)";

            using (var db = new SqlConnection(connectionString))
            {
                try
                {
                    db.Open();
                    using (var CheckCmd = new SqlCommand(checkUserQuery, db))
                    {
                        CheckCmd.Parameters.AddWithValue("@ime", ime);
                        CheckCmd.Parameters.AddWithValue("@priimek", priimek);
                        CheckCmd.Parameters.AddWithValue("@funkcija", funkcija);
                        CheckCmd.Parameters.AddWithValue("@password", passwordHash);
                        CheckCmd.Parameters.AddWithValue("@user", username);

                        int userCount = (int)CheckCmd.ExecuteScalar();
                        if(userCount > 0)
                        {
                            MessageBox.Show("Uporabniško ime že obstaja. Prosimo izberite drugo.");
                            return;
                        }
                    }
                    using(var insertCmd = new SqlCommand(insertQuery, db))
                    {
                        insertCmd.Parameters.AddWithValue("@ime", ime);
                        insertCmd.Parameters.AddWithValue("@priimek", priimek);
                        insertCmd.Parameters.AddWithValue("@funkcija", funkcija);
                        insertCmd.Parameters.AddWithValue("@username", username);
                        insertCmd.Parameters.AddWithValue("@password", passwordHash);

                        int rowsAffected = insertCmd.ExecuteNonQuery();
                        if(rowsAffected > 0)
                        {
                            MessageBox.Show("Uspešno dodan zaposleni!");
                            grpBoxDodajZaposlenega.Visible = false;
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Napaka pri dodajanju zaposlenega.");
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Log.logError(ex);
                    MessageBox.Show($"Napaka pri dodajanju zaposlenega: {ex.Message}");
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

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            var ConfirmResult = MessageBox.Show("Ali ste prepričani,da se želite odjaviti?", "Potrditev odjave", MessageBoxButtons.YesNo);

            if (ConfirmResult == DialogResult.Yes)
            {
                LoggedInUser.Username = null;
                LoggedInUser.Ime = null;
                LoggedInUser.Priimek = null;
                LoggedInUser.IdStranke = null;
                LoggedInUser.IdZaposleni = null;
                FormLogin formLogin = new FormLogin();
                formLogin.FormClosed += (s, args) => this.Close();
                this.Hide();
                formLogin.Show();
            }
            else return;
        }
    }
}