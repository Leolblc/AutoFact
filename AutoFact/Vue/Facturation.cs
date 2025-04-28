using System.Data;
using MySqlConnector;
using AutoFact.Vue;




namespace AutoFact
{
    public partial class Facturation : Form

    {
        private MySqlConnection connection;
        public Facturation()
        {
            InitializeComponent();
        }

        private void BtnAddFact_Click(object sender, EventArgs e)
        {
            AjoutFacturation ajoutFacturation = new AjoutFacturation();
            ajoutFacturation.Show();
            this.Close();
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
            

            try
            {
                var db = DatabaseConnection.GetInstance();
                string query = "SELECT numfact, condition_escompte,datepayement , Prestation.name as name , Client.name as clientName ,Prestation.prix_unitaire , quantite FROM Facturation JOIN db_AutoFact.Client on Client.id = Facturation.id_1 JOIN Prestation on Prestation.id = Facturation.id_2";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    DGVFacturation.DataSource = dataTable;
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
                var db = DatabaseConnection.GetInstance();

                string query = "SELECT id, numfact FROM Facturation;";
                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int ID = reader.GetInt32("id");
                            string nom = reader.GetString("numfact");

                            UnExport exportpdf = new UnExport { LeFact = nom, LID = ID };
                            CBPDF.Items.Add(exportpdf);
                        }
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
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void buttonClient3_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
            this.Close();
        }

        private void buttonPresta3_Click(object sender, EventArgs e)
        {
            Prestation prestation = new Prestation();
            prestation.Show();
            this.Close();
        }

        private void buttonRecap3_Click(object sender, EventArgs e)
        {
            Recapitulatif recapitulatif = new Recapitulatif();
            recapitulatif.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AjoutFacturation ajoutFacturation = new AjoutFacturation();
            ajoutFacturation.Show();
            this.Close();
        }
    }
}
