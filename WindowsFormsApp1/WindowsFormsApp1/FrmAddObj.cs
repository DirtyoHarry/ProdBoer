﻿using System;
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
    public partial class FrmAddObj : Form
    {
        private Production addObj = new Production();
        private List<string> obj;
        public List<string> newObject { get { return obj; } }

        public FrmAddObj()
        {
            InitializeComponent();
            obj = new List<string>();
        }
        
        private void cmbBoxSelObj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxSelObj.SelectedIndex == 1)
            {
                lblSurname.Visible = txtBoxSurname.Visible = false;
                txtBoxSpec.Location = new System.Drawing.Point(119, 147);
                lblSpec.Location = new System.Drawing.Point(18, 150);
            }
            else
            {
                lblSurname.Visible = txtBoxSurname.Visible = true;
                txtBoxSurname.Text = "";
                txtBoxSpec.Location = new System.Drawing.Point(119, 187);
                lblSpec.Location = new System.Drawing.Point(18, 190);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text != "" && cmbBoxSelObj.SelectedIndex != -1 && !(radioBbtnInt.Checked == radioBtnExt.Checked == radioBtnBoth.Checked == false))
            {
                obj.Add(txtBoxName.Text);
                obj.Add(txtBoxSurname.Text);
                obj.Add(txtBoxSpec.Text);
                obj.Add(cmbBoxSelObj.SelectedIndex.ToString());
                SetIntExtSpec();
            }
        }

        private void SetIntExtSpec()
        {
            if (radioBbtnInt.Checked == true)
            {
                obj.Add("2");
                obj.Add("0");
            }
            else if (radioBtnExt.Checked == true)
            {
                obj.Add("0");
                obj.Add("2");
            }
            else
            {
                obj.Add("1");
                obj.Add("1");
            }
        }

    }
}
