using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saleh.program322
{
    public partial class Form1 : Form
    {
        string username = "Saleh"; //username
        string myPassword = "123456"; //password
        

        int attempt = 1;
        int MaxAttempts = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();

        }

        private void btnCheckBox_Click(object sender, EventArgs e)
        {
            frmCheck frm = new frmCheck();
            frm.ShowDialog();
            //to close the form
            this.DialogResult = DialogResult.OK;
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            frmCombo frm = new frmCombo();
            frm.ShowDialog();
        }

        private void LogintoIE322_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
        private void btnPic_Click(object sender, EventArgs e)
        {
            frmImage frm = new frmImage();
            frm.ShowDialog();
            //to close the form
            this.DialogResult = DialogResult.OK;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            frmRandom frm = new frmRandom();
            frm.ShowDialog();
            //to close the form
            this.DialogResult = DialogResult.OK;
        }

        private void btnRandom2_Click(object sender, EventArgs e)
        {
            frmRandomCombo frm = new frmRandomCombo();
            frm.ShowDialog();
        }
    }
}
