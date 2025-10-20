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
    public partial class ImagenGenerada : Form
    {
        public ImagenGenerada()
        {
            InitializeComponent();

            //Propiedades del picture box
        }

        private void noDeformarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imagenFondo.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void ajustarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imagenFondo.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
