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
            // your TabControl will be defined in your designer
            // as will your original TabPage
            TabPage tpOld = tabControlAddPh.SelectedTab;

            TabPage tpNew = new TabPage();
            foreach (Control c in tpOld.Controls)
            {
                Control cNew = (Control)Activator.CreateInstance(c.GetType());

                PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(c);

                foreach (PropertyDescriptor entry in pdc)
                {
                    object val = entry.GetValue(c);
                    entry.SetValue(cNew, val);
                }

                // add control to new TabPage
                tpNew.Controls.Add(cNew);
            }
            tpNew.BackColor = Color.White;
            tpNew.Text = "Fase";
            tabControlAddPh.TabPages.Add(tpNew);

        }

        private void btnNewObj_Click(object sender, EventArgs e)
        {

        }
    }
}
