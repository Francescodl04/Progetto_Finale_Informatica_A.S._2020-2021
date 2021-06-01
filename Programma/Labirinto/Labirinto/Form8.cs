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
        string vincitore = ""; //Variabile che conterrà il nome del vincitore.
        bool statIO = false; //Variabile a cui verrà successivamente assegnato il valore di statisticheIO, che serve a decidere se avviare le procedure di scrittura.
        string statistiche = "0: : "; //Variabile che conterrà l'intero testo del file delle statistiche.
        string[] elementiStatistiche; //Matrice unidimensionale che conterrà gli elementi divisi del testo del file.
        string[,] datiStatistiche; //Matrice multidimensionale che conterrà le statistiche suddivise in righe e colonne.
        char carattereDivisore = '|'; //Carattere che verrà utilizzato per dividere il testo del file in elementi singoli.
        int numeroPosti = 0; //Variabile che servirà per tenere conto del numero di persone che si trovano nella classifica.
        int posizioneDaSpostare = 0; //Variabile che servirà quando sarà necessario spostare di posto una persona che già si trova in classifica.
        public formStatistiche(bool statisticheIO, string nomeVincitore) //Viene inizializzato il form.
        {
            InitializeComponent();
            vincitore = nomeVincitore;
            statIO = statisticheIO;
        }
        private void formStatistiche_Load(object sender, EventArgs e) //Al caricamento del form esegue le seguenti operazioni.
        {
            //Viene impedito all'utente di apportare modifiche a statisticheDGView.
            statisticheDGView.AllowUserToAddRows = false;
            statisticheDGView.AllowUserToDeleteRows = false;
            if (statIO == false)
            {
                salvaBtn.Enabled = false;
            }
            try //Prova a leggere il contenuto del file statistiche.txt.
            {
                statistiche = File.ReadAllText(@"C:\Labirinto\statistiche.txt");
            }
            //Se si generano delle eccezioni, allora queste vengono gestite nella parte di blocco catch.
            catch (FileNotFoundException)
            {
                File.WriteAllText(@"C:\Labirinto\statistiche.txt", statistiche); //Crea un nuovo file con il nome statistiche.txt e inserisce al suo interno il contenuto della variabile statistiche.
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory(@"C:\Labirinto"); //Crea la cartella C:\Labirinto.
                File.WriteAllText(@"C:\Labirinto\statistiche.txt", statistiche); //Crea un nuovo file con il nome statistiche.txt e inserisce al suo interno il contenuto della variabile statistiche.
            }
            catch (IOException)
            {
                var richiesta = MessageBox.Show("Si è verificato un errore durante la lettura del file: errore IO. Premi OK per riavviare il programma. Nel caso in cui questo errore si ripresentasse, provate a riavviare il sistema...", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (richiesta == DialogResult.OK)
                {
                    Application.Restart(); //Riavvia il programma.
                }
            }
            catch (UnauthorizedAccessException)
            {
                var richiesta = MessageBox.Show("Si è verificato un errore durante la lettura del file: accesso non consentito. Premi OK per riavviare il programma. Nel caso in cui questo errore si ripresentasse, prova a riavviare il sistema, o a contattare l'amministratore di sistema...", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (richiesta == DialogResult.OK)
                {
                    Application.Restart(); //Riavvia il programma.
                }
            }
            elementiStatistiche = statistiche.Split(carattereDivisore); //Il metodo string.split permette di dividere la stringa statistiche attraverso l'uso di carattereDivisore e inserire le divisioni nell'array elementiStatistiche.
            numeroPosti = Convert.ToInt32(elementiStatistiche[0]); //Prende dalla prima cella dell'array il numero di persone presenti all'interno della classifica.
            int n = 1; //Variabile contatore necessaria successivamente per poter passare da array unidimensionale a multidimensionale.
            if (numeroPosti == 0) //Se le statistiche sono vuote, allora visualizza un messaggio d'errore.
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
                if (statIO == true) //Se è appena terminata una partita, allora le statistiche devono essere aggiornate.
                {
                    for (int i = 1; i < elementiStatistiche.Length; i = i + 2)
                    {
                        if (vincitore == elementiStatistiche[i]) //Questo caso si verifica se il nome del vincitore si trova già nell'array, quindi non c'è bisogno di ridimensionare le statistiche.
                        {
                            int partiteVinte = Convert.ToInt32(elementiStatistiche[i + 1]) + 1;
                            posizioneDaSpostare = i + 1;
                            elementiStatistiche[posizioneDaSpostare] = Convert.ToString(partiteVinte);
                            break;
                        }
                        else if (vincitore != elementiStatistiche[i] && i == elementiStatistiche.Length - 2) //Questo caso, invece, si verifica se il nome del vincitore NON si trova già nell'array.
                        {
                            numeroPosti++;
                            Array.Resize(ref elementiStatistiche, elementiStatistiche.Length + 2); //La dimensione della matrice viene aumentata di due attraverso questo metodo.
                            elementiStatistiche[elementiStatistiche.Length - 2] = vincitore;
                            elementiStatistiche[elementiStatistiche.Length - 1] = "1";
                            break;
                        }
                    }
                }
            }
            datiStatistiche = new string[numeroPosti, 3];
            for (int i = 0; i < numeroPosti; i++) //Con questo ciclo avviene il passaggio dall'array unidimensionale elementiStatistiche a datiStatistiche.
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        datiStatistiche[i, j] = $"{i + 1}⁰"; //Si aggiunge il numero di posto.
                    }
                    else
                    {
                        datiStatistiche[i, j] = elementiStatistiche[n];
                        n++;
                    }
                    if (j == 2)
                    {
                        if (statIO == true && i == numeroPosti - 1) //Se si viene dalla schermata di gioco, quindi se le statistiche sono state aggiornate, allora si eseguono le seguenti operazioni.
                        {
                            for (int k = numeroPosti - 1; k > 0; k--)  
                            {
                                if (Convert.ToInt32(datiStatistiche[k, 2]) > Convert.ToInt32(datiStatistiche[k - 1, 2])) //Si effettua un controllo per vedere se è necessario un ordinamento.
                                {
                                    for (int l = 1; l < 3; l++) //Se ce n'è bisogno si effettua un semplice ordinamento di tipo Bubble Sort.
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
            for (int i = 0; i < numeroPosti; i++) //Con questo ciclo si inseriscono i dati della classifica all'interno di statisticheDGView.
            {
                statisticheDGView.Rows.Insert(i, datiStatistiche[i, 0], datiStatistiche[i, 1], datiStatistiche[i, 2]);
            }
        }

        private void salvaBtn_Click(object sender, EventArgs e) //Evento generato dal click di salvaBtn, che permette di salvare le modifiche apportate alle statistiche dopo la fine del gioco.
        {
            string salvataggio = " ";
            var conferma = MessageBox.Show("Sei veramente sicuro di voler salvare le nuove statistiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (conferma == DialogResult.Yes) 
            {
                for (int i = 0; i < numeroPosti; i++) //Con questo ciclo tutti gli elementi di datiStatistiche vengono inseriti all'interno di un'unica stringa, divisi da carattereDivisiore.
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
                try //Prova ad eseguire la scrittura del file statistiche.txt. 
                {
                    File.WriteAllText(@"C:\Labirinto\statistiche.txt", salvataggio);
                }
                //Se si generano delle eccezioni, allora queste vengono gestite nella parte di blocco catch.
                catch (DirectoryNotFoundException)
                {
                    Directory.CreateDirectory(@"C:\Labirinto"); //Crea la cartella C:\Labirinto.
                    File.WriteAllText(@"C:\Labirinto\statistiche.txt", salvataggio); //Crea un nuovo file con il nome statistiche.txt e inserisce al suo interno il contenuto della variabile salvataggio.
                }
                catch(IOException)
                {
                    var richiesta = MessageBox.Show("Si è verificato un errore durante la scrittura del file: errore IO. Premi OK per riavviare il programma. Nel caso in cui questo errore si ripresentasse, prova a riavviare il sistema...", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (richiesta == DialogResult.OK)
                    {
                        Application.Restart(); //Riavvia il programma.
                    }
                }
                catch(UnauthorizedAccessException)
                {
                    var richiesta = MessageBox.Show("Si è verificato un errore durante la scrittura del file: accesso non consentito. Premi OK per riavviare il programma. Nel caso in cui questo errore si ripresentasse, prova a riavviare il sistema, o a contattare l'amministratore di sistema...", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (richiesta == DialogResult.OK)
                    {
                        Application.Restart(); //Riavvia il programma.
                    }
                }
                MessageBox.Show("Salvataggio delle modifiche completato con successo.", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                salvaBtn.Enabled = false;
            }
        }

        private void ripristinaStatisticheBtn_Click(object sender, EventArgs e) //Evento generato dal click di ripristinaStatisticheBtn, che permette di cancellare le statistiche.
        {
            var richiesta = MessageBox.Show("Sei veramente sicuro di voler ripristinare le statistiche? Sappi che tutte le statistiche verranno cancellate...", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (richiesta == DialogResult.Yes)
            {
                try //Prova ad eseguire la scrittura del file statistiche.txt.
                {
                    File.WriteAllText(@"C:\Labirinto\statistiche.txt", "0||");
                }
                //Se si generano delle eccezioni, allora queste vengono gestite nella parte di blocco catch.
                catch (DirectoryNotFoundException)
                {
                    Directory.CreateDirectory(@"C:\Labirinto"); //Crea la cartella C:\Labirinto.
                    File.WriteAllText(@"C:\Labirinto\statistiche.txt", "0||"); //Crea un nuovo file con il nome statistiche.txt e inserisce al suo interno il contenuto della stringa "0::".
                }
                catch (IOException)
                {
                    var richiesta2 = MessageBox.Show("Si è verificato un errore durante la scrittura del file: errore IO. Premi OK per riavviare il programma. Nel caso in cui questo errore si ripresentasse, prova a riavviare il sistema...", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (richiesta == DialogResult.OK)
                    {
                        Application.Restart(); //Riavvia il programma.
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    var richiesta2 = MessageBox.Show("Si è verificato un errore durante la scrittura del file: accesso non consentito. Premi OK per riavviare il programma. Nel caso in cui questo errore si ripresentasse, prova a riavviare il sistema, o a contattare l'amministratore di sistema...", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (richiesta == DialogResult.OK)
                    {
                        Application.Restart(); //Riavvia il programma.
                    }
                }
                MessageBox.Show("Salvataggio delle modifiche completato con successo.", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ripristinaStatisticheBtn.Enabled = false;
            }
        }
        
        private void indietroPicBox_Click(object sender, EventArgs e) //Evento generato dal click di indietroPicBox.
        {
            formSchermataIniziale Form2 = new formSchermataIniziale(); //Inizializza il nuovo form.
            Form2.Show(); //Visualizza il nuovo form.
            this.Hide(); //Chiude il form corrente.
        }

        private void formStatistiche_FormClosed(object sender, FormClosedEventArgs e) //Evento generato dalla chiusura del form.
        {
            Application.Exit(); //Esce completamente dal programma.
        }
    }
}
