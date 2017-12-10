using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

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

        List<List<ComboBox>> _cmbBoxSelObjType;
        List<ComboBox> _cmbBoxSelObjTypePhaseX;
        List<List<ComboBox>> _cmbBoxSelObj;
        List<ComboBox> _cmbBoxSelObjPhaseX;
        List<List<Label>> _lblFrom;
        List<Label> _lblFromPhaseX;
        List<List<DateTimePicker>> _dateTimePickerFrom;
        List<DateTimePicker> _dateTimePickerFromPhaseX;
        List<List<Label>> _lblTo;
        List<Label> _lblToPhaseX;
        List<List<DateTimePicker>> _dateTimePickerTo;
        List<DateTimePicker> _dateTimePickerToPhaseX;
        List<List<int>> _cmbBoxSelObjTypeSelInd; //salva selected index
        List<int> _cmbBoxSelObjTypeSelIndPhaseX;
        List<List<int>> _cmbBoxSelObjSelInd; //salva selected index       
        List<int> _cmbBoxSelObjSelIndPhaseX;

        List<Label> _LblNamePhase;
        List<TextBox> _TxtBoxNamePhase;
        List<Label> _lblObjUsed;
        List<Button> _btnAddPhase;
        List<Button> _btnRemPhase;
        List<Button> _BtnAddObj;
        List<Button> _BtnRemoveObj;

        List<string> productsExt;
        List<string> productsInt;
        List<string> objsHuman;
        List<string> objsNotHuman;

        int orderID = -1;
        bool newOrder = true;

        Production production;

        public FrmNewOrd(List<string> _products, List<int> _prodType, List<string> _objs, List<int> _objsType, bool newOrd, int ordID)
        {
            InitializeComponent();
            production = new Production();
            SetProdObjLists(_products, _prodType, _objs, _objsType);
            numUpDownNOrd.Maximum = ordID - 1;
            numUpDownNOrd.Enabled = newOrd;
            orderID = ordID;
            newOrder = newOrd;
            StartForm();
        }

        private void FrmProd_Load(object sender, EventArgs e)
        {
            if (!newOrder)
            {
                lblChangeProd.Text = "Modifica Ordine #" + orderID;
                cmbBoxNameProd.Enabled = cmbBoxSelProd.Enabled = false;
            }
            else
            { lblChangeProd.Text = "Nuovo Ordine #" + orderID; }
        }

        private void StartForm()
        {
            InitializeObjList();
            AddPhase();
            ShowAllPhases();
        }


        private void FrmNewOrd_Shown(object sender, EventArgs e)
        {
            if (!newOrder)
            {
                EditOrder();
            }

        }

        private void EditOrder()
        {
            ShowOrder();
            ShowProduction();
        }

        private void ShowOrder()
        {
            //Name, Type, Starting_Date, Expiring_Date, Barcode, Ext_Code, Phase_ID, Products_ID, Notes, Number
            List<string> order = new List<string>();
            order = production.SelectWithWhereOrders("Orders_ID", orderID.ToString());
            txtBoxNameOrd.Text = order[0];
            cmbBoxSelProd.SelectedIndex = int.Parse(order[1]);
            dateTmPickSD.Value = DateTime.ParseExact(order[2], "yyyy/dd/MM", System.Globalization.CultureInfo.InvariantCulture);
            dateTmPickED.Value = DateTime.ParseExact(order[3], "yyyy/dd/MM", System.Globalization.CultureInfo.InvariantCulture);
            txtBoxCodProd.Text = order[4];
            txtBoxCodComm.Text = order[5];
            string actualPhase = order[6];
            int selProd = production.GetObjAndProdRow("Products_ID", int.Parse(order[1]), "Products", int.Parse(order[7])) - 1;
            cmbBoxNameProd.SelectedIndex = selProd;
            txtBoxNotes.Text = order[8];
            numUpDownNOrd.Maximum = int.Parse(order[9]);
            numUpDownNOrd.Value = int.Parse(order[9]);
        }

        private void ShowProduction()
        {
            /*
             prod[x][0] = Time_ID
             prod[x][1] = Obj_ID
             prod[x][2] = Phase_ID
             prod[x][3] = strftime('%Y/%d/%m', Day_ID)            
             */
            List<List<string>> prodShort = new List<List<string>>();
            int nOfPhases = production.GetNOfPhasesInProd(orderID);
            for (int phase = 0; phase < nOfPhases; phase++)
            {
                if (phase != 0)
                { AddPhaseMain(true); }
                prodShort = production.GetProductionGroupBy(orderID, phase + 1);
                int objPerPhase = production.GetNOfObjsInProd(orderID, phase + 1);
                for (int k = 0; k < objPerPhase; k++)
                {
                    int objID = int.Parse(prodShort[k][1]);
                    if (k != 0)
                    { AddObj(); }
                    int type = production.GetType(objID, "Objs", "Objs_ID");
                    _cmbBoxSelObjType[phase][k].SelectedIndex = type;
                    int selObj = production.GetObjAndProdRow("Objs_ID", type, "Objs", int.Parse(prodShort[k][1]) - 1);
                    _cmbBoxSelObj[phase][k].SelectedIndex = selObj;
                    List<string> dateTime = new List<string>();
                    dateTime = production.GetStartingAndEndingDateTime(orderID, phase + 1, objID);
                    string a = dateTime[0];
                    string b = dateTime[1];
                    string c = dateTime[2];
                    string d = dateTime[3];
                    string sdtHour = production.SelectWithWhereOneRow("Real_STime", "Time", "Time_ID", dateTime[0].ToString());
                    string edtHour = production.SelectWithWhereOneRow("Real_STime", "Time", "Time_ID", dateTime[2].ToString());
                    sdtHour = String.Format("{0:HH:mm}", DateTime.Parse(sdtHour));  //fix 8:00 to 08:00     
                    edtHour = String.Format("{0:HH:mm}", DateTime.Parse(edtHour));  //fix 8:00 to 08:00 
                    DateTime sdt = DateTime.ParseExact(dateTime[1] + " " + sdtHour, "yyyy/dd/MM HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                    DateTime edt = DateTime.ParseExact(dateTime[3] + " " + edtHour, "yyyy/dd/MM HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                    _dateTimePickerFrom[phase][k].Value = sdt;
                    _dateTimePickerTo[phase][k].Value = edt;
                }
            }
            tabControlPhases.SelectedIndex = 0;
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

        private void SetCmbBoxNameProd()
        {
            cmbBoxNameProd.Items.Clear();
            if (cmbBoxSelProd.SelectedIndex == 1)//interna
            {
                for (int i = 0; i < productsInt.Count; i++)
                { cmbBoxNameProd.Items.Add(productsInt[i]); }
            }
            else //esterna
            {
                for (int i = 0; i < productsExt.Count; i++)
                { cmbBoxNameProd.Items.Add(productsExt[i]); }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> error = new List<string>();
            List<string> order = SaveOrder(error);
            List<List<string>> productions = new List<List<string>>();
            for (int i = 0; i < tabControlPhases.TabCount; i++)
            {
                for (int j = 0; j < _cmbBoxSelObj[i].Count; j++)
                { SaveProduction(i, j, error, productions); }
            }
            if (newOrder)
            {
                if (error.Count == 0)
                { production.AddOrder(order); }
            }
            else
            {
                if (error.Count == 0)
                { 
                    production.EditOrder(order);
                    //cancel all rows of that order in production
                    production.RemoveRowsFromDB("Production", "Order_ID", orderID);
                }
            }
            if (error.Count == 0)
            {
                for (int i = 0; i < productions.Count; i++)
                { production.AddProduction(productions[i]); }
            }
            string title = "Stato Avanzamento Salvataggio Ordine", text = "";
            if (error.Count == 0)
            { text = "Salvataggio completato con successo"; }
            else
            {
                text = "Non è stato possibile salvare l'ordine. " + Environment.NewLine;
                text = text + "Prima di riprovare a salvare sistemare i seguenti errori:" + Environment.NewLine;
                for (int i = 0; i < error.Count; i++)
                { text = text + (i + 1) + ") " + error[i] + Environment.NewLine; }
            }
            MessageBox.Show(text, title);
            if (error.Count == 0)
            { Close(); }
        }

        private void SaveProduction(int ph, int idx, List<string> error, List<List<string>> productions)
        {
            //Time_ID, Obj_ID, Order_ID, Phase_ID, Day_ID
            DateTime startingProd = DateTime.Parse(String.Format("{0:dd/MM/yyyy HH:mm}", _dateTimePickerFrom[ph][idx].Value));
            DateTime endingProd = DateTime.Parse(String.Format("{0:dd/MM/yyyy HH:mm}", _dateTimePickerTo[ph][idx].Value));
            TimeSpan ts = _dateTimePickerTo[ph][idx].Value - _dateTimePickerFrom[ph][idx].Value;
            if (endingProd <= startingProd)
            { error.Add("Per il lavoratore/macchinario nella fase " + (ph + 1) + " n. " + (idx + 1) + " l'orario di fine del lavoro NON è successivo alla data di inizio"); }
            int totTime = (Int16)(Math.Round(ts.TotalHours * 2));
            int restart = 1;
            string hour = _dateTimePickerFrom[ph][idx].Value.ToString();
            if (_dateTimePickerFrom[ph][idx].Value <= Convert.ToDateTime("09:30")) //08.00 --> 8.00
            { hour = String.Format("{0:H:mm}", _dateTimePickerFrom[ph][idx].Value); }
            else
            { hour = String.Format("{0:HH:mm}", _dateTimePickerFrom[ph][idx].Value); }
            string dtpTimeID = production.SelectWithWhereOneRow("Time_ID", "Time", "Real_STime", hour);
            //Obj_ID
            int objIdx = _cmbBoxSelObj[ph][idx].SelectedIndex;
            int objType = _cmbBoxSelObjType[ph][idx].SelectedIndex;
            int objID = production.GetObjAndProdRowID(objIdx, objType, "Objs_ID", "Objs");
            if (objID == -1)
            { error.Add("NON è stato selezionato nessun lavoratore/macchinario nella fase " + (ph + 1) + " n. " + (idx + 1)); }
            for (int i = 0; i < totTime; i++) //si ripete per le ore di ogni azione
            {
                int cnt = productions.Count;
                List<string> temporary = new List<string>();
                productions.Add(temporary);
                productions[cnt] = new List<string>();
                //Time_ID
                string timeID = dtpTimeID;
                timeID = (int.Parse(timeID) + i).ToString();
                int inputTime = int.Parse(timeID);
                if (inputTime > 48) //il 48 sarebbe il time_ID delle 7.30
                {
                    inputTime = restart;
                    restart++;
                }
                if (inputTime < 20 && inputTime != 10 && inputTime != 11) //solo ore lavorative
                {
                    productions[cnt].Add(inputTime.ToString());
                    productions[cnt].Add(objID.ToString());
                    //Order_ID
                    productions[cnt].Add(orderID.ToString());
                    //Phase_ID
                    productions[cnt].Add((ph + 1).ToString());
                    //Day_ID
                    string dayID = String.Format("{0:yyyy-MM-dd}", _dateTimePickerFrom[ph][idx].Value);
                    string inputDay = dayID;
                    if (restart > 1)
                    { inputDay = String.Format("{0:yyyy-MM-dd}", _dateTimePickerTo[ph][idx].Value); }
                    productions[cnt].Add(inputDay);
                }
                else
                { productions.RemoveAt(productions.Count - 1); }
            }
        }

        private List<string> SaveOrder(List<string> error)
        {
            //Name, Type, Starting_Date, Expiring_Date, Barcode, Ext_Code, Phase_ID, Products_ID, Notes
            List<string> saveOrd = new List<string>();
            int type = cmbBoxSelProd.SelectedIndex;
            int productID = production.GetObjAndProdRowID(cmbBoxNameProd.SelectedIndex, type, "Products_ID", "Products");
            if (dateTmPickED.Value <= dateTmPickSD.Value)
            { error.Add("La data di scadenza NON è successiva alla data di inserimento dell'ordine"); }
            if (productID == -1)
            { error.Add("NON è stato selezionato nessun prodotto da produrre"); }
            saveOrd.Add(orderID.ToString());
            saveOrd.Add(txtBoxNameOrd.Text);
            saveOrd.Add(type.ToString());
            saveOrd.Add(String.Format("{0:yyyy-MM-dd}", dateTmPickSD.Value));
            saveOrd.Add(String.Format("{0:yyyy-MM-dd}", dateTmPickED.Value));
            saveOrd.Add(txtBoxCodProd.Text);
            saveOrd.Add(txtBoxCodComm.Text);
            saveOrd.Add("1");
            saveOrd.Add(productID.ToString());
            saveOrd.Add(txtBoxNotes.Text);
            saveOrd.Add(numUpDownNOrd.Value.ToString());
            return saveOrd;
        }

        private void InitializeObjList()
        {
            //inizializza gli oggetti --> fa le new
            _cmbBoxSelObjType = new List<List<ComboBox>>(); //lista matrice principale
            _cmbBoxSelObj = new List<List<ComboBox>>(); //lista matrice principale  
            _lblFrom = new List<List<Label>>(); //lista matrice principale
            _dateTimePickerFrom = new List<List<DateTimePicker>>(); //lista matrice principale 
            _lblTo = new List<List<Label>>(); //lista matrice principale
            _dateTimePickerTo = new List<List<DateTimePicker>>(); //lista matrice principale
            _cmbBoxSelObjTypeSelInd = new List<List<int>>(); //salva selected index
            _cmbBoxSelObjSelInd = new List<List<int>>();//salva selected index    

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
            _cmbBoxSelObjTypePhaseX = new List<ComboBox>();
            _cmbBoxSelObjType.Add(_cmbBoxSelObjTypePhaseX);
            _cmbBoxSelObjPhaseX = new List<ComboBox>();
            _cmbBoxSelObj.Add(_cmbBoxSelObjPhaseX);
            _lblFromPhaseX = new List<Label>();
            _lblFrom.Add(_lblFromPhaseX);
            _dateTimePickerFromPhaseX = new List<DateTimePicker>();
            _dateTimePickerFrom.Add(_dateTimePickerFromPhaseX);
            _lblToPhaseX = new List<Label>();
            _lblTo.Add(_lblToPhaseX);
            _dateTimePickerToPhaseX = new List<DateTimePicker>();
            _dateTimePickerTo.Add(_dateTimePickerToPhaseX);
            _cmbBoxSelObjTypeSelIndPhaseX = new List<int>();
            _cmbBoxSelObjTypeSelInd.Add(_cmbBoxSelObjTypeSelIndPhaseX); //salva selected index
            _cmbBoxSelObjSelIndPhaseX = new List<int>();
            _cmbBoxSelObjSelInd.Add(_cmbBoxSelObjSelIndPhaseX);  //salva selected index    
        }

        private void btnAddObj_Click(object sender, EventArgs e)
        {
            AddObj();
        }

        private void AddObj()
        {
            int phase = tabControlPhases.SelectedIndex;
            int count = _dateTimePickerFrom[phase].Count;
            SaveCmbBoxSelIndex();
            AddObject(phase);
            ShowOnePhase(phase);
            if (_dateTimePickerFrom[phase].Count > 1)
            {
                int cntObjs = _dateTimePickerFrom[phase].Count - 1;
                _dateTimePickerFrom[phase][cntObjs].Value = _dateTimePickerFrom[phase][cntObjs-1].Value;
                _dateTimePickerTo[phase][cntObjs].Value = _dateTimePickerTo[phase][cntObjs-1].Value;
            }
        }

        private void AddObject(int phase)
        {
            //aggiungi nuovo lavoratore o macchinario
            DateTimePicker dateTimePickerTemp = new DateTimePicker();
            Label lblTemp = new Label();
            ComboBox cmbBoxTemp = new ComboBox();
            TextBox txtBoxTemp = new TextBox();

            _cmbBoxSelObjType[phase].Add(cmbBoxTemp);
            cmbBoxTemp = new ComboBox();
            _cmbBoxSelObj[phase].Add(cmbBoxTemp);
            _lblFrom[phase].Add(lblTemp);
            _dateTimePickerFrom[phase].Add(dateTimePickerTemp);
            lblTemp = new Label();
            _lblTo[phase].Add(lblTemp);
            dateTimePickerTemp = new DateTimePicker();
            _dateTimePickerTo[phase].Add(dateTimePickerTemp);
            _cmbBoxSelObjTypeSelInd[phase].Add(-1);
            _cmbBoxSelObjSelInd[phase].Add(-1);
        }

        private void btnRemObj_Click(object sender, EventArgs e)
        {
            int phase = tabControlPhases.SelectedIndex;
            int index = _dateTimePickerTo[phase].Count - 1;
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
                _cmbBoxSelObj[phase].RemoveAt(index);
                _cmbBoxSelObjType[phase].RemoveAt(index);
                _cmbBoxSelObjTypeSelInd[phase].RemoveAt(index); //salva selected index
                _cmbBoxSelObjSelInd[phase].RemoveAt(index); //salva selected index 
            }
        }

        private void btnAddPhase_Click(object sender, EventArgs e)
        {
            AddPhaseMain(true);
            SetTxtBoxNamePhaseText();
        }

        private void AddPhaseMain(bool showPh)
        {
            AddPhase();
            int phase = tabControlPhases.TabCount;
            AddTabPage(phase);
            if (showPh)
            { ShowOnePhase(phase); }
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
            _cmbBoxSelObjPhaseX.Add(cmbBoxTemp);
            cmbBoxTemp = new ComboBox();
            _cmbBoxSelObjTypePhaseX.Add(cmbBoxTemp);
            _cmbBoxSelObjTypeSelIndPhaseX.Add(-1);
            _cmbBoxSelObjSelIndPhaseX.Add(-1);

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
            RemovePhaseMain(false);
            SetTxtBoxNamePhaseText();
        }

        private void RemovePhaseMain(bool deleteFirstTP)
        {
            int phase = tabControlPhases.SelectedIndex;
            RemovePhase(phase, deleteFirstTP);
            ShowAllPhases();
            tabControlPhases.SelectedIndex = phase;
        }

        private void RemovePhase(int phase, bool deleteFirstTP)
        {
            //rimuovi la fase selezionata
            if ((nOfTabPages > 1 && !deleteFirstTP) || deleteFirstTP)
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
                _cmbBoxSelObj[phase][j] = _cmbBoxSelObj[phase + 1][j];
                _cmbBoxSelObjType[phase][j] = _cmbBoxSelObjType[phase + 1][j];
                _cmbBoxSelObjTypeSelInd[phase][j] = _cmbBoxSelObjTypeSelInd[phase + 1][j]; //salva selected index 
                _cmbBoxSelObjSelInd[phase][j] = _cmbBoxSelObjSelInd[phase + 1][j]; //salva selected index

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
            _cmbBoxSelObj.RemoveAt(phase);
            _cmbBoxSelObjType.RemoveAt(phase);
            _LblNamePhase.RemoveAt(phase);
            _TxtBoxNamePhase.RemoveAt(phase);
            _btnAddPhase.RemoveAt(phase);
            _btnRemPhase.RemoveAt(phase);
            _cmbBoxSelObjTypeSelInd.RemoveAt(phase);
            _cmbBoxSelObjSelInd.RemoveAt(phase);
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
                tabControlPhases.TabPages[phase].Controls.Add(_cmbBoxSelObj[phase][i]);
                tabControlPhases.TabPages[phase].Controls.Add(_cmbBoxSelObjType[phase][i]);
            }

            ShowBtnAddObj(phase);
            ShowBtnRemoveObj(phase);
            ShowLblObjUsed(phase);
            ShowLblNamePhase(phase);
            ShowTxtBoxNamePhase(phase);
            ShowBtnAddPhase(phase);
            ShowBtnRemovePhase(phase);

            ShowCmbBoxSelObjType(phase, _cmbBoxSelObjTypeSelInd[phase]);
            ShowCmbBoxSelObj(phase, _cmbBoxSelObjSelInd[phase]);
            ShowLabelFrom(phase);
            ShowDateTimePickerFrom(phase);
            ShowLabelTo(phase);
            ShowDateTimePickerTo(phase);
            RoundDateTimePicker(phase);
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
            tabControlPhases.Location = new System.Drawing.Point(10, 140);
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
                DateTimePicker dtp = new DateTimePicker();
                dtp = _dateTimePickerTo[phase][j];
                dtp.Leave += new System.EventHandler(dateTimePickerTo_Leave);
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
                DateTimePicker dtp = new DateTimePicker();
                dtp = _dateTimePickerFrom[phase][j];
                dtp.Leave += new System.EventHandler(dateTimePickerFrom_Leave);
                y1 = y1 + dy;
            }
            x1 = x1 + dx + _dateTimePickerFrom[phase][0].Size.Width;
        }

        private void ShowLabelTo(int phase)
        {
            y1 = y + 2;
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
            y1 = y + 2;
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
            _TxtBoxNamePhase[phase].Enabled = false;
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

        private void cmbBoxSelProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxCodComm.Enabled = cmbBoxSelProd.SelectedIndex == 0;
            if (cmbBoxSelProd.SelectedIndex == 1)
            { txtBoxCodComm.Text = ""; }
            SetCmbBoxNameProd();
        }

        private void dateTimePickerTo_Leave(object sender, EventArgs e)
        {
            RoundDateTimePicker(tabControlPhases.SelectedIndex);
        }

        private void dateTimePickerFrom_Leave(object sender, EventArgs e)
        {
            RoundDateTimePicker(tabControlPhases.SelectedIndex);
        }

        private void RoundDateTimePicker(int phase)
        {
            for (int j = 0; j < _dateTimePickerTo[phase].Count; j++)
            {
                RoundDownMinutes(_dateTimePickerTo[phase][j], phase, 30);
                RoundDownMinutes(_dateTimePickerFrom[phase][j], phase, 30);
            }
        }

        private void RoundDownMinutes(DateTimePicker dtp, int phase, int round)
        {
            int x = dtp.Value.Minute;
            x = -1 * (x % round);
            DateTime dt = dtp.Value.AddMinutes(x);
            dtp.Value = dt;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string title = "Annulla";
            string question = "Sei sicuro di voler annullare? Le modifiche non verranno salvate";
            DialogResult dialogResult = MessageBox.Show(question, title, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            { Close(); }
        }

        private void lblChangeProd_Click(object sender, EventArgs e)
        {

        }

        private void cmbBoxNameProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int productID = production.GetObjAndProdRowID(cmbBoxNameProd.SelectedIndex, cmbBoxSelProd.SelectedIndex, "Products_ID", "Products");
            LoadDefaultPhases(productID);
            SetTxtBoxNamePhaseText();
        }

        private void SetTxtBoxNamePhaseText()
        {
            int type = cmbBoxSelProd.SelectedIndex;
            List<string> namePh = production.SelectWithWhereList("Name", "Phases", "Type", type.ToString());
            for (int i = 0; i < tabControlPhases.TabCount; i++)
            {
                if (namePh.Count > i)
                {
                    string x = _TxtBoxNamePhase[i].Text = namePh[i];
                }
            }
        }
        
        private void LoadDefaultPhases(int productID)
        {
            List<List<string>> defPhases = production.GetDefaultPhasesOneProd(productID, out bool existDefPh);
            string question = "";
            string title = "";
            //Objs_ID, Phases_ID, Length
            if (existDefPh && newOrder)
            {
                question = "Caricare le fasi predefinite? Verranno eliminate le azioni impostate sulla produzione impostate fin'ora.";
                title = "Caricamento Fasi Predefinite";
            }
            else if (!existDefPh && tabControlPhases.TabCount>1 && newOrder)
            {
                question = "Non esistono fasi predefinite per questo prodotto. Per crearle andare su File>Nuovo>Fasi Predefinite. Resettare le azioni impostate fino ad adesso?";
                title = "Modificare azioni preparate";
            }
            DialogResult dialogResult = new DialogResult();
            if (question != "")
            {
                dialogResult = MessageBox.Show(question, title, MessageBoxButtons.YesNo);
            }
            if (dialogResult == DialogResult.Yes && existDefPh)
            {
                ShowDefaultPhases(defPhases, productID);
            }
            else if (dialogResult == DialogResult.Yes && !existDefPh)
            {
                DeleteAllPhases();
                AddPhaseMain(true);
            }
        }

        private void ShowDefaultPhases(List<List<string>> defPhases, int productID)
        {
            DeleteAllPhases();
            ShowDefaultPh(defPhases, productID);
        }

        private void DeleteAllPhases()
        {
            for (int i = 0; i < tabControlPhases.TabCount; i++)
            { RemovePhase(i, true); }
            ShowAllPhases();
        }
        
        private void ShowDefaultPh(List<List<string>> defPhases, int productID)
        {
            List<int> rowsPerPhase = production.RowsInOneDefaultPhases(productID);
            int ctPhases = int.Parse(defPhases[defPhases.Count-1][1]);
            int row = 0;
            for (int phase = 0; phase < ctPhases; phase++)
            {
                AddPhaseMain(false);
                int limit = rowsPerPhase[phase];
                for (int i = 0; i < limit; i++)
                {
                    if (i != 0)
                    { AddObj(); }
                    int type = production.GetType(int.Parse(defPhases[row][0]), "Objs", "Objs_ID");
                    _cmbBoxSelObjType[phase][i].SelectedIndex = type;
                    int selObj = production.GetObjAndProdRow("Objs_ID", type, "Objs", int.Parse(defPhases[row][0])-1);
                    int ctItems = _cmbBoxSelObj[phase][i].Items.Count;
                    _cmbBoxSelObj[phase][i].SelectedIndex = selObj;
                    row++;
                }                
            }
        }
    }
}