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
    public partial class frmPic01 : Form
    {
        public frmPic01()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            picTry.Image = Image.FromFile("C:\\Users\\saleh alammari\\OneDrive\\سطح المكتب\\saleh.program322\\c.jpg");
        }
    }
}
