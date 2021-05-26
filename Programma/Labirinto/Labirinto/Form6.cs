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
using System.IO;

namespace Labirinto
{
    public partial class formLetturaIstruzioni : Form
    {
        int numCapitolo = 0;
        string[,] datiIstruzioni = new string[9, 2];
        public formLetturaIstruzioni(int numeroCapitolo)
        {
            InitializeComponent();
            numCapitolo = numeroCapitolo;
        }
        private void formLetturaIstruzioni_Load(object sender, EventArgs e)
        {
            string istruzioni = File.ReadAllText(@"C:\Labirinto\istruzioni.txt");
            char carattereDivisore = '|';
            string[] elementiIstruzioni = istruzioni.Split(carattereDivisore);
            int n = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 2; j++) 
                {
                    datiIstruzioni[i, j] = elementiIstruzioni[n];
                    n++;
                }
            }
            TestoImmagini();
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
        private void avantiCapitoliBtn_Click(object sender, EventArgs e)
        {
            if (numCapitolo != 8)
            {
                numCapitolo++;
                TestoImmagini();
            }
        }
        private void indietroCapitoliBtn_Click(object sender, EventArgs e)
        {
            if (numCapitolo != 0)
            {
                numCapitolo--;
                TestoImmagini();
            }
        }
        public void TestoImmagini()
        {
            indicazioniGioco.Text = datiIstruzioni[numCapitolo, 0];
            istruzioniTxt.Text = datiIstruzioni[numCapitolo, 1];
            if (numCapitolo == 0)
            {
                indietroCapitoliBtn.Enabled = false;
            }
            else if (numCapitolo == 8)
            {
                avantiCapitoliBtn.Enabled = false;
            }
            else
            {
                indietroCapitoliBtn.Enabled = true;
                avantiCapitoliBtn.Enabled = true;
            }
        }
    }
}
