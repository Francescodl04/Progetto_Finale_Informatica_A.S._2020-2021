namespace prova
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.salvaLaPartitaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chiudiESalvaLaPartitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciSenzaSalvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statisticheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.livelloGiocoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.suoniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicaDiSottofondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.giocatoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quattroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.guidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informazioniSuLabirintoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(916, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(432, 151);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton1,
            this.toolStripSplitButton1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1354, 22);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvaLaPartitaToolStripMenuItem1,
            this.chiudiESalvaLaPartitaToolStripMenuItem,
            this.esciSenzaSalvareToolStripMenuItem,
            this.toolStripSeparator1,
            this.statisticheToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(54, 19);
            this.toolStripDropDownButton2.Text = "Partita";
            // 
            // salvaLaPartitaToolStripMenuItem1
            // 
            this.salvaLaPartitaToolStripMenuItem1.Name = "salvaLaPartitaToolStripMenuItem1";
            this.salvaLaPartitaToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.salvaLaPartitaToolStripMenuItem1.Text = "Salva la partita";
            // 
            // chiudiESalvaLaPartitaToolStripMenuItem
            // 
            this.chiudiESalvaLaPartitaToolStripMenuItem.Name = "chiudiESalvaLaPartitaToolStripMenuItem";
            this.chiudiESalvaLaPartitaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.chiudiESalvaLaPartitaToolStripMenuItem.Text = "Chiudi e salva la partita";
            // 
            // esciSenzaSalvareToolStripMenuItem
            // 
            this.esciSenzaSalvareToolStripMenuItem.Name = "esciSenzaSalvareToolStripMenuItem";
            this.esciSenzaSalvareToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.esciSenzaSalvareToolStripMenuItem.Text = "Esci senza salvare";
            this.esciSenzaSalvareToolStripMenuItem.Click += new System.EventHandler(this.esciSenzaSalvareToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // statisticheToolStripMenuItem
            // 
            this.statisticheToolStripMenuItem.Name = "statisticheToolStripMenuItem";
            this.statisticheToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.statisticheToolStripMenuItem.Text = "Statistiche";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livelloGiocoToolStripMenuItem,
            this.toolStripSeparator2,
            this.suoniToolStripMenuItem,
            this.musicaDiSottofondoToolStripMenuItem,
            this.toolStripSeparator3,
            this.giocatoriToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(107, 19);
            this.toolStripDropDownButton1.Text = "Opzioni di gioco";
            this.toolStripDropDownButton1.ToolTipText = "Opzioni di gioco";
            // 
            // livelloGiocoToolStripMenuItem
            // 
            this.livelloGiocoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facileToolStripMenuItem,
            this.medioToolStripMenuItem,
            this.difficileToolStripMenuItem});
            this.livelloGiocoToolStripMenuItem.Name = "livelloGiocoToolStripMenuItem";
            this.livelloGiocoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.livelloGiocoToolStripMenuItem.Text = "Livello gioco";
            // 
            // facileToolStripMenuItem
            // 
            this.facileToolStripMenuItem.Name = "facileToolStripMenuItem";
            this.facileToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.facileToolStripMenuItem.Text = "Facile";
            this.facileToolStripMenuItem.Click += new System.EventHandler(this.facileToolStripMenuItem_Click);
            // 
            // medioToolStripMenuItem
            // 
            this.medioToolStripMenuItem.Name = "medioToolStripMenuItem";
            this.medioToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.medioToolStripMenuItem.Text = "Medio";
            // 
            // difficileToolStripMenuItem
            // 
            this.difficileToolStripMenuItem.Name = "difficileToolStripMenuItem";
            this.difficileToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.difficileToolStripMenuItem.Text = "Difficile";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // suoniToolStripMenuItem
            // 
            this.suoniToolStripMenuItem.Name = "suoniToolStripMenuItem";
            this.suoniToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.suoniToolStripMenuItem.Text = "Suoni";
            this.suoniToolStripMenuItem.Click += new System.EventHandler(this.suoniToolStripMenuItem_Click);
            // 
            // musicaDiSottofondoToolStripMenuItem
            // 
            this.musicaDiSottofondoToolStripMenuItem.Name = "musicaDiSottofondoToolStripMenuItem";
            this.musicaDiSottofondoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.musicaDiSottofondoToolStripMenuItem.Text = "Musica di sottofondo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(184, 6);
            // 
            // giocatoriToolStripMenuItem
            // 
            this.giocatoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unoToolStripMenuItem,
            this.dueToolStripMenuItem,
            this.treToolStripMenuItem,
            this.quattroToolStripMenuItem});
            this.giocatoriToolStripMenuItem.Name = "giocatoriToolStripMenuItem";
            this.giocatoriToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.giocatoriToolStripMenuItem.Text = "Giocatori";
            // 
            // unoToolStripMenuItem
            // 
            this.unoToolStripMenuItem.Name = "unoToolStripMenuItem";
            this.unoToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.unoToolStripMenuItem.Text = "Uno";
            // 
            // dueToolStripMenuItem
            // 
            this.dueToolStripMenuItem.Name = "dueToolStripMenuItem";
            this.dueToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.dueToolStripMenuItem.Text = "Due";
            // 
            // treToolStripMenuItem
            // 
            this.treToolStripMenuItem.Name = "treToolStripMenuItem";
            this.treToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.treToolStripMenuItem.Text = "Tre ";
            // 
            // quattroToolStripMenuItem
            // 
            this.quattroToolStripMenuItem.Name = "quattroToolStripMenuItem";
            this.quattroToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.quattroToolStripMenuItem.Text = "Quattro";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guidaToolStripMenuItem,
            this.informazioniSuLabirintoToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(25, 19);
            this.toolStripSplitButton1.Text = "?";
            // 
            // guidaToolStripMenuItem
            // 
            this.guidaToolStripMenuItem.Name = "guidaToolStripMenuItem";
            this.guidaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.guidaToolStripMenuItem.Text = "Guida";
            // 
            // informazioniSuLabirintoToolStripMenuItem
            // 
            this.informazioniSuLabirintoToolStripMenuItem.Name = "informazioniSuLabirintoToolStripMenuItem";
            this.informazioniSuLabirintoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.informazioniSuLabirintoToolStripMenuItem.Text = "Informazioni su Labirinto";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Flat Brush", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1090, 664);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 83);
            this.button2.TabIndex = 5;
            this.button2.Text = "Tira i dadi";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(892, 771);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Flat Brush", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(929, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 77);
            this.label1.TabIndex = 8;
            this.label1.Text = "Francesco, è il tuo turno!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1087, 754);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 59);
            this.label2.TabIndex = 10;
            this.label2.Text = "Qui verrà mostrato il numero uscito dai dadi...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1087, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 157);
            this.label3.TabIndex = 13;
            this.label3.Text = "Non hai ancora incontrato alcun oggetto magico...se ne troverai uno, allora verrà" +
    " mostrato qui...";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1090, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 128);
            this.label4.TabIndex = 14;
            this.label4.Text = "Punteggi parziali:\r\nFrancesco: 1\r\nRoberto: 2\r\nMaria: 1\r\nMassimo: 0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1354, 866);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Labirinto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem livelloGiocoToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem guidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informazioniSuLabirintoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficileToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem salvaLaPartitaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chiudiESalvaLaPartitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciSenzaSalvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem statisticheToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem suoniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicaDiSottofondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem giocatoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quattroToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

