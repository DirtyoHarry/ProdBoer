namespace ProdCycleBoer
{
    partial class FrmAddDefaultPh
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
            this.tabControlPhases = new System.Windows.Forms.TabControl();
            this.cmbBoxSelProd = new System.Windows.Forms.ComboBox();
            this.lblNewProd = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabControlPhases
            // 
            this.tabControlPhases.Location = new System.Drawing.Point(12, 79);
            this.tabControlPhases.Name = "tabControlPhases";
            this.tabControlPhases.SelectedIndex = 0;
            this.tabControlPhases.Size = new System.Drawing.Size(700, 387);
            this.tabControlPhases.TabIndex = 18;
            // 
            // cmbBoxSelProd
            // 
            this.cmbBoxSelProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSelProd.FormattingEnabled = true;
            this.cmbBoxSelProd.Location = new System.Drawing.Point(12, 52);
            this.cmbBoxSelProd.Name = "cmbBoxSelProd";
            this.cmbBoxSelProd.Size = new System.Drawing.Size(288, 21);
            this.cmbBoxSelProd.TabIndex = 19;
            this.cmbBoxSelProd.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSelProd_SelectedIndexChanged);
            // 
            // lblNewProd
            // 
            this.lblNewProd.AutoSize = true;
            this.lblNewProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewProd.Location = new System.Drawing.Point(6, 9);
            this.lblNewProd.Name = "lblNewProd";
            this.lblNewProd.Size = new System.Drawing.Size(277, 31);
            this.lblNewProd.TabIndex = 60;
            this.lblNewProd.Text = "Nuove fasi predefinite";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(615, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 55);
            this.btnCancel.TabIndex = 62;
            this.btnCancel.Text = "Annulla";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(512, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 54);
            this.btnSave.TabIndex = 61;
            this.btnSave.Text = "Salva";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmAddDefaultPh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 478);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblNewProd);
            this.Controls.Add(this.cmbBoxSelProd);
            this.Controls.Add(this.tabControlPhases);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddDefaultPh";
            this.Text = "Inserimento fasi predefinite";
            this.Load += new System.EventHandler(this.FrmAddDefaultPh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPhases;
        private System.Windows.Forms.ComboBox cmbBoxSelProd;
        private System.Windows.Forms.Label lblNewProd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}