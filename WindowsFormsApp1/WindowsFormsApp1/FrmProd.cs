using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace ProdCycleBoer
{
    public partial class FrmNewOrd : Form
    { 
        //articolo su misura
        public FrmNewOrd()
        {
            InitializeComponent();
            //dateTimePicker3.Format = Custom
        }

        private void FrmProd_Load(object sender, EventArgs e)
        {
           // cmbBoxSelObj1.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxCodComm.Visible = lblCodComm.Visible = cmbBoxSelProd.SelectedIndex == 1;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
         
        }

        private void label8_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPhase_Click(object sender, EventArgs e)
        {
            /*// your TabControl will be defined in your designer
            // as will your original TabPage
            TabPage tpOld = tabControlAddPh.SelectedTab;

            TabPage tpNew = new TabPage();
            foreach (Control c in tpOld.Controls)
            {
                Control cNew = (Control)Activator.CreateInstance(c.GetType());

                PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(c);

                foreach (PropertyDescriptor entry in pdc)
                {
                    object val = entry.GetValue(c);
                    entry.SetValue(cNew, val);
                }

                // add control to new TabPage
                tpNew.Controls.Add(cNew);
            }
            tpNew.BackColor = Color.White;
            tpNew.Text = "Fase";
            tabControlAddPh.TabPages.Add(tpNew);*/

            TabPage tpNew = new TabPage();
            // 
            // tabControlAddPh
            // 
            this.tabControlAddPh.Controls.Add(tpNew);
            this.tabControlAddPh.Location = new System.Drawing.Point(10, 121);
            this.tabControlAddPh.Name = "tabControlAddPh";
            this.tabControlAddPh.SelectedIndex = 0;
            this.tabControlAddPh.Size = new System.Drawing.Size(885, 490);
            this.tabControlAddPh.TabIndex = 17;
            // 
            // tabPage1
            // 
            
            this.tpNew.Controls.Add(this.btnNewObj);
            this.tpNew.Controls.Add(this.dateTimePickerTo);
            this.tpNew.Controls.Add(this.dateTimePickerFrom);
            this.tpNew.Controls.Add(this.lblTo);
            this.tpNew.Controls.Add(this.lblFrom);
            this.tpNew.Controls.Add(this.cmbBoxWriteObj1);
            this.tpNew.Controls.Add(this.cmbBoxSelObj1);
            this.tpNew.Controls.Add(this.button2);
            this.tpNew.Controls.Add(this.label6);
            this.tpNew.Controls.Add(this.textBox3);
            this.tpNew.Controls.Add(this.btnAddPhase);
            this.tpNew.Location = new System.Drawing.Point(4, 22);
            this.tpNew.Name = "tabPage1";
            this.tpNew.Size = new System.Drawing.Size(877, 464);
            this.tpNew.TabIndex = 3;
            this.tpNew.Text = "Fase";
            this.tpNew.UseVisualStyleBackColor = true;
            this.tpNew.Click += new System.EventHandler(this.tabPage4_Click);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(746, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 44);
            this.button2.TabIndex = 54;
            this.button2.Text = "Salva Fase";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Nome Fase";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(71, 16);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 52;
            // 
            // btnAddPhase
            // 
            this.btnAddPhase.Location = new System.Drawing.Point(810, 3);
            this.btnAddPhase.Name = "btnAddPhase";
            this.btnAddPhase.Size = new System.Drawing.Size(58, 44);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Scadenza:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Inizio:";
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
            // btnNewObj
            // 
            this.btnNewObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewObj.Location = new System.Drawing.Point(755, 88);
            this.btnNewObj.Name = "btnNewObj";
            this.btnNewObj.Size = new System.Drawing.Size(33, 33);
            this.btnNewObj.TabIndex = 63;
            this.btnNewObj.Text = "+";
            this.btnNewObj.UseVisualStyleBackColor = true;
            this.btnNewObj.Click += new System.EventHandler(this.btnNewObj_Click);
            Refresh();

        }

        private void btnNewObj_Click(object sender, EventArgs e)
        {

        }
    }
}
