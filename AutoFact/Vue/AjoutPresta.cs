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

namespace AutoFact
{
    public partial class AjoutPresta : Form
    {
        private MySqlConnection connection;
        public AjoutPresta()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadPresta2();

        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = "Server=localhost;Database=RPGQuest;User ID=root;Password=;";
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


        public class UnePresta
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

        private void LoadPresta2()
        {

            try
            {
                
                    MySqlCommand cmd = new MySqlCommand("SELECT id,name FROM Prestation", connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable ds2 = new DataTable();
                    adapter.Fill(ds2);

                    foreach (DataRow row in ds2.Rows)
                    {
                        int ID = Convert.ToInt32(row["id"]);
                        string nom = row["name"].ToString();
                        UnePresta lapresta = new UnePresta { anName = nom, anid = ID };
                        comboBox1.Items.Add(lapresta);

                    }
                    

                

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données : {ex.Message}", "Erreur de chargement");
            }

        }

        private void Cb_ClientPresta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
            
      
    

