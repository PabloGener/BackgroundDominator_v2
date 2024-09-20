using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            int nX, nY;
            nX = (pbFullscreen.Width /2) - (tlpComandos.Width/2);
            nY = pbFullscreen.Height - tlpComandos.Height - 24;
            tlpComandos.Top = nY;
            tlpComandos.Left = nX;

        }

        private void cmdStretch_Click(object sender, EventArgs e)
        {
            Cambiador.cambiarFondo(pbFullscreen.Tag.ToString());
            Cambiador.Estilos(2);
        }
        private void cmdCenter_Click(object sender, EventArgs e)
        {
            Cambiador.cambiarFondo(pbFullscreen.Tag.ToString());
            Cambiador.Estilos(1);
        }
        private void cmdTile_Click(object sender, EventArgs e)
        {
            Cambiador.cambiarFondo(pbFullscreen.Tag.ToString());
            Cambiador.Estilos(0);
        }



        

        
    }
}
