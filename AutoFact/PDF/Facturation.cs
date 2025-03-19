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
using QuestPDF.Companion;
using QuestPDF.Previewer;

namespace AutoFact.PDF
{
    internal class Facturation
    {
        public void ExportPDF(string selectedFacture)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            if (selectedFacture == "")
            {
                MessageBox.Show($"Aucun valeur entrer.");
                return; // Sortir de la méthode si une erreur se produit
            }
            string query = "SELECT * FROM AfficheFacturationTotale WHERE numfact = @numfact"; // Remplacez par votre requête

            DataTable factureData = new DataTable();

            

            // Créer le document PDF
            var document = Document.Create(container =>
            {
                container.Page(page =>
                {


                    page.Margin(50);
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
                                string dateValue = row["datepayement"] != DBNull.Value ? row["datepayement"].ToString() : "Inconnue";
                                string dateLimite = row["echeance"] != DBNull.Value ? row["echeance"].ToString() : "Inconnue";
                                string addressValue = row["address"] != DBNull.Value ? row["address"].ToString() : "Inconnu";
                                string DescriptionValue = row["description_F"] != DBNull.Value ? row["description_F"].ToString() : "Inconnu";
                                string StatutValue = row["etat"] != DBNull.Value ? row["etat"].ToString() : "Inconnue";

                                text.Line($"Date payement: {row["datepayement"]}");
                                text.Line($"Date échéange: {row["echeance"]}");

                                text.Line($"Client: {row["nom"]}");
                                text.Line($"Description: {row["Description"]}");
                                text.Line($"Statut: {row["etat"]}");
                                // Ajoutez d'autres champs selon vos besoins
                            }
                        });

                    //page.Content().Column(column => 
                    //{
                    //    // Ajoutez ici les données de la facture
                    //    foreach (DataRow row in factureData.Rows)
                    //    {
                    //        string QTE = row["numfact"] != DBNull.Value ? row["numfact"].ToString() : "Inconnu";
                    //    }
                    //});


                    page.Footer().AlignCenter().Text(text =>
                    {
                        text.CurrentPageNumber();
                        text.Span(" / ");
                        text.TotalPages();
                    });
                });
            });

            document.GeneratePdf("exemple.pdf"); // Vous pouvez spécifier un chemin si nécessaire
            MessageBox.Show("PDF généré avec succès !");
        }
    }
}
