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
            this.tabControlAddPh = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddObj = new System.Windows.Forms.Button();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.cmbBoxWriteObj1 = new System.Windows.Forms.ComboBox();
            this.cmbBoxSelObj1 = new System.Windows.Forms.ComboBox();
            this.btnSavePhase = new System.Windows.Forms.Button();
            this.lblNamePhase = new System.Windows.Forms.Label();
            this.txtBoxNamePhase = new System.Windows.Forms.TextBox();
            this.btnAddPhase = new System.Windows.Forms.Button();
            this.txtBoxNameProd = new System.Windows.Forms.TextBox();
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
            this.btnRemPhase = new System.Windows.Forms.Button();
            this.tabControlAddPh.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            // tabControlAddPh
            // 
            this.tabControlAddPh.Controls.Add(this.tabPage1);
            this.tabControlAddPh.Location = new System.Drawing.Point(10, 121);
            this.tabControlAddPh.Name = "tabControlAddPh";
            this.tabControlAddPh.SelectedIndex = 0;
            this.tabControlAddPh.Size = new System.Drawing.Size(885, 490);
            this.tabControlAddPh.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRemPhase);
            this.tabPage1.Controls.Add(this.btnAddObj);
            this.tabPage1.Controls.Add(this.dateTimePickerTo);
            this.tabPage1.Controls.Add(this.dateTimePickerFrom);
            this.tabPage1.Controls.Add(this.lblTo);
            this.tabPage1.Controls.Add(this.lblFrom);
            this.tabPage1.Controls.Add(this.cmbBoxWriteObj1);
            this.tabPage1.Controls.Add(this.cmbBoxSelObj1);
            this.tabPage1.Controls.Add(this.btnSavePhase);
            this.tabPage1.Controls.Add(this.lblNamePhase);
            this.tabPage1.Controls.Add(this.txtBoxNamePhase);
            this.tabPage1.Controls.Add(this.btnAddPhase);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(877, 464);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Fase 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // btnAddObj
            // 
            this.btnAddObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddObj.Location = new System.Drawing.Point(755, 88);
            this.btnAddObj.Name = "btnAddObj";
            this.btnAddObj.Size = new System.Drawing.Size(33, 33);
            this.btnAddObj.TabIndex = 63;
            this.btnAddObj.Text = "+";
            this.btnAddObj.UseVisualStyleBackColor = true;
            this.btnAddObj.Click += new System.EventHandler(this.btnNewObj_Click);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CalendarTitleBackColor = System.Drawing.SystemColors.WindowText;
            this.dateTimePickerTo.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(549, 96);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 62;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CalendarTitleBackColor = System.Drawing.SystemColors.WindowText;
            this.dateTimePickerFrom.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(323, 96);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 47;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(529, 98);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(14, 13);
            this.lblTo.TabIndex = 61;
            this.lblTo.Text = "A";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(296, 98);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(21, 13);
            this.lblFrom.TabIndex = 60;
            this.lblFrom.Text = "Da";
            // 
            // cmbBoxWriteObj1
            // 
            this.cmbBoxWriteObj1.FormattingEnabled = true;
            this.cmbBoxWriteObj1.Items.AddRange(new object[] {
            "Giovanni",
            "Paolo"});
            this.cmbBoxWriteObj1.Location = new System.Drawing.Point(133, 95);
            this.cmbBoxWriteObj1.Name = "cmbBoxWriteObj1";
            this.cmbBoxWriteObj1.Size = new System.Drawing.Size(157, 21);
            this.cmbBoxWriteObj1.TabIndex = 56;
            // 
            // cmbBoxSelObj1
            // 
            this.cmbBoxSelObj1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSelObj1.FormattingEnabled = true;
            this.cmbBoxSelObj1.Items.AddRange(new object[] {
            "Lavoratore",
            "Macchinario"});
            this.cmbBoxSelObj1.Location = new System.Drawing.Point(6, 95);
            this.cmbBoxSelObj1.Name = "cmbBoxSelObj1";
            this.cmbBoxSelObj1.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxSelObj1.TabIndex = 55;
            // 
            // btnSavePhase
            // 
            this.btnSavePhase.Location = new System.Drawing.Point(712, 3);
            this.btnSavePhase.Name = "btnSavePhase";
            this.btnSavePhase.Size = new System.Drawing.Size(50, 50);
            this.btnSavePhase.TabIndex = 54;
            this.btnSavePhase.Text = "Salva Fase";
            this.btnSavePhase.UseVisualStyleBackColor = true;
            // 
            // lblNamePhase
            // 
            this.lblNamePhase.AutoSize = true;
            this.lblNamePhase.Location = new System.Drawing.Point(3, 19);
            this.lblNamePhase.Name = "lblNamePhase";
            this.lblNamePhase.Size = new System.Drawing.Size(61, 13);
            this.lblNamePhase.TabIndex = 53;
            this.lblNamePhase.Text = "Nome Fase";
            // 
            // txtBoxNamePhase
            // 
            this.txtBoxNamePhase.Location = new System.Drawing.Point(71, 16);
            this.txtBoxNamePhase.Name = "txtBoxNamePhase";
            this.txtBoxNamePhase.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNamePhase.TabIndex = 52;
            // 
            // btnAddPhase
            // 
            this.btnAddPhase.Location = new System.Drawing.Point(768, 3);
            this.btnAddPhase.Name = "btnAddPhase";
            this.btnAddPhase.Size = new System.Drawing.Size(50, 50);
            this.btnAddPhase.TabIndex = 47;
            this.btnAddPhase.Text = "+";
            this.btnAddPhase.UseVisualStyleBackColor = true;
            this.btnAddPhase.Click += new System.EventHandler(this.btnAddPhase_Click);
            // 
            // txtBoxNameProd
            // 
            this.txtBoxNameProd.Location = new System.Drawing.Point(479, 29);
            this.txtBoxNameProd.Name = "txtBoxNameProd";
            this.txtBoxNameProd.Size = new System.Drawing.Size(160, 20);
            this.txtBoxNameProd.TabIndex = 9;
            // 
            // lblNameProd
            // 
            this.lblNameProd.AutoSize = true;
            this.lblNameProd.Location = new System.Drawing.Point(380, 32);
            this.lblNameProd.Name = "lblNameProd";
            this.lblNameProd.Size = new System.Drawing.Size(77, 13);
            this.lblNameProd.TabIndex = 8;
            this.lblNameProd.Text = "Nome prodotto";
            // 
            // txtBoxCodProd
            // 
            this.txtBoxCodProd.Location = new System.Drawing.Point(479, 55);
            this.txtBoxCodProd.Name = "txtBoxCodProd";
            this.txtBoxCodProd.Size = new System.Drawing.Size(160, 20);
            this.txtBoxCodProd.TabIndex = 7;
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Location = new System.Drawing.Point(380, 58);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(82, 13);
            this.lblCodProd.TabIndex = 6;
            this.lblCodProd.Text = "Codice prodotto";
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
            this.cmbBoxSelProd.Location = new System.Drawing.Point(717, 68);
            this.cmbBoxSelProd.Name = "cmbBoxSelProd";
            this.cmbBoxSelProd.Size = new System.Drawing.Size(182, 21);
            this.cmbBoxSelProd.TabIndex = 30;
            this.cmbBoxSelProd.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Location = new System.Drawing.Point(17, 71);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(58, 13);
            this.lblDateEnd.TabIndex = 46;
            this.lblDateEnd.Text = "Scadenza:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.WindowText;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(85, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 45;
            // 
            // lblDateStart
            // 
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Location = new System.Drawing.Point(19, 45);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(34, 13);
            this.lblDateStart.TabIndex = 44;
            this.lblDateStart.Text = "Inizio:";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CalendarTitleBackColor = System.Drawing.SystemColors.WindowText;
            this.dateTimePicker4.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(85, 39);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker4.TabIndex = 43;
            // 
            // txtBoxCodComm
            // 
            this.txtBoxCodComm.Location = new System.Drawing.Point(479, 81);
            this.txtBoxCodComm.Name = "txtBoxCodComm";
            this.txtBoxCodComm.Size = new System.Drawing.Size(160, 20);
            this.txtBoxCodComm.TabIndex = 48;
            this.txtBoxCodComm.Visible = false;
            // 
            // lblCodComm
            // 
            this.lblCodComm.AutoSize = true;
            this.lblCodComm.Location = new System.Drawing.Point(380, 84);
            this.lblCodComm.Name = "lblCodComm";
            this.lblCodComm.Size = new System.Drawing.Size(93, 13);
            this.lblCodComm.TabIndex = 47;
            this.lblCodComm.Text = "Codice commessa";
            this.lblCodComm.Visible = false;
            // 
            // btnRemPhase
            // 
            this.btnRemPhase.Location = new System.Drawing.Point(824, 3);
            this.btnRemPhase.Name = "btnRemPhase";
            this.btnRemPhase.Size = new System.Drawing.Size(50, 50);
            this.btnRemPhase.TabIndex = 64;
            this.btnRemPhase.Text = "-";
            this.btnRemPhase.UseVisualStyleBackColor = true;
            this.btnRemPhase.Click += new System.EventHandler(this.btnRemPhase_Click);
            // 
            // FrmNewOrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 619);
            this.Controls.Add(this.txtBoxCodComm);
            this.Controls.Add(this.lblCodComm);
            this.Controls.Add(this.txtBoxNameProd);
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
            this.Controls.Add(this.tabControlAddPh);
            this.Controls.Add(this.lblNewProd);
            this.Name = "FrmNewOrd";
            this.Text = "Aggiungi Ordine";
            this.Load += new System.EventHandler(this.FrmProd_Load);
            this.tabControlAddPh.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNewProd;
        private System.Windows.Forms.TabControl tabControlAddPh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbBoxSelProd;
        private System.Windows.Forms.Label lblDateEnd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDateStart;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label lblCodProd;
        private System.Windows.Forms.TextBox txtBoxNameProd;
        private System.Windows.Forms.Label lblNameProd;
        private System.Windows.Forms.TextBox txtBoxCodProd;
        private System.Windows.Forms.Button btnAddPhase;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.ComboBox cmbBoxWriteObj1;
        private System.Windows.Forms.ComboBox cmbBoxSelObj1;
        private System.Windows.Forms.Button btnSavePhase;
        private System.Windows.Forms.Label lblNamePhase;
        private System.Windows.Forms.TextBox txtBoxNamePhase;
        private System.Windows.Forms.TextBox txtBoxCodComm;
        private System.Windows.Forms.Label lblCodComm;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnAddObj;
        private System.Windows.Forms.Button btnRemPhase;
    }
}