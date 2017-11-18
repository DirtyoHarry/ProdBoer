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


            dbC = new SQLiteConnection(ConfigurationManager.AppSettings.Get("dbConnectionString"));
            dbC.Open();

            dataGridView3.Visible = false;
            dataGridView4.Visible = false;

            Color colGreen = System.Drawing.ColorTranslator.FromHtml("#CCFF90");
            Color colYellow = System.Drawing.ColorTranslator.FromHtml("#FFFF8D");
            Color colRed = System.Drawing.ColorTranslator.FromHtml("#FF9E80");

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 100;
            chart1.Series[0].Points.AddY(50);
            chart1.Series[0].Points.AddY(30);
            chart1.Series[0].Points.AddY(20);
            chart1.Series[0].Points[0].LegendText = "Giornata parzialmente piena";
            chart1.Series[0].Points[1].LegendText = "Giornata piena";
            chart1.Series[0].Points[2].LegendText = "Giornata vuota";
            chart1.Series[0].Points[0].Color = colYellow;
            chart1.Series[0].Points[1].Color = colRed;
            chart1.Series[0].Points[2].Color = colGreen;

            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;


            DataGridViewCellStyle empty = new DataGridViewCellStyle();
            empty.BackColor = Color.White;

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.IndianRed;
            style.ForeColor = Color.Black;

            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            style2.BackColor = Color.Yellow;
            style2.ForeColor = Color.Black;

            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            style3.BackColor = Color.LightGreen;
            style3.ForeColor = Color.Black;

            dataGridView3.Rows.Add("Cliente1", "Cliente1", "Cliente1", "Cliente1", "Cliente1" );
            dataGridView3.Rows.Add("Cliente2", "Cliente2", "Cliente2", "Cliente2", "Cliente2");

            dataGridView3.Rows[0].Cells[0].Style = style;
            dataGridView3.Rows[1].Cells[0].Style = style;
            dataGridView3.Rows[0].Cells[1].Style = style2;
            dataGridView3.Rows[1].Cells[1].Style = style2;
            dataGridView3.Rows[0].Cells[2].Style = style2;
            dataGridView3.Rows[1].Cells[2].Style = style2;
            dataGridView3.Rows[0].Cells[3].Style = style2;
            dataGridView3.Rows[1].Cells[3].Style = style2;
            dataGridView3.Rows[0].Cells[4].Style = style2;
            dataGridView3.Rows[1].Cells[4].Style = style2;
            dataGridView3.Rows[0].Cells[5].Style = style3;
            dataGridView3.Rows[1].Cells[5].Style = style3;

            dataGridView4.Rows.Add("Lunedi");
            dataGridView4.Rows.Add("Martedi");
            dataGridView4.Rows.Add("Mercoledi");
            dataGridView4.Rows.Add("Giovedi");
            dataGridView4.Rows.Add("Venerdi");
            dataGridView4.Rows.Add("Sabato");

            dataGridView4.Rows[0].DefaultCellStyle = style;
            dataGridView4.Rows[1].DefaultCellStyle = style2;
            dataGridView4.Rows[2].DefaultCellStyle = style2;
            dataGridView4.Rows[3].DefaultCellStyle = style2;
            dataGridView4.Rows[4].DefaultCellStyle = style3;
            dataGridView4.Rows[5].DefaultCellStyle = style3;

            dataGridView4.Rows[0].Cells[0].Style = empty;
            dataGridView4.Rows[1].Cells[0].Style = empty;
            dataGridView4.Rows[2].Cells[0].Style = empty;
            dataGridView4.Rows[3].Cells[0].Style = empty;
            dataGridView4.Rows[4].Cells[0].Style = empty;
            dataGridView4.Rows[5].Cells[0].Style = empty;
        }


        private void ShowDaily(long input)
        {
            dataGridView1.Rows.Clear();
            //  dbC = new SQLiteConnection(ConfigurationManager.AppSettings.Get("dbConnectionString"));

            dbC.Open();

            string sql = "SELECT * FROM Production Where Day_ID = @ID order by Time_ID";
           
            command = new SQLiteCommand(sql, dbC);

            command.Parameters.AddWithValue("@ID", input);

            SQLiteDataReader reader = command.ExecuteReader();

            for (int i = 0; i < reader.FieldCount-1; i++) //hide ID
            {
                dataGridView1.Columns[i].HeaderText = reader.GetName(i+1);
            }

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["Time_ID"], reader["Obj_ID"], reader["Phase_ID"], reader["Order_ID"]);
                Refresh();
            }
            dbC.Close();

        }

        private void ShowWeekly(DateTime input)
        {
            
            dataGridView2.Rows.Clear();
            
            //  dbC = new SQLiteConnection(ConfigurationManager.AppSettings.Get("dbConnectionString"));

             dbC.Open();

            string sql = "SELECT * FROM Production Where strftime('%W', @ID) = strftime('%W', Day_ID) order by Time_ID";

            command = new SQLiteCommand(sql, dbC);

            command.Parameters.AddWithValue("@ID", input.Day);

            SQLiteDataReader reader = command.ExecuteReader();

            for (int i = 0; i < reader.FieldCount - 1; i++) //hide ID
            {
                dataGridView2.Columns[i].HeaderText = reader.GetName(i + 1);
            }

            while (reader.Read())
            {
                dataGridView2.Rows.Add(reader["Time_ID"], reader["Obj_ID"], reader["Phase_ID"], reader["Order_ID"]);
                Refresh();
            }
            dbC.Close();

        }

        private void ShowMonthly(DateTime input)
        {
            dataGridView3.Rows.Clear();
            //  dbC = new SQLiteConnection(ConfigurationManager.AppSettings.Get("dbConnectionString"));

            dbC.Open();

            string sql = "SELECT * FROM Production Where strftime('%m',@ID) = strftime('%m',Day_ID) order by Time_ID";

            command = new SQLiteCommand(sql, dbC);

            command.Parameters.AddWithValue("@ID", input);

            SQLiteDataReader reader = command.ExecuteReader();

            for (int i = 0; i < reader.FieldCount - 1; i++) //hide ID
            {
                dataGridView3.Columns[i].HeaderText = reader.GetName(i + 1);
            }

            while (reader.Read())
            {
                dataGridView3.Rows.Add(reader["Time_ID"], reader["Obj_ID"], reader["Phase_ID"], reader["Order_ID"]);
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
            FrmNewOrd frm = new FrmNewOrd(prod, prodType, obj, objType);
            DialogResult dr = frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Form3 frm = new Form3();
           // frm.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            List<string> a = new List<string>();

            a.Add("1");
            a.Add("2");
            a.Add("3");
            a.Add("4");
            a.Add("5");
            a.Add("6");
            a.Add("7");
            a.Add("8");
            a.Add("8");
            a.Add("8");
            a.Add("9");
            a.Add("10");

            Label1.Text = production.EditOrder(a).ToString();

            dataGridView1.Rows.Add("13:30", "johnny", "banco vib 1", "banco vibrante", "pozzetto XYZ");
            dataGridView1.Rows.Add("13:30", "marco", "impastatrice", "impastatura", "coperchi ABC");
            dataGridView1.Rows.Add("13:30", "matteo", "svuotatore", "svuotatura", "OPQ XYZ");

            dataGridView2.Rows.Add("08:00", "stefano", "carroponte", "pulizia stampi", "vasca circolare A1");
            dataGridView2.Rows.Add("08:00", "riccardo", "carroponte", "armo e getto", "vasca circolare A1");
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
                dataGridView3.Visible = false;
                dataGridView4.Visible = false;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                dataGridView3.Visible = true;
                dataGridView4.Visible = false;
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
            ShowDaily(dateTimePicker1.Value.Date.Ticks);
            ShowWeekly(dateTimePicker1.Value.Date);
            ShowMonthly(dateTimePicker1.Value.Date);         
                  

        }

        private void btnAddObj_Click(object sender, EventArgs e)
        {
            FrmAddObj frm = new FrmAddObj();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                production.AddObject(frm.newObject); //write database
            }
        }

        // private void tickmanager
    }
}
