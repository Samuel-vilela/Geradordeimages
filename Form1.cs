using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geradordeimages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdBtn_prota_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_cj.Visible = true;
            pictureBox_big.Visible = true;
            pictureBox_rider.Visible = true;
        }

        private void rdBtn_coad_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_kendi.Visible = true;
            pictureBox_policial.Visible = true;
            pictureBox_matt.Visible = true;
        }
    }
}
