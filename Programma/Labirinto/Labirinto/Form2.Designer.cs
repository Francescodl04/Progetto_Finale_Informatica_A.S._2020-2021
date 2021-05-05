namespace Labirinto
{
    partial class formSchermataIniziale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSchermataIniziale));
            this.logo = new System.Windows.Forms.PictureBox();
            this.descrizioneOperazioni = new System.Windows.Forms.Label();
            this.giocaBtn = new System.Windows.Forms.Button();
            this.comesigiocaBtn = new System.Windows.Forms.Button();
            this.chiudiBtn = new System.Windows.Forms.Button();
            this.statisticheBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Enabled = false;
            this.logo.Image = global::Labirinto.Properties.Resources.logo1;
            this.logo.Location = new System.Drawing.Point(199, 31);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(438, 161);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // descrizioneOperazioni
            // 
            this.descrizioneOperazioni.AutoSize = true;
            this.descrizioneOperazioni.BackColor = System.Drawing.Color.Transparent;
            this.descrizioneOperazioni.Font = new System.Drawing.Font("Flat Brush", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrizioneOperazioni.Location = new System.Drawing.Point(40, 195);
            this.descrizioneOperazioni.Name = "descrizioneOperazioni";
            this.descrizioneOperazioni.Size = new System.Drawing.Size(725, 27);
            this.descrizioneOperazioni.TabIndex = 2;
            this.descrizioneOperazioni.Text = "Benvenuto nel gioco del Labirinto! Premi uno dei pulsanti per iniziare...";
            // 
            // giocaBtn
            // 
            this.giocaBtn.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giocaBtn.Location = new System.Drawing.Point(45, 271);
            this.giocaBtn.Name = "giocaBtn";
            this.giocaBtn.Size = new System.Drawing.Size(244, 124);
            this.giocaBtn.TabIndex = 4;
            this.giocaBtn.Text = "Gioca!";
            this.giocaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.giocaBtn.UseVisualStyleBackColor = true;
            this.giocaBtn.Click += new System.EventHandler(this.giocaBtn_Click);
            // 
            // comesigiocaBtn
            // 
            this.comesigiocaBtn.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comesigiocaBtn.Location = new System.Drawing.Point(549, 271);
            this.comesigiocaBtn.Name = "comesigiocaBtn";
            this.comesigiocaBtn.Size = new System.Drawing.Size(203, 58);
            this.comesigiocaBtn.TabIndex = 5;
            this.comesigiocaBtn.Text = "Come si gioca";
            this.comesigiocaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.comesigiocaBtn.UseVisualStyleBackColor = true;
            this.comesigiocaBtn.Click += new System.EventHandler(this.comesigiocaBtn_Click);
            // 
            // chiudiBtn
            // 
            this.chiudiBtn.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiudiBtn.Location = new System.Drawing.Point(549, 335);
            this.chiudiBtn.Name = "chiudiBtn";
            this.chiudiBtn.Size = new System.Drawing.Size(203, 58);
            this.chiudiBtn.TabIndex = 6;
            this.chiudiBtn.Text = "Esci";
            this.chiudiBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chiudiBtn.UseVisualStyleBackColor = true;
            this.chiudiBtn.Click += new System.EventHandler(this.chiudiBtn_Click);
            // 
            // statisticheBtn
            // 
            this.statisticheBtn.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticheBtn.Location = new System.Drawing.Point(295, 271);
            this.statisticheBtn.Name = "statisticheBtn";
            this.statisticheBtn.Size = new System.Drawing.Size(244, 122);
            this.statisticheBtn.TabIndex = 7;
            this.statisticheBtn.Text = "Vedi statistiche ";
            this.statisticheBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statisticheBtn.UseVisualStyleBackColor = true;
            this.statisticheBtn.Click += new System.EventHandler(this.statisticheBtn_Click);
            // 
            // formSchermataIniziale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Labirinto.Properties.Resources.sfondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 449);
            this.Controls.Add(this.statisticheBtn);
            this.Controls.Add(this.chiudiBtn);
            this.Controls.Add(this.comesigiocaBtn);
            this.Controls.Add(this.giocaBtn);
            this.Controls.Add(this.descrizioneOperazioni);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formSchermataIniziale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menù principale";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formSchermataIniziale_FormClosed);
            this.Load += new System.EventHandler(this.formSchermataIniziale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label descrizioneOperazioni;
        private System.Windows.Forms.Button giocaBtn;
        private System.Windows.Forms.Button comesigiocaBtn;
        private System.Windows.Forms.Button chiudiBtn;
        private System.Windows.Forms.Button statisticheBtn;
    }
}