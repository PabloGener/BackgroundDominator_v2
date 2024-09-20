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
        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdCarpeta_Click(object sender, EventArgs e)
        {
            List<string> strImagenes = new List<string>();
            DirectoryInfo dinfo = new DirectoryInfo(txtCarpeta.Text);
            FileInfo[] Imagenes = dinfo.GetFiles(@"*.jpg");
            foreach (FileInfo imagen in Imagenes)
            {
                //lstImagenes.Items.Add(imagen.Name);
                strImagenes.Add(imagen.Name);
            }

            foreach (string imagen in strImagenes) 
            {
                Debug.WriteLine("Imagen: " + imagen);
            }
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
    }
}
