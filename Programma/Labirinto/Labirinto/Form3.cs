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
    public partial class salvataggio : Form
    {
        public int numeroGiocatori = 0;
        public salvataggio()
        {
            InitializeComponent();
        }
        private void salvataggio_Load(object sender, EventArgs e)
        {

        }
        private void homepageBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chiudiBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            formSchermataIniziale formIniziale = new formSchermataIniziale();
            formIniziale.Show();
            this.Hide();
        }
    }
}
