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
    public partial class Prestation : Form
    {
        private MySqlConnection connection;
        public Prestation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddPresta_Click(object sender, EventArgs e)
        {
            AjoutPresta newPresta = new AjoutPresta();
            newPresta.ShowDialog();
            // this.Close();
        }


        private void Prestation_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT Prestation.id, Prestation.name, Type_Prestation.libelle " +
               "FROM Prestation " +
               "INNER JOIN Type_Prestation ON Prestation.id_type = Type_Prestation.id " +
               "ORDER BY Prestation.id";

            try
            {
                var db = DatabaseConnection.GetInstance();

                using (var command = new MySqlCommand(query, db.GetConnection()))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        DGVListClient.DataSource = dataTable;
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
            // this.Close();
        }

        private void buttonClient3_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
            // this.Close();
        }

        private void buttonFact3_Click(object sender, EventArgs e)
        {
            Facturation facturation = new Facturation();
            facturation.Show();
            // this.Close();
        }

        private void buttonRecap3_Click(object sender, EventArgs e)
        {
            Recapitulatif recapitulatif = new Recapitulatif();
            recapitulatif.Show();
            // this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AjoutPresta ajoutPresta = new AjoutPresta();
            ajoutPresta.Show();
            // this.Close();
        }
    }
}
