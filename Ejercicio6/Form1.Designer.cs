namespace Ejercicio6
{
    partial class Ejercicio6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio6));
            this.btnAbrir = new System.Windows.Forms.Button();
            this.pnImagenes = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnAvance = new System.Windows.Forms.Button();
            this.btnRetroceso = new System.Windows.Forms.Button();
            this.lblGranImagen = new System.Windows.Forms.Label();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblDirectorio = new System.Windows.Forms.Label();
            this.pnImagenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(189, 60);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(151, 65);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir!!";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // pnImagenes
            // 
            this.pnImagenes.Controls.Add(this.toolStrip1);
            this.pnImagenes.Location = new System.Drawing.Point(84, 146);
            this.pnImagenes.Name = "pnImagenes";
            this.pnImagenes.Size = new System.Drawing.Size(380, 616);
            this.pnImagenes.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(380, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(207, 18);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(133, 16);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Cuadro de imagenes";
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(553, 222);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(488, 461);
            this.pbImagen.TabIndex = 3;
            this.pbImagen.TabStop = false;
            // 
            // btnAvance
            // 
            this.btnAvance.Location = new System.Drawing.Point(819, 124);
            this.btnAvance.Name = "btnAvance";
            this.btnAvance.Size = new System.Drawing.Size(222, 65);
            this.btnAvance.TabIndex = 2;
            this.btnAvance.Text = "Siguiente";
            this.tooltip.SetToolTip(this.btnAvance, "Se ejecuta también al pulsar la tecla derecha o la letra D en el teclado");
            this.btnAvance.UseVisualStyleBackColor = true;
            this.btnAvance.Click += new System.EventHandler(this.btnAvance_Click);
            // 
            // btnRetroceso
            // 
            this.btnRetroceso.Location = new System.Drawing.Point(553, 124);
            this.btnRetroceso.Name = "btnRetroceso";
            this.btnRetroceso.Size = new System.Drawing.Size(213, 65);
            this.btnRetroceso.TabIndex = 1;
            this.btnRetroceso.Text = "Anterior";
            this.tooltip.SetToolTip(this.btnRetroceso, "Se ejecuta también al pulsar la flecha izquierda o la letra A en el teclado");
            this.btnRetroceso.UseVisualStyleBackColor = true;
            this.btnRetroceso.Click += new System.EventHandler(this.btnRetroceso_Click);
            // 
            // lblGranImagen
            // 
            this.lblGranImagen.AutoSize = true;
            this.lblGranImagen.Location = new System.Drawing.Point(728, 18);
            this.lblGranImagen.Name = "lblGranImagen";
            this.lblGranImagen.Size = new System.Drawing.Size(139, 16);
            this.lblGranImagen.TabIndex = 6;
            this.lblGranImagen.Text = "Imagen Seleccionada";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(550, 60);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(124, 16);
            this.lblImagen.TabIndex = 7;
            this.lblImagen.Text = "Datos de la imagen";
            // 
            // lblDirectorio
            // 
            this.lblDirectorio.AutoSize = true;
            this.lblDirectorio.Location = new System.Drawing.Point(550, 84);
            this.lblDirectorio.Name = "lblDirectorio";
            this.lblDirectorio.Size = new System.Drawing.Size(65, 16);
            this.lblDirectorio.TabIndex = 8;
            this.lblDirectorio.Text = "Directorio";
            // 
            // Ejercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ejercicio6.Properties.Resources.calaverasAgrupadas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1166, 774);
            this.Controls.Add(this.lblDirectorio);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblGranImagen);
            this.Controls.Add(this.btnRetroceso);
            this.Controls.Add(this.btnAvance);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.pnImagenes);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ejercicio6";
            this.Text = "Ejercicio6";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ejercicio6_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ejercicio6_KeyDown);
            this.pnImagenes.ResumeLayout(false);
            this.pnImagenes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Panel pnImagenes;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnAvance;
        private System.Windows.Forms.Button btnRetroceso;
        private System.Windows.Forms.Label lblGranImagen;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblDirectorio;
    }
}

