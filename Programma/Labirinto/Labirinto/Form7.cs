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
                    if (i == 3 || i == 6 || i == 8 || i == 10 || i == 13 || i == 17 || i == 19 || i == 21 || i == 24 || i == 28)
                    {
                        string oggettoTrovato = "";
                        GeneraOggetti(ref oggettoTrovato, i);
                    }
                    else if (i == 30)
                    {
                        break;
                    }
                }
                else if (scelteGioco[numGiocatore, 2] == "SALISCENDI")
                {
                    pedinaRossaPicBox.Location = new Point(spostamentoPedinaRossa[i, 0], spostamentoPedinaRossa[i, 1]);
                    if (i == 4 || i == 7 || i == 11 || i == 14 || i == 18 || i == 20 || i == 22 || i == 24 || i == 26 || i == 27)
                    {
                        string oggettoTrovato = "";
                        GeneraOggetti(ref oggettoTrovato, i);
                    }
                    else if (i == 30)
                    {
                        break;
                    }
                }
                else if (scelteGioco[numGiocatore, 2] == "DIAMANTE")
                {
                    pedinaGiallaPicBox.Location = new Point(spostamentoPedinaGialla[i, 0], spostamentoPedinaGialla[i, 1]);
                    if (i == 3 || i == 7 || i == 11 || i == 14 || i == 17 || i == 20 || i == 23 || i == 25 || i == 27 || i == 28)
                    {
                        string oggettoTrovato = "";
                        GeneraOggetti(ref oggettoTrovato, i);
                    }
                    else if (i == 30)
                    {
                        break;
                    }
                }
                else if (scelteGioco[numGiocatore, 2] == "LABIRINTORE")
                {
                    pedinaBluPicBox.Location = new Point(spostamentoPedinaBlu[i, 0], spostamentoPedinaBlu[i, 1]);
                    if (i == 4 || i == 7 || i == 9 || i == 11 || i == 13 || i == 16 || i == 19 || i == 22 || i == 25 || i == 27)
                    {
                        string oggettoTrovato = "";
                        GeneraOggetti(ref oggettoTrovato, i);
                    }
                    else if (i == 30)
                    {
                        break;
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
        public void GeneraOggetti(ref string oggettoTrovato, int i)
        {
            Random random = new Random();
            int numeroCasuale2 = random.Next(1, 19);
            var immagine = Properties.Resources.sfondo;
            if (numeroCasuale2 == 1)
            {
                immagine = Properties.Resources.chiavi;
                oggettoTrovato = "CHIAVI";
            }
            else if (numeroCasuale2 == 2)
            {
                immagine = Properties.Resources.fantasma;
                oggettoTrovato = "FANTASMA";
            }
            else if (numeroCasuale2 == 3)
            {
                immagine = Properties.Resources.drago;
                oggettoTrovato = "DRAGO";
            }
            else if (numeroCasuale2 == 4)
            {
                immagine = Properties.Resources.pipistrello;
                oggettoTrovato = "PIPISTRELLO";
            }
            else if (numeroCasuale2 == 5)
            {
                immagine = Properties.Resources.morte;
                oggettoTrovato = "MORTE";
            }
            else if (numeroCasuale2 == 6)
            {
                immagine = Properties.Resources.geniolampada;
                oggettoTrovato = "GENIOLAMPADA";
            }
            else if (numeroCasuale2 == 7)
            {
                immagine = Properties.Resources.fata;
                oggettoTrovato = "FATA";
            }
            else if (numeroCasuale2 == 8)
            {
                immagine = Properties.Resources.stranomino;
                oggettoTrovato = "STRANOMINO";
            }
            else if (numeroCasuale2 == 9)
            {
                immagine = Properties.Resources.civetta;
                oggettoTrovato = "CIVETTA";
            }
            else if (numeroCasuale2 == 10)
            {
                immagine = Properties.Resources.spada;
                oggettoTrovato = "SPADA";
            }
            else if (numeroCasuale2 == 11)
            {
                immagine = Properties.Resources.candelabro;
                oggettoTrovato = "CANDELABRO";
            }
            else if (numeroCasuale2 == 12)
            {
                immagine = Properties.Resources.libro_magico;
                oggettoTrovato = "LIBROMAGICO";
            }
            else if (numeroCasuale2 == 13)
            {
                immagine = Properties.Resources.scarabeo;
                oggettoTrovato = "SCARABEO";
            }
            else if (numeroCasuale2 == 14)
            {
                immagine = Properties.Resources.topo;
                oggettoTrovato = "TOPO";
            }
            else if (numeroCasuale2 == 15)
            {
                immagine = Properties.Resources.ragno;
                oggettoTrovato = "RAGNO";
            }
            else if (numeroCasuale2 == 16)
            {
                immagine = Properties.Resources.anello;
                oggettoTrovato = "ANELLO";
            }
            else if (numeroCasuale2 == 17)
            {
                immagine = Properties.Resources.saccoro;
                oggettoTrovato = "SACCORO";
            }
            else if (numeroCasuale2 == 18)
            {
                immagine = Properties.Resources.smeraldo;
                oggettoTrovato = "SMERALDO";
            }
            if (scelteGioco[numGiocatore, 2] == "SCACCHIERA")
            {
                if (i == 3)
                {
                    mappaVerdePicBox.Visible = false;
                    noOggettiVerde.Visible = false;
                    oggetto1VerdePicBox.Image = immagine;
                }
                else if (i == 6)
                {
                    oggetto2VerdePicBox.Image = immagine;
                }
                else if (i == 8)
                {
                    oggetto3VerdePicBox.Image = immagine;
                }
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
                indicazioniGioco.Location = new Point(1160, 215);
                indicazioniGioco.Text = $"È il turno di {scelteGioco[numGiocatore, 0]},\n che ora sta facendo\nla sua mossa";
                dadiBtn.Text = $"I dadi vengono \ntirati da {scelteGioco[numGiocatore,0]}";
                GenerazioneNumeroCasuale();
            }
            else
            {
                indicazioniGioco.Location = new Point(1203, 223);
                indicazioniGioco.Text = $"{scelteGioco[numGiocatore, 0]},\nè il tuo turno!";
                dadiBtn.Enabled = true;
            }
        }
        
    }
   
}
