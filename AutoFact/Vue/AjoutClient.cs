using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using MySql.EntityFrameworkCore;
using MySql;
using MySql.Data;
using AutoFact.Vue;
using System.Net.Mail;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Extensions.Logging;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Bcpg;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.ComponentModel.Design;

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
            string connectionString = "Server=192.168.56.2;Database=db_AutoFact;User ID=operateur;Password=Operateur;";
            connection = new MySqlConnection(connectionString);
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "192.168.56.2",
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

        }

        private void TBPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnVal_Click(object sender, EventArgs e)
        {
            try
            {

                string command2 = "INSERT INTO Client(name,lastname,mail,phone,address) VALUES (@name, @lastname,@mail,@phone,@address);";
                MySqlCommand cmd1 = new MySqlCommand(command2, connection);
                cmd1.Parameters.AddWithValue("@name", TBNom.Text);
                cmd1.Parameters.AddWithValue("@lastname", TBPrenom.Text);
                cmd1.Parameters.AddWithValue("@mail", TBMail.Text);
                cmd1.Parameters.AddWithValue("@phone", TBPhone.Text);
                cmd1.Parameters.AddWithValue("@address", TBAdresse.Text);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Le Client a été ajoutée dans la liste");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}");
            }
        }

        private void TBNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}