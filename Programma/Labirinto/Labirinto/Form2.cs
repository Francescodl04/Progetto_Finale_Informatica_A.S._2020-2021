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
    public partial class formSchermataIniziale : Form
    {
        private formSchermataIniziale Form2;
        private formCapitoliIstruzioni Form5;
        public formSchermataIniziale()
        {
            InitializeComponent();
        }
        private void formSchermataIniziale_Load(object sender, EventArgs e)
        {
            
        }
        private void chiudiBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void giocaBtn_Click(object sender, EventArgs e)
        {
            salvataggio formSalvataggio = new salvataggio();
            formSalvataggio.Show();
            this.Close();
        }

        private void formSchermataIniziale_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void riduciIconaBtn_Click(object sender, EventArgs e)
        {
            Form2 = new formSchermataIniziale();
            WindowState = FormWindowState.Minimized;
        }

        private void chiudi_gioco_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void statisticheBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Non sono presenti ancora statistiche. Per vederle, gioca!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void comesigiocaBtn_Click(object sender, EventArgs e)
        {
            Form5 = new formCapitoliIstruzioni();
            Form5.Show();
            this.Close();
        }
    }
}
