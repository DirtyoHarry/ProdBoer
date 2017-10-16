using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;
using System.ComponentModel;

namespace ProdCycleBoer
{
    public partial class FrmNewOrd : Form
    {
        //articolo su misura
        int nOfTabPages = 0; //numero di tabPages create in totale
        int y = 100; //altezza obj in una tabPages
        int d = 30; //(distance) --> distanza tra obj 

        List<List<ComboBox>> _cmbBoxSelObj;
        List<ComboBox> _cmbBoxSelObjPhaseX;
        List<List<ComboBox>> _cmbBoxWriteObj;
        List<ComboBox> _cmbBoxWriteObjPhaseX;
        List<List<Label>> _lblFrom;
        List<Label> _lblFromPhaseX;
        List<List<DateTimePicker>> _dateTimePickerFrom;
        List<DateTimePicker> _dateTimePickerFromPhaseX;
        List<List<Label>> _lblTo;
        List<Label> _lblToPhaseX;
        List<List<DateTimePicker>> _dateTimePickerTo;
        List<DateTimePicker> _dateTimePickerToPhaseX;

        List<Label> _LblNamePhase;
        List<TextBox> _TxtBoxNamePhase;
        List<Label> _lblObjUsed;
        List<Button> _BtnAddPhase;
        List<Button> _BtnRemPhase;
        List<Button> _BtnAddObj;
        List<Button> _BtnRemoveObj;

        public FrmNewOrd()
        {
            InitializeComponent();
        }

        private void FrmProd_Load(object sender, EventArgs e)
        {
            InitializeObjList();
            AddPhase();
            ShowAllPhases();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxCodComm.Visible = lblCodComm.Visible = cmbBoxSelProd.SelectedIndex == 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*for (int i = 0; i < nOftg-1; i++)
            {

            }*/

            //salva una fase
        }

        private void InitializeObjList()
        {
            //inizializza gli oggetti --> fa le new
            _cmbBoxSelObj = new List<List<ComboBox>>(); //lista matrice principale
            _cmbBoxWriteObj = new List<List<ComboBox>>(); //lista matrice principale  
            _lblFrom = new List<List<Label>>(); //lista matrice principale
            _dateTimePickerFrom = new List<List<DateTimePicker>>(); //lista matrice principale 
            _lblTo = new List<List<Label>>(); //lista matrice principale
            _dateTimePickerTo = new List<List<DateTimePicker>>(); //lista matrice principale

            _LblNamePhase = new List<Label>();
            _TxtBoxNamePhase = new List<TextBox>();
            _lblObjUsed = new List<Label>();
            _BtnAddPhase = new List<Button>();
            _BtnRemPhase = new List<Button>();
            _BtnAddObj = new List<Button>();
            _BtnRemoveObj = new List<Button>();
        }

        private void AddListToMainList()
        {
            //aggiunge una lista (temporanea, non contiene dati) alla lista principale dell'obj
            _cmbBoxSelObjPhaseX = new List<ComboBox>();
            _cmbBoxSelObj.Add(_cmbBoxSelObjPhaseX);
            _cmbBoxWriteObjPhaseX = new List<ComboBox>();
            _cmbBoxWriteObj.Add(_cmbBoxWriteObjPhaseX);
            _lblFromPhaseX = new List<Label>();
            _lblFrom.Add(_lblFromPhaseX);
            _dateTimePickerFromPhaseX = new List<DateTimePicker>();
            _dateTimePickerFrom.Add(_dateTimePickerFromPhaseX);
            _lblToPhaseX = new List<Label>();
            _lblTo.Add(_lblToPhaseX);
            _dateTimePickerToPhaseX = new List<DateTimePicker>();
            _dateTimePickerTo.Add(_dateTimePickerToPhaseX);
        }

        private void btnNewObj_Click(object sender, EventArgs e)
        {
            int phase = tabControlPhases.SelectedIndex;
            AddObject(phase);
            ShowOnePhase(phase);
        }

