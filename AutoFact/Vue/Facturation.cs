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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using MySql.EntityFrameworkCore;
using MySql;
using MySql.Data;
using System.Net.Mail;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Extensions.Logging;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Bcpg;
using System.ComponentModel.Design;
using QuestPDF.Fluent;

using QuestPDF.Helpers;

using QuestPDF.Infrastructure;

namespace AutoFact
{
    public partial class Facturation : Form
    {
        private MySqlConnection connection;
        public Facturation()
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

        private void BtnAddFact_Click(object sender, EventArgs e)
        {
            AjoutFacturation FormFacturation = new AjoutFacturation();
            FormFacturation.ShowDialog();
        }

        private void buttonClient3_Click(object sender, EventArgs e)
        {
            Client FormClient = new Client();
            FormClient.ShowDialog();
        }
        private void LoadData()
        {
            string query = "select * from AfficheFacturation; ";

            try
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        DGVListClient.DataSource = dataTable; // Assurez-vous que le nom du DataGridView est correct*/
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données : {ex.Message}", "Erreur de chargement");
            }
        }
        public class UneFacture
        {

            public string Text { get; set; }
            public object Value { get; set; }
            public object Type { get; set; }
            public string anName { get; set; }
            public int anid { get; set; }


            public override string ToString()
            {
                return anName;
            }

        }
        private void LoadCBNFacturation()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id, numfact FROM Facturation;", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable ds2 = new DataTable();
                adapter.Fill(ds2);

                // Assurez-vous que le ComboBox est correctement nommé
                CBNFacturation.Items.Clear(); // Effacez les éléments précédents
                foreach (DataRow row in ds2.Rows)
                {
                    int ID = Convert.ToInt32(row["id"]);
                    string nom = row["numfact"].ToString();
                    UneFacture laFacture = new UneFacture { anName = nom, anid = ID };
                    CBNFacturation.Items.Add(laFacture); // Utilisez le nom du ComboBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données : {ex.Message}", "Erreur de chargement");
            }
        }

        private void ExportPDF()
        {
            QuestPDF.Settings.License = LicenseType.Community;

            // Récupérer les données de la base de données
            string selectedFacture = CBNFacturation.Text; // Assurez-vous que l'élément sélectionné est valide
            string query = "SELECT * FROM AfficheFacturation WHERE numfact = @numfact"; // Remplacez par votre requête

            DataTable factureData = new DataTable();

            try
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@numfact", selectedFacture);
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(factureData);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération des données : {ex.Message}", "Erreur de chargement");
                return; // Sortir de la méthode si une erreur se produit
            }

            // Créer le document PDF
            var document = QuestPDF.Fluent.Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(20));

                    page.Header()
                        .Text($"Facture de {selectedFacture}")
                        .SemiBold().FontSize(36).FontColor(Colors.Blue.Medium);

                    page.Content()
                        .Text(text =>
                        {
                            // Ajoutez ici les données de la facture
                            foreach (DataRow row in factureData.Rows)
                            {
                                string numFacture = row["numfact"] != DBNull.Value ? row["numfact"].ToString() : "Inconnu";
                                string clientValue = row["Client"] != DBNull.Value ? row["Client"].ToString() : "Inconnu";
                                string dateValue = row["date"] != DBNull.Value ? row["date"].ToString() : "Inconnue";
                                string DescriptionValue = row["Description"] != DBNull.Value ? row["Description"].ToString() : "Inconnu";
                                string StatutValue = row["Statut"] != DBNull.Value ? row["Statut"].ToString() : "Inconnue";

                                text.Line($"Numéro de Facture: {row["numfact"]}");
                                text.Line($"Client: {row["Client"]}");
                                text.Line($"Date: {row["date"]}");
                                text.Line($"Description: {row["Description"]}");
                                text.Line($"Statut: {row["Statut"]}");
                                // Ajoutez d'autres champs selon vos besoins
                            }
                        });

                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Page ");
                            x.CurrentPageNumber();
                        });
                });
            });

            document.GeneratePdf("exemple.pdf"); // Vous pouvez spécifier un chemin si nécessaire
            MessageBox.Show("PDF généré avec succès !");
        }

        private void buttonRecap3_Click(object sender, EventArgs e)
        {
            Recapitulatif FormRecap = new Recapitulatif();
            FormRecap.ShowDialog();
        }

        private void DGVListClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Facturation_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCBNFacturation(); // Appelez la méthode pour charger les numéros de factures
        }

        private void CBNFacturation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pdf_Click(object sender, EventArgs e)
        {
            ExportPDF();
        }
    }
}