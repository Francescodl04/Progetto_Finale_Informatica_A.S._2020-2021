using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Labirinto
{
    public partial class formGioco : Form
    {
        public formGioco()
        {
            InitializeComponent();
        }

        private void formGioco_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void esciSenzaSalvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void indietroTStripMenuItem_Click(object sender, EventArgs e)
        {
            formSchermataIniziale Form2 = new formSchermataIniziale();
            Form2.Show();
            this.Hide();
        }

        private void infoTStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il Gioco del Labirinto\nVersione software 1.0\nVersione .NET Framework: 4.7.2 \nTutti i diritti riservati a Ravensburger e a Francesco Di Lena" +
                "\n\nProgetto Finale di Informatica con Windows Forms e C#.\nA.S. 2020-2021\nClasse 3F\nITIS Ferruccio Viola", "Informazioni su Labirinto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void istruzioniTStripMenuItem_Click(object sender, EventArgs e)
        {
            formCapitoliIstruzioni Form5 = new formCapitoliIstruzioni();
            Form5.Show();
                
        }
    }
}
