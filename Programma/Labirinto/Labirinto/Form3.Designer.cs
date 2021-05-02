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
            this.dueBtn = new System.Windows.Forms.Button();
            this.chiudiBtn = new System.Windows.Forms.Button();
            this.homepageBtn = new System.Windows.Forms.Button();
            this.unoBtn = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treBtn = new System.Windows.Forms.Button();
            this.quattroBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // dueBtn
            // 
            this.dueBtn.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueBtn.Location = new System.Drawing.Point(227, 233);
            this.dueBtn.Name = "dueBtn";
            this.dueBtn.Size = new System.Drawing.Size(175, 122);
            this.dueBtn.TabIndex = 13;
            this.dueBtn.Text = "Due";
            this.dueBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dueBtn.UseVisualStyleBackColor = true;
            this.dueBtn.Click += new System.EventHandler(this.dueBtn_Click);
            // 
            // chiudiBtn
            // 
            this.chiudiBtn.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiudiBtn.Location = new System.Drawing.Point(408, 365);
            this.chiudiBtn.Name = "chiudiBtn";
            this.chiudiBtn.Size = new System.Drawing.Size(350, 58);
            this.chiudiBtn.TabIndex = 12;
            this.chiudiBtn.Text = "Esci";
            this.chiudiBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chiudiBtn.UseVisualStyleBackColor = true;
            this.chiudiBtn.Click += new System.EventHandler(this.chiudiBtn_Click);
            // 
            // homepageBtn
            // 
            this.homepageBtn.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepageBtn.Location = new System.Drawing.Point(46, 363);
            this.homepageBtn.Name = "homepageBtn";
            this.homepageBtn.Size = new System.Drawing.Size(356, 58);
            this.homepageBtn.TabIndex = 11;
            this.homepageBtn.Text = "Ritorna al menù principale";
            this.homepageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homepageBtn.UseVisualStyleBackColor = true;
            this.homepageBtn.Click += new System.EventHandler(this.homepageBtn_Click);
            // 
            // unoBtn
            // 
            this.unoBtn.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unoBtn.Location = new System.Drawing.Point(46, 233);
            this.unoBtn.Name = "unoBtn";
            this.unoBtn.Size = new System.Drawing.Size(175, 124);
            this.unoBtn.TabIndex = 10;
            this.unoBtn.Text = "Uno";
            this.unoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.unoBtn.UseVisualStyleBackColor = true;
            this.unoBtn.Click += new System.EventHandler(this.unoBtn_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::Labirinto.Properties.Resources.logo1;
            this.logo.Location = new System.Drawing.Point(46, 45);
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
            this.label1.Location = new System.Drawing.Point(509, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Quanti sono i giocatori?";
            // 
            // treBtn
            // 
            this.treBtn.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treBtn.Location = new System.Drawing.Point(408, 233);
            this.treBtn.Name = "treBtn";
            this.treBtn.Size = new System.Drawing.Size(174, 124);
            this.treBtn.TabIndex = 15;
            this.treBtn.Text = "Tre";
            this.treBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.treBtn.UseVisualStyleBackColor = true;
            this.treBtn.Click += new System.EventHandler(this.treBtn_Click);
            // 
            // quattroBtn
            // 
            this.quattroBtn.Font = new System.Drawing.Font("Flat Brush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quattroBtn.Location = new System.Drawing.Point(588, 233);
            this.quattroBtn.Name = "quattroBtn";
            this.quattroBtn.Size = new System.Drawing.Size(170, 124);
            this.quattroBtn.TabIndex = 16;
            this.quattroBtn.Text = "Quattro";
            this.quattroBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quattroBtn.UseVisualStyleBackColor = true;
            this.quattroBtn.Click += new System.EventHandler(this.quattroBtn_Click);
            // 
            // salvataggio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Labirinto.Properties.Resources.sfondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quattroBtn);
            this.Controls.Add(this.treBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dueBtn);
            this.Controls.Add(this.chiudiBtn);
            this.Controls.Add(this.homepageBtn);
            this.Controls.Add(this.unoBtn);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "salvataggio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scelta dei giocatori";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.salvataggio_FormClosed);
            this.Load += new System.EventHandler(this.salvataggio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dueBtn;
        private System.Windows.Forms.Button chiudiBtn;
        private System.Windows.Forms.Button homepageBtn;
        private System.Windows.Forms.Button unoBtn;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button treBtn;
        private System.Windows.Forms.Button quattroBtn;
    }
}