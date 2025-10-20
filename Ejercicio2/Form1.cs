using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {

        public int?[] confirmarRGB(string[] valores)
        {
            if (valores.Length == 0 || valores.Length > 3)
            {
                return null;
            }
            else
            {
                int?[] res = new int?[3];
                for (int i = 0; i < valores.Length; i++)
                {
                    if (!int.TryParse(valores[i], out int val))
                    {
                        MessageBox.Show($"Error en los parametros RGB del textBox numero {i + 1}", "Error de parametros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return null;
                    }
                    else
                    {
                        if (val < 0 || val > 255)
                        {
                            MessageBox.Show($"Error en los parametros RGB del textBox numero {i + 1}, solo se adminten numeros del 0 al 255", "Error de parametros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return null;
                        }
                    }
                    res[i] = val;
                }
                return res;
            }
        }
        public Form1()
        {
            InitializeComponent();

            this.CancelButton = btnSalir;
            this.AcceptButton = btnColor;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Seguro que qieres salir del progrma?", "Salir de la aplicacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            string r = txtR.Text;
            string g = txtG.Text;
            string b = txtB.Text;

            if (r == "R" && g == "G" && b == "B")
            {
                MessageBox.Show("Introduce las propiedades RGB en los textBox", "Uso del color", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                string[] colores = { r, g, b };

                int?[] rgbNull = confirmarRGB(colores);

                if (rgbNull != null)
                {
                    int[] rgb = rgbNull.Select(n => n ?? 0).ToArray(); //El ?? indica si el parametro tiene valor, si es asi, lo usa, el select transforma o proyecta valores que cumplen una condicion

                    this.BackgroundImage = null;
                    this.BackColor = Color.FromArgb(rgb[0], rgb[1], rgb[2]);
                }
            }
        }

        private void ptBtnImagen_Click(object sender, EventArgs e)
        {

        }

        private void btnColor_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnColor;
        }

        private void focoBotones(object sender, EventArgs e)
        {

            TextBox txt = (TextBox)sender;

            if (txt == txtImagen)
            {
                this.AcceptButton = btnImagen;
            }
            else if (txt == txtR || txt == txtG || txt == txtB)
            {
                this.AcceptButton = btnColor;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            BackgroundImage = null;

            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txt = (TextBox)ctr;
                    txt.Text = (string)txt.Tag;
                }

                if (ctr is PictureBox)
                {
                    PictureBox pc = (PictureBox)ctr;

                    pc.Image = null;
                }
            }
        }

        public Dictionary<Control, Color> coloresComponentes = new Dictionary<Control, Color>();//Diccionario que almacena el color de fondo de los componentes
        private void ratonDentro(object sender, EventArgs e)
        {
            Control cont = (Control)sender;

            if (!coloresComponentes.ContainsKey(cont))
            {
                coloresComponentes.Add(cont, cont.BackColor);

            }
            cont.BackColor = Color.Red;
        }

        private void ratonFuera(object sender, EventArgs e)
        {

            Control cont = (Control)sender;

            Color col = coloresComponentes[cont];
            cont.BackColor = col;
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            if (txtImagen.Text == null || txtImagen.Text == "")
            {
                MessageBox.Show($"Introduce una ruta absoluta con la imagen en el textBox", "Error en la imagen", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    ptbImagen.Image = new Bitmap(txtImagen.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se encuentra la imagen {txtImagen}", "Error en la imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ptbImagen_Click(object sender, EventArgs e)
        {

        }

        private void txtR_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
