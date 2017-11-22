using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Configuration;


namespace ProdCycleBoer
{
    public partial class FrmMain : Form
    {
        SQLiteConnection dbC;
        SQLiteCommand command;

        Production production = new Production();

        public FrmMain()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
            dbC = new SQLiteConnection(ConfigurationManager.AppSettings.Get("dbConnectionString"));
            dbC.Open();
            dbC.Close();
            ShowDaily(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            ShowWeekly(dateTimePicker1.Value.Date);
            //ShowMonthly(dateTimePicker1.Value.Date);    
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;

        }


        private void ShowDaily(string input)
        {

            dataGridView1.Rows.Clear();
            //  dbC = new SQLiteConnection(ConfigurationManager.AppSettings.Get("dbConnectionString"));

            dbC.Open();

            string sql = "SELECT Production.Order_ID as 'Order', (Real_STime || ' - ' ||Real_ETime) as 'Ora',Objs.Name as 'Lavoratore',Phases.Name as 'Fase',Orders.Name as 'Ordine', (Products.Name || ' ' || Products.Measure) as Prodotto FROM Production JOIN Products ON Orders.Products_ID = Products.Products_ID  JOIN Time ON Time.Time_ID = Production.Time_ID JOIN Objs ON Objs.Objs_ID = Production.Obj_ID JOIN Phases ON Phases.Phases_ID = Production.Phase_ID JOIN Orders ON Orders.Orders_ID = Production.Order_ID Where Production.Day_ID = @ID order by Production.Time_ID"; // cerco ID nelle tabelle e trascrivo tutto nella lista


            command = new SQLiteCommand(sql, dbC);

            command.Parameters.AddWithValue("@ID", input);

            SQLiteDataReader reader = command.ExecuteReader();

            for (int i = 0; i < reader.FieldCount; i++) //hide ID
            {
                dataGridView1.Columns[i].HeaderText = reader.GetName(i);
            }

            while (reader.Read()) // scrivo gli ID dentro ad una lista
            {
                dataGridView1.Rows.Add(reader["Order"],reader["Ora"], reader["Lavoratore"], reader["Fase"], reader["Ordine"], reader["Prodotto"]);
                Refresh();
            }
            dbC.Close();
        }

        private void ShowWeekly(DateTime input)
        {

            dataGridView3.Rows.Clear();

            //  dbC = new SQLiteConnection(ConfigurationManager.AppSettings.Get("dbConnectionString"));

            dbC.Open();

            string sql = "Select (Select Orders.Name From Production  Join Orders ON Orders.Orders_ID = Production.Order_ID  Where strftime('%W', @ID) = strftime('%W', Day_ID) and strftime('%w',Day_ID) = '1') As Lunedi, (Select Orders.Name From Production  Join Orders ON Orders.Orders_ID = Production.Order_ID  Where strftime('%W', @ID) = strftime('%W', Day_ID) and strftime('%w',Day_ID) = '2') As Martedi,(Select Orders.Name From Production  Join Orders ON Orders.Orders_ID = Production.Order_ID  Where strftime('%W', @ID) = strftime('%W', Day_ID) and strftime('%w',Day_ID) = '3') As Mercoledi ,(Select Orders.Name From Production  Join Orders ON Orders.Orders_ID = Production.Order_ID  Where strftime('%W', @ID) = strftime('%W', Day_ID) and strftime('%w',Day_ID) = '4') As Giovedi ,(Select Orders.Name From Production  Join Orders ON Orders.Orders_ID = Production.Order_ID  Where strftime('%W', @ID) = strftime('%W', Day_ID) and strftime('%w',Day_ID) = '5') As Venerdi, (Select Orders.Name From Production  Join Orders ON Orders.Orders_ID = Production.Order_ID  Where strftime('%W', @ID) = strftime('%W', Day_ID) and strftime('%w',Day_ID) = '6') As Sabato ,(Select Orders.Name From Production  Join Orders ON Orders.Orders_ID = Production.Order_ID  Where strftime('%W', @ID) = strftime('%W', Day_ID) and strftime('%w',Day_ID) = '0') As Domenica";

            command = new SQLiteCommand(sql, dbC);

            command.Parameters.AddWithValue("@ID", input.ToString("yyyy-MM-dd"));

            SQLiteDataReader reader = command.ExecuteReader();

            for (int i = 0; i < reader.FieldCount - 1; i++) //hide ID
            {
                dataGridView3.Columns[i].HeaderText = reader.GetName(i);
            }

            while (reader.Read())
            {
                dataGridView3.Rows.Add(reader["Lunedi"], reader["Martedi"], reader["Mercoledi"], reader["Giovedi"], reader["Venerdi"], reader["Sabato"], reader["Domenica"]);
                Refresh();
            }
            dbC.Close();

        }

