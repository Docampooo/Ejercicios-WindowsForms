using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Visor de imagenes";

            tmr.Interval = 1000;
            tmr.Start();
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Seleccion de directorio para imagenes";
            ofd.InitialDirectory = "C:\\Users\\Usuario\\OneDrive\\Images\\Recursos\\Aspectos\\chacarron";
            ofd.ValidateNames = true;
            ofd.Multiselect = true;
            ofd.Filter = "Imagen PNG (*.png)|*.png|Imagen JPEG (*.jpeg)|*.jpeg|Todos los archivos(*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ImagenGenerada f2 = new ImagenGenerada();

                if (chkModal.Checked)
                {
                    f2.ShowDialog();
                }
                else
                {
                    f2.Show();
                }

                Image imagenSeleccionada = Image.FromFile(ofd.FileName);
                f2.imagenFondo.Image = imagenSeleccionada;

                string[] ruta = ofd.FileName.Split('.','\\');
                string nomImagen = ruta[ruta.Length -2];

                f2.Text = nomImagen;
            }
            
        }

        private void chkModal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkModal.Checked)
            {
                chkModal.ForeColor = Color.Red;
            }
            else
            {
                chkModal.ForeColor = Color.Black;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int contSeg = 0;
        int contMin = 0;
        private void tmr_Tick(object sender, EventArgs e)
        {
            contSeg++;
            if(contSeg % 60 == 0)
            {
                contMin++;
                contSeg = 0;
            }

            this.Text = $"Visor de imagenes {contMin,2:D2}:{contSeg,2:D2}";
        }
    }
}