        private void AddObject(int phase)
        {
            //ANCORA MAI TESTATO
            //aggiungi nuovo lavoratore o macchinario
            DateTimePicker dateTimePickerTemp = new DateTimePicker();
            Label lblTemp = new Label();
            ComboBox cmbBoxTemp = new ComboBox();
            TextBox txtBoxTemp = new TextBox();
            
            _cmbBoxSelObj[phase].Add(cmbBoxTemp);
            cmbBoxTemp = new ComboBox();
            _cmbBoxWriteObj[phase].Add(cmbBoxTemp);
            _lblFrom[phase].Add(lblTemp);
            _dateTimePickerFrom[phase].Add(dateTimePickerTemp);
            lblTemp = new Label();
            _lblTo[phase].Add(lblTemp);
            dateTimePickerTemp = new DateTimePicker();
            _dateTimePickerTo[phase].Add(dateTimePickerTemp);
        }

        private void btnRemObj_Click(object sender, EventArgs e)
        {

        }

        private void RemoveObject(int index)
        {
            //rimuovi l'ultimo lavoratore o macchinario
        }

        private void btnAddPhase_Click(object sender, EventArgs e)
        {
            AddPhase();
            ShowAllPhases();
        }

        private void AddPhase()
        {
            //aggiungi una fase
            nOfTabPages++;
            Button btnTemp = new Button();
            DateTimePicker dateTimePickerTemp = new DateTimePicker();
            Label lblTemp = new Label();
            ComboBox cmbBoxTemp = new ComboBox();
            TextBox txtBoxTemp = new TextBox();

            AddListToMainList();
            _dateTimePickerToPhaseX.Add(dateTimePickerTemp);
            dateTimePickerTemp = new DateTimePicker();
            _dateTimePickerFromPhaseX.Add(dateTimePickerTemp);
            _lblToPhaseX.Add(lblTemp);
            lblTemp = new Label();
            _lblFromPhaseX.Add(lblTemp);
            _cmbBoxWriteObjPhaseX.Add(cmbBoxTemp);
            cmbBoxTemp = new ComboBox();
            _cmbBoxSelObjPhaseX.Add(cmbBoxTemp);

            lblTemp = new Label();
            _lblObjUsed.Add(lblTemp);
            _BtnAddObj.Add(btnTemp);
            btnTemp = new Button();
            _BtnRemoveObj.Add(btnTemp);
            lblTemp = new Label();
            _LblNamePhase.Add(lblTemp);
            _TxtBoxNamePhase.Add(txtBoxTemp);
            btnTemp = new Button();
            _BtnAddPhase.Add(btnTemp);
            btnTemp = new Button();
            _BtnRemPhase.Add(btnTemp);
        }

        private void btnRemPhase_Click(object sender, EventArgs e)
        {
            RemovePhase();
            ShowAllPhases();
        }

        private void RemovePhase()
        {
            //togli una fase
            if (nOfTabPages > 1)
            {
                for (int i = tabControlPhases.SelectedIndex; i < nOfTabPages - 1; i++)
                {
                    _BtnAddObj[i] = _BtnAddObj[i + 1];
                    _BtnRemoveObj[i] = _BtnRemoveObj[i + 1];
                    _dateTimePickerTo[i][0] = _dateTimePickerTo[i + 1][0];
                    _dateTimePickerFrom[i][0] = _dateTimePickerFrom[i + 1][0];
                    _lblTo[i][0] = _lblTo[i + 1][0];
                    _lblFrom[i][0] = _lblFrom[i + 1][0];
                    _lblObjUsed[i] = _lblObjUsed[i + 1];
                    _cmbBoxWriteObj[i][0] = _cmbBoxWriteObj[i + 1][0];
                    _cmbBoxSelObj[i][0] = _cmbBoxSelObj[i + 1][0];
                    _LblNamePhase[i] = _LblNamePhase[i + 1];
                    _TxtBoxNamePhase[i] = _TxtBoxNamePhase[i + 1];
                    _BtnAddPhase[i] = _BtnAddPhase[i + 1];
                    _BtnRemPhase[i] = _BtnRemPhase[i + 1];
                }
                nOfTabPages--;
                RemoveObjsAt(nOfTabPages);
            }
        }

        private void RemoveObjsAt(int index)
        {
            _BtnAddObj.RemoveAt(index);
            _BtnRemoveObj.RemoveAt(index);
            _dateTimePickerTo.RemoveAt(index);
            _dateTimePickerFrom.RemoveAt(index);
            _lblTo.RemoveAt(index);
            _lblFrom.RemoveAt(index);
            _lblObjUsed.RemoveAt(index);
            _cmbBoxWriteObj.RemoveAt(index);
            _cmbBoxSelObj.RemoveAt(index);
            _LblNamePhase.RemoveAt(index);
            _TxtBoxNamePhase.RemoveAt(index);
            _BtnAddPhase.RemoveAt(index);
            _BtnRemPhase.RemoveAt(index);
        }