        private void ShowMonthly(DateTime input)
        {
            dataGridView4.Rows.Clear();
            //  dbC = new SQLiteConnection(ConfigurationManager.AppSettings.Get("dbConnectionString"));

            dbC.Open();

            string sql = "SELECT * FROM Production Where strftime('%m',@ID) = strftime('%m',Day_ID) order by Time_ID";

            command = new SQLiteCommand(sql, dbC);

            command.Parameters.AddWithValue("@ID", input);

            SQLiteDataReader reader = command.ExecuteReader();

            for (int i = 0; i < reader.FieldCount - 1; i++) //hide ID
            {
                dataGridView4.Columns[i].HeaderText = reader.GetName(i + 1);
            }

            while (reader.Read())
            {
                dataGridView4.Rows.Add(reader["Time_ID"], reader["Obj_ID"], reader["Phase_ID"], reader["Order_ID"]);
                Refresh();
            }
            dbC.Close();

        }


        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<int> prodType = new List<int>();
            List<string> prod = production.GetProducts(out prodType);
            List<int> objType = new List<int>();
            List<string> obj = production.GetObjs(out objType);
            int countOrd = production.CountRows("Orders");
            FrmNewOrd frm = new FrmNewOrd(prod, prodType, obj, objType, true, countOrd + 1);
            frm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Form3 frm = new Form3();
            // frm.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {



            // this.reportViewer1.RefreshReport();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView3.Visible = false;
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView1.Visible = true;
                dataGridView3.Visible = false;
                dataGridView4.Visible = false;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                dataGridView1.Visible = false;
                dataGridView3.Visible = true;
                dataGridView4.Visible = true;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                dataGridView3.Visible = false;
                dataGridView4.Visible = true;
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView4.Visible = false;
            dataGridView3.Visible = true;

            comboBox1.SelectedIndex = 1;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dbC.Close();
            ShowDaily(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            ShowWeekly(dateTimePicker1.Value.Date);
            //ShowMonthly(dateTimePicker1.Value.Date);         


        }

        private void btnAddObj_Click(object sender, EventArgs e)
        {

        }

        private void nuovoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ordineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int lastOrd = production.GetLastRowID("Orders_ID", "Orders");
            FormProduction(true, lastOrd + 1);
        }

        private void FormProduction(bool newOrd, int orderID)
        {
            List<int> prodType = new List<int>();
            List<string> prod = production.GetProducts(out prodType);
            List<int> objType = new List<int>();
            List<string> obj = production.GetObjs(out objType);
            FrmNewOrd frm = new FrmNewOrd(prod, prodType, obj, objType, newOrd, orderID);
            frm.Show();
            ShowDaily(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
        }

        private void prodottoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduct frm1 = new FrmProduct();
            frm1.ShowDialog();
            if (frm1.DialogResult == DialogResult.OK)
            {
                production.AddProduct(frm1.newObject);
            }
        }

        private void lavoratoreMacchinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddObj frm = new FrmAddObj();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                production.AddObject(frm.newObject); //write database
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string orderID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            FormProduction(false, int.Parse(orderID));
        }

        // private void tickmanager
    }
}
