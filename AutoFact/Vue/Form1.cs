using AutoFact.Vue;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoFact
{
    public partial class Form1 : Form
    {
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
    }
}
