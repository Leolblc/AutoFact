using System.Data;
using MySqlConnector;
using AutoFact.Vue;

namespace AutoFact
{
    public partial class Client : Form
    {
        private MySqlConnection connection;

        public Client()
        {
            InitializeComponent();
            
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AjoutClient newClient = new AjoutClient();
            newClient.Show();
            // this.Hide();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void LoadData()
        {

            try
            {
                var db = DatabaseConnection.GetInstance();
                string query = "SELECT * FROM Client";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    DGVListClient.DataSource = dataTable;

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

        private void BtnPrestation_Click(object sender, EventArgs e)
        {
            Prestation prestation = new Prestation();
            prestation.Show();
            // this.Close();
        }

        private void BtnFacture_Click(object sender, EventArgs e)
        {
            Facturation facture = new Facturation();
            facture.Show();
            // this.Close();
        }

        private void BtnRecap_Click(object sender, EventArgs e)
        {
            Recapitulatif recapitulatif = new Recapitulatif();
            recapitulatif.Show();
            // this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AjoutClient jout = new AjoutClient();
            jout.Show();
            // this.Close();
        }
    }
}
