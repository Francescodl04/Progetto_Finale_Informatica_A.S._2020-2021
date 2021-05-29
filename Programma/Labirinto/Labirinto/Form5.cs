//Autore: Francesco Di Lena
//Classe: 3F
//Data: aprile-maggio 2021
//Progetto finale di informatica: "Il Gioco del Labirinto".
//Schermata di scelta dei capitoli delle istruzioni d'uso.

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
        int numeroCapitolo = 0; //Variabile che conterrà il numero del capitolo scelto dall'utente.
        public formCapitoliIstruzioni() //Viene inizializzato il form.
        {
            InitializeComponent();
        }
        //Serie di eventi generati dal click dei vari bottoni che permettono di accedere alla lettura delle istruzioni d'uso del programma.
        private void cap1Btn_Click(object sender, EventArgs e)
        {
            numeroCapitolo = 0;
            SchermataSuccessiva(numeroCapitolo);
        }

        private void cap2Btn_Click(object sender, EventArgs e)
        {
            numeroCapitolo = 1;
            SchermataSuccessiva(numeroCapitolo);
        }

        private void cap3Btn_Click(object sender, EventArgs e)
        {
            numeroCapitolo = 2;
            SchermataSuccessiva(numeroCapitolo);
        }

        private void cap4Btn_Click(object sender, EventArgs e)
        {
            numeroCapitolo = 3;
            SchermataSuccessiva(numeroCapitolo);
        }

        private void cap5Btn_Click(object sender, EventArgs e)
        {
            numeroCapitolo = 4;
            SchermataSuccessiva(numeroCapitolo);
        }

        private void cap6Btn_Click(object sender, EventArgs e)
        {
            numeroCapitolo = 5;
            SchermataSuccessiva(numeroCapitolo);
        }

        private void cap7Btn_Click(object sender, EventArgs e)
        {
            numeroCapitolo = 6;
            SchermataSuccessiva(numeroCapitolo);
        }

        private void cap8Btn_Click(object sender, EventArgs e)
        {
            numeroCapitolo = 7;
            SchermataSuccessiva(numeroCapitolo);
        }

        private void cap9Btn_Click(object sender, EventArgs e)
        {
            numeroCapitolo = 8;
            SchermataSuccessiva(numeroCapitolo);
        }
        public void SchermataSuccessiva(int numeroCapitolo) //Funzione che permette di accedere alla schermata successiva, passando il valore di numeroCapitolo.
        {
            formLetturaIstruzioni Form6 = new formLetturaIstruzioni(numeroCapitolo); //Inizializza il nuovo form.
            Form6.Show(); //Visualizza il nuovo form.
            this.Hide(); //Chiude il form corrente.
        }

        private void formCapitoliIstruzioni_FormClosed(object sender, FormClosedEventArgs e) //Evento generato dalla chiusura del form.
        {
            Application.Exit(); //Chiude completamente il programma.
        }

        private void indietroPicBox_Click(object sender, EventArgs e) //Evento generato dal click di indietroPicBox, che permette di tornare alla schermata precedente.
        {
            formSchermataIniziale Form2 = new formSchermataIniziale(); //Inizializza il nuovo form.
            Form2.Show(); //Visualizza il nuovo form.
            this.Hide(); //Chiude il form corrente.
        }
    }
}