        private void ShowOnePhase(int phase)
        {
            //mostra le fasi nella tabControl
            tabControlPhases.TabPages[phase].Controls.Clear();
            tabControlPhases.TabPages[phase].Controls.Add(_BtnAddObj[phase]);
            tabControlPhases.TabPages[phase].Controls.Add(_BtnRemoveObj[phase]);
            for (int i = 0; i < _dateTimePickerTo[phase].Count; i++)
            {
                tabControlPhases.TabPages[phase].Controls.Add(_dateTimePickerTo[phase][i]);
            }
            for (int i = 0; i < _dateTimePickerFrom[phase].Count; i++)
            {
                tabControlPhases.TabPages[phase].Controls.Add(_dateTimePickerFrom[phase][i]);
            }
            for (int i = 0; i < _lblTo[phase].Count; i++)
            {
                tabControlPhases.TabPages[phase].Controls.Add(_lblTo[phase][i]);
            }
            for (int i = 0; i < _lblFrom[phase].Count; i++)
            {
                tabControlPhases.TabPages[phase].Controls.Add(_lblFrom[phase][i]);
            }
            tabControlPhases.TabPages[phase].Controls.Add(_lblObjUsed[phase]);
            for (int i = 0; i < _cmbBoxWriteObj[phase].Count; i++)
            {
                tabControlPhases.TabPages[phase].Controls.Add(_cmbBoxWriteObj[phase][i]);
            }
            for (int i = 0; i < _cmbBoxSelObj[phase].Count; i++)
            {
                tabControlPhases.TabPages[phase].Controls.Add(_cmbBoxSelObj[phase][i]);
            }
            tabControlPhases.TabPages[phase].Controls.Add(_LblNamePhase[phase]);
            tabControlPhases.TabPages[phase].Controls.Add(_TxtBoxNamePhase[phase]);
            tabControlPhases.TabPages[phase].Controls.Add(_BtnAddPhase[phase]);
            tabControlPhases.TabPages[phase].Controls.Add(_BtnRemPhase[phase]);

            ShowBtnAddObj(phase);
            ShowBtnRemoveObj(phase);
            ShowDateTimePickerTo(phase);
            ShowDateTimePickerFrom(phase);
            ShowLabelTo(phase);
            ShowLabelFrom(phase);
            ShowLblObjUsed(phase);
            ShowCmbBoxWriteObj(phase);
            ShowCmbBoxSelObj(phase);
            ShowLblNamePhase(phase);
            ShowTxtBoxNamePhase(phase);
            ShowAddPhase(phase);
            ShowRemovePhase(phase);
        }


        private void ShowAllPhases()
        {
            //mostra le fasi nella tabControl
            tabControlPhases.Controls.Clear();
            TabPage newTabPage;
            for (int i = 0; i < nOfTabPages; i++)
            {
                newTabPage = new TabPage();
                tabControlPhases.Controls.Add(newTabPage);
                tabControlPhases.Location = new System.Drawing.Point(10, 121);
                tabControlPhases.Name = "tabControlAddPh";
                tabControlPhases.SelectedIndex = 0;
                tabControlPhases.Size = new System.Drawing.Size(885, 490);
                tabControlPhases.TabIndex = 17;

                newTabPage.Location = new System.Drawing.Point(4, 22);
                newTabPage.Name = "tabPage" + (i + 1);
                newTabPage.Size = new System.Drawing.Size(877, 464);
                newTabPage.TabIndex = 3;
                newTabPage.Text = "Fase " + (i + 1);
                newTabPage.UseVisualStyleBackColor = true;

                ShowOnePhase(i);
            }
        }

        private void ShowBtnAddObj(int phase)
        {
            _BtnAddObj[phase].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _BtnAddObj[phase].Location = new System.Drawing.Point(755, 88);
            _BtnAddObj[phase].Name = "btnNewObj";
            _BtnAddObj[phase].Size = new System.Drawing.Size(33, 33);
            _BtnAddObj[phase].TabIndex = 63;
            _BtnAddObj[phase].Text = "+";
            _BtnAddObj[phase].UseVisualStyleBackColor = true;
            RemoveClickEvent(_BtnAddObj[phase]);
            _BtnAddObj[phase].Click += new System.EventHandler(this.btnNewObj_Click);
        }

