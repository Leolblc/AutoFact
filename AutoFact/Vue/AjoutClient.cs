using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoFact.Vue;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoFact
{
    public partial class AjoutClient : Form
    {
        private MySqlConnection connection;
        public AjoutClient()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = "Server=192.168.56.10;Database=AutoFact;User ID=operateur;Password=Operateur;";
            connection = new MySqlConnection(connectionString);
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "192.168.56.10",
                UserID = "operateur",
                Password = "Operateur",
                Database = "db_AutoFact",
            };
            connection = new MySqlConnection(builder.ConnectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Connexion à la base de données réussie!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion à la base de données : {ex.Message}", "Erreur de connexion");
            }
        }
        public class UnCli
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public object Type { get; set; }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            try
            {

                string command1 = "INSERT INTO Client(name,lastname,mail,phone,address) values (@name, @lastname,@mail,@phone,@address);";
                MySqlCommand cmmd = new MySqlCommand(command1, connection);
                cmmd.Parameters.AddWithValue("@name", TBNom.Text);
                cmmd.Parameters.AddWithValue("@lastname", TBPrenom.Text);
                cmmd.Parameters.AddWithValue("@mail", TBMail.Text);
                cmmd.Parameters.AddWithValue("@phone", TBPhone.Text);
                cmmd.Parameters.AddWithValue("@adress", TBAdresse.Text);
                cmmd.ExecuteNonQuery();
                MessageBox.Show("Le Client a été ajoutée dans la liste");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}");
            }
        }

        private void TBPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnFacture2_Click(object sender, EventArgs e)
        {
            Facturation FormFacturation = new Facturation();
            FormFacturation.ShowDialog();
        }

        private void BtnRecap2_Click(object sender, EventArgs e)
        {
            Recapitulatif FormRecap = new Recapitulatif();
            FormRecap.ShowDialog();
        }
    }
}