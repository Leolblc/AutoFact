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
            this.Hide();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            LoadData();
            DGVListClient.CellValueChanged += DGVListClient_CellValueChanged;
            ConfigureDataGridView();
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
            this.Close();
        }

        private void BtnPrestation_Click(object sender, EventArgs e)
        {
            Prestation prestation = new Prestation();
            prestation.Show();
            this.Close();
        }

        private void BtnFacture_Click(object sender, EventArgs e)
        {
            Facturation facture = new Facturation();
            facture.Show();
            this.Close();
        }

        private void BtnRecap_Click(object sender, EventArgs e)
        {
            Recapitulatif recapitulatif = new Recapitulatif();
            recapitulatif.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AjoutClient jout = new AjoutClient();
            jout.Show();
            this.Close();
        }

        private void DGVListClient_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGVListClient.Columns["active"].Index && e.RowIndex >= 0)
            {
                int clientId = Convert.ToInt32(DGVListClient.Rows[e.RowIndex].Cells["id"].Value);
                bool isActive = Convert.ToBoolean(DGVListClient.Rows[e.RowIndex].Cells["active"].Value);

                try
                {
                    var db = DatabaseConnection.GetInstance();
                    string query = "UPDATE Client SET active = @active WHERE id = @id;";
                    using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@active", isActive);
                        cmd.Parameters.AddWithValue("@id", clientId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la mise à jour : {ex.Message}");
                    LoadData();
                }
            }
        }






        private void ConfigureDataGridView()
        {

            // Rendre toutes les colonnes sauf la colonne bouton "Supprimer" en lecture seule
            foreach (DataGridViewColumn col in DGVListClient.Columns)
            {
                if (col.Name != "active")
                {
                    col.ReadOnly = true;
                }
            }
        }

        private void DGVListClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