        private void ShowBtnRemoveObj(int phase)
        {
            _BtnRemoveObj[phase].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _BtnRemoveObj[phase].Location = new System.Drawing.Point(790, 88);
            _BtnRemoveObj[phase].Name = "btnRemObj";
            _BtnRemoveObj[phase].Size = new System.Drawing.Size(33, 33);
            _BtnRemoveObj[phase].TabIndex = 63;
            _BtnRemoveObj[phase].Text = "-";
            _BtnRemoveObj[phase].UseVisualStyleBackColor = true;
            RemoveClickEvent(_BtnRemoveObj[phase]);
            _BtnRemoveObj[phase].Click += new System.EventHandler(this.btnRemObj_Click);
        }

        private void ShowDateTimePickerTo(int phase)
        {
            y = 100;
            for (int j = 0; j < _dateTimePickerTo[phase].Count; j++)
            {
                _dateTimePickerTo[phase][j].CalendarTitleBackColor = System.Drawing.SystemColors.WindowText;
                _dateTimePickerTo[phase][j].CustomFormat = "dd/MM/yyyy HH:mm";
                _dateTimePickerTo[phase][j].Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                _dateTimePickerTo[phase][j].Location = new System.Drawing.Point(549, y);
                _dateTimePickerTo[phase][j].Name = "dateTimePickerTo";
                _dateTimePickerTo[phase][j].Size = new System.Drawing.Size(200, 20);
                _dateTimePickerTo[phase][j].TabIndex = 62;
                y = y + d;
            }
        }

        private void ShowDateTimePickerFrom(int phase)
        {
            y = 100;
            for (int j = 0; j < _dateTimePickerFrom[phase].Count; j++)
            {
                _dateTimePickerFrom[phase][j].CalendarTitleBackColor = System.Drawing.SystemColors.WindowText;
                _dateTimePickerFrom[phase][j].CustomFormat = "dd/MM/yyyy HH:mm";
                _dateTimePickerFrom[phase][j].Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                _dateTimePickerFrom[phase][j].Location = new System.Drawing.Point(323, y);
                _dateTimePickerFrom[phase][j].Name = "dateTimePickerFrom";
                _dateTimePickerFrom[phase][j].Size = new System.Drawing.Size(200, 20);
                _dateTimePickerFrom[phase][j].TabIndex = 47;
                y = y + d;
            }
        }

        private void ShowLabelTo(int phase)
        {
            y = 100+2;
            for (int j = 0; j < _lblTo[phase].Count; j++)
            {
                _lblTo[phase][j].AutoSize = true;
                _lblTo[phase][j].Location = new System.Drawing.Point(529, y);
                _lblTo[phase][j].Name = "lblTo";
                _lblTo[phase][j].Size = new System.Drawing.Size(14, 13);
                _lblTo[phase][j].TabIndex = 61;
                _lblTo[phase][j].Text = "A";
                y = y + d;
            }
        }

        private void ShowLabelFrom(int phase)
        {
            y = 100+2;
            for (int j = 0; j < _lblFrom[phase].Count; j++)
            {
                _lblFrom[phase][j].AutoSize = true;
                _lblFrom[phase][j].Location = new System.Drawing.Point(296, y);
                _lblFrom[phase][j].Name = "lblFrom";
                _lblFrom[phase][j].Size = new System.Drawing.Size(21, 13);
                _lblFrom[phase][j].TabIndex = 60;
                _lblFrom[phase][j].Text = "Da";
                y = y + d;
            }
        }

        private void ShowLblObjUsed(int phase)
        {
            _lblObjUsed[phase].AutoSize = true;
            _lblObjUsed[phase].Location = new System.Drawing.Point(8, 76);
            _lblObjUsed[phase].Name = "lblObjUsed";
            _lblObjUsed[phase].Size = new System.Drawing.Size(156, 13);
            _lblObjUsed[phase].TabIndex = 65;
            _lblObjUsed[phase].Text = "Lavoratori e macchinari utilizzati:";
        }

