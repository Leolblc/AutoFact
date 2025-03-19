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
using QuestPDF.Drawing;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;


using QuestPDF.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("La connexion est déjà ouverte.");
                return;
            }
            /*string connectionString = "Server=172.16.119.17Database=Autofact;User ID=operateur;Password=Operateur;";
            connection = new MySqlConnection(connectionString);*/
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

            string selectedFacture = CBNFacturation.Text;
            if (string.IsNullOrEmpty(selectedFacture))
            {
                MessageBox.Show($"Aucune valeur entrée.");
                return;
            }

            string query = "SELECT * FROM AfficheFacturationTotale WHERE numfact = @numfact";
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
                return;
            }

            // Création du document PDF
            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(50);
                    page.Size(PageSizes.A4);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(12));

                    // 📌 En-tête
                    page.Header().Element(container => ComposeHeader(container, factureData, selectedFacture));

                    // 📌 Contenu unique (évite le double appel à `page.Content()`)
                    page.Content().Column(column =>
                    {
                        column.Item().Element(container => ComposeForFrom(container, factureData));
                        column.Item().Element(container => ComposeContent(container, factureData));
                        column.Item().Element(container => ComposeTable(container, factureData));
                    });

                    // 📌 Pied de page
                    page.Footer().AlignCenter().Text(text =>
                    {
                        text.CurrentPageNumber();
                        text.Span(" / ");
                        text.TotalPages();
                    });
                });
            });

            document.GeneratePdf("exemple.pdf");
            MessageBox.Show("PDF généré avec succès !");
        }

        // 📌 Déplacement des méthodes à l'extérieur pour plus de clarté
        private void ComposeHeader(QuestPDF.Infrastructure.IContainer container, DataTable factureData, string numfact)
        {
            if (factureData.Rows.Count == 0) return;
            DataRow row = factureData.Rows[0];

            string dateValue = row["datepayement"] != DBNull.Value ? Convert.ToDateTime(row["datepayement"]).ToShortDateString() : "Inconnue";
            string dateLimite = row["echeance"] != DBNull.Value ? Convert.ToDateTime(row["echeance"]).ToShortDateString() : "Inconnue";
            string addressValue = row["address"] != DBNull.Value ? row["address"].ToString() : "Inconnu";
            string datePDF = DateTime.Now.ToString("dd/MM/yyyy");

            container.Row(row =>
            {
                row.RelativeItem().Column(column =>
                {
                    column.Item().Text($"Facture #{numfact}")
                        .FontSize(20).SemiBold().FontColor(Colors.Blue.Medium);
                    column.Item().Text($"Date PDF : {datePDF}");
                    column.Item().Text($"Date de paiement : {dateValue}");
                    column.Item().Text($"Date d'échéance : {dateLimite}");
                    column.Item().Text($"Adresse : {addressValue}");
                });
            });
        }

        private void ComposeContent(QuestPDF.Infrastructure.IContainer container, DataTable factureData)
        {
            if (factureData.Rows.Count == 0) return;
            DataRow row = factureData.Rows[0];
            
            string description = row["description_F"] != DBNull.Value ? row["description_F"].ToString() : "Inconnu";
            string statut = row["etat"] != DBNull.Value ? row["etat"].ToString() : "Inconnue";

            container.PaddingVertical(20).Column(column =>
            {
                column.Item().Text($"Description : {description}").FontSize(12).SemiBold();
                column.Item().Text($"Statut : {statut}").FontSize(12).SemiBold(); ;
            });
        }

        private void ComposeForFrom(QuestPDF.Infrastructure.IContainer container, DataTable factureData) 
        {
            if (factureData.Rows.Count == 0) return;
            DataRow row = factureData.Rows[0];

            string client_n = row["nom"] != DBNull.Value ? row["nom"].ToString() : "Inconnu";
            string client_p = row["lastname"] != DBNull.Value ? row["lastname"].ToString() : "Inconnu";
            string mail = row["mail"] != DBNull.Value ? row["mail"].ToString() : "Inconnu";
            string téléphone = row["phone"] != DBNull.Value ? row["phone"].ToString() : "Inconnu";
            string residence = row["residence"] != DBNull.Value ? row["residence"].ToString() : "Inconnu";
            string address = row["address"] != DBNull.Value ? row["address"].ToString() : "Inconnu";

            container.PaddingVertical(40).Column(column =>
            {
                column.Item().Text("For").Bold().Underline();
                column.Spacing(20);

                column.Item().Row(row =>
                {
                    row.RelativeItem().Column(clientColumn =>  // Ajout des infos client
                    {
                        clientColumn.Item().Text("From").Bold().Underline();
                        clientColumn.Item().Text($"Client: {client_n} {client_p}");
                        clientColumn.Item().Text($"Residence: {residence}");
                        clientColumn.Item().Text($"Addresse: {address}");
                        clientColumn.Item().Text($"Adresse Mail: {mail}");
                        clientColumn.Item().Text($"Numéro téléphone: {téléphone}");
                    });
                });
            });

        }

        private void ComposeTable(QuestPDF.Infrastructure.IContainer container, DataTable factureData)
        {
            var headerStyle = TextStyle.Default.SemiBold();
            decimal TousTotal = 0;
            container.Column(column =>
            {
                column.Item().Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.ConstantColumn(25);
                        columns.RelativeColumn(3);
                        columns.RelativeColumn(2);
                        columns.RelativeColumn(2);
                        columns.RelativeColumn(2);
                        columns.RelativeColumn(2);
                    });

                    table.Header(header =>
                    {
                        header.Cell().Text("#");
                        header.Cell().Text("Produit").Style(headerStyle);
                        header.Cell().AlignRight().Text("Quantité").Style(headerStyle);
                        header.Cell().AlignRight().Text("Prix Unitaire").Style(headerStyle);
                        header.Cell().AlignRight().Text("Montant HT").Style(headerStyle);
                        header.Cell().AlignRight().Text("Total").Style(headerStyle);
                        header.Cell().ColumnSpan(6).PaddingTop(5).BorderBottom(1).BorderColor(Colors.Black);
                    });

                    
                    int index = 0;
                    foreach (DataRow row in factureData.Rows)
                    {
                        index++;
                        int qte = row["qte"] != DBNull.Value ? Convert.ToInt32(row["qte"]) : 0;
                        string name = row["name"] != DBNull.Value ? row["name"].ToString() : "Inconnue";
                        decimal prix_unitaire = row["prix_unitaire"] != DBNull.Value ? Convert.ToDecimal(row["prix_unitaire"]) : 0m;
                        decimal montant_ht = row["montant_ht"] != DBNull.Value ? Convert.ToDecimal(row["montant_ht"]) : 0m;
                        decimal total = prix_unitaire * qte;
                        TousTotal += total;

                        table.Cell().Text($"{index}");
                        table.Cell().Text(name);
                        table.Cell().AlignRight().Text($"{qte}");
                        table.Cell().AlignRight().Text($"{prix_unitaire:C}");
                        table.Cell().AlignRight().Text($"{montant_ht:C}");
                        table.Cell().AlignRight().Text($"{total:C}");
                    }
                });

                decimal TVA = TousTotal * 0.2M;
                decimal PlusTVA = TousTotal * (1 + 0.2M);
                // Ajout du total en dehors du tableau
                column.Item().PaddingTop(10).AlignRight().Text($"Total Général : {TousTotal:C}").SemiBold().FontSize(14);
                column.Item().PaddingTop(10).AlignRight().Text($"TVA (20%) : {TVA:C}").SemiBold().FontSize(14);
                column.Item().PaddingTop(10).AlignRight().Text($"Total : {PlusTVA:C}").SemiBold().FontSize(14);
                column.Item().PaddingTop(10).AlignRight().Text($"Total : {PlusTVA:C}").SemiBold().FontSize(14);

            });
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