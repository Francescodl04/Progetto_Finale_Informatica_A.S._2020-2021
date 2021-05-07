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
        public formGioco(string [,] scelteGiocatori)
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
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            for (int i = 0; i < 4; i++)
            {
                dataGridView1.Rows.Insert(i, $"{scelteGioco[i, 0]}", "0");
            }
            if (scelteGioco[0, 1] == "ELMO") 
            {
                if (scelteGioco[0, 1] == "ELMO" && scelteGioco[0, 2] == "SCACCHIERA")
                {
                    pedinaVerdePicBox.Image = Properties.Resources.elmo_cavaliere;
                }
                else if (scelteGioco[0, 1] == "ELMO" && scelteGioco[0, 2] == "LABIRINTORE")
                {
                    pedinaBluPicBox.Image = Properties.Resources.elmo_cavaliere;
                }
                else if (scelteGioco[0, 1] == "ELMO" && scelteGioco[0, 2] == "DIAMANTE")
                {
                    pedinaGiallaPicBox.Image = Properties.Resources.elmo_cavaliere;
                }
                else if (scelteGioco[0, 1] == "ELMO" && scelteGioco[0, 2] == "SALISCENDI")
                {
                    pedinaRossaPicBox.Image = Properties.Resources.elmo_cavaliere;
                }
            }
            else if (scelteGioco[1, 1] == "ELMO")
            {
                if (scelteGioco[1, 1] == "ELMO" && scelteGioco[1, 2] == "SCACCHIERA")
                {
                    pedinaVerdePicBox.Image = Properties.Resources.elmo_cavaliere;
                }
                else if (scelteGioco[1, 1] == "ELMO" && scelteGioco[1, 2] == "LABIRINTORE")
                {
                    pedinaBluPicBox.Image = Properties.Resources.elmo_cavaliere;
                }
                else if (scelteGioco[1, 1] == "ELMO" && scelteGioco[1, 2] == "DIAMANTE")
                {
                    pedinaGiallaPicBox.Image = Properties.Resources.elmo_cavaliere;
                }
                else if (scelteGioco[1, 1] == "ELMO" && scelteGioco[1, 2] == "SALISCENDI")
                {
                    pedinaRossaPicBox.Image = Properties.Resources.elmo_cavaliere;
                }
            }
            else if (scelteGioco[2, 1] == "ELMO")
            {
                if (scelteGioco[2, 1] == "ELMO" && scelteGioco[2, 2] == "SCACCHIERA")
                {
                    pedinaVerdePicBox.Image = Properties.Resources.elmo_cavaliere;
                }
                else if (scelteGioco[2, 1] == "ELMO" && scelteGioco[2, 2] == "LABIRINTORE")
                {
                    pedinaBluPicBox.Image = Properties.Resources.elmo_cavaliere;
                }
                else if (scelteGioco[2, 1] == "ELMO" && scelteGioco[2, 2] == "DIAMANTE")
                {
                    pedinaGiallaPicBox.Image = Properties.Resources.elmo_cavaliere;
                }
                else if (scelteGioco[2, 1] == "ELMO" && scelteGioco[2, 2] == "SALISCENDI")
                {
                    pedinaRossaPicBox.Image = Properties.Resources.elmo_cavaliere;
                }
            }
            else if (scelteGioco[3, 1] == "ELMO")
            {
                if (scelteGioco[3, 1] == "ELMO" && scelteGioco[3, 2] == "SCACCHIERA")
                {
                    pedinaVerdePicBox.Image = Properties.Resources.elmo_cavaliere;
                }
                else if (scelteGioco[3, 1] == "ELMO" && scelteGioco[3, 2] == "LABIRINTORE")
                {
                    pedinaBluPicBox.Image = Properties.Resources.elmo_cavaliere;
                }
                else if (scelteGioco[3, 1] == "ELMO" && scelteGioco[3, 2] == "DIAMANTE")
                {
                    pedinaGiallaPicBox.Image = Properties.Resources.elmo_cavaliere;
                }
                else if (scelteGioco[3, 1] == "ELMO" && scelteGioco[3, 2] == "SALISCENDI")
                {
                    pedinaRossaPicBox.Image = Properties.Resources.elmo_cavaliere;
                }
            }
            if (scelteGioco[0, 1] == "CORONA")
            {
                if (scelteGioco[0, 1] == "CORONA" && scelteGioco[0, 2] == "SCACCHIERA")
                {
                    pedinaVerdePicBox.Image = Properties.Resources.corona_re;
                }
                else if (scelteGioco[0, 1] == "CORONA" && scelteGioco[0, 2] == "LABIRINTORE")
                {
                    pedinaBluPicBox.Image = Properties.Resources.corona_re;
                }
                else if (scelteGioco[0, 1] == "CORONA" && scelteGioco[0, 2] == "DIAMANTE")
                {
                    pedinaGiallaPicBox.Image = Properties.Resources.corona_re;
                }
                else if (scelteGioco[0, 1] == "CORONA" && scelteGioco[0, 2] == "SALISCENDI")
                {
                    pedinaRossaPicBox.Image = Properties.Resources.corona_re;
                }
            }
            else if (scelteGioco[1, 1] == "CORONA")
            {
                if (scelteGioco[1, 1] == "CORONA" && scelteGioco[1, 2] == "SCACCHIERA")
                {
                    pedinaVerdePicBox.Image = Properties.Resources.corona_re;
                }
                else if (scelteGioco[1, 1] == "CORONA" && scelteGioco[1, 2] == "LABIRINTORE")
                {
                    pedinaBluPicBox.Image = Properties.Resources.corona_re;
                }
                else if (scelteGioco[1, 1] == "CORONA" && scelteGioco[1, 2] == "DIAMANTE")
                {
                    pedinaGiallaPicBox.Image = Properties.Resources.corona_re;
                }
                else if (scelteGioco[1, 1] == "CORONA" && scelteGioco[1, 2] == "SALISCENDI")
                {
                    pedinaRossaPicBox.Image = Properties.Resources.corona_re;
                }
            }
            else if (scelteGioco[2, 1] == "CORONA")
            {
                if (scelteGioco[2, 1] == "CORONA" && scelteGioco[2, 2] == "SCACCHIERA")
                {
                    pedinaVerdePicBox.Image = Properties.Resources.corona_re;
                }
                else if (scelteGioco[2, 1] == "CORONA" && scelteGioco[2, 2] == "LABIRINTORE")
                {
                    pedinaBluPicBox.Image = Properties.Resources.corona_re;
                }
                else if (scelteGioco[2, 1] == "CORONA" && scelteGioco[2, 2] == "DIAMANTE")
                {
                    pedinaGiallaPicBox.Image = Properties.Resources.corona_re;
                }
                else if (scelteGioco[2, 1] == "CORONA" && scelteGioco[2, 2] == "SALISCENDI")
                {
                    pedinaRossaPicBox.Image = Properties.Resources.corona_re;
                }
            }
            else if (scelteGioco[3, 1] == "CORONA")
            {
                if (scelteGioco[3, 1] == "CORONA" && scelteGioco[3, 2] == "SCACCHIERA")
                {
                    pedinaVerdePicBox.Image = Properties.Resources.corona_re;
                }
                else if (scelteGioco[3, 1] == "CORONA" && scelteGioco[3, 2] == "LABIRINTORE")
                {
                    pedinaBluPicBox.Image = Properties.Resources.corona_re;
                }
                else if (scelteGioco[3, 1] == "CORONA" && scelteGioco[3, 2] == "DIAMANTE")
                {
                    pedinaGiallaPicBox.Image = Properties.Resources.corona_re;
                }
                else if (scelteGioco[3, 1] == "CORONA" && scelteGioco[3, 2] == "SALISCENDI")
                {
                    pedinaRossaPicBox.Image = Properties.Resources.corona_re;
                }
            }
            if (scelteGioco[0, 1] == "GEKO")
            {
                if (scelteGioco[0, 1] == "GEKO" && scelteGioco[0, 2] == "SCACCHIERA")
                {
                    pedinaVerdePicBox.Image = Properties.Resources.geko;
                }
                else if (scelteGioco[0, 1] == "GEKO" && scelteGioco[0, 2] == "LABIRINTORE")
                {
                    pedinaBluPicBox.Image = Properties.Resources.geko;
                }
                else if (scelteGioco[0, 1] == "GEKO" && scelteGioco[0, 2] == "DIAMANTE")
                {
                    pedinaGiallaPicBox.Image = Properties.Resources.geko;
                }
                else if (scelteGioco[0, 1] == "GEKO" && scelteGioco[0, 2] == "SALISCENDI")
                {
                    pedinaRossaPicBox.Image = Properties.Resources.geko;
                }
            }
            else if (scelteGioco[1, 1] == "GEKO")
            {
                if (scelteGioco[1, 1] == "GEKO" && scelteGioco[1, 2] == "SCACCHIERA")
                {
                    pedinaVerdePicBox.Image = Properties.Resources.geko;
                }
                else if (scelteGioco[1, 1] == "GEKO" && scelteGioco[1, 2] == "LABIRINTORE")
                {
                    pedinaBluPicBox.Image = Properties.Resources.geko;
                }
                else if (scelteGioco[1, 1] == "GEKO" && scelteGioco[1, 2] == "DIAMANTE")
                {
                    pedinaGiallaPicBox.Image = Properties.Resources.geko;
                }
                else if (scelteGioco[1, 1] == "GEKO" && scelteGioco[1, 2] == "SALISCENDI")
                {
                    pedinaRossaPicBox.Image = Properties.Resources.geko;
                }
            }
            else if (scelteGioco[2, 1] == "GEKO")
            {
                if (scelteGioco[2, 1] == "GEKO" && scelteGioco[2, 2] == "SCACCHIERA")
                {
                    pedinaVerdePicBox.Image = Properties.Resources.geko;
                }
                else if (scelteGioco[2, 1] == "GEKO" && scelteGioco[2, 2] == "LABIRINTORE")
                {
                    pedinaBluPicBox.Image = Properties.Resources.geko;
                }
                else if (scelteGioco[2, 1] == "GEKO" && scelteGioco[2, 2] == "DIAMANTE")
                {
                    pedinaGiallaPicBox.Image = Properties.Resources.geko;
                }
                else if (scelteGioco[2, 1] == "GEKO" && scelteGioco[2, 2] == "SALISCENDI")
                {
                    pedinaRossaPicBox.Image = Properties.Resources.geko;
                }
            }
            else if (scelteGioco[3, 1] == "GEKO")
            {
                if (scelteGioco[3, 1] == "GEKO" && scelteGioco[3, 2] == "SCACCHIERA")
                {
                    pedinaVerdePicBox.Image = Properties.Resources.geko;
                }
                else if (scelteGioco[3, 1] == "GEKO" && scelteGioco[3, 2] == "LABIRINTORE")
                {
                    pedinaBluPicBox.Image = Properties.Resources.geko;
                }
                else if (scelteGioco[3, 1] == "GEKO" && scelteGioco[3, 2] == "DIAMANTE")
                {
                    pedinaGiallaPicBox.Image = Properties.Resources.geko;
                }
                else if (scelteGioco[3, 1] == "GEKO" && scelteGioco[3, 2] == "SALISCENDI")
                {
                    pedinaRossaPicBox.Image = Properties.Resources.geko;
                }
            }
            if (scelteGioco[0, 1] == "FALENA")
            {
                if (scelteGioco[0, 1] == "FALENA" && scelteGioco[0, 2] == "SCACCHIERA")
                {
                    pedinaVerdePicBox.Image = Properties.Resources.falena;
                }
                else if (scelteGioco[0, 1] == "FALENA" && scelteGioco[0, 2] == "LABIRINTORE")
                {
                    pedinaBluPicBox.Image = Properties.Resources.falena;
                }
                else if (scelteGioco[0, 1] == "FALENA" && scelteGioco[0, 2] == "DIAMANTE")
                {
                    pedinaGiallaPicBox.Image = Properties.Resources.falena;
                }
                else if (scelteGioco[0, 1] == "FALENA" && scelteGioco[0, 2] == "SALISCENDI")
                {
                    pedinaRossaPicBox.Image = Properties.Resources.falena;
                }
            }
            else if (scelteGioco[1, 1] == "FALENA")
            {
                if (scelteGioco[1, 1] == "FALENA" && scelteGioco[1, 2] == "SCACCHIERA")
                {
                    pedinaVerdePicBox.Image = Properties.Resources.falena;
                }
                else if (scelteGioco[1, 1] == "FALENA" && scelteGioco[1, 2] == "LABIRINTORE")
                {
                    pedinaBluPicBox.Image = Properties.Resources.falena;
                }
                else if (scelteGioco[1, 1] == "FALENA" && scelteGioco[1, 2] == "DIAMANTE")
                {
                    pedinaGiallaPicBox.Image = Properties.Resources.falena;
                }
                else if (scelteGioco[1, 1] == "FALENA" && scelteGioco[1, 2] == "SALISCENDI")
                {
                    pedinaRossaPicBox.Image = Properties.Resources.falena;
                }
            }
            else if (scelteGioco[2, 1] == "FALENA")
            {
                if (scelteGioco[2, 1] == "FALENA" && scelteGioco[2, 2] == "SCACCHIERA")
                {
                    pedinaVerdePicBox.Image = Properties.Resources.falena;
                }
                else if (scelteGioco[2, 1] == "FALENA" && scelteGioco[2, 2] == "LABIRINTORE")
                {
                    pedinaBluPicBox.Image = Properties.Resources.falena;
                }
                else if (scelteGioco[2, 1] == "FALENA" && scelteGioco[2, 2] == "DIAMANTE")
                {
                    pedinaGiallaPicBox.Image = Properties.Resources.falena;
                }
                else if (scelteGioco[2, 1] == "FALENA" && scelteGioco[2, 2] == "SALISCENDI")
                {
                    pedinaRossaPicBox.Image = Properties.Resources.falena;
                }
            }
            else if (scelteGioco[3, 1] == "FALENA")
            {
                if (scelteGioco[3, 1] == "FALENA" && scelteGioco[3, 2] == "SCACCHIERA")
                {
                    pedinaVerdePicBox.Image = Properties.Resources.falena;
                }
                else if (scelteGioco[3, 1] == "FALENA" && scelteGioco[3, 2] == "LABIRINTORE")
                {
                    pedinaBluPicBox.Image = Properties.Resources.falena;
                }
                else if (scelteGioco[3, 1] == "FALENA" && scelteGioco[3, 2] == "DIAMANTE")
                {
                    pedinaGiallaPicBox.Image = Properties.Resources.falena;
                }
                else if (scelteGioco[3, 1] == "FALENA" && scelteGioco[3, 2] == "SALISCENDI")
                {
                    pedinaRossaPicBox.Image = Properties.Resources.falena;
                }
            }
        }
        public void SceltaPedina(int n)
        {
            if (scelteGioco[n, 2] == "SCACCHIERA")
            {
                pedinaVerdePicBox.Image = Properties.Resources.elmo_cavaliere;
            }
            else if (scelteGioco[n, 2] == "LABIRINTORE")
            {
                pedinaBluPicBox.Image = Properties.Resources.elmo_cavaliere;
            }
            else if (scelteGioco[n, 2] == "DIAMANTE")
            {
                pedinaGiallaPicBox.Image = Properties.Resources.elmo_cavaliere;
            }
            else if (scelteGioco[n, 2] == "SALISCENDI")
            {
                pedinaRossaPicBox.Image = Properties.Resources.elmo_cavaliere;
            }
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
        
    }
}
