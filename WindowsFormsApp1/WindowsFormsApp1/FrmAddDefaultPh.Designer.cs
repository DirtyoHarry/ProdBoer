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
            this.SuspendLayout();
            // 
            // tabControlPhases
            // 
            this.tabControlPhases.Location = new System.Drawing.Point(12, 79);
            this.tabControlPhases.Name = "tabControlPhases";
            this.tabControlPhases.SelectedIndex = 0;
            this.tabControlPhases.Size = new System.Drawing.Size(700, 500);
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
            // FrmAddDefaultPh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 597);
            this.Controls.Add(this.lblNewProd);
            this.Controls.Add(this.cmbBoxSelProd);
            this.Controls.Add(this.tabControlPhases);
            this.Name = "FrmAddDefaultPh";
            this.Text = "FrmAddDefaultPh";
            this.Load += new System.EventHandler(this.FrmAddDefaultPh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPhases;
        private System.Windows.Forms.ComboBox cmbBoxSelProd;
        private System.Windows.Forms.Label lblNewProd;
    }
}