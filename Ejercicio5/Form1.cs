using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        string directorio = Directory.GetCurrentDirectory();
        string txtNumeros = "Numeros.txt";

        List<string> numeros = new List<string>();
        bool existe;

        public Form1()
        {
            InitializeComponent();

            int x = 0;
            int y = 0;

            for (int i = 0; i < 12; i++)
            {
                Button btn = new Button();

                if (i < 9)
                {
                    btn.Text = (i + 1).ToString();
                    btn.BackColor = Color.Blue;

                }
                else if (i == 9)
                {
                    btn.Text = "*";
                    btn.BackColor = Color.Cyan;

                }
                else if (i == 10)
                {
                    btn.Text = 0.ToString();
                    btn.BackColor = Color.Blue;

                }
                else if (i == 11)
                {
                    btn.Text = "#";
                    btn.BackColor = Color.Cyan;
                }

                if (i % 3 == 0)
                {
                    x = 50;
                    y = y + 70;
                }
                else
                {
                    x = x + 80;
                }

                btn.Tag = btn.BackColor;

                btn.MouseEnter += ratonEncima;
                btn.MouseLeave += ratonFuera;
                btn.Click += clickBoton;


                btn.Location = new Point(x, y);
                btn.Size = new Size(60, 60);

                pantalla.Controls.Add(btn);
            }

            txtMovil.ForeColor = Color.LightCyan;
            txtMovil.ReadOnly = true;
            btnResest.ForeColor = Color.LightCyan;

            if (File.Exists(txtNumeros))
            {
                existe = true;
                string linea;
                StreamReader sr;
                try
                {
                    using (sr = new StreamReader(txtNumeros))
                    {
                        linea = sr.ReadLine();
                        while (linea != null)
                        {
                            numeros.Add(linea);
                            linea = sr.ReadLine();
                        }
                    }

                }
                catch (IOException)
                {
                    Console.WriteLine("Error en el archivo");
                }
            }

        }

        private void ratonEncima(object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            if (!(btn.BackColor == Color.LightCyan))
            {
                btn.BackColor = Color.LightGreen;
            }

        }

        private void ratonFuera(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (!(btn.BackColor == Color.LightCyan))
            {
                btn.BackColor = (Color)btn.Tag;
            }
        }

        private void clickBoton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackColor = Color.LightCyan;

            txtMovil.Text = txtMovil.Text + btn.Text;
        }

        private void btnResest_Click(object sender, EventArgs e)
        {
            txtMovil.Text = "";

            for (int i = 0; i < pantalla.Controls.Count; i++)
            {
                if (pantalla.Controls[i] is Button)
                {
                    Button btn = (Button)pantalla.Controls[i];

                    btn.BackColor = (Color)btn.Tag;
                }
            }
        }

        bool salir = false;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (!salir)
            {
                if (MessageBox.Show("Quieres salir del programa?", "Salir del programa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salir = true;
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este programa emula un telefono movil antiguo, cuenta con varias funciones, ha sido programado por Nicolas Docampo, un joven estudiante de programacion", "informacion sobre el programa y el autor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        Secundario f2 = new Secundario();

        private void grabarNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Se añade todo antes de llamar al showDialog porque esto bloquea todo y no se ejecuta hasta que se cierra el formulario secundario
            f2.txtSecunNum.Text = txtMovil.Text;
            f2.txtSecunNum.ReadOnly = true;

            f2.btnAñadir.Click += añadirNumero;//esyo
            f2.ShowDialog();
        }

        private void añadirNumero(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(f2.txtNombre.Text))
            {
                MessageBox.Show("El textBox del nombre ha de ser rellenado para guardar el numero de telefono", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //añadir el nombre y el numero de telefono
                StreamWriter sw;

                try
                {
                    using (sw = existe ? new StreamWriter(txtNumeros, true) : new StreamWriter(txtNumeros))
                    {
                        if (string.IsNullOrEmpty(f2.txtNombre.Text) || string.IsNullOrEmpty(f2.txtSecunNum.Text))
                        {
                            f2.Hide();
                            MessageBox.Show("Se necesita tanto el numero como el nombre para guardar el numero de telefono", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            string ln = $"{f2.txtNombre.Text}:{f2.txtSecunNum.Text}";
                            MessageBox.Show(ln, "datos", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            numeros.Add(ln);
                            sw.WriteLine(ln);
                            f2.Close();
                        }

                    }
                }
                catch (IOException)
                {
                    Console.WriteLine("Fallo en el archivo");
                }
            }
        }

        private void mostrarAgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //añadir el formulario no modal

            NoModal nm = new NoModal();


            if (numeros.Count != 0)
            {
                for (int i = 0; i < numeros.Count(); i++)
                {
                    string[] di = numeros[i].Split(':');

                    if (di.Length == 2)
                    {
                        nm.txtAgenda.AppendText($"{Environment.NewLine}{di[0],10}\t\t{di[1],10}");
                    }
                }
                nm.Show();
            }
            else
            {
                MessageBox.Show("No hay numeros en la coleccion", "Falta de numeros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnResest.PerformClick();
        }
    }
}
