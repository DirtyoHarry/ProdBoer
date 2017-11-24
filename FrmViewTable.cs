using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdCycleBoer
{
    public partial class FrmViewTable : Form
    {
        enum type { order, products, phases, obj }
        type _type;
        List<List<string>> _data;
        List<string> _columns;

        public FrmViewTable()
        {
            InitializeComponent();
        }

        public FrmViewTable(List<List<string>> data, List<string> columns, int type)
        {
            InitializeComponent();
            _type = (type)type;
            _data = data;
            _columns = columns;
            ShowDataGridView();
            if (_type == FrmViewTable.type.order)
            {
                lblList.Text = lblList.Text + "degli ordini";
                cmbBox1.Visible = false;
            }
            if (_type == FrmViewTable.type.products)
            {
                lblList.Text = lblList.Text + "dei prodotti";
                cmbBox1.Visible = false;
            }
        }

        private void ShowDataGridView()
        {
            for (int i = 0; i < _columns.Count; i++)
            {
                dataGridView1.Columns.Add(_columns[i], _columns[i]);
            }
            for (int col = 0; col < _data.Count; col++)
            {
                dataGridView1.Rows.Add();
                for (int row = 0; row < _columns.Count; row++)
                {
                    dataGridView1[row, col].Value = _data[col][row];
                }
            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void FrmViewTable_Load(object sender, EventArgs e)
        {

        }
    }
}
