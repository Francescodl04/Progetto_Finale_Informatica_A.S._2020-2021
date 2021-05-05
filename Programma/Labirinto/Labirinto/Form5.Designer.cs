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
            this.premessaBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.indietroPicBox = new System.Windows.Forms.PictureBox();
            this.indietroTTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indietroPicBox)).BeginInit();
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
            // formCapitoliIstruzioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Labirinto.Properties.Resources.sfondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 605);
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
            ((System.ComponentModel.ISupportInitialize)(this.indietroPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label indicazioniGioco;
        private System.Windows.Forms.Button premessaBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox indietroPicBox;
        private System.Windows.Forms.ToolTip indietroTTip;
    }
}