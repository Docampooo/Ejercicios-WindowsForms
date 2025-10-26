namespace Ejercicio4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lst1 = new System.Windows.Forms.ListBox();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnTraspasar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.rbLst1 = new System.Windows.Forms.RadioButton();
            this.rbLst2 = new System.Windows.Forms.RadioButton();
            this.rbMover1 = new System.Windows.Forms.RadioButton();
            this.rbMover2 = new System.Windows.Forms.RadioButton();
            this.lblElementos = new System.Windows.Forms.Label();
            this.lblLista = new System.Windows.Forms.Label();
            this.txtAñadir = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tmrTitulo = new System.Windows.Forms.Timer(this.components);
            this.guardarElementos = new System.Windows.Forms.SaveFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.ItemHeight = 16;
            this.lst1.Location = new System.Drawing.Point(335, 192);
            this.lst1.MultiColumn = true;
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(120, 84);
            this.lst1.TabIndex = 2;
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.ItemHeight = 16;
            this.lst2.Location = new System.Drawing.Point(490, 192);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(120, 84);
            this.lst2.TabIndex = 3;
            // 
            // btnAñadir
            // 
            this.btnAñadir.AutoSize = true;
            this.btnAñadir.Location = new System.Drawing.Point(277, 303);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(109, 33);
            this.btnAñadir.TabIndex = 4;
            this.btnAñadir.Text = "Añadir";
            this.toolTip.SetToolTip(this.btnAñadir, "Agrega lo que contenga el textBox a la lista seleccionada");
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnTraspasar
            // 
            this.btnTraspasar.AutoSize = true;
            this.btnTraspasar.Location = new System.Drawing.Point(541, 303);
            this.btnTraspasar.Name = "btnTraspasar";
            this.btnTraspasar.Size = new System.Drawing.Size(127, 33);
            this.btnTraspasar.TabIndex = 6;
            this.btnTraspasar.Text = "Traspasar";
            this.toolTip.SetToolTip(this.btnTraspasar, "Traspasa el indice seleccionado de la lista seleccionada a la otra lista");
            this.btnTraspasar.UseVisualStyleBackColor = true;
            this.btnTraspasar.Click += new System.EventHandler(this.btnTraspasar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.AutoSize = true;
            this.btnQuitar.Location = new System.Drawing.Point(411, 303);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(111, 33);
            this.btnQuitar.TabIndex = 5;
            this.btnQuitar.Text = "Quitar";
            this.toolTip.SetToolTip(this.btnQuitar, "Elimina de la lista seleccionada el indice seleccionado");
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // rbLst1
            // 
            this.rbLst1.AutoSize = true;
            this.rbLst1.Checked = true;
            this.rbLst1.Location = new System.Drawing.Point(13, 13);
            this.rbLst1.Name = "rbLst1";
            this.rbLst1.Size = new System.Drawing.Size(108, 20);
            this.rbLst1.TabIndex = 0;
            this.rbLst1.TabStop = true;
            this.rbLst1.Text = "Marcar Lista1";
            this.rbLst1.UseVisualStyleBackColor = true;
            this.rbLst1.CheckedChanged += new System.EventHandler(this.rbSeleccionado);
            // 
            // rbLst2
            // 
            this.rbLst2.AutoSize = true;
            this.rbLst2.Location = new System.Drawing.Point(134, 13);
            this.rbLst2.Name = "rbLst2";
            this.rbLst2.Size = new System.Drawing.Size(108, 20);
            this.rbLst2.TabIndex = 1;
            this.rbLst2.Text = "Marcar Lista2";
            this.rbLst2.UseVisualStyleBackColor = true;
            this.rbLst2.CheckedChanged += new System.EventHandler(this.rbSeleccionado);
            // 
            // rbMover1
            // 
            this.rbMover1.AutoSize = true;
            this.rbMover1.Checked = true;
            this.rbMover1.Location = new System.Drawing.Point(38, 13);
            this.rbMover1.Name = "rbMover1";
            this.rbMover1.Size = new System.Drawing.Size(63, 20);
            this.rbMover1.TabIndex = 0;
            this.rbMover1.TabStop = true;
            this.rbMover1.Text = "1 --> 2";
            this.rbMover1.UseVisualStyleBackColor = true;
            // 
            // rbMover2
            // 
            this.rbMover2.AutoSize = true;
            this.rbMover2.Location = new System.Drawing.Point(155, 13);
            this.rbMover2.Name = "rbMover2";
            this.rbMover2.Size = new System.Drawing.Size(63, 20);
            this.rbMover2.TabIndex = 1;
            this.rbMover2.Text = "1 <-- 2";
            this.rbMover2.UseVisualStyleBackColor = true;
            // 
            // lblElementos
            // 
            this.lblElementos.AutoSize = true;
            this.lblElementos.Location = new System.Drawing.Point(139, 169);
            this.lblElementos.Name = "lblElementos";
            this.lblElementos.Size = new System.Drawing.Size(148, 16);
            this.lblElementos.TabIndex = 8;
            this.lblElementos.Text = "Elementos de la Lista 1:";
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(139, 208);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(108, 16);
            this.lblLista.TabIndex = 9;
            this.lblLista.Text = "elemento | indice";
            // 
            // txtAñadir
            // 
            this.txtAñadir.Location = new System.Drawing.Point(422, 372);
            this.txtAñadir.Name = "txtAñadir";
            this.txtAñadir.Size = new System.Drawing.Size(100, 22);
            this.txtAñadir.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbLst1);
            this.panel1.Controls.Add(this.rbLst2);
            this.panel1.Location = new System.Drawing.Point(335, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 42);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbMover1);
            this.panel2.Controls.Add(this.rbMover2);
            this.panel2.Location = new System.Drawing.Point(335, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 39);
            this.panel2.TabIndex = 1;
            // 
            // tmrTitulo
            // 
            this.tmrTitulo.Interval = 200;
            this.tmrTitulo.Tick += new System.EventHandler(this.tmrTitulo_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAñadir);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.lblElementos);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnTraspasar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.lst2);
            this.Controls.Add(this.lst1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ejercicio4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnTraspasar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.RadioButton rbLst1;
        private System.Windows.Forms.RadioButton rbLst2;
        private System.Windows.Forms.RadioButton rbMover1;
        private System.Windows.Forms.RadioButton rbMover2;
        private System.Windows.Forms.Label lblElementos;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.TextBox txtAñadir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer tmrTitulo;
        private System.Windows.Forms.SaveFileDialog guardarElementos;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

