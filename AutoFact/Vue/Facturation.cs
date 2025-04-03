using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using AutoFact.Vue;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using QuestPDF;
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
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using QuestPDF.Helpers;
using System.Xml.Linq;





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

        private void BtnAddFact_Click(object sender, EventArgs e)
        {
            AjoutFacturation ajoutFacturation = new AjoutFacturation();
            ajoutFacturation.Show();
            this.Close();
        }

        private void InitializeDatabaseConnection()
        {
            // string connectionString = "Server=172.16.119.9Database=db_AutoFact;User ID=admin;Password=admin;";
            // connection = new MySqlConnection(connectionString);
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "172.16.119.17",
                UserID = "operateur",
                Password = "Operateur",
                Database = "Autofact_leo",
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



        public class UnExport
        {

            public string Text { get; set; }
            public object Value { get; set; }
            public object Type { get; set; }
            public string LeFact { get; set; }
            public int LID { get; set; }


            public override string ToString()
            {
                return LeFact;
            }

        }




        private void Facturation_Load(object sender, EventArgs e)
        {
            string query = "SELECT numfact, condition_escompte,datepayement , Prestation.name as name , Client.name as clientName ,Prestation.prix_unitaire , quantite FROM Facturation JOIN Client on Client.id = Facturation.id_1 join Generer on Generer.id_1=Facturation.id JOIN Prestation on Prestation.id = Generer.id;";

            try
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        DGVFacturation.DataSource = dataTable; // Assurez-vous que le nom du DataGridView est correct
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des dernières prestations : {ex.Message}", "Erreur de chargement");
            }

            Facturepdf();
        }

        private void CBPDF_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Facturepdf()
        {
            try
            {

                MySqlCommand cmd = new MySqlCommand("SELECT id , numfact FROM Facturation;", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable ds2 = new DataTable();
                adapter.Fill(ds2);

                foreach (DataRow row in ds2.Rows)
                {
                    int ID = Convert.ToInt32(row["id"]);
                    string nom = row["numfact"].ToString();
                    UnExport exportpdf = new UnExport { LeFact = nom, LID = ID };
                    CBPDF.Items.Add(exportpdf);
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

            string selectedFacture = CBPDF.Text;
            if (string.IsNullOrEmpty(selectedFacture))
            {
                MessageBox.Show($"Aucune valeur entrée.");
                return;
            }

            string query = "select Facturation.id as id, numfact, condition_escompte, datepayement, Facturation.description as description_F, quantite, Client.name as nom, Client.lastname, mail, phone, residence, address, echeance, taux_penalite, date_etat, etat, qte, Prestation.name as name, Prestation.description as description_P, prix_unitaire, montant_ht, libelle from Facturation left join Client on Client.id=Facturation.id_1 left join Payement on Payement.id=Facturation.id_2 left join Definir on Definir.id=Facturation.id left join Etat on Definir.id_1=Etat.id left join Generer on Generer.id_1=Facturation.id left join Prestation on Prestation.id=Generer.id left join Type_Prestation on Type_Prestation.id=Prestation.id_type WHERE numfact = @numfact;";
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

            bool colonneVide = factureData.AsEnumerable().All(row =>
           row.IsNull("id") || string.IsNullOrWhiteSpace(row["id"].ToString()));
            if (colonneVide) 
            {
                MessageBox.Show($"Aucune valeur correspond.");
                return;
            }

            // Création du document PDF
            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(50);
                    page.Size(QuestPDF.Helpers.PageSizes.A4);
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

            document.GeneratePdfAndShow();
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
            string condition_escompte = row["condition_escompte"] != DBNull.Value ? row["condition_escompte"].ToString() : "Inconnue";

            container.PaddingVertical(20).Column(column =>
            {
                column.Item().Text($"Description : {description}").FontSize(12).SemiBold();
                column.Item().Text($"Statut : {statut}").FontSize(12).SemiBold();
                column.Item().Text($"condition_escompte : {condition_escompte}").FontSize(12).SemiBold(); ;
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
                column.Item().Row(row =>
                {
                    row.RelativeItem().Column(clientColumn =>  // Ajout des infos client
                    {
                        clientColumn.Item().Text("For").Bold().Underline();
                        clientColumn.Item().Text("expéditeur: Waché Nathan");
                        clientColumn.Item().Text("Residence: Lycée Fulbert");
                        clientColumn.Item().Text("Addresse: 62 rue Saint Chéron – 28000 Chartres");
                        clientColumn.Item().Text("Adresse Mail: nat@nat.com");
                        clientColumn.Item().Text("Numéro téléphone: 06 77 77 77 77");
                    });
                });

                column.Spacing(10);

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
            // variable colonneVide pour savoir si prestation est vide 
            bool colonneVide = factureData.AsEnumerable().All(row =>
           row.IsNull("name") || string.IsNullOrWhiteSpace(row["name"].ToString()));
            container.Column(column =>
            {
                if (colonneVide)
                {
                    column.Item().PaddingTop(10).AlignCenter().Text($"Aucun Prestation.").SemiBold().FontSize(14);
                }
                else
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
                            string name = row["name"] != DBNull.Value ? row["name"].ToString() : "Inconnue";
                            if (name != "Inconnue")
                            {
                                index++;
                                int qte = row["qte"] != DBNull.Value ? Convert.ToInt32(row["qte"]) : 0;
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
                        }
                    });

                    decimal TVA = TousTotal * 0.2M;
                    decimal PlusTVA = TousTotal * (1 + 0.2M);
                    // Ajout du total en dehors du tableau
                    column.Item().PaddingTop(10).AlignRight().Text($"Total Général : {TousTotal:C}").SemiBold().FontSize(14);
                    column.Item().PaddingTop(10).AlignRight().Text($"TVA (20%) : {TVA:C}").SemiBold().FontSize(14);
                    column.Item().PaddingTop(10).AlignRight().Text($"Total : {PlusTVA:C}").SemiBold().FontSize(14);
                }   
            });
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void buttonClient3_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
            this.Close();
        }

        private void buttonPresta3_Click(object sender, EventArgs e)
        {
            Prestation prestation = new Prestation();
            prestation.Show();
            this.Close();
        }

        private void buttonRecap3_Click(object sender, EventArgs e)
        {
            Recapitulatif recapitulatif = new Recapitulatif();
            recapitulatif.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AjoutFacturation ajoutFacturation = new AjoutFacturation();
            ajoutFacturation.Show();
            this.Close();
        }

        private void CBPDF_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void BtnExportPDF_Click(object sender, EventArgs e)
        {
            ExportPDF();
        }
    }
}
