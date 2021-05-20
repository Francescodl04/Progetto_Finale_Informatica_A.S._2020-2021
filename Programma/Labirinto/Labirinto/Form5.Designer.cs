namespace Labirinto
{
    partial class formCapitoliIstruzioni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCapitoliIstruzioni));
            this.logo = new System.Windows.Forms.PictureBox();
            this.indicazioniGioco = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.indietroPicBox = new System.Windows.Forms.PictureBox();
            this.indietroTTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.cap3Btn = new System.Windows.Forms.Button();
            this.cap1Btn = new System.Windows.Forms.Button();
            this.cap2Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cap4Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cap5Btn = new System.Windows.Forms.Button();
            this.cap6Btn = new System.Windows.Forms.Button();
            this.cap7Btn = new System.Windows.Forms.Button();
            this.cap8Btn = new System.Windows.Forms.Button();
            this.cap9Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indietroPicBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::Labirinto.Properties.Resources.logo1;
            this.logo.Location = new System.Drawing.Point(44, 41);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(438, 161);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 24;
            this.logo.TabStop = false;
            // 
            // indicazioniGioco
            // 
            this.indicazioniGioco.AutoSize = true;
            this.indicazioniGioco.BackColor = System.Drawing.Color.Transparent;
            this.indicazioniGioco.Font = new System.Drawing.Font("Flat Brush", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicazioniGioco.Location = new System.Drawing.Point(495, 73);
            this.indicazioniGioco.Name = "indicazioniGioco";
            this.indicazioniGioco.Size = new System.Drawing.Size(473, 81);
            this.indicazioniGioco.TabIndex = 25;
            this.indicazioniGioco.Text = "Benvenuto nelle istruzioni d\'uso del gioco.\r\nScegli uno dei pulsanti per accedere" +
    " al relativo\r\ncapitolo del manuale...";
            this.indicazioniGioco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Labirinto.Properties.Resources.pergamena;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cap2Btn);
            this.panel1.Controls.Add(this.cap1Btn);
            this.panel1.Controls.Add(this.cap3Btn);
            this.panel1.Controls.Add(this.cap4Btn);
            this.panel1.Location = new System.Drawing.Point(69, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 398);
            this.panel1.TabIndex = 45;
            // 
            // indietroPicBox
            // 
            this.indietroPicBox.BackColor = System.Drawing.Color.Transparent;
            this.indietroPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.indietroPicBox.Image = ((System.Drawing.Image)(resources.GetObject("indietroPicBox.Image")));
            this.indietroPicBox.Location = new System.Drawing.Point(12, 12);
            this.indietroPicBox.Name = "indietroPicBox";
            this.indietroPicBox.Size = new System.Drawing.Size(50, 43);
            this.indietroPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.indietroPicBox.TabIndex = 46;
            this.indietroPicBox.TabStop = false;
            this.indietroTTip.SetToolTip(this.indietroPicBox, "Premi qui per ritornare al menu principale");
            this.indietroPicBox.Click += new System.EventHandler(this.indietroPicBox_Click);
            // 
            // indietroTTip
            // 
            this.indietroTTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.indietroTTip.ToolTipTitle = "Indietro";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Labirinto.Properties.Resources.pergamena;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.cap9Btn);
            this.panel2.Controls.Add(this.cap8Btn);
            this.panel2.Controls.Add(this.cap7Btn);
            this.panel2.Controls.Add(this.cap6Btn);
            this.panel2.Controls.Add(this.cap5Btn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(500, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 398);
            this.panel2.TabIndex = 46;
            // 
            // cap3Btn
            // 
            this.cap3Btn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cap3Btn.Location = new System.Drawing.Point(69, 231);
            this.cap3Btn.Name = "cap3Btn";
            this.cap3Btn.Size = new System.Drawing.Size(215, 55);
            this.cap3Btn.TabIndex = 44;
            this.cap3Btn.Text = "3- Schermata di caricamento";
            this.cap3Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cap3Btn.UseVisualStyleBackColor = true;
            this.cap3Btn.Click += new System.EventHandler(this.cap3Btn_Click);
            // 
            // cap1Btn
            // 
            this.cap1Btn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cap1Btn.Location = new System.Drawing.Point(69, 98);
            this.cap1Btn.Name = "cap1Btn";
            this.cap1Btn.Size = new System.Drawing.Size(215, 43);
            this.cap1Btn.TabIndex = 45;
            this.cap1Btn.Text = "1- Introduzione";
            this.cap1Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cap1Btn.UseVisualStyleBackColor = true;
            this.cap1Btn.Click += new System.EventHandler(this.cap1Btn_Click);
            // 
            // cap2Btn
            // 
            this.cap2Btn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cap2Btn.Location = new System.Drawing.Point(69, 147);
            this.cap2Btn.Name = "cap2Btn";
            this.cap2Btn.Size = new System.Drawing.Size(215, 78);
            this.cap2Btn.TabIndex = 46;
            this.cap2Btn.Text = "2- Descrizione del \r\nregolamento di gioco";
            this.cap2Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cap2Btn.UseVisualStyleBackColor = true;
            this.cap2Btn.Click += new System.EventHandler(this.cap2Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Flat Brush", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 27);
            this.label1.TabIndex = 47;
            this.label1.Text = "Istruzioni iniziali";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cap4Btn
            // 
            this.cap4Btn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cap4Btn.Location = new System.Drawing.Point(69, 292);
            this.cap4Btn.Name = "cap4Btn";
            this.cap4Btn.Size = new System.Drawing.Size(215, 43);
            this.cap4Btn.TabIndex = 45;
            this.cap4Btn.Text = "4- Menu principale";
            this.cap4Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cap4Btn.UseVisualStyleBackColor = true;
            this.cap4Btn.Click += new System.EventHandler(this.cap4Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Flat Brush", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 27);
            this.label2.TabIndex = 48;
            this.label2.Text = "Funzionamento del programma";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cap5Btn
            // 
            this.cap5Btn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cap5Btn.Location = new System.Drawing.Point(54, 98);
            this.cap5Btn.Name = "cap5Btn";
            this.cap5Btn.Size = new System.Drawing.Size(279, 43);
            this.cap5Btn.TabIndex = 49;
            this.cap5Btn.Text = "5- Scelta numero giocatori";
            this.cap5Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cap5Btn.UseVisualStyleBackColor = true;
            this.cap5Btn.Click += new System.EventHandler(this.cap5Btn_Click);
            // 
            // cap6Btn
            // 
            this.cap6Btn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cap6Btn.Location = new System.Drawing.Point(54, 147);
            this.cap6Btn.Name = "cap6Btn";
            this.cap6Btn.Size = new System.Drawing.Size(279, 43);
            this.cap6Btn.TabIndex = 50;
            this.cap6Btn.Text = "6- Scelta opzioni giocatore";
            this.cap6Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cap6Btn.UseVisualStyleBackColor = true;
            this.cap6Btn.Click += new System.EventHandler(this.cap6Btn_Click);
            // 
            // cap7Btn
            // 
            this.cap7Btn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cap7Btn.Location = new System.Drawing.Point(54, 194);
            this.cap7Btn.Name = "cap7Btn";
            this.cap7Btn.Size = new System.Drawing.Size(279, 43);
            this.cap7Btn.TabIndex = 51;
            this.cap7Btn.Text = "7- Tabellone di gioco";
            this.cap7Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cap7Btn.UseVisualStyleBackColor = true;
            this.cap7Btn.Click += new System.EventHandler(this.cap7Btn_Click);
            // 
            // cap8Btn
            // 
            this.cap8Btn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cap8Btn.Location = new System.Drawing.Point(54, 243);
            this.cap8Btn.Name = "cap8Btn";
            this.cap8Btn.Size = new System.Drawing.Size(279, 43);
            this.cap8Btn.TabIndex = 52;
            this.cap8Btn.Text = "8- Svolgimento della partita";
            this.cap8Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cap8Btn.UseVisualStyleBackColor = true;
            this.cap8Btn.Click += new System.EventHandler(this.cap8Btn_Click);
            // 
            // cap9Btn
            // 
            this.cap9Btn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cap9Btn.Location = new System.Drawing.Point(54, 292);
            this.cap9Btn.Name = "cap9Btn";
            this.cap9Btn.Size = new System.Drawing.Size(279, 43);
            this.cap9Btn.TabIndex = 53;
            this.cap9Btn.Text = "9- Fine della partita e statistiche";
            this.cap9Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cap9Btn.UseVisualStyleBackColor = true;
            this.cap9Btn.Click += new System.EventHandler(this.cap9Btn_Click);
            // 
            // formCapitoliIstruzioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Labirinto.Properties.Resources.sfondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 663);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.indietroPicBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.indicazioniGioco);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formCapitoliIstruzioni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Istruzioni d\'uso";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formCapitoliIstruzioni_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indietroPicBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label indicazioniGioco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox indietroPicBox;
        private System.Windows.Forms.ToolTip indietroTTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cap2Btn;
        private System.Windows.Forms.Button cap1Btn;
        private System.Windows.Forms.Button cap3Btn;
        private System.Windows.Forms.Button cap4Btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cap9Btn;
        private System.Windows.Forms.Button cap8Btn;
        private System.Windows.Forms.Button cap7Btn;
        private System.Windows.Forms.Button cap6Btn;
        private System.Windows.Forms.Button cap5Btn;
        private System.Windows.Forms.Label label2;
    }
}