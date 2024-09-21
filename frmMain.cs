using System;
using System.Collections;
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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BackgroundDominator_v2
{
    public partial class frmMain : Form
    {
        List<string> strImagenes = new List<string>();
        

        int cPagina, cantPag;
        string strFullScreen;

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
                Properties.Settings.Default.UltimaCarpeta = txtCarpeta.Text;
                Properties.Settings.Default.Save();
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
                    pbActual.Tag = "";
                    pbActual.Refresh();
                }
                if (cActual < cFin)
                {
                    
                    pbActual.Image = Image.FromFile(strImagenes[cActual]);
                    pbActual.Tag = strImagenes[cActual];
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.UltimaCarpeta != "")
            {
                txtCarpeta.Text = Properties.Settings.Default.UltimaCarpeta;
                Leer_Carpeta();

                CargarUsados();
            }
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                generarRandoms();
            }
        }

        private void cmdCambiar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button cEstilo = (System.Windows.Forms.Button)sender;

            string nBG = "";
            if(rbtnRandom1.Checked) { nBG = rbtnRandom1.Tag.ToString(); } else
                if (rbtnRandom2.Checked) { nBG = rbtnRandom2.Tag.ToString(); } else
                    if(rbtnRandom3.Checked) { nBG =rbtnRandom3.Tag.ToString(); }

            int res = Cambiador.cambiarFondo(nBG);
            Cambiador.Estilos(int.Parse(cEstilo.Tag.ToString()));

            if(res > 0)
            {
                Cambiador.ActualizarUsados(nBG);
            }
        }

        

        private void cmdCloseRandoms_Click(object sender, EventArgs e)
        {
            gpThreeRandoms.Visible = false;
        }

        private void btnReloadRandom_Click(object sender, EventArgs e)
        {
            generarRandoms();
        }

        private void Ver_FullScreen(object sender, EventArgs e)
        {
            PictureBox cPBPreview = (PictureBox)sender;
            Form pantalla_completa = new frmFullScreen();
            foreach (PictureBox pbPC in pantalla_completa.Controls.OfType<PictureBox>())
            {
                pbPC.Image = Image.FromFile(cPBPreview.Tag.ToString());
                pbPC.Tag = cPBPreview.Tag.ToString();
            }
            pantalla_completa.Show();
        }



        

        private void GuardarUsados()
        {
            //guardar la lista de usados
            if (Program.strUsados.Count > 0)
            {
                //guardar las rutas de los archivos usados
                File.WriteAllLines("Usados.txt", Program.strUsados);
                //guardar las veces que se uso cada uno
                //....
                using (StreamWriter sw = File.CreateText("Veces.txt"))
                {
                    foreach (int aVeces in Program.intVeces)
                    {
                        sw.WriteLine(aVeces.ToString());
                    }
                }

            }

        }

        private void CargarUsados()
        {
            //cargar la lista de usados
            if (File.Exists("Usados.txt"))
            {
                if (Program.strUsados.Count > 0) { Program.strUsados.Clear(); }
                var filUsados = File.ReadAllLines("Usados.txt");
                Program.strUsados = new List<string>(filUsados);

                if (Program.intVeces.Count > 0) { Program.intVeces.Clear(); }
                var filVeces = File.ReadAllLines("Veces.txt");
                List<string> strTemp = new List<string>(filVeces);
                foreach (string vez in strTemp)
                {
                    Program.intVeces.Add(int.Parse(vez));
                }
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardarUsados();
        }

        private void generarRandoms()
        {
            gpThreeRandoms.Visible = true;
            //SHOW THREE RANDOM IMAGES
            var rd = new Random();
            int r1, r2, r3;
            r1 = rd.Next(1, strImagenes.Count);
            r2 = rd.Next(1, strImagenes.Count);
            r3 = rd.Next(1, strImagenes.Count);


            rbtnRandom1.BackgroundImage = Image.FromFile(strImagenes[r1]);
            rbtnRandom1.Tag = strImagenes[r1];

            rbtnRandom2.BackgroundImage = Image.FromFile(strImagenes[r2]);
            rbtnRandom2.Tag = strImagenes[r2];

            rbtnRandom3.BackgroundImage = Image.FromFile(strImagenes[r3]);
            rbtnRandom3.Tag = strImagenes[r3];
        }
    }
}
