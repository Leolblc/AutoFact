
using MySqlConnector;


namespace AutoFact.Vue
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
            loadData();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void loadData()
        {
            try
            {
                var db = DatabaseConnection.GetInstance();
                string query = "SELECT * FROM Info_entrepreneur WHERE id=1";
                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        TB_Name_INFO.Text = reader["nom"].ToString();
                        TB_LasName_ENT.Text = reader["prenom"].ToString();
                        TB_Address_INFO.Text = reader["Adresse"].ToString();
                        TB_Mail_INFO.Text = reader["mail"].ToString();
                        TB_Phone_INFO.Text = reader["telephone"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données : {ex.Message}", "Erreur de chargement");
            }
        }

        private void BTN_Update_INFO_Click(object sender, EventArgs e)
        {
            try
            {
                var db = DatabaseConnection.GetInstance();

                string command3 = "UPDATE Info_entrepreneur SET nom=@nom, prenom=@prenom, Adresse=@adresse, mail=@mail, telephone=@telephone WHERE id=1";

                using (MySqlCommand cmd3 = new MySqlCommand(command3, db.GetConnection()))
                {
                    cmd3.Parameters.AddWithValue("@nom", TB_Name_INFO.Text);
                    cmd3.Parameters.AddWithValue("@prenom", TB_LasName_ENT.Text);
                    cmd3.Parameters.AddWithValue("@adresse", TB_Address_INFO.Text);
                    cmd3.Parameters.AddWithValue("@mail", TB_Mail_INFO.Text);
                    cmd3.Parameters.AddWithValue("@telephone", TB_Phone_INFO.Text);

                    cmd3.ExecuteNonQuery();
                }

                MessageBox.Show("Informations mises à jour");
                this.Close();
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
            this.Close();
        }

        private void buttonPresta_Click(object sender, EventArgs e)
        {
            Prestation FormPrestation = new Prestation();
            FormPrestation.ShowDialog();
            this.Close();
        }

        private void buttonFact_Click(object sender, EventArgs e)
        {
            Facturation FormFacturation = new Facturation();
            FormFacturation.ShowDialog();
            this.Close();
        }

        private void buttonRecap_Click(object sender, EventArgs e)
        {
            Recapitulatif FormRecap = new Recapitulatif();
            FormRecap.ShowDialog();
            this.Close();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TB_LasName_ENT_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }

}
