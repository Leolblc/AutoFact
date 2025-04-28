
using System.Data;
using MySqlConnector;



namespace AutoFact.Vue
{
    public partial class Recapitulatif : Form
    {
        private MySqlConnection connection;


        public Recapitulatif()
        {
            InitializeComponent();
        }

        private void LoadDataMois()
        {
            string query = "SELECT * FROM DataMois;";

            try
            {
                var db = DatabaseConnection.GetInstance();

                using (var command = new MySqlCommand(query, db.GetConnection()))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridViewM.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données : {ex.Message}", "Erreur de chargement");
            }
        }
        private void LoadDatatrimestre()
        {
            string query = "SELECT * FROM DataTrimestre";

            try
            {
                var db = DatabaseConnection.GetInstance();

                using (var command = new MySqlCommand(query, db.GetConnection()))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridViewT.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données : {ex.Message}", "Erreur de chargement");
            }
        }
        private void LoadDataSommetrimestre()
        {
            string query = "SELECT * FROM DataSommeTrimestre";

            try
            {
                var db = DatabaseConnection.GetInstance();
                using (var command = new MySqlCommand(query, db.GetConnection()))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        ARPT.DataSource = dataTable;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données : {ex.Message}", "Erreur de chargement");
            }
        }
        private void LoadDataSommeMois()
        {
            string query = "SELECT * FROM DataSommeMois";

            try
            {
                var db = DatabaseConnection.GetInstance();
                using (var command = new MySqlCommand(query, db.GetConnection()))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        ARPM.DataSource = dataTable;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données : {ex.Message}", "Erreur de chargement");
            }
        }
        private void Recapitulatif_Load(object sender, EventArgs e)
        {
            LoadDataMois();
            LoadDatatrimestre();
            LoadDataSommeMois();
            LoadDataSommetrimestre();
        }


        private void buttonPresta_Click(object sender, EventArgs e)
        {
            Prestation FormPrestation = new Prestation();
            FormPrestation.ShowDialog();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            Client FormClient = new Client();
            FormClient.ShowDialog();
        }

        private void buttonFact_Click(object sender, EventArgs e)
        {
            Facturation FormFacturation = new Facturation();
            FormFacturation.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ARPM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ARPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClient_Click_1(object sender, EventArgs e)
        {
            Client FormClient = new Client();

            FormClient.Show();

            this.Close();
        }

        private void buttonPresta_Click_1(object sender, EventArgs e)
        {
            Prestation prestation = new Prestation();
            prestation.Show();
            this.Close();
        }

        private void buttonFact_Click_1(object sender, EventArgs e)
        {
            Facturation formFacturation = new Facturation();
            formFacturation.Show();
            this.Close();
        }

        private void buttonRecap_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
