namespace Ejercicio7
{
    partial class Ejercicio7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio7));
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.rbMultipliacion = new System.Windows.Forms.RadioButton();
            this.rbDivision = new System.Windows.Forms.RadioButton();
            this.rbSuma = new System.Windows.Forms.RadioButton();
            this.rbResta = new System.Windows.Forms.RadioButton();
            this.lblOperador = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNum1.ForeColor = System.Drawing.Color.White;
            this.txtNum1.Location = new System.Drawing.Point(237, 227);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 22);
            this.txtNum1.TabIndex = 4;
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum1.TextChanged += new System.EventHandler(this.ModificacionTexto);
            // 
            // txtNum2
            // 
            this.txtNum2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNum2.ForeColor = System.Drawing.Color.White;
            this.txtNum2.Location = new System.Drawing.Point(409, 225);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(109, 22);
            this.txtNum2.TabIndex = 5;
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum2.TextChanged += new System.EventHandler(this.ModificacionTexto);
            // 
            // btnResultado
            // 
            this.btnResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnResultado.ForeColor = System.Drawing.Color.White;
            this.btnResultado.Location = new System.Drawing.Point(323, 352);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(101, 38);
            this.btnResultado.TabIndex = 6;
            this.btnResultado.Text = "Resultado!";
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // rbMultipliacion
            // 
            this.rbMultipliacion.AutoSize = true;
            this.rbMultipliacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbMultipliacion.ForeColor = System.Drawing.Color.White;
            this.rbMultipliacion.Location = new System.Drawing.Point(148, 351);
            this.rbMultipliacion.Name = "rbMultipliacion";
            this.rbMultipliacion.Size = new System.Drawing.Size(33, 20);
            this.rbMultipliacion.TabIndex = 3;
            this.rbMultipliacion.TabStop = true;
            this.rbMultipliacion.Text = "*";
            this.rbMultipliacion.UseVisualStyleBackColor = false;
            this.rbMultipliacion.CheckedChanged += new System.EventHandler(this.focoEnRadioButton);
            // 
            // rbDivision
            // 
            this.rbDivision.AutoSize = true;
            this.rbDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbDivision.ForeColor = System.Drawing.Color.White;
            this.rbDivision.Location = new System.Drawing.Point(148, 309);
            this.rbDivision.Name = "rbDivision";
            this.rbDivision.Size = new System.Drawing.Size(32, 20);
            this.rbDivision.TabIndex = 2;
            this.rbDivision.TabStop = true;
            this.rbDivision.Text = "/";
            this.rbDivision.UseVisualStyleBackColor = false;
            this.rbDivision.CheckedChanged += new System.EventHandler(this.focoEnRadioButton);
            // 
            // rbSuma
            // 
            this.rbSuma.AutoSize = true;
            this.rbSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbSuma.ForeColor = System.Drawing.Color.White;
            this.rbSuma.Location = new System.Drawing.Point(148, 228);
            this.rbSuma.Name = "rbSuma";
            this.rbSuma.Size = new System.Drawing.Size(35, 20);
            this.rbSuma.TabIndex = 0;
            this.rbSuma.TabStop = true;
            this.rbSuma.Text = "+";
            this.rbSuma.UseVisualStyleBackColor = false;
            this.rbSuma.CheckedChanged += new System.EventHandler(this.focoEnRadioButton);
            // 
            // rbResta
            // 
            this.rbResta.AutoSize = true;
            this.rbResta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbResta.ForeColor = System.Drawing.Color.White;
            this.rbResta.Location = new System.Drawing.Point(148, 271);
            this.rbResta.Name = "rbResta";
            this.rbResta.Size = new System.Drawing.Size(32, 20);
            this.rbResta.TabIndex = 1;
            this.rbResta.TabStop = true;
            this.rbResta.Text = "-";
            this.rbResta.UseVisualStyleBackColor = false;
            this.rbResta.CheckedChanged += new System.EventHandler(this.focoEnRadioButton);
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOperador.ForeColor = System.Drawing.Color.White;
            this.lblOperador.Location = new System.Drawing.Point(359, 228);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(25, 16);
            this.lblOperador.TabIndex = 7;
            this.lblOperador.Text = "Op";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtResultado.ForeColor = System.Drawing.Color.White;
            this.txtResultado.Location = new System.Drawing.Point(315, 291);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(109, 22);
            this.txtResultado.TabIndex = 8;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ejercicio7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ejercicio7.Properties.Resources.luna;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 627);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.rbResta);
            this.Controls.Add(this.rbSuma);
            this.Controls.Add(this.rbDivision);
            this.Controls.Add(this.rbMultipliacion);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ejercicio7";
            this.Text = "Ejercicio7";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ejercicio7_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.RadioButton rbMultipliacion;
        private System.Windows.Forms.RadioButton rbDivision;
        private System.Windows.Forms.RadioButton rbSuma;
        private System.Windows.Forms.RadioButton rbResta;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

