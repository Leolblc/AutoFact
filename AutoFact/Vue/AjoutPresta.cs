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

                MySqlCommand cmd = new MySqlCommand("SELECT id , libelle FROM Type_Prestation;", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable ds2 = new DataTable();
                adapter.Fill(ds2);

                foreach (DataRow row in ds2.Rows)
                {
                    int ID = Convert.ToInt32(row["id"]);
                    string nom = row["libelle"].ToString();
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonValider2_Click(object sender, EventArgs e)
        {
            UnePresta selectedPrestation = comboBox1.SelectedItem as UnePresta;
            if (selectedPrestation == null)
            {
                MessageBox.Show("Veuillez sélectionner une prestation.", "Erreur");
                return;
            }

            try
            {

                string command1 = "INSERT INTO Prestation (name, description, prix_unitaire, montant_ht, id_type) VALUES (@name, @description, @prix_unitaire, @montant_ht, @id_type)";
                MySqlCommand cmmd = new MySqlCommand(command1, connection);
                cmmd.Parameters.AddWithValue("@name", TBNom.Text);
                cmmd.Parameters.AddWithValue("@description", richTextBox1.Text);
                cmmd.Parameters.AddWithValue("@prix_unitaire", TBPrixunitaire.Text);
                cmmd.Parameters.AddWithValue("@montant_ht", CB_HT.Text);
                cmmd.Parameters.AddWithValue("@id_type", comboBox1.Items.Count);
                cmmd.ExecuteNonQuery();
                MessageBox.Show("La Prestation a été ajoutée dans la liste")

                Prestation presta = new Prestation();
                presta.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}");
            }


        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnClientNA3_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
            this.Close();
        }

        private void BtnPrestationNA_Click(object sender, EventArgs e)
        {

        }

        private void BtnFacture3_Click(object sender, EventArgs e)
        {
            Facturation facturation = new Facturation();
            facturation.Show();
            this.Close();
        }

        private void BtnRecap3_Click(object sender, EventArgs e)
        {
            Recapitulatif recapitulatif = new Recapitulatif();
            recapitulatif.Show();
            this.Close();
        }
    }
}

            
      
    

