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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCapitoliIstruzioni));
            this.logo = new System.Windows.Forms.PictureBox();
            this.indicazioniGioco = new System.Windows.Forms.Label();
            this.homepageBtn = new System.Windows.Forms.Button();
            this.esciBtn = new System.Windows.Forms.Button();
            this.premessaBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
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
            // homepageBtn
            // 
            this.homepageBtn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepageBtn.Location = new System.Drawing.Point(657, 535);
            this.homepageBtn.Name = "homepageBtn";
            this.homepageBtn.Size = new System.Drawing.Size(311, 43);
            this.homepageBtn.TabIndex = 43;
            this.homepageBtn.Text = "Ritorna al menù principale";
            this.homepageBtn.UseVisualStyleBackColor = true;
            // 
            // esciBtn
            // 
            this.esciBtn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esciBtn.Location = new System.Drawing.Point(23, 535);
            this.esciBtn.Name = "esciBtn";
            this.esciBtn.Size = new System.Drawing.Size(311, 43);
            this.esciBtn.TabIndex = 41;
            this.esciBtn.Text = "Esci";
            this.esciBtn.UseVisualStyleBackColor = true;
            // 
            // premessaBtn
            // 
            this.premessaBtn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premessaBtn.Location = new System.Drawing.Point(56, 48);
            this.premessaBtn.Name = "premessaBtn";
            this.premessaBtn.Size = new System.Drawing.Size(176, 43);
            this.premessaBtn.TabIndex = 44;
            this.premessaBtn.Text = "0- Premessa";
            this.premessaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.premessaBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Labirinto.Properties.Resources.pergamena;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.premessaBtn);
            this.panel1.Location = new System.Drawing.Point(23, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 265);
            this.panel1.TabIndex = 45;
            // 
            // formCapitoliIstruzioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Labirinto.Properties.Resources.sfondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.homepageBtn);
            this.Controls.Add(this.esciBtn);
            this.Controls.Add(this.indicazioniGioco);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formCapitoliIstruzioni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Istruzioni d\'uso";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label indicazioniGioco;
        private System.Windows.Forms.Button homepageBtn;
        private System.Windows.Forms.Button esciBtn;
        private System.Windows.Forms.Button premessaBtn;
        private System.Windows.Forms.Panel panel1;
    }
}