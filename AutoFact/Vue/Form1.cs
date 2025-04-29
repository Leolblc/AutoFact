using AutoFact.Vue;
using System.Data;
using MySqlConnector;



namespace AutoFact
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            Client FormClient = new Client();
            FormClient.ShowDialog();
            this.Hide();

        }

        private void buttonPresta_Click(object sender, EventArgs e)
        {
            Prestation FormPrestation = new Prestation();
            FormPrestation.ShowDialog();
            this.Hide();
        }

        private void buttonFact_Click(object sender, EventArgs e)
        {
            Facturation FormFacturation = new Facturation();
            FormFacturation.ShowDialog();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonRecap_Click(object sender, EventArgs e)
        {
            Recapitulatif FormRecap = new Recapitulatif();
            FormRecap.ShowDialog();
            this.Hide();
        }

        private void DGVPrestation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void LoadDernieresPrestations()
        {
            string query = "SELECT * FROM DernieresPrestations";

            try
            {
                var db = DatabaseConnection.GetInstance();
                using (var command = new MySqlCommand(query, db.GetConnection()))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        DGVPrestation.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des dernières prestations : {ex.Message}", "Erreur de chargement");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDernieresPrestations();
            LoadDernierClients();
            LoadDerniereFacture();
        }

        private void DGVLastClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadDernierClients()
        {
            string query = "SELECT * FROM DernierClients";

            try
            {
                var db = DatabaseConnection.GetInstance();
                using (var command = new MySqlCommand(query, db.GetConnection()))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        DGVLastClient.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des dernières prestations : {ex.Message}", "Erreur de chargement");
            }
        }

        private void LoadDerniereFacture()
        {
            string query = "SELECT * FROM Derniere_Facture";

            try
            {
                var db = DatabaseConnection.GetInstance();
                using (var command = new MySqlCommand(query, db.GetConnection()))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        DGVFact.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des dernières prestations : {ex.Message}", "Erreur de chargement");
            }
        }

        private void DGVFact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_info1_Click(object sender, EventArgs e)
        {
            Form3 FormInfo = new Form3();
            FormInfo.ShowDialog();
            this.Hide();
        }
    }
}
