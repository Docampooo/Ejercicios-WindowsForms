using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Ejercicio7
{
    public partial class Ejercicio7 : Form
    {

        Dictionary<string, Func<double, double, double>> operaciones = new Dictionary<string, Func<double, double, double>>(); //Comprobar el delegado

        public Ejercicio7()
        {
            InitializeComponent();
            this.AcceptButton = btnResultado;

            this.KeyPreview = true;

            operaciones.Add(rbSuma.Text, (double a, double b) => a + b);

            operaciones.Add(rbResta.Text, (double a, double b) => a - b);

            operaciones.Add(rbMultipliacion.Text, (double a, double b) => a * b);

            operaciones.Add(rbDivision.Text, (double a, double b) => a / b);
        }
        string signo = "";

        private void focoEnRadioButton(object sender, EventArgs e)
        {

            RadioButton rb = (RadioButton)sender;

            signo = rb.Text;
            lblOperador.Text = signo;
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(txtNum1.Text, out double n1) || !double.TryParse(txtNum2.Text, out double n2))
            {
                MessageBox.Show("Solo se admiten numeros", "Error en los parametros", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                txtResultado.Text = operaciones[signo](n1, n2).ToString();
            }
        }

        private void Ejercicio7_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Quieres salir del programa?", "Salir del programa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void ModificacionTexto(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            string texto = txt.Text;

            if(!double.TryParse(texto, out double res))
            {
                txt.BackColor = Color.Red;
                txt.ForeColor = Color.White;
            }
            else
            {
                txt.BackColor = Color.White;
                txt.ForeColor = Color.DarkGreen;
            }
        }
    }
}
