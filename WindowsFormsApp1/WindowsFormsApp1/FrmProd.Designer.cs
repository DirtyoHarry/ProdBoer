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
            this.lblNewProd = new System.Windows.Forms.Label();
            this.lblNameProd = new System.Windows.Forms.Label();
            this.txtBoxCodProd = new System.Windows.Forms.TextBox();
            this.lblCodProd = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbBoxSelProd = new System.Windows.Forms.ComboBox();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.txtBoxCodComm = new System.Windows.Forms.TextBox();
            this.lblCodComm = new System.Windows.Forms.Label();
            this.tabControlPhases = new System.Windows.Forms.TabControl();
            this.lblNameOrd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNewProd
            // 
            this.lblNewProd.AutoSize = true;
            this.lblNewProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewProd.Location = new System.Drawing.Point(4, 4);
            this.lblNewProd.Name = "lblNewProd";
            this.lblNewProd.Size = new System.Drawing.Size(181, 31);
            this.lblNewProd.TabIndex = 6;
            this.lblNewProd.Text = "Nuovo Ordine";
            // 
            // lblNameProd
            // 
            this.lblNameProd.AutoSize = true;
            this.lblNameProd.Location = new System.Drawing.Point(301, 43);
            this.lblNameProd.Name = "lblNameProd";
            this.lblNameProd.Size = new System.Drawing.Size(77, 13);
            this.lblNameProd.TabIndex = 8;
            this.lblNameProd.Text = "Nome prodotto";
            this.lblNameProd.Click += new System.EventHandler(this.lblNameProd_Click);
            // 
            // txtBoxCodProd
            // 
            this.txtBoxCodProd.Location = new System.Drawing.Point(396, 65);
            this.txtBoxCodProd.Name = "txtBoxCodProd";
            this.txtBoxCodProd.Size = new System.Drawing.Size(160, 20);
            this.txtBoxCodProd.TabIndex = 7;
            this.txtBoxCodProd.TextChanged += new System.EventHandler(this.txtBoxCodProd_TextChanged);
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Location = new System.Drawing.Point(301, 69);
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
            // 
            // cmbBoxSelProd
            // 
            this.cmbBoxSelProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSelProd.FormattingEnabled = true;
            this.cmbBoxSelProd.Items.AddRange(new object[] {
            "Produzione Interna",
            "Produzione Esterna"});
            this.cmbBoxSelProd.Location = new System.Drawing.Point(743, 69);
            this.cmbBoxSelProd.Name = "cmbBoxSelProd";
            this.cmbBoxSelProd.Size = new System.Drawing.Size(156, 21);
            this.cmbBoxSelProd.TabIndex = 30;
            this.cmbBoxSelProd.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Location = new System.Drawing.Point(15, 95);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(55, 13);
            this.lblDateEnd.TabIndex = 46;
            this.lblDateEnd.Text = "Scadenza";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.WindowText;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 45;
            // 
            // lblDateStart
            // 
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Location = new System.Drawing.Point(17, 69);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(31, 13);
            this.lblDateStart.TabIndex = 44;
            this.lblDateStart.Text = "Inizio";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CalendarTitleBackColor = System.Drawing.SystemColors.WindowText;
            this.dateTimePicker4.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(88, 65);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker4.TabIndex = 43;
            // 
            // txtBoxCodComm
            // 
            this.txtBoxCodComm.Enabled = false;
            this.txtBoxCodComm.Location = new System.Drawing.Point(396, 91);
            this.txtBoxCodComm.Name = "txtBoxCodComm";
            this.txtBoxCodComm.Size = new System.Drawing.Size(160, 20);
            this.txtBoxCodComm.TabIndex = 48;
            this.txtBoxCodComm.TextChanged += new System.EventHandler(this.txtBoxCodComm_TextChanged);
            // 
            // lblCodComm
            // 
            this.lblCodComm.AutoSize = true;
            this.lblCodComm.Location = new System.Drawing.Point(301, 95);
            this.lblCodComm.Name = "lblCodComm";
            this.lblCodComm.Size = new System.Drawing.Size(93, 13);
            this.lblCodComm.TabIndex = 47;
            this.lblCodComm.Text = "Codice commessa";
            this.lblCodComm.Click += new System.EventHandler(this.lblCodComm_Click);
            // 
            // tabControlPhases
            // 
            this.tabControlPhases.Location = new System.Drawing.Point(10, 117);
            this.tabControlPhases.Name = "tabControlPhases";
            this.tabControlPhases.SelectedIndex = 0;
            this.tabControlPhases.Size = new System.Drawing.Size(885, 494);
            this.tabControlPhases.TabIndex = 17;
            // 
            // lblNameOrd
            // 
            this.lblNameOrd.AutoSize = true;
            this.lblNameOrd.Location = new System.Drawing.Point(17, 43);
            this.lblNameOrd.Name = "lblNameOrd";
            this.lblNameOrd.Size = new System.Drawing.Size(67, 13);
            this.lblNameOrd.TabIndex = 49;
            this.lblNameOrd.Text = "Nome ordine";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 50;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(570, 19);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(30, 13);
            this.lblNotes.TabIndex = 51;
            this.lblNotes.Text = "Note";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(573, 35);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 76);
            this.textBox2.TabIndex = 52;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(396, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 53;
            // 
            // FrmNewOrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 619);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNameOrd);
            this.Controls.Add(this.txtBoxCodComm);
            this.Controls.Add(this.lblCodComm);
            this.Controls.Add(this.lblDateEnd);
            this.Controls.Add(this.lblNameProd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtBoxCodProd);
            this.Controls.Add(this.lblCodProd);
            this.Controls.Add(this.lblDateStart);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.cmbBoxSelProd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControlPhases);
            this.Controls.Add(this.lblNewProd);
            this.Name = "FrmNewOrd";
            this.Text = "Aggiungi Ordine";
            this.Load += new System.EventHandler(this.FrmProd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNewProd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbBoxSelProd;
        private System.Windows.Forms.Label lblDateEnd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDateStart;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label lblCodProd;
        private System.Windows.Forms.Label lblNameProd;
        private System.Windows.Forms.TextBox txtBoxCodProd;
        private System.Windows.Forms.TextBox txtBoxCodComm;
        private System.Windows.Forms.Label lblCodComm;
        private System.Windows.Forms.TabControl tabControlPhases;
        private System.Windows.Forms.Label lblNameOrd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}