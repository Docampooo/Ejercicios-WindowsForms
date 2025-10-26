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
            this.CancelButton = 
        }

        DialogResult res;
        FolderBrowserDialog fb;
        string rutaSeleccionada = "";

        int width = 50;
        int height = 50;

        int x = 10;
        int y = 0;

        int cont = -1;
        List<string> imagenes = new List<string>();
        List<string> titulos = new List<string>();
        List<long> tamaños = new List<long>();


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

                    rutaSeleccionada = fb.SelectedPath;

                    DirectoryInfo dir = new DirectoryInfo(rutaSeleccionada);

                    foreach (FileInfo fi in dir.GetFiles())
                    {

                        string ext = fi.Extension.ToLower();
                        if (ext == ".jpg" || ext == ".png" || ext == ".jpeg")
                        {
                            cont++;
                            imagenes.Add(fi.FullName); //ruta imagen
                            titulos.Add(fi.Name); //nombre y extension imagen
                            tamaños.Add((long)fi.Length / 1024); //tamaño en KB

                            if (cont == 0)
                            {
                                pbImagen.Image = new Bitmap(fi.FullName);
                                pbImagen.SizeMode = PictureBoxSizeMode.AutoSize;
                                pbImagen.Tag = cont;

                                this.Text = "Visor de imagenes " + titulos[cont];
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
            if ((int)pbImagen.Tag == imagenes.Count - 1)
            {
                pbImagen.Tag = 0;
            }
            else
            {
                pbImagen.Tag = ((int)pbImagen.Tag + 1);

            }
            imagen = imagenes[(int)pbImagen.Tag];


            this.Text = "Visor de imagenes " + titulos[(int)pbImagen.Tag];
            lblImagen.Text = $"Nombre: {titulos[(int)pbImagen.Tag]}, Tamaño en KB: {tamaños[(int)pbImagen.Tag]}, Resolucion: {pbImagen.Width}:{pbImagen.Height}";
            lblDirectorio.Text = rutaSeleccionada;

            pbImagen.Image = new Bitmap(imagen);

        }

        private void btnRetroceso_Click(object sender, EventArgs e)
        {
            if ((int)pbImagen.Tag == 0)
            {
                pbImagen.Tag = imagenes.Count - 1;
            }
            else
            {
                pbImagen.Tag = ((int)pbImagen.Tag - 1);

            }
            imagen = imagenes[(int)pbImagen.Tag];

            this.Text = "Visor de imagenes " + titulos[(int)pbImagen.Tag];
            lblImagen.Text = $"Nombre: {titulos[(int)pbImagen.Tag]}, Tamaño en KB: {tamaños[(int)pbImagen.Tag]}, Resolucion: {pbImagen.Width}:{pbImagen.Height}";
            lblDirectorio.Text = rutaSeleccionada;

            pbImagen.Image = new Bitmap(imagen);

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

            pbImagen.Image = new Bitmap(imagenes[(int)pbImagen.Tag]);
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
