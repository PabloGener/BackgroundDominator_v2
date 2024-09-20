using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BackgroundDominator_v2
{
    public partial class frmMain : Form
    {
        List<string> strImagenes = new List<string>();
        int cPagina, cantPag;


        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdCarpeta_Click(object sender, EventArgs e)
        {
            Leer_Carpeta();
        }

        private void txtCarpeta_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);
                Debug.WriteLine("Carpeta: " + archivos[0]);

                DirectoryInfo carpeta = new DirectoryInfo(Path.GetFullPath(archivos[0]));
                if (carpeta.Exists) 
                {
                    txtCarpeta.Text = carpeta.ToString();
                    Leer_Carpeta();
                }

            }
        }

        private void txtCarpeta_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }


        private void Leer_Carpeta() 
        {
            DirectoryInfo dinfo = new DirectoryInfo(txtCarpeta.Text);
            FileInfo[] Imagenes = dinfo.GetFiles(@"*.jpg");
            foreach (FileInfo imagen in Imagenes)
            {
                //lstImagenes.Items.Add(imagen.Name);
                strImagenes.Add(imagen.FullName);

            }

            foreach (string imagen in strImagenes)
            {
                Debug.WriteLine("Imagen: " + imagen);
            }

            if (strImagenes.Count > 0) 
            {
                cPagina = 1;
                cantPag = strImagenes.Count / 20;
                if(strImagenes.Count % 20 > 0) { cantPag++; }
                if(cantPag > 1) { cmdAvPag.Enabled = true; }
                Cargar_Pagina();
            }
        }

        private void Cargar_Pagina() 
        {
            int cActual, cFin;
            cActual = ((cPagina - 1) * 20) + 1;
            cFin = cActual + 20;

            Debug.WriteLine("cantPag:" + cantPag);
            Debug.WriteLine("cActual:" + cActual);
            Debug.WriteLine("cFin:" + cFin);

            tlsStatus.Text = "Paginas:" + cantPag + "| Pag actual:" + cActual;

            if(cFin > strImagenes.Count) { cFin = strImagenes.Count; }

            foreach(PictureBox pbActual in this.Controls.OfType<PictureBox>())
            {
                if (pbActual.Image != null)
                {
                    pbActual.Image.Dispose();
                    pbActual.Image = null;
                    pbActual.Refresh();
                }
                if (cActual < cFin)
                {
                    
                    pbActual.Image = Image.FromFile(strImagenes[cActual]);
                    cActual++;
                }
            }
        }

        private void cmdRePag_Click(object sender, EventArgs e)
        {
            if(cPagina > 1)
            {
                cPagina--;
                cmdAvPag.Enabled = true;
            }

            if(cPagina == 1) { cmdRePag.Enabled = false; }

            Cargar_Pagina();
        }

        private void cmdAvPag_Click(object sender, EventArgs e)
        {
            if (cPagina < cantPag)
            {
                cPagina++;
                cmdRePag.Enabled = true;
            }

            if(cPagina == cantPag) { cmdAvPag.Enabled = false; }

            Cargar_Pagina();
        }
    }
}