        private void ShowCmbBoxWriteObj(int phase)
        {
            y = 100;
            for (int j = 0; j < _cmbBoxWriteObj[phase].Count; j++)
            {
                _cmbBoxWriteObj[phase][j].FormattingEnabled = true;
                _cmbBoxWriteObj[phase][j].Items.AddRange(new object[] { "Giovanni", "Paolo" });
                _cmbBoxWriteObj[phase][j].Location = new System.Drawing.Point(133, y);
                _cmbBoxWriteObj[phase][j].Name = "cmbBoxWriteObj";
                _cmbBoxWriteObj[phase][j].Size = new System.Drawing.Size(157, 21);
                _cmbBoxWriteObj[phase][j].TabIndex = 56;
                y = y + d;
            }
        }

        private void ShowCmbBoxSelObj(int phase)
        {
            y = 100;
            for (int j = 0; j < _cmbBoxSelObj[phase].Count; j++)
            {
                _cmbBoxSelObj[phase][j].DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                _cmbBoxSelObj[phase][j].FormattingEnabled = true;
                _cmbBoxSelObj[phase][j].Items.AddRange(new object[] { "Lavoratore", "Macchinario" });
                _cmbBoxSelObj[phase][j].Location = new System.Drawing.Point(6, y);
                _cmbBoxSelObj[phase][j].Name = "cmbBoxSelObj";
                _cmbBoxSelObj[phase][j].Size = new System.Drawing.Size(121, 21);
                _cmbBoxSelObj[phase][j].TabIndex = 55;
                y = y + d;
            }
        }

        private void ShowLblNamePhase(int phase)
        {
            _LblNamePhase[phase].AutoSize = true;
            _LblNamePhase[phase].Location = new System.Drawing.Point(3, 19);
            _LblNamePhase[phase].Name = "label6";
            _LblNamePhase[phase].Size = new System.Drawing.Size(61, 13);
            _LblNamePhase[phase].TabIndex = 53;
            _LblNamePhase[phase].Text = "Nome Fase";
        }

        private void ShowTxtBoxNamePhase(int phase)
        {
            _TxtBoxNamePhase[phase].Location = new System.Drawing.Point(71, 16);
            _TxtBoxNamePhase[phase].Name = "txtBoxNamePhase";
            _TxtBoxNamePhase[phase].Size = new System.Drawing.Size(200, 20);
            _TxtBoxNamePhase[phase].TabIndex = 52;
        }

        private void ShowAddPhase(int phase)
        {
            _BtnAddPhase[phase].Location = new System.Drawing.Point(768, 3);
            _BtnAddPhase[phase].Name = "btnAddPhase";
            _BtnAddPhase[phase].Size = new System.Drawing.Size(50, 50);
            _BtnAddPhase[phase].TabIndex = 47;
            _BtnAddPhase[phase].Text = "+";
            _BtnAddPhase[phase].UseVisualStyleBackColor = true;
            RemoveClickEvent(_BtnAddPhase[phase]);
            _BtnAddPhase[phase].Click += new System.EventHandler(this.btnAddPhase_Click);
        }

        private void ShowRemovePhase(int phase)
        {
            _BtnRemPhase[phase].Location = new System.Drawing.Point(824, 3);
            _BtnRemPhase[phase].Name = "btnRemPhase";
            _BtnRemPhase[phase].Size = new System.Drawing.Size(50, 50);
            _BtnRemPhase[phase].TabIndex = 64;
            _BtnRemPhase[phase].Text = "-";
            _BtnRemPhase[phase].UseVisualStyleBackColor = true;
            RemoveClickEvent(_BtnRemPhase[phase]);
            _BtnRemPhase[phase].Click += new System.EventHandler(this.btnRemPhase_Click);
            tabControlPhases.SelectedIndex = phase;
        }

        private void RemoveClickEvent(Button b)
        {
            FieldInfo f1 = typeof(Control).GetField("EventClick",
                BindingFlags.Static | BindingFlags.NonPublic);
            object obj = f1.GetValue(b);
            PropertyInfo pi = b.GetType().GetProperty("Events",
                BindingFlags.NonPublic | BindingFlags.Instance);
            EventHandlerList list = (EventHandlerList)pi.GetValue(b, null);
            list.RemoveHandler(obj, list[obj]);
        }

        private void BtnToDebug_Click(object sender, EventArgs e)
        {
            string s = "N fasi: " + nOfTabPages.ToString() + " - ";
            for (int i = 0; i < nOfTabPages; i++)
            {
                s = s + _TxtBoxNamePhase[i].Text + "-";
            }
            MessageBox.Show(s);
        }
    }
}