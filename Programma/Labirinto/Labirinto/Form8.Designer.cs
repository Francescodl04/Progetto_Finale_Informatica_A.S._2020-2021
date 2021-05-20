namespace Labirinto
{
    partial class formStatistiche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formStatistiche));
            this.indicazioniGioco = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.indietroPicBox = new System.Windows.Forms.PictureBox();
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            this.indietroTTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indietroPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // indicazioniGioco
            // 
            this.indicazioniGioco.AutoSize = true;
            this.indicazioniGioco.BackColor = System.Drawing.Color.Transparent;
            this.indicazioniGioco.Font = new System.Drawing.Font("Flat Brush", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicazioniGioco.Location = new System.Drawing.Point(123, 178);
            this.indicazioniGioco.Name = "indicazioniGioco";
            this.indicazioniGioco.Size = new System.Drawing.Size(223, 31);
            this.indicazioniGioco.TabIndex = 29;
            this.indicazioniGioco.Text = "Statistiche di gioco";
            this.indicazioniGioco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 225);
            this.dataGridView1.TabIndex = 30;
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
            this.indietroPicBox.TabIndex = 31;
            this.indietroPicBox.TabStop = false;
            this.indietroTTip.SetToolTip(this.indietroPicBox, "Premi qui per tornare al menu principale");
            this.indietroPicBox.Click += new System.EventHandler(this.indietroPicBox_Click);
            // 
            // logoPicBox
            // 
            this.logoPicBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPicBox.Image = global::Labirinto.Properties.Resources.logo1;
            this.logoPicBox.Location = new System.Drawing.Point(41, 61);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(408, 114);
            this.logoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoPicBox.TabIndex = 3;
            this.logoPicBox.TabStop = false;
            // 
            // indietroTTip
            // 
            this.indietroTTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.indietroTTip.ToolTipTitle = "Indietro";
            // 
            // formStatistiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Labirinto.Properties.Resources.sfondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(498, 571);
            this.Controls.Add(this.indietroPicBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.indicazioniGioco);
            this.Controls.Add(this.logoPicBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formStatistiche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistiche";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formStatistiche_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indietroPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label indicazioniGioco;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox indietroPicBox;
        private System.Windows.Forms.PictureBox logoPicBox;
        private System.Windows.Forms.ToolTip indietroTTip;
    }
}