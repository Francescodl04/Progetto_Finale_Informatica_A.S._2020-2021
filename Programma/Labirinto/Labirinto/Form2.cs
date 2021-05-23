//Autore: Francesco Di Lena
//Classe: 3F
//Data: aprile-maggio 2021
//Progetto finale di informatica: "Il Gioco del Labirinto".
//Schermata iniziale.

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
        public formSchermataIniziale()
        {
            InitializeComponent();
        }
        private void giocaBtn_Click(object sender, EventArgs e)
        {
            formSceltaGiocatori formSalvataggio = new formSceltaGiocatori();
            formSalvataggio.Show();
            this.Hide();
        }

        private void formSchermataIniziale_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void statisticheBtn_Click(object sender, EventArgs e)
        {
            bool statisticheIO = false;
            formStatistiche Form8 = new formStatistiche(statisticheIO, "");
            Form8.Show();
            this.Hide();
        }

        private void comesigiocaBtn_Click(object sender, EventArgs e)
        {
            formCapitoliIstruzioni Form5 = new formCapitoliIstruzioni();
            Form5.Show();
            this.Hide();
        }
        
        private void giocaPicBox_MouseHover(object sender, EventArgs e)
        {
            giocaBtn.Visible = true;
            statisticheBtn.Visible = false;
            comeSiGiocaBtn.Visible = false;
        }

        private void statistichePicBox_MouseHover(object sender, EventArgs e)
        {
            giocaBtn.Visible = false;
            statisticheBtn.Visible = true;
            comeSiGiocaBtn.Visible = false;
        }

        private void comeSiGiocaPicBox_MouseHover(object sender, EventArgs e)
        {
            giocaBtn.Visible = false;
            statisticheBtn.Visible = false;
            comeSiGiocaBtn.Visible = true;
        }
    }
}
