using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void nonSalvareEChiudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void facileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (facileToolStripMenuItem.Checked == false)
            {
                facileToolStripMenuItem.Checked = true;
            }
            else
            {
                facileToolStripMenuItem.Checked = false;
            }
        }

        private void suoniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            suoniToolStripMenuItem.Checked = true;
        }

        private void esciSenzaSalvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
