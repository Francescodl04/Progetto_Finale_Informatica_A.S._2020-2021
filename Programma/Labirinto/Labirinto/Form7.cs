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
        string[,] scelteGioco = new string[4, 3];
        int[] posizionePedine = new int[4];
        int numGiocatore = 0;
        //Dichiarazione delle varie coordinate che dovranno avere le pedine.
        int[,] spostamentoPedinaVerde = { { 29, 721}, { 29,666 }, { 29,616 }, { 29,566 }, { 29,516 }, { 29,466 }, { 29,416 }, { 29,366 }, { 76,366 }
        , { 128,366 }, { 128,413 }, { 128,462 }, { 128,513  }, { 128,562 }, { 128,613 }, { 128,663  }, { 128,715  }, { 183,715 }, { 232,715 }, { 232,666 },
        { 232,616 }, { 232,566 }, { 232,516 }, { 232,467 }, { 232,417 }, { 232,369 }, { 279, 369 }, { 279, 419 }, { 330, 419}, { 330, 369 }, { 11, 193 }};
        int[,] spostamentoPedinaRossa = { { 24, 22}, { 74, 29 }, { 38, 67 }, { 74, 104 }, { 37, 142 }, { 73, 179 }, { 36, 218 }, { 73, 256 }, { 112, 219 }
        , { 151, 256 }, { 191, 218 }, { 151, 180 }, { 113, 143 }, { 152, 103 }, { 113, 68 }, { 152, 31 }, { 191, 68 }, { 230, 30 }, { 270, 67 }, { 309, 31 },
        { 350, 68 }, { 309, 106 }, { 270, 143 }, { 231, 106 }, { 191, 143 }, { 230, 179 }, { 266, 221 }, { 312, 181 }, { 312, 222}, { 312, 266 }, { 388, 282 }};
        int[,] spostamentoPedinaGialla = {{ 831, 22}, { 789, 62 }, { 754, 33 }, { 720, 62 }, { 687, 32 }, { 655, 63 }, { 624, 31 }, { 595, 62 }, { 560, 34 }
        , { 530, 65 }, { 499, 99 }, { 531, 128 }, { 562, 97 }, { 598, 126 }, { 634, 156 }, { 664, 124 }, { 695, 156 }, { 724, 124 }, { 756, 94 }, { 786, 126 },
        { 756, 156 }, { 787, 186 }, { 758, 219 }, { 727, 190 }, { 696, 221 }, { 664, 253 }, { 630, 220 }, { 601, 252 }, { 566, 224 }, { 536, 256 }, { 453, 282 } };
        int[,] spostamentoPedinaBlu = { { 831, 705 }, { 783, 705 }, { 736, 705 }, { 688, 705 }, { 641, 705 }, { 595, 705 }, { 548, 705 }, { 502, 705 }, { 455, 705 },
        { 455, 657 },{ 455, 613 },{ 455, 555 }, /*Casella di scelta*/ { 489, 523 }, /*Percorso in basso*/ { 517, 555 }, { 549, 587 }, { 581, 616 }, { 615, 585 },
        { 647, 556 }, /*Percorso in alto*/ { 520, 493 }, { 552, 465 }, { 584, 435 }, { 616, 465 }, { 647, 495 }, /*Ritorno al percorso normale*/ { 678, 526 }, { 758, 583 }, { 802, 583 }, { 802, 539 }, { 798, 491 }, { 766, 463 }, { 735, 433 }, { 702, 404 }, { 667, 375 }, { 617, 353 }, { 573, 353 },
        { 527, 353 }, { 453, 345 } };
        public formGioco(string[,] scelteGiocatori)
        {
            InitializeComponent();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    scelteGioco[i, j] = scelteGiocatori[i, j];
                }
            }
        }
        private void formGioco_Load(object sender, EventArgs e)
        {
            classificaParzialeDGView.AllowUserToAddRows = false;
            classificaParzialeDGView.AllowUserToDeleteRows = false;
            for (int i = 0; i < 4; i++)
            {
                classificaParzialeDGView.Rows.Insert(i, $"{scelteGioco[i, 0]}", "0");
            }
            for (int i = 0; i < 4; i++)
            {
                if (scelteGioco[i, 1] == "ELMO")
                {
                    SceltaPedinaElmo(i);
                }
                if (scelteGioco[i, 1] == "CORONA")
                {
                    SceltaPedinaCorona(i);
                }
                if (scelteGioco[i, 1] == "GEKO")
                {
                    SceltaPedinaGeko(i);
                }
                if (scelteGioco[i, 1] == "FALENA")
                {
                    SceltaPedinaFalena(i);
                }
            }
            Attendi();
        }
        public void SceltaPedinaElmo(int i)
        {
            if (scelteGioco[i, 1] == "ELMO" && scelteGioco[i, 2] == "SCACCHIERA")
            {
                pedinaVerdePicBox.Image = Properties.Resources.elmo_cavaliere;
            }
            else if (scelteGioco[i, 1] == "ELMO" && scelteGioco[i, 2] == "LABIRINTORE")
            {
                pedinaBluPicBox.Image = Properties.Resources.elmo_cavaliere;
            }
            else if (scelteGioco[i, 1] == "ELMO" && scelteGioco[i, 2] == "DIAMANTE")
            {
                pedinaGiallaPicBox.Image = Properties.Resources.elmo_cavaliere;
            }
            else if (scelteGioco[i, 1] == "ELMO" && scelteGioco[i, 2] == "SALISCENDI")
            {
                pedinaRossaPicBox.Image = Properties.Resources.elmo_cavaliere;
            }
        }
        public void SceltaPedinaCorona(int i)
        {
            if (scelteGioco[i, 1] == "CORONA" && scelteGioco[i, 2] == "SCACCHIERA")
            {
                pedinaVerdePicBox.Image = Properties.Resources.corona_re;
            }
            else if (scelteGioco[i, 1] == "CORONA" && scelteGioco[i, 2] == "LABIRINTORE")
            {
                pedinaBluPicBox.Image = Properties.Resources.corona_re;
            }
            else if (scelteGioco[i, 1] == "CORONA" && scelteGioco[i, 2] == "DIAMANTE")
            {
                pedinaGiallaPicBox.Image = Properties.Resources.corona_re;
            }
            else if (scelteGioco[i, 1] == "CORONA" && scelteGioco[i, 2] == "SALISCENDI")
            {
                pedinaRossaPicBox.Image = Properties.Resources.corona_re;
            }
        }
        public void SceltaPedinaGeko(int i)
        {
            if (scelteGioco[i, 1] == "GEKO" && scelteGioco[i, 2] == "SCACCHIERA")
            {
                pedinaVerdePicBox.Image = Properties.Resources.geko;
            }
            else if (scelteGioco[i, 1] == "GEKO" && scelteGioco[i, 2] == "LABIRINTORE")
            {
                pedinaBluPicBox.Image = Properties.Resources.geko;
            }
            else if (scelteGioco[i, 1] == "GEKO" && scelteGioco[i, 2] == "DIAMANTE")
            {
                pedinaGiallaPicBox.Image = Properties.Resources.geko;
            }
            else if (scelteGioco[i, 1] == "GEKO" && scelteGioco[i, 2] == "SALISCENDI")
            {
                pedinaRossaPicBox.Image = Properties.Resources.geko;
            }
        }
        public void SceltaPedinaFalena(int i)
        {
            if (scelteGioco[i, 1] == "FALENA" && scelteGioco[i, 2] == "SCACCHIERA")
            {
                pedinaVerdePicBox.Image = Properties.Resources.falena;
            }
            else if (scelteGioco[i, 1] == "FALENA" && scelteGioco[i, 2] == "LABIRINTORE")
            {
                pedinaBluPicBox.Image = Properties.Resources.falena;
            }
            else if (scelteGioco[i, 1] == "FALENA" && scelteGioco[i, 2] == "DIAMANTE")
            {
                pedinaGiallaPicBox.Image = Properties.Resources.falena;
            }
            else if (scelteGioco[i, 1] == "FALENA" && scelteGioco[i, 2] == "SALISCENDI")
            {
                pedinaRossaPicBox.Image = Properties.Resources.falena;
            }
        }
        public async void Attendi()
        {
            await Task.Delay(3000);
            Scelte();
            SceltaImmagine();
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

        private void dadiBtn_Click(object sender, EventArgs e)
        {
            GenerazioneNumeroCasuale();
        }
        public void GenerazioneNumeroCasuale()
        {
            dadiBtn.Enabled = false;
            dadiBtn.Text = "Il risultato è...";
            Random random = new Random();
            int numeroCasuale = random.Next(1, 7);
            if(scelteGioco[numGiocatore, 0] != "G2" && scelteGioco[numGiocatore, 0] != "G3" && scelteGioco[numGiocatore, 0] != "G4")
            {
                var conferma = MessageBox.Show($"Il numero che hai ottenuto è {numeroCasuale}. Premi OK per vedere cosa succederà...", "Risultato dadi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            posizionePedine[numGiocatore] += numeroCasuale;
            SpostamentoPedinaGiocatore(numeroCasuale);
        }
        public void SpostamentoPedinaGiocatore(int numeroCasuale)
        {
            for (int i = posizionePedine[numGiocatore] - numeroCasuale; i <= posizionePedine[numGiocatore]; i++)
            {
                Task.Delay(850).Wait();
                if (scelteGioco[numGiocatore, 2] == "SCACCHIERA")
                {
                    pedinaVerdePicBox.Location = new Point(spostamentoPedinaVerde[i, 0], spostamentoPedinaVerde[i, 1]);
                    if (i != posizionePedine[numGiocatore] - numeroCasuale)
                    {
                        if (i == 3)
                        {
                            mappaVerdePicBox.Visible = false;
                            noOggettiVerde.Visible = false;
                            TrovateChiavi();
                            oggetto1VerdePicBox.Image = Properties.Resources.chiavi;
                        }
                        else if (i == 6 || i == 8 || i == 10 || i == 13 || i == 17 || i == 19 || i == 21 || i == 24 || i == 28)
                        {
                            string oggettoTrovato = "";
                            GeneraOggetti(ref oggettoTrovato, ref i);
                        }
                        else if (i == 30)
                        {
                            break;
                        }
                    }
                }
                else if (scelteGioco[numGiocatore, 2] == "SALISCENDI")
                {
                    pedinaRossaPicBox.Location = new Point(spostamentoPedinaRossa[i, 0], spostamentoPedinaRossa[i, 1]);
                    if (i != posizionePedine[numGiocatore] - numeroCasuale)
                    {
                        if (i == 4)
                        {
                            mappaRossoPicBox.Visible = false;
                            noOggettiRosso.Visible = false;
                            TrovateChiavi();
                            oggetto1RossoPicBox.Image = Properties.Resources.chiavi;
                        }
                        else if (i == 7 || i == 11 || i == 14 || i == 18 || i == 20 || i == 22 || i == 24 || i == 26 || i == 27)
                        {
                            string oggettoTrovato = "";
                            GeneraOggetti(ref oggettoTrovato, ref i);
                        }
                        else if (i == 30)
                        {
                            break;
                        }
                    }
                }
                else if (scelteGioco[numGiocatore, 2] == "DIAMANTE")
                {
                    pedinaGiallaPicBox.Location = new Point(spostamentoPedinaGialla[i, 0], spostamentoPedinaGialla[i, 1]);
                    if (i != posizionePedine[numGiocatore] - numeroCasuale)
                    {
                        if (i == 3)
                        {
                            mappaGialloPicBox.Visible = false;
                            noOggettiGiallo.Visible = false;
                            TrovateChiavi();
                            oggetto1GialloPicBox.Image = Properties.Resources.chiavi;
                        }
                        else if (i == 7 || i == 11 || i == 14 || i == 17 || i == 20 || i == 23 || i == 25 || i == 27 || i == 28)
                        {
                            string oggettoTrovato = "";
                            GeneraOggetti(ref oggettoTrovato, ref i);
                        }
                        else if (i == 30)
                        {
                            break;
                        }
                    }
                }
                else if (scelteGioco[numGiocatore, 2] == "LABIRINTORE")
                {
                    pedinaBluPicBox.Location = new Point(spostamentoPedinaBlu[i, 0], spostamentoPedinaBlu[i, 1]);
                    if (i != posizionePedine[numGiocatore] - numeroCasuale)
                    {
                        if (i == 4)
                        {
                            mappaBluPicBox.Visible = false;
                            noOggettiBlu.Visible = false;
                            TrovateChiavi();
                            oggetto1BluPicBox.Image = Properties.Resources.chiavi;
                        }
                        else if (i == 7 || i == 9 || i == 11 || i == 13 || i == 16 || i == 19 || i == 22 || i == 25 || i == 27)
                        {
                            string oggettoTrovato = "";
                            GeneraOggetti(ref oggettoTrovato, ref i);
                        }
                        else if (i == 30)
                        {
                            break;
                        }
                    }
                }
            }
            Task.Delay(2500).Wait();
            classificaParzialeDGView.Rows.RemoveAt(numGiocatore);
            classificaParzialeDGView.Rows.Insert(numGiocatore, $"{scelteGioco[numGiocatore, 0]}", $"{posizionePedine[numGiocatore]}");
            numGiocatore++;
            if (numGiocatore > 3)
            {
                numGiocatore = 0;
            }
            SceltaImmagine();
            Scelte();
        }
        public void AggiungiPedine(int numeroCasuale, int i)
        {
            numeroCasuale = i;
            posizionePedine[numGiocatore] += numeroCasuale;
            SpostamentoPedinaGiocatore(numeroCasuale);
        }
        public void GeneraOggetti(ref string oggettoTrovato, ref int i)
        {
            Random random = new Random();
            int numeroCasuale2 = random.Next(1, 18);
            var immagine = Properties.Resources.sfondo;
            if (numeroCasuale2 == 1)
            {
                immagine = Properties.Resources.fantasma;
                oggettoTrovato = "FANTASMA";
                MessageBox.Show("Sapevi che esplorare un vecchio labirinto avrebbe avuto i suoi pericoli...Ora hai incontrato un fantasma, che ti fa retrocedere di una casella...", "Oggetto trovato...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (numeroCasuale2 == 2)
            {
                immagine = Properties.Resources.drago;
                oggettoTrovato = "DRAGO";
                MessageBox.Show("Non avresti mai pensato esistessoro, ma...ora hai incontrato un drago, che ti fa retrocedere di due caselle...", "Oggetto trovato...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (numeroCasuale2 == 3)
            {
                immagine = Properties.Resources.pipistrello;
                oggettoTrovato = "PIPISTRELLO";
                MessageBox.Show("Pipistrelli...pipistrelli, vi sembravano tanto innocui, ma... Adesso solamente uno vi fa retrocedere tutti di tre caselle!", "Oggetto trovato...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (numeroCasuale2 == 4)
            {
                immagine = Properties.Resources.morte;
                oggettoTrovato = "MORTE";
                MessageBox.Show("Che sfortuna! Hai trovato la morte...resti fermo per un giro...", "Oggetto trovato...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (numeroCasuale2 == 5)
            {
                immagine = Properties.Resources.geniolampada;
                oggettoTrovato = "GENIOLAMPADA";
                var messaggio = MessageBox.Show("Hai trovato il genio della lampada, che ti offre solo un desiderio da esaudire: premi Sì per interrompere il giro del giocatore seguente, oppure premi NO per non far nulla... ", "Oggetto trovato!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (messaggio == DialogResult.Yes)
                {
                    if (numGiocatore == 0 || numGiocatore == 1 || numGiocatore == 2)
                    {
                        numGiocatore++;
                    }
                    else
                    {
                        numGiocatore = 0;
                    }
                }
            }
            else if (numeroCasuale2 == 6)
            {
                immagine = Properties.Resources.fata;
                oggettoTrovato = "FATA";
                MessageBox.Show("Che fortuna! Hai incontrato la fata! Avanzate tutti di tre caselle!", "Oggetto trovato!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (numeroCasuale2 == 7)
            {
                immagine = Properties.Resources.stranomino;
                oggettoTrovato = "STRANOMINO";
                MessageBox.Show("A prima vista sembra un cattivo, ma in realtà è tuo amico! Lo Stranomino Amico ti fa avanzare di due caselle!", "Oggetto trovato!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (numeroCasuale2 == 8)
            {
                immagine = Properties.Resources.civetta;
                oggettoTrovato = "CIVETTA";
                MessageBox.Show("Hai trovato la civetta, che ti prende con sé per portarti avanti! Però, siccome sei un po' pesante, ti fa avanzare di una sola casella...", "Oggetto trovato!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (numeroCasuale2 == 9)
            {
                immagine = Properties.Resources.spada;
                oggettoTrovato = "SPADA";
                MessageBox.Show("Hai trovato una spada, che forse ti sarà utile in futuro...", "Oggetto trovato!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (numeroCasuale2 == 10)
            {
                immagine = Properties.Resources.candelabro;
                oggettoTrovato = "CANDELABRO";
                MessageBox.Show("Bene! Farti un po' di luce nell'oscurità del labirinto sarà un buon modo per usare il candelabro che hai appena trovato.", "Oggetto trovato!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (numeroCasuale2 == 11)
            {
                immagine = Properties.Resources.libro_magico;
                oggettoTrovato = "LIBROMAGICO";
                MessageBox.Show("Le conoscenze più profonde sul labirinto sono contenute qui: complimenti per aver trovato il libro magico!", "Oggetto trovato!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (numeroCasuale2 == 12)
            {
                immagine = Properties.Resources.scarabeo;
                oggettoTrovato = "SCARABEO";
                MessageBox.Show("Hai trovato un simpatico scarabeo blu, che non ti porta vantaggi né svantaggi...", "Oggetto trovato!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (numeroCasuale2 == 13)
            {
                immagine = Properties.Resources.topo;
                oggettoTrovato = "TOPO";
                MessageBox.Show("AH UN TOPO! Forse di loro hai un po' paura, ma alla fine non ti fanno nulla...", "Oggetto trovato!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (numeroCasuale2 == 14)
            {
                immagine = Properties.Resources.ragno;
                oggettoTrovato = "RAGNO";
                MessageBox.Show("Dopo tanti anni che è chiuso, nel labirinto ci sono tanti ragni...Stai attento a non sbattere la testa contro le ragnatele!", "Oggetto trovato!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (numeroCasuale2 == 15)
            {
                immagine = Properties.Resources.anello;
                oggettoTrovato = "ANELLO";
                MessageBox.Show("Hai trovato un anello, che il tuo esploratore potrà mettere al dito di sua moglie...sempre che esca dal labirinto!", "Oggetto trovato!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (numeroCasuale2 == 16)
            {
                immagine = Properties.Resources.saccoro;
                oggettoTrovato = "SACCORO";
                MessageBox.Show("Un po' di mancia in anticipo non fa male! Hai trovato un sacco pieno di monete d'oro!", "Oggetto trovato!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (numeroCasuale2 == 17)
            {
                immagine = Properties.Resources.smeraldo;
                oggettoTrovato = "SMERALDO";
                MessageBox.Show("Una pietra preziosa come uno smeraldo non è così semplice da trovare!", "Oggetto trovato!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (scelteGioco[numGiocatore, 2] == "SCACCHIERA")
            {
                if (i == 6)
                {
                    oggetto2VerdePicBox.Image = immagine;
                }
                else if (i == 8)
                {
                    oggetto3VerdePicBox.Image = immagine;
                }
                else if (i == 10)
                {
                    oggetto4VerdePicBox.Image = immagine;

                }
                else if (i == 13)
                {
                    oggetto5VerdePicBox.Image = immagine;
                }
                else if (i == 17)
                {
                    oggetto6VerdePicBox.Image = immagine;
                }
                else if (i == 19)
                {
                    oggetto7VerdePicBox.Image = immagine;
                }
                else if (i == 21)
                {
                    oggetto8VerdePicBox.Image = immagine;
                }
                else if (i == 24)
                {
                    oggetto9VerdePicBox.Image = immagine;
                }
                else if (i == 28)
                {
                    oggetto10VerdePicBox.Image = immagine;
                }
            }
            if (scelteGioco[numGiocatore, 2] == "SALISCENDI")
            {
                if (i == 7)
                {
                    oggetto2RossoPicBox.Image = immagine;
                }
                else if (i == 11)
                {
                    oggetto3RossoPicBox.Image = immagine;
                }
                else if (i == 14)
                {
                    oggetto4RossoPicBox.Image = immagine;

                }
                else if (i == 18)
                {
                    oggetto5RossoPicBox.Image = immagine;
                }
                else if (i == 20)
                {
                    oggetto6RossoPicBox.Image = immagine;
                }
                else if (i == 22)
                {
                    oggetto7RossoPicBox.Image = immagine;
                }
                else if (i == 24)
                {
                    oggetto8RossoPicBox.Image = immagine;
                }
                else if (i == 26)
                {
                    oggetto9RossoPicBox.Image = immagine;
                }
                else if (i == 27)
                {
                    oggetto10RossoPicBox.Image = immagine;
                }
            }
            if (scelteGioco[numGiocatore, 2] == "DIAMANTE")
            {
                if (i == 7)
                {
                    oggetto2GialloPicBox.Image = immagine;
                }
                else if (i == 11)
                {
                    oggetto3GialloPicBox.Image = immagine;
                }
                else if (i == 14)
                {
                    oggetto4GialloPicBox.Image = immagine;

                }
                else if (i == 17)
                {
                    oggetto5GialloPicBox.Image = immagine;
                }
                else if (i == 20)
                {
                    oggetto6GialloPicBox.Image = immagine;
                }
                else if (i == 23)
                {
                    oggetto7GialloPicBox.Image = immagine;
                }
                else if (i == 25)
                {
                    oggetto8GialloPicBox.Image = immagine;
                }
                else if (i == 27)
                {
                    oggetto9GialloPicBox.Image = immagine;
                }
                else if (i == 28)
                {
                    oggetto10GialloPicBox.Image = immagine;
                }
            }
            if (scelteGioco[numGiocatore, 2] == "LABIRINTORE")
            {
                if (i == 7)
                {
                    oggetto2BluPicBox.Image = immagine;
                }
                else if (i == 9)
                {
                    oggetto3BluPicBox.Image = immagine;
                }
                else if (i == 11)
                {
                    oggetto4BluPicBox.Image = immagine;

                }
                else if (i == 13)
                {
                    oggetto5BluPicBox.Image = immagine;
                }
                else if (i == 16)
                {
                    oggetto6BluPicBox.Image = immagine;
                }
                else if (i == 19)
                {
                    oggetto7BluPicBox.Image = immagine;
                }
                else if (i == 22)
                {
                    oggetto8BluPicBox.Image = immagine;
                }
                else if (i == 25)
                {
                    oggetto9BluPicBox.Image = immagine;
                }
                else if (i == 27)
                {
                    oggetto10BluPicBox.Image = immagine;
                }
            }
        }
        public void TrovateChiavi()
        {
            if (scelteGioco[numGiocatore, 0] != "G2" && scelteGioco[numGiocatore, 0] != "G3" && scelteGioco[numGiocatore, 0] != "G4")  
            {
                MessageBox.Show("Erano nascoste bene, ma le hai trovate! \nOra con le chiavi potrai aprire il forziere del tesoro!", "Oggetto trovato!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }
        public void SceltaImmagine()
        {
            if (scelteGioco[numGiocatore, 1] == "ELMO")
            {
                pedinaPicBox.Image = Properties.Resources.elmo_cavaliere;
            }
            else if (scelteGioco[numGiocatore, 1] == "CORONA")
            {
                pedinaPicBox.Image = Properties.Resources.corona_re;
            }
            else if (scelteGioco[numGiocatore, 1] == "GEKO")
            {
                pedinaPicBox.Image = Properties.Resources.geko;
            }
            else if (scelteGioco[numGiocatore, 1] == "FALENA")
            {
                pedinaPicBox.Image = Properties.Resources.falena;
            }
        }
        public void Scelte()
        {
            if (scelteGioco[numGiocatore, 0] == "G2" || scelteGioco[numGiocatore, 0] == "G3" || scelteGioco[numGiocatore, 0] == "G4")
            {
                indicazioniGioco.Text = $"È il turno di {scelteGioco[numGiocatore, 0]},\n che ora sta facendo\nla sua mossa";
                dadiBtn.Text = $"I dadi vengono \ntirati da {scelteGioco[numGiocatore,0]}";
                GenerazioneNumeroCasuale();
            }
            else
            {
                indicazioniGioco.Text = $"{scelteGioco[numGiocatore, 0]},\nè il tuo turno!";
                dadiBtn.Text = "Tira i dadi...";
                dadiBtn.Enabled = true;
            }
        }
        
    }
}
   

