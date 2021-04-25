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
            formCaricamento Form1 = new formCaricamento();
            formSchermataIniziale Form2 = new formSchermataIniziale();
            salvataggio Form3 = new salvataggio();
            formScelteGioco Form4 = new formScelteGioco();
            Form1.ShowDialog();
            Form1.Dispose();
            Form2.ShowDialog();
            Form2.Dispose();
            Form3.ShowDialog();
            Form3.Dispose();
            Form4.ShowDialog();
            Form4.Dispose();
        }
    }
}
