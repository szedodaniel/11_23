using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _2311
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            string nev = nevTextBox.Text;
            string jelszo = jelszoTextBox.Text;
            DateTime regdatum = szuletesDateTimePicker.Value;
            using (var conn = new MySqlConnection("Server=localhost;DataBase=regisztracio;Uid=root;Pwd=;"))
            {
                conn.Open();

                var ellenorzes = conn.CreateCommand();
                ellenorzes.CommandText = "SELECT COUNT(*) FROM felhasznalo WHERE nev = @nev";
                ellenorzes.Parameters.AddWithValue("@nev", nev);
                var darab = (long)ellenorzes.ExecuteScalar();
                if (darab != 0)
                {
                    MessageBox.Show("ilyen felhasználó van");
                    return;
                }
                
                var command = conn.CreateCommand();
                command.CommandText = "INSERT INTO felhasznalo (nev,jelszo,regdatum) VALUES (@nev, @jelszo, @regdatum)";
                command.Parameters.AddWithValue("@nev",nev);
                command.Parameters.AddWithValue("@jelszo", jelszo);
                command.Parameters.AddWithValue("@regdatum", regdatum);
                int erintettSorok = command.ExecuteNonQuery();
                
               


            }
        }

        private void frissitesButton_Click(object sender, EventArgs e)
        {
            string nev = nevTextBox.Text;
            string jelszo = jelszoTextBox.Text;
            DateTime regdatum = szuletesDateTimePicker.Value;
            using (var conn = new MySqlConnection("Server=localhost;DataBase=regisztracio;Uid=root;Pwd=;"))
            {
                conn.Open();

                var ellenorzes = conn.CreateCommand();
                ellenorzes.CommandText = "SELECT COUNT(*) FROM felhasznalo WHERE nev = @nev";
                ellenorzes.Parameters.AddWithValue("@nev", nev);
                
                var command = conn.CreateCommand();
                command.CommandText = "UPDATE felhasznalo SET jelszo = @jelszo, regdatum = @regdatum WHERE nev = @nev";
                /*update kaloriatabla set nev = '$nev',
                mennyiseg = '$mennyiseg', kaloria = $kaloria,
						zsir = $zsir, szenhidrat = $szenhidrat, feherje = $feherje
                        where id = $id";*/
                command.Parameters.AddWithValue("@nev", nev);
                command.Parameters.AddWithValue("@jelszo", jelszo);
                command.Parameters.AddWithValue("@regdatum", regdatum);
                int erintettSorok = command.ExecuteNonQuery();




            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nev = nevTextBox.Text;
            string jelszo = jelszoTextBox.Text;
            DateTime regdatum = szuletesDateTimePicker.Value;
            using (var conn = new MySqlConnection("Server=localhost;DataBase=regisztracio;Uid=root;Pwd=;"))
            {
                conn.Open();

                var ellenorzes = conn.CreateCommand();
                ellenorzes.CommandText = "SELECT COUNT(*) FROM felhasznalo WHERE nev = @nev";
                ellenorzes.Parameters.AddWithValue("@nev", nev);

                var command = conn.CreateCommand();
                command.CommandText = "DELETE FROM felhasznalo WHERE nev = @nev";
                
                command.Parameters.AddWithValue("@nev", nev);
                command.Parameters.AddWithValue("@jelszo", jelszo);
                command.Parameters.AddWithValue("@regdatum", regdatum);
                int erintettSorok = command.ExecuteNonQuery();




            }
        }
    }
}
