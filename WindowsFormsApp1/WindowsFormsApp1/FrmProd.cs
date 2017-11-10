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
        const int x = 6;
        int x1 = x;
        int dx = 6;
        const int y = 100;
        int y1 = y; //altezza obj in una tabPages
        int dy = 30; //(distance) --> distanza tra obj 

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
        List<List<int>> _intcmbBoxSelObjSelInd; //salva selected index
        List<int> _intcmbBoxSelObjSelIndPhaseX;
        List<List<int>> _intcmbBoxWriteObjSelInd; //salva selected index       
        List<int> _intcmbBoxWriteObjSelIndPhaseX;

        List<Label> _LblNamePhase;
        List<TextBox> _TxtBoxNamePhase;
        List<Label> _lblObjUsed;
        List<Button> _btnAddPhase;
        List<Button> _btnRemPhase;
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
            txtBoxCodComm.Enabled = cmbBoxSelProd.SelectedIndex == 1;
            if (cmbBoxSelProd.SelectedIndex == 0)
            { txtBoxCodComm.Text = ""; }
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
            _intcmbBoxSelObjSelInd = new List<List<int>>(); //salva selected index
            _intcmbBoxWriteObjSelInd = new List<List<int>>();//salva selected index    

            _LblNamePhase = new List<Label>();
            _TxtBoxNamePhase = new List<TextBox>();
            _lblObjUsed = new List<Label>();
            _btnAddPhase = new List<Button>();
            _btnRemPhase = new List<Button>();
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
            _intcmbBoxSelObjSelIndPhaseX = new List<int>();
            _intcmbBoxSelObjSelInd.Add(_intcmbBoxSelObjSelIndPhaseX); //salva selected index
            _intcmbBoxWriteObjSelIndPhaseX = new List<int>();
            _intcmbBoxWriteObjSelInd.Add(_intcmbBoxWriteObjSelIndPhaseX);  //salva selected index    
            int a1 = _dateTimePickerTo.Count;
            int a2 = _intcmbBoxSelObjSelInd.Count;
            int a3 = _intcmbBoxWriteObjSelInd.Count;
        }

        private void btnAddObj_Click(object sender, EventArgs e)
        {
            int phase = tabControlPhases.SelectedIndex;
            int count = _dateTimePickerFrom[phase].Count;
            SaveCmbBoxSelIndex();
            AddObject(phase);
            ShowOnePhase(phase);
            //setta data inizio e fine come nell'obj precedente
            _dateTimePickerFrom[phase][count].Value = _dateTimePickerFrom[phase][count - 1].Value; 
            _dateTimePickerTo[phase][count].Value = _dateTimePickerTo[phase][count - 1].Value;
        }

        private void AddObject(int phase)
        {
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
            _intcmbBoxWriteObjSelInd[phase].Add(-1);
            _intcmbBoxSelObjSelInd[phase].Add(-1);

            int a = _dateTimePickerTo[phase].Count;
            int b = _intcmbBoxWriteObjSelInd[phase].Count;
            int c = _intcmbBoxSelObjSelInd[phase].Count;
        }

        private void btnRemObj_Click(object sender, EventArgs e)
        {
            int phase = tabControlPhases.SelectedIndex;
            int index = _dateTimePickerTo[phase].Count-1;
            SaveCmbBoxSelIndex();
            RemoveObject(phase, index);
            ShowOnePhase(phase);
        }

        private void RemoveObject(int phase, int index)
        {
            //rimuove un obj (lavoratore o macchinario) di una fase
            if (_dateTimePickerTo[phase].Count > 1)
            {
                _dateTimePickerTo[phase].RemoveAt(index);
                _dateTimePickerFrom[phase].RemoveAt(index);
                _lblTo[phase].RemoveAt(index);
                _lblFrom[phase].RemoveAt(index);
                _cmbBoxWriteObj[phase].RemoveAt(index);
                _cmbBoxSelObj[phase].RemoveAt(index);
                _intcmbBoxSelObjSelInd[phase].RemoveAt(index); //salva selected index
                _intcmbBoxWriteObjSelInd[phase].RemoveAt(index); //salva selected index 
                int xx1 = _intcmbBoxSelObjSelInd[phase].Count;
                int xx2 = _intcmbBoxWriteObjSelInd[phase].Count;
            }
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
            lblTemp = new Label();
            _lblFromPhaseX.Add(lblTemp);
            _cmbBoxWriteObjPhaseX.Add(cmbBoxTemp);
            cmbBoxTemp = new ComboBox();
            _cmbBoxSelObjPhaseX.Add(cmbBoxTemp);
            _intcmbBoxSelObjSelIndPhaseX.Add(-1);
            _intcmbBoxWriteObjSelIndPhaseX.Add(-1);

            lblTemp = new Label();
            _lblObjUsed.Add(lblTemp);
            _BtnAddObj.Add(btnTemp);
            btnTemp = new Button();
            _BtnRemoveObj.Add(btnTemp);
            lblTemp = new Label();
            _LblNamePhase.Add(lblTemp);
            _TxtBoxNamePhase.Add(txtBoxTemp);
            btnTemp = new Button();
            _btnAddPhase.Add(btnTemp);
            btnTemp = new Button();
            _btnRemPhase.Add(btnTemp);

        }

        private void btnRemPhase_Click(object sender, EventArgs e)
        {
            int phase = tabControlPhases.SelectedIndex;
            RemovePhase(phase);
            ShowAllPhases();
            tabControlPhases.SelectedIndex = phase;
        }

        private void RemovePhase(int phase)
        {
            //rimuovi la fase selezionata
            if (nOfTabPages > 1)
            {
                for (int i = phase; i < nOfTabPages - 1; i++)
                {
                    _BtnAddObj[i] = _BtnAddObj[i + 1];
                    _BtnRemoveObj[i] = _BtnRemoveObj[i + 1];
                    _LblNamePhase[i] = _LblNamePhase[i + 1];
                    _TxtBoxNamePhase[i] = _TxtBoxNamePhase[i + 1];
                    _btnAddPhase[i] = _btnAddPhase[i + 1];
                    _btnRemPhase[i] = _btnRemPhase[i + 1];
                    _lblObjUsed[i] = _lblObjUsed[i + 1];
                    int a = _lblObjUsed.Count;
                    int b = _intcmbBoxSelObjSelInd.Count; //salva selected index 
                    int c = _intcmbBoxWriteObjSelInd.Count; //salva selected index
                    ChangeNOfObj(i);
                }
                nOfTabPages--;
                RemoveObjsAt(nOfTabPages);
            }
        }

        private void ChangeNOfObj(int phase)
        {
            int nOfObjDiff = _dateTimePickerTo[phase + 1].Count - _dateTimePickerTo[phase].Count;
            //se il numero di obj nella fase successiva è MAGGIORE a quella precedente
            if (nOfObjDiff > 0)
            {
                for (int j = 0; j < nOfObjDiff; j++)
                {
                    AddObject(phase);
                }
            }
            //se il numero di obj nella fase successiva è MINORE a quella precedente
            else if (nOfObjDiff < 0)
            {
                for (int j = (nOfObjDiff * -1); j > 0; j--)
                {
                    RemoveObject(phase, j);
                }
            }
            for (int j = 0; j < _dateTimePickerTo[phase + 1].Count; j++)
            {
                _dateTimePickerTo[phase][j] = _dateTimePickerTo[phase + 1][j];
                _dateTimePickerFrom[phase][j] = _dateTimePickerFrom[phase + 1][j];
                _lblTo[phase][j] = _lblTo[phase + 1][j];
                _lblFrom[phase][j] = _lblFrom[phase + 1][j];
                _cmbBoxWriteObj[phase][j] = _cmbBoxWriteObj[phase + 1][j];
                _cmbBoxSelObj[phase][j] = _cmbBoxSelObj[phase + 1][j];
                _intcmbBoxSelObjSelInd[phase][j] = _intcmbBoxSelObjSelInd[phase+1][j]; //salva selected index 
                _intcmbBoxWriteObjSelInd[phase][j] = _intcmbBoxWriteObjSelInd[phase+1][j]; //salva selected index
                int a = _lblTo[phase].Count;
                int b = _intcmbBoxSelObjSelInd[phase].Count; //salva selected index 
                int c = _intcmbBoxWriteObjSelInd[phase].Count; //salva selected index

            }
        }

        private void RemoveObjsAt(int phase)
        {
            //rimuove tutti gli oggetti di una fase
            _BtnAddObj.RemoveAt(phase);
            _BtnRemoveObj.RemoveAt(phase);
            _dateTimePickerTo.RemoveAt(phase);
            _dateTimePickerFrom.RemoveAt(phase);
            _lblTo.RemoveAt(phase);
            _lblFrom.RemoveAt(phase);
            _lblObjUsed.RemoveAt(phase);
            _cmbBoxWriteObj.RemoveAt(phase);
            _cmbBoxSelObj.RemoveAt(phase);
            _LblNamePhase.RemoveAt(phase);
            _TxtBoxNamePhase.RemoveAt(phase);
            _btnAddPhase.RemoveAt(phase);
            _btnRemPhase.RemoveAt(phase);
            _intcmbBoxSelObjSelInd.RemoveAt(phase);
            _intcmbBoxWriteObjSelInd.RemoveAt(phase);
        }

        private void ShowOnePhase(int phase)
        {
            //mostra gli obj di una fase
            tabControlPhases.TabPages[phase].Controls.Clear();
            tabControlPhases.TabPages[phase].Controls.Add(_BtnAddObj[phase]);
            tabControlPhases.TabPages[phase].Controls.Add(_BtnRemoveObj[phase]);
            tabControlPhases.TabPages[phase].Controls.Add(_LblNamePhase[phase]);
            tabControlPhases.TabPages[phase].Controls.Add(_TxtBoxNamePhase[phase]);
            tabControlPhases.TabPages[phase].Controls.Add(_btnAddPhase[phase]);
            tabControlPhases.TabPages[phase].Controls.Add(_btnRemPhase[phase]);
            tabControlPhases.TabPages[phase].Controls.Add(_lblObjUsed[phase]);

            for (int i = 0; i < _dateTimePickerTo[phase].Count; i++)
            {
                x1 = x;
                tabControlPhases.TabPages[phase].Controls.Add(_dateTimePickerTo[phase][i]);
                tabControlPhases.TabPages[phase].Controls.Add(_dateTimePickerFrom[phase][i]);
                tabControlPhases.TabPages[phase].Controls.Add(_lblTo[phase][i]);
                tabControlPhases.TabPages[phase].Controls.Add(_lblFrom[phase][i]);
                tabControlPhases.TabPages[phase].Controls.Add(_cmbBoxWriteObj[phase][i]);
                tabControlPhases.TabPages[phase].Controls.Add(_cmbBoxSelObj[phase][i]);
            }

            ShowBtnAddObj(phase);
            ShowBtnRemoveObj(phase);
            ShowLblObjUsed(phase);
            ShowLblNamePhase(phase);
            ShowTxtBoxNamePhase(phase);
            ShowBtnAddPhase(phase);
            ShowBtnRemovePhase(phase);

            ShowCmbBoxSelObj(phase, _intcmbBoxSelObjSelInd[phase]);
            ShowCmbBoxWriteObj(phase, _intcmbBoxWriteObjSelInd[phase]);
            ShowLabelFrom(phase);
            ShowDateTimePickerFrom(phase);
            ShowLabelTo(phase);
            ShowDateTimePickerTo(phase);
        }

        private void SaveCmbBoxSelIndex()
        {     
            //salva i selected index delle ComboBox       
            for (int i = 0; i < _cmbBoxSelObj.Count; i++)
            {
                for (int j = 0; j < _cmbBoxSelObj[i].Count; j++)
                {
                    _intcmbBoxSelObjSelInd[i][j] = _cmbBoxSelObj[i][j].SelectedIndex;
                    _intcmbBoxWriteObjSelInd[i][j] = _cmbBoxWriteObj[i][j].SelectedIndex;
                }
            }
        }

        private void ShowAllPhases()
        {
            SaveCmbBoxSelIndex();
            //mostra le fasi nella tabControl
            tabControlPhases.Controls.Clear();
            TabPage newTabPage;
            for (int phase = 0; phase < nOfTabPages; phase++)
            {
                newTabPage = new TabPage();
                tabControlPhases.Controls.Add(newTabPage);
                tabControlPhases.Location = new System.Drawing.Point(10, 121);
                tabControlPhases.Name = "tabControlAddPh";
                tabControlPhases.SelectedIndex = 0;
                tabControlPhases.Size = new System.Drawing.Size(885, 490);
                tabControlPhases.TabIndex = 17;

                newTabPage.Location = new System.Drawing.Point(4, 22);
                newTabPage.Name = "tabPage" + (phase + 1);
                newTabPage.Size = new System.Drawing.Size(877, 464);
                newTabPage.TabIndex = 3;
                newTabPage.Text = "Fase " + (phase + 1);
                newTabPage.UseVisualStyleBackColor = true;

                ShowOnePhase(phase);
            }
        }

        private void ShowBtnAddObj(int phase)
        {
            y1 = y - 7;
            _BtnAddObj[phase].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _BtnAddObj[phase].Location = new System.Drawing.Point(755, y1);
            _BtnAddObj[phase].Name = "btnNewObj";
            _BtnAddObj[phase].Size = new System.Drawing.Size(33, 33);
            _BtnAddObj[phase].TabIndex = 63;
            _BtnAddObj[phase].Text = "+";
            _BtnAddObj[phase].UseVisualStyleBackColor = true;
            RemoveClickEvent(_BtnAddObj[phase]);
            _BtnAddObj[phase].Click += new System.EventHandler(this.btnAddObj_Click);
        }

        private void ShowBtnRemoveObj(int phase)
        {
            y1 = y - 7;
            _BtnRemoveObj[phase].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _BtnRemoveObj[phase].Location = new System.Drawing.Point(790, y1);
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
            y1 = y;
            for (int j = 0; j < _dateTimePickerTo[phase].Count; j++)
            {
                _dateTimePickerTo[phase][j].CalendarTitleBackColor = System.Drawing.SystemColors.WindowText;
                _dateTimePickerTo[phase][j].CustomFormat = "dd/MM/yyyy HH:mm";
                _dateTimePickerTo[phase][j].Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                _dateTimePickerTo[phase][j].Location = new System.Drawing.Point(x1, y1);
                _dateTimePickerTo[phase][j].Name = "dateTimePickerTo";
                _dateTimePickerTo[phase][j].Size = new System.Drawing.Size(150, 20);
                _dateTimePickerTo[phase][j].TabIndex = 62;
                y1 = y1 + dy;
            }
            x1 = x1 + dx + _dateTimePickerTo[phase][0].Size.Width;
        }

        private void ShowDateTimePickerFrom(int phase)
        {
            y1 = y;
            for (int j = 0; j < _dateTimePickerFrom[phase].Count; j++)
            {
                _dateTimePickerFrom[phase][j].CalendarTitleBackColor = System.Drawing.SystemColors.WindowText;
                _dateTimePickerFrom[phase][j].CustomFormat = "dd/MM/yyyy HH:mm";
                _dateTimePickerFrom[phase][j].Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                _dateTimePickerFrom[phase][j].Location = new System.Drawing.Point(x1, y1);
                _dateTimePickerFrom[phase][j].Name = "dateTimePickerFrom";
                _dateTimePickerFrom[phase][j].Size = new System.Drawing.Size(150, 20);
                _dateTimePickerFrom[phase][j].TabIndex = 47;
                y1 = y1 + dy;
            }
            x1 = x1 + dx + _dateTimePickerFrom[phase][0].Size.Width;
        }

        private void ShowLabelTo(int phase)
        {
            y1 = y+2;
            for (int j = 0; j < _lblTo[phase].Count; j++)
            {
                _lblTo[phase][j].AutoSize = true;
                _lblTo[phase][j].Location = new System.Drawing.Point(x1, y1);
                _lblTo[phase][j].Name = "lblTo";
                _lblTo[phase][j].Size = new System.Drawing.Size(14, 13);
                _lblTo[phase][j].TabIndex = 61;
                _lblTo[phase][j].Text = "A";
                y1 = y1 + dy;
            }
            x1 = x1 + dx + _lblTo[phase][0].Size.Width;
        }

        private void ShowLabelFrom(int phase)
        {
            y1 = y+2;
            for (int j = 0; j < _lblFrom[phase].Count; j++)
            {
                _lblFrom[phase][j].AutoSize = true;
                _lblFrom[phase][j].Location = new System.Drawing.Point(x1, y1);
                _lblFrom[phase][j].Name = "lblFrom";
                _lblFrom[phase][j].Size = new System.Drawing.Size(21, 13);
                _lblFrom[phase][j].TabIndex = 60;
                _lblFrom[phase][j].Text = "Da";
                y1 = y1 + dy;
            }
            x1 = x1 + dx + _lblFrom[phase][0].Size.Width;
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

        private void ShowCmbBoxWriteObj(int phase, List<int> selIndex)
        {
            y1 = y;
            for (int j = 0; j < _cmbBoxWriteObj[phase].Count; j++)
            {
                _cmbBoxWriteObj[phase][j].DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                _cmbBoxWriteObj[phase][j].FormattingEnabled = true;
                _cmbBoxWriteObj[phase][j].Items.Clear();
                _cmbBoxWriteObj[phase][j].Items.AddRange(new object[] { "Giovanni", "Paolo" });
                _cmbBoxWriteObj[phase][j].Location = new System.Drawing.Point(x1, y1);
                _cmbBoxWriteObj[phase][j].Name = "cmbBoxWriteObj";
                _cmbBoxWriteObj[phase][j].Size = new System.Drawing.Size(250, 21);
                _cmbBoxWriteObj[phase][j].TabIndex = 56;
                _cmbBoxWriteObj[phase][j].SelectedIndex = selIndex[j];
                y1 = y1 + dy;
            }
            x1 = x1 + dx + _cmbBoxWriteObj[phase][0].Size.Width;
        }

        private void ShowCmbBoxSelObj(int phase, List<int> selIndex)
        {
            y1 = y;
            for (int j = 0; j < _cmbBoxSelObj[phase].Count; j++)
            {
                _cmbBoxSelObj[phase][j].DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                _cmbBoxSelObj[phase][j].FormattingEnabled = true;
                _cmbBoxSelObj[phase][j].Items.Clear();
                _cmbBoxSelObj[phase][j].Items.AddRange(new object[] { "Lavoratore", "Macchinario" });
                _cmbBoxSelObj[phase][j].Location = new System.Drawing.Point(x1, y1);
                _cmbBoxSelObj[phase][j].Name = "cmbBoxSelObj";
                _cmbBoxSelObj[phase][j].Size = new System.Drawing.Size(100, 21);
                _cmbBoxSelObj[phase][j].TabIndex = 55;
                _cmbBoxSelObj[phase][j].SelectedIndex = selIndex[j];
                y1 = y1 + dy;
            }
            x1 = x1 + dx + _cmbBoxSelObj[phase][0].Size.Width;
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

        private void ShowBtnAddPhase(int phase)
        {
            _btnAddPhase[phase].Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _btnAddPhase[phase].Location = new System.Drawing.Point(768, 3);
            _btnAddPhase[phase].Name = "btnAddPhase";
            _btnAddPhase[phase].Size = new System.Drawing.Size(50, 50);
            _btnAddPhase[phase].TabIndex = 47;
            _btnAddPhase[phase].Text = "+";
            _btnAddPhase[phase].UseVisualStyleBackColor = true;
            RemoveClickEvent(_btnAddPhase[phase]);
            _btnAddPhase[phase].Click += new System.EventHandler(this.btnAddPhase_Click);
        }

        private void ShowBtnRemovePhase(int phase)
        {
            _btnRemPhase[phase].Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _btnRemPhase[phase].Location = new System.Drawing.Point(824, 3);
            _btnRemPhase[phase].Name = "btnRemPhase";
            _btnRemPhase[phase].Size = new System.Drawing.Size(50, 50);
            _btnRemPhase[phase].TabIndex = 64;
            _btnRemPhase[phase].Text = "-";
            _btnRemPhase[phase].UseVisualStyleBackColor = true;
            RemoveClickEvent(_btnRemPhase[phase]);
            _btnRemPhase[phase].Click += new System.EventHandler(this.btnRemPhase_Click);
            tabControlPhases.SelectedIndex = phase;
        }

        private void RemoveClickEvent(Button b)
        {
            //resetta EventHandler (eventi) da un bottone
            FieldInfo f1 = typeof(Control).GetField("EventClick",
                BindingFlags.Static | BindingFlags.NonPublic);
            object obj = f1.GetValue(b);
            PropertyInfo pi = b.GetType().GetProperty("Events",
                BindingFlags.NonPublic | BindingFlags.Instance);
            EventHandlerList list = (EventHandlerList)pi.GetValue(b, null);
            list.RemoveHandler(obj, list[obj]);
        }

        private void txtBoxCodComm_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCodComm_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxNameProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNameProd_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxCodProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCodProd_Click(object sender, EventArgs e)
        {

        }
    }
}