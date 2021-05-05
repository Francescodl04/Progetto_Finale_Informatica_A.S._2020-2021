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
        string nomeGiocatore = "";
        string sceltaPedina = "";
        string sceltaTabellone = "";
        int contatoreGiocatore = 1;
        int contatoreGiocatori = 1;
        string[] scelteGiocatori = new string[12];
        int n = 0;
        public formScelteGioco(int numeroGiocatori)
        {
            InitializeComponent();
            contatoreGiocatori = numeroGiocatori;
        }
        private void confermaBtn_Click(object sender, EventArgs e)
        {
            if (contatoreGiocatore < contatoreGiocatori)
            {
                if (contatoreGiocatore != 1)
                {
                    n += 3;
                }
                contatoreGiocatore++;
                nomeGiocatore = nomeTxt.Text;
                scelteGiocatori[n] = nomeGiocatore;
                scelteGiocatori[n + 1] = sceltaPedina;
                scelteGiocatori[n + 2] = sceltaTabellone;
                var conferma = MessageBox.Show("Sei sicuro di voler confermare i tuoi dati?", "Conferma...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (conferma == DialogResult.Yes)
                {
                    indicazioniGioco.Text = $"Giocatore {contatoreGiocatore}, effettua le tue scelte...";
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
                }
            }
            else
            {
                pedinaSaliScendiPicBox Form7 = new pedinaSaliScendiPicBox();
                Form7.Show();
                this.Hide();
            }
        }

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

        private void esciBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formScelteGioco_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void nomeTxt_Click(object sender, EventArgs e)
        {
            nomeTxt.Clear();
        }

        private void indietroPicBox_Click(object sender, EventArgs e)
        {
            formSceltaGiocatori Form3 = new formSceltaGiocatori();
            Form3.Show();
            this.Hide();
        }
    }
}
