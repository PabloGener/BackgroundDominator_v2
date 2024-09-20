using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgroundDominator_v2
{
    public partial class frmFullScreen : Form
    {
        public frmFullScreen()
        {
            InitializeComponent();
        }

        private void frmFullScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        private void frmFullScreen_Load(object sender, EventArgs e)
        {
            pbFullscreen.Size = this.Size;
        }
    }
}
