using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RBtnMerah.Checked = true;
        }
         
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            bool belumAda = true;
            foreach(var item in LBoxData.Items)
                if(item.ToString() == TBoxData.Text) belumAda = false;
            if (belumAda)
            {
                LBoxData.Items.Add(TBoxData.Text);
                LBoxData.SelectedItem = TBoxData.Text;
                LblOutput.Text = TBoxData.Text;
                TBoxData.Text = "";
            }
            else
            {
                MessageBox.Show("Input Sudah Ada !");
                TBoxData.Text = "";
            }
            TBoxData.Focus();
        }

        private void CBoxAktif_CheckedChanged(object sender, EventArgs e)
        {
            if(CBoxAktif.Checked)
            {
                if(RBtnMerah.Checked) LblOutput.ForeColor = Color.Red;
                if(RBtnBiru.Checked) LblOutput.ForeColor = Color.Blue;
            }
            else
            {
                LblOutput.ForeColor = Color.Black;
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            LBoxData.Items.Clear();
            RBtnMerah.Checked = true;
            RBtnBiru.Checked = false;
            CBoxAktif.Checked = false;
            LblOutput.Text = "Output";
            TBoxData.Text = "";
        }

        private void RBtnBiru_CheckedChanged(object sender, EventArgs e)
        {
            if(CBoxAktif.Checked)
            {
                LblOutput.ForeColor = Color.Blue;
            }
        }

        private void RBtnMerah_CheckedChanged(object sender, EventArgs e)
        {
            if (CBoxAktif.Checked)
            {
                LblOutput.ForeColor = Color.Red;
            }
        }

        private void LBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblOutput.Text = LBoxData.SelectedItem.ToString();
        }
    }
}
