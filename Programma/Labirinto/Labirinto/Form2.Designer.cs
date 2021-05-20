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
            this.comeSiGiocaBtn = new System.Windows.Forms.Button();
            this.statisticheBtn = new System.Windows.Forms.Button();
            this.giocaPicBox = new System.Windows.Forms.PictureBox();
            this.statistichePicBox = new System.Windows.Forms.PictureBox();
            this.comeSiGiocaPicBox = new System.Windows.Forms.PictureBox();
            this.giocaPanel = new System.Windows.Forms.Panel();
            this.statistichePanel = new System.Windows.Forms.Panel();
            this.comeSiGiocaPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giocaPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistichePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comeSiGiocaPicBox)).BeginInit();
            this.giocaPanel.SuspendLayout();
            this.statistichePanel.SuspendLayout();
            this.comeSiGiocaPanel.SuspendLayout();
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
            this.giocaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.giocaBtn.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giocaBtn.Location = new System.Drawing.Point(48, 36);
            this.giocaBtn.Name = "giocaBtn";
            this.giocaBtn.Size = new System.Drawing.Size(115, 105);
            this.giocaBtn.TabIndex = 4;
            this.giocaBtn.Text = "Gioca!";
            this.giocaBtn.UseVisualStyleBackColor = true;
            this.giocaBtn.Visible = false;
            this.giocaBtn.Click += new System.EventHandler(this.giocaBtn_Click);
            // 
            // comeSiGiocaBtn
            // 
            this.comeSiGiocaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comeSiGiocaBtn.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comeSiGiocaBtn.Location = new System.Drawing.Point(50, 31);
            this.comeSiGiocaBtn.Name = "comeSiGiocaBtn";
            this.comeSiGiocaBtn.Size = new System.Drawing.Size(118, 105);
            this.comeSiGiocaBtn.TabIndex = 5;
            this.comeSiGiocaBtn.Text = "Come si \r\ngioca";
            this.comeSiGiocaBtn.UseVisualStyleBackColor = true;
            this.comeSiGiocaBtn.Visible = false;
            this.comeSiGiocaBtn.Click += new System.EventHandler(this.comesigiocaBtn_Click);
            // 
            // statisticheBtn
            // 
            this.statisticheBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statisticheBtn.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticheBtn.Location = new System.Drawing.Point(53, 31);
            this.statisticheBtn.Name = "statisticheBtn";
            this.statisticheBtn.Size = new System.Drawing.Size(118, 105);
            this.statisticheBtn.TabIndex = 7;
            this.statisticheBtn.Text = "Vedi \r\nstatistiche ";
            this.statisticheBtn.UseVisualStyleBackColor = true;
            this.statisticheBtn.Visible = false;
            this.statisticheBtn.Click += new System.EventHandler(this.statisticheBtn_Click);
            // 
            // giocaPicBox
            // 
            this.giocaPicBox.BackColor = System.Drawing.Color.Transparent;
            this.giocaPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.giocaPicBox.Image = global::Labirinto.Properties.Resources.frecciaavanti;
            this.giocaPicBox.Location = new System.Drawing.Point(48, 37);
            this.giocaPicBox.Name = "giocaPicBox";
            this.giocaPicBox.Size = new System.Drawing.Size(115, 105);
            this.giocaPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.giocaPicBox.TabIndex = 8;
            this.giocaPicBox.TabStop = false;
            this.giocaPicBox.MouseHover += new System.EventHandler(this.giocaPicBox_MouseHover);
            // 
            // statistichePicBox
            // 
            this.statistichePicBox.BackColor = System.Drawing.Color.Transparent;
            this.statistichePicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statistichePicBox.Image = global::Labirinto.Properties.Resources.grafico_statistiche;
            this.statistichePicBox.Location = new System.Drawing.Point(53, 37);
            this.statistichePicBox.Name = "statistichePicBox";
            this.statistichePicBox.Size = new System.Drawing.Size(110, 99);
            this.statistichePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.statistichePicBox.TabIndex = 9;
            this.statistichePicBox.TabStop = false;
            this.statistichePicBox.MouseHover += new System.EventHandler(this.statistichePicBox_MouseHover);
            // 
            // comeSiGiocaPicBox
            // 
            this.comeSiGiocaPicBox.BackColor = System.Drawing.Color.Transparent;
            this.comeSiGiocaPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.comeSiGiocaPicBox.Image = global::Labirinto.Properties.Resources.puntodidomanda;
            this.comeSiGiocaPicBox.Location = new System.Drawing.Point(50, 36);
            this.comeSiGiocaPicBox.Name = "comeSiGiocaPicBox";
            this.comeSiGiocaPicBox.Size = new System.Drawing.Size(118, 100);
            this.comeSiGiocaPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.comeSiGiocaPicBox.TabIndex = 10;
            this.comeSiGiocaPicBox.TabStop = false;
            this.comeSiGiocaPicBox.MouseHover += new System.EventHandler(this.comeSiGiocaPicBox_MouseHover);
            // 
            // giocaPanel
            // 
            this.giocaPanel.BackColor = System.Drawing.Color.Transparent;
            this.giocaPanel.BackgroundImage = global::Labirinto.Properties.Resources.pergamena;
            this.giocaPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.giocaPanel.Controls.Add(this.giocaBtn);
            this.giocaPanel.Controls.Add(this.giocaPicBox);
            this.giocaPanel.Location = new System.Drawing.Point(45, 246);
            this.giocaPanel.Name = "giocaPanel";
            this.giocaPanel.Size = new System.Drawing.Size(217, 171);
            this.giocaPanel.TabIndex = 11;
            // 
            // statistichePanel
            // 
            this.statistichePanel.BackColor = System.Drawing.Color.Transparent;
            this.statistichePanel.BackgroundImage = global::Labirinto.Properties.Resources.pergamena;
            this.statistichePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.statistichePanel.Controls.Add(this.statisticheBtn);
            this.statistichePanel.Controls.Add(this.statistichePicBox);
            this.statistichePanel.Location = new System.Drawing.Point(305, 246);
            this.statistichePanel.Name = "statistichePanel";
            this.statistichePanel.Size = new System.Drawing.Size(217, 171);
            this.statistichePanel.TabIndex = 12;
            // 
            // comeSiGiocaPanel
            // 
            this.comeSiGiocaPanel.BackColor = System.Drawing.Color.Transparent;
            this.comeSiGiocaPanel.BackgroundImage = global::Labirinto.Properties.Resources.pergamena;
            this.comeSiGiocaPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.comeSiGiocaPanel.Controls.Add(this.comeSiGiocaBtn);
            this.comeSiGiocaPanel.Controls.Add(this.comeSiGiocaPicBox);
            this.comeSiGiocaPanel.Location = new System.Drawing.Point(560, 246);
            this.comeSiGiocaPanel.Name = "comeSiGiocaPanel";
            this.comeSiGiocaPanel.Size = new System.Drawing.Size(217, 171);
            this.comeSiGiocaPanel.TabIndex = 13;
            // 
            // formSchermataIniziale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Labirinto.Properties.Resources.sfondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 449);
            this.Controls.Add(this.descrizioneOperazioni);
            this.Controls.Add(this.comeSiGiocaPanel);
            this.Controls.Add(this.statistichePanel);
            this.Controls.Add(this.giocaPanel);
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
            ((System.ComponentModel.ISupportInitialize)(this.giocaPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistichePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comeSiGiocaPicBox)).EndInit();
            this.giocaPanel.ResumeLayout(false);
            this.statistichePanel.ResumeLayout(false);
            this.comeSiGiocaPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label descrizioneOperazioni;
        private System.Windows.Forms.Button giocaBtn;
        private System.Windows.Forms.Button comeSiGiocaBtn;
        private System.Windows.Forms.Button statisticheBtn;
        private System.Windows.Forms.PictureBox giocaPicBox;
        private System.Windows.Forms.PictureBox statistichePicBox;
        private System.Windows.Forms.PictureBox comeSiGiocaPicBox;
        private System.Windows.Forms.Panel giocaPanel;
        private System.Windows.Forms.Panel statistichePanel;
        private System.Windows.Forms.Panel comeSiGiocaPanel;
    }
}