namespace ProdCycleBoer
{
    partial class FrmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Macchinario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuovoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodottoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lavoratoreMacchinarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Controls.Add(this.dataGridView4);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(820, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Produzione";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(575, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Vista Giornaliera",
            "Vista Settimanale",
            "Vista Mensile"});
            this.comboBox1.Location = new System.Drawing.Point(575, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dataGridView4.Location = new System.Drawing.Point(0, 60);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(814, 443);
            this.dataGridView4.TabIndex = 2;
            this.dataGridView4.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellDoubleClick);
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Settimana 4";
            this.Column14.Name = "Column14";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Settimana 3";
            this.Column13.Name = "Column13";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Settimana 2";
            this.Column12.Name = "Column12";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Settimana 1";
            this.Column11.Name = "Column11";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridView3.Location = new System.Drawing.Point(0, 60);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(814, 443);
            this.dataGridView3.TabIndex = 1;
            this.dataGridView3.Visible = false;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            this.dataGridView3.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellDoubleClick);
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Domenica";
            this.Column10.Name = "Column10";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Sabato";
            this.Column9.Name = "Column9";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Venerdi";
            this.Column8.Name = "Column8";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Giovedi";
            this.Column7.Name = "Column7";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Mercoledi";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Martedi";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Lunedi";
            this.Column4.Name = "Column4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Macchinario,
            this.Fase,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(0, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(814, 438);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prodotto";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Fase
            // 
            this.Fase.HeaderText = "Fase";
            this.Fase.Name = "Fase";
            this.Fase.Width = 150;
            // 
            // Macchinario
            // 
            this.Macchinario.FillWeight = 125F;
            this.Macchinario.HeaderText = "Macchinario";
            this.Macchinario.Name = "Macchinario";
            this.Macchinario.Width = 150;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 130F;
            this.Column2.HeaderText = "Lavoratore";
            this.Column2.Name = "Column2";
            this.Column2.Width = 145;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ora";
            this.Column1.Name = "Column1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(828, 525);
            this.tabControl1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovoToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(852, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuovoToolStripMenuItem1
            // 
            this.nuovoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovoToolStripMenuItem});
            this.nuovoToolStripMenuItem1.Name = "nuovoToolStripMenuItem1";
            this.nuovoToolStripMenuItem1.Size = new System.Drawing.Size(79, 20);
            this.nuovoToolStripMenuItem1.Text = "Produzione";
            this.nuovoToolStripMenuItem1.Click += new System.EventHandler(this.nuovoToolStripMenuItem1_Click);
            // 
            // nuovoToolStripMenuItem
            // 
            this.nuovoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordineToolStripMenuItem,
            this.prodottoToolStripMenuItem,
            this.lavoratoreMacchinarioToolStripMenuItem});
            this.nuovoToolStripMenuItem.Name = "nuovoToolStripMenuItem";
            this.nuovoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuovoToolStripMenuItem.Text = "Nuovo";
            // 
            // ordineToolStripMenuItem
            // 
            this.ordineToolStripMenuItem.Name = "ordineToolStripMenuItem";
            this.ordineToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ordineToolStripMenuItem.Text = "Ordine";
            this.ordineToolStripMenuItem.Click += new System.EventHandler(this.ordineToolStripMenuItem_Click);
            // 
            // prodottoToolStripMenuItem
            // 
            this.prodottoToolStripMenuItem.Name = "prodottoToolStripMenuItem";
            this.prodottoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.prodottoToolStripMenuItem.Text = "Prodotto";
            this.prodottoToolStripMenuItem.Click += new System.EventHandler(this.prodottoToolStripMenuItem_Click);
            // 
            // lavoratoreMacchinarioToolStripMenuItem
            // 
            this.lavoratoreMacchinarioToolStripMenuItem.Name = "lavoratoreMacchinarioToolStripMenuItem";
            this.lavoratoreMacchinarioToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.lavoratoreMacchinarioToolStripMenuItem.Text = "Lavoratore/Macchinario";
            this.lavoratoreMacchinarioToolStripMenuItem.Click += new System.EventHandler(this.lavoratoreMacchinarioToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 579);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Macchinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuovoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prodottoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lavoratoreMacchinarioToolStripMenuItem;
    }
}

