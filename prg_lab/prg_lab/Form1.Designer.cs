namespace prg_lab
{
    partial class Labirinto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Labirinto));
            this.giocaBtn = new System.Windows.Forms.Button();
            this.istruzioniBtn = new System.Windows.Forms.Button();
            this.esciBtn = new System.Windows.Forms.Button();
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // giocaBtn
            // 
            this.giocaBtn.Location = new System.Drawing.Point(82, 264);
            this.giocaBtn.Name = "giocaBtn";
            this.giocaBtn.Size = new System.Drawing.Size(145, 120);
            this.giocaBtn.TabIndex = 0;
            this.giocaBtn.Text = "Gioca!";
            this.giocaBtn.UseVisualStyleBackColor = true;
            this.giocaBtn.Click += new System.EventHandler(this.giocaBtn_Click);
            // 
            // istruzioniBtn
            // 
            this.istruzioniBtn.Location = new System.Drawing.Point(247, 264);
            this.istruzioniBtn.Name = "istruzioniBtn";
            this.istruzioniBtn.Size = new System.Drawing.Size(145, 120);
            this.istruzioniBtn.TabIndex = 1;
            this.istruzioniBtn.Text = "Come si gioca?";
            this.istruzioniBtn.UseVisualStyleBackColor = true;
            this.istruzioniBtn.Click += new System.EventHandler(this.istruzioniBtn_Click);
            // 
            // esciBtn
            // 
            this.esciBtn.Location = new System.Drawing.Point(408, 264);
            this.esciBtn.Name = "esciBtn";
            this.esciBtn.Size = new System.Drawing.Size(145, 120);
            this.esciBtn.TabIndex = 2;
            this.esciBtn.Text = "Esci dal gioco";
            this.esciBtn.UseVisualStyleBackColor = true;
            this.esciBtn.Click += new System.EventHandler(this.esciBtn_Click);
            // 
            // logoPicBox
            // 
            this.logoPicBox.Image = global::prg_lab.Properties.Resources.logo1;
            this.logoPicBox.Location = new System.Drawing.Point(82, 84);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(471, 153);
            this.logoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoPicBox.TabIndex = 3;
            this.logoPicBox.TabStop = false;
            // 
            // Labirinto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 436);
            this.Controls.Add(this.logoPicBox);
            this.Controls.Add(this.esciBtn);
            this.Controls.Add(this.istruzioniBtn);
            this.Controls.Add(this.giocaBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Labirinto";
            this.Text = "Labirinto";
            this.Load += new System.EventHandler(this.Labirinto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button giocaBtn;
        private System.Windows.Forms.Button istruzioniBtn;
        private System.Windows.Forms.Button esciBtn;
        private System.Windows.Forms.PictureBox logoPicBox;
    }
}

