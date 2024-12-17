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
    public partial class Prestation : Form
    {
        private MySqlConnection connection;
        public Prestation()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = "Server=172.16.119.17Database=Autofact;User ID=operateur;Password=Operateur;";
            connection = new MySqlConnection(connectionString);
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "172.16.119.17",
                UserID = "operateur",
                Password = "Operateur",
                Database = "Autofact",
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddPresta_Click(object sender, EventArgs e)
        {
            AjoutPresta newPresta = new AjoutPresta();
            newPresta.ShowDialog();
        }


        private void Prestation_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string query = "select * from AffichePrestation;";

            try
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        DGVListClient.DataSource = dataTable; // Assurez-vous que le nom du DataGridView est correct
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données : {ex.Message}", "Erreur de chargement");
            }
        }

        private void buttonClient3_Click(object sender, EventArgs e)
        {
            Client FormClient = new Client();
            FormClient.ShowDialog();
        }

        private void DGVListClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonFact3_Click(object sender, EventArgs e)
        {
            Facturation FormFacturation = new Facturation();
            FormFacturation.ShowDialog();
        }

        private void buttonRecap3_Click(object sender, EventArgs e)
        {
            Recapitulatif FormRecap = new Recapitulatif();
            FormRecap.ShowDialog();
        }
    }
}
