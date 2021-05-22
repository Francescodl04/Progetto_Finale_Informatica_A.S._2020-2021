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
        public int numeroGiocatori = 0;
        public formSceltaGiocatori()
        {
            InitializeComponent();
        }
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
        private void SchermataSuccessiva()
        {
            formScelteGioco form4 = new formScelteGioco(numeroGiocatori);
            form4.Show();
            this.Hide();
        }
        private void salvataggio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void unoPicBox_MouseHover(object sender, EventArgs e)
        {
            unoBtn.Visible = true;
            dueBtn.Visible = false;
            treBtn.Visible = false;
            quattroBtn.Visible = false;
        }

        private void duePicBox_MouseHover(object sender, EventArgs e)
        {
            unoBtn.Visible = false;
            dueBtn.Visible = true;
            treBtn.Visible = false;
            quattroBtn.Visible = false;
        }

        private void trePicBox_MouseHover(object sender, EventArgs e)
        {
            unoBtn.Visible = false;
            dueBtn.Visible = false;
            treBtn.Visible = true;
            quattroBtn.Visible = false;
        }

        private void quattroPicBox_MouseHover(object sender, EventArgs e)
        {
            unoBtn.Visible = false;
            dueBtn.Visible = false;
            treBtn.Visible = false;
            quattroBtn.Visible = true;
        }

        private void indietroPicBox_Click(object sender, EventArgs e)
        {
            formSchermataIniziale Form2 = new formSchermataIniziale();
            Form2.Show();
            this.Hide();
        }
    }
}
