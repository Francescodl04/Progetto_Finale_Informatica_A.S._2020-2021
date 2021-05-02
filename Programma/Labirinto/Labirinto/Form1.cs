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

        private void Form1_Load(object sender, EventArgs e)
        {
            Attendi();
        }
        public async void  Attendi()
        {
            barraProgressi.Step = 1;
            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(1);
                barraProgressi.PerformStep();
                descrizioneOperazioni.Text = "Caricamento in corso ( " + (i + 1) + "% )";
            }
            await Task.Delay(1000);
            formSchermataIniziale fSchermata = new formSchermataIniziale();
            fSchermata.Show();
            this.Hide();
        }
        private void chiudi_gioco_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
