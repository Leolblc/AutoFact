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
using System.Net.Mail;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Extensions.Logging;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Bcpg;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static AutoFact.AjoutPresta;
using Org.BouncyCastle.Crypto;
using Microsoft.VisualBasic;

namespace AutoFact.Vue
{
    public partial class Form3 : Form
    {
        private MySqlConnection connection;

        public Form3()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        public void InitializeDatabaseConnection()
        {
            // string connectionString = "Server=172.16.119.9Database=db_AutoFact;User ID=admin;Password=admin;";
            // connection = new MySqlConnection(connectionString);
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Update_INFO_Click(object sender, EventArgs e)
        {
            try
            {
                string command3 = "UPDATE Info_entrepreneur SET nom=@nom, prenom=@prenom, Adresse=@adresse, mail = @mail,telephone=@telephone WHERE id= 1";
                MySqlCommand cmd3 = new MySqlCommand(command3, connection);
                cmd3.Parameters.AddWithValue("@nom", TB_Name_INFO.Text);
                cmd3.Parameters.AddWithValue("@prenom", TB_LasName_ENT.Text);
                cmd3.Parameters.AddWithValue("@adresse", TB_Address_INFO.Text);
                cmd3.Parameters.AddWithValue("@mail", TB_Mail_INFO.Text);
                cmd3.Parameters.AddWithValue("@telephone", TB_Phone_INFO.Text);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Informations mises à jour");


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la mise à jour des informations : {ex.Message}", "Erreur de mise à jour");
            }


        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            Client FormClient = new Client();
            FormClient.ShowDialog();
            // this.Hide();
        }

        private void buttonPresta_Click(object sender, EventArgs e)
        {
            Prestation FormPrestation = new Prestation();
            FormPrestation.ShowDialog();
            // this.Hide();
        }

        private void buttonFact_Click(object sender, EventArgs e)
        {
            Facturation FormFacturation = new Facturation();
            FormFacturation.ShowDialog();
            // this.Hide();
        }

        private void buttonRecap_Click(object sender, EventArgs e)
        {
            Recapitulatif FormRecap = new Recapitulatif();
            FormRecap.ShowDialog();
            // this.Hide();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
