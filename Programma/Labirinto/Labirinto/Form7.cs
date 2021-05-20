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
        int contatorePipistrello = 0;
        bool verifica = false;
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
        { 455, 657 },{ 455, 613 },{ 455, 555 },  { 489, 523 }, /*Percorso in basso { 517, 555 }, { 549, 587 }, { 581, 616 }, { 615, 585 },
        { 647, 556 },*/ /*Percorso in alto*/ { 520, 493 }, { 552, 465 }, { 584, 435 }, { 616, 465 }, { 647, 495 }, /*Ritorno al percorso normale*/ { 678, 526 }, { 758, 583 }, { 802, 583 }, { 802, 539 }, { 798, 491 }, { 766, 463 }, { 735, 433 }, { 702, 404 }, { 667, 375 }, { 617, 353 }, { 573, 353 },
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
            var conferma = MessageBox.Show("Sei sicuro di voler uscire dal gioco?\nSappi che i progressi della partita non verranno salvati...", "Chiusura gioco", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (conferma == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void indietroTStripMenuItem_Click(object sender, EventArgs e)
        {
            var conferma = MessageBox.Show("Sei sicuro di voler tornare al menu principale?\nSappi che i progressi della partita non verrranno salvati...", "Ritorno al menu principale", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (conferma == DialogResult.Yes)
            {
                formSchermataIniziale Form2 = new formSchermataIniziale();
                Form2.Show();
                this.Hide();
            }
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
            if (scelteGioco[numGiocatore, 0] != "G2" && scelteGioco[numGiocatore, 0] != "G3" && scelteGioco[numGiocatore, 0] != "G4")
            {
                dadiBtn.Enabled = false;
                dadiBtn.Text = "Il risultato è...";
            }
            Random random = new Random();
            int numeroCasuale = 6;// random.Next(1, 7);
            if (scelteGioco[numGiocatore, 0] != "G2" && scelteGioco[numGiocatore, 0] != "G3" && scelteGioco[numGiocatore, 0] != "G4") 
            {
                var conferma = MessageBox.Show($"Il numero che hai ottenuto è {numeroCasuale}. Premi OK per vedere cosa succederà...", "Risultato dadi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            posizionePedine[numGiocatore] += numeroCasuale;
            SpostamentoPedinaGiocatore(posizionePedine, numeroCasuale);
        }
        public void SpostamentoPedinaGiocatore(int[] posizionePedine, int numeroCasuale)
        {
            string oggettoTrovato = "";
            int contatoreOggettiIndietro = 0;
            for (int i = (posizionePedine[numGiocatore] - numeroCasuale); i <= posizionePedine[numGiocatore]; i++)
            {
                Task.Delay(850).Wait();
                if (scelteGioco[numGiocatore, 2] == "SCACCHIERA")
                {
                    pedinaVerdePicBox.Location = new Point(spostamentoPedinaVerde[i, 0], spostamentoPedinaVerde[i, 1]);
                    if (i != posizionePedine[numGiocatore] - numeroCasuale)
                    {
                        if (i == 3 && verifica == false)
                        {
                            mappaVerdePicBox.Visible = false;
                            noOggettiVerde.Visible = false;
                            string descrizioneOggetto = "Hai trovato le chiavi!";
                            TrovatiOggetti(descrizioneOggetto, oggettoTrovato);
                            oggetto1VerdePicBox.Image = Properties.Resources.chiavi;
                        }
                        else if ((i == 6 || i == 8 || i == 10 || i == 13 || i == 17 || i == 19 || i == 21 || i == 24 || i == 28) && verifica == false)
                        {
                            GeneraOggetti(ref oggettoTrovato, i);
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
                    if (i != posizionePedine[numGiocatore] - numeroCasuale )
                    {
                        if (i == 4 && verifica == false)
                        {
                            mappaRossoPicBox.Visible = false;
                            noOggettiRosso.Visible = false;
                            string descrizioneOggetto = "Hai trovato le chiavi!";
                            TrovatiOggetti(descrizioneOggetto, oggettoTrovato);
                            oggetto1RossoPicBox.Image = Properties.Resources.chiavi;
                        }
                        else if ((i == 7 || i == 11 || i == 14 || i == 18 || i == 20 || i == 22 || i == 24 || i == 26 || i == 27) && verifica == false)
                        {
                            GeneraOggetti(ref oggettoTrovato,  i);
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
                        if (i == 3 && verifica == false)
                        {
                            mappaGialloPicBox.Visible = false;
                            noOggettiGiallo.Visible = false;
                            string descrizioneOggetto = "Hai trovato le chiavi!";
                            TrovatiOggetti(descrizioneOggetto, oggettoTrovato);
                            oggetto1GialloPicBox.Image = Properties.Resources.chiavi;
                        }
                        else if ((i == 7 || i == 11 || i == 14 || i == 17 || i == 20 || i == 23 || i == 25 || i == 27 || i == 28) && verifica == false)
                        {
                            GeneraOggetti(ref oggettoTrovato,i);
                            verifica = true;
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
                        if (i == 4 && verifica == false)
                        {
                            mappaBluPicBox.Visible = false;
                            noOggettiBlu.Visible = false;
                            string descrizioneOggetto = "Hai trovato le chiavi!";
                            TrovatiOggetti(descrizioneOggetto, oggettoTrovato);
                            oggetto1BluPicBox.Image = Properties.Resources.chiavi;
                        }
                        else if ((i == 7 || i == 9 || i == 11 || i == 13 || i == 16 || i == 19 || i == 22 || i == 25 || i == 27) && verifica == false) 
                        {
                            GeneraOggetti(ref oggettoTrovato, i);
                        }
                        else if (i == 30)
                        {
                            break;
                        }
                    }
                }
                if (oggettoTrovato == "FANTASMA")
                {
                    if (contatoreOggettiIndietro == 1)
                    {
                        break;
                    }
                    verifica = true;
                    posizionePedine[numGiocatore] = i - 1;
                    i = posizionePedine[numGiocatore] - 1;
                    contatoreOggettiIndietro++;
                }
                else if (oggettoTrovato == "DRAGO")
                {
                    if (contatoreOggettiIndietro == 2)
                    {
                        break;
                    }
                    verifica = true;
                    posizionePedine[numGiocatore] = i - 1;
                    i = posizionePedine[numGiocatore] - 1;
                    contatoreOggettiIndietro++;
                }
                else if (oggettoTrovato == "PIPISTRELLO")
                {
                    if (contatoreOggettiIndietro == 3)
                    {
                        contatorePipistrello++;
                        if (contatorePipistrello <= 4)
                        {
                            if (posizionePedine[numGiocatore] == 0 && contatorePipistrello < 4)  
                            {
                                numGiocatore = contatorePipistrello;
                                SpostamentoPedinaGiocatore(posizionePedine, numeroCasuale);
                            }
                            else if (posizionePedine[numGiocatore] == 0 && contatorePipistrello == 4)
                            {
                                break;
                            }
                            else
                            {
                                numGiocatore = contatorePipistrello - 1;
                                SpostamentoPedinaGiocatore(posizionePedine, numeroCasuale);
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    verifica = true;
                    posizionePedine[numGiocatore] = i - 1;
                    i = posizionePedine[numGiocatore] - 1;
                    contatoreOggettiIndietro++;
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
        public void GeneraOggetti(ref string oggettoTrovato, int i)
        {
            var messaggio = DialogResult.Cancel;
            Random random = new Random();
            int numeroCasuale2 = 0;
            if (contatorePipistrello == 0) 
            {
                numeroCasuale2 = 8; //random.Next(1, 18);
            }
            contatorePipistrello++;
            var immagine = Properties.Resources.sfondo;
            if (numeroCasuale2 == 1)
            {
                immagine = Properties.Resources.fantasma;
                oggettoTrovato = "FANTASMA";
                string descrizioneOggetto = "NO! HAI INCONTRATO UN FANTASMA! Pensavi non esistessero, ma ti tocca retrocedere di una casella...";
                TrovatiOggetti(descrizioneOggetto, oggettoTrovato);
            }
            else if (numeroCasuale2 == 2)
            {
                immagine = Properties.Resources.drago;
                oggettoTrovato = "DRAGO";
                string descrizioneOggetto = "AH, CHE DOLORE! Il getto di fuoco del drago ti colpisce e tu retrocederi di due caselle...";
                TrovatiOggetti(descrizioneOggetto, oggettoTrovato);
            }
            else if (numeroCasuale2 == 3)
            {
                immagine = Properties.Resources.pipistrello;
                oggettoTrovato = "PIPISTRELLO";
                string descrizioneOggetto = "Pipistrelli...vi sembravano tanto innocui, eh! Ma adesso, solamente per colpa di uno degli esploratori, fate scatenare la loro ira e vi fanno retrocedere tutti di tre caselle!";
                TrovatiOggetti(descrizioneOggetto, oggettoTrovato);
            }
            else if (numeroCasuale2 == 4)
            {
                immagine = Properties.Resources.morte;
                oggettoTrovato = "MORTE";
                string descrizioneOggetto = "Cos'è!? OSSA UMANE!? Resti di esploratori del passato sono rimasti nel Labirinto, ti viene una fifa blu e svieni per lo spavento, restando così fermo per due giri...";
                TrovatiOggetti(descrizioneOggetto, oggettoTrovato);
            }
            else if (numeroCasuale2 == 5)
            {
                immagine = Properties.Resources.geniolampada;
                oggettoTrovato = "GENIOLAMPADA";
                if (scelteGioco[numGiocatore, 0] == "G2" || scelteGioco[numGiocatore, 0] == "G3" || scelteGioco[numGiocatore, 0] == "G4")
                {
                    int numeroCasuale = random.Next(0, 2);
                    if (numeroCasuale == 0)
                    {
                        messaggio = DialogResult.Yes;
                        if (numGiocatore < 4)
                        {
                            MessageBox.Show($"{scelteGioco[numGiocatore, 0]}, durante il suo percorso, mi ha incontrato: la buona sorte non ha certo colpito {scelteGioco[numGiocatore + 1, 0]}, che salta il suo giro e sa con chi prendersela...", "Parla il Genio della Lampada...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show($"{scelteGioco[numGiocatore, 0]}, durante il suo percorso, mi ha incontrato: la buona sorte non ha certo colpito {scelteGioco[0, 0]}, che salta il suo giro e sa con chi prendersela...", "Parla il Genio della Lampada...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else
                    {
                        if (numGiocatore < 4)
                        {
                            MessageBox.Show($"{scelteGioco[numGiocatore + 1, 0]}, ringrazia {scelteGioco[numGiocatore, 0]}, che mi ha incontrato e ha scelto di non farti fermare per un giro!", "Parla il Genio della Lampada...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show($"{scelteGioco[0, 0]}, ringrazia {scelteGioco[numGiocatore, 0]}, che mi ha incontrato e ha scelto di non farti fermare per un giro!", "Parla il Genio della Lampada...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
                else
                {
                    messaggio = MessageBox.Show("Hai trovato il Genio della Lampada, che ti offre solo un desiderio da esaudire: se vuoi premi Sì per interrompere il giro del giocatore seguente, oppure premi NO per non far nulla...", "Oggetto trovato!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                }
            }
            else if (numeroCasuale2 == 6)
            {
                immagine = Properties.Resources.fata;
                oggettoTrovato = "FATA";
                string descrizioneOggetto = "Che fortuna! Uno degli esploratori ha incontrato la Magica Fata! Avanzate tutti di tre caselle!";
                TrovatiOggetti(descrizioneOggetto, oggettoTrovato);
                for (int j = 0; j < 4; j++)
                {
                   posizionePedine[j] += 3;
                }
            }
            else if (numeroCasuale2 == 7)
            {
                immagine = Properties.Resources.stranomino;
                oggettoTrovato = "STRANOMINO";
                string descrizioneOggetto = "A prima vista sembra un cattivo, ma in realtà è tuo amico! Lo Stranomino Amico ti fa avanzare di due caselle!";
                TrovatiOggetti(descrizioneOggetto, oggettoTrovato);
                posizionePedine[numGiocatore] += 2;
            }
            else if (numeroCasuale2 == 8)
            {
                immagine = Properties.Resources.civetta;
                oggettoTrovato = "CIVETTA";
                string descrizioneOggetto = "Hai trovato la civetta, che ti prende con sé per portarti avanti! Però, siccome sei un po' pesante, ti fa avanzare di una sola casella...";
                TrovatiOggetti(descrizioneOggetto, oggettoTrovato);
                posizionePedine[numGiocatore] += 1;
            }
            else if (numeroCasuale2 == 9)
            {
                immagine = Properties.Resources.spada;
                oggettoTrovato = "SPADA";
                string descrizioneOggetto = "Hai trovato una spada, che forse ti sarà utile se voi esploratori dovrete decidere di chi sarà il tesoro...";
                TrovatiOggetti(descrizioneOggetto, oggettoTrovato);
            }
            else if (numeroCasuale2 == 10)
            {
                immagine = Properties.Resources.candelabro;
                oggettoTrovato = "CANDELABRO";
                string descrizioneOggetto = "Bene! Farti un po' di luce nell'oscurità del labirinto sarà un buon modo per usare il candelabro che hai appena trovato.";
                TrovatiOggetti(descrizioneOggetto, oggettoTrovato);
            }
            else if (numeroCasuale2 == 11)
            {
                immagine = Properties.Resources.libro_magico;
                oggettoTrovato = "LIBROMAGICO";
                string descrizioneOggetto = "Le conoscenze più profonde sul labirinto sono contenute qui: complimenti per aver trovato il libro magico!";
                TrovatiOggetti(descrizioneOggetto, oggettoTrovato);
            }
            else if (numeroCasuale2 == 12)
            {
                immagine = Properties.Resources.scarabeo;
                oggettoTrovato = "SCARABEO";
                string descrizioneOggetto = "Hai trovato un simpatico scarabeo blu, che non ti porta né buona né cattiva sorte...";
                TrovatiOggetti(descrizioneOggetto, oggettoTrovato);
            }
            else if (numeroCasuale2 == 13)
            {
                immagine = Properties.Resources.topo;
                oggettoTrovato = "TOPO";
                string descrizioneOggetto = "AH UN TOPO! Forse di loro hai un po' paura, ma alla fine non ti fanno nulla...";
                TrovatiOggetti(descrizioneOggetto, oggettoTrovato);
            }
            else if (numeroCasuale2 == 14)
            {
                immagine = Properties.Resources.ragno;
                oggettoTrovato = "RAGNO";
                string descrizioneOggetto = "Nell'angolo del muro hai trovato un ragno...Stai attento che non ti si appicichino le sue ragnatele!";
                TrovatiOggetti(descrizioneOggetto, oggettoTrovato);
            }
            else if (numeroCasuale2 == 15)
            {
                immagine = Properties.Resources.anello;
                oggettoTrovato = "ANELLO";
                string descrizioneOggetto = "Hai trovato un anello, che se vuoi puoi mettere subito, oppure lo puoi per una proposta di matrimonio!";
                TrovatiOggetti(descrizioneOggetto, oggettoTrovato);
            }
            else if (numeroCasuale2 == 16)
            {
                immagine = Properties.Resources.saccoro;
                oggettoTrovato = "SACCORO";
                string descrizioneOggetto = "Un po' di mancia in anticipo non fa male! Hai trovato un sacco pieno di monete d'oro!";
                TrovatiOggetti(descrizioneOggetto, oggettoTrovato);
            }
            else if (numeroCasuale2 == 17)
            {
                immagine = Properties.Resources.smeraldo;
                oggettoTrovato = "SMERALDO";
                string descrizioneOggetto = "OH, uno smeraldo! Pensi WOW ma una volta che troverai il tesoro vedrai quanti WOW, sempre che tu ce la faccia...";
                TrovatiOggetti(descrizioneOggetto, oggettoTrovato );
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
        public void TrovatiOggetti(string descrizioneOggetto, string oggettoTrovato)
        {
            if ((scelteGioco[numGiocatore, 0] != "G2" && scelteGioco[numGiocatore, 0] != "G3" && scelteGioco[numGiocatore, 0] != "G4") || oggettoTrovato == "FATA" || oggettoTrovato == "PIPISTRELLO") 
            {
                MessageBox.Show(descrizioneOggetto, "Oggetto trovato!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                dadiBtn.Enabled = true; //Si rende necessario attivarlo e poi disattivarlo per poterne cambiare il testo.
                dadiBtn.Text = $"I dadi vengono \ntirati da {scelteGioco[numGiocatore,0]}";
                dadiBtn.Enabled = false;
                GenerazioneNumeroCasuale();
            }
            else
            {
                indicazioniGioco.Text = $"{scelteGioco[numGiocatore, 0]},\nè il tuo turno!";
                dadiBtn.Text = "Tira i dadi...";
                dadiBtn.Enabled = true;
            }
        }
        public void ProclamazioneVincitore()
        {

        }

    }
}
   

