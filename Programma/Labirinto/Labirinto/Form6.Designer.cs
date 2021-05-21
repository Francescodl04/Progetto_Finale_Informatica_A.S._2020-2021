namespace Labirinto
{
    partial class formLetturaIstruzioni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLetturaIstruzioni));
            this.indicazioniGioco = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.indietroPicBox = new System.Windows.Forms.PictureBox();
            this.indietroTTip = new System.Windows.Forms.ToolTip(this.components);
            this.indietroCapitoliPicBox = new System.Windows.Forms.PictureBox();
            this.avantiCapitoliPicBox = new System.Windows.Forms.PictureBox();
            this.avantiTTip = new System.Windows.Forms.ToolTip(this.components);
            this.immagineCapitoliPicBox = new System.Windows.Forms.PictureBox();
            this.contenitoreImmaginiPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indietroPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indietroCapitoliPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avantiCapitoliPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.immagineCapitoliPicBox)).BeginInit();
            this.contenitoreImmaginiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // indicazioniGioco
            // 
            this.indicazioniGioco.AutoSize = true;
            this.indicazioniGioco.BackColor = System.Drawing.Color.Transparent;
            this.indicazioniGioco.Font = new System.Drawing.Font("Flat Brush", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicazioniGioco.Location = new System.Drawing.Point(627, 105);
            this.indicazioniGioco.Name = "indicazioniGioco";
            this.indicazioniGioco.Size = new System.Drawing.Size(229, 27);
            this.indicazioniGioco.TabIndex = 27;
            this.indicazioniGioco.Text = "Capitolo 0 - Premessa";
            this.indicazioniGioco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::Labirinto.Properties.Resources.logo1;
            this.logo.Location = new System.Drawing.Point(46, 37);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(438, 161);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 26;
            this.logo.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.textBox1.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(41, 219);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(513, 267);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = "Grazie per aver scelto Labirinto!";
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
            this.indietroPicBox.TabIndex = 47;
            this.indietroPicBox.TabStop = false;
            this.indietroTTip.SetToolTip(this.indietroPicBox, "Torna alla scelta dei capitoli");
            this.indietroPicBox.Click += new System.EventHandler(this.indietroPicBox_Click);
            // 
            // indietroTTip
            // 
            this.indietroTTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.indietroTTip.ToolTipTitle = "Indietro";
            // 
            // indietroCapitoliPicBox
            // 
            this.indietroCapitoliPicBox.BackColor = System.Drawing.Color.Transparent;
            this.indietroCapitoliPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.indietroCapitoliPicBox.Image = ((System.Drawing.Image)(resources.GetObject("indietroCapitoliPicBox.Image")));
            this.indietroCapitoliPicBox.Location = new System.Drawing.Point(181, 492);
            this.indietroCapitoliPicBox.Name = "indietroCapitoliPicBox";
            this.indietroCapitoliPicBox.Size = new System.Drawing.Size(86, 81);
            this.indietroCapitoliPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.indietroCapitoliPicBox.TabIndex = 48;
            this.indietroCapitoliPicBox.TabStop = false;
            this.indietroTTip.SetToolTip(this.indietroCapitoliPicBox, "Torna al capitolo precedente");
            // 
            // avantiCapitoliPicBox
            // 
            this.avantiCapitoliPicBox.BackColor = System.Drawing.Color.Transparent;
            this.avantiCapitoliPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avantiCapitoliPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avantiCapitoliPicBox.Image = global::Labirinto.Properties.Resources.frecciaavanti;
            this.avantiCapitoliPicBox.Location = new System.Drawing.Point(266, 492);
            this.avantiCapitoliPicBox.Name = "avantiCapitoliPicBox";
            this.avantiCapitoliPicBox.Size = new System.Drawing.Size(86, 81);
            this.avantiCapitoliPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avantiCapitoliPicBox.TabIndex = 49;
            this.avantiCapitoliPicBox.TabStop = false;
            this.avantiTTip.SetToolTip(this.avantiCapitoliPicBox, "Vai al capitolo successivo");
            // 
            // avantiTTip
            // 
            this.avantiTTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.avantiTTip.ToolTipTitle = "Avanti";
            // 
            // immagineCapitoliPicBox
            // 
            this.immagineCapitoliPicBox.BackColor = System.Drawing.Color.Transparent;
            this.immagineCapitoliPicBox.Image = global::Labirinto.Properties.Resources.icona;
            this.immagineCapitoliPicBox.Location = new System.Drawing.Point(18, 43);
            this.immagineCapitoliPicBox.Name = "immagineCapitoliPicBox";
            this.immagineCapitoliPicBox.Size = new System.Drawing.Size(313, 202);
            this.immagineCapitoliPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.immagineCapitoliPicBox.TabIndex = 50;
            this.immagineCapitoliPicBox.TabStop = false;
            // 
            // contenitoreImmaginiPanel
            // 
            this.contenitoreImmaginiPanel.BackColor = System.Drawing.Color.Transparent;
            this.contenitoreImmaginiPanel.BackgroundImage = global::Labirinto.Properties.Resources.pergamena;
            this.contenitoreImmaginiPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contenitoreImmaginiPanel.Controls.Add(this.immagineCapitoliPicBox);
            this.contenitoreImmaginiPanel.Location = new System.Drawing.Point(592, 210);
            this.contenitoreImmaginiPanel.Name = "contenitoreImmaginiPanel";
            this.contenitoreImmaginiPanel.Size = new System.Drawing.Size(352, 287);
            this.contenitoreImmaginiPanel.TabIndex = 51;
            // 
            // formLetturaIstruzioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Labirinto.Properties.Resources.sfondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 602);
            this.Controls.Add(this.contenitoreImmaginiPanel);
            this.Controls.Add(this.avantiCapitoliPicBox);
            this.Controls.Add(this.indietroCapitoliPicBox);
            this.Controls.Add(this.indietroPicBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.indicazioniGioco);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formLetturaIstruzioni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capitolo 0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formLetturaIstruzioni_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indietroPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indietroCapitoliPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avantiCapitoliPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.immagineCapitoliPicBox)).EndInit();
            this.contenitoreImmaginiPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label indicazioniGioco;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox indietroPicBox;
        private System.Windows.Forms.ToolTip indietroTTip;
        private System.Windows.Forms.PictureBox indietroCapitoliPicBox;
        private System.Windows.Forms.PictureBox avantiCapitoliPicBox;
        private System.Windows.Forms.ToolTip avantiTTip;
        private System.Windows.Forms.PictureBox immagineCapitoliPicBox;
        private System.Windows.Forms.Panel contenitoreImmaginiPanel;
    }
}