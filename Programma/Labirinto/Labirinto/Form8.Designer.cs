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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formStatistiche));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.indicazioniGioco = new System.Windows.Forms.Label();
            this.statisticheDGView = new System.Windows.Forms.DataGridView();
            this.indietroPicBox = new System.Windows.Forms.PictureBox();
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            this.indietroTTip = new System.Windows.Forms.ToolTip(this.components);
            this.ripristinaStatisticheBtn = new System.Windows.Forms.Button();
            this.postoDGVTBColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeGiocatoreDGVTBColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partiteVinteDGVTBColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salvaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statisticheDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indietroPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // indicazioniGioco
            // 
            this.indicazioniGioco.AutoSize = true;
            this.indicazioniGioco.BackColor = System.Drawing.Color.Transparent;
            this.indicazioniGioco.Font = new System.Drawing.Font("Flat Brush", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicazioniGioco.Location = new System.Drawing.Point(140, 180);
            this.indicazioniGioco.Name = "indicazioniGioco";
            this.indicazioniGioco.Size = new System.Drawing.Size(197, 27);
            this.indicazioniGioco.TabIndex = 29;
            this.indicazioniGioco.Text = "Statistiche di gioco";
            this.indicazioniGioco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statisticheDGView
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Flat Brush", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticheDGView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.statisticheDGView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Flat Brush", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statisticheDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.statisticheDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statisticheDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.postoDGVTBColumn,
            this.nomeGiocatoreDGVTBColumn,
            this.partiteVinteDGVTBColumn});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Flat Brush", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.statisticheDGView.DefaultCellStyle = dataGridViewCellStyle9;
            this.statisticheDGView.Location = new System.Drawing.Point(41, 231);
            this.statisticheDGView.MultiSelect = false;
            this.statisticheDGView.Name = "statisticheDGView";
            this.statisticheDGView.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Flat Brush", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statisticheDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.statisticheDGView.Size = new System.Drawing.Size(408, 225);
            this.statisticheDGView.TabIndex = 30;
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
            this.logoPicBox.Location = new System.Drawing.Point(59, 45);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(394, 121);
            this.logoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoPicBox.TabIndex = 3;
            this.logoPicBox.TabStop = false;
            // 
            // indietroTTip
            // 
            this.indietroTTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.indietroTTip.ToolTipTitle = "Indietro";
            // 
            // ripristinaStatisticheBtn
            // 
            this.ripristinaStatisticheBtn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ripristinaStatisticheBtn.Location = new System.Drawing.Point(41, 475);
            this.ripristinaStatisticheBtn.Name = "ripristinaStatisticheBtn";
            this.ripristinaStatisticheBtn.Size = new System.Drawing.Size(195, 57);
            this.ripristinaStatisticheBtn.TabIndex = 32;
            this.ripristinaStatisticheBtn.Text = "Ripristina statistiche";
            this.ripristinaStatisticheBtn.UseVisualStyleBackColor = true;
            // 
            // postoDGVTBColumn
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Flat Brush", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postoDGVTBColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.postoDGVTBColumn.HeaderText = "Posto";
            this.postoDGVTBColumn.Name = "postoDGVTBColumn";
            this.postoDGVTBColumn.ReadOnly = true;
            // 
            // nomeGiocatoreDGVTBColumn
            // 
            this.nomeGiocatoreDGVTBColumn.HeaderText = "Nome giocatore";
            this.nomeGiocatoreDGVTBColumn.Name = "nomeGiocatoreDGVTBColumn";
            this.nomeGiocatoreDGVTBColumn.ReadOnly = true;
            // 
            // partiteVinteDGVTBColumn
            // 
            this.partiteVinteDGVTBColumn.HeaderText = "Partite vinte";
            this.partiteVinteDGVTBColumn.Name = "partiteVinteDGVTBColumn";
            this.partiteVinteDGVTBColumn.ReadOnly = true;
            // 
            // salvaBtn
            // 
            this.salvaBtn.Font = new System.Drawing.Font("Flat Brush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvaBtn.Location = new System.Drawing.Point(254, 475);
            this.salvaBtn.Name = "salvaBtn";
            this.salvaBtn.Size = new System.Drawing.Size(195, 57);
            this.salvaBtn.TabIndex = 33;
            this.salvaBtn.Text = "Salva le modifiche";
            this.salvaBtn.UseVisualStyleBackColor = true;
            this.salvaBtn.Click += new System.EventHandler(this.salvaBtn_Click);
            // 
            // formStatistiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Labirinto.Properties.Resources.sfondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(498, 571);
            this.Controls.Add(this.salvaBtn);
            this.Controls.Add(this.ripristinaStatisticheBtn);
            this.Controls.Add(this.indietroPicBox);
            this.Controls.Add(this.statisticheDGView);
            this.Controls.Add(this.indicazioniGioco);
            this.Controls.Add(this.logoPicBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formStatistiche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistiche";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formStatistiche_FormClosed);
            this.Load += new System.EventHandler(this.formStatistiche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statisticheDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indietroPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label indicazioniGioco;
        private System.Windows.Forms.DataGridView statisticheDGView;
        private System.Windows.Forms.PictureBox indietroPicBox;
        private System.Windows.Forms.PictureBox logoPicBox;
        private System.Windows.Forms.ToolTip indietroTTip;
        private System.Windows.Forms.Button ripristinaStatisticheBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postoDGVTBColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeGiocatoreDGVTBColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partiteVinteDGVTBColumn;
        private System.Windows.Forms.Button salvaBtn;
    }
}