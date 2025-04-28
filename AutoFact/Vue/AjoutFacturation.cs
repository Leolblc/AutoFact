using MySqlConnector;
using AutoFact.Vue;


namespace AutoFact
{
    public partial class AjoutFacturation : Form
    {

        private List<unePresta> ListePresta = new List<unePresta>();
        private List<unClients> ListedeClients = new List<unClients>();
        public AjoutFacturation()
        {
            InitializeComponent();
            LoadClient();
            LoadPresta();
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
                var db = DatabaseConnection.GetInstance();
                string query = "SELECT id, name FROM Client";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int ID = reader.GetInt32("id");
                        string nom = reader.GetString("name");
                        unClients leclient = new unClients { Name = nom, id = ID };
                        CBListCli.Items.Add(leclient);
                        ListedeClients.Add(leclient);
                    }
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
                var db = DatabaseConnection.GetInstance();
                string query = "SELECT id, name FROM Prestation";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int ID = reader.GetInt32("id");
                        string nom = reader.GetString("name");
                        unePresta lapresta = new unePresta { anName = nom, id = ID };
                        CBNpresta.Items.Add(lapresta);
                        ListePresta.Add(lapresta);
                    }
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

            unePresta selectedPrestation = CBNpresta.SelectedItem as unePresta;
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

                var db = DatabaseConnection.GetInstance();
                

                string query = @"INSERT INTO Facturation
                    (numfact, quantite, condition_escompte, description, datepayement,id_1,id_2) VALUES 
                    (@numfact, @quantite, @escompte,@description, @datepayement, @id_1, @id_2);";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@numfact", TBNomFacture.Text);
                    cmd.Parameters.AddWithValue("@quantite", (int)NUDQte.Value);
                    cmd.Parameters.AddWithValue("@escompte", TBEscompte.Text);
                    cmd.Parameters.AddWithValue("@description", TBDescription.Text);
                    cmd.Parameters.AddWithValue("@datepayement", DTPDate.Value);
                    cmd.Parameters.AddWithValue("@id_1", selectedClient.id);
                    cmd.Parameters.AddWithValue("@id_2", selectedPrestation.id);

                    cmd.ExecuteNonQuery();
                }
                
                MessageBox.Show("La facture a été ajoutée dans la liste");

                Facturation facturation = new Facturation();
                facturation.Show();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
            this.Close();
        }

        private void buttonPresta_Click(object sender, EventArgs e)
        {
            Prestation prestation = new Prestation();
            prestation.Show();
            this.Close();
        }

        private void buttonRecap_Click(object sender, EventArgs e)
        {
            Recapitulatif recapitulatif = new Recapitulatif();
            recapitulatif.Show();
            this.Close();
        }
    }

}
