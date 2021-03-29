using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prg_lab
{
    public partial class Labirinto : Form
    {
        public Labirinto()
        {
            InitializeComponent();
        }
        private void Labirinto_Load(object sender, EventArgs e)
        {

        }

        private void giocaBtn_Click(object sender, EventArgs e)
        {
            giocaBtn.Visible = false;
            istruzioniBtn.Visible = false;
            esciBtn.Visible = false;
            logoPicBox.Visible = false;
        }

        private void istruzioniBtn_Click(object sender, EventArgs e)
        {
            giocaBtn.Visible = false;
            istruzioniBtn.Visible = false;
            esciBtn.Visible = false;
            logoPicBox.Visible = false;
        }

        private void esciBtn_Click(object sender, EventArgs e)
        {
            giocaBtn.Visible = false;
            istruzioniBtn.Visible = false;
            esciBtn.Visible = false;
            logoPicBox.Visible = false;
            Application.Exit();
        }
    }
}
