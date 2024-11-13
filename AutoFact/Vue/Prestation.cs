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
    public partial class Prestation : Form
    {
        public Prestation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddPresta_Click(object sender, EventArgs e)
        {
            AjoutPresta newPresta = new AjoutPresta();
            newPresta.ShowDialog();
        }
    }
}
