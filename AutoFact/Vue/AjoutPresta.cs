
using System.Data;
using MySqlConnector;
using AutoFact.Vue;

namespace AutoFact
{
    public partial class AjoutPresta : Form
    {
        private MySqlConnection connection;
        public AjoutPresta()
        {
            InitializeComponent();
            LoadPresta2();

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
                var db = DatabaseConnection.GetInstance();
                string query = "SELECT id, libelle FROM Type_Prestation";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int ID = reader.GetInt32("id");
                        string nom = reader.GetString("libelle");
                        UnePresta lapresta = new UnePresta { anName = nom, anid = ID };
                        comboBox1.Items.Add(lapresta);
                    }

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
                var db = DatabaseConnection.GetInstance();

                string query = @"INSERT INTO Prestation (name, description, prix_unitaire, montant_ht, id_type) VALUES (@name, @description, @prix_unitaire, @montant_ht, @id_type)";
                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@name", TBNom.Text);
                    cmd.Parameters.AddWithValue("@description", richTextBox1.Text);
                    cmd.Parameters.AddWithValue("@prix_unitaire", TBPrixunitaire.Text);
                    cmd.Parameters.AddWithValue("@montant_ht", CB_HT.Text);
                    cmd.Parameters.AddWithValue("@id_type", selectedPrestation.anid);
                    cmd.ExecuteNonQuery();
                };

                MessageBox.Show("La Prestation a été ajoutée dans la liste");

                Prestation presta = new Prestation();
                presta.Show();
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

        private void AjoutPresta_Load(object sender, EventArgs e)
        {

        }

        private void Btn_info1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }
    }
}

            
      
    

