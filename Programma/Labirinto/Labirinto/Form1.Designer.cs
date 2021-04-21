namespace Labirinto
{
    partial class formCaricamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCaricamento));
            this.logo = new System.Windows.Forms.PictureBox();
            this.descrizioneOperazioni = new System.Windows.Forms.Label();
            this.barraProgressi = new System.Windows.Forms.ProgressBar();
            this.chiudi_gioco = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::Labirinto.Properties.Resources.logo1;
            this.logo.Location = new System.Drawing.Point(40, 36);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(438, 161);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // descrizioneOperazioni
            // 
            this.descrizioneOperazioni.AutoSize = true;
            this.descrizioneOperazioni.BackColor = System.Drawing.Color.Transparent;
            this.descrizioneOperazioni.Font = new System.Drawing.Font("Flat Brush", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrizioneOperazioni.Location = new System.Drawing.Point(101, 170);
            this.descrizioneOperazioni.Name = "descrizioneOperazioni";
            this.descrizioneOperazioni.Size = new System.Drawing.Size(242, 27);
            this.descrizioneOperazioni.TabIndex = 1;
            this.descrizioneOperazioni.Text = "Caricamento in corso...";
            // 
            // barraProgressi
            // 
            this.barraProgressi.Location = new System.Drawing.Point(40, 216);
            this.barraProgressi.Name = "barraProgressi";
            this.barraProgressi.Size = new System.Drawing.Size(415, 25);
            this.barraProgressi.TabIndex = 2;
            // 
            // chiudi_gioco
            // 
            this.chiudi_gioco.BackColor = System.Drawing.Color.OrangeRed;
            this.chiudi_gioco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chiudi_gioco.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiudi_gioco.Location = new System.Drawing.Point(446, 12);
            this.chiudi_gioco.Name = "chiudi_gioco";
            this.chiudi_gioco.Size = new System.Drawing.Size(37, 33);
            this.chiudi_gioco.TabIndex = 3;
            this.chiudi_gioco.Text = "x";
            this.chiudi_gioco.UseVisualStyleBackColor = false;
            this.chiudi_gioco.Click += new System.EventHandler(this.chiudi_gioco_Click);
            // 
            // formCaricamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Labirinto.Properties.Resources.sfondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 263);
            this.Controls.Add(this.chiudi_gioco);
            this.Controls.Add(this.barraProgressi);
            this.Controls.Add(this.descrizioneOperazioni);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formCaricamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caricamento in corso...";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label descrizioneOperazioni;
        private System.Windows.Forms.ProgressBar barraProgressi;
        private System.Windows.Forms.Button chiudi_gioco;
    }
}

