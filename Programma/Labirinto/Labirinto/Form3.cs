//Autore: Francesco Di Lena
//Classe: 3F
//Data: aprile-maggio 2021
//Progetto finale di informatica: "Il Gioco del Labirinto".
//Schermata di scelta del numero di giocatori.

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
    public partial class formSceltaGiocatori : Form
    {
        public int numeroGiocatori = 0; //Variabile che tiene conto del numero di giocatori selezionato.
        public formSceltaGiocatori()
        {
            InitializeComponent();
        }
        //Se si fa click sopra questi oggetti, allora esegue le seguenti operazioni per ognuno di essi.
        private void unoBtn_Click(object sender, EventArgs e) 
        {
            numeroGiocatori = 1;
            SchermataSuccessiva();
        }

        private void dueBtn_Click(object sender, EventArgs e) 
        {
            numeroGiocatori = 2;
            SchermataSuccessiva();
        }

        private void treBtn_Click(object sender, EventArgs e) 
        {
            numeroGiocatori = 3;
            SchermataSuccessiva();
        }

        private void quattroBtn_Click(object sender, EventArgs e) 
        {
            numeroGiocatori = 4;
            SchermataSuccessiva();
        }
        
        private void SchermataSuccessiva() //Funzione che passa alla schermata successiva, passando il valore al nuovo form di numeroGiocatori.
        {
            formScelteGioco form4 = new formScelteGioco(numeroGiocatori); //Inizializza il form.
            form4.Show(); //Visualizza il nuovo form.
            this.Hide(); //Chiude il form corrente.
        }
        private void indietroPicBox_Click(object sender, EventArgs e)
        {
            formSchermataIniziale Form2 = new formSchermataIniziale();
            Form2.Show();
            this.Hide();
        }
        //Se si pone il mouse sopra questi oggetti, allora genera i seguenti eventi per ognuno di essi.
        private void unoPicBox_MouseHover(object sender, EventArgs e) 
        {
            //Rende visibile solamente il primo pulsante.
            unoBtn.Visible = true;
            dueBtn.Visible = false;
            treBtn.Visible = false;
            quattroBtn.Visible = false;
        }

        private void duePicBox_MouseHover(object sender, EventArgs e) 
        {
            //Rende visibile solamente il secondo pulsante.
            unoBtn.Visible = false;
            dueBtn.Visible = true;
            treBtn.Visible = false;
            quattroBtn.Visible = false;
        }

        private void trePicBox_MouseHover(object sender, EventArgs e)
        {
            //Rende visibile solamente il terzo pulsante.
            unoBtn.Visible = false;
            dueBtn.Visible = false;
            treBtn.Visible = true;
            quattroBtn.Visible = false;
        }

        private void quattroPicBox_MouseHover(object sender, EventArgs e)
        {
            //Rende visibile solamente il quarto pulsante.
            unoBtn.Visible = false;
            dueBtn.Visible = false;
            treBtn.Visible = false;
            quattroBtn.Visible = true;
        }
        
        private void salvataggio_FormClosed(object sender, FormClosedEventArgs e) //Evento generato dal click dalla chiusura del form.
        {
            Application.Exit(); //Chiude completamente il programma.
        }
    }
}
