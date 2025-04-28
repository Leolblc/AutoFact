using MySqlConnector;
using AutoFact.Vue;


namespace AutoFact
{
    public partial class AjoutClient : Form
    {
        private MySqlConnection connection;
        public AjoutClient()
        {
            InitializeComponent();
        }
 
        public class UnCli
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public object Type { get; set; }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {

        }

        private void TBPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnVal_Click(object sender, EventArgs e)
        {
            try
            {
                var db = DatabaseConnection.GetInstance();
                string command2 = "INSERT INTO Client(name,lastname,mail,phone,address,active) VALUES (@name, @lastname,@mail,@phone,@address,@active);";
                
                MySqlCommand cmd1 = new MySqlCommand(command2, db.GetConnection());
                cmd1.Parameters.AddWithValue("@name", TBNom.Text);
                cmd1.Parameters.AddWithValue("@lastname", TBPrenom.Text);
                cmd1.Parameters.AddWithValue("@mail", TBMail.Text);
                cmd1.Parameters.AddWithValue("@phone", TBPhone.Text);
                cmd1.Parameters.AddWithValue("@address", TBAdresse.Text);
                cmd1.Parameters.AddWithValue("@active", true);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Le Client a été ajoutée dans la liste");

                Client client = new Client();
                client.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}");
            }
        }

        private void TBNom_TextChanged(object sender, EventArgs e)
        {

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

        private void BtnPrestation2_Click(object sender, EventArgs e)
        {
            Prestation prestation = new Prestation();
            prestation.Show();
            this.Close();
        }

        private void BtnFacture2_Click(object sender, EventArgs e)
        {
            Facturation facture = new Facturation();
            facture.Show();
            this.Close();
        }

        private void BtnRecap2_Click(object sender, EventArgs e)
        {
            Recapitulatif recapitulatif = new Recapitulatif();
            recapitulatif.Show();
            this.Close();
        }

        private void AjoutClient_Load(object sender, EventArgs e)
        {

        }
    }
}