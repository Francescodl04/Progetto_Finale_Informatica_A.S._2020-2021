//Autore: Francesco Di Lena
//Classe: 3F
//Data: aprile-maggio 2021
//Progetto finale di informatica: "Il Gioco del Labirinto".
//Schermata di visualizzazione dei singoli capitoli delle istruzioni d'uso.

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
    public partial class formLetturaIstruzioni : Form
    {
        int numCapitolo = 0;
        public formLetturaIstruzioni(int numeroCapitolo)
        {
            InitializeComponent();
            numCapitolo = numeroCapitolo;
        }

        private void indietroPicBox_Click(object sender, EventArgs e)
        {
            formCapitoliIstruzioni Form5 = new formCapitoliIstruzioni();
            Form5.Show();
            this.Hide();
        }

        private void formLetturaIstruzioni_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
