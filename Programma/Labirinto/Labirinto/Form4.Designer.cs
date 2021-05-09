namespace Labirinto
{
    partial class formScelteGioco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formScelteGioco));
            this.indicazioniGioco = new System.Windows.Forms.Label();
            this.descrizioneOperazioni = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.elmoRadBtn = new System.Windows.Forms.RadioButton();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.coronaRadBtn = new System.Windows.Forms.RadioButton();
            this.falenaRadBtn = new System.Windows.Forms.RadioButton();
            this.gekoRadBtn = new System.Windows.Forms.RadioButton();
            this.labirintoReRadBtn = new System.Windows.Forms.RadioButton();
            this.diamanteRadBtn = new System.Windows.Forms.RadioButton();
            this.saliScendiRadBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.scacchieraRadBtn = new System.Windows.Forms.RadioButton();
            this.descrizionePedina = new System.Windows.Forms.Label();
            this.descrizioneTabellone = new System.Windows.Forms.Label();
            this.confermaBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pedinaPicBox = new System.Windows.Forms.PictureBox();
            this.tabellonePicBox = new System.Windows.Forms.PictureBox();
            this.indietroPicBox = new System.Windows.Forms.PictureBox();
            this.indietroTTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedinaPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabellonePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indietroPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // indicazioniGioco
            // 
            this.indicazioniGioco.AutoSize = true;
            this.indicazioniGioco.BackColor = System.Drawing.Color.Transparent;
            this.indicazioniGioco.Font = new System.Drawing.Font("Flat Brush", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicazioniGioco.Location = new System.Drawing.Point(562, 105);
            this.indicazioniGioco.Name = "indicazioniGioco";
            this.indicazioniGioco.Size = new System.Drawing.Size(351, 27);
            this.indicazioniGioco.TabIndex = 23;
            this.indicazioniGioco.Text = "Giocatore 1, effettua le tue scelte...";
            // 
            // descrizioneOperazioni
            // 
            this.descrizioneOperazioni.AutoSize = true;
            this.descrizioneOperazioni.BackColor = System.Drawing.Color.Transparent;
            this.descrizioneOperazioni.Font = new System.Drawing.Font("Flat Brush", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrizioneOperazioni.Location = new System.Drawing.Point(38, 206);
            this.descrizioneOperazioni.Name = "descrizioneOperazioni";
            this.descrizioneOperazioni.Size = new System.Drawing.Size(0, 27);
            this.descrizioneOperazioni.TabIndex = 18;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::Labirinto.Properties.Resources.logo1;
            this.logo.Location = new System.Drawing.Point(43, 42);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(438, 161);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 17;
            this.logo.TabStop = false;
            // 
            // elmoRadBtn
            // 
            this.elmoRadBtn.AutoSize = true;
            this.elmoRadBtn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elmoRadBtn.Location = new System.Drawing.Point(40, 74);
            this.elmoRadBtn.Name = "elmoRadBtn";
            this.elmoRadBtn.Size = new System.Drawing.Size(176, 26);
            this.elmoRadBtn.TabIndex = 0;
            this.elmoRadBtn.Text = "Elmo del cavaliere";
            this.elmoRadBtn.UseVisualStyleBackColor = true;
            this.elmoRadBtn.CheckedChanged += new System.EventHandler(this.elmoRadBtn_CheckedChanged);
            // 
            // nomeTxt
            // 
            this.nomeTxt.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTxt.Location = new System.Drawing.Point(43, 209);
            this.nomeTxt.Multiline = true;
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(969, 34);
            this.nomeTxt.TabIndex = 26;
            this.nomeTxt.Text = "Inserisci qui il tuo nome...";
            this.nomeTxt.Click += new System.EventHandler(this.nomeTxt_Click);
            this.nomeTxt.TextChanged += new System.EventHandler(this.nomeTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Scelta della pedina";
            // 
            // coronaRadBtn
            // 
            this.coronaRadBtn.AutoSize = true;
            this.coronaRadBtn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coronaRadBtn.Location = new System.Drawing.Point(40, 106);
            this.coronaRadBtn.Name = "coronaRadBtn";
            this.coronaRadBtn.Size = new System.Drawing.Size(140, 26);
            this.coronaRadBtn.TabIndex = 28;
            this.coronaRadBtn.Text = "Corona del Re";
            this.coronaRadBtn.UseVisualStyleBackColor = true;
            this.coronaRadBtn.CheckedChanged += new System.EventHandler(this.coronaRadBtn_CheckedChanged);
            // 
            // falenaRadBtn
            // 
            this.falenaRadBtn.AutoSize = true;
            this.falenaRadBtn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.falenaRadBtn.Location = new System.Drawing.Point(40, 170);
            this.falenaRadBtn.Name = "falenaRadBtn";
            this.falenaRadBtn.Size = new System.Drawing.Size(82, 26);
            this.falenaRadBtn.TabIndex = 29;
            this.falenaRadBtn.Text = "Falena";
            this.falenaRadBtn.UseVisualStyleBackColor = true;
            this.falenaRadBtn.CheckedChanged += new System.EventHandler(this.falenaRadBtn_CheckedChanged);
            // 
            // gekoRadBtn
            // 
            this.gekoRadBtn.AutoSize = true;
            this.gekoRadBtn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gekoRadBtn.Location = new System.Drawing.Point(40, 138);
            this.gekoRadBtn.Name = "gekoRadBtn";
            this.gekoRadBtn.Size = new System.Drawing.Size(68, 26);
            this.gekoRadBtn.TabIndex = 30;
            this.gekoRadBtn.Text = "Geko";
            this.gekoRadBtn.UseVisualStyleBackColor = true;
            this.gekoRadBtn.CheckedChanged += new System.EventHandler(this.gekoRadBtn_CheckedChanged);
            // 
            // labirintoReRadBtn
            // 
            this.labirintoReRadBtn.AutoSize = true;
            this.labirintoReRadBtn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labirintoReRadBtn.Location = new System.Drawing.Point(26, 170);
            this.labirintoReRadBtn.Name = "labirintoReRadBtn";
            this.labirintoReRadBtn.Size = new System.Drawing.Size(185, 26);
            this.labirintoReRadBtn.TabIndex = 30;
            this.labirintoReRadBtn.Text = "Il \"Labirinto del Re\"";
            this.labirintoReRadBtn.UseVisualStyleBackColor = true;
            this.labirintoReRadBtn.CheckedChanged += new System.EventHandler(this.labirintoReRadBtn_CheckedChanged);
            // 
            // diamanteRadBtn
            // 
            this.diamanteRadBtn.AutoSize = true;
            this.diamanteRadBtn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diamanteRadBtn.Location = new System.Drawing.Point(26, 138);
            this.diamanteRadBtn.Name = "diamanteRadBtn";
            this.diamanteRadBtn.Size = new System.Drawing.Size(136, 26);
            this.diamanteRadBtn.TabIndex = 29;
            this.diamanteRadBtn.Text = "Il \"Diamante\"";
            this.diamanteRadBtn.UseVisualStyleBackColor = true;
            this.diamanteRadBtn.CheckedChanged += new System.EventHandler(this.diamanteRadBtn_CheckedChanged);
            // 
            // saliScendiRadBtn
            // 
            this.saliScendiRadBtn.AutoSize = true;
            this.saliScendiRadBtn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saliScendiRadBtn.Location = new System.Drawing.Point(26, 106);
            this.saliScendiRadBtn.Name = "saliScendiRadBtn";
            this.saliScendiRadBtn.Size = new System.Drawing.Size(160, 26);
            this.saliScendiRadBtn.TabIndex = 28;
            this.saliScendiRadBtn.Text = "Il \"Sali e Scendi\"";
            this.saliScendiRadBtn.UseVisualStyleBackColor = true;
            this.saliScendiRadBtn.CheckedChanged += new System.EventHandler(this.saliScendiRadBtn_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Scelta del tabellone";
            // 
            // scacchieraRadBtn
            // 
            this.scacchieraRadBtn.AutoSize = true;
            this.scacchieraRadBtn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scacchieraRadBtn.Location = new System.Drawing.Point(26, 74);
            this.scacchieraRadBtn.Name = "scacchieraRadBtn";
            this.scacchieraRadBtn.Size = new System.Drawing.Size(154, 26);
            this.scacchieraRadBtn.TabIndex = 0;
            this.scacchieraRadBtn.Text = "La \"Scacchiera\"";
            this.scacchieraRadBtn.UseVisualStyleBackColor = true;
            this.scacchieraRadBtn.CheckedChanged += new System.EventHandler(this.scacchieraRadBtn_CheckedChanged);
            // 
            // descrizionePedina
            // 
            this.descrizionePedina.AutoSize = true;
            this.descrizionePedina.BackColor = System.Drawing.Color.Transparent;
            this.descrizionePedina.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrizionePedina.Location = new System.Drawing.Point(39, 514);
            this.descrizionePedina.Name = "descrizionePedina";
            this.descrizionePedina.Size = new System.Drawing.Size(368, 44);
            this.descrizionePedina.TabIndex = 32;
            this.descrizionePedina.Text = "Scegli una pedina: qui ne verrà visualizzata \r\nla descrizione...";
            this.descrizionePedina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descrizioneTabellone
            // 
            this.descrizioneTabellone.AutoSize = true;
            this.descrizioneTabellone.BackColor = System.Drawing.Color.Transparent;
            this.descrizioneTabellone.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrizioneTabellone.Location = new System.Drawing.Point(563, 514);
            this.descrizioneTabellone.Name = "descrizioneTabellone";
            this.descrizioneTabellone.Size = new System.Drawing.Size(376, 44);
            this.descrizioneTabellone.TabIndex = 33;
            this.descrizioneTabellone.Text = "Scegli un tabellone: qui ne verrà visualizzata \r\nla descrizione...";
            this.descrizioneTabellone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confermaBtn
            // 
            this.confermaBtn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confermaBtn.Location = new System.Drawing.Point(43, 574);
            this.confermaBtn.Name = "confermaBtn";
            this.confermaBtn.Size = new System.Drawing.Size(969, 43);
            this.confermaBtn.TabIndex = 36;
            this.confermaBtn.Text = "Conferma le tue scelte";
            this.confermaBtn.UseVisualStyleBackColor = true;
            this.confermaBtn.Click += new System.EventHandler(this.confermaBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Labirinto.Properties.Resources.pergamena;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.elmoRadBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.coronaRadBtn);
            this.panel1.Controls.Add(this.gekoRadBtn);
            this.panel1.Controls.Add(this.falenaRadBtn);
            this.panel1.Location = new System.Drawing.Point(43, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 240);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Labirinto.Properties.Resources.pergamena;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.labirintoReRadBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.diamanteRadBtn);
            this.panel2.Controls.Add(this.scacchieraRadBtn);
            this.panel2.Controls.Add(this.saliScendiRadBtn);
            this.panel2.Location = new System.Drawing.Point(558, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 240);
            this.panel2.TabIndex = 38;
            // 
            // pedinaPicBox
            // 
            this.pedinaPicBox.BackColor = System.Drawing.Color.Transparent;
            this.pedinaPicBox.Location = new System.Drawing.Point(334, 300);
            this.pedinaPicBox.Name = "pedinaPicBox";
            this.pedinaPicBox.Size = new System.Drawing.Size(170, 148);
            this.pedinaPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pedinaPicBox.TabIndex = 39;
            this.pedinaPicBox.TabStop = false;
            // 
            // tabellonePicBox
            // 
            this.tabellonePicBox.BackColor = System.Drawing.Color.Transparent;
            this.tabellonePicBox.Location = new System.Drawing.Point(842, 300);
            this.tabellonePicBox.Name = "tabellonePicBox";
            this.tabellonePicBox.Size = new System.Drawing.Size(170, 148);
            this.tabellonePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tabellonePicBox.TabIndex = 40;
            this.tabellonePicBox.TabStop = false;
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
            this.indietroPicBox.TabIndex = 41;
            this.indietroPicBox.TabStop = false;
            this.indietroTTip.SetToolTip(this.indietroPicBox, "Premi qui per tornare alla scelta dei giocatori");
            this.indietroPicBox.Click += new System.EventHandler(this.indietroPicBox_Click);
            // 
            // indietroTTip
            // 
            this.indietroTTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.indietroTTip.ToolTipTitle = "Indietro";
            // 
            // formScelteGioco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Labirinto.Properties.Resources.sfondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1037, 647);
            this.Controls.Add(this.indietroPicBox);
            this.Controls.Add(this.tabellonePicBox);
            this.Controls.Add(this.pedinaPicBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.confermaBtn);
            this.Controls.Add(this.descrizioneTabellone);
            this.Controls.Add(this.descrizionePedina);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.indicazioniGioco);
            this.Controls.Add(this.descrizioneOperazioni);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formScelteGioco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scelte di gioco";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formScelteGioco_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedinaPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabellonePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indietroPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label indicazioniGioco;
        private System.Windows.Forms.Label descrizioneOperazioni;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.RadioButton elmoRadBtn;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.RadioButton gekoRadBtn;
        private System.Windows.Forms.RadioButton falenaRadBtn;
        private System.Windows.Forms.RadioButton coronaRadBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton labirintoReRadBtn;
        private System.Windows.Forms.RadioButton diamanteRadBtn;
        private System.Windows.Forms.RadioButton saliScendiRadBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton scacchieraRadBtn;
        private System.Windows.Forms.Label descrizionePedina;
        private System.Windows.Forms.Label descrizioneTabellone;
        private System.Windows.Forms.Button confermaBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pedinaPicBox;
        private System.Windows.Forms.PictureBox tabellonePicBox;
        private System.Windows.Forms.PictureBox indietroPicBox;
        private System.Windows.Forms.ToolTip indietroTTip;
    }
}