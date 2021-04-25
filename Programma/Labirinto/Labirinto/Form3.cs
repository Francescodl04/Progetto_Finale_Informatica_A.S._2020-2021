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

        
    }
}
