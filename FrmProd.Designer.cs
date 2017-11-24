namespace ProdCycleBoer
{
    partial class FrmNewOrd
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
            this.lblChangeProd = new System.Windows.Forms.Label();
            this.lblNameProd = new System.Windows.Forms.Label();
            this.txtBoxCodProd = new System.Windows.Forms.TextBox();
            this.lblCodProd = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbBoxSelProd = new System.Windows.Forms.ComboBox();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.dateTmPickED = new System.Windows.Forms.DateTimePicker();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.dateTmPickSD = new System.Windows.Forms.DateTimePicker();
            this.txtBoxCodComm = new System.Windows.Forms.TextBox();
            this.lblCodComm = new System.Windows.Forms.Label();
            this.tabControlPhases = new System.Windows.Forms.TabControl();
            this.lblNameOrd = new System.Windows.Forms.Label();
            this.txtBoxNameOrd = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtBoxNotes = new System.Windows.Forms.TextBox();
            this.cmbBoxNameProd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNOrder = new System.Windows.Forms.Label();
            this.numUpDownNOrd = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNOrd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChangeProd
            // 
            this.lblChangeProd.AutoSize = true;
            this.lblChangeProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeProd.Location = new System.Drawing.Point(4, 4);
            this.lblChangeProd.Name = "lblChangeProd";
            this.lblChangeProd.Size = new System.Drawing.Size(181, 31);
            this.lblChangeProd.TabIndex = 6;
            this.lblChangeProd.Text = "Nuovo Ordine";
            // 
            // lblNameProd
            // 
            this.lblNameProd.AutoSize = true;
            this.lblNameProd.Location = new System.Drawing.Point(301, 67);
            this.lblNameProd.Name = "lblNameProd";
            this.lblNameProd.Size = new System.Drawing.Size(77, 13);
            this.lblNameProd.TabIndex = 8;
            this.lblNameProd.Text = "Nome prodotto";
            this.lblNameProd.Click += new System.EventHandler(this.lblNameProd_Click);
            // 
            // txtBoxCodProd
            // 
            this.txtBoxCodProd.Location = new System.Drawing.Point(396, 90);
            this.txtBoxCodProd.Name = "txtBoxCodProd";
            this.txtBoxCodProd.Size = new System.Drawing.Size(160, 20);
            this.txtBoxCodProd.TabIndex = 7;
            this.txtBoxCodProd.TextChanged += new System.EventHandler(this.txtBoxCodProd_TextChanged);
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Location = new System.Drawing.Point(301, 93);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(82, 13);
            this.lblCodProd.TabIndex = 6;
            this.lblCodProd.Text = "Codice prodotto";
            this.lblCodProd.Click += new System.EventHandler(this.lblCodProd_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(743, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 54);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Salva";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(824, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 55);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Annulla";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbBoxSelProd
            // 
            this.cmbBoxSelProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSelProd.FormattingEnabled = true;
            this.cmbBoxSelProd.Items.AddRange(new object[] {
            "Produzione Esterna",
            "Produzione Interna"});
            this.cmbBoxSelProd.Location = new System.Drawing.Point(85, 37);
            this.cmbBoxSelProd.Name = "cmbBoxSelProd";
            this.cmbBoxSelProd.Size = new System.Drawing.Size(200, 21);
            this.cmbBoxSelProd.TabIndex = 2;
            this.cmbBoxSelProd.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSelProd_SelectedIndexChanged);
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Location = new System.Drawing.Point(14, 119);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(55, 13);
            this.lblDateEnd.TabIndex = 46;
            this.lblDateEnd.Text = "Scadenza";
            // 
            // dateTmPickED
            // 
            this.dateTmPickED.CalendarTitleBackColor = System.Drawing.SystemColors.WindowText;
            this.dateTmPickED.CustomFormat = "dd/MM/yyyy";
            this.dateTmPickED.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTmPickED.Location = new System.Drawing.Point(85, 116);
            this.dateTmPickED.Name = "dateTmPickED";
            this.dateTmPickED.Size = new System.Drawing.Size(200, 20);
            this.dateTmPickED.TabIndex = 45;
            // 
            // lblDateStart
            // 
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Location = new System.Drawing.Point(14, 93);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(31, 13);
            this.lblDateStart.TabIndex = 44;
            this.lblDateStart.Text = "Inizio";
            // 
            // dateTmPickSD
            // 
            this.dateTmPickSD.CalendarTitleBackColor = System.Drawing.SystemColors.WindowText;
            this.dateTmPickSD.CustomFormat = "dd/MM/yyyy";
            this.dateTmPickSD.Enabled = false;
            this.dateTmPickSD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTmPickSD.Location = new System.Drawing.Point(85, 89);
            this.dateTmPickSD.Name = "dateTmPickSD";
            this.dateTmPickSD.Size = new System.Drawing.Size(200, 20);
            this.dateTmPickSD.TabIndex = 43;
            // 
            // txtBoxCodComm
            // 
            this.txtBoxCodComm.Enabled = false;
            this.txtBoxCodComm.Location = new System.Drawing.Point(396, 116);
            this.txtBoxCodComm.Name = "txtBoxCodComm";
            this.txtBoxCodComm.Size = new System.Drawing.Size(160, 20);
            this.txtBoxCodComm.TabIndex = 48;
            this.txtBoxCodComm.TextChanged += new System.EventHandler(this.txtBoxCodComm_TextChanged);
            // 
            // lblCodComm
            // 
            this.lblCodComm.AutoSize = true;
            this.lblCodComm.Location = new System.Drawing.Point(301, 119);
            this.lblCodComm.Name = "lblCodComm";
            this.lblCodComm.Size = new System.Drawing.Size(93, 13);
            this.lblCodComm.TabIndex = 47;
            this.lblCodComm.Text = "Codice commessa";
            this.lblCodComm.Click += new System.EventHandler(this.lblCodComm_Click);
            // 
            // tabControlPhases
            // 
            this.tabControlPhases.Location = new System.Drawing.Point(10, 141);
            this.tabControlPhases.Name = "tabControlPhases";
            this.tabControlPhases.SelectedIndex = 0;
            this.tabControlPhases.Size = new System.Drawing.Size(885, 494);
            this.tabControlPhases.TabIndex = 17;
            // 
            // lblNameOrd
            // 
            this.lblNameOrd.AutoSize = true;
            this.lblNameOrd.Location = new System.Drawing.Point(14, 67);
            this.lblNameOrd.Name = "lblNameOrd";
            this.lblNameOrd.Size = new System.Drawing.Size(67, 13);
            this.lblNameOrd.TabIndex = 49;
            this.lblNameOrd.Text = "Nome ordine";
            // 
            // txtBoxNameOrd
            // 
            this.txtBoxNameOrd.Location = new System.Drawing.Point(85, 62);
            this.txtBoxNameOrd.Name = "txtBoxNameOrd";
            this.txtBoxNameOrd.Size = new System.Drawing.Size(200, 20);
            this.txtBoxNameOrd.TabIndex = 1;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(570, 21);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(30, 13);
            this.lblNotes.TabIndex = 51;
            this.lblNotes.Text = "Note";
            // 
            // txtBoxNotes
            // 
            this.txtBoxNotes.Location = new System.Drawing.Point(573, 37);
            this.txtBoxNotes.Multiline = true;
            this.txtBoxNotes.Name = "txtBoxNotes";
            this.txtBoxNotes.Size = new System.Drawing.Size(161, 100);
            this.txtBoxNotes.TabIndex = 52;
            // 
            // cmbBoxNameProd
            // 
            this.cmbBoxNameProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxNameProd.FormattingEnabled = true;
            this.cmbBoxNameProd.Location = new System.Drawing.Point(396, 63);
            this.cmbBoxNameProd.Name = "cmbBoxNameProd";
            this.cmbBoxNameProd.Size = new System.Drawing.Size(160, 21);
            this.cmbBoxNameProd.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Tipo";
            // 
            // lblNOrder
            // 
            this.lblNOrder.AutoSize = true;
            this.lblNOrder.Location = new System.Drawing.Point(301, 41);
            this.lblNOrder.Name = "lblNOrder";
            this.lblNOrder.Size = new System.Drawing.Size(76, 13);
            this.lblNOrder.TabIndex = 55;
            this.lblNOrder.Text = "Numero ordine";
            // 
            // numUpDownNOrd
            // 
            this.numUpDownNOrd.Location = new System.Drawing.Point(396, 37);
            this.numUpDownNOrd.Name = "numUpDownNOrd";
            this.numUpDownNOrd.Size = new System.Drawing.Size(160, 20);
            this.numUpDownNOrd.TabIndex = 56;
            this.numUpDownNOrd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmNewOrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 643);
            this.Controls.Add(this.numUpDownNOrd);
            this.Controls.Add(this.lblNOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxNameProd);
            this.Controls.Add(this.txtBoxNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtBoxNameOrd);
            this.Controls.Add(this.lblNameOrd);
            this.Controls.Add(this.txtBoxCodComm);
            this.Controls.Add(this.lblCodComm);
            this.Controls.Add(this.lblDateEnd);
            this.Controls.Add(this.lblNameProd);
            this.Controls.Add(this.dateTmPickED);
            this.Controls.Add(this.txtBoxCodProd);
            this.Controls.Add(this.lblCodProd);
            this.Controls.Add(this.lblDateStart);
            this.Controls.Add(this.dateTmPickSD);
            this.Controls.Add(this.cmbBoxSelProd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControlPhases);
            this.Controls.Add(this.lblChangeProd);
            this.Name = "FrmNewOrd";
            this.Text = "Aggiungi Ordine";
            this.Load += new System.EventHandler(this.FrmProd_Load);
            this.Shown += new System.EventHandler(this.FrmNewOrd_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNOrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblChangeProd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbBoxSelProd;
        private System.Windows.Forms.Label lblDateEnd;
        private System.Windows.Forms.DateTimePicker dateTmPickED;
        private System.Windows.Forms.Label lblDateStart;
        private System.Windows.Forms.DateTimePicker dateTmPickSD;
        private System.Windows.Forms.Label lblCodProd;
        private System.Windows.Forms.Label lblNameProd;
        private System.Windows.Forms.TextBox txtBoxCodProd;
        private System.Windows.Forms.TextBox txtBoxCodComm;
        private System.Windows.Forms.Label lblCodComm;
        private System.Windows.Forms.TabControl tabControlPhases;
        private System.Windows.Forms.Label lblNameOrd;
        private System.Windows.Forms.TextBox txtBoxNameOrd;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtBoxNotes;
        private System.Windows.Forms.ComboBox cmbBoxNameProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNOrder;
        private System.Windows.Forms.NumericUpDown numUpDownNOrd;
    }
}