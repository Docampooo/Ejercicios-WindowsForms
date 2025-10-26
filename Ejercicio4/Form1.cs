using Ejercicio4.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form//TODO label indices seleecionados. Seleccion multiple lista 1. Tooltip secundaria. Scroll titulo
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnAñadir;

            lblElementos.Text = $"Elementos de la lista 1";
            lblLista.Text = $"Seleccion lista 1 | indice";
            Text = "";

            lst1.SelectionMode = SelectionMode.MultiSimple;

            toolTip.SetToolTip(this.lst2, "No hay elementos en la lista");

            tmrTitulo.Start();
        }

        public void actualizarLabel()
        {
            lblElementos.Text = $"Elementos de la lista 1: {lst1.Items.Count}";
            for (int i = 0; i < lst1.Items.Count; i++)
            {
                if (lst1.GetSelected(i) == true)
                {
                    lblLista.Text = $"{lblElementos.Text}{Environment.NewLine}{lst1.Items[i].ToString(),20}|{lst1.Items.IndexOf(lst1.Items[i])}";
                }
            }

            if (lst2.Items.Count == 0)
            {
                toolTip.SetToolTip(this.lst2, "No hay elementos en la lista");
            }
            else
            {
                toolTip.SetToolTip(this.lst2, $"Elementos de la lista 2: {lst2.Items.Count}");
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string texto = txtAñadir.Text;

            if (texto.Length == 0 || texto == null || lst1.Items.Contains(texto))
            {
                MessageBox.Show("Introduce un texto que no pertenezca a la lista en el textBox", "Error en el texto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lst1.Items.Add(txtAñadir.Text);
            }
            actualizarLabel();
        }

        private void btnTraspasar_Click(object sender, EventArgs e)
        {
            ListBox lstEnviar;
            ListBox lstRecoger;

            lstEnviar = rbMover1.Checked ? lst1 : lst2;
            lstRecoger = rbMover1.Checked ? lst2 : lst1;

            int seleccionados = lstEnviar.SelectedIndices.Count;
            if (seleccionados == 0)
            {
                MessageBox.Show("Selecciona al menos un elemento de la lista para enviarlo", "Error en la seleccion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = lstEnviar.Items.Count - 1; i >= 0; i--)
                {
                    if (lstEnviar.GetSelected(i) == true)
                    {
                        lstRecoger.Items.Add(lstEnviar.Items[i].ToString());
                        lstEnviar.Items.RemoveAt(i);
                    }
                }
            }
            actualizarLabel();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            ListBox lst;

            lst = rbLst1.Checked ? lst1 : lst2; //seguir aqui 

            int seleccionados = lst.SelectedIndices.Count;

            if (seleccionados == 0)
            {
                MessageBox.Show("Selecciona al menos un elemento de la lista para eliminarlo", "Error en la seleccion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = lst.Items.Count - 1; i >= 0; i--)
                {
                    if (lst.GetSelected(i) == true)
                    {
                        lst.Items.RemoveAt(i);
                    }
                }
            }
            actualizarLabel();
        }

        private void rbSeleccionado(object sender, EventArgs e)
        {
            if (rbLst1.Checked)
            {
                btnQuitar.Text = "Quitar de 1";
                btnAñadir.Text = "Añadir a 1";
            }

            if (rbLst2.Checked)
            {
                btnQuitar.Text = "Quitar de 2";
                btnAñadir.Text = "Añadir a 2";

            }
        }

        int cont = -1;
        string titulo;
        string tituloInverso = "";
        int contIcono;
        bool imagen = true;


        private void tmrTitulo_Tick(object sender, EventArgs e)
        {
            titulo = "Intercambio de valores entre Listas!!!";
            for (int i = titulo.Length - 1; i >= 0; i--)
            {
                tituloInverso += titulo[i];
            }

            if (cont == titulo.Length - 1)
            {
                cont = -1;
                Text = "";

                if (imagen)
                {
                    imagen = false;
                    this.Icon = Properties.Resources.perroGafas;
                }
                else
                {
                    imagen = true;
                    this.Icon = Properties.Resources.perroOjos;
                }

            }
            else
            {
                cont++;
                Text += tituloInverso[cont];
            }
        }
    }
}
