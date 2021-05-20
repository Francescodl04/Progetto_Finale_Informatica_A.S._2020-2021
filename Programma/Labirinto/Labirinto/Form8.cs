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
    public partial class formStatistiche : Form
    {
        public formStatistiche()
        {
            InitializeComponent();
        }

        private void indietroPicBox_Click(object sender, EventArgs e)
        {
            formSchermataIniziale Form2 = new formSchermataIniziale();
            Form2.Show();
            this.Hide();
        }

        private void formStatistiche_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
