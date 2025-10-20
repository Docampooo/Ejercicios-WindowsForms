using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosWindowsForms
{
    public partial class MouseTester : Form
    {
        public MouseTester()
        {
            InitializeComponent();
            btn1.Tag = Color.Green;
            btn2.Tag = Color.Red;

            this.KeyPreview = true;

            int x = 75;
            int y = 125;
            List<Button> botones = new List<Button>();

            for (int i = 0; i < 20; i++)
            {
                Button btn = new Button();

                if (i % 5 == 0)
                {
                    x = 75;
                    y = y + 50;
                }
                else
                {
                    x = x + 100;
                }
                btn.Location = new Point(x, y);
                btn.Text = (i + 1).ToString();

                btn.MouseDown += Btn_MouseDown;
                btn.MouseUp += Btn_MouseUp;
                btn.MouseMove += ratonEnBoton;

                this.Controls.Add(btn);
                botones.Add(btn);

            }

            btn1.MouseMove += ratonEnBoton;
            btn2.MouseMove += ratonEnBoton;


            this.Icon = Properties.Resources.perroGafas;
        }

        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            Random x = new Random();

            int r = x.Next(0, 256);
            int g = x.Next(0, 256);
            int b = x.Next(0, 256);

            Color c = Color.FromArgb(r, g, b);

            Button btn = (Button)sender;

            btn.ForeColor = c;
        }

        private void Btn_MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;

            btn.ForeColor = Color.Black;
        }

        private void MouseTester_MouseMove(object sender, MouseEventArgs e)
        {
            //TODO Sin esto (polim) e icono
            Point p = this.PointToClient(Cursor.Position);

            Text = $"X:{p.X.ToString()} Y:{p.Y.ToString()}";
        }

        private void ratonEnBoton(object sender, MouseEventArgs e) //Funcion para los botones
        {
            Button btn = (Button)sender;

            Point p = btn.Location;

            Text = $"X:{p.X.ToString()} Y:{p.Y.ToString()}";

        }

        private void MouseTester_MouseLeave(object sender, EventArgs e)
        {
            Text = "Juego de raton";
        }

        private void MouseTester_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                btn1.BackColor = (Color)btn1.Tag;
            }
            else if (e.Button == MouseButtons.Right)
            {
                btn2.BackColor = (Color)btn2.Tag;
            }
            else
            {
                btn1.BackColor = Color.Blue;
                btn2.BackColor = Color.Blue;
            }
        }

        private void MouseTester_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Text = "Juego de Raton";
            }
            else
            {
                Text = e.KeyCode.ToString();
            }
        }

        private void MouseTester_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                btn1.BackColor = Color.White;
            }
            else if (e.Button == MouseButtons.Right)
            {
                btn2.BackColor = Color.White;
            }
            else
            {
                btn1.BackColor = Color.White;
                btn2.BackColor = Color.White;
            }
        }

        private void MouseTester_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Salir de mi aplicacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
