using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    { //articolo su misura
        public Form2()
        {
            InitializeComponent();
            //dateTimePicker3.Format = Custom
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[comboBox1.SelectedIndex];
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

        private void button1_Click(object sender, EventArgs e)
        {
            TabPage tb = new TabPage("fase");
            tabControl1.TabPages.Add(tb);
        }
    }
}
