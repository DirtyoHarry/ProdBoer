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
    public partial class FrmAddDefaultPh : Form
    {
        //articolo su misura
        int nOfTabPages = 0; //numero di tabPages create in totale
        const int x = 6;
        int x1 = x;
        int dx = 6;
        const int y = 100;
        int y1 = y; //altezza obj in una tabPages
        int dy = 30; //(distance) --> distanza tra obj 

        List<List<ComboBox>> _cmbBoxSelObjType;
        List<ComboBox> _cmbBoxSelObjTypePhaseX;
        List<List<ComboBox>> _cmbBoxSelObj;
        List<ComboBox> _cmbBoxSelObjPhaseX;
        List<List<int>> _cmbBoxSelObjTypeSelInd; //salva selected index
        List<int> _cmbBoxSelObjTypeSelIndPhaseX;
        List<List<int>> _cmbBoxSelObjSelInd; //salva selected index       
        List<int> _cmbBoxSelObjSelIndPhaseX;

        List<Label> _lblPhLength;
        List<NumericUpDown> _numUpDwSelLength;
        List<Label> _lblObjUsed;
        List<Button> _BtnAddObj;
        List<Button> _BtnRemoveObj;
        List<Label> _LblNamePhase;
        List<TextBox> _TxtBoxNamePhase;

        List<string> productsExt;
        List<string> productsInt;
        List<string> objsHuman;
        List<string> objsNotHuman;

        Production production;
        int productID = -1;
        bool edit = false;

        public FrmAddDefaultPh(List<string> _products, List<int> _prodType, List<string> _objs, List<int> _objsType)
        {
            InitializeComponent();
            production = new Production();
            SetProdObjLists(_products, _prodType, _objs, _objsType);
            InitializeObjList();
            SetCmbBoxSelProduct();
            cmbBoxSelProd.SelectedIndex = 0;
        }

        private void FrmAddDefaultPh_Load(object sender, EventArgs e)
        {

        }

        private void SetCmbBoxSelProduct()
        {
            List<int> useless;
            List<string> products = production.GetProducts(out useless);
            for (int i = 0; i < products.Count; i++)
            {
                cmbBoxSelProd.Items.Add(products[i]);
            }
        }

        private void SetTabPagesAsPhases()
        {
            tabControlPhases.TabPages.Clear();
            ClearAllObjects();
            int type = production.GetType(cmbBoxSelProd.SelectedIndex, "Products");
            int nOfPhases = production.CountPhasesByType(type);
            List<string> namePh = production.SelectWithWhereList("Name", "Phases", "Type", type.ToString());
            for (int i = 0; i < nOfPhases; i++)
            {
                AddPhaseMain();
                _TxtBoxNamePhase[i].Text = namePh[i];
            }
            ShowAllPhases();
        }

        private void SetProdObjLists(List<string> _products, List<int> _prodType, List<string> _objs, List<int> _objsType)
        {
            productsExt = new List<string>();
            productsInt = new List<string>();
            objsHuman = new List<string>();
            objsNotHuman = new List<string>();
            for (int i = 0; i < _products.Count; i++)
            {
                if (_prodType[i] == 0)
                { productsExt.Add(_products[i]); }
                else
                { productsInt.Add(_products[i]); }
            }
            for (int i = 0; i < _objs.Count; i++)
            {
                if (_objsType[i] == 0)
                { objsHuman.Add(_objs[i]); }
                else
                { objsNotHuman.Add(_objs[i]); }
            }
        }

        private void SetCmbBoxSelProd()
        {
            cmbBoxSelProd.Items.Clear();
            if (cmbBoxSelProd.SelectedIndex == 1)//interna
            {
                for (int i = 0; i < productsInt.Count; i++)
                { cmbBoxSelProd.Items.Add(productsInt[i]); }
            }
            else //esterna
            {
                for (int i = 0; i < productsExt.Count; i++)
                { cmbBoxSelProd.Items.Add(productsExt[i]); }
            }
        }


        private void InitializeObjList()
        {
            //inizializza gli oggetti --> fa le new
            _cmbBoxSelObjType = new List<List<ComboBox>>(); //lista matrice principale
            _cmbBoxSelObj = new List<List<ComboBox>>(); //lista matrice principale  
            _cmbBoxSelObjTypeSelInd = new List<List<int>>(); //salva selected index
            _cmbBoxSelObjSelInd = new List<List<int>>();//salva selected index  

            _numUpDwSelLength = new List<NumericUpDown>();
            _lblPhLength = new List<Label>();
            _lblObjUsed = new List<Label>();
            _BtnAddObj = new List<Button>();
            _BtnRemoveObj = new List<Button>();
            _TxtBoxNamePhase = new List<TextBox>();
            _LblNamePhase = new List<Label>();
        }

        private void AddListToMainList()
        {
            //aggiunge una lista (temporanea, non contiene dati) alla lista principale dell'obj
            _cmbBoxSelObjTypePhaseX = new List<ComboBox>();
            _cmbBoxSelObjType.Add(_cmbBoxSelObjTypePhaseX);
            _cmbBoxSelObjPhaseX = new List<ComboBox>();
            _cmbBoxSelObj.Add(_cmbBoxSelObjPhaseX);
            _cmbBoxSelObjTypeSelIndPhaseX = new List<int>();
            _cmbBoxSelObjTypeSelInd.Add(_cmbBoxSelObjTypeSelIndPhaseX); //salva selected index
            _cmbBoxSelObjSelIndPhaseX = new List<int>();
            _cmbBoxSelObjSelInd.Add(_cmbBoxSelObjSelIndPhaseX);  //salva selected index    
        }

        private void btnAddObj_Click(object sender, EventArgs e)
        {
            AddObj(tabControlPhases.SelectedIndex);
        }

        private void AddObj(int phase)
        {
            SaveCmbBoxSelIndex();
            AddObject(phase);
            ShowOnePhase(phase);
            Refresh();
        }



        private void AddObject(int phase)
        {
            //aggiungi nuovo lavoratore o macchinario
            ComboBox cmbBoxTemp = new ComboBox();
            NumericUpDown numUpDwTemp = new NumericUpDown();
            Label lblTemp = new Label();
            _numUpDwSelLength.Add(numUpDwTemp);
            _lblPhLength.Add(lblTemp);
            _cmbBoxSelObjType[phase].Add(cmbBoxTemp);
            cmbBoxTemp = new ComboBox();
            _cmbBoxSelObj[phase].Add(cmbBoxTemp);
            _cmbBoxSelObjTypeSelInd[phase].Add(-1);
            _cmbBoxSelObjSelInd[phase].Add(-1);
        }

        private void btnRemObj_Click(object sender, EventArgs e)
        {
            int phase = tabControlPhases.SelectedIndex;
            int index = _cmbBoxSelObj[phase].Count - 1;
            SaveCmbBoxSelIndex();
            RemoveObject(phase, index);
            ShowOnePhase(phase);
        }

        private void RemoveObject(int phase, int index)
        {
            //rimuove un obj (lavoratore o macchinario) di una fase
            if (_cmbBoxSelObj[phase].Count > 1)
            {
                _cmbBoxSelObj[phase].RemoveAt(index);
                _cmbBoxSelObjType[phase].RemoveAt(index);
                _cmbBoxSelObjTypeSelInd[phase].RemoveAt(index); //salva selected index
                _cmbBoxSelObjSelInd[phase].RemoveAt(index); //salva selected index 
            }
        }

        private void ClearAllObjects()
        {
            nOfTabPages = 0;
            _lblPhLength.Clear();
            _BtnAddObj.Clear();
            _BtnRemoveObj.Clear();
            _lblObjUsed.Clear();
            _cmbBoxSelObj.Clear();
            _cmbBoxSelObjType.Clear();
            _cmbBoxSelObjTypeSelInd.Clear();
            _cmbBoxSelObjSelInd.Clear();
            _numUpDwSelLength.Clear();
            _TxtBoxNamePhase.Clear();
            _LblNamePhase.Clear();
        }

        private void btnAddPhase_Click(object sender, EventArgs e)
        {
            AddPhaseMain();
        }

        private void AddPhaseMain()
        {
            AddPhase();
            int phase = tabControlPhases.SelectedIndex + 1;
            AddTabPage(phase);
            ShowOnePhase(phase);
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
            NumericUpDown numUpDwTemp = new NumericUpDown();

            AddListToMainList();
            _cmbBoxSelObjPhaseX.Add(cmbBoxTemp);
            cmbBoxTemp = new ComboBox();
            _cmbBoxSelObjTypePhaseX.Add(cmbBoxTemp);
            _cmbBoxSelObjTypeSelIndPhaseX.Add(-1);
            _cmbBoxSelObjSelIndPhaseX.Add(-1);

            _lblPhLength.Add(lblTemp);
            _numUpDwSelLength.Add(numUpDwTemp);
            lblTemp = new Label();
            _lblObjUsed.Add(lblTemp);
            _BtnAddObj.Add(btnTemp);
            btnTemp = new Button();
            _BtnRemoveObj.Add(btnTemp);
            lblTemp = new Label();
            _TxtBoxNamePhase.Add(txtBoxTemp);
            _LblNamePhase.Add(lblTemp);
        }

        private void ShowOnePhase(int phase)
        {
            //mostra gli obj di una fase
            tabControlPhases.TabPages[phase].Controls.Clear();
            tabControlPhases.TabPages[phase].Controls.Add(_BtnAddObj[phase]);
            tabControlPhases.TabPages[phase].Controls.Add(_BtnRemoveObj[phase]);
            tabControlPhases.TabPages[phase].Controls.Add(_lblObjUsed[phase]);
            tabControlPhases.TabPages[phase].Controls.Add(_lblPhLength[phase]);
            tabControlPhases.TabPages[phase].Controls.Add(_numUpDwSelLength[phase]);
            tabControlPhases.TabPages[phase].Controls.Add(_TxtBoxNamePhase[phase]);
            tabControlPhases.TabPages[phase].Controls.Add(_LblNamePhase[phase]);

            for (int i = 0; i < _cmbBoxSelObj[phase].Count; i++)
            {
                x1 = x;
                tabControlPhases.TabPages[phase].Controls.Add(_cmbBoxSelObj[phase][i]);
                tabControlPhases.TabPages[phase].Controls.Add(_cmbBoxSelObjType[phase][i]);
            }

            ShowLblNamePhase(phase);
            ShowTxtBoxNamePhase(phase);
            ShowNumUpDwSelLength(phase);
            ShowLblPhLength(phase);
            ShowBtnAddObj(phase);
            ShowBtnRemoveObj(phase);
            ShowLblObjUsed(phase);
            ShowCmbBoxSelObjType(phase, _cmbBoxSelObjTypeSelInd[phase]);
            ShowCmbBoxSelObj(phase, _cmbBoxSelObjSelInd[phase]);
        }

        private void SaveCmbBoxSelIndex()
        {
            //salva i selected index delle ComboBox       
            for (int phase = 0; phase < _cmbBoxSelObjType.Count; phase++)
            {
                for (int i = 0; i < _cmbBoxSelObjType[phase].Count; i++)
                {
                    int x = _cmbBoxSelObjTypeSelInd[phase][i] = _cmbBoxSelObjType[phase][i].SelectedIndex;
                    int y = _cmbBoxSelObjSelInd[phase][i] = _cmbBoxSelObj[phase][i].SelectedIndex;
                }
            }
        }

        private void ApplyCmbBoxSelIndex()
        {
            //salva i selected index delle ComboBox       
            try
            {
                for (int phase = 0; phase < _cmbBoxSelObjType.Count; phase++)
                {
                    for (int i = 0; i < _cmbBoxSelObjType[phase].Count; i++)
                    {
                        _cmbBoxSelObjType[phase][i].SelectedIndex = _cmbBoxSelObjTypeSelInd[phase][i];
                        _cmbBoxSelObj[phase][i].SelectedIndex = _cmbBoxSelObjSelInd[phase][i];
                    }
                }
            }
            catch
            { SaveCmbBoxSelIndex(); }
        }

        private void ShowAllPhases()
        {
            SaveCmbBoxSelIndex();
            //mostra le fasi nella tabControl
            tabControlPhases.Controls.Clear();
            for (int phase = 0; phase < nOfTabPages; phase++)
            {
                AddTabPage(phase);
                ShowOnePhase(phase);
            }
        }

        private void AddTabPage(int phase)
        {
            TabPage newTabPage = new TabPage();
            tabControlPhases.Controls.Add(newTabPage);
            tabControlPhases.Name = "tabControlAddPh";
            tabControlPhases.SelectedIndex = 0;
            tabControlPhases.TabIndex = 17;
            tabControlPhases.Size = new System.Drawing.Size(700, 500);

            newTabPage.Location = new System.Drawing.Point(4, 22);
            newTabPage.Name = "tabPage" + (phase + 1);
            newTabPage.Size = new System.Drawing.Size(545, 10);
            newTabPage.TabIndex = 3;
            newTabPage.Text = "Fase " + (phase + 1);
            newTabPage.UseVisualStyleBackColor = true;
        }

        private void ShowBtnAddObj(int phase)
        {
            y1 = y - 7;
            _BtnAddObj[phase].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _BtnAddObj[phase].Location = new System.Drawing.Point(370, y1);
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
            _BtnRemoveObj[phase].Location = new System.Drawing.Point(408, y1);
            _BtnRemoveObj[phase].Name = "btnRemObj";
            _BtnRemoveObj[phase].Size = new System.Drawing.Size(33, 33);
            _BtnRemoveObj[phase].TabIndex = 63;
            _BtnRemoveObj[phase].Text = "-";
            _BtnRemoveObj[phase].UseVisualStyleBackColor = true;
            RemoveClickEvent(_BtnRemoveObj[phase]);
            _BtnRemoveObj[phase].Click += new System.EventHandler(this.btnRemObj_Click);
        }


        private void ShowLblObjUsed(int phase)
        {
            _lblObjUsed[phase].AutoSize = true;
            _lblObjUsed[phase].Location = new System.Drawing.Point(6, 76);
            _lblObjUsed[phase].Name = "lblObjUsed";
            _lblObjUsed[phase].Size = new System.Drawing.Size(156, 13);
            _lblObjUsed[phase].TabIndex = 65;
            _lblObjUsed[phase].Text = "Lavoratori e macchinari utilizzati:";
        }

        private void ShowCmbBoxSelObj(int phase, List<int> selIndex)
        {
            y1 = y;
            for (int j = 0; j < _cmbBoxSelObj[phase].Count; j++)
            {
                _cmbBoxSelObj[phase][j].DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                _cmbBoxSelObj[phase][j].FormattingEnabled = true;
                _cmbBoxSelObj[phase][j].Location = new System.Drawing.Point(x1, y1);
                _cmbBoxSelObj[phase][j].Name = "cmbBoxSelObj";
                _cmbBoxSelObj[phase][j].Size = new System.Drawing.Size(250, 21);
                _cmbBoxSelObj[phase][j].TabIndex = 56;
                if (_cmbBoxSelObj[phase][j].Items.Count < selIndex[j])
                { _cmbBoxSelObj[phase][j].SelectedIndex = selIndex[j]; }
                y1 = y1 + dy;
            }
            x1 = x1 + dx + _cmbBoxSelObj[phase][0].Size.Width;
        }

        private void ShowCmbBoxSelObjType(int phase, List<int> selIndex)
        {
            y1 = y;
            for (int j = 0; j < _cmbBoxSelObjType[phase].Count; j++)
            {
                _cmbBoxSelObjType[phase][j].DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                _cmbBoxSelObjType[phase][j].FormattingEnabled = true;
                _cmbBoxSelObjType[phase][j].Items.Clear();
                _cmbBoxSelObjType[phase][j].Items.AddRange(new object[] { "Lavoratore", "Macchinario" });
                _cmbBoxSelObjType[phase][j].Location = new System.Drawing.Point(x1, y1);
                _cmbBoxSelObjType[phase][j].Name = "cmbBoxSelObjType";
                _cmbBoxSelObjType[phase][j].Size = new System.Drawing.Size(100, 21);
                _cmbBoxSelObjType[phase][j].TabIndex = 55;
                _cmbBoxSelObjType[phase][j].SelectedIndex = selIndex[j];
                y1 = y1 + dy;
                ComboBox cmb = new ComboBox();
                cmb = _cmbBoxSelObjType[phase][j];
                cmb.SelectedIndexChanged += new System.EventHandler(cmbBoxSelObjType_SelectedIndexChanged);
            }
            x1 = x1 + dx + _cmbBoxSelObjType[phase][0].Size.Width;
        }


        private void ShowLblPhLength(int phase)
        {
            _lblPhLength[phase].AutoSize = true;
            _lblPhLength[phase].Location = new System.Drawing.Point(6, 48);
            _lblPhLength[phase].Name = "label1";
            _lblPhLength[phase].Size = new System.Drawing.Size(35, 13);
            _lblPhLength[phase].TabIndex = 1;
            _lblPhLength[phase].Text = "Durata della fase (in mezz'ore):";
        }

        private void ShowNumUpDwSelLength(int phase)
        {
            _numUpDwSelLength[phase].Location = new System.Drawing.Point(170, 48);
            _numUpDwSelLength[phase].Name = "numericUpDown1";
            _numUpDwSelLength[phase].Size = new System.Drawing.Size(100, 20);
            _numUpDwSelLength[phase].TabIndex = 0;
            _numUpDwSelLength[phase].Minimum = 1;
        }

        private void ShowLblNamePhase(int phase)
        {
            _LblNamePhase[phase].AutoSize = true;
            _LblNamePhase[phase].Location = new System.Drawing.Point(6, 19);
            _LblNamePhase[phase].Name = "label6";
            _LblNamePhase[phase].Size = new System.Drawing.Size(61, 13);
            _LblNamePhase[phase].TabIndex = 53;
            _LblNamePhase[phase].Text = "Nome Fase:";
        }

        private void ShowTxtBoxNamePhase(int phase)
        {
            _TxtBoxNamePhase[phase].Location = new System.Drawing.Point(70, 16);
            _TxtBoxNamePhase[phase].Name = "txtBoxNamePhase";
            _TxtBoxNamePhase[phase].Size = new System.Drawing.Size(200, 20);
            _TxtBoxNamePhase[phase].TabIndex = 52;
            _TxtBoxNamePhase[phase].Enabled = false;
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

        private void cmbBoxSelObjType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCmbBoxSelObj();
        }

        private void SetCmbBoxSelObj()
        {
            SaveCmbBoxSelIndex();
            int phase = tabControlPhases.SelectedIndex;
            for (int j = 0; j < _cmbBoxSelObj[phase].Count; j++)
            {
                _cmbBoxSelObj[phase][j].Items.Clear();
                if (_cmbBoxSelObjType[phase][j].SelectedIndex == 0) //human
                {
                    for (int i = 0; i < objsHuman.Count; i++)
                    { _cmbBoxSelObj[phase][j].Items.Add(objsHuman[i]); }
                }
                else if (_cmbBoxSelObjType[phase][j].SelectedIndex == 1) //notHuman
                {
                    for (int i = 0; i < objsNotHuman.Count; i++)
                    { _cmbBoxSelObj[phase][j].Items.Add(objsNotHuman[i]); }
                }
            }
            ApplyCmbBoxSelIndex();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbBoxSelProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            productID = production.GetRowID(cmbBoxSelProd.SelectedIndex, "Products_ID", "Products");
            List<List<string>> defPhases = production.GetDefaultPhasesOneProd(productID, out edit);
            List<int> rowsInOneDefPh = production.RowsInOneDefaultPhases(productID);
            SetTabPagesAsPhases(); 
            if(edit)
            {
                EditDefaultPhases(defPhases, rowsInOneDefPh);
            }
        }

        private void EditDefaultPhases(List<List<string>> defPhases, List<int> rowsInOneDefPh)
        {
            //Objs_ID, Phases_ID, Length
            for (int phase = 0; phase < tabControlPhases.TabCount; phase++)
            {
                int countRows = rowsInOneDefPh[phase];
                for (int i = 0; i < countRows; i++)
                {
                    if (i != 0)
                    {
                        AddObj(phase);
                    }
                    int type = production.GetType(int.Parse(defPhases[phase][0]), "Objs", "Objs_ID");
                    _cmbBoxSelObjType[phase][i].SelectedIndex = type;
                    int selObj = production.GetObjAndProdRow("Objs_ID", type, "Objs", int.Parse(defPhases[phase][0]) - 1);
                    _cmbBoxSelObj[phase][i].SelectedIndex = selObj;
                }
            }
        }

        private void Save()
        {
            List<string> defaultPh;
            for (int phase = 0; phase < tabControlPhases.TabCount; phase++)
            {
                for (int i = 0; i < _cmbBoxSelObj[phase].Count; i++)
                {
                    defaultPh = new List<string>();
                    int objIdx = _cmbBoxSelObj[phase][i].SelectedIndex;
                    int objType = _cmbBoxSelObjType[phase][i].SelectedIndex;
                    int objID = production.GetObjAndProdRowID(objIdx, objType, "Objs_ID", "Objs");
                    defaultPh.Add(objID.ToString());
                    int type = production.GetType(cmbBoxSelProd.SelectedIndex, "Products");
                    int phaseID = production.GetRowID(phase, "Phases_ID", "Phases", "Type", type.ToString());
                    defaultPh.Add(phaseID.ToString());
                    defaultPh.Add(productID.ToString());
                    defaultPh.Add(_numUpDwSelLength[phase].Value.ToString());
                    production.AddDefaultPhases(defaultPh);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }
    }
}