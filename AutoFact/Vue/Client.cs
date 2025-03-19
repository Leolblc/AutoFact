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
    public partial class Client : Form
    {
        private MySqlConnection connection;

        public Client()
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


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AjoutClient newClient = new AjoutClient();
            newClient.Show();
            this.Hide();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            LoadData();
            AddDeleteButtonColumn();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM Client";

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

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void BtnPrestation_Click(object sender, EventArgs e)
        {
            Prestation prestation = new Prestation();
            prestation.Show();
            this.Close();
        }

        private void BtnFacture_Click(object sender, EventArgs e)
        {
            Facturation facture = new Facturation();
            facture.Show();
            this.Close();
        }

        private void BtnRecap_Click(object sender, EventArgs e)
        {
            Recapitulatif recapitulatif = new Recapitulatif();
            recapitulatif.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AjoutClient jout = new AjoutClient();
            jout.Show();
            this.Close();
        }

        private void DeleteClient(int clientId)
        {
            try
            {
                string command = "DELETE FROM Client WHERE id = @id;";
                MySqlCommand cmd = new MySqlCommand(command, connection);
                cmd.Parameters.AddWithValue("@id", clientId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le client a été supprimé.");


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression : {ex.Message}");
            }
        }

        private void AddDeleteButtonColumn()
        {
            if (DGVListClient.Columns["DeleteButton"] == null) // Vérifie si la colonne existe déjà
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "DeleteButton";
                deleteButton.HeaderText = "Action";
                deleteButton.Text = "Supprimer";
                deleteButton.UseColumnTextForButtonValue = true; // Afficher le texte dans les boutons

                DGVListClient.Columns.Add(deleteButton);
            }
        }

        private void DGVListClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGVListClient.Columns["DeleteButton"].Index && e.RowIndex >= 0)
            {
                // Récupérer l'ID du client
                int clientId = Convert.ToInt32(DGVListClient.Rows[e.RowIndex].Cells["id"].Value);

                // Demande de confirmation
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce client ?",
                                                      "Confirmation de suppression",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteClient(clientId);
                    LoadData(); // Rafraîchir les données après suppression
                }
            }
        }

        private void DGVListClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
