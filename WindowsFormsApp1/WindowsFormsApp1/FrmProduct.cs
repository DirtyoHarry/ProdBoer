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
    public partial class FrmProduct : Form
    {
        Production AddPR = new Production();
        List<string> AddProduct = new List<string>();
        public List<string> newObject { get { return AddProduct; } }

        public FrmProduct()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddProduct.Add(txtBoxName.Text);
            AddProduct.Add(txtBoxMeasure.Text);
            AddProduct.Add(comboBox1.SelectedIndex.ToString());

           
        }
    }
}
