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
        int numCapitolo = 0; //Variabile che conterrà il numero del capitolo delle istruzioni selezionato dall'utente nel form precedente.
        string[,] datiIstruzioni = new string[9, 2]; //Matrice che conterrà le istruzioni del gioco, prelevate da file.
        public formLetturaIstruzioni(int numeroCapitolo) //Inizializza il form.
        {
            InitializeComponent();
            numCapitolo = numeroCapitolo;
        }
        private void formLetturaIstruzioni_Load(object sender, EventArgs e) //Al caricamento del form, prende da file istruzioni di gioco.
        {
            string istruzioni = ""; //Variabile che conterrà tutto il testo provenente dal file di salvataggio delle istruzioni.
            try //Prova a leggere il file con il metodo File.ReadAllText();
            {
                istruzioni = File.ReadAllText(@"C:\Labirinto\istruzioni.txt");
            }
            //Gestisce le varie eccezioni che si possono presentare.
            catch (FileNotFoundException)
            {
                Errore();
            }
            catch(DirectoryNotFoundException)
            {
                Errore();
            }
            catch(UnauthorizedAccessException)
            {
                Errore();
            }
            catch(IOException)
            {
                Errore();
            }
            char carattereDivisore = '|'; 
            string[] elementiIstruzioni = istruzioni.Split(carattereDivisore); //Divide il contenuto della stringa istruzioni con la variabile char carattereDivisore.
            int n = 0; //Variabile contatore necessaria da indice.
            //Con questo ciclo inserisce le istruzioni nel nuovo array bidimensionale datiIstruzioni.
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
        public void TestoImmagini() //Funzione che permette la visualizzazione del testo delle istruzioni nella casella di testo.
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
        public void Errore() //Funzione richiamata in caso di presenza di eccezioni nella lettura del file.
        {
            MessageBox.Show("Non è stato possibile leggere il file del manuale di istruzioni. Premi Ok per riavviare il programa ed eventualemente rivolgiti al supporto tecnico per ottenere un nuovo manuale d'uso...", "Lettura file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Restart();
        }

        //Eventi generati con il click del mouse.
        private void indietroPicBox_Click(object sender, EventArgs e)
        {
            formCapitoliIstruzioni Form5 = new formCapitoliIstruzioni(); //Inizializza il nuovo form.
            Form5.Show(); //Visualizza il nuovo form.
            this.Hide(); //Chiude il form corrente.
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

        private void formLetturaIstruzioni_FormClosed(object sender, FormClosedEventArgs e) //Evento generato alla chiusura del form.
        {
            Application.Exit(); //Chiude completamente il programma.
        }
    }
}
