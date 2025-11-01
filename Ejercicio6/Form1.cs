using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Ejercicio6 : Form
    {

        public Ejercicio6()
        {
            InitializeComponent();
            this.KeyPreview = true;

            btnAvance.Enabled = false;
            btnRetroceso.Enabled = false;
        }
        internal class Propiedades
        {
            private string imagen;
            public string Imagen { set; get; }

            private string titulo;
            public string Titulo { set; get; }

            private long tamaño;
            public long Tamaño { set; get; }

            public Propiedades()
            {
                Imagen = "";
                Titulo = "";
                Tamaño = 0;
            }

            public Propiedades(string imagen, string titulo, long tamaño)
            {
                Imagen = imagen;
                Titulo = titulo;
                Tamaño = tamaño;
            }
        }

        public bool confirmarImagen(string ruta)
        {
            try
            {
                using (Image img = Image.FromFile(ruta))
                {
                    return true;
                }

            }
            catch (ArgumentException ag)
            {
                return false;

            }
            catch (FileNotFoundException fn)
            {
                return false;

            }
            catch (OutOfMemoryException ofe)
            {
                return false;
            }
        }

        DialogResult res;
        FolderBrowserDialog fb;
        string rutaSeleccionada = "";

        int width = 50;
        int height = 50;

        int x = 10;
        int y = 0;

        int cont = -1;

        List<Propiedades> propiedades = new List<Propiedades>(); // --> Coleccion de las imagenes contenidas en las listas

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            using (fb = new FolderBrowserDialog())
            {
                fb.Description = "Selecciona una carpeta de destino";
                fb.RootFolder = Environment.SpecialFolder.MyPictures;
                fb.ShowNewFolderButton = false;

                res = fb.ShowDialog();
                if (res == DialogResult.OK)
                {

                    propiedades.Clear();
                    pnImagenes.Controls.Clear();

                    rutaSeleccionada = fb.SelectedPath;

                    DirectoryInfo dir = new DirectoryInfo(rutaSeleccionada);

                    foreach (FileInfo fi in dir.GetFiles())
                    {

                        string ext = fi.Extension.ToLower();
                        if ((ext == ".jpg" || ext == ".png" || ext == ".jpeg" || ext == ".bmp" || ext == ".gif") && confirmarImagen(fi.FullName)) //Corregir esta condicion para imagenes corruptas
                        {
                            cont++;
                            /**
                             * 1 ruta imagen
                             * 2 nombre y extension
                             * 3 tamaño en KB
                             */
                            Propiedades prop = new Propiedades(fi.FullName, fi.Name, (long)fi.Length / 1024);
                            propiedades.Add(prop);

                            if (cont == 0)
                            {
                                pbImagen.Image = new Bitmap(fi.FullName);
                                pbImagen.SizeMode = PictureBoxSizeMode.AutoSize;
                                pbImagen.Tag = cont;

                                this.Text = "Visor de imagenes " + prop.Titulo;
                            }

                            PictureBox pi = new PictureBox(); //--> añadir el autosize y que se vean todas las imagenes

                            pi.Image = new Bitmap(fi.FullName);
                            this.Dock = DockStyle.None;

                            if (cont % 4 == 0)
                            {
                                x = 10;
                                y += 70;
                            }
                            else
                            {
                                x += 70;
                            }

                            pi.Location = new Point(x, y);
                            pi.Size = new Size(width, height);
                            pi.SizeMode = PictureBoxSizeMode.StretchImage;
                            pi.Tag = cont;

                            pi.Click += colocarImagen;

                            lblImagen.Text = $"Nombre: {fi.Name}, Tamaño en KB: {(long)fi.Length / 1024}, Resolucion: {pbImagen.Width}:{pbImagen.Height}";
                            lblDirectorio.Text = rutaSeleccionada;

                            pnImagenes.Controls.Add(pi);

                        }
                    }

                    if (propiedades.Count > 0)
                    {
                        btnAvance.Enabled = true;
                        btnRetroceso.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ninguna imagen", "Ninguna imagen seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        string imagen = "";
        private void btnAvance_Click(object sender, EventArgs e)
        {
            if ((int)pbImagen.Tag == propiedades.Count - 1)
            {
                pbImagen.Tag = 0;
            }
            else
            {
                pbImagen.Tag = ((int)pbImagen.Tag + 1);

            }
            imagen = propiedades[(int)pbImagen.Tag].Imagen;


            this.Text = "Visor de imagenes " + propiedades[(int)pbImagen.Tag].Titulo;
            lblImagen.Text = $"Nombre: {propiedades[(int)pbImagen.Tag].Titulo}, Tamaño en KB: {propiedades[(int)pbImagen.Tag].Tamaño}, Resolucion: {pbImagen.Width}:{pbImagen.Height}";
            lblDirectorio.Text = rutaSeleccionada;

            pbImagen.Image = new Bitmap(imagen);

        }

        private void btnRetroceso_Click(object sender, EventArgs e)
        {
            if ((int)pbImagen.Tag == 0)
            {
                pbImagen.Tag = propiedades.Count - 1;
            }
            else
            {
                pbImagen.Tag = ((int)pbImagen.Tag - 1);

            }
            imagen = propiedades[(int)pbImagen.Tag].Imagen;

            this.Text = "Visor de imagenes " + propiedades[(int)pbImagen.Tag].Titulo;
            lblImagen.Text = $"Nombre: {propiedades[(int)pbImagen.Tag].Titulo}, Tamaño en KB: {propiedades[(int)pbImagen.Tag].Tamaño}, Resolucion: {pbImagen.Width}:{pbImagen.Height}";
            lblDirectorio.Text = rutaSeleccionada;

            pbImagen.Image = new Bitmap(propiedades[(int)pbImagen.Tag].Imagen);

        }

        private void Ejercicio6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                btnAvance.PerformClick();
            }

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                btnRetroceso.PerformClick();
            }
        }

        private void colocarImagen(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            pbImagen.Tag = (int)pic.Tag;

            lblImagen.Text = $"Nombre: {propiedades[(int)pbImagen.Tag].Titulo}, Tamaño en KB: {propiedades[(int)pbImagen.Tag].Tamaño}, Resolucion: {pbImagen.Width}:{pbImagen.Height}";
            lblDirectorio.Text = rutaSeleccionada;

            pbImagen.Image = new Bitmap(propiedades[(int)pbImagen.Tag].Imagen);
        }

        private void Ejercicio6_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Quieres salir del programa?", "Salir del programa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
