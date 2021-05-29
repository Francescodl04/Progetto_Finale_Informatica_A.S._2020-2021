//Autore: Francesco Di Lena
//Classe: 3F
//Data: aprile-maggio 2021
//Progetto finale di informatica: "Il Gioco del Labirinto".
//Schermata delle scelte di ogni giocatore.

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
    public partial class formScelteGioco : Form
    {
        string sceltaPedina = ""; //Variabile che conterrà il nome della pedina scelta dal giocatore.
        string sceltaTabellone = ""; //Variabile che conterrà il nome del tabellone scelto dal giocatore.
        int contatoreGiocatore = 1; //Variabile che terrà conto del numero di giocatore a cui si è arrivati nelle scelte.
        int numGiocatori = 1; //Variabile che conterrà il numero di giocatori selezionato nel form precedente.
        string[,] scelteGiocatori = new string[4, 3]; //Matrice che conterrà le scelte di tutte i giocatori (reali e non), ovvero nome, pedina e tabellone.
        int riga = 0; //Variabile che tiene conto del numero di riga dell'array scelteGiocatori a cui si dovrà accedere successivamente.
        public formScelteGioco(int numeroGiocatori) //Inizializza il form e trasferisce il valore di numeroGiocatori in una nuova variabile utilizzabile in tutto il codice.
        {
            InitializeComponent();
            numGiocatori = numeroGiocatori;
        }
        private void confermaBtn_Click(object sender, EventArgs e) //Evento generato dal click del bottone confermaBtn.
        {
            //I primi due (if e else if) sono controlli preventivi per individuare eventuali errori, mentre il terzo (else) salva nell'array scelteGioco le scelte dei giocatori corrette.
            if (nomeTxt.Text == "Inserisci qui il tuo nome..." || nomeTxt.Text == "" || (elmoRadBtn.Checked == false && coronaRadBtn.Checked == false
                && gekoRadBtn.Checked == false && falenaRadBtn.Checked == false) || (scacchieraRadBtn.Checked == false && saliScendiRadBtn.Checked == false
                && diamanteRadBtn.Checked == false && labirintoReRadBtn.Checked == false))
            {
                MessageBox.Show("Non hai inserito il tuo nome oppure non hai scelto \nuno o entrambi gli oggetti. Inseriscili, altrimenti non potrai giocare...", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nomeTxt.Text == "G1" || nomeTxt.Text == "g1" || nomeTxt.Text == "G2" || nomeTxt.Text == "g2"
                     || nomeTxt.Text == "G3" || nomeTxt.Text == "g3" || nomeTxt.Text == "G4" || nomeTxt.Text == "g4")
            {
                MessageBox.Show("Non puoi inserire questo tipo di nome. \nInseriscine un altro...", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nomeTxt.Clear();
            }
            else
            {
                var conferma = MessageBox.Show("Sei sicuro di voler confermare i tuoi dati?", "Conferma...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (conferma == DialogResult.Yes)
                {
                    //Disattiva i bottoni selezionati dal giocatore.
                    if (sceltaPedina == "ELMO")
                    {
                        elmoRadBtn.Checked = false;
                        elmoRadBtn.Enabled = false;
                    }
                    else if (sceltaPedina == "CORONA")
                    {
                        coronaRadBtn.Checked = false;
                        coronaRadBtn.Enabled = false;
                    }
                    else if (sceltaPedina == "GEKO")
                    {
                        gekoRadBtn.Checked = false;
                        gekoRadBtn.Enabled = false;
                    }
                    else if (sceltaPedina == "FALENA")
                    {
                        falenaRadBtn.Checked = false;
                        falenaRadBtn.Enabled = false;
                    }
                    if (sceltaTabellone == "SCACCHIERA")
                    {
                        scacchieraRadBtn.Checked = false;
                        scacchieraRadBtn.Enabled = false;
                    }
                    else if (sceltaTabellone == "SALISCENDI")
                    {
                        saliScendiRadBtn.Checked = false;
                        saliScendiRadBtn.Enabled = false;
                    }
                    else if (sceltaTabellone == "DIAMANTE")
                    {
                        diamanteRadBtn.Checked = false;
                        diamanteRadBtn.Enabled = false;
                    }
                    else if (sceltaTabellone == "LABIRINTORE")
                    {
                        labirintoReRadBtn.Checked = false;
                        labirintoReRadBtn.Enabled = false;
                    }
                    scelteGiocatori[riga, 0] = nomeTxt.Text;
                    scelteGiocatori[riga, 1] = sceltaPedina;
                    scelteGiocatori[riga, 2] = sceltaTabellone;
                    if (contatoreGiocatore == numGiocatori && numGiocatori != 4) //Se ci sono giocatori da gestire con il computer, allora genera le scelte casualmente.
                    {
                        Random random = new Random(); //Crea una classe Random.
                        for (int i = numGiocatori; i < 4; i++)
                        {
                            bool collisioni = false; //Variabile necessaria per individuare se sono presenti o meno collisioni nella generazione casuale.
                            scelteGiocatori[i, 0] = $"G{i + 1}";
                            do
                            {
                                collisioni = false;
                                int numeroCasuale = random.Next(0, 4); //Viene generato il numero casuale.
                                if (numeroCasuale == 0)
                                {
                                    sceltaPedina = "ELMO";
                                }
                                else if (numeroCasuale == 1)
                                {
                                    sceltaPedina = "CORONA";
                                }
                                else if (numeroCasuale == 2)
                                {
                                    sceltaPedina = "GEKO";
                                }
                                else if (numeroCasuale == 3)
                                {
                                    sceltaPedina = "FALENA";
                                }
                                for (int j = 0; j < 4; j++)
                                {
                                    if (sceltaPedina == scelteGiocatori[j, 1])
                                    {
                                        collisioni = true;
                                    }
                                }
                            }
                            while (collisioni == true);
                            scelteGiocatori[i, 1] = sceltaPedina;
                            do
                            {
                                collisioni = false;
                                int numeroCasuale = random.Next(0, 4);
                                if (numeroCasuale == 0)
                                {
                                    sceltaTabellone = "SCACCHIERA";
                                }
                                else if (numeroCasuale == 1)
                                {
                                    sceltaTabellone = "SALISCENDI";
                                }
                                else if (numeroCasuale == 2)
                                {
                                    sceltaTabellone = "DIAMANTE";
                                }
                                else if (numeroCasuale == 3)
                                {
                                    sceltaTabellone = "LABIRINTORE";
                                }
                                for (int j = 0; j < 4; j++)
                                {
                                    if (sceltaTabellone == scelteGiocatori[j, 2])
                                    {
                                        collisioni = true;
                                    }
                                }
                            }
                            while (collisioni == true);
                            scelteGiocatori[i, 2] = sceltaTabellone;
                        }
                        ChiudiForm();
                    }
                    if (contatoreGiocatore == numGiocatori && numGiocatori == 4)
                    {
                        ChiudiForm();
                    }
                    contatoreGiocatore++;
                    riga++;
                    indicazioniGioco.Text = $"Giocatore {contatoreGiocatore}, effettua le tue scelte...";
                    nomeTxt.Text = "Inserisci qui il tuo nome...";
                    descrizionePedina.Text = "Scegli una pedina: qui ne verrà visualizzata \nla descrizione...";
                    descrizioneTabellone.Text = "Scegli un tabellone: qui ne verrà visualizzata \nla descrizione...";
                    //Le immagini delle due PictureBox vengono annullate.
                    pedinaPicBox.Image = null;
                    tabellonePicBox.Image = null;
                }
            }
        }
        public void ChiudiForm() //Funzione che permette di accedere al form di gioco.
        {
            MessageBox.Show("Ora siete pronti per giocare al Labirinto! \nPremete OK per proseguire...", "Pronti!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            formGioco Form7 = new formGioco(scelteGiocatori); //Viene inizializzato il nuovo form.
            Form7.Show(); //Si mostra il nuovo form.
            this.Hide(); //Il form corrente viene chiuso.
        }
        //Serie di eventi generati al click di uno degli oggetti RadioButton, che visualizzano contemporaneamente una nuova descrizione dell'oggetto e un'immagine rappresentativa.
        private void elmoRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            descrizionePedina.Text = "Buona scelta! Non temerai nulla con l'Elmo del \nCavaliere, supererai qualsiasi ostacolo!";
            sceltaPedina = "ELMO";
            pedinaPicBox.Image = Properties.Resources.elmo_cavaliere;
        }

        private void coronaRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            descrizionePedina.Text = "Buona scelta! Indossa la corona per un percorso \nda vero Re!";
            sceltaPedina = "CORONA";
            pedinaPicBox.Image = Properties.Resources.corona_re;
        }

        private void gekoRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            descrizionePedina.Text = "Buona scelta! Corri lungo il percorso e mimetizzati \ncome il Geko del labirinto!";
            sceltaPedina = "GEKO";
            pedinaPicBox.Image = Properties.Resources.geko;
        }

        private void falenaRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            descrizionePedina.Text = "Buona scelta! Spostati con l'agilità di una falena \nche trova sempre la luce in fondo al labirinto!";
            sceltaPedina = "FALENA";
            pedinaPicBox.Image = Properties.Resources.falena;
        }

        private void scacchieraRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            descrizioneTabellone.Text = "Mettiti alla prova con un percorso non molto \ndifficile fisicamente, ma dove dovrai pensare molto...";
            sceltaTabellone = "SCACCHIERA";
            tabellonePicBox.Image = Properties.Resources.scacchiera1;
        }

        private void saliScendiRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            descrizioneTabellone.Text = "Scala le alte pareti del labirinto per \nraggiungere il tesoro!";
            sceltaTabellone = "SALISCENDI";
            tabellonePicBox.Image = Properties.Resources.saliscendi;
        }

        private void diamanteRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            descrizioneTabellone.Text = "Un labirinto dalla forma preziosa, forse tanto quanto \nquello che troverai alla fine...Esploralo!";
            sceltaTabellone = "DIAMANTE";
            tabellonePicBox.Image = Properties.Resources.diamante;
        }

        private void labirintoReRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            descrizioneTabellone.Text = "Il prezioso labirinto creato dal re...Scegli la strada \nmigliore da affrontare in questo percorso misterioso...";
            sceltaTabellone = "LABIRINTORE";
            tabellonePicBox.Image = Properties.Resources.labirintore;
        }
        private void formScelteGioco_FormClosed(object sender, FormClosedEventArgs e) //Evento generato dalla chiusura del form.
        {
            Application.Exit(); //Chiude completamente il programma.
        }

        private void indietroPicBox_Click(object sender, EventArgs e) //Evento generato dal click di indietroPicBox.
        {
            formSceltaGiocatori Form3 = new formSceltaGiocatori(); //Inizializza il nuovo form.
            Form3.Show(); //Visualizza il nuovo form.
            this.Hide(); //Nasconde il form corrente.
        }

        private void nomeTxt_Click(object sender, EventArgs e) //Evento generato dal click di nomeTxt.
        {
            nomeTxt.Clear(); //Il contenuto della casella di testo viene eliminato.
        }

        private void nomeTxt_TextChanged(object sender, EventArgs e) //Evento generato dal cambio di testo di nomeTxt.
        {
            //Se il testo della casella di testo contiene uno dei caratteri non consentiti, allora lo elimina con il metodo String.Trim.
            if (nomeTxt.Text.Contains('\n')) 
            {
                nomeTxt.Text = nomeTxt.Text.Trim('\n');
            }
            else if(nomeTxt.Text.Contains(':'))
            {
                nomeTxt.Text = nomeTxt.Text.Trim(':');
            }
        }
    }
}
