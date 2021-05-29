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
        public formSchermataIniziale() //Inizializzazione del form.
        {
            InitializeComponent();
        }
        private void giocaBtn_Click(object sender, EventArgs e) //Se si fa click sopra questo oggetto, allora esegue le seguenti operazioni.
        {
            formSceltaGiocatori Form3 = new formSceltaGiocatori(); //Inizializza il Form3, ovvero quello che permette la scelta del numero di giocatori.
            Form3.Show(); //Visualizza il Form3.
            this.Hide(); //Chiude questo form.
        }
        private void statisticheBtn_Click(object sender, EventArgs e) //Se si fa click sopra questo oggetto, allora esegue le seguenti operazioni.
        {
            bool statisticheIO = false;
            formStatistiche Form8 = new formStatistiche(statisticheIO, ""); //Inizializza il Form8, ovvero quello che contiene le statistiche.
            Form8.Show(); //Visualizza il Form8.
            this.Hide(); //Chiude questo form.
        }

        private void comesigiocaBtn_Click(object sender, EventArgs e) //Se si fa click sopra questo oggetto, allora esegue le seguenti operazioni.
        { 
            formCapitoliIstruzioni Form5 = new formCapitoliIstruzioni(); //Inizializza il Form5, ovvero quello che contiene i capitoli delle istruzioni.
            Form5.Show(); //Visualizza il Form5.
            this.Hide(); //Chiude questo form.
        }

        private void giocaPicBox_MouseHover(object sender, EventArgs e) //Se si pone il mouse sopra questo oggetto, allora esegue le seguenti operazioni.
        {
            //Abilita solamente il bottone che si trova sotto alla PictureBox.
            giocaBtn.Visible = true;
            statisticheBtn.Visible = false;
            comeSiGiocaBtn.Visible = false;
        }

        private void statistichePicBox_MouseHover(object sender, EventArgs e) //Se si pone il mouse sopra questo oggetto, allora esegue le seguenti operazioni.
        {
            //Abilita solamente il bottone che si trova sotto alla PictureBox.
            giocaBtn.Visible = false;
            statisticheBtn.Visible = true;
            comeSiGiocaBtn.Visible = false;
        }

        private void comeSiGiocaPicBox_MouseHover(object sender, EventArgs e) //Se si pone il mouse sopra questo oggetto, allora esegue le seguenti operazioni.
        {
            //Abilita solamente il bottone che si trova sotto alla PictureBox.
            giocaBtn.Visible = false;
            statisticheBtn.Visible = false;
            comeSiGiocaBtn.Visible = true;
        }
        private void formSchermataIniziale_FormClosed(object sender, FormClosedEventArgs e) //Operazioni eseguite alla chiusura di un form.
        {
            Application.Exit(); //Esce completamente dal programma.
        }
    }
}
