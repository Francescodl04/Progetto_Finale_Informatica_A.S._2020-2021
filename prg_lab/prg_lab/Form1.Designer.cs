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
            this.benvenutoLbl = new System.Windows.Forms.Label();
            this.creditiBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // giocaBtn
            // 
            this.giocaBtn.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giocaBtn.Location = new System.Drawing.Point(92, 271);
            this.giocaBtn.Name = "giocaBtn";
            this.giocaBtn.Size = new System.Drawing.Size(165, 143);
            this.giocaBtn.TabIndex = 0;
            this.giocaBtn.Text = "Gioca!";
            this.giocaBtn.UseVisualStyleBackColor = true;
            this.giocaBtn.Click += new System.EventHandler(this.giocaBtn_Click);
            // 
            // istruzioniBtn
            // 
            this.istruzioniBtn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.istruzioniBtn.Location = new System.Drawing.Point(263, 271);
            this.istruzioniBtn.Name = "istruzioniBtn";
            this.istruzioniBtn.Size = new System.Drawing.Size(160, 143);
            this.istruzioniBtn.TabIndex = 1;
            this.istruzioniBtn.Text = "Come si gioca?";
            this.istruzioniBtn.UseVisualStyleBackColor = true;
            this.istruzioniBtn.Click += new System.EventHandler(this.istruzioniBtn_Click);
            // 
            // esciBtn
            // 
            this.esciBtn.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esciBtn.Location = new System.Drawing.Point(429, 271);
            this.esciBtn.Name = "esciBtn";
            this.esciBtn.Size = new System.Drawing.Size(172, 143);
            this.esciBtn.TabIndex = 2;
            this.esciBtn.Text = "Esci dal gioco";
            this.esciBtn.UseVisualStyleBackColor = true;
            this.esciBtn.Click += new System.EventHandler(this.esciBtn_Click);
            // 
            // logoPicBox
            // 
            this.logoPicBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPicBox.Image = global::prg_lab.Properties.Resources.logo1;
            this.logoPicBox.Location = new System.Drawing.Point(80, 12);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(537, 236);
            this.logoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoPicBox.TabIndex = 3;
            this.logoPicBox.TabStop = false;
            // 
            // benvenutoLbl
            // 
            this.benvenutoLbl.AutoSize = true;
            this.benvenutoLbl.BackColor = System.Drawing.Color.Transparent;
            this.benvenutoLbl.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benvenutoLbl.Location = new System.Drawing.Point(58, 213);
            this.benvenutoLbl.Name = "benvenutoLbl";
            this.benvenutoLbl.Size = new System.Drawing.Size(583, 22);
            this.benvenutoLbl.TabIndex = 4;
            this.benvenutoLbl.Text = "Benvenuto nel gioco del Labirinto! Premi uno dei pulsanti per iniziare...";
            // 
            // creditiBtn
            // 
            this.creditiBtn.Location = new System.Drawing.Point(13, 13);
            this.creditiBtn.Name = "creditiBtn";
            this.creditiBtn.Size = new System.Drawing.Size(75, 23);
            this.creditiBtn.TabIndex = 5;
            this.creditiBtn.Text = "Crediti";
            this.creditiBtn.UseVisualStyleBackColor = true;
            // 
            // Labirinto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prg_lab.Properties.Resources.fondo_pag_iniziale;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(698, 476);
            this.Controls.Add(this.creditiBtn);
            this.Controls.Add(this.benvenutoLbl);
            this.Controls.Add(this.logoPicBox);
            this.Controls.Add(this.esciBtn);
            this.Controls.Add(this.istruzioniBtn);
            this.Controls.Add(this.giocaBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Labirinto";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Labirinto";
            this.Load += new System.EventHandler(this.Labirinto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giocaBtn;
        private System.Windows.Forms.Button istruzioniBtn;
        private System.Windows.Forms.Button esciBtn;
        private System.Windows.Forms.PictureBox logoPicBox;
        private System.Windows.Forms.Label benvenutoLbl;
        private System.Windows.Forms.Button creditiBtn;
    }
}

