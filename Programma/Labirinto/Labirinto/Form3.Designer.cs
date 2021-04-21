namespace Labirinto
{
    partial class salvataggio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salvataggio));
            this.nuovapartitaBtn = new System.Windows.Forms.Button();
            this.chiudiBtn = new System.Windows.Forms.Button();
            this.homepageBtn = new System.Windows.Forms.Button();
            this.continuaBtn = new System.Windows.Forms.Button();
            this.descrizioneOperazioni = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // nuovapartitaBtn
            // 
            this.nuovapartitaBtn.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuovapartitaBtn.Location = new System.Drawing.Point(293, 283);
            this.nuovapartitaBtn.Name = "nuovapartitaBtn";
            this.nuovapartitaBtn.Size = new System.Drawing.Size(244, 122);
            this.nuovapartitaBtn.TabIndex = 13;
            this.nuovapartitaBtn.Text = "Nuova partita";
            this.nuovapartitaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuovapartitaBtn.UseVisualStyleBackColor = true;
            // 
            // chiudiBtn
            // 
            this.chiudiBtn.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiudiBtn.Location = new System.Drawing.Point(547, 347);
            this.chiudiBtn.Name = "chiudiBtn";
            this.chiudiBtn.Size = new System.Drawing.Size(203, 58);
            this.chiudiBtn.TabIndex = 12;
            this.chiudiBtn.Text = "Esci";
            this.chiudiBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chiudiBtn.UseVisualStyleBackColor = true;
            this.chiudiBtn.Click += new System.EventHandler(this.chiudiBtn_Click);
            // 
            // homepageBtn
            // 
            this.homepageBtn.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepageBtn.Location = new System.Drawing.Point(547, 283);
            this.homepageBtn.Name = "homepageBtn";
            this.homepageBtn.Size = new System.Drawing.Size(203, 58);
            this.homepageBtn.TabIndex = 11;
            this.homepageBtn.Text = "Ritorna al menù principale";
            this.homepageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homepageBtn.UseVisualStyleBackColor = true;
            this.homepageBtn.Click += new System.EventHandler(this.homepageBtn_Click);
            // 
            // continuaBtn
            // 
            this.continuaBtn.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuaBtn.Location = new System.Drawing.Point(43, 283);
            this.continuaBtn.Name = "continuaBtn";
            this.continuaBtn.Size = new System.Drawing.Size(244, 124);
            this.continuaBtn.TabIndex = 10;
            this.continuaBtn.Text = "Continua con il salvataggio";
            this.continuaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.continuaBtn.UseVisualStyleBackColor = true;
            // 
            // descrizioneOperazioni
            // 
            this.descrizioneOperazioni.AutoSize = true;
            this.descrizioneOperazioni.BackColor = System.Drawing.Color.Transparent;
            this.descrizioneOperazioni.Font = new System.Drawing.Font("Flat Brush", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrizioneOperazioni.Location = new System.Drawing.Point(38, 207);
            this.descrizioneOperazioni.Name = "descrizioneOperazioni";
            this.descrizioneOperazioni.Size = new System.Drawing.Size(0, 27);
            this.descrizioneOperazioni.TabIndex = 9;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::Labirinto.Properties.Resources.logo1;
            this.logo.Location = new System.Drawing.Point(197, 43);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(438, 161);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 8;
            this.logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Flat Brush", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 54);
            this.label1.TabIndex = 14;
            this.label1.Text = "Durante l\'apertura del gioco è stato rilevato un salvataggio.\r\nVuoi continuare co" +
    "n quello o iniziare una nuova partita?";
            // 
            // salvataggio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Labirinto.Properties.Resources.sfondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nuovapartitaBtn);
            this.Controls.Add(this.chiudiBtn);
            this.Controls.Add(this.homepageBtn);
            this.Controls.Add(this.continuaBtn);
            this.Controls.Add(this.descrizioneOperazioni);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "salvataggio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presenza di salvataggio";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nuovapartitaBtn;
        private System.Windows.Forms.Button chiudiBtn;
        private System.Windows.Forms.Button homepageBtn;
        private System.Windows.Forms.Button continuaBtn;
        private System.Windows.Forms.Label descrizioneOperazioni;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
    }
}