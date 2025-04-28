
using MySqlConnector;


namespace AutoFact.Vue
{
    public partial class Form3 : Form
    {
        private MySqlConnection connection;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

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
            // this.Hide();
        }

        private void buttonPresta_Click(object sender, EventArgs e)
        {
            Prestation FormPrestation = new Prestation();
            FormPrestation.ShowDialog();
            // this.Hide();
        }

        private void buttonFact_Click(object sender, EventArgs e)
        {
            Facturation FormFacturation = new Facturation();
            FormFacturation.ShowDialog();
            // this.Hide();
        }

        private void buttonRecap_Click(object sender, EventArgs e)
        {
            Recapitulatif FormRecap = new Recapitulatif();
            FormRecap.ShowDialog();
            // this.Hide();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
