using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestavracijaClasses;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SeminarskaNalogaRestavracija
{
    public partial class FormMainStranka : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["RestavracijaConnectionString"].ConnectionString;

        public FormMainStranka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dropDownNacin.Text))
            {
                MessageBox.Show("Izberite način dostave!");
                return;
            }
            Dictionary<string, decimal> Narocilo = NarociloPodrobnosti();
            bool isEmpty = true;
            foreach (var item in Narocilo)
            {
                if (item.Value > 0)
                {
                    isEmpty = false;
                    break;
                }
            }
            if (isEmpty)
            {
                MessageBox.Show("Naročilo ne more biti prazno!");
                return;
            }
            else
            { 
                using (var db = new SqlConnection(connectionString))
                {
                    try
                    {
                        db.Open();
                        string insertOrderQuery = "INSERT INTO Narocila (id_stranke, datum_ura, nacin_dostave, skupna_cena) " +
                                                   "OUTPUT INSERTED.id_narocila " +
                                                   "VALUES (@id_stranke, @datum_ura, @nacin_dostave, @skupna_cena)";
                        int idNarocila;
                        using (var cmd = new SqlCommand(insertOrderQuery, db))
                        {
                            cmd.Parameters.AddWithValue("@id_stranke", LoggedInUser.IdStranke);
                            cmd.Parameters.AddWithValue("@datum_ura", DateTime.Now);
                            cmd.Parameters.AddWithValue("@nacin_dostave", dropDownNacin.Text);
                            cmd.Parameters.AddWithValue("@skupna_cena", 0);

                            idNarocila = (int)cmd.ExecuteScalar();
                        }

                        decimal skupnaCena = 0;
                        foreach (var item in Narocilo)
                        {
                            if (item.Value > 0)
                            {
                                string getPriceQuery = "SELECT cena FROM Jedi WHERE ime = @ime";
                                decimal cena;
                                using (var cmd = new SqlCommand(getPriceQuery, db))
                                {
                                    cmd.Parameters.AddWithValue("@ime", item.Key);
                                    cena = (decimal)cmd.ExecuteScalar();
                                }

                                decimal skupnaCenaJedi = cena * item.Value;
                                skupnaCena += skupnaCenaJedi;

                                string insertOrderDishQuery = "INSERT INTO Narocila_jedi (id_narocila, id_jedi, kolicina, skupna_cena) " +
                                                              "VALUES (@id_narocila, (SELECT id_jedi FROM Jedi WHERE ime = @ime), @kolicina, @skupna_cena)";
                                using (var cmd = new SqlCommand(insertOrderDishQuery, db))
                                {
                                    cmd.Parameters.AddWithValue("@id_narocila", idNarocila);
                                    cmd.Parameters.AddWithValue("@ime", item.Key);
                                    cmd.Parameters.AddWithValue("@kolicina", item.Value);
                                    cmd.Parameters.AddWithValue("@skupna_cena", skupnaCenaJedi);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                        string updateOrderQuery = "UPDATE Narocila SET skupna_cena = @skupna_cena WHERE id_narocila = @id_narocila";
                        using (var cmd = new SqlCommand(updateOrderQuery, db))
                        {
                            cmd.Parameters.AddWithValue("@skupna_cena", skupnaCena);
                            cmd.Parameters.AddWithValue("@id_narocila", idNarocila);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Naročilo je bilo uspešno oddano!");
                        btnCheckOrder.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka pri oddaji naročila: " + ex.Message);
                    }
                }
            }

        }
        private Dictionary<string, decimal> NarociloPodrobnosti()
        {
            return new Dictionary<string, decimal>
            {
                {"Margerita", numMargerita.Value},
                {"Klasika", numKlasika.Value},
                {"Kmečka", numKmecka.Value},
                {"Kraška", numKraska.Value},
                {"Tuna", numTuna.Value},
                {"Kebab", numKebab.Value},
                {"Ocvrti Lignji", numOcvLig.Value},
                {"Lignji z žara", numZarLig.Value},
                {"Mesna plošča", numMesna.Value}
            };
        }
        private void button2_Click(object sender, EventArgs e)
        {
            decimal skupnaCena = 0;
            Dictionary<string, decimal> Narocilo = new Dictionary<string, decimal>
            {
                {"Margerita", numMargerita.Value},
                {"Klasika", numKlasika.Value},
                {"Kmečka", numKmecka.Value},
                {"Kraška", numKraska.Value},
                {"Tuna", numTuna.Value},
                {"Kebab", numKebab.Value},
                {"Ocvrti Lignji", numOcvLig.Value },
                {"Lignji z žara", numZarLig.Value },
                {"Mesna plošča", numMesna.Value }
            };
            using (var db = new SqlConnection(connectionString))
            {
                try
                {
                    db.Open();
                    foreach (var item in Narocilo)
                    {
                        string query = "SELECT cena FROM jedi WHERE ime = @ime";
                        using (var cmd = new SqlCommand(query, db))
                        {
                            cmd.Parameters.AddWithValue("@ime", item.Key);
                            using(var reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    decimal cena = reader.GetDecimal(0);
                                    skupnaCena += cena * item.Value;
                                }
                            }
                        }
                    }
                    lblCena.Text = skupnaCena.ToString() + "€";

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Napaka pri povezavi z bazo podatkov: " + ex.Message);
                }
            }
        }

        private void FormMainStranka_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LoggedInUser.IdStranke))
            {
                MessageBox.Show("Napaka: uporabnik ni prijavljen.");
                return;
            }
            else
            {
                lblUserStranka.Text = $"Dobrodošli {LoggedInUser.Username}";
            }
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void btnCheckOrder_Click(object sender, EventArgs e)
        {
            listViewNarocilo.Items.Clear();
            string loggedInUser = LoggedInUser.Username;
            string id_stranke = LoggedInUser.IdStranke;
            string query = "SELECT n.id_stranke, j.ime, nj.kolicina, n.status " +
                            "FROM Narocila n JOIN Narocila_jedi nj ON n.id_narocila = nj.id_narocila " +
                            "JOIN Jedi j ON j.id_jedi = nj.id_jedi " +
                            "WHERE n.id_stranke = @id_stranke AND n.status = 'Aktivno'";

            using (var db = new SqlConnection(connectionString))
            {
                try
                {
                    db.Open();
                    using (var cmd = new SqlCommand(query, db))
                    {
                        cmd.Parameters.AddWithValue("@id_stranke", id_stranke);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string ime = reader["ime"].ToString();
                                string kolicina = reader["kolicina"].ToString();
                                listViewNarocilo.Items.Add(ime);
                                listViewNarocilo.Items.Add($"{kolicina}x");
                            }
                            lblStatus.Visible = true;
                            lblStatus.Text = "V obdelavi";
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Napaka pri povezavi z bazo podatkov: " + ex.Message);
                }
            }
        }
    }

}
