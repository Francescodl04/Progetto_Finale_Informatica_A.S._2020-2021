using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirinto
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Visualizza lo splash screen dell'applicazione.
            formCaricamento Form1 = new formCaricamento();
            formSchermataIniziale Form2 = new formSchermataIniziale();
            Form1.ShowDialog();
            Form1.Dispose();
            Form2.ShowDialog();
            Application.Run(new salvataggio());
        }
    }
}
