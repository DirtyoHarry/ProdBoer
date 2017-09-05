namespace WindowsFormsApp1
{
    partial class FrmDetails
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblSpec = new System.Windows.Forms.Label();
            this.TxtBox1 = new System.Windows.Forms.TextBox();
            this.TxtBox2 = new System.Windows.Forms.TextBox();
            this.TxtBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(12, 70);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Cognome";
            // 
            // lblSpec
            // 
            this.lblSpec.AutoSize = true;
            this.lblSpec.Location = new System.Drawing.Point(12, 97);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(85, 13);
            this.lblSpec.TabIndex = 2;
            this.lblSpec.Text = "Specializzazione";
            // 
            // TxtBox1
            // 
            this.TxtBox1.Location = new System.Drawing.Point(148, 41);
            this.TxtBox1.Name = "TxtBox1";
            this.TxtBox1.Size = new System.Drawing.Size(100, 20);
            this.TxtBox1.TabIndex = 3;
            // 
            // TxtBox2
            // 
            this.TxtBox2.Location = new System.Drawing.Point(148, 67);
            this.TxtBox2.Name = "TxtBox2";
            this.TxtBox2.Size = new System.Drawing.Size(100, 20);
            this.TxtBox2.TabIndex = 4;
            // 
            // TxtBox3
            // 
            this.TxtBox3.Location = new System.Drawing.Point(148, 94);
            this.TxtBox3.Name = "TxtBox3";
            this.TxtBox3.Size = new System.Drawing.Size(100, 20);
            this.TxtBox3.TabIndex = 5;
            // 
            // FrmDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 431);
            this.Controls.Add(this.TxtBox3);
            this.Controls.Add(this.TxtBox2);
            this.Controls.Add(this.TxtBox1);
            this.Controls.Add(this.lblSpec);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Name = "FrmDetails";
            this.Text = "FrmOrders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblSpec;
        private System.Windows.Forms.TextBox TxtBox1;
        private System.Windows.Forms.TextBox TxtBox2;
        private System.Windows.Forms.TextBox TxtBox3;
    }
}