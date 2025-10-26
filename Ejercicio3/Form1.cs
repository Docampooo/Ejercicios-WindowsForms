using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form//TODO menu contextual en secundario
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
            string rutaInicial = Environment.GetEnvironmentVariable("homepath");

            try
            {
                ofd.InitialDirectory = rutaInicial + "\\OneDrive\\Images\\Recursos\\Aspectos\\chacarron";

            }
            catch (SecurityException)
            {
                MessageBox.Show("No hay permisos para esta carpeta", "Error de permisos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ofd.InitialDirectory = rutaInicial;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Error en los caracteres de la cadena", "Error de parametros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ofd.InitialDirectory = rutaInicial;
            }
            catch (IOException)
            {
                MessageBox.Show("Error al acceder al sistema de archivos", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ofd.InitialDirectory = rutaInicial;
            }
            ofd.ValidateNames = true;
            ofd.Multiselect = true;
            ofd.Filter = "Imagen PNG (*.png)|*.png|Imagen JPEG (*.jpeg)|*.jpeg|Todos los archivos(*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string cad = ofd.FileName.Trim();

                ImagenGenerada f2 = new ImagenGenerada();

                try
                {
                    Image imagenSeleccionada = Image.FromFile(ofd.FileName);
                    f2.imagenFondo.Image = imagenSeleccionada;

                    string[] ruta = ofd.FileName.Split('.', '\\');
                    string nomImagen = ruta[ruta.Length - 2];

                    f2.Text = nomImagen;

                    if (chkModal.Checked)
                    {
                        f2.ShowDialog();
                    }
                    else
                    {
                        f2.Show();
                    }
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Solo se admiten imagenes en este campo", "Error en el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("Solo se admiten imagenes en este campo", "Error en el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Solo se admiten imagenes en este campo", "Error en el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
            if (contSeg % 60 == 0)
            {
                contMin++;
                contSeg = 0;
            }

            this.Text = $"Visor de imagenes {contMin,2:D2}:{contSeg,2:D2}";
        }
    }
}
