using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirinto
{
    public partial class formCapitoliIstruzioni : Form
    {
        public formCapitoliIstruzioni()
        {
            InitializeComponent();
        }

        private void formCapitoliIstruzioni_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void indietroPicBox_Click(object sender, EventArgs e)
        {
            formSchermataIniziale Form2 = new formSchermataIniziale();
            Form2.Show();
            this.Hide();
        }
    }
}
