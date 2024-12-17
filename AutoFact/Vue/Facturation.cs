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
            string query = "SELECT numfact, condition_escompte,datepayement , Prestation.name as name , Client.name as clientName FROM Facturation JOIN db_AutoFact.Client on Client.id = Facturation.id_1 JOIN Prestation on Prestation.id = Facturation.id_2;";

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

    }
}
