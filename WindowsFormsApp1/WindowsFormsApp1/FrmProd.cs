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
        int nOftg = 1; //numero di tabPages aperte al momento
        int nOftgTot = 0; //numero di tabPages create in totale

        List<Button> newBtnAddObj;
        List<DateTimePicker> newDateTimePickerTo;
        List<DateTimePicker> newdateTimePickerFrom;
        List<Label> newLblTo;
        List<Label> newLblFrom;
        List<Label> newlblObjUsed;        
        List<ComboBox> newCmbBoxWriteObj;
        List<ComboBox> newCmbBoxSelObj;
        List<Button> newBtnSavePhase;
        List<Label> newLblNamePhase;
        List<TextBox> newTxtBoxNamePhase;
        List<Button> newBtnAddPhase;
        List<Button> newBtnRemPhase;

        public FrmNewOrd()
        {
            InitializeComponent();
            //dateTimePicker3.Format = Custom
        }

        private void FrmProd_Load(object sender, EventArgs e)
        {
            // cmbBoxSelObj1.SelectedIndex = 0;
            ListOfObjs();
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
            /*for (int i = 0; i < nOftg-1; i++)
            {

            }*/

            //salva una fase
            List<List<Button>> newCmbBoxWriteObj1 = new List<List<Button>>(); //lista matrice principale

            List <Button> CmbBoxWriteObjPhase1 = new List<Button>(); //lista matrice secondaria della fase x

            newCmbBoxWriteObj1.Add(CmbBoxWriteObjPhase1);
            Button newCmbBoxWriteObjPhase1 = new Button(); //oggetto temporaneo della lista matrice secondaria della fase x
            CmbBoxWriteObjPhase1.Add(newCmbBoxWriteObjPhase1);
            newCmbBoxWriteObjPhase1.Text = "phase 1 button 1";
            MessageBox.Show(newCmbBoxWriteObj1[0][0].Text);
            Refresh();

            newCmbBoxWriteObjPhase1 = new Button(); //oggetto temporaneo della lista matrice secondaria della fase x
            CmbBoxWriteObjPhase1.Add(newCmbBoxWriteObjPhase1);
            newCmbBoxWriteObjPhase1.Text = "phase 1 button 2";
            MessageBox.Show(newCmbBoxWriteObj1[0][1].Text);
            Refresh();


            List<Button> CmbBoxWriteObjPhase2 = new List<Button>(); //lista matrice secondaria della fase x

            newCmbBoxWriteObj1.Add(CmbBoxWriteObjPhase2);
            Button newCmbBoxWriteObjPhase2 = new Button(); //oggetto temporaneo della lista matrice secondaria della fase x
            CmbBoxWriteObjPhase2.Add(newCmbBoxWriteObjPhase2);
            newCmbBoxWriteObjPhase2.Text = "phase 2 button 1";

            MessageBox.Show(newCmbBoxWriteObj1[1][0].Text);
            Refresh();

        }

        private void ListOfObjs()
        {
            newBtnAddObj = new List<Button>();
            newDateTimePickerTo = new List<DateTimePicker>();
            newdateTimePickerFrom = new List<DateTimePicker>();
            newLblTo = new List<Label>();
            newLblFrom = new List<Label>();
            newlblObjUsed = new List<Label>();            
            newCmbBoxWriteObj = new List<ComboBox>();
            newCmbBoxSelObj = new List<ComboBox>();
            newBtnSavePhase = new List<Button>();
            newLblNamePhase = new List<Label>();
            newTxtBoxNamePhase = new List<TextBox>();
            newBtnAddPhase = new List<Button>();
            newBtnRemPhase = new List<Button>();
        }

        private void PhaseObjRow()
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
            Button nnewBtnAddObj = new Button();
            newBtnAddObj.Add(nnewBtnAddObj);
            DateTimePicker nnewDateTimePickerTo = new DateTimePicker();
            newDateTimePickerTo.Add(nnewDateTimePickerTo);
            DateTimePicker nnewdateTimePickerFrom = new DateTimePicker();
            newdateTimePickerFrom.Add(nnewdateTimePickerFrom);
            Label nnewLblTo = new Label();
            newLblTo.Add(nnewLblTo);
            Label nnewLblFrom = new Label();
            newLblFrom.Add(nnewLblFrom);
            Label nnewlblObjUsed = new Label();
            newlblObjUsed.Add(nnewlblObjUsed);            
            ComboBox nnewCmbBoxWriteObj1 = new ComboBox();
            newCmbBoxWriteObj.Add(nnewCmbBoxWriteObj1);
            ComboBox nnewCmbBoxSelObj1 = new ComboBox();
            newCmbBoxSelObj.Add(nnewCmbBoxSelObj1);
            Button nnewBtnSavePhase = new Button();
            newBtnSavePhase.Add(nnewBtnSavePhase);
            Label nnewLblNamePhase = new Label();
            newLblNamePhase.Add(nnewLblNamePhase);
            TextBox nnewTxtBoxNamePhase = new TextBox();
            newTxtBoxNamePhase.Add(nnewTxtBoxNamePhase);
            Button nnewBtnAddPhase = new Button();
            newBtnAddPhase.Add(nnewBtnAddPhase);
            Button nnewBtnRemPhase = new Button();
            newBtnRemPhase.Add(nnewBtnRemPhase);


            tabPageX.Controls.Add(nnewBtnAddObj);
            tabPageX.Controls.Add(nnewDateTimePickerTo);
            tabPageX.Controls.Add(nnewdateTimePickerFrom);
            tabPageX.Controls.Add(nnewLblTo);
            tabPageX.Controls.Add(nnewLblFrom);
            tabPageX.Controls.Add(nnewlblObjUsed); 
            tabPageX.Controls.Add(nnewCmbBoxWriteObj1);
            tabPageX.Controls.Add(nnewCmbBoxSelObj1);
            tabPageX.Controls.Add(nnewBtnSavePhase);
            tabPageX.Controls.Add(nnewLblNamePhase);
            tabPageX.Controls.Add(nnewTxtBoxNamePhase);
            tabPageX.Controls.Add(nnewBtnAddPhase);
            tabPageX.Controls.Add(nnewBtnRemPhase);
            tabPageX.Location = new System.Drawing.Point(4, 22);
            tabPageX.Name = "tabPage" + (nOftgTot + 2);
            tabPageX.Size = new System.Drawing.Size(877, 464);
            tabPageX.TabIndex = 3;
            tabPageX.Text = "Fase " + (nOftgTot + 2);
            tabPageX.UseVisualStyleBackColor = true;
            tabPageX.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // btnAddObj
            // 
            newBtnAddObj[nOftgTot].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newBtnAddObj[nOftgTot].Location = new System.Drawing.Point(755, 88);
            newBtnAddObj[nOftgTot].Name = "btnNewObj";
            newBtnAddObj[nOftgTot].Size = new System.Drawing.Size(33, 33);
            newBtnAddObj[nOftgTot].TabIndex = 63;
            newBtnAddObj[nOftgTot].Text = "+";
            newBtnAddObj[nOftgTot].UseVisualStyleBackColor = true;
            newBtnAddObj[nOftgTot].Click += new System.EventHandler(this.btnNewObj_Click);
            // 
            // dateTimePickerTo
            // 
            newDateTimePickerTo[nOftgTot].CalendarTitleBackColor = System.Drawing.SystemColors.WindowText;
            newDateTimePickerTo[nOftgTot].CustomFormat = "dd/MM/yyyy HH:mm";
            newDateTimePickerTo[nOftgTot].Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            newDateTimePickerTo[nOftgTot].Location = new System.Drawing.Point(549, 96);
            newDateTimePickerTo[nOftgTot].Name = "dateTimePickerTo";
            newDateTimePickerTo[nOftgTot].Size = new System.Drawing.Size(200, 20);
            newDateTimePickerTo[nOftgTot].TabIndex = 62;
            // 
            // dateTimePickerFrom
            // 
            newdateTimePickerFrom[nOftgTot].CalendarTitleBackColor = System.Drawing.SystemColors.WindowText;
            newdateTimePickerFrom[nOftgTot].CustomFormat = "dd/MM/yyyy HH:mm";
            newdateTimePickerFrom[nOftgTot].Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            newdateTimePickerFrom[nOftgTot].Location = new System.Drawing.Point(323, 96);
            newdateTimePickerFrom[nOftgTot].Name = "dateTimePickerFrom";
            newdateTimePickerFrom[nOftgTot].Size = new System.Drawing.Size(200, 20);
            newdateTimePickerFrom[nOftgTot].TabIndex = 47;
            // 
            // lblTo
            // 
            newLblTo[nOftgTot].AutoSize = true;
            newLblTo[nOftgTot].Location = new System.Drawing.Point(529, 98);
            newLblTo[nOftgTot].Name = "lblTo";
            newLblTo[nOftgTot].Size = new System.Drawing.Size(14, 13);
            newLblTo[nOftgTot].TabIndex = 61;
            newLblTo[nOftgTot].Text = "A";
            // 
            // lblFrom
            // 
            newLblFrom[nOftgTot].AutoSize = true;
            newLblFrom[nOftgTot].Location = new System.Drawing.Point(296, 98);
            newLblFrom[nOftgTot].Name = "lblFrom";
            newLblFrom[nOftgTot].Size = new System.Drawing.Size(21, 13);
            newLblFrom[nOftgTot].TabIndex = 60;
            newLblFrom[nOftgTot].Text = "Da";
            // 
            // lblObjUsed
            // 
            newlblObjUsed[nOftgTot].AutoSize = true;
            newlblObjUsed[nOftgTot].Location = new System.Drawing.Point(8, 76);
            newlblObjUsed[nOftgTot].Name = "lblObjUsed";
            newlblObjUsed[nOftgTot].Size = new System.Drawing.Size(156, 13);
            newlblObjUsed[nOftgTot].TabIndex = 65;
            newlblObjUsed[nOftgTot].Text = "Lavoratori e macchinari utilizzati:";
            // 
            // cmbBoxWriteObj1
            // 
            newCmbBoxWriteObj[nOftgTot].FormattingEnabled = true;
            newCmbBoxWriteObj[nOftgTot].Items.AddRange(new object[] {
            "Giovanni",
            "Paolo"});
            newCmbBoxWriteObj[nOftgTot].Location = new System.Drawing.Point(133, 95);
            newCmbBoxWriteObj[nOftgTot].Name = "cmbBoxWriteObj1";
            newCmbBoxWriteObj[nOftgTot].Size = new System.Drawing.Size(157, 21);
            newCmbBoxWriteObj[nOftgTot].TabIndex = 56;
            // 
            // cmbBoxSelObj1
            // 
            newCmbBoxSelObj[nOftgTot].DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            newCmbBoxSelObj[nOftgTot].FormattingEnabled = true;
            newCmbBoxSelObj[nOftgTot].Items.AddRange(new object[] {
            "Lavoratore",
            "Macchinario"});
            newCmbBoxSelObj[nOftgTot].Location = new System.Drawing.Point(6, 95);
            newCmbBoxSelObj[nOftgTot].Name = "cmbBoxSelObj1";
            newCmbBoxSelObj[nOftgTot].Size = new System.Drawing.Size(121, 21);
            newCmbBoxSelObj[nOftgTot].TabIndex = 55;
            // 
            // btnSavePhase
            // 
            newBtnSavePhase[nOftgTot].Location = new System.Drawing.Point(712, 3);
            newBtnSavePhase[nOftgTot].Name = "btnSavePhase";
            newBtnSavePhase[nOftgTot].Size = new System.Drawing.Size(50, 50);
            newBtnSavePhase[nOftgTot].TabIndex = 54;
            newBtnSavePhase[nOftgTot].Text = "Salva Fase";
            newBtnSavePhase[nOftgTot].UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            newLblNamePhase[nOftgTot].AutoSize = true;
            newLblNamePhase[nOftgTot].Location = new System.Drawing.Point(3, 19);
            newLblNamePhase[nOftgTot].Name = "label6";
            newLblNamePhase[nOftgTot].Size = new System.Drawing.Size(61, 13);
            newLblNamePhase[nOftgTot].TabIndex = 53;
            newLblNamePhase[nOftgTot].Text = "Nome Fase";
            // 
            // textBox3
            // 
            newTxtBoxNamePhase[nOftgTot].Location = new System.Drawing.Point(71, 16);
            newTxtBoxNamePhase[nOftgTot].Name = "textBox3";
            newTxtBoxNamePhase[nOftgTot].Size = new System.Drawing.Size(100, 20);
            newTxtBoxNamePhase[nOftgTot].TabIndex = 52;
            // 
            // btnAddPhase
            // 
            newBtnAddPhase[nOftgTot].Location = new System.Drawing.Point(768, 3);
            newBtnAddPhase[nOftgTot].Name = "btnAddPhase";
            newBtnAddPhase[nOftgTot].Size = new System.Drawing.Size(50, 50);
            newBtnAddPhase[nOftgTot].TabIndex = 47;
            newBtnAddPhase[nOftgTot].Text = "+";
            newBtnAddPhase[nOftgTot].UseVisualStyleBackColor = true;
            newBtnAddPhase[nOftgTot].Click += new System.EventHandler(this.btnAddPhase_Click);
            // 
            // btnRemPhase
            // 
            newBtnRemPhase[nOftgTot].Location = new System.Drawing.Point(824, 3);
            newBtnRemPhase[nOftgTot].Name = "btnRemPhase";
            newBtnRemPhase[nOftgTot].Size = new System.Drawing.Size(50, 50);
            newBtnRemPhase[nOftgTot].TabIndex = 64;
            newBtnRemPhase[nOftgTot].Text = "-";
            newBtnRemPhase[nOftgTot].UseVisualStyleBackColor = true;
            newBtnRemPhase[nOftgTot].Click += new System.EventHandler(this.btnRemPhase_Click);
            nOftgTot++;
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

        private void btnSavePhase_Click(object sender, EventArgs e)
        {

        }
    }
}