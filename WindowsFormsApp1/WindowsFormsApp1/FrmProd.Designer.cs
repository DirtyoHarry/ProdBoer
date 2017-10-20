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
            this.tabControlPhases = new System.Windows.Forms.TabControl();
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
            // txtBoxNameProd
            // 
            this.txtBoxNameProd.Location = new System.Drawing.Point(418, 39);
            this.txtBoxNameProd.Name = "txtBoxNameProd";
            this.txtBoxNameProd.Size = new System.Drawing.Size(160, 20);
            this.txtBoxNameProd.TabIndex = 9;
            this.txtBoxNameProd.TextChanged += new System.EventHandler(this.txtBoxNameProd_TextChanged);
            // 
            // lblNameProd
            // 
            this.lblNameProd.AutoSize = true;
            this.lblNameProd.Location = new System.Drawing.Point(323, 45);
            this.lblNameProd.Name = "lblNameProd";
            this.lblNameProd.Size = new System.Drawing.Size(80, 13);
            this.lblNameProd.TabIndex = 8;
            this.lblNameProd.Text = "Nome prodotto:";
            this.lblNameProd.Click += new System.EventHandler(this.lblNameProd_Click);
            // 
            // txtBoxCodProd
            // 
            this.txtBoxCodProd.Location = new System.Drawing.Point(418, 65);
            this.txtBoxCodProd.Name = "txtBoxCodProd";
            this.txtBoxCodProd.Size = new System.Drawing.Size(160, 20);
            this.txtBoxCodProd.TabIndex = 7;
            this.txtBoxCodProd.TextChanged += new System.EventHandler(this.txtBoxCodProd_TextChanged);
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Location = new System.Drawing.Point(323, 71);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(85, 13);
            this.lblCodProd.TabIndex = 6;
            this.lblCodProd.Text = "Codice prodotto:";
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
            this.txtBoxCodComm.Location = new System.Drawing.Point(418, 91);
            this.txtBoxCodComm.Name = "txtBoxCodComm";
            this.txtBoxCodComm.Size = new System.Drawing.Size(160, 20);
            this.txtBoxCodComm.TabIndex = 48;
            this.txtBoxCodComm.Visible = false;
            this.txtBoxCodComm.TextChanged += new System.EventHandler(this.txtBoxCodComm_TextChanged);
            // 
            // lblCodComm
            // 
            this.lblCodComm.AutoSize = true;
            this.lblCodComm.Location = new System.Drawing.Point(323, 97);
            this.lblCodComm.Name = "lblCodComm";
            this.lblCodComm.Size = new System.Drawing.Size(96, 13);
            this.lblCodComm.TabIndex = 47;
            this.lblCodComm.Text = "Codice commessa:";
            this.lblCodComm.Visible = false;
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
        private System.Windows.Forms.TextBox txtBoxNameProd;
        private System.Windows.Forms.Label lblNameProd;
        private System.Windows.Forms.TextBox txtBoxCodProd;
        private System.Windows.Forms.TextBox txtBoxCodComm;
        private System.Windows.Forms.Label lblCodComm;
        private System.Windows.Forms.TabControl tabControlPhases;
    }
}