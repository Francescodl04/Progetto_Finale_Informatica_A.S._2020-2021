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
            this.istruzioniTxt = new System.Windows.Forms.TextBox();
            this.indietroPicBox = new System.Windows.Forms.PictureBox();
            this.indietroTTip = new System.Windows.Forms.ToolTip(this.components);
            this.contenitoreImmaginiPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.indietroCapitoliBtn = new System.Windows.Forms.Button();
            this.avantiCapitoliBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indietroPicBox)).BeginInit();
            this.contenitoreImmaginiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // indicazioniGioco
            // 
            this.indicazioniGioco.BackColor = System.Drawing.Color.Transparent;
            this.indicazioniGioco.Font = new System.Drawing.Font("Flat Brush", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicazioniGioco.Location = new System.Drawing.Point(517, 37);
            this.indicazioniGioco.Name = "indicazioniGioco";
            this.indicazioniGioco.Size = new System.Drawing.Size(445, 161);
            this.indicazioniGioco.TabIndex = 27;
            this.indicazioniGioco.Text = "Capitolo 0 - Layout grafico";
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
            // istruzioniTxt
            // 
            this.istruzioniTxt.BackColor = System.Drawing.Color.PapayaWhip;
            this.istruzioniTxt.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.istruzioniTxt.Location = new System.Drawing.Point(41, 219);
            this.istruzioniTxt.Multiline = true;
            this.istruzioniTxt.Name = "istruzioniTxt";
            this.istruzioniTxt.ReadOnly = true;
            this.istruzioniTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.istruzioniTxt.Size = new System.Drawing.Size(513, 267);
            this.istruzioniTxt.TabIndex = 28;
            this.istruzioniTxt.Text = "Qui verrà visualizzato il testo delle istruzioni...";
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
            // contenitoreImmaginiPanel
            // 
            this.contenitoreImmaginiPanel.BackColor = System.Drawing.Color.Transparent;
            this.contenitoreImmaginiPanel.BackgroundImage = global::Labirinto.Properties.Resources.pergamena;
            this.contenitoreImmaginiPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contenitoreImmaginiPanel.Controls.Add(this.pictureBox2);
            this.contenitoreImmaginiPanel.Controls.Add(this.pictureBox1);
            this.contenitoreImmaginiPanel.Location = new System.Drawing.Point(592, 210);
            this.contenitoreImmaginiPanel.Name = "contenitoreImmaginiPanel";
            this.contenitoreImmaginiPanel.Size = new System.Drawing.Size(352, 287);
            this.contenitoreImmaginiPanel.TabIndex = 51;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Labirinto.Properties.Resources.icona;
            this.pictureBox2.Location = new System.Drawing.Point(52, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 176);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Labirinto.Properties.Resources.puntodidomanda;
            this.pictureBox1.Location = new System.Drawing.Point(226, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // indietroCapitoliBtn
            // 
            this.indietroCapitoliBtn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indietroCapitoliBtn.Location = new System.Drawing.Point(110, 492);
            this.indietroCapitoliBtn.Name = "indietroCapitoliBtn";
            this.indietroCapitoliBtn.Size = new System.Drawing.Size(166, 76);
            this.indietroCapitoliBtn.TabIndex = 52;
            this.indietroCapitoliBtn.Text = "Torna al capitolo precedente";
            this.indietroCapitoliBtn.UseVisualStyleBackColor = true;
            this.indietroCapitoliBtn.Click += new System.EventHandler(this.indietroCapitoliBtn_Click);
            // 
            // avantiCapitoliBtn
            // 
            this.avantiCapitoliBtn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avantiCapitoliBtn.Location = new System.Drawing.Point(282, 492);
            this.avantiCapitoliBtn.Name = "avantiCapitoliBtn";
            this.avantiCapitoliBtn.Size = new System.Drawing.Size(166, 76);
            this.avantiCapitoliBtn.TabIndex = 53;
            this.avantiCapitoliBtn.Text = "Vai al capitolo successivo";
            this.avantiCapitoliBtn.UseVisualStyleBackColor = true;
            this.avantiCapitoliBtn.Click += new System.EventHandler(this.avantiCapitoliBtn_Click);
            // 
            // formLetturaIstruzioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Labirinto.Properties.Resources.sfondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 602);
            this.Controls.Add(this.avantiCapitoliBtn);
            this.Controls.Add(this.indietroCapitoliBtn);
            this.Controls.Add(this.contenitoreImmaginiPanel);
            this.Controls.Add(this.indietroPicBox);
            this.Controls.Add(this.istruzioniTxt);
            this.Controls.Add(this.indicazioniGioco);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formLetturaIstruzioni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Istruzioni d\'uso";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formLetturaIstruzioni_FormClosed);
            this.Load += new System.EventHandler(this.formLetturaIstruzioni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indietroPicBox)).EndInit();
            this.contenitoreImmaginiPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label indicazioniGioco;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox istruzioniTxt;
        private System.Windows.Forms.PictureBox indietroPicBox;
        private System.Windows.Forms.ToolTip indietroTTip;
        private System.Windows.Forms.Panel contenitoreImmaginiPanel;
        private System.Windows.Forms.Button indietroCapitoliBtn;
        private System.Windows.Forms.Button avantiCapitoliBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}