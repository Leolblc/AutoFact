using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFact
{
    public partial class Facturation : Form
    {
        public Facturation()
        {
            InitializeComponent();
        }

        private void BtnAddFact_Click(object sender, EventArgs e)
        {
            AjoutFacturation ajoutFacturation = new AjoutFacturation();
            ajoutFacturation.Show();
        }
    }
}
