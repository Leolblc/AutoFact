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
using static AutoFact.AjoutPresta;
using static AutoFact.AjoutClient;
using Org.BouncyCastle.Crypto;

namespace AutoFact
{
    public partial class AjoutFacturation : Form
    {
        private MySqlConnection connection;

        private List<unePresta> ListePresta = new List<unePresta>();
        private List<unClients> ListedeClients = new List<unClients>();
        public AjoutFacturation()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadClient();
            LoadPresta();
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

        public class unClients
        {

            public string Text { get; set; }
            public object Value { get; set; }
            public object Type { get; set; }
            public string Name { get; set; }
            public int id { get; set; }


            public override string ToString()
            {
                return Name;
            }

        }

        private void LoadClient()
        {

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id , name FROM Client", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                adapter.Fill(ds);

                foreach (DataRow row in ds.Rows)
                {
                    int ID = Convert.ToInt32(row["id"]);
                    string nom = row["name"].ToString();
                    unClients leclient = new unClients { Name = nom, id = ID };
                    CBListCli.Items.Add(leclient);
                    ListedeClients.Add(leclient);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données : {ex.Message}", "Erreur de chargement");
            }

        }
        public class unePresta
        {

            
            public object Type { get; set; }
            public string anName { get; set; }
            public int id { get; set; }


            public override string ToString()
            {
                return anName;
            }

        }
        private void LoadPresta()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id , name FROM Prestation", connection);
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                adapter2.Fill(ds);

                foreach (DataRow row in ds.Rows)
                {
                    int ID = Convert.ToInt32(row["id"]);
                    string lenom = row["name"].ToString();
                    unePresta lapresta = new unePresta { anName = lenom, id = ID };
                    CBNpresta.Items.Add(lapresta);
                    ListePresta.Add(lapresta);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données : {ex.Message}", "Erreur de chargement");
            }

        }
        private void CBListCli_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AjoutFacturation_Load(object sender, EventArgs e)
        {


        }

        private void buttonFact_Click(object sender, EventArgs e)
        {

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {

            unePresta selectedPrestation = ListePresta[CBNpresta.SelectedIndex];
            if (selectedPrestation == null)
            {
                MessageBox.Show("Veuillez sélectionner une prestation.", "Erreur");
                return;
            }

            unClients selectedClient = CBListCli.SelectedItem as unClients;
            if (selectedClient == null)
            {
                MessageBox.Show("Veuillez sélectionner un Client.", "Erreur");
                return;
            }
            try
            {

                string command2 = "INSERT INTO Facturation(numfact,condition_escompte,datepayement,id_1,id_2,description,quantite) VALUES (@numfact, @escompte,@datepayement,@id_1,@id_2,@description,@quantite);";
                MySqlCommand cmd1 = new MySqlCommand(command2, connection);
                cmd1.Parameters.AddWithValue("@numfact", TBNomFacture.Text);
                cmd1.Parameters.AddWithValue("@escompte", TBEscompte.Text);
                cmd1.Parameters.AddWithValue("@datepayement", DTPDate.Value);
                cmd1.Parameters.AddWithValue("@id_1", ListePresta[CBListCli.SelectedIndex].id);
                cmd1.Parameters.AddWithValue("@id_2", ListePresta[CBNpresta.SelectedIndex].id);
                cmd1.Parameters.AddWithValue("@description", TBDescription.Text);
                cmd1.Parameters.AddWithValue("@quantite", NUDQte.Text);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("La facture a été ajoutée dans la liste");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}");
            }
        }
    }

}
