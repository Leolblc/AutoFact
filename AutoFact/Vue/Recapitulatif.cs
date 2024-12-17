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


namespace AutoFact.Vue
{
    public partial class Recapitulatif : Form
    {
        private MySqlConnection connection;


        public Recapitulatif()
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

        private void LoadDataMois()
        {
            string query = "select `Client`.`name`, nomfact, prix_unitaire, MONTH(echeance) as `Mois` from Facturation inner join `Client` on `Client`.id=Facturation.id_1 inner join Generer on Generer.id_1=Facturation.id inner join Prestation on Generer.id=Prestation.id inner join Payement on Facturation.id_2=Payement.id ; ";

            try
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewM.DataSource = dataTable; // Assurez-vous que le nom du DataGridView est correct*/
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données : {ex.Message}", "Erreur de chargement");
            }
        }
        private void LoadDatatrimestre()
        {
            string query = "select `Client`.`name`, nomfact, prix_unitaire, QUARTER(echeance)  as `trimestre` from Facturation inner join `Client` on `Client`.id=Facturation.id_1 inner join Generer on Generer.id_1=Facturation.id inner join Prestation on Generer.id=Prestation.id inner join Payement on Facturation.id_2=Payement.id ; ";

            try
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewT.DataSource = dataTable; // Assurez-vous que le nom du DataGridView est correct
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données : {ex.Message}", "Erreur de chargement");
            }
        }
        private void LoadDataSommetrimestre()
        {
            string query = "SELECT `Client`.`name` AS `Client`, nomfact AS `NomFacture`, SUM(prix_unitaire) AS `Total_Prix`, QUARTER(echeance) AS `trimestre` FROM Facturation INNER JOIN `Client` ON `Client`.id = Facturation.id_1 INNER JOIN  Generer ON Generer.id_1 = Facturation.id INNER JOIN Prestation ON Generer.id = Prestation.id INNER JOIN Payement ON Facturation.id_2 = Payement.id GROUP BY `Client`.`name`, QUARTER(echeance);";

            try
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        ARPT.DataSource = dataTable;
                        // Assurez-vous que le nom du DataGridView est correct
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données : {ex.Message}", "Erreur de chargement");
            }
        }
        private void LoadDataSommeMois()
        {
            string query = "SELECT `Client`.`name` AS `Client`, nomfact AS `NomFacture`, SUM(prix_unitaire) AS `Total_Prix`, MONTH(echeance) AS `Mois` FROM Facturation INNER JOIN `Client` ON `Client`.id = Facturation.id_1 INNER JOIN  Generer ON Generer.id_1 = Facturation.id INNER JOIN Prestation ON Generer.id = Prestation.id INNER JOIN Payement ON Facturation.id_2 = Payement.id GROUP BY `Client`.`name`,  MONTH(echeance);";

            try
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        ARPM.DataSource = dataTable; // Assurez-vous que le nom du DataGridView est correct
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données : {ex.Message}", "Erreur de chargement");
            }
        }
        private void Recapitulatif_Load(object sender, EventArgs e)
        {
            LoadDataMois();
            LoadDatatrimestre();
            LoadDataSommeMois();
            LoadDataSommetrimestre();
        }


        private void buttonPresta_Click(object sender, EventArgs e)
        {
            Prestation FormPrestation = new Prestation();
            FormPrestation.ShowDialog();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            Client FormClient = new Client();
            FormClient.ShowDialog();
        }

        private void buttonFact_Click(object sender, EventArgs e)
        {
            Facturation FormFacturation = new Facturation();
            FormFacturation.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ARPM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ARPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
