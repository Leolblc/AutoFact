using AutoFact.Vue;
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
using static AutoFact.AjoutPresta;
using Org.BouncyCastle.Crypto;


namespace AutoFact
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            InitializeDatabaseConnection();

        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = "Server=172.16.119.9;Database=db_AutoFact;User ID=admin;Password=admin;";
            connection = new MySqlConnection(connectionString);
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "172.16.119.9",
                UserID = "admin",
                Password = "admin",
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



        private void buttonClient_Click(object sender, EventArgs e)
        {
            Client FormClient = new Client();
            FormClient.ShowDialog();
            this.Hide();

        }

        private void buttonPresta_Click(object sender, EventArgs e)
        {
            Prestation FormPrestation = new Prestation();
            FormPrestation.ShowDialog();
            this.Hide();
        }

        private void buttonFact_Click(object sender, EventArgs e)
        {
            Facturation FormFacturation = new Facturation();
            FormFacturation.ShowDialog();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonRecap_Click(object sender, EventArgs e)
        {
            Recapitulatif FormRecap = new Recapitulatif();
            FormRecap.ShowDialog();
            this.Hide();
        }

        private void DGVPrestation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void LoadDernieresPrestations()
        {
            string query = "SELECT * FROM DernieresPrestations";

            try
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        DGVPrestation.DataSource = dataTable; // Assurez-vous que le nom du DataGridView est correct
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des dernières prestations : {ex.Message}", "Erreur de chargement");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDernieresPrestations();
            LoadDernierClients();
            LoadDerniereFacture();
        }

        private void DGVLastClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadDernierClients()
        {
            string query = "SELECT * FROM DernierClients";

            try
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        DGVLastClient.DataSource = dataTable; // Assurez-vous que le nom du DataGridView est correct
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des dernières prestations : {ex.Message}", "Erreur de chargement");
            }
        }

        private void LoadDerniereFacture()
        {
            string query = "SELECT * FROM Derniere_Facture";

            try
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        DGVFact.DataSource = dataTable; // Assurez-vous que le nom du DataGridView est correct
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des dernières prestations : {ex.Message}", "Erreur de chargement");
            }
        }

        private void DGVFact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
