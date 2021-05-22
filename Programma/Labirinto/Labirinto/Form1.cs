//Autore: Francesco Di Lena
//Classe: 3F
//Data: aprile-maggio 2021
//Progetto finale di informatica: "Il Gioco del Labirinto".
//Schermata di caricamento.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirinto
{
    public partial class formCaricamento : Form
    {
        public formCaricamento()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //Al caricamento del form esegue le seguenti operazioni.
        {
            Attendi();
        }
        public async void  Attendi() //Funzione di tipo asincrono che non restituisce alcun valore e che permette di posticipare l'esecuzione delle istruzioni.
        {
            barraProgressi.Step = 1; //Identifica lo step che deve essere compiuto dalla barra di progresso (1% alla volta)
            for (int i = 0; i < 100; i++) //Inizia un ciclo in cui riempie la barra di progresso.
            {
                await Task.Delay(1); //Metodo che permette di attendere un millisecondo.
                barraProgressi.PerformStep(); //Metodo che esegue lo step di 1% alla volta.
                descrizioneOperazioni.Text = "Caricamento in corso ( " + (i + 1) + "% )";
            }
            await Task.Delay(1000); //Attende un ulteriore secondo.
            formSchermataIniziale fSchermata = new formSchermataIniziale();
            fSchermata.Show(); //Passa il controllo alla schermata successiva.
            this.Hide(); //Nasconde questa schermata.
        }
        private void chiudi_gioco_Click(object sender, EventArgs e) //Evento generato dal click dell'oggetto.
        {
            Application.Exit(); //Questo metodo chiude il programma.
        }
    }
}
