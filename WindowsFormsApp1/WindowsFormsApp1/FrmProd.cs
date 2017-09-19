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
        int nOftg = 1;
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
            nOftg++;
            TabPage tabPageX = new TabPage();
            // 
            // tabControlAddPh
            // 
            this.tabControlAddPh.Controls.Add(tabPageX);
            this.tabControlAddPh.Location = new System.Drawing.Point(10, 121);
            this.tabControlAddPh.Name = "tabControlAddPh";
            this.tabControlAddPh.SelectedIndex = 0;
            this.tabControlAddPh.Size = new System.Drawing.Size(885, 490);
            this.tabControlAddPh.TabIndex = 17;
            // 
            // tabPageX
            // 
            Button newBtnAddObj = new Button();
            DateTimePicker newDateTimePickerTo = new DateTimePicker();
            DateTimePicker newdateTimePickerFrom = new DateTimePicker();
            Label newLblTo = new Label();
            Label newLblFrom = new Label();
            ComboBox newCmbBoxWriteObj1 = new ComboBox();
            ComboBox newCmbBoxSelObj1 = new ComboBox();
            Button newBtnSavePhase = new Button();
            Label newLblNamePhase = new Label();
            TextBox newTxtBoxNamePhase = new TextBox();
            Button newBtnAddPhase = new Button();
            Button newBtnRemPhase = new Button();

            tabPageX.Controls.Add(newBtnAddObj);
            tabPageX.Controls.Add(newDateTimePickerTo);
            tabPageX.Controls.Add(newdateTimePickerFrom);
            tabPageX.Controls.Add(newLblTo);
            tabPageX.Controls.Add(newLblFrom);
            tabPageX.Controls.Add(newCmbBoxWriteObj1);
            tabPageX.Controls.Add(newCmbBoxSelObj1);
            tabPageX.Controls.Add(newBtnSavePhase);
            tabPageX.Controls.Add(newLblNamePhase);
            tabPageX.Controls.Add(newTxtBoxNamePhase);
            tabPageX.Controls.Add(newBtnAddPhase);
            tabPageX.Controls.Add(newBtnRemPhase);
            tabPageX.Location = new System.Drawing.Point(4, 22);
            tabPageX.Name = "tabPage" + nOftg;
            tabPageX.Size = new System.Drawing.Size(877, 464);
            tabPageX.TabIndex = 3;
            tabPageX.Text = "Fase " + nOftg;
            tabPageX.UseVisualStyleBackColor = true;
            tabPageX.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // btnAddObj
            // 
            newBtnAddObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newBtnAddObj.Location = new System.Drawing.Point(755, 88);
            newBtnAddObj.Name = "btnNewObj";
            newBtnAddObj.Size = new System.Drawing.Size(33, 33);
            newBtnAddObj.TabIndex = 63;
            newBtnAddObj.Text = "+";
            newBtnAddObj.UseVisualStyleBackColor = true;
            newBtnAddObj.Click += new System.EventHandler(this.btnNewObj_Click);
            // 
            // dateTimePickerTo
            // 
            newDateTimePickerTo.CalendarTitleBackColor = System.Drawing.SystemColors.WindowText;
            newDateTimePickerTo.CustomFormat = "dd/MM/yyyy HH:mm";
            newDateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            newDateTimePickerTo.Location = new System.Drawing.Point(549, 96);
            newDateTimePickerTo.Name = "dateTimePickerTo";
            newDateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            newDateTimePickerTo.TabIndex = 62;
            // 
            // dateTimePickerFrom
            // 
            newdateTimePickerFrom.CalendarTitleBackColor = System.Drawing.SystemColors.WindowText;
            newdateTimePickerFrom.CustomFormat = "dd/MM/yyyy HH:mm";
            newdateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            newdateTimePickerFrom.Location = new System.Drawing.Point(323, 96);
            newdateTimePickerFrom.Name = "dateTimePickerFrom";
            newdateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            newdateTimePickerFrom.TabIndex = 47;
            // 
            // lblTo
            // 
            newLblTo.AutoSize = true;
            newLblTo.Location = new System.Drawing.Point(529, 98);
            newLblTo.Name = "lblTo";
            newLblTo.Size = new System.Drawing.Size(14, 13);
            newLblTo.TabIndex = 61;
            newLblTo.Text = "A";
            // 
            // lblFrom
            // 
            newLblFrom.AutoSize = true;
            newLblFrom.Location = new System.Drawing.Point(296, 98);
            newLblFrom.Name = "lblFrom";
            newLblFrom.Size = new System.Drawing.Size(21, 13);
            newLblFrom.TabIndex = 60;
            newLblFrom.Text = "Da";
            // 
            // cmbBoxWriteObj1
            // 
            newCmbBoxWriteObj1.FormattingEnabled = true;
            newCmbBoxWriteObj1.Items.AddRange(new object[] {
            "Giovanni",
            "Paolo"});
            newCmbBoxWriteObj1.Location = new System.Drawing.Point(133, 95);
            newCmbBoxWriteObj1.Name = "cmbBoxWriteObj1";
            newCmbBoxWriteObj1.Size = new System.Drawing.Size(157, 21);
            newCmbBoxWriteObj1.TabIndex = 56;
            // 
            // cmbBoxSelObj1
            // 
            newCmbBoxSelObj1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            newCmbBoxSelObj1.FormattingEnabled = true;
            newCmbBoxSelObj1.Items.AddRange(new object[] {
            "Lavoratore",
            "Macchinario"});
            newCmbBoxSelObj1.Location = new System.Drawing.Point(6, 95);
            newCmbBoxSelObj1.Name = "cmbBoxSelObj1";
            newCmbBoxSelObj1.Size = new System.Drawing.Size(121, 21);
            newCmbBoxSelObj1.TabIndex = 55;
            // 
            // btnSavePhase
            // 
            newBtnSavePhase.Location = new System.Drawing.Point(712, 3);
            newBtnSavePhase.Name = "btnSavePhase";
            newBtnSavePhase.Size = new System.Drawing.Size(50, 50);
            newBtnSavePhase.TabIndex = 54;
            newBtnSavePhase.Text = "Salva Fase";
            newBtnSavePhase.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            newLblNamePhase.AutoSize = true;
            newLblNamePhase.Location = new System.Drawing.Point(3, 19);
            newLblNamePhase.Name = "label6";
            newLblNamePhase.Size = new System.Drawing.Size(61, 13);
            newLblNamePhase.TabIndex = 53;
            newLblNamePhase.Text = "Nome Fase";
            // 
            // textBox3
            // 
            newTxtBoxNamePhase.Location = new System.Drawing.Point(71, 16);
            newTxtBoxNamePhase.Name = "textBox3";
            newTxtBoxNamePhase.Size = new System.Drawing.Size(100, 20);
            newTxtBoxNamePhase.TabIndex = 52;
            // 
            // btnAddPhase
            // 
            newBtnAddPhase.Location = new System.Drawing.Point(768, 3);
            newBtnAddPhase.Name = "btnAddPhase";
            newBtnAddPhase.Size = new System.Drawing.Size(50, 50);
            newBtnAddPhase.TabIndex = 47;
            newBtnAddPhase.Text = "+";
            newBtnAddPhase.UseVisualStyleBackColor = true;
            newBtnAddPhase.Click += new System.EventHandler(this.btnAddPhase_Click);
            // 
            // btnRemPhase
            // 
            newBtnRemPhase.Location = new System.Drawing.Point(824, 3);
            newBtnRemPhase.Name = "btnRemPhase";
            newBtnRemPhase.Size = new System.Drawing.Size(50, 50);
            newBtnRemPhase.TabIndex = 64;
            newBtnRemPhase.Text = "-";
            newBtnRemPhase.UseVisualStyleBackColor = true;
            newBtnRemPhase.Click += new System.EventHandler(this.btnRemPhase_Click);
        }

        private void btnNewObj_Click(object sender, EventArgs e)
        {

        }

        private void btnRemPhase_Click(object sender, EventArgs e)
        {
            if (nOftg > 1)
            {
                nOftg--;
                this.tabControlAddPh.Controls.RemoveAt(tabControlAddPh.SelectedIndex);
            }
        }
    }
}