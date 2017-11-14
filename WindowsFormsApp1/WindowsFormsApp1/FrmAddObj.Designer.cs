namespace ProdCycleBoer
{
    partial class FrmAddObj
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
            this.cmbBoxSelObj = new System.Windows.Forms.ComboBox();
            this.lblNewProd = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblSpec = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.txtBoxSpec = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBoxSelObj
            // 
            this.cmbBoxSelObj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSelObj.FormattingEnabled = true;
            this.cmbBoxSelObj.Items.AddRange(new object[] {
            "Lavoratore",
            "Macchinario"});
            this.cmbBoxSelObj.Location = new System.Drawing.Point(119, 67);
            this.cmbBoxSelObj.Name = "cmbBoxSelObj";
            this.cmbBoxSelObj.Size = new System.Drawing.Size(268, 21);
            this.cmbBoxSelObj.TabIndex = 57;
            this.cmbBoxSelObj.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSelObj_SelectedIndexChanged);
            // 
            // lblNewProd
            // 
            this.lblNewProd.AutoSize = true;
            this.lblNewProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewProd.Location = new System.Drawing.Point(12, 9);
            this.lblNewProd.Name = "lblNewProd";
            this.lblNewProd.Size = new System.Drawing.Size(375, 31);
            this.lblNewProd.TabIndex = 59;
            this.lblNewProd.Text = "Nuovo lavoratore/macchinario";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(18, 70);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 60;
            this.lblType.Text = "Tipo:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(18, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 61;
            this.lblName.Text = "Nome:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(18, 150);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(55, 13);
            this.lblSurname.TabIndex = 62;
            this.lblSurname.Text = "Cognome:";
            // 
            // lblSpec
            // 
            this.lblSpec.AutoSize = true;
            this.lblSpec.Location = new System.Drawing.Point(18, 190);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(88, 13);
            this.lblSpec.TabIndex = 63;
            this.lblSpec.Text = "Specializzazione:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(119, 107);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(268, 20);
            this.txtBoxName.TabIndex = 64;
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Location = new System.Drawing.Point(119, 147);
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(268, 20);
            this.txtBoxSurname.TabIndex = 65;
            // 
            // txtBoxSpec
            // 
            this.txtBoxSpec.Location = new System.Drawing.Point(119, 187);
            this.txtBoxSpec.Multiline = true;
            this.txtBoxSpec.Name = "txtBoxSpec";
            this.txtBoxSpec.Size = new System.Drawing.Size(268, 117);
            this.txtBoxSpec.TabIndex = 66;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(312, 346);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 67;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(18, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 68;
            this.btnCancel.Text = "Annulla";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmAddObj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 381);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtBoxSpec);
            this.Controls.Add(this.txtBoxSurname);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblSpec);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblNewProd);
            this.Controls.Add(this.cmbBoxSelObj);
            this.Name = "FrmAddObj";
            this.Text = "FrmAddObj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbBoxSelObj;
        private System.Windows.Forms.Label lblNewProd;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblSpec;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxSurname;
        private System.Windows.Forms.TextBox txtBoxSpec;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}