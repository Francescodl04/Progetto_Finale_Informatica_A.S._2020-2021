//Autore: Francesco Di Lena
//Classe: 3F
//Data: aprile-maggio 2021
//Progetto finale di informatica: "Il Gioco del Labirinto".
//Schermata di visualizzazione delle statistiche di gioco.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Labirinto
{
    public partial class formStatistiche : Form
    {
        string vincitore = "";
        bool statIO = false;
        string statistiche = "0: : ";
        string[] elementiStatistiche;
        string[,] datiStatistiche;
        char carattereDivisore = ':';
        int numeroPosti = 0;
        int posizioneDaSpostare = 0;
        public formStatistiche(bool statisticheIO, string nomeVincitore)
        {
            InitializeComponent();
            vincitore = nomeVincitore;
            statIO = statisticheIO;
        }
        private void formStatistiche_Load(object sender, EventArgs e)
        {
            if (statIO == false)
            {
                salvaBtn.Enabled = false;
            }
            try
            {
                statistiche = File.ReadAllText(@"C:\Labirinto\statistiche.txt");
            }
            catch (FileNotFoundException)
            {
                File.WriteAllText(@"C:\Labirinto\statistiche.txt", statistiche);
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory(@"C:\Labirinto");
                File.WriteAllText(@"C:\Labirinto\statistiche.txt", statistiche);
            }
            catch (IOException)
            {
                var richiesta = MessageBox.Show("Si è verificato un errore durante la lettura del file: errore IO. Premi OK per riavviare il programma. Nel caso in cui questo errore si ripresentasse, provate a riavviare il sistema...", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (richiesta == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            catch (UnauthorizedAccessException)
            {
                var richiesta = MessageBox.Show("Si è verificato un errore durante la lettura del file: accesso non consentito. Premi OK per riavviare il programma. Nel caso in cui questo errore si ripresentasse, provate a riavviare il sistema, o a contattare l'amministratore di sistema...", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
            }
            elementiStatistiche = statistiche.Split(carattereDivisore);
            numeroPosti = Convert.ToInt32(elementiStatistiche[0]);
            int n = 1;
            if (numeroPosti == 0)
            {
                if (statIO == false)
                {
                    MessageBox.Show("Non sono ancora presenti statistiche...per aggiungerne, gioca!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    numeroPosti = 1;
                    elementiStatistiche[0] = Convert.ToString(numeroPosti);
                    elementiStatistiche[1] = vincitore;
                    elementiStatistiche[2] = "1";
                }
                ripristinaStatisticheBtn.Enabled = false;
            }
            else
            {
                if (statIO == true)
                {
                    for (int i = 1; i < elementiStatistiche.Length; i = i + 2)
                    {
                        if (vincitore == elementiStatistiche[i])
                        {
                            int partiteVinte = Convert.ToInt32(elementiStatistiche[i + 1]) + 1;
                            posizioneDaSpostare = i + 1;
                            elementiStatistiche[posizioneDaSpostare] = Convert.ToString(partiteVinte);
                            break;
                        }
                        else if (vincitore != elementiStatistiche[i] && i == elementiStatistiche.Length - 2)
                        {
                            numeroPosti++;
                            Array.Resize(ref elementiStatistiche, elementiStatistiche.Length + 2);
                            elementiStatistiche[elementiStatistiche.Length - 2] = vincitore;
                            elementiStatistiche[elementiStatistiche.Length - 1] = "1";
                            break;
                        }
                    }
                }
            }
            datiStatistiche = new string[numeroPosti, 3];
            for (int i = 0; i < numeroPosti; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        datiStatistiche[i, j] = $"{i + 1}⁰";
                    }
                    else
                    {
                        datiStatistiche[i, j] = elementiStatistiche[n];
                        n++;
                    }
                    if (j == 2)
                    {
                        if (statIO == true && i == numeroPosti - 1) 
                        {
                            for (int k = numeroPosti - 1; k > 0; k--) 
                            {
                                if (Convert.ToInt32(datiStatistiche[k, 2]) > Convert.ToInt32(datiStatistiche[k - 1, 2])) 
                                {
                                    for (int l = 1; l < 3; l++) 
                                    {
                                        string temp = datiStatistiche[k, l];
                                        datiStatistiche[k, l] = datiStatistiche[k - 1, l];
                                        datiStatistiche[k - 1, l] = temp;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < numeroPosti; i++)
            {
                statisticheDGView.Rows.Insert(i, datiStatistiche[i, 0], datiStatistiche[i, 1], datiStatistiche[i, 2]);
            }
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

        private void salvaBtn_Click(object sender, EventArgs e)
        {
            string salvataggio = " ";
            var conferma = MessageBox.Show("Sei veramente sicuro di voler salvare le nuove statistiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (conferma == DialogResult.Yes) 
            {
                for (int i = 0; i < numeroPosti; i++)
                {
                    for (int j = 1; j < 3; j++)
                    {
                        if (i == 0 && j == 1)
                        {
                            salvataggio = $"{numeroPosti}" + carattereDivisore;
                        }
                        if (i == numeroPosti - 1 && j == 2)
                        {
                            salvataggio = salvataggio + datiStatistiche[i, j];
                        }
                        else
                        {
                            salvataggio = salvataggio + datiStatistiche[i, j] + carattereDivisore;
                        }
                    }
                }
                File.WriteAllText(@"C:\Labirinto\statistiche.txt", salvataggio);
                MessageBox.Show("Salvataggio delle modifiche completato con successo.", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                salvaBtn.Enabled = false;
            }
        }

        private void ripristinaStatisticheBtn_Click(object sender, EventArgs e)
        {
            var richiesta = MessageBox.Show("Sei veramente sicuro di voler ripristinare le statistiche? Sappi che tutte le statistiche verranno cancellate...", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (richiesta == DialogResult.Yes)
            {
                File.WriteAllText(@"C:\Labirinto\statistiche.txt", "0::");
                MessageBox.Show("Salvataggio delle modifiche completato con successo.", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ripristinaStatisticheBtn.Enabled = false;
            }
        }
    }
}
