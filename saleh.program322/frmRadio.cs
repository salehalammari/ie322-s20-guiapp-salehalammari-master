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
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }
        public frmRadio(string title, string txt)
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // rdoBlue.Checked = true;
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            rdoRed.Checked = false;
            rdoGreen.Checked = false;
            rdoBlue.Checked = false;
            rdoYallow.Checked = false;

            rdoRed.ForeColor = Color.FromName("black");
            rdoGreen.ForeColor = Color.FromName("black");
            rdoBlue.ForeColor = Color.FromName("black");
            rdoYallow.ForeColor = Color.FromName("black");

            RdoRed2.Checked = false;
            RdoGreen2.Checked = false;
            RdoBlue2.Checked = false;
            RdoYallow2.Checked = false;

            RdoRed2.ForeColor = Color.FromName("black");
            RdoGreen2.ForeColor = Color.FromName("black");
            RdoBlue2.ForeColor = Color.FromName("black");
            RdoYallow2.ForeColor = Color.FromName("black");
        }

        private void rdoRed_CheckedChanged(object sender, EventArgs e)
        {

            if (rdoRed.Checked == true)
                rdoRed.ForeColor = Color.FromArgb(255, 0, 0); // http://www.flounder.com/csharp_color_table.htm
            else
                rdoRed.ForeColor = Color.FromArgb(0, 0, 0);

        }

        private void rdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGreen.Checked == true)
                rdoGreen.ForeColor = Color.FromName("green");
            else
                rdoGreen.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void rdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBlue.Checked == true)
                rdoBlue.ForeColor = Color.FromName("blue");
            else
                rdoBlue.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void rdoYallow_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoYallow.Checked == true)
                rdoYallow.ForeColor = Color.FromName("yellow");
            else
                rdoYallow.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RdoGreen2_CheckedChanged(object sender, EventArgs e)
        {
            RdoGreen2.ForeColor = Color.FromName("green");
        }

        private void RdoRed2_CheckedChanged(object sender, EventArgs e)
        {
            RdoRed2.ForeColor = Color.FromName("red");
        }

        private void RdoBlue2_CheckedChanged(object sender, EventArgs e)
        {
            RdoBlue2.ForeColor = Color.FromName("blue");
        }

        private void RdoYallow2_CheckedChanged(object sender, EventArgs e)
        {
            RdoYallow2.ForeColor = Color.FromName("yellow");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
